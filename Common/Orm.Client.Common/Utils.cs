using Newtonsoft.Json;
using Orm.Config;
using Orm.Framework.Services;
using Orm.Model;
using Orm.Model.Custom;
using Orm.Model.EnumDefine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;

namespace Orm.Client.Common
{
    /// <summary>
    /// �������ݵĲ���
    /// </summary>
    public class Utils : DBServiceBase
    {
        public static string ReadLocalRegitFile(string key)
        {
            KeyConfig loginUserConfig = ConfigManager<KeyConfig>.GetInfo(ConfigTypes.LocalRegit, key);
            if (loginUserConfig == null)
            {
                if (key.Contains("Is"))
                {
                    return "false";
                }
                else if (key.ToUpper().Contains("ID"))
                {
                    return "0";
                }
                else
                {
                    return string.Empty;
                }
            }
            string returnValue = loginUserConfig.KeyValue;
            if (key.Contains("Time") && Orm.Utilities.Common.IsNumeric(returnValue) && System.Convert.ToInt32(returnValue) < 15000)    //�����ʱ�����ã�����С��30��
            {
                return "15000";
            }
            else
            {
                return returnValue;
            }
        }
        /// <summary>
        /// ˢ�²�������棬���»�ȡָ��������ֵ��ͨ���ڶԲ����޸ĺ����
        /// </summary>
        /// <param name="key">������</param>
        public static void RefreshGblSetting(string key)
        {
            List<Model.GblSetting> lsts = null; //Orm.Config.Service.SystemService.SelectByKeyNum(key).ToList();
            if (lsts != null && lsts.Count > 0)
            {
                if (Global.LstGblSetting.FindAll(t => t.KeyNum == key).Count > 0)
                {
                    Global.LstGblSetting.Remove(Global.LstGblSetting.FindAll(t => t.KeyNum == key)[0]);
                }
                Global.LstGblSetting.Add(lsts[0]);
            }
        }
        //����
        public static string GetSystemSetting(string key)
        {
            if (key == "ReportTitleHeader")
            {
                return Orm.Config.UserProfiles.HospitalName;
                //List<Model.GblSetting> lsts = Orm.Config.Service.CommonServices.SelectByKeyNum("IsChain").ToList();
                //if (lsts != null && lsts.Count > 0 && lsts[0].SetValue == "1")
                //{
                //    return Orm.Config.UserProfiles.HospitalName;
                //}
            }
            List<Model.GblSetting> lst = Global.LstGblSetting.FindAll(t => t.KeyNum == key);
            if (lst == null || lst.Count == 0)
            {
                lst = null;// Orm.Config.Service.SystemService.SelectByKeyNum(key).ToList();
                //fwh �����ݿ�GblSetting ����key��

                if (lst != null && lst.Count > 0)
                {
                    Global.LstGblSetting.Add(lst[0]);
                    return GetKeyValue(lst[0]);
                }
                MessageBox.Show(string.Format("����{0}û�����ã�����ʧ�ܣ���֪ͨϵͳ����Ա��", key), "ϵͳ��ʾ", MessageBoxButton.OK, MessageBoxImage.Information);
                return string.Empty;
            }
            return GetKeyValue(lst[0]);
        }

        /// <summary>
        /// ˢ�²���ֵ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void RefreshGblSetting(string key, string value)
        {
            if (Global.LstGblSetting.Find(t => t.KeyNum == key) != null)
            {
                Global.LstGblSetting.Find(t => t.KeyNum == key).SetValue = value;
            }
        }
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSystemSettingEx(string key)
        {
            List<Model.GblSetting> lst = Global.LstGblSetting.FindAll(t => t.KeyNum == key);
            if (lst == null || lst.Count == 0)
            {
                lst = null;//Orm.Config.DBClientOuInRedis.SelectByKeyNum(key).ToList(); 
                if (lst != null && lst.Count > 0)
                {
                    Global.LstGblSetting.Add(lst[0]);
                    return GetKeyValue(lst[0]);
                }
                return string.Empty;
            }
            return GetKeyValue(lst[0]);
        }



        //����
        private static string GetKeyValue(Model.GblSetting infoGblSetting)
        {
            if (infoGblSetting.KeyNum.EndsWith("Id") && infoGblSetting.SetValue.Trim() == string.Empty)
            {
                return "0";
            }
            else
            {
                return infoGblSetting.SetValue;
            }
        }



        /// <summary>
        /// ��ȡ���ƴ������뷽ʽ
        /// </summary>
        /// <param name="itemName"></param>
        /// <param name="inputWay"></param>
        /// <param name="lenth"></param>
        /// <returns></returns>
        public static string GetWbPyString(string itemName, EnumInputWay inputWay, int lenth)
        {
            if (itemName == null)
            {
                return "";
            }

            string returnString = string.Empty;
            for (int i = 0; i < itemName.Length; i++)
            {
                var lst = Service.DBClientService.GetList<Model.GblChinChar>("Name=@0", itemName.Substring(i, 1));
                if (lst.Count == 0)
                {
                    continue;
                };
                if (inputWay == EnumInputWay.WuBi)
                {
                    returnString += lst[0].WbCode;
                    if (lenth > 1 && lst[0].WbChar != string.Empty)
                    {
                        if (lst[0].WbChar.Length > lenth)
                        {
                            returnString += lst[0].WbChar.Substring(0, lenth - 1);
                        }
                        else
                        {
                            returnString += lst[0].WbChar;
                        }
                    }
                }
                if (inputWay == EnumInputWay.Phoneticize)
                {
                    returnString += lst[0].PyCode;
                    if (lenth > 1 && lst[0].PyChar.Trim() != string.Empty)
                    {
                        if (lst[0].PyChar.Length > lenth)
                        {
                            returnString += lst[0].PyChar.Substring(0, lenth - 1);
                        }
                        else
                        {
                            returnString += lst[0].PyChar;
                        }
                    }
                }
            }
            return returnString == "" ? itemName : returnString.ToUpper();
        }

        ////����
        //public static bool CheckSameLocBranch(int locationId1, int locationId2)
        //{
        //    var lstBsLocBranch1 = Service.DBClientService.GetList<Model.BsLocBranch>("HospitalID =@0", locationId1);
        //    var lstBsLocBranch2 = Service.DBClientService.GetList<Model.BsLocBranch>("HospitalID =@0", locationId2);
        //    foreach (var info2 in lstBsLocBranch2)
        //    {
        //        foreach (var info1 in lstBsLocBranch1)
        //        {
        //            if (info1.BranchId == info2.BranchId)
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        //����
        public static string GetLocalIP()
        {
            string strHostName = Dns.GetHostName(); //�õ�������������
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName); //ȡ�ñ���IP
            string strAddr = ipEntry.AddressList[0].ToString();
            return strAddr;
        }

        //����
        /// <summary>
        /// ��ȡ�����۸���Ϣ
        /// </summary>
        /// <param name="ItemId"></param>
        /// <param name="locationId"></param>
        /// <param name="lsInOut"></param>
        /// <param name="LsPriceState"></param>
        /// <returns></returns>
        public static double GetLocationPrice(string ItemId, string locationId, int lsInOut, int LsPriceState)
        {
            Model.BsLocation infoLocation = UtilsLocCache.GetCacheByID<Model.BsLocation>(locationId);
            Model.BsItem infoItem = UtilsLocCache.GetCacheByID<Model.BsItem>(ItemId);
            //if (Convert.ToBoolean(infoLocation.IsPriceSub) && LsPriceState == 1)
            //    return infoItem.PriceSub;
            // else 
            if (lsInOut == 1)
            {
                return infoItem.PriceDiag;
            }
            //else if (lsInOut == 2)
            //    return infoItem.PriceIn;
            return 0;
        }

        ////����
        ///// <summary>
        ///// ��ȡҽ���������
        ///// </summary>
        ///// <param name="itemId"></param>
        ///// <param name="tallyGroupId"></param>
        ///// <param name="memo"></param>
        ///// <returns></returns>
        //public static string GetYbDesc(int itemId, int tallyGroupId, string memo)
        //{
        //    List<Model.BsItemYb> lst;
        //    if (Convert.ToBoolean(GetSystemSetting("IsAllShowItemYbMemo")))
        //        lst = Orm.Config.Service.DBClientService.GetList<Model.BsItemYb>("ItemId = @0", itemId);
        //    else
        //        lst = Orm.Config.Service.DBClientService.GetList<Model.BsItemYb>("ItemId = @0  && TallyGroupId = @1",itemId, tallyGroupId);
        //    if (lst.Count > 0)
        //    {
        //        if (lst[0].LsYbType == 2)
        //        {
        //        }
        //        if (lst[0].LsYbType >= 3) return memo;
        //        memo += string.Format("��{0}", lst[0].LsYbType == 1 ? "����" : "����");
        //        if (lst[0].YBType != null)
        //            if (lst[0].YBType != null)
        //                memo += string.Format("��{0}", lst[0].YBType);
        //        if (memo.StartsWith("��"))
        //            memo = memo.Substring(1);
        //    }
        //    return memo;
        //}



        //����
        //public static bool CheckBeginCharge(string MzRegId)
        //{
        //    List<Model.RmSending> lstRmSending = Service.DBClientService.GetList<Model.RmSending>("MzRegId=@0", MzRegId);
        //    if (lstRmSending.Count > 0)
        //    {
        //        MessageBox.Show("��Ҫ�߳��Ĳ��˿��ܴ����շ�״̬,���Ժ����ԣ�", "ϵͳ��ʾ", MessageBoxButton.OK, MessageBoxImage.Information);
        //        return true;
        //    }
        //    return false;
        //}



        ////����
        ///// <summary>
        /////  �ж���ҽ�����ǹ��� IsGf���ѣ�IsYb ҽ��
        ///// </summary>
        ///// <param name="PatTypeId">BsPatType���е�ID</param>
        ///// <returns></returns>
        //public static Model.BsTallyGroup IsYb(int PatTypeId)
        //{
        //    var lstBsPatType = UtilsLocCache.GetCacheEntity<Model.BsPatType>(t => t.GUID == PatTypeId);
        //    var lstBsTallyType = UtilsLocCache.GetCacheEntity<Model.BsTallyType>(t => t.GUID == lstBsPatType.TallyTypeId);
        //    var lstBsTallyGroup = UtilsLocCache.GetCacheEntity<Model.BsTallyGroup>(t => t.GUID == lstBsTallyType.TallyGroupId);
        //    return lstBsTallyGroup;
        //}


        /// <summary>
        /// ����ʱ���ȡ���ID
        /// </summary>
        /// <param name="time">��ǰ����ʱ��</param>
        /// <returns></returns>
        public static string GetTimeSpanID(DateTime time)
        {
            string result = string.Empty;
            //�����α�����
            var bsRegTimeSpan = UtilsLocCache.GetCacheAll<BsRegTimeSpan>().Where(t => t.IsActive = true).ToList();
            string timeStr = time.ToShortTimeString();
            if (bsRegTimeSpan.Count > 0)
            {
                var lstbsRegTimeSpan = bsRegTimeSpan.FindAll(t => DateTime.Compare(Convert.ToDateTime(timeStr), Convert.ToDateTime(t.TimeBegin)) >= 0 && DateTime.Compare(Convert.ToDateTime(timeStr), Convert.ToDateTime(t.TimeEnd)) <= 0);
                if (lstbsRegTimeSpan.Count > 0)
                {
                    result = lstbsRegTimeSpan.FirstOrDefault().GUID;
                }
                else
                {
                    result = string.Empty;
                }
            }
            return result;
        }

        /// <summary>
        /// ���˻�����Ϣ��ת��Ϊ����
        /// </summary>
        /// <param name="bsPatient"></param>
        /// <returns></returns>
        public static BsPatientCache BsPatientConvertToCache(BsPatient bsPatient)
        {
            var bsUser = UtilsLocCache.GetCacheByID<BsUser>(bsPatient.DoctorId);
            var doctorName = "";
            if (bsUser != null)
            {
                doctorName = bsUser.Name;
            }

            BsPatientCache bsPatientCache = new BsPatientCache();
            bsPatientCache.GUID = bsPatient.GUID;
            bsPatientCache.Name = bsPatient.Name;
            bsPatientCache.Sex = bsPatient.Sex;
            bsPatientCache.CardNo = bsPatient.CardNo;
            bsPatientCache.IdCardNo = bsPatient.IdCardNo;
            bsPatientCache.Phone = bsPatient.Phone;
            bsPatientCache.AddressHome = bsPatient.AddressHome;
            bsPatientCache.BirthDate = bsPatient.BirthDate;
            bsPatientCache.IsActive = bsPatient.IsActive;
            bsPatientCache.Mobile = bsPatient.Mobile;
            bsPatientCache.PyCode = Orm.Utilities.PyWbHelper.SixBitPYCode(bsPatient.Name);
            bsPatientCache.WbCode = Orm.Utilities.PyWbHelper.SixBitWBCode(bsPatient.Name);
            bsPatientCache.WebUserCode = bsPatientCache.WebUserCode;
            bsPatientCache.LastRegTime = bsPatient.ModiTime == DateTime.MinValue ? bsPatient.OperTime : bsPatient.ModiTime;
            bsPatientCache.DoctorName = doctorName;
            return bsPatientCache;
        }

        public static BsPatientCache BsPatientConvertToCache(BsPatient bsPatient, string vipCardId, string vipLevel, string vipCardNo)
        {
            var bsUser = UtilsLocCache.GetCacheByID<BsUser>(bsPatient.DoctorId);
            var doctorName = "";
            if (bsUser != null)
            {
                doctorName = bsUser.Name;
            }

            BsPatientCache bsPatientCache = new BsPatientCache();
            bsPatientCache.GUID = bsPatient.GUID;
            bsPatientCache.Name = bsPatient.Name;
            bsPatientCache.Sex = bsPatient.Sex;
            bsPatientCache.CardNo = bsPatient.CardNo;
            bsPatientCache.IdCardNo = bsPatient.IdCardNo;
            bsPatientCache.Phone = bsPatient.Phone;
            bsPatientCache.AddressHome = bsPatient.AddressHome;
            bsPatientCache.BirthDate = bsPatient.BirthDate;
            bsPatientCache.IsActive = bsPatient.IsActive;
            bsPatientCache.Mobile = bsPatient.Mobile;
            bsPatientCache.PyCode = Orm.Utilities.PyWbHelper.SixBitPYCode(bsPatient.Name);
            bsPatientCache.WbCode = Orm.Utilities.PyWbHelper.SixBitWBCode(bsPatient.Name);
            bsPatientCache.WebUserCode = bsPatientCache.WebUserCode;
            bsPatientCache.LastRegTime = bsPatient.ModiTime == DateTime.MinValue ? bsPatient.OperTime : bsPatient.ModiTime;
            bsPatientCache.DoctorName = doctorName;
            bsPatientCache.VipLevel = vipLevel;
            bsPatientCache.VipCardID = vipCardId;
            bsPatientCache.VipCardNo = vipCardNo;
            return bsPatientCache;
        }

        #region 

        private static char[] constant =
        {
        '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public static string GenerateRandom(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }
        #endregion

        #region �����4.0����˫��datagrid�ؼ���������
        //'DeferRefresh' is not allowed during an AddNew or EditItem transaction.
        public static bool IsUnderTabHeader(DependencyObject control)
        {
            if (control is System.Windows.Controls.TabItem)
            {
                return true;
            }

            DependencyObject parent = System.Windows.Media.VisualTreeHelper.GetParent(control);
            if (parent == null)
            {
                return false;
            }

            return IsUnderTabHeader(parent);
        }

        public static void CommitTables(DependencyObject control)
        {
            if (control is System.Windows.Controls.DataGrid)
            {
                System.Windows.Controls.DataGrid grid = control as System.Windows.Controls.DataGrid;
                grid.CommitEdit(System.Windows.Controls.DataGridEditingUnit.Row, true);
                return;
            }
            int childrenCount = System.Windows.Media.VisualTreeHelper.GetChildrenCount(control);
            for (int childIndex = 0; childIndex < childrenCount; childIndex++)
            {
                CommitTables(System.Windows.Media.VisualTreeHelper.GetChild(control, childIndex));
            }
        }

        #endregion     

        ///<summary>  
        ///��*.exe.config�ļ���appSettings���ý�����һ�Լ�ֵ��  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            //��ȡ���򼯵������ļ�
            string assemblyConfigFile = Assembly.GetEntryAssembly().Location;
            System.Configuration.Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(assemblyConfigFile);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(System.Configuration.ConfigurationSaveMode.Modified);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");
        }


        /// <summary>
        /// ����dataset  û��where����
        /// </summary>
        /// <param name="QueryString">��ѯ���</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string QueryString)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLDBConnection"].ConnectionString;
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(QueryString, connection);
            adapter.Fill(ds);
            return ds;
        }

        public static DataSet GetDataSet(string QueryString, SqlParameter[] prmArr)
        {
            return GetDataSet(QueryString, prmArr, CommandType.Text);
        }


        /// <summary>
        /// ���ݲ�ѯ���ȡ��DataSet�������ѯ���������������ⲿ�����������SQL���ʱ������ȫ��ִ��
        /// </summary>
        /// <param name="QueryString">��ѯ���</param>
        /// <param name="prmCol">SQL���Ĳ�������</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string QueryString, SqlParameter[] prmArr, CommandType cmdType)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SQLDBConnection"].ConnectionString;
            DataSet ds = new DataSet();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(QueryString, connection);
            adapter.SelectCommand.CommandType = cmdType;
            if (prmArr != null)
            {
                for (int i = 0; i < prmArr.GetLength(0); i++)
                {
                    adapter.SelectCommand.Parameters.Add(prmArr[i]);
                }
            }
            adapter.Fill(ds);
            return ds;
        }


        /// <summary>
        /// ��ȡ�����������ؽ��
        /// </summary>
        /// <param name="MachineID"></param>
        /// <returns></returns>
        public static DataTable GetCKMachineResult(string MachineID, string SampleNum, DateTime TestDate)
        {
            string sql = @"SELECT CKMachineResultDtl.result,CKMachineResult.MachineID,CKMachineResult.SampleNum,CKMachineResultDtl.ItemChannelNumber AS MajorName 
FROM CKMachineResult LEFT JOIN CKMachineResultDtl
ON CKMachineResult.id = CKMachineResultDtl.ResultID where CKMachineResult.MachineID = @MachineID and CKMachineResult.SampleNum=@SampleNum and CKMachineResult.TestDate>=@TestDate";
            List<SqlParameter> parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@MachineID", MachineID));
            parameter.Add(new SqlParameter("@SampleNum", SampleNum));
            parameter.Add(new SqlParameter("@TestDate", TestDate));
            return GetDataSet(sql, parameter.ToArray()).Tables[0];
        }
        /// <summary>
        /// ѹ������
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] input)
        {
            byte[] output;
            using (MemoryStream ms = new MemoryStream())
            {
                using (System.IO.Compression.GZipStream gs = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Compress))
                {
                    gs.Write(input, 0, input.Length);
                    gs.Close();
                    output = ms.ToArray();
                }
                ms.Close();
            }
            return output;
        }

        /// <summary>
        /// 获取该诊所可登录人员
        /// </summary>
        /// <param name="userList">有效用户</param>
        /// <param name="isDoctor">是否医生</param>
        /// <returns></returns>
        public static List<BsUser> FilterUserFromCurLoc(List<BsUser> userList, int hospitalid = 0, bool isDoctor = true)
        {
            if (userList.Count > 0)
            {
                List<BsUserLocation> userLocationList = DBClientBaseInRedis.GetAllList<BsUserLocation>().Where(t => t.HospitalId == (hospitalid == 0 ? Config.UserProfiles.HospitalID : hospitalid)).ToList();
                if (userLocationList.Count > 0)
                {
                    string[] IDs = userLocationList.CopyTo("OperId");
                    return userList.Where(t => t.IsActive && t.IsRecipe == isDoctor && IDs.Contains(t.GUID.ToString())).ToList();
                }
                return new List<BsUser>();
            }
            else
            {
                return userList;
            }
        }

        /// <summary>
        /// ���������л�ΪJSON��ʽ
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>json�ַ���</returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;

        }

        /// <summary>
        /// ����JSON�������ɶ���ʵ�弯��
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <param name="json">json�����ַ���(eg.[{"ID":"112","Name":"ʯ�Ӷ�"}])</param>
        /// <returns>����ʵ�弯��</returns>
        public static List<T> DeserializeJsonToList<T>(string json) where T : class
        {
            JsonSerializer serializer = new JsonSerializer();
            StringReader sr = new StringReader(json);
            object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
            List<T> list = o as List<T>;
            return list;
        }

        /// <summary>
        /// ����json��ʽ���ı�
        /// </summary>
        /// <param name="jsonStr">�����ı�</param>
        /// <param name="path">·��</param>
        public static void SaveJsonText(string jsonStr, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(jsonStr);
                    sw.Close();
                }
                fs.Close();
            }
        }

        /// <summary>
        /// ͨ����ɢ�Ȼ�ȡҩƷ����
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static double GetYpTotality(string itemId, int days, double dosage, string frequencyId, string unitDiagID, string unitTakeId, double totality, int locationID = 0)
        {
            try
            {
                var result = 1.00;
                if (days == 0)
                {
                    return totality;
                }

                var tempUnitRatio = new List<BsUnitRatio>();
                var unitRatio = Orm.Config.Service.DBClientService.GetList<BsUnitRatio>("ItemId = @0 ", itemId);//unitDiagID, unitTakeId);
                if (locationID != 0)
                {
                    tempUnitRatio = unitRatio.FindAll(t => t.HospitalId == locationID);
                }

                if (tempUnitRatio.Count != 0)
                {
                    unitRatio = tempUnitRatio;
                }

                var frequency = UtilsLocCache.GetCacheByID<BsFrequency>(frequencyId);
                if (unitRatio.Count > 0 && frequency != null)
                {
                    if (unitRatio.First() != null && !string.IsNullOrWhiteSpace(unitRatio.First().GUID) && unitRatio.First().DrugRatio != 0 && frequency != null)
                    {
                        var drugRatio = unitRatio.First().DrugRatio;
                        var fredays = frequency.Days;
                        var actualdays = Math.Round(Convert.ToDouble(days / fredays), MidpointRounding.AwayFromZero);
                        var actualdosage = actualdays * frequency.Times * dosage;
                        var actualResult = Math.Round(actualdosage / drugRatio, 4);
                        result = actualResult == 0 ? 1 : actualResult;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return totality;
            }
        }

        /// <summary>
        /// ͨ计算总量
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static double GetYpTotality(OuRecipeDtl ouRecipeDtl)
        {
            try
            {
                var result = 1.00;
                if (ouRecipeDtl.Days == 0)
                {
                    return ouRecipeDtl.Totality;
                }

                var tempUnitRatio = new List<BsUnitRatio>();
                double _DrugRatio = 1;
                if (AppSettings.IsMainLocation)
                {
                    tempUnitRatio = Orm.Config.Service.DBClientService.GetList<BsUnitRatio>("ItemId = @0 and HospitalId =@1 ", ouRecipeDtl.ItemID, (int)EnumMainLocation.总店);//unitDiagID, unitTakeId);
                    if (tempUnitRatio.Count > 0)
                    {
                        _DrugRatio = tempUnitRatio.First().DrugRatio;
                    }
                }
                else
                {
                    tempUnitRatio = Orm.Config.Service.DBClientService.GetList<BsUnitRatio>("ItemId = @0 and HospitalId =@1 ", ouRecipeDtl.ItemID, Config.UserProfiles.HospitalID);//unitDiagID, unitTakeId);
                }
                var frequency = UtilsLocCache.GetCacheByID<BsFrequency>(ouRecipeDtl.FrequencyId);
                if (tempUnitRatio.Count > 0 && frequency != null)
                {
                    var tempUnitRatioGuid = tempUnitRatio.First().GUID;
                    if (tempUnitRatio.First() != null && !string.IsNullOrWhiteSpace(tempUnitRatioGuid) && _DrugRatio != 0 && frequency != null)
                    {
                        var drugRatio = _DrugRatio;
                        var fredays = frequency.Days;
                        var actualdays = Math.Round(Convert.ToDouble(ouRecipeDtl.Days / fredays), MidpointRounding.AwayFromZero);
                        var actualdosage = actualdays * frequency.Times * ouRecipeDtl.Dosage;
                        var actualResult = Math.Round(actualdosage / drugRatio, 4);
                        result = actualResult == 0 ? 1 : actualResult;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return ouRecipeDtl.Totality;
            }
        }




        /// <summary>
        /// ͨ计算西药整散比金额
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static double GetYpTotalityPriceDiag(BsItem bsItem)
        {
            try
            {
                double result = bsItem.PriceDiag;
                var tempUnitRatio = new List<BsUnitRatio>();
                if (!AppSettings.IsMainLocation)
                {
                    tempUnitRatio = Orm.Config.Service.DBClientService.GetList<BsUnitRatio>("ItemId = @0 and HospitalId =@1 ", bsItem.GUID, Config.UserProfiles.HospitalID);
                    var tempUnitRatioGuid = tempUnitRatio.First().GUID;
                    if (tempUnitRatio.First() != null && !string.IsNullOrWhiteSpace(tempUnitRatioGuid))
                    {
                        var drugRatio = tempUnitRatio.First().DrugRatio;
                        drugRatio = drugRatio == 0 ? 1 : drugRatio;
                        var actualResult = Math.Round(bsItem.PriceDiag / drugRatio, 4);
                        result = actualResult;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                return bsItem.PriceDiag;
            }

        }

        /// <summary>
        /// ����ĳ����������Ե�ֵ�Ƿ����
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="last"></param>
        /// <param name="old"></param>
        /// <returns></returns>
        public static bool InfoIsChange<T>(T last, T old)
        {
            //OldInfoClone = usp;

            if (old != null && last != null)
            {
                foreach (System.Reflection.PropertyInfo p in old.GetType().GetProperties())
                {
                    foreach (System.Reflection.PropertyInfo q in last.GetType().GetProperties())
                    {
                        if (p.Name == q.Name/*&&p.Name!= "IsVIPPrice"*/)
                        {
                            var proInP = p.GetValue(last, null);
                            var proInQ = q.GetValue(old, null);
                            if (!object.Equals(proInP, proInQ))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static List<BsRegTimeSpan> GetTimeSpanIDs(DateTime time)
        {
            var lstbsRegTimeSpan = new List<BsRegTimeSpan>();
            var bsRegTimeSpan = UtilsLocCache.GetCacheAll<BsRegTimeSpan>().FindAll(t => t.IsActive);//Orm.Config.Service.DBClientService.GetAllList<BsRegTimeSpan>(); //CacheHelper.GetCacheList<BsRegTimeSpan>(); 
            string timeStr = time.ToShortTimeString();
            if (bsRegTimeSpan.Count > 0)
            {
                lstbsRegTimeSpan = bsRegTimeSpan.FindAll(t => DateTime.Compare(Convert.ToDateTime(timeStr), Convert.ToDateTime(t.TimeBegin)) >= 0 && DateTime.Compare(Convert.ToDateTime(timeStr), Convert.ToDateTime(t.TimeEnd)) <= 0);
            }
            return lstbsRegTimeSpan;
        }

        public bool CheckSettingContainFormat(string keyNum, object item)
        {
            var gblSettingDto = this.GetAllList<GblSetting>().ToList();
            string keyValue = gblSettingDto.Where(z => z.KeyNum == keyNum).Single().SetValue;
            if (keyValue == string.Empty)
            {
                return true;
            }

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
    }

    public static class StringExtensions
    {
        /// <summary>
        ///ǰ��ȥ�ո��ܹ�����nullֵ��������Ϊnullֵʱ��תΪ�մ���
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string TrimEx(this string value)
        {
            if (value == null)
            {
                value = "";
            }

            return value = value.Trim();

        }
    }


}
