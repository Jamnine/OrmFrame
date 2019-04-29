using Orm.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Orm.Config
{    /// <summary>
     /// 用户配置文件
     /// </summary>
    public static class UserProfiles
    {/// <summary>
     /// 用户ID
     /// </summary>
        public static string UserID = string.Empty;
        /// <summary>
        /// 部门编号
        /// </summary>
        public static string LocationId;
        /// <summary>
        /// IP地址
        /// </summary>
        public static string IP = string.Empty;
        /// <summary>
        /// 用户名
        /// </summary>
        public static string UserName = "Demo";
        /// <summary>
        /// 用户编号
        /// </summary>
        public static string UserCode = "Demo";
        /// <summary>
        /// 诊所对比编码
        /// </summary>
        public static string ContrastCode = "";
        /// <summary>
        /// 密码
        /// </summary>
        public static string PassWord = string.Empty;

        /// <summary>
        /// 自动化测试跳过权限限制
        /// </summary>
        public static bool blnPassTest = false;
        /// <summary>
        /// 版本标识
        /// </summary>
        public static int Edition = 0;
        /// <summary>
        /// 门诊机构id
        /// </summary>
        public static int HospitalID = 0;
        /// <summary>
        /// 是否物资仓库
        /// </summary>
        public static bool IsWzHouse = true;
        /// <summary>
        /// 门诊科室编号
        /// </summary>
        public static string LocationCode = string.Empty;
        /// <summary>
        /// 门诊科室名称
        /// </summary>
        public static string LocationName = string.Empty;
        /// <summary>
        /// 门诊机构地址
        /// </summary>
        public static string LocationAddress = string.Empty;
        /// <summary>
        ///门诊机构英文名
        /// </summary>
        public static string EngDesc = string.Empty;
        /// <summary>
        /// 门诊机构联系电话
        /// </summary>
        public static string LocationTelephone = string.Empty;
        /// <summary>
        /// 门诊机构营业证
        /// </summary>
        public static string TempPass = string.Empty;
        /// <summary>
        /// 客户id
        /// </summary>
        public static int CustomterID = 1;
        /// <summary>
        /// 微信资金1
        /// </summary>
        public static int BsWeChatMoney1 = 0;
        /// <summary>
        /// 微信资金2
        /// </summary>
        public static int BsWeChatMoney2 = 0;
        /// <summary>
        ///操作时间
        /// </summary>
        public static DateTime OperTime = DateTime.MinValue;
        //手机号码
        public static string Phone = string.Empty;

        /// <summary>
        /// 是否发送红包
        /// </summary>
        public static bool IsGiveRedEnvelopes = true;

        /// <summary>
        /// 门诊类别
        /// </summary>
        public static string RegTypeID = string.Empty;
        /// <summary>
        /// 第三方用户编码
        /// </summary>
        public static string ThirdUserCode = string.Empty;
        /// <summary>
        /// 当前城市
        /// </summary>
        public static string CurrCity = string.Empty;
        /// <summary>
        /// 就诊地点
        /// </summary>
        public static string LocationPlace = string.Empty;

        public static string XType = string.Empty;
        public static int LsInOut = 0;
        /// <summary>
        /// 医院名称
        /// </summary>
        public static string HospitalName = string.Empty;
        /// <summary>
        /// 医院地址
        /// </summary>
        public static string HospitalAddress = string.Empty;
        /// <summary>
        /// 医院电话
        /// </summary>
        public static string HospitalTelephone = string.Empty;
        /// <summary>
        /// 医院标志
        /// </summary>
        public static byte[] HospitalLogo;
        /// <summary>
        /// 专业id
        /// </summary>
        public static string SpecialityID = "19";
        /// <summary>
        ///仓库id
        /// </summary>
        public static string HouseID = "1";
        /// <summary>
        ///科室id
        /// </summary>
        public static string RoomID = "1504";
        /// <summary>
        /// 医生id
        /// </summary>
        public static string DoctorID = "0";
        /// <summary>
        /// 体检科室id
        /// </summary>
        public static string TjLocationID = "0";
        /// <summary>
        /// 是否体检小结
        /// </summary>
        public static bool IsTjSummary = false;
        /// <summary>
        /// 是否是健康管理师
        /// </summary>
        public static bool IsHealthDoctor = false;//健康管理师
        /// <summary>
        /// 是否是理疗师
        /// </summary>
        public static bool IsHealthExcutor = false;//理疗师
        /// <summary>
        /// 是否是营养师
        /// </summary>
        public static bool IsDietitianDoc = false;//营养师
        /// <summary>
        /// 是否是运动师
        /// </summary>
        public static bool IsSportDoctor = false;//运动师
        /// <summary>
        /// 是否是中医师
        /// </summary>
        public static bool IsTCMDoctor = false;//中医师
        /// <summary>
        /// 是否是心理医生
        /// </summary>
        public static bool IsPsyDocDoctor = false;//心理医生
        /// <summary>
        /// 医生等级
        /// </summary>
        public static string DoctorLevel;
        /// <summary>
        /// 用户角色id
        /// </summary>
        public static string UserRoleIDs;
        /// <summary>
        /// 版本
        /// </summary>
        public const string SoftVersion = "Standard";
        /// <summary>
        /// 1-单窗口调试；２-主窗口调用调试
        /// </summary>
        public static int DebugMode = 1;    //1-单窗口调试；２-主窗口调用调试
        /// <summary>
        /// 获取当前基目录，它由程序集冲突解决程序用来探测程序集。
        /// </summary>
        public static string CurrentFileName = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// FTP文件服务器的路径
        /// </summary>
        public static string FtpFileServicesPath = @"D:\";   //FTP文件服务器的路径
        /// <summary>
        /// 是否处于自动化测试模式。
        /// </summary>
        public static bool IsProcessTestMode = false; //是否处于自动化测试模式。
        /// <summary>
        /// 客户身份GUID
        /// </summary>
        public static string CustomterGuid = string.Empty;           //客户身份GUID
        /// <summary>
        /// 客户电脑GUID
        /// </summary>
        public static string ClientComputerGuid = string.Empty;      //客户电脑GUID
        /// <summary>
        /// 客户电脑名称
        /// </summary>
        public static string HostName = string.Empty;                //客户电脑名称
        /// <summary>
        /// 客户版本名称
        /// </summary>
        public static string CustomterVersionName = string.Empty;                //客户版本名称
        /// <summary>
        /// 客户版本号
        /// </summary>
        public static string CustomterVersionNum = "0";                //客户版本号
        /// <summary>
        /// 客户IIS站点名称
        /// </summary>
        public static string CustomterIisSiteName = "NoSite";
        /// <summary>
        /// 服务端最新版本号
        /// </summary>
        public static int ServiceNewVersionNum = 20;            //服务端最新版本号
        /// <summary>
        /// 客户数据库的版本号
        /// </summary>
        public static int CustomerDbVersionNum = 20;            //客户数据库的版本号
        /// <summary>
        /// 登录日志ID 
        /// </summary>
        public static string LoginLogId;                               //登录日志ID 


        /// <summary>
        /// 前台质询字段共用
        /// </summary>
        public static string FrontDeskConsultation = "平台咨询";

        /// <summary>
        /// 门诊就诊
        /// </summary>
        public static string Outpatients = "医疗服务";
        /// <summary>
        /// 当前输入语言
        /// </summary>
        public static InputLanguage CurrentInputLanguage;

        /// <summary>
        /// 当前用户的权限
        /// </summary>
        public static List<Orm.Model.Custom.TreeClass<Orm.Model.Custom.DisplayModule>> CurrentAuthority;

        /// <summary>
        /// 项目集合
        /// </summary>
        public static List<BsItem> chargeItemAll = new List<BsItem>();
        private static bool _isDoctorID = false;
        public static bool u_IsDoctorID
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(DoctorID))
                {
                    _isDoctorID = true;
                }
                else
                {
                    _isDoctorID = false;
                }
                return _isDoctorID;
            }
            set { _isDoctorID = value; }
        }

        #region 药品对接
        /// <summary>
        /// 药房信息
        /// </summary>
        public static List<PharmacyInfo> PharmacyInfoList;

        /// <summary>
        /// 是否开启药品对接
        /// </summary>
        public static bool IsInterUMP = false;
        #endregion

        #region 项目控件输入法设置

        /// <summary>
        /// 用户输入法设置——五笔码查找
        /// </summary>
        public static bool IsUserInputWB = true;
        /// <summary>
        /// 用户输入法设置——拼音码查找
        /// </summary>
        public static bool IsUserInputPY = true;
        /// <summary>
        /// 用户输入法设置——项目编码查找
        /// </summary>
        public static bool IsUserInputCode = true;
        /// <summary>
        /// 用户输入法设置——中文名称查找
        /// </summary>
        public static bool IsUserInputName = true;

        #endregion

        #region 昆山治疗方案
        public static string KCMountYes = "0";
        public static string KCMountNo = "0";
        public static string SpecName = string.Empty;
        #endregion

        #region 远程会诊
        /// <summary>
        /// 是否正在视频
        /// </summary>
        public static bool IsVedioNow = false;
        /// <summary>
        /// 退出视频聊天的方法
        /// </summary>
        public static Action ExitVedioRoom;
        /// <summary>
        /// 房间号/病人ID
        /// </summary>
        public static string RoomName = "999";

        /// <summary>
        /// 房间号密码
        /// </summary>
        public static string RoomPass = "999";

        /// <summary>
        /// 是否专家
        /// </summary>
        public static bool IsItAnExpert = false;
        //在线专家列表
        public static List<string> UserIDList = new List<string>();
        //等待专家会诊列表
        public static List<string> WaitUserIDList = new List<string>();
        //等待时间
        public static string WaitTime = string.Empty;
        private static SocketClient _socketMessageClient = null;
        public static SocketClient socketMessageClient
        {
            get
            {
                if (_socketMessageClient == null)
                {
                    _socketMessageClient = new SocketClient();
                }
                return _socketMessageClient;
            }
        }
        #endregion


    }
}
