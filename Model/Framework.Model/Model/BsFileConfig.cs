using System;

namespace Orm.Model
{
    /// <summary>
    /// 配置文件
    /// </summary>
    [Serializable]
    public class BsFileConfig : BaseModel
    {
        private int _linkType = 0;  //连接类型（0 共享，1 Ftp，2 Http）

        private string _filePath = string.Empty;  //文件路径

        private string _serverPath = string.Empty;  //服务器路径

        private string _userName = string.Empty;  //用户名

        private string _userPassword = string.Empty;  //用户密码

        private bool _isActive;

        private int _HospitalID;  //

        /// <summary>
        /// 配置文件
        /// </summary>
        public BsFileConfig()
        {
        }

        /// <summary>
        /// 0 共享 1 Ftp 2 Http
        /// </summary>
        public int LinkType
        {
            get { return this._linkType; }
            set { this._linkType = value; }
        }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        /// <summary>
        /// 服务器保存路径
        /// </summary>
        public string ServerPath
        {
            get { return this._serverPath; }
            set { this._serverPath = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassword
        {
            get { return this._userPassword; }
            set { this._userPassword = value; }
        }

        /// <summary>
        /// 有效标志.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

  
    }
}
