using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Orm.Framework.Services;
using Orm.Model;
using Orm.Model.Custom;
using Orm.Model.Custom.UspModel;
using Orm.Model.EnumDefine;
using Orm.Model.Parameter; 

namespace Orm.Framework.Common
{
    public class Utils
    {
        private static DBServiceBase _db = new DBServiceBase();
        public static string GetSystemSetting(string keyNum)
        {

            var list = _db.GetList<GblSetting>(t => t.KeyNum == keyNum);

            if (list != null && list.Count() > 0)
            {
                return list.ElementAt(0).SetValue;
            }
            throw new Orm.Utilities.InformationException(string.Format("参数{0}没有设置，调用失败，请通知系统管理员！", keyNum));
        }

        /// <summary>
        /// 单位整散比转换
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="firstUnitId"></param>
        /// <param name="secondUnitId"></param>
        /// <returns></returns>
        public static double GetUnitRatio(string itemId, string firstUnitId, string secondUnitId)
        {
            double ratio = 0.0;
            var db = new DBServiceBase();
            List<BsUnitRatio> lst = db.GetAllList<BsUnitRatio>();
            List<BsUnitRatio> lstRatio;
            lstRatio = lst.FindAll(t => t.ItemId == itemId && t.UnitId2 == firstUnitId && t.UnitId1 == secondUnitId);
            if (lstRatio != null && lstRatio.Count > 0)
            {
                ratio = 1 / lstRatio[0].DrugRatio;
            }
            else
            {
                lstRatio = lst.FindAll(t => t.ItemId == itemId && t.UnitId2 == secondUnitId && t.UnitId1 == firstUnitId);
                if (lstRatio != null && lstRatio.Count > 0)
                {
                    ratio = lstRatio[0].DrugRatio;
                }
                else
                {
                    ratio = 1;
                }
            }
            return ratio;
        }

        public static ReturnValue<bool> CheckBeginCharge(string mzRegId, int lockType)
        {
            ReturnValue<bool> sResponse = new ReturnValue<bool>();
            List<RmSending> lstRmSending = new List<RmSending>();
            if (lockType == (int)EnumLockType.HospId)
            {
                lstRmSending = _db.DataRepository.GetQueryable<RmSending>().Where(m => m.HospId == mzRegId).ToList();
            }
            else if (lockType == (int)EnumLockType.MzRegId)
            {
                lstRmSending = _db.DataRepository.GetQueryable<RmSending>().Where(m => m.MzRegId == mzRegId).ToList();
            }
            if (lstRmSending.Count <= 0)
            {
                return sResponse;
            }
            sResponse.IsSuccess = true;
            sResponse.Success("您要踢出的病人可能处于收费状态,请稍候再试！");
            return sResponse;
        }

        public static string GetIllDesc(string mzRegId)
        {
            var lstOuClincDiag = _db.DataRepository.GetQueryable<OuClincDiag>().Where(x => x.MzRegId == mzRegId).ToList();
            if (lstOuClincDiag.Count == 0)
            {
                return string.Empty;
            }
            StringBuilder illness = new StringBuilder();
            lstOuClincDiag.ForEach(m =>
            {
                illness.Append(m.IllDesc);
            });
            return illness.ToString();
        }

        public static bool CheckRmSending(string roomId)
        {
            var lstRmSending = _db.DataRepository.GetQueryable<RmSending>().Where(m => m.RoomId == roomId);
            if (lstRmSending.Any())
            {
                return true;
            }
            return false;
        }

        public static bool CheckSettingContainFormat(string keyNum, object item)
        {
            string keyValue = GetSystemSetting(keyNum);
            if (keyValue == string.Empty) return true;
            string[] itemIds = item.ToString().Split(',', '，', '|');
            for (int i = 0; i < itemIds.Length; i++)
            {
                if (keyValue.Contains(string.Format("[{0}]", itemIds[i])))
                {
                    return true;
                }
            }
            return false;
        }
        //---public static bool CheckIsWzGysHouseId(int roomId)
        //{
        //    int locationId = Convert.ToInt32(_db.GetModelByGuid<BsHouse>(roomId).HospitalId);
        //    List<BsHouse> lstHouse = _db.GetAllList<BsHouse>();
        //    foreach (BsHouse infoHouse in lstHouse)
        //    {
        //        if (infoHouse.HospitalId == locationId && infoHouse.GUID == Convert.ToInt32(Utils.GetSystemSetting("WzGysHouseId")))
        //        { 
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        /// <summary>
        /// 保存日志
        /// </summary>
        /// <param name="operType">操作类型：1-新增 2-删除 3-修改  </param>
        /// <param name="TableDesc">操作的表的描述</param>
        /// <param name="operTableName">操作的表名</param>
        /// <param name="operId">操作人</param>
        /// <param name="operName">操作人名称</param>
        /// <param name="machineName">客户端机器名</param>
        /// <param name="operIP">客户端IP</param>
        /// <param name="operDate">操作时间</param>
        /// <param name="operContent">日志内容</param>
        /// <param name="operTableID">主键值得ID</param>
        /// <param name="columnName">列名</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static Trace GetLogFieldChanged(int operType, string TableDesc, string operTableName, string operId, string operName, string machineName, string operIP, DateTime operDate, string operContent, string operTableID = "", string columnName = "", string oldValue = "", string newValue = "")
        {
            Trace log = new Trace
            {
                Messages = operContent,
                OperateType = operType.ToString(),
                Type = operTableName,
                UserID = operId,
                RecordId = operTableID,
                Ip = operIP,
                CreateDate = operDate,
                WorkFlow = TableDesc
            };
            return log;
        }

        /// <summary>
        /// 获得整散比(Fn_GetRatio)
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="drugsId"></param>
        /// <param name="unitId1"></param>
        /// <param name="unitId2"></param>
        /// <returns></returns>
        public double GetRatio(List<BsUnitRatio> lstUnitRatio, string drugsId, string unitId1, string unitId2)
        {
            if (unitId1 == unitId2)
            {
                return 1;
            }
            Func<BsUnitRatio, bool> predicate = m => m.ItemId == drugsId && m.UnitId1 == unitId1 && m.UnitId2 == unitId2;

            var UnitRatios = lstUnitRatio.Where(predicate);

            if (UnitRatios.Any())
            {
                return UnitRatios.Select(m => m.DrugRatio).Single();
            }
            else
            {
                predicate = m => m.ItemId == drugsId && m.UnitId2 == unitId1 && m.UnitId1 == unitId2;
                UnitRatios = UnitRatios.Where(predicate);
                if (UnitRatios.Any())
                {
                    return 1 / UnitRatios.Select(m => m.DrugRatio).Single();
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>
        /// 获得整散比(Fn_GetRatio)
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="drugsId"></param>
        /// <param name="unitId1"></param>
        /// <param name="unitId2"></param>
        /// <returns></returns>
        public double GetRatio(string drugsId, string unitId1, string unitId2)
        {
            if (unitId1 == unitId2)
            {
                return 1;
            }
            Func<BsUnitRatio, bool> predicate = m => m.ItemId == drugsId && m.UnitId1 == unitId1 && m.UnitId2 == unitId2;

            var bsUnitRatio = _db.GetAllList<BsUnitRatio>().Where(predicate);

            if (bsUnitRatio.Any())
            {
                return bsUnitRatio.Select(m => m.DrugRatio).Single();
            }
            else
            {
                predicate = m => m.ItemId == drugsId && m.UnitId2 == unitId1 && m.UnitId1 == unitId2;
                bsUnitRatio = bsUnitRatio.Where(predicate);
                if (bsUnitRatio.Any())
                {
                    return 1 / bsUnitRatio.Select(m => m.DrugRatio).Single();
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>
        /// Fn_GetINIll
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="hospId"></param>
        /// <returns></returns>
        public string GetINIll(string hospId)
        {
            string illDesc = _db.DataRepository.GetQueryable<InHosMzIll>().Where(m => m.HospId == hospId).Select(m => m.IllDesc).Take(1).Single();
            if (string.IsNullOrWhiteSpace(illDesc))
            {
                illDesc = "空";
            }
            return illDesc;
        }

        /// <summary>
        /// Fn_TruncDate
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DateTime GetTruncDate(DateTime dt)
        {
            return dt.AddDays(dt.Day - 0);
        }

        /// <summary>
        /// Fn_GetStrDate
        /// </summary>
        /// <param name="strDate"></param>
        /// <returns></returns>
        public string GetStrDate(DateTime strDate)
        {
            if (strDate == DateTime.MinValue)
            {
                return string.Empty;
            }
            else
            {
                return strDate.ToString("yyyy-MM-dd");
            }
        }

        /// <summary>
        /// [Fn_GetDrugReqStore]
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="intCode"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        //public decimal GetDrugReqStore(string intCode, string roomId)
        //{
        //    bool predicate(Rmstore x) => x.ItemId == intCode && x.RoomId == roomId;
        //    var stocknum = uow.Repo<RmstoreDto>().AsQueryable().ToList().
        //        Where(predicate).ToList().Sum(x => x.StockNum);
        //    return stocknum;
        //}

        /// <summary>
        /// [Fn_RequestBack_Num]
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="isBacked"></param>
        /// <param name="reqDtlId"></param>
        /// <returns></returns>
        public double GetBackNum(bool isBacked, string reqDtlId)
        {
            var result = _db.DataRepository.GetQueryable<InDrugReqBack>().Where(x => x.GUID == reqDtlId
                && x.IsBack == isBacked).ToList().Sum(x => x.Totality);
            return result;
        }

        /// <summary>
        /// [Fn_Request_BackReq]
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="SeqDtlID"></param>
        /// <returns></returns>
        public bool GetBackReq(string seqDtlID)
        {
            var inDrugReqBackDto = _db.DataRepository.GetQueryable<InDrugReqBack>().Where(x => x.ReqDtlId == seqDtlID && !x.IsBack).ToList().FirstOrDefault();
            if (inDrugReqBackDto != null)
            {
                return inDrugReqBackDto.IsBack;
            }
            return false;
        }

        /// <summary>
        /// Fn_GetTableVwHist
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="beginTime"></param>
        /// <returns></returns>
        public int GetTableVwHist(DateTime beginTime)
        {
            DateTime dtCurrentDateTime = _db.GetServerTime();
            var moveDayHist = _db.SysParam.GetByName<int>("MoveDayHist");

            if (dtCurrentDateTime.Day - beginTime.Day >= moveDayHist - 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        /// <summary>
        /// dbo.GetSexString
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        public string GetSexString(string sex)
        {
            if (sex == "M")
            {
                sex = "男";

            }
            else if (sex == "F")
            {
                sex = "女";

            }
            else if (sex == "O")
            {
                sex = "其他";

            }
            else if (sex == "男")
            {
                sex = "男";

            }
            else if (sex == "女")
            {
                sex = "女";
            }
            else
            {
                sex = "未知性别" + sex;
            }

            return sex;
        }

        /// <summary>
        /// Fn_StrMoney
        /// </summary>
        /// <param name="nhAmount"></param>
        /// <returns></returns>
        public string NumChangeToString(decimal nhAmount)
        {
            return string.Empty;
        }

        public static bool CheckPatientInStatus(string hospId)
        {
            InHosInfo infoInHosInfoInfo = _db.GetModelByGuid<InHosInfo>(hospId);
            if (infoInHosInfoInfo.LsInStatus == (int)EnumInStatus.LeaveHospital || infoInHosInfoInfo.LsInStatus == (int)EnumInStatus.WaitForLeaveHospital)
            {
                return false;
            }
            return true;
        }

        public static bool EndAllLongAdvice(UspBed patInfo, string userId)
        {
            DateTime dtCurrentDateTime = _db.GetServerTime();
            var lstInAdviceLong = _db.DataRepository.GetQueryable<InAdviceLong>().Where(x => x.HospId == patInfo.HospId && !x.IsEnd).ToList();
            foreach (var item in lstInAdviceLong)
            {
                item.IsEnd = true;
                item.EndDoctorID = patInfo.DoctorId;
                item.EndOperID = userId;
                item.EndOperTime = dtCurrentDateTime;
            }
            _db.InsertOrUpdate<InAdviceLong>(lstInAdviceLong);
            return true;
        }

        public static bool CancelAllTempAdvice(string hospId, string userId)
        {
            DateTime dtCurrentDateTime = _db.GetServerTime();
            var lstInAdviceTemp = _db.DataRepository.GetQueryable<InAdviceTemp>().Where(x => x.HospId == hospId && !x.IsCancel).ToList();
            foreach (var item in lstInAdviceTemp)
            {
                item.IsCancel = true;
                item.CancelOperID = userId;
                item.CancelOperTime = dtCurrentDateTime;
            }
            _db.InsertOrUpdate<InAdviceTemp>(lstInAdviceTemp);
            return true;
        }


        public static void HoldRmSending(string roomId, string userId, DateTime dt)
        {
            if (!string.IsNullOrEmpty(roomId))
            {
                RmSending rmSending = new RmSending();
                rmSending.RoomId = roomId;
                rmSending.OperId = userId;
                rmSending.OperTime = dt;
                _db.Add<RmSending>(rmSending);
            }
        }
        public static void HoldRmSending(string roomId, string userId, DateTime dt, int hospitalId, int hisType)
        {
            if (!string.IsNullOrEmpty(roomId))
            {
                RmSending rmSending = new RmSending();
                rmSending.RoomId = roomId;
                rmSending.OperId = userId;
                rmSending.OperTime = dt;
                rmSending.HospitalId = hospitalId;
                rmSending.HisType = hisType;
                _db.Add<RmSending>(rmSending);
            }
        }
        public static void HoldRmSendings(string roomId, string userId, DateTime dt, int hospitalId, int hisType)
        {
            if (!string.IsNullOrEmpty(roomId))
            {
                RmSending rmSending = new RmSending();
                rmSending.RoomId = roomId;
                rmSending.OperId = userId;
                rmSending.OperTime = dt;
                rmSending.HospitalId = hospitalId;
                rmSending.HisType = hisType;
                _db.Add<RmSending>(rmSending);
            }
        }
        public static void EndRmSending(string roomId)
        {
            _db.Delete<RmSending>(m => m.RoomId == roomId);
        }
        public static bool IsSendToCenterRoom(string usageId, int hospitalId)
        {
            var centerHospitalId = _db.SysParam.GetByName<int>("CenterHospitalId");
            bool isUseDropDrugCenterRoom = _db.SysParam.GetByName<bool>("IsUseDropDrugCenterRoom");
            if (centerHospitalId == hospitalId && isUseDropDrugCenterRoom && CheckSettingContainFormat("DropDrugCenterRoomUsageId", usageId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string TrimComer(string str)
        {
            if (str.StartsWith("，"))
            {
                return str.Substring(1);
            }
            return str;
        }


        public static bool CheckNotBackDrugForm(string itemId)
        {
            var lstBsItemDrug = _db.GetAllList<BsItemDrug>().AsQueryable().ToList();
            var infoItem = _db.GetAllList<BsItem>().AsQueryable().ToList().Where(x => x.GUID == itemId).Single();
            var inNotBackDrugFormIds = _db.SysParam.GetByName<int>("InNotBackDrugFormIds", ParamDelimiter.Bracket);
            if (lstBsItemDrug.Count > 0 && inNotBackDrugFormIds.ToString().Contains(lstBsItemDrug.FirstOrDefault().FormId.ToString())
                && lstBsItemDrug.FirstOrDefault().UnitKc != infoItem.UnitInId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //判断中成药在哪个药房去发
        public static bool CheckRoomHasItem(string itemId, string roomId)
        {
            var lstUnderLine = _db.DataRepository.GetQueryable<RmUnderLine>().Where(x => x.ItemId == itemId && x.RoomId == roomId).ToList();
            if (lstUnderLine.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetLocationPrice(string itemId, string locationId, int lsInOut)
        {
            var infoLocation = _db.GetList<BsLocation>(x => x.GUID == locationId).FirstOrDefault();
            var infoItem = _db.GetList<BsItem>(x => x.GUID == itemId).Single();

            if (infoItem.LsRpType < (int)EnumRpType.Test && infoLocation.IsPriceSub)
            {
                return infoItem.PriceSub;
            }
            else if (lsInOut == 0)
            {
                return infoItem.PriceDiag;
            }
            else if (lsInOut == (int)EnumLocationInOut.In)
            {
                return infoItem.PriceDiag;
            }
            else if (lsInOut == (int)EnumLocationInOut.Out)
            {
                return infoItem.PriceIn;
            }
            return 0;
        }


        public void InsertLog<TMain, TDetail>(TMain infoMain, IList<TDetail> lstDetail,
                  List<UspInSendDrugClassPrint> lstInDrugIssueDtl, EnumRmActType actType, bool isSaveStockNumToDtl,
                  bool isOut, string locationid, string inOuPatId, DateTime dt)
                  where TMain : BaseModel, new()
                  where TDetail : BaseModel, new()
        {
            RmStoreLog infoRmStoreLog = new RmStoreLog();
            List<UspInSendDrugClassPrint> listInDrugIssueDtl = null;
            List<RmStoreLog> lstRmStoreLog = new List<RmStoreLog>();
            Rmstores infoRmStore = new Rmstores();
            //lstDetail.Sort("InBatchId");
            string lastInBatchId = string.Empty;
            if (isSaveStockNumToDtl)
            {
                string RoomId = infoMain.GetPropertyValue("RoomId").ToString();
                foreach (TDetail infoDetail in lstDetail)
                {
                    string itemid = infoDetail.GetPropertyValue("ItemId").ToString();
                    List<Rmstores> lstHuStores = _db.DataRepository.GetQueryable<Rmstores>().Where(m => m.ItemId == itemid
                        && !m.IsBalance
                        && m.RoomId == RoomId).ToList();
                    double sumDrugNum = lstDetail.Where(m => m.GetPropertyValue("ItemId").ToString() == itemid)
                        .Sum(m => Convert.ToDouble(m.GetPropertyValue("DrugNum")));
                    double beforeDrugNum = lstHuStores.Sum(m => m.StockNum);
                    if (isOut)
                    {
                        sumDrugNum = -sumDrugNum;
                    }
                    infoDetail.SetPropertyValue("BeforeStockNum", beforeDrugNum);
                    infoDetail.SetPropertyValue("AfterStockNum", beforeDrugNum + sumDrugNum);
                }
            }
            foreach (TDetail infoDetail in lstDetail)
            {
                //如果是相同批次，则infoRmStoreLog的数量递减而不是每次读数据库的StockNum
                double stockNum = 0;
                if (lastInBatchId != infoDetail.GetPropertyValue("InBatchId").ToString())
                { }
            }
        }

        public bool CheckIsSendToCenterRoom(string usageId, string locationId, int hospitalId)
        {
            var bsLocationDto = _db.GetAllList<BsLocation>().Where(x => x.GUID == locationId).Single();
            if (IsSendToCenterRoom(usageId, hospitalId) && bsLocationDto.InRoomId == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 发布信息
        /// </summary>
        /// <param name="uow"></param>
        /// <param name="userId"></param>
        /// <param name="message"></param>
        /// <param name="roleId"></param>
        /// <param name="locationId"></param>
        /// <returns></returns>
        public ReturnValue AddEmail(string userId, string message, string roleId, string locationId, string doctorId)
        {
            ReturnValue returnValues = new ReturnValue();
            GblEmail infoEmail = new GblEmail();
            infoEmail.OperId = userId;
            infoEmail.OperTime = _db.GetServerTime();
            infoEmail.Content = message;
            infoEmail.IsPriority = true;
            var InsertId = _db.Add<GblEmail>(infoEmail);
            string emailId = InsertId;
            if (roleId != string.Empty)
            {
                var id = from bsLocation in _db.DataRepository.GetQueryable<BsLocation>()
                         where bsLocation.LsInOut > (int)EnumLocationInOut.All
                         select bsLocation.GUID;
                var lstUser = _db.DataRepository.GetQueryable<BsUserRole>().ToList().Where(x => x.RoleId.ToString().Contains(roleId));
                if (!string.IsNullOrEmpty(locationId))
                {
                    GblEmailUser infoEmailUser = new GblEmailUser();
                    foreach (var item in lstUser)
                    {
                        var lstBsUserLocation = _db.DataRepository.GetQueryable<BsUserLocation>().Where(x => x.OperId == item.OperId && x.LocationId == locationId).ToList();
                        if (lstBsUserLocation.Count > 0)
                        {
                            continue;
                        }

                        var lstBsUserLocationCount = _db.DataRepository.GetQueryable<BsUserLocation>().Where(x => x.OperId == item.OperId
                            && x.LocationId.ToString().Contains(id.ToString())).Count();

                        if (lstBsUserLocationCount > 0) { continue; }
                        infoEmailUser.EmailId = emailId;
                        infoEmailUser.OperId = item.OperId;
                        infoEmailUser.OperId = userId;
                        _db.Add<GblEmailUser>(infoEmailUser);
                    }
                }
                if (!string.IsNullOrEmpty(doctorId))
                {
                    GblEmailUser infoEmailUser = new GblEmailUser();
                    infoEmailUser.EmailId = emailId;
                    infoEmailUser.OperId = userId;
                    _db.Add<GblEmailUser>(infoEmailUser);
                }
            }
            return returnValues;
        }
        public string ExecInsertAccountItem(ExecInsertAccountItem info)
        {
            return ExecInsertAccountItem(info.HospId, info.AdviceId, info.ItemId, info.Totality, info.LsPerform, info.CancelId,
                   info.DoctorId, info.LocationId, info.ExecLocationId, info.PriceIn, info.ReqOperId, info.OperId, info.LsMarkType,
                   info.ExecOperId, info.RegOperTime, info.RegDate, info.HospitalId, info.HisType, info.Memo);
        }

        public string ExecInsertAccountItem(string hospId, string adviceId, string itemId, double totality, int lsPerform, string cancelId, string doctorId, string locationId, string execLocationId, double priceIn, string reqOperId, string operId, int lsMarkType, string execOperId, DateTime regOperTime, string regDate, int hospitalId, int hisType = 1, string memo = "")
        {
            DateTime dt = _db.GetServerTime();
            if (regOperTime == DateTime.MinValue)
            {
                regOperTime = dt;
            }
            if (string.IsNullOrEmpty(doctorId))
            {
                var drId = _db.DataRepository.GetQueryable<InHosInfo>().Where(m => m.GUID == hospId).Select(m => m.DoctorId).Single();
                doctorId = string.IsNullOrEmpty(drId) ? string.Empty : drId;
            }
            if (string.IsNullOrWhiteSpace(regDate) || regDate.Length != 10)
            {
                regDate = regOperTime.ToString("yyyy-MM-dd");
            }

            var feeHsZyId = _db.DataRepository.GetQueryable<BsItemLocation>()
                .Where(m => m.ItemId == itemId && m.LocationId == locationId)
                .Select(m => m.FeeHsZyId).ToList().FirstOrDefault();

            string adviceName = string.Empty;
            if (!string.IsNullOrWhiteSpace(adviceId))
            {
                switch (lsMarkType)
                {
                    case (int)EnumMarkType.LongAdvice:
                        adviceName = (from at in _db.DataRepository.GetQueryable<InAdviceLong>().Where(m => m.GUID == adviceId)
                                      join i in _db.DataRepository.GetQueryable<BsItem>() on at.ItemId equals i.GUID
                                      select (string.Concat(at.GroupNum.ToString(), ".", i.Name))).Single();
                        break;
                    case (int)EnumMarkType.TemporaryAdvice:
                        adviceName = (from al in _db.DataRepository.GetQueryable<InAdviceTemp>().Where(m => m.GUID == adviceId)
                                      join i in _db.DataRepository.GetQueryable<BsItem>() on al.ItemId equals i.GUID
                                      select (string.Concat(al.GroupNum.ToString(), ".", i.Name))).Single();
                        break;
                    default:
                        break;
                }
            }

            var inHosInfoQuery = _db.DataRepository.GetQueryable<InHosInfo>().Where(m => m.GUID == hospId);
            var lstBsItemPatType = inHosInfoQuery.Join(_db.DataRepository.GetQueryable<BsItemPatType>(),
                hi => hi.PatTypeId, ipt => ipt.PatTypeId, (hi, ipt) => ipt);
            var lstBsLimitGroup = lstBsItemPatType.Join(_db.DataRepository.GetQueryable<BsLimitGroup>(),
                ipt => ipt.LimitGroupId, lg => lg.GUID, (ipt, lg) => lg);
            var lstbsItem = lstBsItemPatType.Join(_db.DataRepository.GetQueryable<BsItem>(),
                ipt => ipt.ItemId, i => i.GUID, (ipt, i) => i).Where(m => m.GUID == itemId);

            var inInvoiceDtl = (from inHosInfo in inHosInfoQuery
                                join bsItemPatType in lstBsItemPatType on inHosInfo.PatTypeId equals bsItemPatType.PatTypeId
                                join bsLimitGroup in lstBsLimitGroup on bsItemPatType.LimitGroupId equals bsLimitGroup.GUID into bsLimitGroupTable
                                from bsLimitGroupInfo in bsLimitGroupTable.DefaultIfEmpty()
                                join bsItem in lstbsItem on bsItemPatType.ItemId equals bsItem.GUID
                                select new InInvoiceDtl
                                {
                                    HospId = inHosInfo.GUID,
                                    ItemId = bsItemPatType.ItemId,
                                    RegOperTime = regOperTime,
                                    RegOperId = reqOperId,
                                    LocationId = locationId,
                                    AdviceId = adviceId,
                                    LsMarkType = (short)lsMarkType,
                                    Totality = (double)totality,
                                    PriceIn = (double)priceIn,
                                    UnitId = bsItem.UnitInId,
                                    IsPay = false,
                                    DiscIn = bsItemPatType.DiscIn,
                                    DiscSelf = 1,
                                    Amount = (double)totality * (double)priceIn,
                                    AmountFact = (double)totality * (double)priceIn * bsItemPatType.DiscIn,
                                    AmountSelf = (double)totality * (double)priceIn * bsItemPatType.DiscIn,
                                    AmountTally = (double)totality * (double)priceIn,
                                    AmountPay = (double)totality * (double)priceIn * bsItemPatType.DiscIn,
                                    InvoId = null,
                                    LsPerform = (short)lsPerform,
                                    IsModiDisc = false,
                                    LimitGroupId = bsItemPatType.LimitGroupId,
                                    LimitFee = bsLimitGroupInfo.LimitFeeZy,
                                    DoctorId = doctorId,
                                    ExecOperId = operId,
                                    ExecLocId = execLocationId,
                                    InvItemId = bsItemPatType.InvInItemId,
                                    FeeId = bsItem.FeeZyId,
                                    FeeHsId = feeHsZyId,
                                    LsReportType = 0,
                                    Memo = string.Empty,
                                    OperTime = dt,
                                    OperId = operId,
                                    IsCancel = false,
                                    CancelId = cancelId,
                                    IsManual = false,
                                    AdviceName = adviceName,
                                    RegDate = regDate,
                                    IsAutoCharged = false,
                                    HisType = hisType,
                                    HospitalId = hospitalId
                                }
                         );
            var newInvoiceDtl = inInvoiceDtl.FirstOrDefault();
            if (newInvoiceDtl == null) return string.Empty;
            return _db.Add<InInvoiceDtl>(newInvoiceDtl);
        }
        public string ExecInsertAccountItem(string hospId, string adviceId, string itemId, double totality, int lsPerform, string cancelId, string doctorId, string locationId, string execLocationId, double priceIn, string reqOperId, string operId, int lsMarkType, string execOperId, DateTime regOperTime, string regDate)
        {
            DateTime dt = DateTime.Now;
            if (regOperTime == dt)
            {
                regOperTime = _db.GetServerTime();
            }
            if (string.IsNullOrEmpty(doctorId))
            {
                var drId = _db.DataRepository.GetQueryable<InHosInfo>().Where(m => m.GUID == hospId).Select(m => m.DoctorId).FirstOrDefault();
                doctorId = drId == null ? drId : null;
            }
            if (string.IsNullOrWhiteSpace(regDate) || regDate.Length != 10)
            {
                //regDate = scalarValued.GetStrDate(regOperTime);
            }
            var feeHsZyId = _db.GetAllList<BsItemLocation>()
                .Where(m => m.ItemId == itemId && m.LocationId == locationId)
                .Select(m => m.FeeHsZyId).FirstOrDefault();
            List<InInvoiceDtl> lstInInvoiceDtlDto = new List<InInvoiceDtl>();
            string id = string.Empty;
            string adviceName = string.Empty;
            var bsItemDto = _db.GetAllList<BsItem>();
            var inAdviceLongDto = _db.DataRepository.GetQueryable<InAdviceLong>().Where(m => m.GUID == adviceId);
            var inAdviceTempDto = _db.DataRepository.GetQueryable<InAdviceTemp>().Where(m => m.GUID == adviceId);
            switch (lsMarkType)
            {
                case (int)EnumMarkType.LongAdvice:
                    adviceName = (from at in inAdviceLongDto
                                  join i in bsItemDto on at.ItemId equals i.GUID
                                  select (string.Concat(at.GroupNum.ToString(), ".", i.Name))).ToString();
                    break;
                case (int)EnumMarkType.TemporaryAdvice:
                    adviceName = (from al in inAdviceTempDto
                                  join i in bsItemDto on al.ItemId equals i.GUID
                                  select (string.Concat(al.GroupNum.ToString(), ".", i.Name))).ToString();
                    break;
                default:
                    break;
            }
            var inHosInfoQuery = _db.DataRepository.GetQueryable<InHosInfo>().Where(m => m.GUID == hospId);
            var bsItemPatType = inHosInfoQuery.Join(_db.DataRepository.GetQueryable<BsItemPatType>(),
                hi => hi.PatTypeId, ipt => ipt.PatTypeId, (hi, ipt) => ipt).ToList();
            var bsLimitGroup = bsItemPatType.Join(_db.DataRepository.GetQueryable<BsLimitGroup>(),
                ipt => ipt.LimitGroupId, lg => lg.GUID, (ipt, lg) => lg).ToList();
            var bsItem = bsItemPatType.Join(_db.DataRepository.GetQueryable<BsItem>(),
                ipt => ipt.ItemId, i => i.GUID, (ipt, i) => i).Where(m => m.GUID == itemId).ToList();
            var inHosInfo = inHosInfoQuery.ToList();
            var inInvoiceDtl = (from hi in inHosInfo
                                join ipt in bsItemPatType on hi.PatTypeId equals ipt.PatTypeId
                                join blg in bsLimitGroup on ipt.LimitGroupId equals blg.GUID into bsLimitGroupTable
                                from lg in bsLimitGroupTable.DefaultIfEmpty()
                                join i in bsItem on ipt.ItemId equals i.GUID
                                select new InInvoiceDtl
                                {
                                    HospId = hi.GUID,
                                    ItemId = ipt.ItemId,
                                    RegOperTime = regOperTime,
                                    RegOperId = reqOperId,
                                    LocationId = locationId,
                                    AdviceId = adviceId,
                                    LsMarkType = (short)lsMarkType,
                                    Totality = totality,
                                    PriceIn = priceIn,
                                    UnitId = i.UnitInId,
                                    IsPay = false,
                                    DiscIn = ipt.DiscIn,
                                    DiscSelf = 1,
                                    Amount = totality * priceIn,
                                    AmountFact = (totality * priceIn) * ipt.DiscIn,
                                    AmountSelf = (totality * priceIn) * ipt.DiscIn,
                                    AmountTally = totality * priceIn,
                                    AmountPay = (totality * priceIn) * ipt.DiscIn,
                                    InvoId = null,
                                    LsPerform = (short)lsPerform,
                                    IsModiDisc = false,
                                    LimitGroupId = ipt.LimitGroupId,
                                    LimitFee = lg.LimitFeeZy,
                                    DoctorId = doctorId,
                                    ExecOperId = operId,
                                    ExecLocId = locationId,
                                    InvItemId = ipt.InvInItemId,
                                    FeeId = i.FeeZyId,
                                    FeeHsId = feeHsZyId,
                                    LsReportType = 0,
                                    Memo = string.Empty,
                                    OperTime = dt,
                                    OperId = operId,
                                    IsCancel = false,
                                    CancelId = cancelId,
                                    IsManual = false,
                                    AdviceName = adviceName,
                                    RegDate = regDate,
                                    IsAutoCharged = false,
                                }
                         ).ToList();
            if (inInvoiceDtl.Count > 0)
            {
                //lstInInvoiceDtlDto = this.Add<InInvoiceDtl>(inInvoiceDtl);
                id = lstInInvoiceDtlDto.FirstOrDefault().GUID;
            }
            return id;
        }

        public void GetUsageItem(string operId, int LsMarkType, string UsageId, string HospId, string FrequencyId, string LocationId, string DoctorId, string ReqOperId, string Memo)
        {
            var lstBsUsageItemInfo = _db.GetList<BsUsageItem>(x => x.UsageId == UsageId);
            string special = string.Empty;
            string memoSpecial = string.Empty;
            string memoTemp = string.Format("，{0}，", Memo);
            memoTemp = memoTemp.Replace(",", "，");
            foreach (BsUsageItem infoSearch in lstBsUsageItemInfo)
            {
                string UsageMemo = string.Format("，{0}，", infoSearch.Memo.Trim());
                if (infoSearch.Memo.Trim() != string.Empty && memoTemp.Contains(UsageMemo) && !memoSpecial.Contains(UsageMemo))
                    special = string.Format("{0}，{1}", special, infoSearch.Memo.Trim()); //本处方是要求特殊情况
                memoSpecial = special;
                if (!memoSpecial.StartsWith("，")) memoSpecial = string.Format("，{0}", memoSpecial);
                if (!memoSpecial.EndsWith("，")) memoSpecial = string.Format("{0}，", memoSpecial);
            }
            if (special.StartsWith("，"))
                special = special.Substring(1);
            DateTime dt = _db.GetServerTime();
            foreach (BsUsageItem infoUsageItem in lstBsUsageItemInfo)
            {
                string UsageMemo = string.Format("，{0}，", infoUsageItem.Memo.Trim());
                if (infoUsageItem.LsUseArea == 1) continue;
                if (!string.IsNullOrEmpty(infoUsageItem.LocationId) && infoUsageItem.LocationId != LocationId) continue;
                if (special == string.Empty && infoUsageItem.Memo.Trim() != string.Empty) continue;
                if (special != string.Empty && infoUsageItem.Memo.Trim() != string.Empty && !memoSpecial.Contains(UsageMemo)) continue;
                if (infoUsageItem.Memo.Trim() == string.Empty && string.IsNullOrEmpty(UsageId)) continue;
                var infoBsItem = _db.GetList<BsItem>(x => x.GUID == infoUsageItem.ItemId).FirstOrDefault();
                double times = 1;   //默认执行一次
                if (!string.IsNullOrEmpty(FrequencyId))
                    times = _db.GetList<BsFrequency>(x => x.GUID == FrequencyId).FirstOrDefault().Times;
                string DetailId = ExecInsertAccountItem(HospId, string.Empty, infoUsageItem.ItemId, infoUsageItem.Memo.Contains("皮试") ? 1 : infoUsageItem.Totality * times, (int)EnumOuPerformFlg.NormalCarryOut, string.Empty, DoctorId,
                                    LocationId, LocationId, infoBsItem.PriceIn, ReqOperId, operId, LsMarkType, ReqOperId, dt, dt.Date.ToString("yyyy-MM-dd"));
            }
        }

        /// <summary>
        /// 验证发票号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInvoNo(string input)
        {
            string pattern = @"^[\d|\w|_]+$";
            return IsMatch(input, pattern);
        }

        #region 匹配方法
        /// <summary>
        /// 验证字符串是否匹配正则表达式描述的规则
        /// </summary>
        /// <param name="inputStr">待验证的字符串</param>
        /// <param name="patternStr">正则表达式字符串</param>
        /// <returns>是否匹配</returns>
        public static bool IsMatch(string inputStr, string patternStr)
        {
            return IsMatch(inputStr, patternStr, false, false);
        }

        ///// <summary>
        ///// 验证字符串是否匹配正则表达式描述的规则
        ///// </summary>
        ///// <param name="inputStr">待验证的字符串</param>
        ///// <param name="patternStr">正则表达式字符串</param>
        ///// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>
        ///// <returns>是否匹配</returns>
        //public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase)
        //{
        //    return IsMatch(inputStr, patternStr, ifIgnoreCase, false);
        //}

        ///// <summary>
        ///// 验证字符串是否匹配正则表达式描述的规则
        ///// </summary>
        ///// <param name="inputStr">待验证的字符串</param>
        ///// <param name="patternStr">正则表达式字符串</param>
        ///// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>
        ///// <returns>是否匹配</returns>
        //public static bool IsMatch(string inputStr, string patternStr, bool ifValidateWhiteSpace)
        //{
        //    return IsMatch(inputStr, patternStr, false, ifValidateWhiteSpace);
        //}

        /// <summary>
        /// 验证字符串是否匹配正则表达式描述的规则
        /// </summary>
        /// <param name="inputStr">待验证的字符串</param>
        /// <param name="patternStr">正则表达式字符串</param>
        /// <param name="ifIgnoreCase">匹配时是否不区分大小写</param>
        /// <param name="ifValidateWhiteSpace">是否验证空白字符串</param>
        /// <returns>是否匹配</returns>
        public static bool IsMatch(string inputStr, string patternStr, bool ifIgnoreCase, bool ifValidateWhiteSpace)
        {
            if (!ifValidateWhiteSpace && string.IsNullOrWhiteSpace(inputStr))
                return false;//如果不要求验证空白字符串而此时传入的待验证字符串为空白字符串，则不匹配
            Regex regex = null;
            if (ifIgnoreCase)
                regex = new Regex(patternStr, RegexOptions.IgnoreCase);//指定不区分大小写的匹配
            else
                regex = new Regex(patternStr);
            return regex.IsMatch(inputStr);
        }
        #endregion
    }
}


