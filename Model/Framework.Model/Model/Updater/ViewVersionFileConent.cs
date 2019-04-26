// ===================================================================   
// Model  
// ===================================================================   
// File: VersionFile.cs  
//   
// Copyright   
// History:  
// 2015/1/28 10:59:01: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  查看版本文件内容
    /// </summary> 
    [Serializable]
 
    public partial class ViewVersionFileConent : BaseModel
    {
        private byte[] _fileContent;
        private bool _isZip;
        private string _downLoadLocation = String.Empty;

        public ViewVersionFileConent()
        {
        }

        /// <summary>
        /// 文件版本号
        /// </summary>
        public int FileVersionNum { get; set; }

        /// <summary>  
        /// 文件内容  
        /// </summary>  
        public byte[] FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }
        
        /// <summary>  
        /// 是否压缩上传的  
        /// </summary>  
        public bool IsZip
        {
            get { return this._isZip; }
            set { this._isZip = value; }
        }

        /// <summary>  
        /// 文件下载后保存位置  
        /// </summary>  
        public string DownLoadLocation
        {
            get { return this._downLoadLocation; }
            set { this._downLoadLocation = value; }
        }

    }
}
