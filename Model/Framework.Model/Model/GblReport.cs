

using System;
namespace Orm.Model
{
	/// <summary>
	/// 报表类型 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblReport : BaseModel
    {   
		 
		private string _name;  //名称
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _lsOutOrIn;  //报表范畴：1-门诊；2-住院
		
		private int _iconIndex;  //图标类型
		
		private int _HospitalID;  //
		 
         
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
		/// 报表范畴：1-门诊；2-住院
		/// </summary>
		public int LsOutOrIn
		{
			get { return _lsOutOrIn;}
			set { _lsOutOrIn = value;}
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


