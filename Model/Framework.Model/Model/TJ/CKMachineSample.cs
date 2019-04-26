using System;

namespace Orm.Model
{
    /// <summary>  
    /// 仪器流水号匹配
    /// </summary> 
    [Serializable]
    public partial class CKMachineSample : BaseModel
    {
        private string _tjitemId;
        private string _sampleNum;
        private DateTime _matchDate;
        private bool _sendStatus;
        private string _machineID;
        private string _userID;
        private string _patID;
        private string _hosID;
        private bool _isMatching;
        private string _specimenCode;

        private string _labID;
        private int _hosPitalId;

        private bool _isAuthed;
        private string _matchBy;
        private string _preSeq;
        private string _barcode;


        /// <summary>
        /// 诊所id
        /// </summary>
        public int HosPitalId
        {
            get
            {
                return _hosPitalId;
            }

            set
            {
                _hosPitalId = value;
            }
        }


        /// <summary>
        /// 标本ID,CkLab.Id
        /// </summary>
        public string LabId
        {
            get { return _labID; }
            set { _labID = value; }
        }

        /// <summary>  
        /// 检验项目id
        /// </summary>  
        public string TjitemId
        {
            get { return _tjitemId; }
            set { _tjitemId = value; }
        }

        /// <summary>  
        /// 仪器流水号 
        /// </summary>  
        public string SampleNum
        {
            get { return _sampleNum; }
            set { _sampleNum = value; }
        }

        /// <summary>  
        /// 匹配时间  
        /// </summary>  
        public DateTime MatchDate
        {
            get { return _matchDate; }
            set { _matchDate = value; }
        }

        /// <summary>  
        /// 是否传回 
        /// </summary>  
        public bool SendStatus
        {
            get { return _sendStatus; }
            set { _sendStatus = value; }
        }

        /// <summary>  
        /// 仪器id
        /// </summary>  
        public string MachineID
        {
            get { return _machineID; }
            set { _machineID = value; }
        }

        /// <summary>  
        /// 操作人id  
        /// </summary>  
        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        /// <summary>  
        /// 病人id  
        /// </summary>  
        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }

        /// <summary>  
        /// 病人就诊id  
        /// </summary>  
        public string HosID
        {
            get { return _hosID; }
            set { _hosID = value; }
        }

        /// <summary>  
        ///  标本号 
        /// </summary>  
        public string SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        /// <summary>  
        /// 是否匹配
        /// </summary>  
        public bool IsMatching
        {
            get { return _isMatching; }
            set { _isMatching = value; }
        }

        private string _qCReagentlot = String.Empty;
        /// <summary>  
        /// QC试剂批号
        /// </summary>  
        public string QCReagentlot
        {
            get { return _qCReagentlot; }
            set { _qCReagentlot = value; }
        }

        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        public string MatchBy
        {
            get { return _matchBy; }
            set { _matchBy = value; }
        }

        public string PreSeq
        {
            get { return _preSeq; }
            set { _preSeq = value; }
        }
        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
    }
}
