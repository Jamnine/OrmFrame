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
    /// 版本文件
    /// </summary>  
    [Serializable]
   
    public partial class VersionFile : BaseModel
    {
        private int _upVersionId;
        private string _fileName = String.Empty;
        private string _fileNames = String.Empty;
        private string _fileSize = String.Empty;
        private string _fileTime = String.Empty;
        private byte[] _fileContent ;
        private string _memo = String.Empty;
        private bool _isZip;
        private string _downLoadLocation = String.Empty;

        public VersionFile()
        {
        }

        public virtual int ID { get; set; }
        /// <summary>  
        /// 更新的版本id 
        /// </summary>  
        public int UpVersionId
        {
            get { return this._upVersionId; }
            set { this._upVersionId = value; }
        }

        /// <summary>  
        /// 文件名
        /// </summary>  
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        /// <summary>  
        /// 文件路径+名称  
        /// </summary>  
        public string FileNames
        {
            get { return this._fileNames; }
            set { this._fileNames = value; }
        }

        /// <summary>  
        /// 文件大小  
        /// </summary>  
        public string FileSize
        {
            get { return this._fileSize; }
            set { this._fileSize = value; }
        }

        /// <summary>  
        /// 文件最后修改时间  
        /// </summary>  
        public string FileTime
        {
            get { return this._fileTime; }
            set { this._fileTime = value; }
        }

        /// <summary>  
        /// 文件内容  
        /// </summary>  
        public byte[] FileContent
        {
            get { return this._fileContent; }
            set { this._fileContent = value; }
        }

        /// <summary>  
        /// 备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
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
