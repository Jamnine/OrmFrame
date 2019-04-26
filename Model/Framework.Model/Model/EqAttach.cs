

using System;
namespace Orm.Model
{
    /// <summary>
    /// 设备文件表 - 实体类
    /// </summary>
    [Serializable]
    public partial class EqAttach : BaseModel
    {
        private string _equipmentId;  //设备

        private string _fileName;  //

        private string _lsFileType;  //1.合同2.附件3.扫描件;

        private byte[] _attachFile;  //

        private bool _isAuthed;  //是否封存

        private DateTime _expirationDate;

        private DateTime _uploadDate;

        private string _memo;  //描述

        public EqAttach() { }

        /// <summary>
        /// 设备
        /// </summary>
        public string EquipmentId
        {
            get { return _equipmentId; }
            set { _equipmentId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// 1.合同2.附件3.扫描件;
        /// </summary>
        public string LsFileType
        {
            get { return _lsFileType; }
            set { _lsFileType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] AttachFile
        {
            get { return _attachFile; }
            set { _attachFile = value; }
        }

        /// <summary>
        /// 是否封存
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }
        public DateTime UploadDate
        {
            get { return _uploadDate; }
            set { _uploadDate = value; }
        }

        public string Memo
        {
            get { return _memo; }
            set { this._memo = value; }
        }
    }
}


