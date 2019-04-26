

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:患者划价表 - 实体类
	/// </summary>  
    [Serializable]
	public partial class PatPricereCords  : BaseModel
	{
        private string _houid;
        private double _price;
        private DateTime _corddate;
        private string _remarks;
        private string _doctorID;
        private bool _isCharge;
        private bool _isActive;
        private bool _enabled;
        private string _ouinvoiceID;
        private string _nurseID;
        private string _consultID;
        private int _HospitalID;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public PatPricereCords()
        {
        }

        /// <summary>
        /// 挂号ID
        /// </summary>
        public string HouId { get { return this._houid; } set { this._houid = value; } }

        /// <summary>
        /// 划价价格
        /// </summary>
        public double Price { get { return this._price; } set { this._price = value; } }

        /// <summary>
        /// 划价时间
        /// </summary>
        public DateTime CordDate { get { return this._corddate; } set { this._corddate = value; } }

        /// <summary>
        /// 划价备注
        /// </summary>
        public string Remarks { get { return this._remarks; } set { this._remarks = value; } }

        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID { get { return this._doctorID; } set { this._doctorID = value; } }

        /// <summary>
        /// 是否结算
        /// </summary>
        public bool IsCharge { get { return this._isCharge; } set { this._isCharge = value; } }

        /// <summary>
        /// 是否对收费信息启用
        /// </summary>
        public bool Enabled { get { return !this._isCharge; } set { this._enabled = !this._isCharge; } }

        /// <summary>
        /// 发票ID
        /// </summary> 
        public string OuinvoiceID { get { return this._ouinvoiceID; } set { this._ouinvoiceID = value; } }

        /// <summary>
        /// 护士
        /// </summary>
        public string NurseID { get { return this._nurseID; } set { this._nurseID = value; } }

        /// <summary>
        /// 专家助理
        /// </summary> 
        public string ConsultID { get { return this._consultID; } set { this._consultID = value; } }

        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        
    }  
}           


