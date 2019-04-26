

using System;
using System.Windows;

namespace Orm.Model
{
	/// <summary>
	/// 病人转诊表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InOutHospital:BaseModel
	{   
		 
		private string _hospId;  //住院病人ID
		
		private string _mzregId;  //门诊就诊ID
		
		private string _patId;  //病人ID
		
		private int  _outHospitalID;  //转诊医院ID
		
		private DateTime _outoperTime;  //转诊时间
		
		private string _outoperId;  //转诊操作人
		
		private string _outDoctorId;  //转诊医生
		
		private bool _isOutSign;  //是否转诊审核
		
		private string _outSignOperId;  //转诊审核人
		
		private DateTime _outSignTime;  //转诊审核时间
		
		private string _outSignMemo;  //转诊审核备注
		
		private string  _inHospitalID;  //接诊医院ID
		
		private DateTime _inOperTime;  //接诊时间
		
		private string _inOperId;  //接诊人
		
		private string _inDoctorId;  //接诊医生
		
		private bool _isInsign;  //是否接诊审核
		
		private string _inSignOperId;  //接诊审核人
		
		private DateTime _inSignTime;  //接诊审核时间
		
		private string _inSignMemo;  //接诊审核人备注
		
		private string _refNo;  //转诊流水号
		
		private string _treatmentPro;  //治疗经过，
		
		private string _diagGoal;  //诊疗目的

		
		private int _lsEmergency;  //紧急程度:1一般2急3紧急
		
		private string _inlocationid;  //转入科室

        private string _referralSource;  //转诊来源

        private string _outHospitalName;  //转入医院名称


        /// <summary>
        /// 转入医院名称
        /// </summary>
        public string OutHospitalName
        {
            get { return _outHospitalName; }
            set { _outHospitalName = value; }
        }

        /// <summary>
        /// 转诊来源
        /// </summary>
        public string ReferralSource
        {
            get { return _referralSource; }
            set { _referralSource = value; }
        }

        /// <summary>
        /// 住院病人ID
        /// </summary>
        public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 门诊就诊ID
		/// </summary>
		public string MzregId
		{
			get { return _mzregId;}
			set { _mzregId = value;}
		}                                    
		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatId
		{
			get { return _patId;}
			set { _patId = value;}
		}                                    
		
		/// <summary>
		/// 转诊医院ID
		/// </summary>
		public int  OutHospitalID
		{
			get { return _outHospitalID;}
			set { _outHospitalID = value;}
		}

        /// <summary>
        /// 接诊医院ID
        /// </summary>
        public string InHospitalID
        {
            get { return _inHospitalID; }
            set { _inHospitalID = value; }
        }

        /// <summary>
        /// 转诊时间
        /// </summary>
        public DateTime OutoperTime
		{
			get { return _outoperTime;}
			set { _outoperTime = value;}
		}                                    
		
		/// <summary>
		/// 转诊操作人
		/// </summary>
		public string OutoperId
		{
			get { return _outoperId;}
			set { _outoperId = value;}
		}                                    
		
		/// <summary>
		/// 转诊医生
		/// </summary>
		public string OutDoctorId
		{
			get { return _outDoctorId;}
			set { _outDoctorId = value;}
		}                                    
		
		/// <summary>
		/// 是否转诊审核
		/// </summary>
		public bool IsOutSign
		{
			get { return _isOutSign;}
			set { _isOutSign = value;}
		}                                    
		
		/// <summary>
		/// 转诊审核人
		/// </summary>
		public string OutSignOperId
		{
			get { return _outSignOperId;}
			set { _outSignOperId = value;}
		}                                    
		
		/// <summary>
		/// 转诊审核时间
		/// </summary>
		public DateTime OutSignTime
		{
			get { return _outSignTime;}
			set { _outSignTime = value;}
		}                                    
		
		/// <summary>
		/// 转诊审核备注
		/// </summary>
		public string OutSignMemo
		{
			get { return _outSignMemo;}
			set { _outSignMemo = value;}
		}                                    
		
		/// <summary>
		/// 接诊时间
		/// </summary>
		public DateTime InOperTime
		{
			get { return _inOperTime;}
			set { _inOperTime = value;}
		}                                    
		
		/// <summary>
		/// 接诊人
		/// </summary>
		public string InOperId
		{
			get { return _inOperId;}
			set { _inOperId = value;}
		}                                    
		
		/// <summary>
		/// 接诊医生
		/// </summary>
		public string InDoctorId
		{
			get { return _inDoctorId;}
			set { _inDoctorId = value;}
		}

        /// <summary>
        /// 是否接受完成
        /// </summary>
        public Visibility IsAccept { get; set; }

        /// <summary>
        /// 是否接诊审核
        /// </summary>
        public bool IsInsign
		{
            get { return _isInsign; }
            set
            {
                _isInsign = value;
                if (!string.IsNullOrWhiteSpace(InOperId))
                {
                    IsAccept = Visibility.Collapsed;
                }
                else
                {
                    IsAccept = Visibility.Visible;
                }
            }
        }                                    
		
		/// <summary>
		/// 接诊审核人
		/// </summary>
		public string InSignOperId
		{
			get { return _inSignOperId;}
			set { _inSignOperId = value;}
		}                                    
		
		/// <summary>
		/// 接诊审核时间
		/// </summary>
		public DateTime InSignTime
		{
			get { return _inSignTime;}
			set { _inSignTime = value;}
		}                                    
		
		/// <summary>
		/// 接诊审核人备注
		/// </summary>
		public string InSignMemo
		{
			get { return _inSignMemo;}
			set { _inSignMemo = value;}
		}                                    
		
		/// <summary>
		/// 转诊流水号
		/// </summary>
		public string RefNo
		{
			get { return _refNo;}
			set { _refNo = value;}
		}                                    
		
		/// <summary>
		/// 治疗经过，
		/// </summary>
		public string TreatmentPro
		{
			get { return _treatmentPro;}
			set { _treatmentPro = value;}
		}                                    
		
		/// <summary>
		/// 诊疗目的 
		/// </summary>
		public string DiagGoal
		{
			get { return _diagGoal;}
			set { _diagGoal = value;}
		}                                    
		
		/// <summary>
		/// 紧急程度:1一般2急3紧急
		/// </summary>
		public int LsEmergency
		{
			get { return _lsEmergency;}
			set { _lsEmergency = value;}
		}                                    
		
		/// <summary>
		/// 转入科室
		/// </summary>
		public string Inlocationid
		{
			get { return _inlocationid;}
			set { _inlocationid = value;}
		}
        /// <summary>
        /// 接诊医生电话
        /// </summary>
        public string InDocPhone { get; set; }

        /// <summary>
        /// 转出操作人
        /// </summary>
        public string OutOperName { get; set; }

        /// <summary>
        /// 接诊操作人
        /// </summary>
        public string InOperName { get; set; }
        /// <summary>
        /// 转出医院名
        /// </summary>
        public string OutHospName { get; set; }

        /// <summary>
        /// 转出审核人
        /// </summary>
        public string OutSignOperName { get; set; }

        /// <summary>  
        /// 紧急程度:1一般   2急  3紧急  
        /// </summary>  
        public string LsemergencyStr { get; set; }

        /// <summary>
        /// 转入审核人
        /// </summary>
        public string InSignOperName { get; set; }

        /// <summary>
        /// 转出医院省份ID
        /// </summary>
        public string ProvinceId { get; set; }

        /// <summary>
        /// 转入医院省份
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// 转出医院市县ID
        /// </summary>
        public string RegIonId { get; set; }
        
        /// <summary>
        /// 转入医院市县
        /// </summary>
        public string RegIonName { get; set; }

        /// <summary>
        /// 转入医院
        /// </summary>
        public string InHospitalName { get; set; }

        /// <summary>
        /// 病人卡号
        /// </summary>
        public string PatCardNo { get; set; }

        /// <summary>
        /// 是否转出审核
        /// </summary>
        public string IsOutSignStr { get; set; }

        /// <summary>
        /// 是否转入审核
        /// </summary>
        public string IsInSignStr { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IDcardNo { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 性别
        /// </summary> 
        public string Sex { get; set; }
    }  
}