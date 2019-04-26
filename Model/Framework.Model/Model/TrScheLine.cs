

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class TrScheLine:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _locationId;  //所属科室
		
		private string _memo;  //备注
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private string _labelId;  //标本ID,CkLab.Id
		
		private DateTime _startTime;  //开始时间
		
		private DateTime _endTime;  //结束时间
		
		private int _HospitalID;  //
		 

		                     
		
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
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
		/// 标本ID,CkLab.Id
		/// </summary>
		public string LabelId
		{
			get { return _labelId;}
			set { _labelId = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime
		{
			get { return _startTime;}
			set { _startTime = value;}
		}                                    
		
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		                                 
		        
	}  
}           


