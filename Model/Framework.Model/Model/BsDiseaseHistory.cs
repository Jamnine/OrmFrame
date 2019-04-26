

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:既往史表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsDiseaseHistory : BaseModel
    {   
		private string _name;  //名称
		
		private bool _isActive;  //是否有效
		
		private bool _isdisease;  //是否疾病可用
		
		private bool _isfamily;  //是否家族史可用
		
		private string _operId;  //修改人
		
		private DateTime _operDate;  //修改日期
		
		private int _HospitalID;  //


        /// <summary>
        /// 名称
        /// </summary>
        [Collumn(HeaderName = "既往史", RelatedTableType = null)]
        public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 是否有效
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 是否疾病可用
		/// </summary>
		public bool Isdisease
		{
			get { return _isdisease;}
			set { _isdisease = value;}
		}                                    
		
		/// <summary>
		/// 是否家族史可用
		/// </summary>
		public bool Isfamily
		{
			get { return _isfamily;}
			set { _isfamily = value;}
		}                                    
		
		/// <summary>
		/// 修改人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 修改日期
		/// </summary>
		public DateTime OperDate
		{
			get { return _operDate;}
			set { _operDate = value;}
		}                                    
		
	                                  
		        
	}  
}           


