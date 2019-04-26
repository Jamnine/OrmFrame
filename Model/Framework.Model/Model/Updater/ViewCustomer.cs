
using System;

namespace Orm.Model
{
    /// <summary>  
    /// 客户端视图
    /// </summary>
    [Serializable]
  
    public partial class ViewCustomer
    {
        private string _name = String.Empty;
        private string _code = String.Empty;
        private string _address = String.Empty;
        private string _mobile = String.Empty;
        private int _versionId;
        private bool _isUpdate;

        public ViewCustomer()
        {

        }
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        public string VersionName { get; set; }

        /// <summary>
        /// 客户端的Guid
        /// </summary>
        public string CustomerGuid{get;set;}

        /// <summary>
        /// IIS的用户资源路径
        /// </summary>
        public string IisUrl{get;set;}
        
        /// <summary>
        /// 当前最新版本号
        /// </summary>
        public int CurrentVersionNum { get; set; }
        
        /// <summary>  
        /// 名称
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        /// 编码
        /// </summary>  
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        /// <summary>  
        ///地址
        /// </summary>  
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        /// <summary>  
        /// 手机号
        /// </summary>  
        public string Mobile
        {
            get { return this._mobile; }
            set { this._mobile = value; }
        }

        /// <summary>  
        /// 对应的版本ID  
        /// </summary>  
        public int VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        /// <summary>  
        /// 是否启用更新  
        /// </summary>  
        public bool IsUpdate
        {
            get { return this._isUpdate; }
            set { this._isUpdate = value; }
        }

        /// <summary>
        /// 数据库版本号
        /// </summary>
        public int DbVersionNum { get; set; }
    }
}
