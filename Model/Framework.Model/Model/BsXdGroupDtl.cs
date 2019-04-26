

using System;
namespace Orm.Model
{
	/// <summary>
	/// 控制面版治疗项目明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsXdGroupDtl : BaseModel
    {   
		 
		private string _groupId;  //组ID
		
		private string _xdRpId;  //协定处方ID
		
		private int _orderBy;  //显示次序
		
		private bool _isActive;  //是否可用
		
		private int _lsOpenType;  //使用权：1-个人；2-科室；3-公共
		
		private string _operId;  //创建人
		
		private DateTime _operTime;  //创建时间
		
		private string _locationId;  //创建部门
		
		private int _iconIndex;  //图标类型
		
		private int _HospitalID;  //

        public BsXdGroupDtl() { }
         
		/// <summary>
		/// 组ID
		/// </summary>
		public string GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string XdRpId
		{
			get { return _xdRpId;}
			set { _xdRpId = value;}
		}                                    
		
		/// <summary>
		/// 显示次序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
	                                 
		        
	}  
}           


