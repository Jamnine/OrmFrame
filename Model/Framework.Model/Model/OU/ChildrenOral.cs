// ===================================================================   
// Model  
// ===================================================================   
// File: ChildrenOral.cs  
//   
// Copyright   
// History:  
// 2015/2/27 15:47:38: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>
    /// 小孩口腔表
    /// </summary>
    [Serializable]
    public partial class ChildrenOral : BaseModel
    {
        private string _schoolName = String.Empty;
        private string _classLevel = String.Empty;
        private string _studentID = String.Empty;
        private string _name = String.Empty;
        private string _sex = String.Empty;
        private DateTime _birthday;
        private string _dentalConditions = String.Empty;
        private DateTime _checkDate;
        private bool _isParentalConsent;
        private string _pitAndFissure = String.Empty;
        private DateTime _operatorDate;
        private string _signature = String.Empty;
        private string _review = String.Empty;
        private DateTime _reviewDate;
        private string _telephone = String.Empty;
        private string _memo = String.Empty;
        private string _operId;
        private DateTime _operTime;
        private string _reClose = String.Empty;
        private string _operName = String.Empty;
        private string _parentsAgree = String.Empty;
        private int _hospitalId;  //医院id
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public ChildrenOral()
        {
        }

        /// <summary>  
        /// 学校名称  
        /// </summary> 
        [Collumn(HeaderName = "学校名称", RelatedTableType = null)]
        public string SchoolName
        {
            get { return this._schoolName; }
            set { this._schoolName = value; }
        }

        /// <summary>  
        /// 班级  
        /// </summary> 
        [Collumn(HeaderName = "班级", RelatedTableType = null)]
        public string ClassLevel
        {
            get { return this._classLevel; }
            set { this._classLevel = value; }
        }

        /// <summary>  
        /// 学号  
        /// </summary>  
        [Collumn(HeaderName = "学号", RelatedTableType = null)]
        public string StudentID
        {
            get { return this._studentID; }
            set { this._studentID = value; }
        }

        /// <summary>  
        /// 姓名  
        /// </summary>  
        [Collumn(HeaderName = "姓名", RelatedTableType = null)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        /// 性别  
        /// </summary> 
        [Collumn(HeaderName = "性别", RelatedTableType = null)]
        public string Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        /// <summary>  
        /// 出生日期  
        /// </summary> 
        [Collumn(HeaderName = "出生日期", RelatedTableType = null)]
        public DateTime Birthday
        {
            get { return this._birthday; }
            set { this._birthday = value; }
        }

        /// <summary>  
        /// 牙齿情况 保存数据为 1-2|2-4|3-2|4-1  (1-2 :1=位置 2=情况编码 部分萌出)  
        /// </summary> 
        [Collumn(HeaderName = "牙齿情况", RelatedTableType = null)]
        public string DentalConditions
        {
            get { return this._dentalConditions; }
            set { this._dentalConditions = value; }
        }

        /// <summary>  
        /// 检查日期  
        /// </summary>
        [Collumn(HeaderName = "检查日期", RelatedTableType = null)]
        public DateTime CheckDate
        {
            get { return this._checkDate; }
            set { this._checkDate = value; }
        }

        /// <summary>  
        /// 家长是否同意 1同意,0不同意  
        /// </summary>
        [Collumn(HeaderName = "家长是否同意", RelatedTableType = null)]
        public bool IsParentalConsent
        {
            get { return this._isParentalConsent; }
            set { this._isParentalConsent = value; }
        }

        /// <summary>  
        /// 窝沟封闭 保存数据为 1-1|2-1|3-2|4-2   (2-1: 2=位置 1=封闭情况编码  未封闭)  
        /// </summary>  
        [Collumn(HeaderName = "窝沟封闭", RelatedTableType = null)]
        public string PitAndFissure
        {
            get { return this._pitAndFissure; }
            set { this._pitAndFissure = value; }
        }

        /// <summary>  
        /// 操作者日期  
        /// </summary>  
        [Collumn(HeaderName = "操着者/日期", RelatedTableType = null)]
        public DateTime OperatorDate
        {
            get { return this._operatorDate; }
            set { this._operatorDate = value; }
        }

        /// <summary>  
        /// 家长教师签字  
        /// </summary> 
        [Collumn(HeaderName = "家长/教师签名", RelatedTableType = null)]
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        /// <summary>  
        /// 复查 保存数据为  3-2|4-2   (3-2:  3=位置 2=封闭情况编码  未封闭)  
        /// </summary> 
        [Collumn(HeaderName = "复查", RelatedTableType = null)]
        public string Review
        {
            get { return this._review; }
            set { this._review = value; }
        }

        /// <summary>  
        /// 复查日期  
        /// </summary> 
        [Collumn(HeaderName = "复查者/日期", RelatedTableType = null)]
        public DateTime ReviewDate
        {
            get { return this._reviewDate; }
            set { this._reviewDate = value; }
        }

        /// <summary>  
        /// 联系电话  
        /// </summary>  
        [Collumn(HeaderName = "联系电话", RelatedTableType = null)]
        public string Telephone
        {
            get { return this._telephone; }
            set { this._telephone = value; }
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
        /// 录入人  
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 录入时间  
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>
        /// 重封闭情况
        /// </summary>
        [Collumn(HeaderName = "重封闭情况", RelatedTableType = null)]
        public string ReClose
        {
            get { return this._reClose; }
            set { this._reClose = value; }
        }

        /// <summary>
        /// 录入人姓名
        /// </summary>
        [Collumn(HeaderName = "录入人姓名", RelatedTableType = null)]
        public string OperName
        {
            get { return this._operName; }
            set { this._operName = value; }
        }

        /// <summary>
        /// 家长是否同意
        /// </summary>
        public string ParentsAgree
        {
            get { return this._parentsAgree; }
            set { this._parentsAgree = value; }
        }
        /// <summary>
		/// 医院id
		/// </summary>
		public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }
    }
}

