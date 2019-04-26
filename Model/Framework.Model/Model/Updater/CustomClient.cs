// ===================================================================   
// Model  
// ===================================================================   
// File: CustomClient.cs  
//   
// Copyright   
// History:  
// 2015/1/28 10:54:08: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// 客户端信息
    /// </summary> 
    [Serializable]
    public partial class CustomClient : BaseModel
    {
        private int _customId;
        private int _lastVersionNum;
        private DateTime _downLoadTime;
        private string _downLoadHostName = String.Empty;
        private string _downLoadIp = String.Empty;

        public CustomClient()
        {
        }
        public int ID { get; set; }
        /// <summary>  
        /// 客户ID  
        /// </summary>  
        public int CustomId
        {
            get { return this._customId; }
            set { this._customId = value; }
        }

        /// <summary>  
        /// 服务端最新的版本号  
        /// </summary>  
        public int LastVersionNum
        {
            get { return this._lastVersionNum; }
            set { this._lastVersionNum = value; }
        }

        /// <summary>  
        /// 下载时间  
        /// </summary>  
        public DateTime DownLoadTime
        {
            get { return this._downLoadTime; }
            set { this._downLoadTime = value; }
        }

        /// <summary>  
        /// 下载的电脑  
        /// </summary>  
        public string DownLoadHostName
        {
            get { return this._downLoadHostName; }
            set { this._downLoadHostName = value; }
        }

        /// <summary>  
        /// 下载的电脑ip  
        /// </summary>  
        public string DownLoadIp
        {
            get { return this._downLoadIp; }
            set { this._downLoadIp = value; }
        }

        /// <summary>
        /// 客户端版本号
        /// </summary>
        public int CustomerVersionNum{get;set;}

        /// <summary>
        /// 更新的版本号
        /// </summary>
        public int UpdatedVersionNum{get;set;}

    }
}
