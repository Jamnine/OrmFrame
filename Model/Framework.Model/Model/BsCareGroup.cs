

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsCareGroup:BsBank
	{   
		
		
		
		private string _code;  //编码
		
		private string _name;  //团队名称
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private string _doctorId;  //责任医生
		
		private string _nurseUserId;  //责任护士
		
		private string _guardUserId;  //防保人员
		
		private string _otherUserId;  //其它人员
		
		private int _iconIndex;  //图标类型

        private int _HospitalID;//医院ID
         
		///// <summary>
		///// 编码
		///// </summary>
		//public string Code
		//{
		//	get { return _code;}
		//	set { _code = value;}
		//}                                    
		
		/// <summary>
		/// 团队名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 责任医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 责任护士
		/// </summary>
		public string NurseUserId
		{
			get { return _nurseUserId;}
			set { _nurseUserId = value;}
		}                                    
		
		/// <summary>
		/// 防保人员
		/// </summary>
		public string GuardUserId
		{
			get { return _guardUserId;}
			set { _guardUserId = value;}
		}                                    
		
		/// <summary>
		/// 其它人员
		/// </summary>
		public string OtherUserId
		{
			get { return _otherUserId;}
			set { _otherUserId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }
    }  
}           


