

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用血报销 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBldReimb : BaseModel
	{   
		 
		private string _hospId;  //住院ID
		
		private string _locationId;  //科室
		
		private string _bloodGroup;  //血型：1-A;2-B;3-O;4-AB

        private string _rhd;  //血型：1-A;2-B;3-O;4-AB

        private string _bloodTypeId;  //血液种类
		
		private double _vollume;  //血量
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //
		
		private string _operId;  //
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //



        /// <summary>
        /// 住院ID
        /// </summary>
        public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 血型：1-A;2-B;3-O;4-AB
		/// </summary>
		public string BloodGroup
		{
			get { return _bloodGroup;}
			set { _bloodGroup = value;}
		}

        public string RHD
        {
            get { return _rhd; }
            set { _rhd = value; }
        }

        

        /// <summary>
        /// 血液种类
        /// </summary>
        public string BloodTypeId
		{
			get { return _bloodTypeId;}
			set { _bloodTypeId = value;}
		}                                    
		
		/// <summary>
		/// 血量
		/// </summary>
		public double Vollume
		{
			get { return _vollume;}
			set { _vollume = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}


    }  
}           


