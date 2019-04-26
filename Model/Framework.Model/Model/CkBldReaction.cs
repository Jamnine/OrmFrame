

using System;
namespace Orm.Model
{
    /// <summary>
    /// 病人用血 - 实体类
    /// </summary>
    [Serializable]
    public partial class CkBldReaction : BaseModel
    {

        private string _recNo;  //申请单号

        private string _labId;  //标本号

        private string _hospId;  //住院号

        private string _bloodId;  //血袋ID

        private DateTime _transTime;  //输血时间

        private string _locationId;  //科室

        private string _doctorId;  //输血医生

        private string _transType;  //受血方式

        private double _totalVollume;  //实际输入量

        private DateTime _reactTime;  //反应时间

        private int _lsTransType;  //输血反应类型：1-发热、2-过敏、3-荨麻疹、4-溶血反应、5-非溶血性发热、6-心功能衰竭、7-循环负荷过重、8-肺部并发症

        private string _clincHandle;  //临床处理

        private string _transHandle;  //输血科处理

        private string _memo;  //备注

        private DateTime _operTime;  //操作时间

        private string _operId;  //操作员ID,BsUser.Id

        private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //


        /// <summary>
        /// 申请单号
        /// </summary>
        public string LabId
        {
            get { return _labId; }
            set { _labId = value; }
        }
        
        /// <summary>
        /// 申请单号
        /// </summary>
        public string RecNo
        {
            get { return _recNo; }
            set { _recNo = value; }
        }
          
        /// <summary>
        /// 住院号
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        /// <summary>
        /// 血袋ID
        /// </summary>
        public string BloodId
        {
            get { return _bloodId; }
            set { _bloodId = value; }
        }

        /// <summary>
        /// 输血时间
        /// </summary>
        public DateTime TransTime
        {
            get { return _transTime; }
            set { _transTime = value; }
        }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 输血医生
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 受血方式
        /// </summary>
        public string TransType
        {
            get { return _transType; }
            set { _transType = value; }
        }

        /// <summary>
        /// 实际输入量
        /// </summary>
        public double TotalVollume
        {
            get { return _totalVollume; }
            set { _totalVollume = value; }
        }

        /// <summary>
        /// 反应时间
        /// </summary>
        public DateTime ReactTime
        {
            get { return _reactTime; }
            set { _reactTime = value; }
        }

        /// <summary>
        /// 输血反应类型：1-发热、2-过敏、3-荨麻疹、4-溶血反应、5-非溶血性发热、6-心功能衰竭、7-循环负荷过重、8-肺部并发症
        /// </summary>
        public int LsTransType
        {
            get { return _lsTransType; }
            set { _lsTransType = value; }
        }

        /// <summary>
        /// 临床处理
        /// </summary>
        public string ClincHandle
        {
            get { return _clincHandle; }
            set { _clincHandle = value; }
        }

        /// <summary>
        /// 输血科处理
        /// </summary>
        public string TransHandle
        {
            get { return _transHandle; }
            set { _transHandle = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 操作员ID,BsUser.Id
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }
    }
}           


