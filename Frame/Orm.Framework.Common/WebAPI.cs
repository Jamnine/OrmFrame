using System;
using System.Collections.Generic;
using System.Linq;
using Orm.Framework.Services;
using Orm.Model;
using Orm.Model.Custom;
using Orm.Model.EnumDefine;
using Orm.Model.Parameter;

namespace Orm.Framework.Common
{
    /// <summary>
    /// 对外通用接口
    /// 返回值统一使用ReturnValue，根据需要对ReturnValue.Returns扩展
    /// </summary>
    public class WebAPI
    {
        private DBServiceBase _dbupdate = new DBServiceBase(AppSettings.ConfigUpdateDB_Key);
        private DBServiceBase _dbserver = new DBServiceBase();

        public WebAPI() { }

        /// <summary>
        /// 更新回访的记录  
        /// </summary>
        /// <param name="FollowID">ID回访记录唯一号</param>
        /// <param name="AppraiseType">满意度（即评分默认请传5）</param>
        /// <param name="BackContent">反馈内容</param>
        /// <returns></returns>
        public ReturnValue UpdateFollowInfo(string FollowID, int AppraiseType, string BackContent)
        {
            ReturnValue returnValue = new ReturnValue();
            returnValue.ErrorCode = 0;
            try
            {
                var followPatient = _dbserver.GetModelByGuid<FollowPatient>(FollowID);
                followPatient.FeedBackContent = BackContent;
                followPatient.AppRaiseType = AppraiseType;
                followPatient.FollowStatus = 1;
                if (!_dbserver.Update(followPatient))
                {
                    returnValue.ErrorCode = -1;
                    returnValue.ErrorMsg = "更新失败！";
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                returnValue.ErrorCode = -1;
                returnValue.ErrorMsg = ex.Message;
                return returnValue;
            }
        }
        /// <summary>
        /// 获取未使用的IIS信息
        /// </summary>
        /// <param name="Code"></param>
        /// <returns></returns>
        public ReturnValue GetViewCustomer(string Code)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var customer = _dbupdate.DataRepository.GetQueryable<Customer>();
                var date = DateTime.Now.Date;
                var query = from er in customer
                            where er.IsActive
                            && !er.IsStartUsing
                            && er.StartUsingDate.Date != date
                            orderby er.GUID ascending
                            select er;
                var lstCustomer = query.Take(10).ToList();
                Random rad = new Random();
                var currIndex = rad.Next(0, lstCustomer.Count - 1);
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = new
                {
                    ID = lstCustomer[currIndex].GUID,
                    IisUrl = lstCustomer[currIndex].IisUrl,
                    CustomerGuid = lstCustomer[currIndex].CustomerGuid,
                    Code = lstCustomer[currIndex].Code
                };

                //修改使用时间防止被重复使用
                lstCustomer[currIndex].StartUsingDate = DateTime.Now;
                _dbupdate.Update(lstCustomer[currIndex]);

                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
                return returnvalue;
            }

        }


        #region 预约接口 

        /// <summary>
        /// 获取医生出诊信息列表
        /// </summary>
        /// <MethodName="GetDaySchedule">接口方法名：GetDaySchedule</MethodName>
        /// <param name="DocUserCode">医生用户名（手机号码），可为空，空则查所有医生</param>
        /// <param name="StartTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <returns>ErrorCode=0则成功，返回的Returns是List<uspOuDayScheduleDtlQry></returns>
        public ReturnValue GetDaySchedule(string DocUserCode, string StartTime, string EndTime)
        {
            var startTime = Convert.ToDateTime(StartTime);
            var endTime = Convert.ToDateTime(EndTime);
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var ouDaySchedule = _dbserver.DataRepository.GetQueryable<OuDaySchedule>();
                var ouDayScheduleDtl = _dbserver.DataRepository.GetQueryable<OuDayScheduleDtl>();
                var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsRegTimeSpan = _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var bsDiagRoom = _dbserver.DataRepository.GetQueryable<BsDiagRoom>();

                var query = from ouday in ouDaySchedule
                            join ouDayDtl in ouDayScheduleDtl on ouday.GUID equals ouDayDtl.ScheduleID
                            join buser in bsUser on ouday.DoctorId equals buser.GUID into buserEmpty
                            from buser in buserEmpty.DefaultIfEmpty()
                            join bsloc in bsLocation on ouday.HospitalId.ToString() equals bsloc.GUID into bslocEmpty
                            from bsloc in bslocEmpty.DefaultIfEmpty()
                            join bsreg in bsRegTimeSpan on ouday.TimeSpanId equals bsreg.GUID into bsPatEmpty
                            from bsreg in bsPatEmpty.DefaultIfEmpty()
                            join bsregSub in bsRegSpanSub on ouDayDtl.TimeSpanSubID equals bsregSub.GUID into bsregSubEmpty
                            from bsregSub in bsregSubEmpty.DefaultIfEmpty()
                            join bsDiag in bsDiagRoom on ouday.DoctorId equals bsDiag.LocationId.ToString() into bsDiagRoomEmpty
                            from bsDiag in bsDiagRoomEmpty.DefaultIfEmpty()
                            where (DocUserCode.Trim() == string.Empty)
                            && ouday.ScheduleDate >= startTime.Date
                            && ouday.ScheduleDate < endTime.Date
                            && ouday.IsActive
                            && ouday.IsDoctor == 1
                            select new uspOuDayScheduleDtlQry
                            {
                                BookedNum = (from ouhos in ouHosInfo where ouhos.IsHide == false && ouday.HospitalId.ToString() == ouhos.RegDept && ouday.DoctorId == ouhos.DoctorId && ouhos.OperTime.Date == ouday.ScheduleDate.Date && ouday.TimeSpanId == ouhos.TimeSpanId && ouDayDtl.TimeSpanSubID == ouhos.TimeSpanSubId && ouhos.IsPreReg && !ouhos.IsCancel select new { ID = ouhos.GUID }).Count(),

                                TimeSpanName = bsreg.Name,
                                DoctorName = buser.Name,
                                LocationName = bsloc.Name,
                                DiagRoomName = bsDiag.Name,
                                DoctorId = ouday.DoctorId,
                                RegTypeId = ouday.RegTypeId,
                                TimeSpanId = ouday.TimeSpanId,
                                LocationId = ouday.HospitalId.ToString(),
                                DiagRoomID = ouday.DiagRoomID,
                                TotalNum = ouday.TotalNum,
                                IsStop = ouday.IsStop,
                                BookLimitNum = ouDayDtl.BooklimitNum,
                                ScheduleDate = ouday.ScheduleDate.Date,
                                ScheduleId = ouday.GUID,
                                ScheduleDtlId = ouDayDtl.GUID,
                                TimeSpanSubId = ouDayDtl.TimeSpanSubID,
                                TimeSpanSubName = bsreg.Name + " " + bsregSub.TimeBegin + "~" + bsregSub.TimeEnd,
                            };
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = query.ToList();
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "获取排班数据异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 网站预约
        /// </summary>
        /// <MethodName="MakeAppointment">接口方法名：MakeAppointment</MethodName>
        /// <param name="RegNo">预约流水号（由网站端产生）</param>
        /// <param name="UserCode">病人用户名（注册的手机号码）</param>
        /// <param name="Name">姓名</param>
        /// <param name="Mobile">手机号码</param>
        /// <param name="Sex">性别</param>
        /// <param name="Birthdate">出生日期</param>
        /// <param name="BookingPurpose">预约就诊目的</param>
        /// /// <param name="CnBookingPurpose">预约就诊目的（中文）</param>
        /// <param name="Comment">其他备注</param>
        /// <param name="ScheduleID">医生排班ID</param>
        /// <param name="ScheduleDtlID">时段号表ID</param>
        /// <returns>ErrorCode=0则成功，-1则预约出错</returns>
        //public ReturnValue MakeAppointment(string RegNo, string UserCode, string Name, string Mobile, string Sex, string Birthdate, string BookingPurpose, string CnBookingPurpose, string Comment, int ScheduleID, int ScheduleDtlID)
        //{ 
        //    var birthdate = Convert.ToDateTime(Birthdate);
        //    ReturnValue returnvalue = new ReturnValue(); 
        //    string MzRegNo = "";//预约流水号
        //    try
        //    {
        //        Action action = delegate
        //        {

        //            if (RegNo.Trim() == string.Empty)
        //            {
        //                returnvalue.ErrorCode = -1;
        //                returnvalue.ErrorMsg = "预约失败：预约流水号为空，请重新生成！";
        //                return ;
        //            }
        //            else
        //            { 
        //                var hos = _dbserver.GetList<OuHosInfo>(t=>t.MzRegNo == RegNo &&t.IsHide==false ); 
        //                if (hos.Count > 0)
        //                {
        //                    returnvalue.ErrorCode = -1;
        //                    returnvalue.WarningMsg = "预约失败：您已预约！";
        //                    return;
        //                }
        //            } 
        //            var currentDateTime = _dbserver.GetServerTime(); 
        //            var isNewPatient = false; 
        //            //判断病人是否建档，不存在则自动建档 
        //            BsPatient bsPatientInfo = _dbserver.GetList<BsPatient>(t=>t.WebUserCode == UserCode && t.IsHide==false).LastOrDefault(); 
        //            if (bsPatientInfo == null)
        //            {
        //                bsPatientInfo = new BsPatient
        //                { 
        //                    CardNo = ServiceTaker.GetService<ICodeService>().Next(((int)EnumSequenceNumType.CarNo).ToString()).ToString(),
        //                    OperTime = currentDateTime, 
        //                    IsActive = true, 
        //                    ModiTime = currentDateTime,
        //                    Name = Name,
        //                    BirthDate = birthdate,
        //                    Sex = Sex,
        //                    Mobile = Mobile,
        //                    PatTypeId =116,// Orm.Config.UtilsLocCache.GetCacheEntity<BsPatType>(t=>t.Code == "01").GUID,//TODO 自费 
        //                    WebUserCode = UserCode
        //                }; 
        //               bsPatientInfo.GUID= _dbserver.Add(bsPatientInfo); 
        //               isNewPatient = true;
        //            }
        //            if (bsPatientInfo.GUID > 0) //存在病人
        //            { 
        //                OuDaySchedule ouDayScheduleInfo = _dbserver.GetModelByGuid<OuDaySchedule>(ScheduleID);
        //                if (ouDayScheduleInfo.IsStop || !ouDayScheduleInfo.IsActive)
        //                {
        //                    returnvalue.ErrorCode = -1;
        //                    returnvalue.WarningMsg = "预约失败：该医生此班次已停诊，请选择其他班次试试！";
        //                    return;
        //                }
        //                OuDayScheduleDtl  ouDayScheduleDtlInfo = _dbserver.GetModelByGuid<OuDayScheduleDtl>(ScheduleDtlID); 
        //                if (ouDayScheduleInfo.ScheduleDate <= _dbserver.GetServerTime().Date)
        //                {
        //                    returnvalue.ErrorCode = -1;
        //                    returnvalue.WarningMsg = "预约失败：该预约时段已过期，请选择其他班次试试！";
        //                    return;
        //                }
        //                //非新病人判断是否重复预约
        //                if (!isNewPatient)
        //                {

        //                    var ouhos = _dbserver.GetList<OuHosInfo>(t => t.PatId == bsPatientInfo.GUID && t.OperTime.Date == ouDayScheduleInfo.ScheduleDate.Date && t.DoctorId == ouDayScheduleInfo.DoctorId && t.TimeSpanId == ouDayScheduleInfo.TimeSpanId && t.IsPreReg && t.IsCancel == 0 && t.IsHide==false);
        //                    if (ouhos.Count > 0)
        //                    {
        //                        returnvalue.ErrorCode = -1;
        //                        returnvalue.WarningMsg = "预约失败：您已经预约过当前医生的当前班次，不能重复预约，请选择其他班次试试！"; 
        //                        return;
        //                    }
        //                }
        //                //判断是否能够预约
        //                int bookedCount = _dbserver.GetList<OuHosInfo>(t => t.DoctorId == ouDayScheduleInfo.DoctorId && t.RegDept == ouDayScheduleInfo.HospitalID && t.TimeSpanSubId == ouDayScheduleDtlInfo.TimeSpanSubID && t.IsPreReg && t.IsCancel == 0&&t.IsHide==false).Count();
        //                if (bookedCount < ouDayScheduleDtlInfo.BooklimitNum)
        //                {
        //                    var age =  currentDateTime.Date.Year - birthdate.Year;
        //                    if (RegNo.Trim() == string.Empty)
        //                        MzRegNo = ServiceTaker.GetService<ICodeService>().Next(((int)EnumSequenceNumType.MzReg).ToString()).ToString();
        //                    else
        //                        MzRegNo = RegNo;
        //                    var ouHosInfo = new OuHosInfo
        //                    {
        //                        MzRegNo = MzRegNo,
        //                        CardNo = bsPatientInfo.CardNo,
        //                        PatId = bsPatientInfo.GUID,
        //                        Name = bsPatientInfo.Name,
        //                        Sex = bsPatientInfo.Sex,
        //                        BookingTel = Mobile,
        //                        CnBookingPurpose = CnBookingPurpose,
        //                        BookingPurpose = BookingPurpose,
        //                        Comments = Comment,
        //                        AgeString = age.ToString() + "岁",
        //                        PatTypeId = bsPatientInfo.PatTypeId,
        //                        IsPreReg = true,
        //                        OperTime = ouDayScheduleInfo.ScheduleDate,
        //                        RegTime = DateTime.MinValue,
        //                        DoctorId = ouDayScheduleInfo.DoctorId,
        //                        RegDept = ouDayScheduleInfo.HospitalID,
        //                        TimeSpanId = ouDayScheduleInfo.TimeSpanId,
        //                        TimeSpanSubId = ouDayScheduleDtlInfo.TimeSpanSubID,
        //                        RegTypeId = ouDayScheduleInfo.RegTypeId,
        //                        ISInputBYRegMAN = true,
        //                        PyCode =Orm.Utilities.PyWbHelper.SixBitPYCode(bsPatientInfo.Name),
        //                        WbCode = Orm.Utilities.PyWbHelper.SixBitWBCode(bsPatientInfo.Name),
        //                        OperTime = currentDateTime
        //                    };
        //                    var id = _dbserver.Add(ouHosInfo);
        //                    if (id > 0)
        //                    {
        //                        returnvalue.ErrorCode = 0;
        //                        returnvalue.Returns = MzRegNo; 
        //                    }
        //                }
        //                else
        //                {  
        //                    returnvalue.ErrorCode = -1;
        //                    returnvalue.WarningMsg = "预约失败：该医生该时间段已预约满，请换其他时间段试试！";
        //                }

        //            }
        //            else
        //            { 
        //                returnvalue.ErrorCode = -1;
        //                returnvalue.WarningMsg = "预约失败：自动建档保存失败，请重新试试。";
        //            } 

        //        };
        //        _dbserver.Commit(action); 

        //        return returnvalue;

        //        //returnvalue.Returns = query.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        //AppLogger.Log("结束：" + DateTime.Now.ToString());
        //        returnvalue.ErrorCode = -1;
        //        returnvalue.ErrorMsg = "预约操作异常。详细信息：" + ex.Message + Environment.NewLine + ex.StackTrace;
        //        return returnvalue;
        //    }
        //}

        /// <summary>
        /// 网站取消预约
        /// </summary>
        /// <MethodName="CancelAppointment">接口方法名：CancelAppointment</MethodName>
        /// <param name="MzRegNo">预约流水号</param>
        /// <returns>ErrorCode=0则成功，-1则取消出错</returns>
        public ReturnValue CancelAppointment(string MzRegNo)
        {
            ReturnValue returnvalue = new ReturnValue();
            var currentTime = _dbserver.GetServerTime();
            try
            {
                var ouHosInfo = _dbserver.GetList<OuHosInfo>(t => t.MzRegNo == MzRegNo && t.IsPreReg && t.IsHide == false).FirstOrDefault();
                if (ouHosInfo != null)
                {
                    if (ouHosInfo.OperTime.Date <= currentTime.Date)
                    {
                        returnvalue.WarningMsg = "取消预约失败！预约信息过期，不允许取消！";
                        returnvalue.ErrorCode = -1;
                        return returnvalue;
                    }
                    ouHosInfo.IsCancel = true;
                    ouHosInfo.CancelTime = currentTime;
                    _dbserver.Update(ouHosInfo);
                }
                returnvalue.ErrorMsg = string.Empty;
                returnvalue.ErrorCode = 0;
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "取消预约异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 预约信息查询
        /// </summary>
        /// <MethodName="CancelAppointment">接口方法名：SearchAppointment</MethodName>
        /// <param name="BeginTime">开始日期</param>
        /// <param name="EndTime">结束日期</param>
        /// <param name="UserCode">用户Code（手机号码）,传空则查询所有</param>
        /// <returns></returns>
        public ReturnValue SearchAppointment(string BeginTime, string EndTime, string UserCode)
        {
            var startTime = Convert.ToDateTime(BeginTime);
            var endTime = Convert.ToDateTime(EndTime);
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsRegTimeSpan = _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var bsDiagRoom = _dbserver.DataRepository.GetQueryable<BsDiagRoom>();

                var query = from hos in ouHosInfo
                            join bspat in bsPatient on hos.PatId equals bspat.GUID
                            join span in bsRegSpanSub on hos.TimeSpanSubId equals span.GUID into spanEmpty
                            from span in spanEmpty.DefaultIfEmpty()
                            join doc in bsUser on hos.DoctorId equals doc.GUID into docEmpty
                            from doc in docEmpty.DefaultIfEmpty()
                            join location in bsLocation on hos.RegDept equals location.GUID into locationEmpty
                            from location in locationEmpty.DefaultIfEmpty()
                            join bsDiag in bsDiagRoom on hos.RegDept equals bsDiag.GUID into bsDiagEmpty
                            from bsDiag in bsDiagEmpty.DefaultIfEmpty()
                            where bspat.IsHide == false && hos.IsHide == false && (UserCode.Trim() == "" || bspat.WebUserCode == UserCode) && hos.OperTime >= startTime.Date && hos.OperTime <= endTime.Date && hos.IsPreReg
                            select new uspBookedInfoQry()
                            {
                                UserCode = bspat.WebUserCode,
                                CardNo = hos.CardNo,
                                Mobile = hos.ContactPhone,
                                RegID = hos.GUID,
                                RegNo = hos.MzRegNo,
                                PatID = hos.PatId,
                                Name = hos.Name,
                                Sex = hos.Sex,
                                Age = hos.AgeString,
                                RegTime = hos.OperTime.ToString("yyyy-MM-dd"),
                                TimeSpanSubName = span.TimeBegin + "~" + span.TimeEnd,
                                //CnBookingPurpose = hos.CnBookingPurpose,
                                Comment = hos.Memo,
                                DoctorName = doc.Name,
                                LocationName = location.Name,
                                DiagRoomName = bsDiag.Name,
                                LsDiagType = hos.LsDiagType==true?1:2,
                                VisitContent = hos.VisitContent,
                                OperTime = hos.OperTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                VisitStatus = hos.RegTime != DateTime.MinValue ? 2 : hos.IsCancel?1:0
                            };

                returnvalue.ErrorCode = 0;
                returnvalue.Returns = query.ToList().OrderByDescending(t => t.RegTime).ThenBy(t => t.TimeSpanSubName).ToList();
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约信息查询异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 预约信息查询(医生)
        /// </summary>
        /// <MethodName="CancelAppointment">接口方法名：SearchAppointmentByDoctor</MethodName>
        /// <param name="BeginTime">开始日期</param>
        /// <param name="EndTime">结束日期</param>
        /// <param name="DoctorUserCode">医生Code（手机号码）,传空则查询所有</param>
        /// <returns></returns>
        public ReturnValue SearchAppointmentByDoctor(string BeginTime, string EndTime, string DoctorUserCode)
        {
            var startTime = Convert.ToDateTime(BeginTime);
            var endTime = Convert.ToDateTime(EndTime);
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsRegTimeSpan = _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var bsDiagRoom = _dbserver.DataRepository.GetQueryable<BsDiagRoom>();

                var query = from hos in ouHosInfo
                            join bspat in bsPatient on hos.PatId equals bspat.GUID
                            join span in bsRegSpanSub on hos.TimeSpanSubId equals span.GUID into spanEmpty
                            from span in spanEmpty.DefaultIfEmpty()
                            join doc in bsUser on hos.DoctorId equals doc.GUID into docEmpty
                            from doc in docEmpty.DefaultIfEmpty()
                            join location in bsLocation on hos.RegDept equals location.GUID into locationEmpty
                            from location in locationEmpty.DefaultIfEmpty()
                            join bsDiag in bsDiagRoom on hos.RegDept equals bsDiag.GUID into bsDiagEmpty
                            from bsDiag in bsDiagEmpty.DefaultIfEmpty()
                            where bspat.IsHide == false && hos.IsHide == false && (DoctorUserCode.Trim() == "") && hos.OperTime >= startTime.Date && hos.OperTime <= endTime.Date && hos.IsPreReg
                            select new uspBookedInfoQry()
                            {
                                UserCode = bspat.WebUserCode,
                                CardNo = hos.CardNo,
                                Mobile = hos.ContactPhone,
                                RegID = hos.GUID,
                                RegNo = hos.MzRegNo,
                                PatID = hos.PatId,
                                Name = hos.Name,
                                Sex = hos.Sex,
                                Age = hos.AgeString,
                                RegTime = hos.OperTime.ToString("yyyy-MM-dd"),
                                TimeSpanSubName = span.TimeBegin + "~" + span.TimeEnd,
                                //CnBookingPurpose = hos.CnBookingPurpose,
                                Comment = hos.Memo,
                                DoctorName = doc.Name,
                                LocationName = location.Name,
                                DiagRoomName = bsDiag.Name,
                                // IsReturnVisit = hos.IsReturnVisit,
                                LsDiagType = hos.LsDiagType==true?1:2,
                                VisitContent = hos.VisitContent,
                                OperTime = hos.OperTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                VisitStatus = hos.RegTime != DateTime.MinValue ? 2 : hos.IsCancel ? 1 : 0
                            };

                returnvalue.ErrorCode = 0;
                returnvalue.Returns = query.ToList().OrderByDescending(t => t.RegTime).ThenBy(t => t.TimeSpanSubName).ToList();
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约信息查询异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        ///// <summary>
        ///// 就诊目的基础数据查询
        ///// </summary>
        ///// <MethodName="CancelAppointment">接口方法名：GetBookingPurpose</MethodName> 
        ///// <param name="Key">传空</param>
        ///// <returns></returns>
        //public ReturnValue GetBookingPurpose(string Key)
        //{
        //    ReturnValue returnvalue = new ReturnValue();
        //    try
        //    {
        //        var bsObjective = _dbserver.DataRepository.GetQueryable<BsObjective>();

        //        var query = from bsObj in bsObjective 
        //                    where bsObj.IsActive
        //                    select new BsData  ()
        //                    {
        //                         ID= bsObj.GUID,
        //                         Name=bsObj.Name
        //                    };

        //        returnvalue.ErrorCode = 0;
        //        returnvalue.Returns = query.ToList();
        //        return returnvalue;
        //    }
        //    catch (Exception ex)
        //    {
        //        returnvalue.ErrorCode = -1;
        //        returnvalue.ErrorMsg = "就诊目的基础数据查询异常。详细信息：" + ex.Message;
        //        return returnvalue;
        //    }
        //}

        #region 同步数据

        /// <summary>
        /// 获取省信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllProvince(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsAreaProvince>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "省信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取市/县信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllRegion(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsAreaRegion>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "省信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取区/县信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllArea(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsArea>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "区/县信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取诊所信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllLocation(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var linq = from loc in _dbserver.DataRepository.GetQueryable<BsHospital>()
                           join pro in _dbserver.DataRepository.GetQueryable<BsAreaProvince>() on loc.ProvinceId equals pro.GUID into proEmpty
                           from pro in proEmpty.DefaultIfEmpty()
                           join reg in _dbserver.DataRepository.GetQueryable<BsAreaRegion>() on loc.RegionId equals reg.GUID into regEmpty
                           from reg in regEmpty.DefaultIfEmpty()
                           join are in _dbserver.DataRepository.GetQueryable<BsArea>() on loc.AreaId equals are.GUID into areEmpty
                           from are in areEmpty.DefaultIfEmpty()
                           select new uspBsLocation
                           {
                               GuId = loc.GUID,
                               Name = loc.Name,
                               EngDesc = loc.EngDesc,
                               ProvinceID = loc.ProvinceId,
                               Province = pro.Name,
                               RegionID = loc.RegionId,
                               Region = reg.Name,
                               AreaID = loc.AreaId,
                               Area = are.Name,
                               Address = loc.Address,
                               Phone = loc.Phone,
                               IsActive = loc.IsActive
                           };
                returnvalue.Returns = linq.ToList();//_dbserver.GetAllList<BsLocation>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "诊所信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取职衔信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllTitle(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsDocLevel>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "职衔信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取门诊类别信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllRegType(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsRegType>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "门诊类别信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取科室信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllDepartment(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
               // returnvalue.Returns = _dbserver.GetAllList<BsDepartment>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "科室信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取可登录诊所信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllUserLocation(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsUserLocation>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "可登录诊所信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取医生信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllUser(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var linq = from user in _dbserver.DataRepository.GetQueryable<BsUser>()
                           join photo in _dbserver.DataRepository.GetQueryable<BsUserPhoto>() on user.GUID equals photo.UserId into photoEmpty
                           from photo in photoEmpty.DefaultIfEmpty()
                           join lv in _dbserver.DataRepository.GetQueryable<BsDocLevel>() on user.DocLevId equals lv.GUID into lvEmpty
                           from lv in lvEmpty.DefaultIfEmpty()
                           where user.IsRecipe
                           select new uspBsUser
                           {
                               GuId = user.GUID,
                               BirthDate = user.BirthDate,
                               Sex = user.Sex,
                               Specialty = photo.Specialty,
                               Introduce = photo.IntroDuce,
                               Picture = photo.PictureSource,
                               Code = user.Code,
                               LocationID = user.LocationId,
                               TitleID = user.DocLevId,
                               Title = lv.Name,
                               Mobile = user.Mobile,
                               RegTypeID = user.RegTypeId,
                               Name = user.Name,
                               DepartmentID = user.DepartmentId,
                               IsActive = user.IsActive
                           };
                returnvalue.Returns = linq.ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "医生信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取班次信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllTimeSpan(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsRegTimeSpan>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "班次信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取时段信息
        /// </summary>
        /// <param name="Token">授权码</param>
        /// <returns></returns>
        public ReturnValue GetAllSpanSub(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetAllList<BsRegSpanSub>();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "时段信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取会员消费信息
        /// </summary>
        /// <param name="Token"></param>
        /// <returns></returns>
        public ReturnValue GetAllRecharge(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var linq = from rec in _dbserver.DataRepository.GetQueryable<OuRecharge>()
                           select new
                           {
                               VipCardNO = rec.CardNo,
                               ChangeAmt = rec.OperType == 0 ? rec.Income : (rec.OperType == 1 ? -rec.PayOut : (rec.OperType == 2 ? rec.Income : -rec.PayOut)),
                               Balance = rec.Balance,
                               OperTime = rec.OperTime.ToString("yyyy-MM-dd"),
                               Comments = rec.Comments,
                               PatID = rec.PatID
                           };
                //returnvalue.Returns = _dbserver.GetAllList<OuRecharge>();
                returnvalue.Returns = linq.ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "会员消费信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        #endregion

        /// <summary>
        /// 获取排班信息
        /// </summary>
        /// <param name="BeginDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <returns></returns>
        public ReturnValue GetSchedule(string BeginDate, string EndDate)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                DateTime beginDate = Convert.ToDateTime(BeginDate);
                DateTime endDate = Convert.ToDateTime(EndDate);
                var linq = from scheduleDtl in _dbserver.DataRepository.GetQueryable<OuDayScheduleDtl>()
                           join spanSub in _dbserver.DataRepository.GetQueryable<BsRegSpanSub>() on scheduleDtl.TimeSpanSubID equals spanSub.GUID
                           join schedule in _dbserver.DataRepository.GetQueryable<OuDaySchedule>() on scheduleDtl.ScheduleID equals schedule.GUID
                           join timeSpan in _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>() on schedule.TimeSpanId equals timeSpan.GUID
                           where scheduleDtl.BooklimitNum > 0
                           && spanSub.IsActive
                           && schedule.ScheduleDate.Date >= beginDate.Date
                           && schedule.ScheduleDate.Date <= endDate.Date
                           && schedule.IsActive
                           && !schedule.IsStop
                           && schedule.BookLimitNum > 0
                           && timeSpan.IsActive
                           select new UspOuDaySchedule
                           {
                               InfoID = schedule.GUID,
                               LocationID = schedule.HospitalId.ToString(),
                               ScheduleDate = schedule.ScheduleDate,
                               TimeSpanId = schedule.TimeSpanId,
                               UserID = schedule.DoctorId,
                               DtlID = scheduleDtl.GUID,
                               TimeSpanSubID = scheduleDtl.TimeSpanSubID,
                               RestNum = scheduleDtl.BooklimitNum - (from hos in _dbserver.DataRepository.GetQueryable<OuHosInfo>()
                                                                     where DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeBegin) <= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeBegin)
                                                                     && DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeEnd) >= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeEnd)
                                                                     && hos.DoctorId == schedule.DoctorId
                                                                     && hos.RegDept == schedule.HospitalId.ToString()
                                                                     && !hos.IsCancel
                                                                     select hos.GUID).Count(),
                               IsStop = schedule.IsStop,
                               IsActive = schedule.IsActive
                           };
                returnvalue.Returns = linq.ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "值班信息获取异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 获取排班信息(分组)
        /// </summary>
        /// <param name="BeginDate">开始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <returns></returns>
        public ReturnValue GetScheduleGroup(string BeginDate, string EndDate)
        {
            ReturnValue returnvalue = new ReturnValue();
            List<uspDaySchedule> list = new List<uspDaySchedule>();
            try
            {
                DateTime beginDate = Convert.ToDateTime(BeginDate);
                DateTime endDate = Convert.ToDateTime(EndDate);
                var linq = from scheduleDtl in _dbserver.DataRepository.GetQueryable<OuDayScheduleDtl>()
                           join spanSub in _dbserver.DataRepository.GetQueryable<BsRegSpanSub>() on scheduleDtl.TimeSpanSubID equals spanSub.GUID
                           join schedule in _dbserver.DataRepository.GetQueryable<OuDaySchedule>() on scheduleDtl.ScheduleID equals schedule.GUID
                           join timeSpan in _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>() on schedule.TimeSpanId equals timeSpan.GUID
                           where scheduleDtl.BooklimitNum > 0
                           && spanSub.IsActive
                           && schedule.ScheduleDate.Date >= beginDate.Date
                           && schedule.ScheduleDate.Date <= endDate.Date
                           && schedule.IsActive
                           && !schedule.IsStop
                           && schedule.BookLimitNum > 0
                           && timeSpan.IsActive
                           select new UspOuDaySchedule
                           {
                               InfoID = schedule.GUID,
                               LocationID = schedule.HospitalId.ToString(),
                               ScheduleDate = schedule.ScheduleDate,
                               TimeSpanId = schedule.TimeSpanId,
                               UserID = schedule.DoctorId,
                               DtlID = scheduleDtl.GUID,
                               TimeSpanSubID = scheduleDtl.TimeSpanSubID,
                               RestNum = scheduleDtl.BooklimitNum - (from hos in _dbserver.DataRepository.GetQueryable<OuHosInfo>()
                                                                     where DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeBegin) <= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeBegin)
                                                                     && DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeEnd) >= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeEnd)
                                                                     && hos.DoctorId == schedule.DoctorId
                                                                     && hos.RegDept == schedule.HospitalId.ToString()
                                                                     && !hos.IsCancel
                                                                     select hos.GUID).Count(),
                               IsStop = schedule.IsStop,
                               IsActive = schedule.IsActive
                           };
                var dtlList = linq.ToList();
                var groupList = dtlList.GroupBy(t => t.InfoID, t => t);
                foreach (var groupItem in groupList)
                {
                    List<UspOuDaySchedule> itemList = groupItem.ToList<UspOuDaySchedule>();
                    UspOuDaySchedule infoItem = itemList.Find(t => t.InfoID == groupItem.Key);
                    uspDaySchedule info = new uspDaySchedule();
                    info.DayScheduleInfo = new uspOuDaySchedule
                    {
                        GuId = infoItem.InfoID,
                        LocationID = infoItem.LocationID,
                        ScheduleDate = infoItem.ScheduleDate.ToString("yyyy-MM-dd"),
                        TimeSpanId = infoItem.TimeSpanId,
                        UserID = infoItem.UserID,
                        IsStop = infoItem.IsStop,
                        IsActive = infoItem.IsActive
                    };
                    info.DayScheduleDtl = itemList.Select(t => new uspOuDayScheduleDtl { ID = t.DtlID, ScheduleID = t.InfoID, TimeSpanSubID = t.TimeSpanSubID, RestNum = t.RestNum }).ToList();
                    //foreach (var item in itemList)
                    //{
                    //    uspOuDayScheduleDtl dtlInfo = new uspOuDayScheduleDtl
                    //    {
                    //        ID = item.DtlID,
                    //        ScheduleID = item.InfoID,
                    //        TimeSpanSubID = item.TimeSpanSubID,
                    //        RestNum = item.RestNum
                    //    };
                    //    info.DayScheduleDtl.Add(dtlInfo);
                    //}
                    list.Add(info);
                }
                returnvalue.Returns = list;
                returnvalue.ErrorCode = 0;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "值班信息查询异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <param name="Name">姓名</param>
        /// <param name="Mobile">电话</param>
        /// <param name="Sex">性别</param>
        /// <param name="Birthdate">出生日期</param>
        /// <returns></returns>
        public ReturnValue DoRegister(string UserCode, string Name, string Mobile, string Sex, string Birthdate)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                Name = Name.Trim();
                Mobile = Mobile.Trim();
                if (string.IsNullOrEmpty(Name))
                {
                    returnvalue.WarningMsg = "注册失败：请填写姓名！";
                    returnvalue.ErrorCode = 1;
                    return returnvalue;
                }
                if (string.IsNullOrEmpty(Mobile))
                {
                    returnvalue.WarningMsg = "注册失败：请填写联系电话号码！";
                    returnvalue.ErrorCode = 1;
                    return returnvalue;
                }
                DateTime now = DateTime.Now;
                if (Convert.ToDateTime(Birthdate).Date > now.Date)
                {
                    returnvalue.WarningMsg = "注册失败：出生日期不能大于今天！";
                    returnvalue.ErrorCode = 1;
                    return returnvalue;
                }
                Action action = delegate ()
                {
                    var isNewPatient = false;
                    BsPatient bsPatient = null;
                    var list = _dbserver.GetList<BsPatient>(t => (t.Mobile == Mobile || t.Phone == Mobile) && t.Name == Name);
                    if (list.Count > 1)
                    {
                        bsPatient = list.Find(t => t.WebUserCode == UserCode);
                        if (bsPatient == null)
                        {
                            bsPatient = list.FirstOrDefault();
                        }
                    }
                    else if (list.Count == 1)
                    {
                        bsPatient = list.FirstOrDefault();
                    }
                    else //新建档案
                    {
                        bsPatient = new BsPatient
                        {
                            CardNo = ServiceTaker.GetService<ICodeService>().Next(((int)EnumSequenceNumType.CarNo).ToString()).ToString(),
                            OperTime = now,
                            IsActive = true,
                            ModiTime = now,
                            Name = Name,
                            BirthDate = Convert.ToDateTime(Birthdate).Date,
                            Age = now.Year - Convert.ToDateTime(Birthdate).Date.Year,
                            AgeStr = (now.Year - Convert.ToDateTime(Birthdate).Date.Year).ToString(),
                            Sex = Sex,
                            Mobile = Mobile,
                            PatTypeId = "116",// Orm.Config.UtilsLocCache.GetCacheEntity<BsPatType>(t=>t.Code == "01").GUID,//TODO 自费 
                            WebUserCode = UserCode
                        };
                        bsPatient.GUID = _dbserver.Add(bsPatient);
                        returnvalue.ErrorCode = 0;
                        isNewPatient = true;
                    }
                    if (!isNewPatient)
                    {
                        bsPatient.WebUserCode = UserCode;
                        bsPatient.Sex = Sex;
                        bsPatient.Mobile = Mobile;
                        bsPatient.BirthDate = Convert.ToDateTime(Birthdate).Date;
                        bsPatient.Age = now.Year - Convert.ToDateTime(Birthdate).Date.Year;
                        bsPatient.IsActive = true;
                        bsPatient.IsHide = false;
                        _dbserver.Update(bsPatient);
                        returnvalue.WarningMsg = "注册失败：账号已存在！";
                        returnvalue.ErrorCode = 0;
                    }
                };
                _dbserver.Commit(action);
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "注册操作异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="CustomerID">病人ID</param>
        /// <param name="ScheduleDtlID">排班细表ID</param>
        /// <returns></returns>
        public ReturnValue MakeAppointment(string CustomerID, string ScheduleDtlID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                string patID = CustomerID;
                string dtlID = ScheduleDtlID;
                if (!string.IsNullOrWhiteSpace(patID) && !string.IsNullOrWhiteSpace(dtlID))
                {
                    var patInfo = _dbserver.GetModelByGuid<BsPatient>(patID);
                    if (patInfo != null && !string.IsNullOrWhiteSpace(patInfo.GUID))
                    {
                        var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                        var linq = from scheduleDtl in _dbserver.DataRepository.GetQueryable<OuDayScheduleDtl>()
                                   join spanSub in _dbserver.DataRepository.GetQueryable<BsRegSpanSub>() on scheduleDtl.TimeSpanSubID equals spanSub.GUID
                                   join schedule in _dbserver.DataRepository.GetQueryable<OuDaySchedule>() on scheduleDtl.ScheduleID equals schedule.GUID
                                   join timeSpan in _dbserver.DataRepository.GetQueryable<BsRegTimeSpan>() on schedule.TimeSpanId equals timeSpan.GUID
                                   where scheduleDtl.GUID == dtlID && scheduleDtl.BooklimitNum > 0 && spanSub.IsActive && schedule.IsDoctor == 1 && schedule.IsActive && !schedule.IsStop && timeSpan.IsActive
                                   select new
                                   {
                                       LocationID = schedule.HospitalId,
                                       DoctorID = schedule.DoctorId,
                                       DiagRoomID = schedule.DiagRoomID,
                                       ScheduleDate = schedule.ScheduleDate,
                                       TimeBegin = spanSub.TimeBegin,
                                       TimeEnd = spanSub.TimeEnd,
                                       BookTotalNum = scheduleDtl.BooklimitNum,
                                       BookedNum = (from hos in ouHosInfo
                                                    where DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeBegin) <= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeBegin)
                                                    && DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeEnd) >= DateTime.Parse(schedule.ScheduleDate.Date + " " + spanSub.TimeEnd)
                                                    && hos.DoctorId == schedule.DoctorId
                                                    && hos.RegDept == schedule.HospitalId.ToString()
                                                    && !hos.IsCancel
                                                    && !hos.IsHide
                                                    select hos.GUID).Count(),
                                       IsOpered = (from hos in ouHosInfo where hos.OperTime.Date == schedule.ScheduleDate.Date && hos.PatId == patID && !hos.IsCancel && !hos.IsHide select hos.GUID).Count() > 0
                                   };
                        var list = linq.ToList();
                        if (list.Count > 0)
                        {
                            var dtlInfo = list.First();
                            if (!dtlInfo.IsOpered)
                            {
                                if (dtlInfo.BookTotalNum - dtlInfo.BookedNum > 0)
                                {
                                    DateTime time = DateTime.Now;
                                    if (dtlInfo.ScheduleDate.Date.AddMinutes(TimeSpan.Parse(dtlInfo.TimeEnd).TotalMinutes) >= time)
                                    {
                                        int age = time.Year - patInfo.BirthDate.Year;
                                        OuHosInfo hosInfo = new OuHosInfo()
                                        {
                                            PatId = patID,
                                            MzRegNo = ServiceTaker.GetService<ICodeService>().Next(((int)EnumSequenceNumType.MzReg).ToString()).ToString(),
                                            CardNo = patInfo.CardNo,
                                            Name = patInfo.Name,
                                            Sex = patInfo.Sex,
                                            PatTypeId = "116",
                                            Age = age,
                                            AgeString = age.ToString() + "岁",
                                            RegDept = dtlInfo.LocationID.ToString(),
                                            DoctorId = dtlInfo.DoctorID,
                                            DiagRoomId = dtlInfo.DiagRoomID,
                                            IsPreReg = true,
                                            OperTime = time,
                                            IsCancel = false,
                                            //OperTime = dtlInfo.ScheduleDate.Date,
                                            //TimeBegin = dtlInfo.TimeBegin,
                                            //TimeEnd = dtlInfo.TimeEnd
                                        };
                                        Action action = delegate ()
                                        {
                                            hosInfo.GUID = _dbserver.Add(hosInfo);
                                            if (!string.IsNullOrWhiteSpace(hosInfo.GUID))
                                            {
                                                if (!patInfo.IsActive || patInfo.IsHide)
                                                {
                                                    _dbserver.Update<BsPatient>(new { IsActive = true, IsHide = false }, t => t.GUID == patInfo.GUID);
                                                }
                                            }
                                        };
                                        _dbserver.Commit(action);
                                        var bookedLinq = from hos in ouHosInfo
                                                         join spanSub in _dbserver.DataRepository.GetQueryable<BsRegSpanSub>() 
                                                         on hos.TimeSpanSubId equals spanSub.GUID
                                                         where DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeBegin) <= DateTime.Parse(dtlInfo.ScheduleDate.Date + " " + dtlInfo.TimeBegin)
                                                         && DateTime.Parse(hos.OperTime.Date + " " + spanSub.TimeEnd) >= DateTime.Parse(dtlInfo.ScheduleDate.Date + " " + dtlInfo.TimeEnd)
                                                         && hos.DoctorId == dtlInfo.DoctorID && hos.RegDept == dtlInfo.LocationID.ToString() && !hos.IsCancel&& !hos.IsHide
                                                         select hos.GUID;
                                        int BookedNum = bookedLinq.ToList().Count;
                                        returnvalue.Returns = new { DtlID = dtlID, RestNum = dtlInfo.BookTotalNum - BookedNum, ID = hosInfo.GUID, MzRegNo = hosInfo.MzRegNo };
                                        returnvalue.ErrorCode = 0;
                                    }
                                    else
                                    {
                                        returnvalue.Returns = new { DtlID = dtlID, RestNum = dtlInfo.BookTotalNum - dtlInfo.BookedNum };
                                        returnvalue.ErrorCode = 1;
                                        returnvalue.WarningMsg = "预约时段已过！";
                                    }
                                }
                                else
                                {
                                    returnvalue.Returns = new { DtlID = dtlID, RestNum = 0 };
                                    returnvalue.ErrorCode = 1;
                                    returnvalue.WarningMsg = "该医生预约已满！";
                                }
                            }
                            else
                            {
                                returnvalue.Returns = new { DtlID = dtlID, RestNum = dtlInfo.BookTotalNum - dtlInfo.BookedNum };
                                returnvalue.ErrorCode = 1;
                                returnvalue.WarningMsg = string.Format("【{0}】您已预约过！", dtlInfo.ScheduleDate.ToString("yyyy-MM-dd"));
                            }
                        }
                        else
                        {
                            returnvalue.ErrorCode = 1;
                            returnvalue.WarningMsg = "该医生已经停止预约！";
                        }
                    }
                    else
                    {
                        returnvalue.ErrorCode = 2;
                        returnvalue.WarningMsg = "找不到该用户！";
                    }
                }
                else
                {
                    returnvalue.ErrorCode = 2;
                    returnvalue.WarningMsg = "数据异常！";
                }
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 人工预约
        /// </summary>
        /// <param name="CustomerID">病人ID</param>
        /// <param name="Mobile">手机</param>
        /// <param name="ScheduleDate">预约日期</param>
        /// <param name="TimeSpanSubID">预约时段ID</param>
        /// <returns></returns>
        public ReturnValue ArtificialReservation(string CustomerID, string Mobile, string ScheduleDate, string TimeSpanSubID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                string patID =CustomerID;
                DateTime scheduleDate = DateTime.Parse(ScheduleDate);
                if (!string.IsNullOrWhiteSpace(patID))
                {
                    var patInfo = _dbserver.GetModelByGuid<BsPatient>(patID);
                    if (patInfo != null && !string.IsNullOrWhiteSpace(patInfo.GUID))
                    {
                        if (_dbserver.GetList<OuHosInfo>(t => t.OperTime.Date == scheduleDate.Date && t.PatId == patInfo.GUID && !t.IsCancel && !t.IsHide).Count > 0)
                        {
                            returnvalue.WarningMsg = string.Format("预约申请失败：您已经有【{0}】的预约，不需要提交申请！", scheduleDate.ToString("yyyy-MM-dd"));
                            returnvalue.ErrorCode = 1;
                        }
                        else
                        {
                            if (_dbserver.GetList<OuWebPreReg>(t => t.PatID == patInfo.GUID && t.PreRegTime.Date == scheduleDate.Date && !t.IsDealed && t.IsActive).Count > 0)
                            {
                                returnvalue.WarningMsg = string.Format("预约申请失败：您已经提交过【{0}】的预约申请，不允许重复提交！", scheduleDate.ToString("yyyy-MM-dd"));
                                returnvalue.ErrorCode = 1;
                            }
                            else
                            {
                                OuWebPreReg webPreRegInfo = new OuWebPreReg
                                {
                                    PatID = patInfo.GUID,
                                    //WebUserCode = bsPatient.WebUserCode,
                                    Name = patInfo.Name,
                                    Sex = patInfo.Sex,
                                    BirthDate = patInfo.BirthDate.Date,
                                    Phone = Mobile,
                                    //BookingPurpose = BookingPurpose,
                                    //BookingComments = BookingPurposeComment,

                                    PreRegTime = scheduleDate.Date,
                                    ApplyTime = DateTime.Now,
                                    TimeSpanSubID = TimeSpanSubID,
                                    DoctorId = string.Empty,
                                    LocationID = string.Empty,
                                    IsActive = true,
                                    IsDealed = false,
                                    Status = 0
                                };
                                Action action = delegate ()
                                {
                                    webPreRegInfo.GUID = _dbserver.Add(webPreRegInfo);
                                    if (!string.IsNullOrWhiteSpace(webPreRegInfo.GUID))
                                    {
                                        if (!patInfo.IsActive || patInfo.IsHide)
                                        {
                                            _dbserver.Update<BsPatient>(new { IsActive = true, IsHide = false }, t => t.GUID == patInfo.GUID);
                                        }
                                    }
                                };
                                _dbserver.Commit(action);
                                returnvalue.Returns = webPreRegInfo.GUID;
                                returnvalue.ErrorCode = 0;
                            }
                        }
                    }
                    else
                    {
                        returnvalue.ErrorCode = 2;
                        returnvalue.WarningMsg = "找不到该用户！";
                    }
                }
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "人工预约异常。详细信息：" + e.Message;
            }
            return returnvalue;
        }

        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <param name="Name">姓名</param>
        /// <param name="Mobile">电话</param>
        /// <param name="Sex">性别</param>
        /// <param name="Birthdate">出生日期</param>
        /// <param name="BookingPurpose">预约目的（种植，拔牙，洗牙等等）</param>
        /// <param name="BookingPurposeComment">预约备注（病情描述）</param>
        /// <param name="RegTime">预约日期</param>
        /// <param name="TimeSpanSubID">时段ID</param>
        /// <param name="DoctorID">医生ID</param>
        /// <param name="HosID">诊所ID</param>
        /// <returns></returns>
        public ReturnValue DoAppointmentReg(string UserCode, string Name, string Mobile, string Sex, string Birthdate, string BookingPurpose, string BookingPurposeComment, string RegTime, string TimeSpanSubID, string DoctorID, int HosID)
        {
            ReturnValue returnvalue = new ReturnValue();
            int LocationID = 0;
            try
            {
                var currentDateTime = _dbserver.GetServerTime();
                if (Convert.ToDateTime(Birthdate).Date > currentDateTime.Date)
                {
                    returnvalue.WarningMsg = "预约失败：出生日期不能大于今天！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                if (string.IsNullOrEmpty(Name.Trim()))
                {
                    returnvalue.WarningMsg = "预约失败：请填写姓名！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                if (string.IsNullOrEmpty(Mobile.Trim()))
                {
                    returnvalue.WarningMsg = "预约失败：请填写联系电话号码！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                if (string.IsNullOrEmpty(RegTime.Trim()))
                {
                    returnvalue.WarningMsg = "预约失败：请填写预约日期！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                if (Convert.ToDateTime(RegTime).Date <= currentDateTime.Date)
                {
                    returnvalue.WarningMsg = "预约失败：预约日期不能少于等于今天！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                //if (TimeSpanSubID > 0 && Convert.ToDateTime(RegTime).Date == currentDateTime.Date)
                //{
                //    string[] str = _dbserver.GetModelByGuid<BsRegSpanSub>(TimeSpanSubID).TimeBegin.Split(':');
                //    if (currentDateTime.Hour > int.Parse(str[0]) && currentDateTime.Minute > int.Parse(str[1]))
                //    {
                //        returnvalue.WarningMsg = "预约失败：当前时段大于所选时段！";
                //        returnvalue.ErrorCode = -1;
                //        return returnvalue;
                //    }
                //}
                if (HosID == 0)
                {
                    returnvalue.WarningMsg = "预约失败：请选择诊所！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }

                Action action = delegate ()
                {
                    var isNewPatient = false;
                    BsPatient bsPatient = null;
                    var list = _dbserver.GetList<BsPatient>(t => (t.Mobile == Mobile || t.Phone == Mobile) && t.Name == Name);
                    if (list.Count > 1)
                    {
                        bsPatient = list.Find(t => t.WebUserCode == UserCode);
                        if (bsPatient == null)
                        {
                            bsPatient = list.FirstOrDefault();
                        }
                    }
                    else if (list.Count == 1)
                    {
                        bsPatient = list.FirstOrDefault();
                    }
                    else //新建档案
                    {
                        bsPatient = new BsPatient
                        {
                            CardNo = ServiceTaker.GetService<ICodeService>().Next(((int)EnumSequenceNumType.CarNo).ToString()).ToString(),
                            OperTime = currentDateTime,
                            IsActive = true,
                            ModiTime = currentDateTime,
                            Name = Name,
                            BirthDate = Convert.ToDateTime(Birthdate).Date,
                            Age = currentDateTime.Year - Convert.ToDateTime(Birthdate).Date.Year,
                            AgeStr = (currentDateTime.Year - Convert.ToDateTime(Birthdate).Date.Year).ToString(),
                            Sex = Sex,
                            Mobile = Mobile,
                            PatTypeId = "116",// Orm.Config.UtilsLocCache.GetCacheEntity<BsPatType>(t=>t.Code == "01").GUID,//TODO 自费 
                            WebUserCode = UserCode
                        };
                        bsPatient.GUID = _dbserver.Add(bsPatient);
                        isNewPatient = true;
                    }
                    bsPatient.WebUserCode = UserCode;
                    bsPatient.Sex = Sex;
                    bsPatient.Mobile = Mobile;
                    bsPatient.BirthDate = Convert.ToDateTime(Birthdate).Date;
                    bsPatient.Age = currentDateTime.Year - Convert.ToDateTime(Birthdate).Date.Year;
                    bsPatient.IsActive = true;
                    bsPatient.IsHide = false;
                    //建档成功后，用bsPatient => OuWebPreReg 
                    var ouWebPreReg = new OuWebPreReg
                    {
                        PatID = bsPatient.GUID,
                        WebUserCode = bsPatient.WebUserCode,
                        Name = bsPatient.Name,
                        Sex = bsPatient.Sex,
                        BirthDate = bsPatient.BirthDate.Date,
                        Phone = Mobile,
                        BookingPurpose = BookingPurpose,
                        BookingComments = BookingPurposeComment,
                        PreRegTime = Convert.ToDateTime(RegTime).Date,
                        ApplyTime = currentDateTime,
                        TimeSpanSubID = TimeSpanSubID,
                        DoctorId = DoctorID,
                        LocationID = LocationID.ToString(),
                        IsActive = true,
                        IsDealed = false,
                        Status = 0
                    };
                    if (!isNewPatient)
                    {
                        if (_dbserver.GetList<OuHosInfo>(t => t.PatId == bsPatient.GUID && t.OperTime == Convert.ToDateTime(RegTime).Date && !t.IsCancel  && !t.IsHide).Count > 0)
                        {
                            returnvalue.WarningMsg = string.Format("预约申请失败：您已经成功申请({0})的预约，不允许再提交申请！", Convert.ToDateTime(RegTime).ToString("yyyy-MM-dd"));
                            returnvalue.ErrorCode = -1;
                        }
                        else
                        {
                            if (_dbserver.GetList<OuWebPreReg>(t => t.PatID == bsPatient.GUID && t.PreRegTime.Date == Convert.ToDateTime(RegTime).Date && !t.IsDealed && t.IsActive).Count > 0)
                            {
                                returnvalue.WarningMsg = string.Format("预约申请失败：您已经提交过({0})的预约申请，不允许重复提交！", Convert.ToDateTime(RegTime).ToString("yyyy-MM-dd"));
                                returnvalue.ErrorCode = -1;
                            }
                            else
                            {
                                ouWebPreReg.GUID = _dbserver.Add(ouWebPreReg);
                                returnvalue.ErrorCode = 0;
                                returnvalue.Returns = ouWebPreReg.GUID;
                            }
                        }
                        _dbserver.Update(bsPatient);
                    }
                    else
                    {
                        ouWebPreReg.GUID = _dbserver.Add(ouWebPreReg);
                        returnvalue.ErrorCode = 0;
                        returnvalue.Returns = ouWebPreReg.GUID;
                    }
                };
                _dbserver.Commit(action);
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约操作异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 取消预约
        /// </summary>
        /// <param name="MzRegNo">预约流水号</param>
        /// <returns></returns>
        public ReturnValue CancelAppointmentReg(string MzRegNo)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var currentTime = _dbserver.GetServerTime();
                var ouHosInfo = _dbserver.GetList<OuHosInfo>(t => t.MzRegNo == MzRegNo && t.IsPreReg && !t.IsCancel && !t.IsHide).FirstOrDefault();
                if (ouHosInfo != null)
                {
                    if (ouHosInfo.OperTime.Date <= currentTime.Date)
                    {
                        returnvalue.WarningMsg = "取消预约失败：该预约信息过期，不允许取消！";
                        returnvalue.ErrorCode = -1;
                    }
                    else
                    {
                        ouHosInfo.IsCancel = true;
                        ouHosInfo.CancelTime = currentTime;
                        _dbserver.Update(ouHosInfo);
                        returnvalue.ErrorCode = 0;
                    }
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约取消异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取预约信息(病人)
        /// </summary>
        /// <param name="BeginTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <returns></returns>
        public ReturnValue GetAppointmentInfo(string BeginTime, string EndTime, string UserCode)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                var ouWebPreReg = _dbserver.DataRepository.GetQueryable<OuWebPreReg>();
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var bsDiagRoom = _dbserver.DataRepository.GetQueryable<BsDiagRoom>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var linq = from ouhos in ouHosInfo
                           join ouweb in ouWebPreReg on ouhos.PatId equals ouweb.PatID into ouwebEmpty
                           from ouweb in ouwebEmpty.DefaultIfEmpty()
                           join bspat in bsPatient on ouhos.PatId equals bspat.GUID into bspatEmpty
                           from bspat in bspatEmpty.DefaultIfEmpty()
                           join bsuse in bsUser on ouhos.DoctorId equals bsuse.GUID into bsuseEmpty
                           from bsuse in bsuseEmpty.DefaultIfEmpty()
                           join bsloc in bsLocation on ouhos.RegDept equals bsloc.GUID into bslocEmpty
                           from bsloc in bslocEmpty.DefaultIfEmpty()
                           join bsdia in bsDiagRoom on ouhos.DiagRoomId equals bsdia.GUID into bsdiaEmpty
                           from bsdia in bsdiaEmpty.DefaultIfEmpty()
                           join bsreg in bsRegSpanSub on ouhos.TimeSpanSubId equals bsreg.GUID into bsregEmpty
                           from bsreg in bsregEmpty.DefaultIfEmpty()
                           where ouweb.WebUserCode == UserCode
                           && ouhos.OperTime.Date >= Convert.ToDateTime(BeginTime).Date
                           && bspat.IsActive
                           && !bspat.IsHide
                           && ouhos.OperTime.Date <= Convert.ToDateTime(EndTime).Date
                           && ouhos.IsPreReg
                           && !ouhos.IsCancel
                           && !ouhos.IsHide
                           select new uspBookedInfoQry
                           {
                               CardNo = ouhos.CardNo,
                               Name = ouhos.Name,
                               RegNo = ouhos.MzRegNo,
                               RegTime = ouhos.OperTime.ToString(),
                               DoctorName = bsuse.Name,
                               LocationName = bsloc.Name,
                               DiagRoomName = bsdia.Name,
                               TimeSpanSubName = bsreg.Name,
                               //CnBookingPurpose = ouhos.CnBookingPurpose,
                               Comment = ouhos.Memo,
                               LsDiagType = ouhos.LsDiagType == true ? 1 : 2
                           };
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = linq.OrderByDescending(t => t.RegTime).ToList();
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约信息查询异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取预约信息(医生或护士)
        /// </summary>
        /// <param name="BeginTime">开始时间</param>
        /// <param name="EndTime">结束时间</param>
        /// <param name="UserCode">用户（医生或护士）唯一码（绑定微信的手机号码）</param>
        /// <returns></returns>
        public ReturnValue GetAppointmentInfoByUser(string BeginTime, string EndTime, string UserCode)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsuserInfo = _dbserver.GetList<BsUser>(t => t.IsActive).FirstOrDefault();
                if (bsuserInfo != null)
                {
                    var DoctorID =string.Empty;
                    if (bsuserInfo.IsRecipe)
                    { DoctorID = bsuserInfo.GUID; }
                    var currentTime = _dbserver.GetServerTime();
                    var ouHosInfo = _dbserver.DataRepository.GetQueryable<OuHosInfo>();
                    var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                    var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                    var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                    var bsDiagRoom = _dbserver.DataRepository.GetQueryable<BsDiagRoom>();
                    var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                    var linq = from ouhos in ouHosInfo
                               join bspat in bsPatient on ouhos.PatId equals bspat.GUID into bspatEmpty
                               from bspat in bspatEmpty.DefaultIfEmpty()
                               join bsuse in bsUser on ouhos.DoctorId equals bsuse.GUID into bsuseEmpty
                               from bsuse in bsuseEmpty.DefaultIfEmpty()
                               join bsloc in bsLocation on ouhos.RegDept equals bsloc.GUID into bslocEmpty
                               from bsloc in bslocEmpty.DefaultIfEmpty()
                               join bsdia in bsDiagRoom on ouhos.DiagRoomId equals bsdia.GUID into bsdiaEmpty
                               from bsdia in bsdiaEmpty.DefaultIfEmpty()
                               join bsreg in bsRegSpanSub on ouhos.TimeSpanSubId equals bsreg.GUID into bsregEmpty
                               from bsreg in bsregEmpty.DefaultIfEmpty()
                               where (DoctorID ==string.Empty || ouhos.DoctorId == DoctorID)
                               && ouhos.IsPreReg
                               && !ouhos.IsCancel
                               && !ouhos.IsHide &&
                               ouhos.OperTime.Date >= Convert.ToDateTime(BeginTime).Date
                               && ouhos.OperTime.Date <= Convert.ToDateTime(EndTime).Date
                               select new uspBookedInfoQry
                               {
                                   CardNo = ouhos.CardNo,
                                   Name = ouhos.Name,
                                   Sex = ouhos.Sex,
                                   Age = (currentTime.Year - bspat.BirthDate.Year).ToString() + "岁",
                                   Mobile = bspat.Mobile,
                                   RegNo = ouhos.MzRegNo,
                                   RegTime = ouhos.OperTime.ToString("yyyy-MM-dd"),
                                   DoctorName = bsuse.Name,
                                   LocationName = bsloc.Name,
                                   DiagRoomName = bsdia.Name,
                                   TimeSpanSubName = bsreg.Name,
                                   //CnBookingPurpose = ouhos.CnBookingPurpose,
                                   Comment = ouhos.Memo,
                                   OperTime = ouhos.OperTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                   LsDiagType = ouhos.LsDiagType==true?1:2,
                                   VisitContent = ouhos.VisitContent,
                                   VisitStatus = ouhos.IsCancel== ouhos.IsCancel?1:0
                               };
                    returnvalue.ErrorCode = 0;
                    returnvalue.Returns = linq.OrderByDescending(t => t.OperTime).ToList();
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "没有权限查看！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约信息查询异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取预约目的
        /// </summary>
        /// <param name="Token">Token 授权码</param>
        /// <returns></returns>
        public ReturnValue GetBookingPurposeInfo(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                List<BsData> list = new List<BsData>();
                list.Add(new BsData() { GUID = "1", Name = "治疗" });
                list.Add(new BsData() { GUID = "2", Name = "修复" });
                list.Add(new BsData() { GUID = "3", Name = "种植" });
                list.Add(new BsData() { GUID = "4", Name = "正畸" });
                list.Add(new BsData() { GUID = "5", Name = "检查" });
                list.Add(new BsData() { GUID = "6", Name = "洗牙" });
                list.Add(new BsData() { GUID = "7", Name = "其他" });
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = list;
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约目的获取异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取预约时段
        /// </summary>
        /// <param name="Token">Token 授权码</param>
        /// <returns></returns>
        public ReturnValue GetTimeSpanSubInfo(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var linq = from bsreg in bsRegSpanSub
                           where bsreg.IsActive
                           select new BsData
                           {
                               GUID = bsreg.GUID,
                               Name = bsreg.Name
                           };
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = linq.OrderBy(t => t.GUID).ToList(); ;
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约时段获取异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取预约申请（病人）
        /// </summary>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <returns></returns>
        public ReturnValue GetOuWebPreRegInfo(string UserCode)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var ouWebPreReg = _dbserver.DataRepository.GetQueryable<OuWebPreReg>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var linq = from ouweb in ouWebPreReg
                           join bspat in bsPatient on ouweb.PatID equals bspat.GUID into bspatEmpty
                           from bspat in bspatEmpty.DefaultIfEmpty()
                           join bsuse in bsUser on ouweb.DoctorId equals bsuse.GUID into bsuseEmpty
                           from bsuse in bsuseEmpty.DefaultIfEmpty()
                           join bsreg in bsRegSpanSub on ouweb.TimeSpanSubID equals bsreg.GUID into bsregEmpty
                           from bsreg in bsregEmpty.DefaultIfEmpty()
                           join bsloc in bsLocation on ouweb.LocationID equals bsloc.GUID into bslocEmpty
                           from bsloc in bslocEmpty.DefaultIfEmpty()
                           where ouweb.WebUserCode == UserCode
                           && ouweb.IsActive
                           select new uspOuWebPreReg
                           {
                               GUID = ouweb.GUID,
                               PatID = bspat.GUID,
                               Name = bspat.Name,
                               Sex = bspat.Sex,
                               BirthDate = bspat.BirthDate.ToString("yyyy-MM-dd"),
                               Phone = bspat.Mobile,
                               Comments = ouweb.Comments,
                               BookingPurpose = ouweb.BookingPurpose,
                               BookingComments = ouweb.BookingComments,
                               PreRegTime = ouweb.PreRegTime.ToString("yyyy-MM-dd"),
                               TimeSpanSubID = ouweb.TimeSpanSubID,
                               DoctorId = ouweb.DoctorId,
                               ApplyTime = ouweb.ApplyTime.ToString("yyyy-MM-dd HH:mm:ss"),
                               LocationID = bsloc.GUID,
                               TimeSpanSubName = bsreg.Name,
                               DoctorName = bsuse.Name,
                               LocationName = bsloc.Name,
                               Status = ouweb.Status == 1 ? "已通过" : ouweb.Status == 2 ? "未通过" : "未处理"
                           };
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = linq.ToList();
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "病人预约申请获取异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 取消预约申请（病人）
        /// </summary>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <param name="WebPreRegID">预约申请ID</param>
        /// <returns></returns>
        public ReturnValue CancelAppointmentPreReg(string UserCode, string WebPreRegID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var ouWebPreReg = _dbserver.GetModelByGuid<OuWebPreReg>(WebPreRegID);
                if (ouWebPreReg != null)
                {
                    if (ouWebPreReg.WebUserCode == UserCode)
                    {
                        if (ouWebPreReg.IsActive)
                        {
                            if (ouWebPreReg.Status == 0)
                            {
                                var currentTime = _dbserver.GetServerTime();
                                ouWebPreReg.IsDealed = true;
                                ouWebPreReg.IsActive = false;
                                ouWebPreReg.OperTime = currentTime;
                                _dbserver.Update(ouWebPreReg);
                                returnvalue.ErrorCode = 0;
                            }
                            else
                            {
                                returnvalue.WarningMsg = "取消预约申请失败：该预约申请已经被处理了！";
                                returnvalue.ErrorCode = -1;
                            }
                        }
                        else
                        {
                            returnvalue.WarningMsg = "取消预约申请失败：该预约申请已经被取消了！";
                            returnvalue.ErrorCode = -1;
                        }
                    }
                    else
                    {
                        returnvalue.ErrorCode = -1;
                        returnvalue.WarningMsg = "不是本人，没有操作权限！";
                    }
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "取消预约申请失败：没有该预约申请！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "预约取消异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取指定预约申请(医生或护士)
        /// </summary>
        /// <param name="WebPreID">预约申请ID</param>
        /// <returns></returns>
        public ReturnValue GetOuWebPreRegInfoByWebRegID(string WebPreID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var ouWebPreReg = _dbserver.DataRepository.GetQueryable<OuWebPreReg>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                var linq = from ouweb in ouWebPreReg
                           join bspat in bsPatient on ouweb.PatID equals bspat.GUID into bspatEmpty
                           from bspat in bspatEmpty.DefaultIfEmpty()
                           join bsuse in bsUser on ouweb.DoctorId equals bsuse.GUID into bsuseEmpty
                           from bsuse in bsuseEmpty.DefaultIfEmpty()
                           join bsreg in bsRegSpanSub on ouweb.TimeSpanSubID equals bsreg.GUID into bsregEmpty
                           from bsreg in bsregEmpty.DefaultIfEmpty()
                           join bsloc in bsLocation on ouweb.LocationID equals bsloc.GUID into bslocEmpty
                           from bsloc in bslocEmpty.DefaultIfEmpty()
                           where ouweb.GUID == WebPreID
                           && ouweb.IsActive
                           && !ouweb.IsDealed
                           select new uspOuWebPreReg
                           {
                               GUID = ouweb.GUID,
                               PatID = bspat.GUID,
                               Name = bspat.Name,
                               Sex = bspat.Sex,
                               BirthDate = bspat.BirthDate.ToString("yyyy-MM-dd"),
                               Phone = bspat.Mobile,
                               Comments = "预约目的：" + ouweb.BookingPurpose + " " + "病情描述：" + ouweb.BookingComments,
                               PreRegTime = ouweb.PreRegTime.ToString("yyyy-MM-dd"),
                               TimeSpanSubID = ouweb.TimeSpanSubID,
                               DoctorId = ouweb.DoctorId,
                               ApplyTime = ouweb.ApplyTime.ToString("yyyy-MM-dd HH:mm:ss"),
                               LocationID = bsloc.GUID,
                               TimeSpanSubName = bsreg.Name,
                               DoctorName = bsuse.Name,
                               LocationName = bsloc.Name
                           };
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = linq.ToList();
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "病人预约申请获取异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 获取全部预约申请(医生或护士)
        /// </summary>
        /// <param name="UserCode">用户（医生或护士）唯一码（绑定微信的手机号码）</param>
        /// <returns></returns>
        public ReturnValue GetOuWebPreRegInfoByUser(string UserCode)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsUserInfo = _dbserver.GetList<BsUser>(t => t.IsActive).FirstOrDefault();
                if (bsUserInfo != null)
                {
                    var DoctorID = string.Empty;
                    if (bsUserInfo.IsRecipe)
                    {
                        DoctorID = bsUserInfo.GUID;
                    }
                    var ouWebPreReg = _dbserver.DataRepository.GetQueryable<OuWebPreReg>();
                    var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                    var bsRegSpanSub = _dbserver.DataRepository.GetQueryable<BsRegSpanSub>();
                    var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                    var bsLocation = _dbserver.DataRepository.GetQueryable<BsLocation>();
                    var linq = from ouweb in ouWebPreReg
                               join bspat in bsPatient on ouweb.PatID equals bspat.GUID into bspatEmpty
                               from bspat in bspatEmpty.DefaultIfEmpty()
                               join bsuse in bsUser on ouweb.DoctorId equals bsuse.GUID into bsuseEmpty
                               from bsuse in bsuseEmpty.DefaultIfEmpty()
                               join bsreg in bsRegSpanSub on ouweb.TimeSpanSubID equals bsreg.GUID into bsregEmpty
                               from bsreg in bsregEmpty.DefaultIfEmpty()
                               join bsloc in bsLocation on ouweb.LocationID equals bsloc.GUID into bslocEmpty
                               from bsloc in bslocEmpty.DefaultIfEmpty()
                               where (DoctorID == string.Empty || ouweb.DoctorId == DoctorID)
                               && ouweb.IsActive
                               select new uspOuWebPreReg
                               {
                                   GUID = ouweb.GUID,
                                   PatID = bspat.GUID,
                                   Name = bspat.Name,
                                   Sex = bspat.Sex,
                                   BirthDate = bspat.BirthDate.ToString("yyyy-MM-dd"),
                                   Phone = bspat.Mobile,
                                   Comments = "预约目的：" + ouweb.BookingPurpose + " " + "病情描述：" + ouweb.BookingComments,
                                   PreRegTime = ouweb.PreRegTime.ToString("yyyy-MM-dd"),
                                   TimeSpanSubID = ouweb.TimeSpanSubID,
                                   DoctorId = ouweb.DoctorId,
                                   ApplyTime = ouweb.ApplyTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                   LocationID = bsloc.GUID,
                                   TimeSpanSubName = bsreg.Name,
                                   DoctorName = bsuse.Name,
                                   LocationName = bsloc.Name,
                                   Status = ouweb.Status == 1 ? "已确认" : ouweb.Status == 2 ? "已回绝" : "未处理"
                               };
                    returnvalue.ErrorCode = 0;
                    returnvalue.Returns = linq.ToList(); ;
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "没有权限查看！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "病人预约申请获取异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        public string GenernateSequenceNo(string sequenceName, string dynamicContent)
        {
            try
            {
                string sql = @"begin
                         getsequence(v_sequencename => :v_sequencename,
                          v_dynamiccontent => :v_dynamiccontent,
                          cv_1 => :cv_1);
                        end;";
                var helper = this._dbserver.DataRepository.SqlHelper;

                helper.AddParameter(":v_sequencename", sequenceName);
                helper.AddParameter(":v_dynamiccontent", dynamicContent);
                helper.AddOutParameter(":cv_1", (int)Oracle.DataAccess.Client.OracleDbType.RefCursor);
                var d = helper.ExecuteDataTable(sql, helper.Parameters);
                var result = d.Rows[0][0];
                return result == null ? "" : result.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }

        /// <summary>
        /// 确认预约申请并获取信息内容(医生或护士)
        /// </summary>
        /// <param name="UserCode">用户（医生或护士）唯一码（绑定微信的手机号码）</param>
        /// <param name="WebPreID">预约申请ID</param>
        /// <param name="BookingPurpose">就诊目的（编码，格式如1|2|3）</param>
        /// <param name="CnBookingPurpose">就诊目的中文（格式如：洁牙，拔牙，种植）</param>
        /// <param name="BookingPurposeComment">备注</param>
        /// <param name="TimeSpanSubID">时段ID</param>
        /// <param name="DoctorID">医生ID</param>
        /// <returns></returns>
        public ReturnValue ConfirmAppointmentRegAndGetMessage(string UserCode, string WebPreID, string BookingPurpose, string CnBookingPurpose, string BookingPurposeComment, string TimeSpanSubID, string DoctorID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                if (string.IsNullOrWhiteSpace(DoctorID))
                {
                    returnvalue.WarningMsg = "确认预约申请失败：请选择医生！";
                    returnvalue.ErrorCode = -1;
                    return returnvalue;
                }
                var bsuser = _dbserver.GetList<BsUser>(t => t.IsActive).FirstOrDefault();
                if (bsuser != null)
                {
                    var ouWebPreRegInfo = _dbserver.GetModelByGuid<OuWebPreReg>(WebPreID);
                    if (ouWebPreRegInfo != null)
                    {
                        if (ouWebPreRegInfo.IsActive && ouWebPreRegInfo.Status == 0)
                        {
                            Action action = delegate ()
                            {
                                var currentTime = _dbserver.GetServerTime();
                                var bsPatientInfo = _dbserver.GetModelByGuid<BsPatient>(ouWebPreRegInfo.PatID);
                                var bsUserInfo = _dbserver.GetModelByGuid<BsUser>(DoctorID);
                                var bsRegSpanSubInfo = _dbserver.GetModelByGuid<BsRegSpanSub>(TimeSpanSubID);
                                var operPhone = bsuser.Mobile == null ? UserCode : bsuser.Mobile;
                                var ouHosInfo = new OuHosInfo
                                {
                                    IsHide = false,
                                    MzRegNo = GenernateSequenceNo(((int)EnumSequenceNumType.CarNo).ToString(), "").ToString(),
                                    RegTime = ouWebPreRegInfo.PreRegTime.Date == currentTime.Date ? currentTime.Date : DateTime.MinValue,
                                    PatId = bsPatientInfo.GUID,
                                    CardNo = bsPatientInfo.CardNo,
                                    Name = bsPatientInfo.Name,
                                    Sex = bsPatientInfo.Sex,
                                    //Height = bsPatientInfo.Height,
                                    //Weight = bsPatientInfo.Weight,
                                    PatTypeId = bsPatientInfo.PatTypeId,
                                    MedicareNo = bsPatientInfo.MedicareNo,
                                    RegTypeId = bsUserInfo.RegTypeId,
                                    RegDept = ouWebPreRegInfo.LocationID,
                                    DoctorId = DoctorID,
                                    IsPreReg = ouWebPreRegInfo.PreRegTime.Date == currentTime.Date ? false : true,
                                    //OperTime = _dbserver.GetServerTime(),
                                    OperId = bsuser.GUID,
                                    IsCancel = false,
                                    TimeSpanId = bsRegSpanSubInfo.TimeSpanId,
                                    TimeSpanSubId = TimeSpanSubID,
                                    Age = (currentTime.Year - bsPatientInfo.BirthDate.Year),
                                    AgeString = (currentTime.Year - bsPatientInfo.BirthDate.Year).ToString() + "岁",
                                    OperTime = ouWebPreRegInfo.PreRegTime.Date == currentTime.Date ? DateTime.MinValue : ouWebPreRegInfo.PreRegTime.Date,
                                   // ISInputBYRegMAN = true,
                                    PyCode = Orm.Utilities.PyWbHelper.SixBitPYCode(bsPatientInfo.Name),
                                    WbCode = Orm.Utilities.PyWbHelper.SixBitWBCode(bsPatientInfo.Name),
                                    //CnBookingPurpose = CnBookingPurpose,
                                    CnBookingPurpose = BookingPurpose,
                                    Memo = BookingPurposeComment
                                };
                                ouHosInfo.GUID = _dbserver.Add(ouHosInfo);
                                ouWebPreRegInfo.MzRegID = ouHosInfo.GUID;
                                ouWebPreRegInfo.OperId = bsuser.GUID;
                                ouWebPreRegInfo.OperTime = _dbserver.GetServerTime();
                                ouWebPreRegInfo.Status = 1;
                                ouWebPreRegInfo.IsDealed = true;
                                _dbserver.Update(ouWebPreRegInfo);
                                returnvalue.ErrorCode = 0;
                                string PreRegTime = ouWebPreRegInfo.PreRegTime.ToString("yyyy-MM-dd") + " " + bsRegSpanSubInfo.Name;

                            };
                            _dbserver.Commit(action);
                        }
                        else
                        {
                            returnvalue.ErrorCode = -1;
                            returnvalue.WarningMsg = "确认预约失败：该预约申请已被处理！";
                        }
                    }
                    else
                    {
                        returnvalue.ErrorCode = -1;
                        returnvalue.WarningMsg = "确认预约失败：没有该预约申请！";
                    }
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "没有操作权限！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "病人预约申请确认异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }


        /// <summary>
        /// 拒绝预约申请(医生或护士)
        /// </summary>
        /// <param name="UserCode">用户（医生或护士）唯一码（绑定微信的手机号码）</param>
        /// <param name="WebPreID">预约申请ID</param>
        /// <param name="Comment">拒绝理由</param>
        /// <returns></returns>
        public ReturnValue RejectAppointmentRegAndGetMessage(string UserCode, string WebPreID, string Comment)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsuser = _dbserver.GetList<BsUser>(t => t.IsActive).FirstOrDefault();
                if (bsuser != null)
                {
                    var currentTime = _dbserver.GetServerTime();
                    var ouWebPreRegInfo = _dbserver.GetModelByGuid<OuWebPreReg>(WebPreID);
                    if (ouWebPreRegInfo != null)
                    {
                        if (ouWebPreRegInfo.IsActive && ouWebPreRegInfo.Status == 0)
                        {
                            ouWebPreRegInfo.Status = 2;
                            ouWebPreRegInfo.IsDealed = true;
                            ouWebPreRegInfo.OperId = bsuser.GUID;
                            ouWebPreRegInfo.OperTime = currentTime;
                            ouWebPreRegInfo.Comments = Comment;
                            _dbserver.Update(ouWebPreRegInfo);
                            returnvalue.ErrorCode = 0;
                        }
                        else
                        {
                            returnvalue.ErrorCode = -1;
                            returnvalue.WarningMsg = "回绝预约申请失败：该预约申请已被处理！";
                        }
                    }
                    else
                    {
                        returnvalue.ErrorCode = -1;
                        returnvalue.WarningMsg = "回绝预约申请失败：没有该预约申请！";
                    }
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "没有操作权限！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "病人预约申请拒绝确认异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 保存发送信息内容
        /// </summary>
        /// <param name="UserCode">用户（医生或护士）唯一码（绑定微信的手机号码）</param>
        /// <param name="WebPreID">预约申请ID</param>
        /// <param name="Message">发送信息内容</param>
        /// <param name="NotifyType">推送方式(0 微信 1 短信 2 电话)</param>
        /// <returns></returns>
        public ReturnValue SaveSendedInfo(string UserCode, string WebPreID, string Message, int NotifyType)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var bsUserInfo = _dbserver.GetList<BsUser>(t => t.IsActive).FirstOrDefault();
                if (bsUserInfo != null)
                {
                    Action action = delegate ()
                    {
                        var ouWebPreRegInfo = _dbserver.GetModelByGuid<OuWebPreReg>(WebPreID);
                        var ouCommunicateLogInfo = new OuCommunicateLog
                        {
                            PatId = ouWebPreRegInfo.PatID,
                            Name = ouWebPreRegInfo.Name,
                            Phone = ouWebPreRegInfo.Phone,
                            Type = 2,
                            OperId = bsUserInfo.GUID,
                            OperTime = _dbserver.GetServerTime(),
                            Comments = Message,
                            Notifytype = NotifyType
                        };
                        _dbserver.Add(ouCommunicateLogInfo);
                        returnvalue.ErrorCode = 0;
                    };
                    _dbserver.Commit(action);
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "没有操作权限！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "发送信息保存异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 保存微信关注信息
        /// </summary>
        /// <param name="UserCode">病人唯一码（绑定微信的手机号码）</param>
        /// <param name="Status"> 1 绑定 0 取消绑定</param>
        /// <returns></returns>
        public ReturnValue UpdateWebBindingStatus(string UserCode, string Status)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                bool status = Status == "1";
                var lstBsPatientInfo = _dbserver.GetList<BsPatient>(t => t.WebUserCode == UserCode);
                if (lstBsPatientInfo.Count > 0)
                {
                    lstBsPatientInfo.ForEach(t => { t.IsModify = true; /*t.IsWebBinding = status;*/ });
                    _dbserver.Save(lstBsPatientInfo, true);
                    returnvalue.ErrorCode = 0;
                }
                else
                {
                    returnvalue.ErrorCode = -1;
                    returnvalue.WarningMsg = "找不到该病人信息！";
                }
                return returnvalue;
            }
            catch (Exception e)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "关注信息保存异常。详细信息：" + e.Message;
                return returnvalue;
            }
        }

        #endregion

        #region OA接口

        public ReturnValue GetVIPType()
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetList<BsVipType>(t => t.IsActive).OrderBy(t => t.OrderBy).ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
            }
            return returnvalue;
        }

        public ReturnValue GetVIPLvByTypeID(string typeId)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                string TypeID = typeId;
                if (string.IsNullOrWhiteSpace(TypeID))
                    returnvalue.Returns = _dbserver.GetList<BsVipLevel>(t => t.IsActive).OrderBy(t => t.OrderBy).ToList();
                else if (!string.IsNullOrWhiteSpace(TypeID))
                    returnvalue.Returns = _dbserver.GetList<BsVipLevel>(t => t.VipTypeId == TypeID && t.IsActive).OrderBy(t => t.OrderBy).ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
            }
            return returnvalue;
        }

        public ReturnValue SearchVIP(string cardNo, string typeId, string lvId, string createStartDate, string createEndDate, string fileNo, string name, string sex, string startBirthDate, string endBirthDate)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                cardNo = cardNo.Trim();
                string TypeID =typeId;
                string LvID =lvId;
                DateTime CreateStartDate = Convert.ToDateTime(createStartDate).Date;
                DateTime CreateEndDate = Convert.ToDateTime(createEndDate).Date;
                fileNo = fileNo.Trim();
                name = name.Trim();
                sex = sex.Trim();
                DateTime StartBirthDate = Convert.ToDateTime(startBirthDate).Date;
                DateTime EndBirthDate = Convert.ToDateTime(endBirthDate).Date;
                var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                var ouRecharge = _dbserver.DataRepository.GetQueryable<OuRecharge>();
                var linq = from binding in _dbserver.DataRepository.GetQueryable<VipBinding>()
                           join pat in bsPatient on binding.PatId equals pat.GUID
                           join card in _dbserver.DataRepository.GetQueryable<VipCard>() on binding.VipCardId equals card.GUID
                           join holder in bsPatient on card.PatId equals holder.GUID
                           join cardLv in _dbserver.DataRepository.GetQueryable<BsVipLevel>() on card.VipLevelId equals cardLv.GUID
                           join recmax in
                               (from rectemp in ouRecharge
                                group rectemp by rectemp.VipCardID into g
                                select new { ID = g.Max(t => t.GUID), VipCardID = g.Key, RechargeAmount = g.Sum(t => t.Income), AE = g.Sum(t => t.PayOut) }) on card.GUID equals recmax.VipCardID into rectempEmpty
                           from recmax in rectempEmpty.DefaultIfEmpty()
                           join recinfo in ouRecharge on recmax.ID equals recinfo.GUID into recinfoEmpty
                           from recinfo in recinfoEmpty.DefaultIfEmpty()
                           join intemax in
                               (from intetemp in _dbserver.DataRepository.GetQueryable<VipIntegral>()
                                where intetemp.IsActive
                                group intetemp by intetemp.VipcardId into g
                                select new { ID = g.Max(t => t.GUID), VipCardID = g.Key, TotalIntegral = g.Sum(t => t.Integral) }) on card.GUID equals intemax.VipCardID into intetempEmpty
                           from intemax in intetempEmpty.DefaultIfEmpty()
                           join introducer in bsPatient on card.IntroducerId equals introducer.GUID into introducerEmpty
                           from introducer in introducerEmpty.DefaultIfEmpty()
                           join oper in bsUser on card.OperId equals oper.GUID into operEmpty
                           from oper in operEmpty.DefaultIfEmpty()
                           join introducerOper in bsUser on card.IntroducerOperId equals introducerOper.GUID into introducerOperEmpty
                           from introducerOper in introducerOperEmpty.DefaultIfEmpty()
                           join modiOper in bsUser on card.ModiOperId equals modiOper.GUID into modiOperEmpty
                           from modiOper in modiOperEmpty.DefaultIfEmpty()
                           where binding.IsActive
                           && holder.IsActive
                           && !holder.IsHide
                           && pat.IsActive
                           && !pat.IsHide
                           && card.IsActive
                           && card.CardStatus == 1
                           && cardLv.IsActive
                           && (cardNo.Trim() == string.Empty || card.CardNo.EndsWith(cardNo))
                           && (TypeID == string.Empty || cardLv.VipTypeId == TypeID)
                           && (LvID == string.Empty || cardLv.GUID == LvID)
                           && (CreateStartDate == DateTime.MinValue || card.CreateTime.Date >= CreateStartDate)
                           && (CreateEndDate == DateTime.MinValue || card.CreateTime.Date <= CreateEndDate)
                           && (fileNo.Trim() == string.Empty || pat.CardNo.EndsWith(fileNo))
                           && (name.Trim() == string.Empty || pat.Name.StartsWith(name))
                           && (sex.Trim() == string.Empty || pat.Sex == sex)
                           && (StartBirthDate == DateTime.MinValue || pat.BirthDate.Date >= StartBirthDate)
                           && (EndBirthDate == DateTime.MinValue || pat.BirthDate.Date <= EndBirthDate)
                           select new UspVIPCardQry
                           {
                               GUID = binding.GUID,
                               Name = pat.Name,
                               VIPCardID = card.GUID,
                               RechargeAmount = recmax.RechargeAmount,
                               AE = recmax.AE,
                               TotalBalance = recinfo.Balance,
                               TotalIntegral = intemax.TotalIntegral,
                               VIPCardNo = card.CardNo,
                               VIPCardName = cardLv.Name,
                               CreateTime = card.CreateTime,
                               IsCardHolder = binding.IsCardHolder,
                               Discount = card.Discount,
                               OperName = oper.Name,
                               CardStatus = card.CardStatus,
                               ModifiedOperName = card.ModiTime == card.CreateTime ? "无" : modiOper.Name,
                               ModifiedOperTime = card.ModiTime == card.CreateTime ? "无" : card.ModiTime.ToString("yyyy-MM-dd HH:mm:ss"),
                               IntroducerName = introducer.Name,
                               IntroducerOperName = introducerOper.Name,
                               InvalidDate = card.InvalidDate.Date == DateTime.MinValue.Date ? "无" : (card.InvalidDate.Date == DateTime.MaxValue.Date ? "无" : card.InvalidDate.ToString("yyyy-MM-dd HH:mm:ss"))
                           };
                returnvalue.Returns = linq.ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
            }
            return returnvalue;
        }

        public ReturnValue GetIdNoTypeList(string Token)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.Returns = _dbserver.GetList<BsCertificate>(t => t.IsActive).OrderBy(t => t.OrderBy).ToList();
                returnvalue.ErrorCode = 0;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
            }
            return returnvalue;
        }

        public ReturnValue GetAllIntroducerCardByIdNo(string typeId, string idNo)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                var patTemp = _dbserver.GetList<BsPatient>(t => t.CertificateId == typeId && t.IdCardNo == idNo.Trim() && t.IsActive && !t.IsHide);
                if (patTemp.Count == 1)
                {
                    var patInfo = patTemp.FirstOrDefault();
                    if (patInfo != null && !string.IsNullOrWhiteSpace(patInfo.GUID))
                    {
                        var bsPatient = _dbserver.DataRepository.GetQueryable<BsPatient>();
                        var bsUser = _dbserver.DataRepository.GetQueryable<BsUser>();
                        var integral = _dbserver.DataRepository.GetQueryable<VipIntegral>();
                        var ouRecharge = _dbserver.DataRepository.GetQueryable<OuRecharge>();
                        var linq = from card in _dbserver.DataRepository.GetQueryable<VipCard>()
                                   join pat in bsPatient on card.PatId equals pat.GUID
                                   join cardLv in _dbserver.DataRepository.GetQueryable<BsVipLevel>() on card.VipLevelId equals cardLv.GUID into cardLvEmpty
                                   from cardLv in cardLvEmpty.DefaultIfEmpty()
                                   join introducer in bsPatient on card.IntroducerId equals introducer.GUID into introducerEmpty
                                   from introducer in introducerEmpty.DefaultIfEmpty()
                                   join oper in bsUser on card.OperId equals oper.GUID into operEmpty
                                   from oper in operEmpty.DefaultIfEmpty()
                                   join introducerOper in bsUser on card.IntroducerOperId equals introducerOper.GUID into introducerOperEmpty
                                   from introducerOper in introducerOperEmpty.DefaultIfEmpty()
                                   join modiOper in bsUser on card.ModiOperId equals modiOper.GUID into modiOperEmpty
                                   from modiOper in modiOperEmpty.DefaultIfEmpty()
                                   where pat.IsActive
                                   && !pat.IsHide
                                   && card.IsActive
                                   && card.CardStatus == 1
                                   && cardLv.IsActive
                                   && (card.PatId == patInfo.GUID || card.FirstintRoducerId == patInfo.GUID)
                                   select new UspVIPCardQry
                                   {
                                       GUID = card.PatId,
                                       Name = pat.Name,
                                       VIPCardID = card.GUID,
                                       RechargeAmount = (from ourec in ouRecharge where ourec.VipCardID == card.GUID select ourec.Income).Sum(),
                                       //recmax.RechargeAmount,
                                       AE = (from ourec in ouRecharge where ourec.VipCardID == card.GUID select ourec.PayOut).Sum(),
                                       //recmax.AE,
                                       TotalBalance = (from oure in ouRecharge where oure.GUID == (from ourec in ouRecharge where ourec.VipCardID == card.GUID select ourec).Max(t => t.GUID) select oure.Balance).Sum(),
                                       //recinfo.Balance,
                                       TotalIntegral = (from inte in integral where inte.VipcardId == card.GUID && inte.IsActive select inte.Integral).Sum(),
                                       //intemax.TotalIntegral,
                                       AEIntegral = (from inte in integral where inte.VipcardId == card.GUID && inte.Integral < 0 && inte.IsActive select inte.Integral).Sum(),
                                       IntroducerReward = card.IntroducerReward,
                                       VIPCardNo = card.CardNo,
                                       VIPCardName = cardLv.Name,
                                       CreateTime = card.CreateTime,
                                       IsCardHolder = card.PatId == patInfo.GUID,
                                       Discount = card.Discount,
                                       OperName = oper.Name,
                                       CardStatus = card.CardStatus,
                                       ModifiedOperName = card.ModiTime == card.CreateTime ? "无" : modiOper.Name,
                                       ModifiedOperTime = card.ModiTime == card.CreateTime ? "无" : card.ModiTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                       IntroducerID = card.IntroducerId,
                                       IntroducerName = introducer.Name,
                                       IntroducerOperName = introducerOper.Name,
                                       InvalidDate = card.InvalidDate.Date == DateTime.MinValue.Date ? "无" : (card.InvalidDate.Date == DateTime.MaxValue.Date ? "无" : card.InvalidDate.ToString("yyyy-MM-dd HH:mm:ss"))
                                   };
                        var list = linq.ToList();
                        returnvalue.Returns = list;
                        returnvalue.ErrorCode = 0;
                    }
                    else
                    {
                        returnvalue.ErrorCode = 1;
                        returnvalue.WarningMsg = "找不到该病人！";
                    }
                }
                else if (patTemp.Count > 1)
                {
                    returnvalue.ErrorCode = 1;
                    returnvalue.WarningMsg = "搜索结果不唯一！";
                }
                else
                {
                    returnvalue.ErrorCode = 1;
                    returnvalue.WarningMsg = "找不到该病人！";
                }
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = ex.Message;
            }
            return returnvalue;
        }

        #endregion

        /// <summary>
        /// 回收长期不使用系统的客户
        /// </summary>
        /// <param name="customerGuid"></param>
        /// <returns></returns>
        public ReturnValue RecoverCustomer(string customerGuid)
        {
            ReturnValue rv = new ReturnValue();
            rv.ErrorCode = 0;

            try
            {
                var customer = _dbupdate.Get<Orm.Model.Customer>(m => m.CustomerGuid == customerGuid);
                if (customer == null || string.IsNullOrEmpty(customer.Code))
                {
                    rv.ErrorCode = 0;
                    rv.WarningMsg = string.Format("不存在GUID: {0} 对应的客户信息！", customerGuid);
                    return rv;
                }

                var db = ServiceTaker.GetService<IDataPersist>(GetDbProviderInfo(customer.Code));
                int ouInvoiceNum = db.GetQueryable<OuInvoice>().Count();
                DateTime time = db.GetQueryable<OuInvoice>().Max(m => m.InvoTime);

                if (ouInvoiceNum > 30 || DateTime.Compare(time, DateTime.Now.AddDays(-30)) > 0)
                {
                    rv.ErrorCode = 1;
                    rv.WarningMsg = string.Format("{0}【{1}】不能回收,发票总数:{2}, 最后发票时间:{3}", customer.Name, customer.Code.Substring(customer.Code.IndexOf('_') + 1), ouInvoiceNum.ToString(), time.ToShortDateString());
                    return rv;
                }

                //清除数据库历史数据                
                Action action = delegate ()
                {
                    for (int i = 0; i < GetDeleteSql().Length; i++)
                    {
                        db.SqlHelper.ExecuteNonQuery(GetDeleteSql()[i]);
                    }

                };
                db.WorkUnitAct(action);

                //修改customer表的customterGuid和isStartUsing=0
                customer.IsStartUsing = false;
                string cuGuid = Orm.Utilities.Common.GuidTo16String();
                customer.Mobile = customer.Mobile.ToString() + cuGuid;
                customer.CustomerGuid = cuGuid;
                _dbupdate.Update(customer);
                rv.ErrorCode = 0;
                rv.WarningMsg = "客户数据回收成功!";
                return rv;
            }
            catch (Exception ex)
            {
                rv.ErrorCode = -1;
                rv.ErrorMsg = ex.Message;
                return rv;
            }

        }

        private object GetDbProviderInfo(string customerCode)
        {
            string hostIp = customerCode.Substring(0, customerCode.IndexOf('_'));
            string userId = customerCode.Substring(customerCode.IndexOf('_') + 1);
            string serviceName = "orcl";
            string password = "asd2828";
            string connectionString = string.Format("Data Source=(DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = {0})(PORT = 1521)) ) (CONNECT_DATA =(SERVICE_NAME ={1}) ) );User Id={2};Password={3};", hostIp, serviceName, userId, password);

            var provider = System.Reflection.Assembly.Load("Orm").CreateInstance("Orm.DbProviderInfo");
            Orm.Utilities.Common.SetPropertyValue(provider, "CommandTimeout", 100);
            Orm.Utilities.Common.SetPropertyValue(provider, "ConnectionString", connectionString);
            Orm.Utilities.Common.SetPropertyValue(provider, "ContextAssembly", "Orm.MapContext.dll");
            Orm.Utilities.Common.SetPropertyValue(provider, "DbContextName", customerCode);
            Orm.Utilities.Common.SetPropertyValue(provider, "ProviderName", "Oracle.DataAccess.Client");
            Orm.Utilities.Common.SetPropertyValue(provider, "ContextType", "SCB.Framework.UI.MapContext.RegisterMapContext");
            return provider;
        }

        private string[] GetDeleteSql()
        {
            string[] sqls = {"truncate table toothcasehistory","truncate table  ourecipe",
                "truncate table  ouinvoicepay","truncate table  ouinvoiceinvitemsum",
                "truncate table ouinvoicefeetysum","truncate table  ouinvoicedtl",
                "truncate table ouinvoice","delete   ouhosinfo where name not in('张三','测试1')",
                //"truncate table bsuserwindows",
                //"truncate table bsuserroom",
                "delete from  bsuserrole where operid<>9","delete from  bsusermodule where operid<>9",
                //"delete from  bsusermenu where operid<>9",
                "delete from  bsuserlocation  where operid<>9",
                //"truncate table bsuserhouse",
                "update tmpemr set operid=9",
                "delete from  bsuser where id<>9","truncate table bsusageitem",
                "truncate table bsusage","truncate table bsunitratio",
                //"truncate table bstestpaper",
                //"truncate table bsspecialtyroom",
                //"truncate table bsspeciality",
                "truncate table bsscalediscount",
                //"truncate table bsroomwindow",
                //"truncate table bsroom",
                //"truncate table bsrestoration",
                "truncate table bsrelation",
                "truncate table bsregpatamount","delete bspatient where name not in('张三','测试1')",
                "truncate table bspatientphoto",
                //"truncate table bsordertype",
                "truncate table bsmanufacturer",
                //"truncate table bslocbranch",
                "truncate table bslocation",
                //"truncate table bslimitgroup",
                "truncate table bsjcgroup",
                "truncate table bsbed","truncate table bsbasedrug",
                "update gblsetting set setvalue='行心口腔'  where keynum='ReportTitleHeader'",
                "update gblsetting set setvalue='14'  where keynum='ArrearsInvItemId'",
                "update gblsetting set setvalue='0'  where keynum='IsEnableSchedule'",
                "update gblsetting set setvalue='true'  where keynum='IsAutoAuditStockBill'",
                "update gblsetting set setvalue='false'  where keynum='IsSetInvoice'",
                "update gblsetting set setvalue='false'  where keynum='IsSetInvoiceNum'",
                "update gblsetting set setvalue='0'  where keynum='IsEnableConversation'",
                //"update gblsetting set setvalue='true'  where keynum='IsUsingNewRecord'",
                "update gblsetting set setvalue='0'  where keynum='PercentagePoints'",
                "update gblsetting set setvalue='0'  where keynum='ScoreToMoney'",
                "update gblsetting set setvalue='false'  where keynum='IsFirstLogin'",
                "update gblsetting set setvalue='0'  where keynum='IsEnableBirthDateInput'",
                "update gblsetting set setvalue='true'  where keynum='IsChangeElereCord'",
                "update gblsetting set setvalue='0'  where keynum='PhoneNotMustInput'",
                "update gblsetting set setvalue='true'  where keynum='PrintCross'",
                "update gblsetting set setvalue='true'  where keynum='IsDisplayRecycle'",
                "update gblsetting set setvalue='true'  where keynum='IsModifyChargeTime'",
                "update gblsetting set setvalue='http://kqy.Orm.com/explian/'  where keynum='IsModifyUrl'"};
            return sqls;
        }

        /// <summary>
        /// 剩余可安装客户数
        /// </summary>
        /// <returns></returns>
        public int NoUsedCustomerCount(string versionType)
        {
            try
            {
                return _dbupdate.GetList<Orm.Model.Customer>(m => m.IsActive && !m.IsStartUsing).Count();
            }
            catch (Exception)
            {
                return 0;
            }

        }

        /// <summary>
        /// 获取短信任务
        /// </summary>
        /// <param name="TaskState"></param>
        /// <returns></returns>
        public ReturnValue GetLstTimingSendTask(string TaskState)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.ErrorCode = 0;
                returnvalue.Returns = _dbserver.GetList<TimingSendTask>(t => t.TaskState == int.Parse(TaskState)).ToList();
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "获取短信任务查询异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        public ReturnValue SendLstTimingMessage(string TaskID)
        {
            ReturnValue returnvalue = new ReturnValue();
            try
            {
                returnvalue.ErrorCode = 0;
                Action action = delegate ()
                {
                    var timingSendTask = _dbserver.GetModelByGuid<TimingSendTask>(TaskID);
                    var lstOuCommunicateLog = new List<OuCommunicateLog>();
                    var lstSendTimingMessage = _dbserver.GetList<TimingMessage>(t => t.TaskID == TaskID && t.SendState == 0);
                    if (lstSendTimingMessage.Count == 0) return;
                    var location = _dbserver.GetAllList<BsLocation>().FirstOrDefault();
                    foreach (var item in lstSendTimingMessage)
                    {
                        item.IsModify = true;
                        if (item.Mobile.Length == 11 && item.Mobile.Trim().Substring(0, 1) == "1")
                        {
                            var msgContent = GetSendTaskContent(item, timingSendTask);
                            var returnValue = SendMessage(item.Mobile, msgContent, location.Name);
                            if (returnValue.ErrorCode == 0)
                            {
                                var sendLog = SaveSendedInfo(item, msgContent,timingSendTask.CreatOperID);
                                lstOuCommunicateLog.Add(sendLog);
                                item.SendNum += 1;
                                item.SendState = 1;
                                item.SendTime = DateTime.Now;
                                item.MessageContent = msgContent;
                            }
                            else
                            {
                                item.SendState = 2;
                                item.MsgError = returnValue.ErrorMsg;
                                item.SendTime = DateTime.Now;
                                item.MessageContent = msgContent;
                            }
                        }
                        if (lstSendTimingMessage.Count > 0)
                            System.Threading.Thread.Sleep(1000);
                    }
                    timingSendTask.TaskState = 1;
                    timingSendTask.MsgError = returnvalue.ErrorMsg;
                    timingSendTask.SendTime = DateTime.Now;
                    timingSendTask.IsModify = true;
                    _dbserver.Save(lstOuCommunicateLog);
                    _dbserver.SaveChild<TimingSendTask, TimingMessage>(timingSendTask, lstSendTimingMessage, "TaskID");
                };
                _dbserver.Commit(action);
                return returnvalue;
            }
            catch (Exception ex)
            {
                returnvalue.ErrorCode = -1;
                returnvalue.ErrorMsg = "发送发送短信列表查询异常。详细信息：" + ex.Message;
                return returnvalue;
            }
        }

        /// <summary>
        /// 发送短信方法
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="content"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        public ReturnValue SendMessage(string phone, string content, string sign)
        {
            ReturnValue returnValue = new ReturnValue();
            try
            {
                content = content + string.Format("【{0}】", sign);
                var result = ShortMessage.SendMessage(phone, content);
                if (result)
                    returnValue.ErrorCode = 0;
                else
                {
                    returnValue.ErrorCode = -1;
                    returnValue.ErrorMsg = "短信发送失败！";
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                returnValue.ErrorCode = -1;
                returnValue.ErrorMsg = ex.Message;
                return returnValue;
            }

        }

        /// <summary>
        /// 历史记录
        /// </summary>
        /// <param name="lstOuCommunicateLog"></param>
        /// <param name="item"></param>
        /// <param name="msgContent"></param>
        /// <returns></returns>
        private OuCommunicateLog SaveSendedInfo(TimingMessage item, string msgContent, string creatOperID)
        {
            var ouCommunicateLog = new OuCommunicateLog();
            ouCommunicateLog.PatId = item.PatID;
            ouCommunicateLog.Name = item.PatientName;
            ouCommunicateLog.Phone = item.Mobile;
            ouCommunicateLog.Type = 0;
            ouCommunicateLog.OperId = creatOperID;
            ouCommunicateLog.OperTime = DateTime.Now;
            ouCommunicateLog.Comments = msgContent;
            ouCommunicateLog.Notifytype = 1;
            return ouCommunicateLog;
        }

        private string GetSendTaskContent(TimingMessage sendMsg, TimingSendTask sendTask)
        {
            var originContent = string.Empty;
            if (sendMsg.MessageContent != string.Empty && sendMsg.MessageContent != null)
                originContent = sendMsg.MessageContent;
            else
                originContent = sendTask.MessageContent;
            if (originContent != null && originContent != string.Empty)
            {
                if (originContent.Contains("【病人姓名】"))
                    originContent = originContent.Replace("【病人姓名】", sendMsg.PatientName);
                if (originContent.Contains("【病人性别】"))
                    originContent = originContent.Replace("【病人性别】", GetSexName(sendMsg.Sex));
            }
            return originContent;
        }

        private string GetSexName(string sex)
        {
            var sexName = string.Empty;
            if (sex == "M")
                sexName = "先生";
            else if (sex == "F")
                sexName = "女士";
            else
                sexName = "病人";
            return sexName;
        }

    }

    public class BsData
    {
        public string  GUID { get; set; }

        public string Name { get; set; }
    }

    public class BsUserIDComparer : IEqualityComparer<uspBsUser>
    {
        public bool Equals(uspBsUser x, uspBsUser y)
        {
            if (x == null) return y == null; return x.GuId == y.GuId;
        }
        public int GetHashCode(uspBsUser obj)
        {
            if (obj == null) return 0; return obj.GuId.GetHashCode();
        }
    }
}
