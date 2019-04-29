using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Orm.Utilities
{
    public class ShareFileHelper
    {
        public class Cmd
        {
            private static Process SetProcess()
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                return process;
            }

            public static string Connect(string remoteHost, string userName, string passWord)
            {
                string errormsg = string.Empty;
                Process process = SetProcess();
                try
                {
                    process.Start();
                    process.StandardInput.WriteLine("net use " + remoteHost + " " + passWord + " /user:" + userName);
                    process.StandardInput.WriteLine("exit");
                    while (!process.HasExited)
                    {
                        process.WaitForExit(1000);
                    }
                    errormsg = process.StandardError.ReadToEnd();
                    process.StandardError.Close();
                    if (errormsg.Contains("1219") || errormsg.Contains("多重连接"))
                    {
                        errormsg = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    process.Close();
                    process.Dispose();
                }
                return errormsg;
            }
            public static string Disconnect(string remoteHost)
            {
                string errormsg = string.Empty;
                Process process = SetProcess();
                try
                {
                    process.Start();
                    process.StandardInput.WriteLine("net use " + remoteHost + " /del");
                    process.StandardInput.WriteLine("exit");
                    while (!process.HasExited)
                    {
                        process.WaitForExit(1000);
                    }
                    errormsg = process.StandardError.ReadToEnd();
                    process.StandardError.Close();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    process.Close();
                    process.Dispose();
                }
                return errormsg;
            }
        }

        public enum ERROR_ID
        {
            NO_ERROR = 0,//连接成功
            ERROR_ACCESS_DENIED = 5,//拒绝访问
            ERROR_NOT_ENOUGH_MEMORY = 8,
            ERROR_BAD_NETPATH = 53,
            ERROR_NETWORK_BUSY = 54,
            ERROR_BAD_DEV_TYPE = 66,//类型不匹配
            ERROR_BAD_NET_NAME = 67,//找不到该连接
            ERROR_ALREADY_ASSIGNED = 85,//已连接
            ERROR_INVALID_PASSWORD = 86,//密码错误
            ERROR_INVALID_PARAMETER = 87,
            ERROR_INVALID_LEVEL = 124,
            ERROR_BUSY = 170,//网络繁忙
            ERROR_MORE_DATA = 234,
            ERROR_BAD_DEVICE = 1200,//localPath值无效
            ERROR_DEVICE_ALREADY_REMEMBERED = 1202,//localPath重复输入
            ERROR_NO_NET_OR_BAD_PATH = 1203,//网络没打开（硬件）
            ERROR_BAD_PROVIDER = 1204,
            ERROR_CANNOT_OPEN_PROFILE = 1205,//连接已断开
            ERROR_BAD_PROFILE = 1206,//用户名或密码格式不对
            ERROR_EXTENDED_ERROR = 1208,//特殊错误，调用WNetGetLastError获取错误信息

            ERROR_NO_NETWORK = 1222,//网络太差，连不上
            ERROR_CANCELLED = 1223,//该设备正在使用，不能进行其他操作
            ERROR_INVALID_HANDLE_STATE = 1609,
            ERROR_NO_BROWSER_SERVERS_FOUND = 6118,
        }

        public enum RESOURCE_SCOPE
        {
            RESOURCE_CONNECTED = 1,
            RESOURCE_GLOBALNET = 2,
            RESOURCE_REMEMBERED = 3,
            RESOURCE_RECENT = 4,
            RESOURCE_CONTEXT = 5
        }

        public enum RESOURCE_TYPE
        {
            RESOURCETYPE_ANY = 0,
            RESOURCETYPE_DISK = 1,
            RESOURCETYPE_PRINT = 2,
            RESOURCETYPE_RESERVED = 8,
        }

        public enum RESOURCE_USAGE
        {
            RESOURCEUSAGE_CONNECTABLE = 1,
            RESOURCEUSAGE_CONTAINER = 2,
            RESOURCEUSAGE_NOLOCALDEVICE = 4,
            RESOURCEUSAGE_SIBLING = 8,
            RESOURCEUSAGE_ATTACHED = 16,
            RESOURCEUSAGE_ALL = (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED),
        }

        public enum RESOURCE_DISPLAYTYPE
        {
            RESOURCEDISPLAYTYPE_GENERIC = 0,
            RESOURCEDISPLAYTYPE_DOMAIN = 1,
            RESOURCEDISPLAYTYPE_SERVER = 2,
            RESOURCEDISPLAYTYPE_SHARE = 3,
            RESOURCEDISPLAYTYPE_FILE = 4,
            RESOURCEDISPLAYTYPE_GROUP = 5,
            RESOURCEDISPLAYTYPE_NETWORK = 6,
            RESOURCEDISPLAYTYPE_ROOT = 7,
            RESOURCEDISPLAYTYPE_SHAREADMIN = 8,
            RESOURCEDISPLAYTYPE_DIRECTORY = 9,
            RESOURCEDISPLAYTYPE_TREE = 10,
            RESOURCEDISPLAYTYPE_NDSCONTAINER = 11
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct NETRESOURCE
        {
            public RESOURCE_SCOPE dwScope;
            public RESOURCE_TYPE dwType;
            public RESOURCE_DISPLAYTYPE dwDisplayType;
            public RESOURCE_USAGE dwUsage;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpLocalName;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpRemoteName;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpComment;

            [MarshalAs(UnmanagedType.LPStr)]
            public string lpProvider;
        }

        public class NetworkConnection
        {

            [DllImport("mpr.dll")]
            public static extern int WNetAddConnection2A(NETRESOURCE[] lpNetResource, string lpPassword, string lpUserName, int dwFlags);

            [DllImport("mpr.dll")]
            public static extern int WNetCancelConnection2A(string sharename, int dwFlags, int fForce);


            public static int Connect(string remotePath, string localPath, string username, string password)
            {
                NETRESOURCE[] share_driver = new NETRESOURCE[1];
                share_driver[0].dwScope = RESOURCE_SCOPE.RESOURCE_GLOBALNET;
                share_driver[0].dwType = RESOURCE_TYPE.RESOURCETYPE_DISK;
                share_driver[0].dwDisplayType = RESOURCE_DISPLAYTYPE.RESOURCEDISPLAYTYPE_SHARE;
                share_driver[0].dwUsage = RESOURCE_USAGE.RESOURCEUSAGE_CONNECTABLE;
                share_driver[0].lpLocalName = localPath;
                share_driver[0].lpRemoteName = remotePath;

                Disconnect(localPath);
                int ret = WNetAddConnection2A(share_driver, password, username, 1);

                return ret;
            }

            public static int Disconnect(string localpath)
            {
                return WNetCancelConnection2A(localpath, 1, 1);
            }
        }

        public static string GetErrorMessage(int code, string serverPath)
        {
            string errorMessage = string.Empty;
            if (code == (int)ShareFileHelper.ERROR_ID.ERROR_ACCESS_DENIED)
            {
                errorMessage = string.Format("访问被拒绝（{0}），请检查该共享机器的共享设置！", serverPath);
            }
            else if (code == (int)ShareFileHelper.ERROR_ID.ERROR_BAD_NET_NAME)
            {
                errorMessage = string.Format("找不到该连接（{0}），请确认该共享机是否在运行中并且有该路径共享文件！", serverPath);
            }
            else if (code == (int)ShareFileHelper.ERROR_ID.ERROR_INVALID_PASSWORD)
            {
                errorMessage = string.Format("密码错误（连接为：{0}）！", serverPath);
            }
            else if (code == (int)ShareFileHelper.ERROR_ID.ERROR_NO_NET_OR_BAD_PATH)
            {
                errorMessage = string.Format("请检查网络设备（连接为：{0}）！", serverPath);
            }
            else if (code == (int)ShareFileHelper.ERROR_ID.ERROR_CANNOT_OPEN_PROFILE)
            {
                errorMessage = string.Format("请检查共享机器（连接为：{0}）或路由器的运行状态，如果仍无法连上，建议重启它们！", serverPath);
            }
            else if (code == (int)ShareFileHelper.ERROR_ID.ERROR_BAD_PROFILE)
            {
                errorMessage = string.Format("用户名或密码格式不正确（连接为：{0}）！", serverPath);
            }
            else
            {
                errorMessage = string.Format("特殊错误（连接为：{0}），请检查设备的运行状态！", serverPath);
            }
            return errorMessage;
        }

        public class Authentication
        {
            // logon types
            const int LOGON32_LOGON_INTERACTIVE = 2;
            const int LOGON32_LOGON_NETWORK = 3;
            const int LOGON32_LOGON_NEW_CREDENTIALS = 9;
            // logon providers
            const int LOGON32_PROVIDER_DEFAULT = 0;
            const int LOGON32_PROVIDER_WINNT50 = 3;
            const int LOGON32_PROVIDER_WINNT40 = 2;
            const int LOGON32_PROVIDER_WINNT35 = 1;

            [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int LogonUser(String lpszUserName, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

            [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int DuplicateToken(IntPtr hToken, int impersonationLevel, ref IntPtr hNewToken);

            [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool RevertToSelf();

            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            public static extern bool CloseHandle(IntPtr handle);

            private static WindowsImpersonationContext impersonationContext;

            public static bool impersonateValidUser(String userName, String domain, String password)
            {
                WindowsIdentity tempWindowsIdentity;
                IntPtr token = IntPtr.Zero;
                IntPtr tokenDuplicate = IntPtr.Zero;

                if (RevertToSelf())
                {
                    // 这里使用LOGON32_LOGON_NEW_CREDENTIALS来访问远程资源。
                    // 如果要（通过模拟用户获得权限）实现服务器程序，访问本地授权数据库可
                    // 以用LOGON32_LOGON_INTERACTIVE
                    if (LogonUser(userName, domain, password, LOGON32_LOGON_NEW_CREDENTIALS, LOGON32_PROVIDER_DEFAULT, ref token) != 0)
                    {
                        if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                        {
                            tempWindowsIdentity = new WindowsIdentity(tokenDuplicate);
                            impersonationContext = tempWindowsIdentity.Impersonate();
                            if (impersonationContext != null)
                            {
                                System.AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
                                IPrincipal pr = System.Threading.Thread.CurrentPrincipal;
                                IIdentity id = pr.Identity;
                                CloseHandle(token);
                                CloseHandle(tokenDuplicate);
                                return true;
                            }
                        }
                    }
                }

                if (token != IntPtr.Zero)
                {
                    CloseHandle(token);
                }

                if (tokenDuplicate != IntPtr.Zero)
                {
                    CloseHandle(tokenDuplicate);
                }

                return false;
            }

            public static void undoImpersonation()
            {
                impersonationContext.Undo();
            }
        }

        public class Authentication2
        {
            // obtains user token    
            [DllImport("advapi32.dll", SetLastError = true)]
            static extern bool LogonUser(string pszUsername, string pszDomain, string pszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

            // closes open handes returned by LogonUser    
            [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
            extern static bool CloseHandle(IntPtr handle);

            [DllImport("Advapi32.DLL")]
            static extern bool ImpersonateLoggedOnUser(IntPtr hToken);

            [DllImport("Advapi32.DLL")]
            static extern bool RevertToSelf();
            const int LOGON32_PROVIDER_DEFAULT = 0;
            const int LOGON32_LOGON_NEWCREDENTIALS = 9;//域?控?中D的?需è要癮用?:Interactive = 2    
            private bool disposed;
            public static int IdentityScope(string sUsername, string sDomain, string sPassword)
            {
                int errorcode = 0;
                // initialize tokens    
                IntPtr pExistingTokenHandle = new IntPtr(0);
                IntPtr pDuplicateTokenHandle = new IntPtr(0);

                try
                {
                    // get handle to token    
                    bool bImpersonated = LogonUser(sUsername, sDomain, sPassword, LOGON32_LOGON_NEWCREDENTIALS, LOGON32_PROVIDER_DEFAULT, ref pExistingTokenHandle);

                    if (true == bImpersonated)
                    {
                        if (!ImpersonateLoggedOnUser(pExistingTokenHandle))
                        {
                            errorcode = Marshal.GetLastWin32Error();
                            //throw new Exception("ImpersonateLoggedOnUser error;Code=" + nErrorCode);    
                        }
                    }
                    else
                    {
                        errorcode = Marshal.GetLastWin32Error();
                        //throw new Exception("LogonUser error;Code=" + nErrorCode);    
                    }
                    return errorcode;
                }
                finally
                {
                    // close handle(s)    
                    if (pExistingTokenHandle != IntPtr.Zero)
                    {
                        CloseHandle(pExistingTokenHandle);
                    }
                    if (pDuplicateTokenHandle != IntPtr.Zero)
                    {
                        CloseHandle(pDuplicateTokenHandle);
                    }
                }
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    RevertToSelf();
                    disposed = true;
                }
            }

            public void Dispose()
            {
                Dispose(true);
            }
        }

        public static List<FileInfo> GetFileList(string path, string patName = "", string sex = "")
        {
            List<FileInfo> fileList = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists)//判断所指的文件或文件夹是否存在
            {
                DirectoryInfo dirD = dir as DirectoryInfo;
                FileSystemInfo[] files = dirD.GetFileSystemInfos();//获取文件夹中所有文件和文件夹
                //对单个FileSystemInfo进行判断,如果是文件夹则进行递归操作
                foreach (FileSystemInfo FSys in files)
                {
                    FileInfo file = FSys as FileInfo;
                    if (file != null)//如果是文件的话，进行文件的复制操作
                    {
                        if (string.IsNullOrWhiteSpace(patName) && string.IsNullOrWhiteSpace(sex))
                        {
                            fileList.Add(new FileInfo(file.DirectoryName + "\\" + file.Name));
                        }
                        else if (!string.IsNullOrWhiteSpace(patName))
                        {
                            string[] str = file.Name.Split('-');
                            if (string.IsNullOrWhiteSpace(sex) && str[0] == patName)
                            {
                                fileList.Add(new FileInfo(file.DirectoryName + "\\" + file.Name));
                            }
                            else if (str.Count() > 1 && str[0] == patName && str[1] == sex)
                            {
                                fileList.Add(new FileInfo(file.DirectoryName + "\\" + file.Name));
                            }
                        }
                    }
                    else
                    {
                        GetFileList(FSys.FullName, patName, sex);
                    }
                }
            }
            return fileList;
        }

        /// <summary>
        /// 复制方法
        /// </summary>
        /// <param name="server_path">数据源地址</param>
        /// <param name="local_path">本机地址</param>
        public static void CopyFile(string server_path, string local_path, string fileName)
        {
            try
            {
                server_path = server_path + "\\" + fileName;
                if (File.Exists(server_path))
                {
                    if (!Directory.Exists(local_path))
                    {
                        Directory.CreateDirectory(local_path);
                    }
                    FileInfo serverInfo = new FileInfo(server_path);
                    serverInfo.CopyTo(local_path + "\\" + fileName, true);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }
    }
}
