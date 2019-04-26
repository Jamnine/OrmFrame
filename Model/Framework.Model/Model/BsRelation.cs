

using System;
namespace Orm.Model
{
	/// <summary>
	/// 亲属关系 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRelation : BaseModel
	{   
		 
		private string _code;  //关系ID
		
		private string _name;  //与病人关系
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private bool _isActive;  //有效标志
		
		private int _orderBy;  //显示顺序
		
		private int _iconIndex;  //图标类型
		
		private string _upcode;  //行心云:上报码
		
		private string _ybcode;  //行心云:医保码
		
		private string _modioperID;  //行心云:最后修改人
		
		private DateTime _moditime;  //行心云:最后修改时间
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 关系ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 与病人关系
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
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
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
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
		/// 行心云:上报码
		/// </summary>
		public string Upcode
		{
			get { return _upcode;}
			set { _upcode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string Ybcode
		{
			get { return _ybcode;}
			set { _ybcode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperID
		{
			get { return _modioperID;}
			set { _modioperID = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime Moditime
		{
			get { return _moditime;}
			set { _moditime = value;}
		}                                    
		
	       
	}  
}           


