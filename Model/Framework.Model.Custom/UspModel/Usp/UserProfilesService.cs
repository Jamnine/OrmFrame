using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Parameter
{
    [Serializable]
    public static class UserProfilesService
    {
        public static string UserID = string.Empty;

        public static string IP=string.Empty;
        public static string UserName = "Demo";
        public static string UserCode = "Demo";
        public static string LocationID = "731";
        public static bool _IsWzHouse;
        public static bool _isAdminstrator;
        public static bool IsDoctor;
        public static string LastDemoFunctionIds;
        public static bool IsWzHouse;
        public static string LocationCode="";
        public static string LocationName="";
        public static string TempPass = string.Empty;

        public static string HostName;
        public static string XType = string.Empty;
        public static int LsInOut = 0;
        public static int HospitalID=5037;
        public static string SpecialityID = "19";
        public static string HouseID="1";
        public static string RoomID="1";
        public static string DoctorID="1";
        public static string RegTypeID="1";
        /// <summary>
        /// 医生等级
        /// </summary>
        public static string DoctorLevel = string.Empty;
        public static string UserRoleIDs;
        public const string SoftVersion = "Standard";
        public static int DebugMode = 1;    //1-单窗口调试；２-主窗口调用调试
        public static string CurrentFileName = AppDomain.CurrentDomain.BaseDirectory;
        public static string FtpFileServicesPath = @"D:\";   //FTP文件服务器的路径
    }
}
