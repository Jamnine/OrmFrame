

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 系统一级菜单 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblSystem : BaseModel
    {   
		
		
		
		private string _name;  //名称
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private int _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _hospitalId;  //
		                                   
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public int ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


