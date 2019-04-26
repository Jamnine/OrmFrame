// ===================================================================   
// Model  
// ===================================================================   
// File: OuWebPreReg.cs  
//   
// Copyright   
// History:  
// 2015/7/28 19:38:38: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  预约申请表  // 数据库不存在此表
    /// </summary> 
    [Serializable]
    public partial class OuWebPreReg : BaseModel
    {
        private string _patID;
        private string _webUserCode = String.Empty;
        private string _name = String.Empty;
        private string _sex = String.Empty;
        private DateTime _birthDate;
        private string _phone = String.Empty;
        private string _bookingPurpose = String.Empty;
        private string _bookingComments = String.Empty;
        private string _comments = String.Empty;
        private DateTime _preRegTime;
        private string _timeSpanSubID;
        private string _doctorId;
        private string _mzRegID;
        private string _locationID;
        private DateTime _applyTime;
        private string _operId;
        private DateTime _operTime;
        private bool _isDealed;
        private bool _isActive;
        private int _status = 0;
        public OuWebPreReg()
        {
        }
        /// <summary>  
        /// 病人ID
        /// </summary>  
        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }

        /// <summary>  
        /// 病人微信绑定的手机号码  
        /// </summary>  
        public string WebUserCode
        {
            get { return this._webUserCode; }
            set { this._webUserCode = value; }
        }

        /// <summary>  
        ///  姓名
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        ///   性别
        /// </summary>  
        public string Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        /// <summary>  
        ///   生日
        /// </summary>  
        public DateTime BirthDate
        {
            get { return this._birthDate; }
            set { this._birthDate = value; }
        }

        /// <summary>  
        ///   电话
        /// </summary>  
        public string Phone
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        /// <summary>  
        /// 预约目的  
        /// </summary>  
        public string BookingPurpose
        {
            get { return this._bookingPurpose; }
            set { this._bookingPurpose = value; }
        }

        /// <summary>  
        /// 预约备注(病情描述)  
        /// </summary>  
        public string BookingComments
        {
            get { return this._bookingComments; }
            set { this._bookingComments = value; }
        }



        /// <summary>  
        ///   备注
        /// </summary>  
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        /// <summary>  
        ///   预约日期
        /// </summary>  
        public DateTime PreRegTime
        {
            get { return this._preRegTime; }
            set { this._preRegTime = value; }
        }
        /// <summary>  
        ///   时段ID
        /// </summary>  
        public string TimeSpanSubID
        {
            get { return this._timeSpanSubID; }
            set { this._timeSpanSubID = value; }
        }

        /// <summary>  
        ///   医生ID
        /// </summary>  
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }

        /// <summary>  
        ///   申请时间
        /// </summary>  
        public DateTime ApplyTime
        {
            get { return this._applyTime; }
            set { this._applyTime = value; }
        }

        /// <summary>  
        ///   操作人ID
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        ///   操作时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 是否处理  
        /// </summary>  
        public bool IsDealed
        {
            get { return this._isDealed; }
            set { this._isDealed = value; }
        }

        /// <summary>  
        /// 是否使用
        /// </summary>  
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        public int BookingSource { get; set; }

        /// <summary>
        /// 确认预约成功后预约信息的ID
        /// </summary>
        public string MzRegID
        {
            get { return this._mzRegID; }
            set { this._mzRegID = value; }
        }

        /// <summary>
        /// 诊所科室ID
        /// </summary>
        public string LocationID
        {
            get { return this._locationID; }
            set { this._locationID = value; }
        }

        /// <summary>
        /// 0 未处理 1 已确认 2 已回绝
        /// </summary>
        public int Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

    }
}

