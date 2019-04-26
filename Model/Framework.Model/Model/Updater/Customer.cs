// ===================================================================   
// Model  
// ===================================================================   
// File: Custom.cs  
//   
// Copyright   
// History:  
// 2015/1/28 10:51:10: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///客户端信息
    /// </summary>
    [Serializable]
    public partial class Customer : BaseModel
    {
     
        private string _name = String.Empty;
        private string _code = String.Empty;
        private string _address = String.Empty;
        private string _mobile = String.Empty;
        private int _versionId;
        private bool _isUpdate;

        /// <summary>
        /// 默认构造方法
        /// </summary>
        public Customer()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public   int ID { get; set; }
        /// <summary>
        /// 客户端GUID
        /// </summary>
        public string CustomerGuid { get; set; }

        /// <summary>
        /// 客户端数据库版本
        /// </summary>
        public int DbVersionNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IisVersionNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IisUrl { get; set; }

        /// <summary>  
        ///   客户端名称
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        ///   客户端编码
        /// </summary>  
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        /// <summary>  
        ///   地址
        /// </summary>  
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        /// <summary>  
        ///   手机号
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
        /// 是否可用
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 是否开始使用
        /// </summary>
        public bool IsStartUsing { get; set; }

        /// <summary>
        /// 开始使用时间
        /// </summary>
        public DateTime StartUsingDate { get; set; }

        /// <summary>
        /// IIS文件路径
        /// </summary>
        public string IisFilePath { get; set; }

        /// <summary>
        /// IIS服务IP地址
        /// </summary>
        public string IisServerLwIp { get; set; }

        /// <summary>
        /// 数据库更新时间
        /// </summary>
        public DateTime DbUpdateTime { get; set; }

        /// <summary>
        /// IIS更新时间
        /// </summary>
        public DateTime IisUpdateTime { get; set; }
    }
}
