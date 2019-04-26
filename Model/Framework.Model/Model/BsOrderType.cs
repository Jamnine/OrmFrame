

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云：订单类型 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsOrderType:BaseModel
	{    
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _pYCode;  //拼音码
		
		private string _wBCode;  //五笔码
		
		private DateTime _modiTime;  //最后修改时间
		
		private string _modiOperId;  //最后修改人
		  
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PYCode
		{
			get { return _pYCode;}
			set { _pYCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WBCode
		{
			get { return _wBCode;}
			set { _wBCode = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		        
	}  
}           


