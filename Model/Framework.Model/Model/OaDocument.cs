

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class OaDocument : BaseModel
    {   
		 
		private string _code;  //文档
		
		private string _name;  //主题
		
		private string _groupMainId;  //主组
		
		private string _groupSubId;  //子组
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private string _operId;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private string _locationId;  //创建部门
		
		private bool _isActive;  //是否可用
		
		private string _inActiveReason;  //非活动的原因
		
		private DateTime _inActiveTime;  //非活动(作废)时间
		
		private string _inActiveOperID;  //作废人
		
		private int _iconIndex;  //图标类型
		
		private int _security;  //保密等级
		
		private string _password;  //密码
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 文档
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 主题
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 主组
		/// </summary>
		public string GroupMainId
		{
			get { return _groupMainId;}
			set { _groupMainId = value;}
		}                                    
		
		/// <summary>
		/// 子组
		/// </summary>
		public string GroupSubId
		{
			get { return _groupSubId;}
			set { _groupSubId = value;}
		}                                    
		
		/// <summary>
		/// 使用权：1-个人；2-科室；3-公共
		/// </summary>
		public int LsOpenType
		{
			get { return _lsOpenType;}
			set { _lsOpenType = value;}
		}                                    
		
		/// <summary>
		/// 创建人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 创建部门
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 非活动的原因
		/// </summary>
		public string InActiveReason
		{
			get { return _inActiveReason;}
			set { _inActiveReason = value;}
		}                                    
		
		/// <summary>
		/// 非活动(作废)时间
		/// </summary>
		public DateTime InActiveTime
		{
			get { return _inActiveTime;}
			set { _inActiveTime = value;}
		}                                    
		
		/// <summary>
		/// 作废人
		/// </summary>
		public string InActiveOperID
		{
			get { return _inActiveOperID;}
			set { _inActiveOperID = value;}
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
		/// 保密等级
		/// </summary>
		public int Security
		{
			get { return _security;}
			set { _security = value;}
		}                                    
		
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			get { return _password;}
			set { _password = value;}
		}                                    
		                                  
		        
	}  
}           


