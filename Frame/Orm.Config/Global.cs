using Orm.Model;
using Orm.Model.Custom;
using Orm.Model.EnumDefine;
using System;
using System.Collections.Generic;

namespace Orm.Config
{
    /// <summary>
    /// 全局操作
    /// 数据库表集合缓冲如：表Gbletting。等
    /// </summary>
    public class Global
    {
        protected string _showMessage;
        /// <summary>
        /// ShowMessage
        /// </summary>
        public string ShowMessage
        {
            set { _showMessage = value; }
            get { return _showMessage; }
        }
        protected string _serverVersion;
        /// <summary>
        /// ServerVersion
        /// </summary>
        public string ServerVersion
        {
            set { _serverVersion = value; }
            get { return _serverVersion; }
        }
        /// <summary>
        /// PatientPhotoFolder
        /// </summary>
        public string PatientPhotoFolder
        {
            set { _patientPhotoFolder = value; }
            get { return _patientPhotoFolder; }
        }
        protected string _patientPhotoFolder;
        protected string _hospitalName;
        /// <summary>
        /// HospitalName
        /// </summary>
        public string HospitalName
        {
            set { _hospitalName = value; }
            get { return _hospitalName; }
        }
        protected string _dbType;
        public string DbType
        {
            set
            {
                _dbType = value;
            }
            get { return _dbType; }
        }
        public static int CommandTimeout = 90;
        public static string ConnectionEorrMessage = "";
        public static bool IsLoad = false;
        public static bool ElectTag = false;
        [Obsolete("已过期")]
        public static string ConnectionType = "HIS";
        [Obsolete("已过期")]
        public static string ConnectionTypeLogin = "HIS";
        public static int PatientID = 0;
        public static List<GblSetting> LstGblSetting = new List<GblSetting>();
        public static List<uspHisOuPatientQry> LstTodayPreOuhosInfo = new List<uspHisOuPatientQry>();//当前所有预约病人
        public static bool AdviceInputing = false;
        public static bool IsOpenFrmDmt = false;
        public static string CardNo = string.Empty;
        public static string LastRecipeNum = string.Empty;
        public static string LastPrinter = string.Empty;
        public static string LabNum = string.Empty;
        public static int LabId = 0;
        public static int PatID = 0;
        public static bool IsFingterReading = false;
        public static bool IsBsItemControlFire = false;
        public static string HuItemName = "药";
        public static bool IsLoadBsItem = false;
        public static bool IsLoadBaseTable = false;
        public static int MsaageNewStr = 0;
        /// <summary>
        /// 删除作废病人基本信息
        /// </summary>
        public static bool CanDeleteBsPatient = true;//删除作废病人基本信息
        /// <summary>
        /// 删除作废病人就诊信息
        /// </summary>
        public static bool CanDeleteOuHosInfo = true;//删除作废病人就诊信息
        /// <summary>
        /// 允许打印总检报告
        /// </summary>
        public static bool CanPrintTjReport = false;//允许打印总检报告
        /// <summary>
        /// 允许设置会员等级
        /// </summary>
        public static bool CanSetVipLevel = false;//允许设置会员等级
        /// <summary>
        /// 允许作废会员卡
        /// </summary>
        public static bool CanDeleteVipCard = false;//允许作废会员卡
        /// <summary>
        /// 允许更改会员卡
        /// </summary>
        public static bool CanChangeVipCard = false;//允许更改会员卡
        /// <summary>
        /// 允许会员退款
        /// </summary>
        public static bool CanVipChargeBack = false;//允许会员退款
        /// <summary>
        /// 允许查看特殊病人
        /// </summary>
        public static bool CanSeeIllness = false;//允许查看特殊病人
        public static bool DataAnalysisIsUseProc = true;//数据分析是否使用存储过程
        public static List<BsCmmonData> SexList = new List<BsCmmonData>();
        public static List<BsCmmonData> UserangeForTjList = new List<BsCmmonData>();
        public static List<BsCmmonData> DataTypeList = new List<BsCmmonData>();
        public static List<BsCmmonData> LocationTypeList = new List<BsCmmonData>();
        public static List<BsCmmonData> FlagTypeList = new List<BsCmmonData>();
        public static List<BsCmmonData> LstTaskType = new List<BsCmmonData>();
        public static List<KeyValuePair<string, Orm.Toolkit.DownloadItem>> CacheDownloadItems = new List<KeyValuePair<string, Orm.Toolkit.DownloadItem>>();
        //public static List<CacheDownloadItems> CacheDownloadItemsList = new List<CacheDownloadItems>();
        public static List<BsCmmonData> LstVisitType = new List<BsCmmonData>();
        public static List<BsCmmonData> LstAttachType = new List<BsCmmonData>();
        public static List<BsCmmonData> LstOverType = new List<BsCmmonData>();
        public static List<CkItem> AllBsTjItemList = new List<CkItem>();
        public static List<BsItem> AllBsItemList = new List<BsItem>();
        public static List<BsCmmonData> SensitiveList = new List<BsCmmonData>();
        public static List<BsCmmonData> LimitTypeList = new List<BsCmmonData>();
        public static List<BsCmmonData> SamlingTypeList = new List<BsCmmonData>();
        public static List<BsCmmonData> TagTypeList = new List<BsCmmonData>();
        public static List<string> ReferTypeList = new List<string>();
        /// <summary>
        /// 检查类型集合
        /// </summary>
        public static List<Model.Custom.BsCmmonData> LstCheckType = new List<Model.Custom.BsCmmonData>();
        /// <summary>
        /// 附加项目项目列表
        /// </summary>
        public static List<BsLabSourceItem> AllLabSourceItemList = new List<BsLabSourceItem>();
        /// <summary>
        /// 结算天数是否包含最后一天
        /// </summary>
        public static EnumChargeDaysTypeCalculateMode ChargeDaysTypeCalculateMode = EnumChargeDaysTypeCalculateMode.UnIncludeLastDay;
        /// <summary>
        /// 用户输入法设置——五笔码查找
        /// </summary>
        public static string IsUserInputWB = "1";
        /// <summary>
        /// 用户输入法设置——拼音码查找
        /// </summary>
        public static string IsUserInputPY = "1";
        /// <summary>
        /// 用户输入法设置——项目编码查找
        /// </summary>
        public static string IsUserInputCode = "1";
        /// <summary>
        /// 用户输入法设置——中文名称查找
        /// </summary>
        public static string IsUserInputName = "1";
        /// <summary>
        /// 用户输入法设置——笔画码查找
        /// </summary>
        public static string IsUserInputStrokeCode = "0";
        /// <summary>
        /// 用户输入法设置——别名查找
        /// </summary>
        public static string IsUserInputEngDesc = "0";
        /// <summary>
        /// 用户输入法设置——下拉跟随输入
        /// </summary>
        public static string IsUserInputList = "0";
        /// <summary>
        /// 用户输入法设置——写字板
        /// </summary>
        ///  
        public static string IsUserWordPad = "0";
        /// <summary>
        /// 用户输入法设置——精确查找
        /// </summary>
        public static string IsUserSelectOnly = "0";
        public static List<string> ClientAddressIPList = new List<string>();

        public static string FtpAddress = "ftp://192.168.1.135/";
        public static string FtpUser = "Ben";
        public static string FtpPWD = "1";
        public static string AppUpdateAddress = "";
    }
    public class XdRpGroupSelect
    {

        protected bool _isBsItemAttach;
        public bool IsBsItemAttach
        {
            set { _isBsItemAttach = value; }
            get { return _isBsItemAttach; }
        }

        protected int _groupId;
        public int GroupId
        {
            set { _groupId = value; }
            get { return _groupId; }
        }
    }
    public class CwPatientInfo
    {

        protected bool _idCareNo;
        public bool IDCardNo
        {
            set { _idCareNo = value; }
            get { return _idCareNo; }
        }

        protected string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        protected string _sex;
        public string Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }

        protected string _nation;
        public string Nation
        {
            set { _nation = value; }
            get { return _nation; }
        }

        protected string _birthPlace;
        public string BirthPlace
        {
            set { _birthPlace = value; }
            get { return _birthPlace; }
        }

        protected string _residentType;
        public string RresidentType
        {
            set { _residentType = value; }
            get { return _residentType; }
        }

        protected string _address;
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        protected string _addressExtend;
        public string AddressExtend
        {
            set { _addressExtend = value; }
            get { return _addressExtend; }
        }

        protected string _addressArea;
        public string AddressArea
        {
            set { _addressArea = value; }
            get { return _addressArea; }
        }

        protected string _addressStreet;
        public string AddressStreet
        {
            set { _addressStreet = value; }
            get { return _addressStreet; }
        }

        protected string _addressCommittee;
        public string AddressCommittee
        {
            set { _addressCommittee = value; }
            get { return _addressCommittee; }
        }
    }
}
