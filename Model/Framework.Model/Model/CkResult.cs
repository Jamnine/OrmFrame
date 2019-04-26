

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检单结果 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkResult : BaseModel
    {   
		 
		private string _checkId;  //体检ID,CkMain.Id
		
		private string _testId;  //项目代码
		
		private string _lastResult;  //上次检查结果
		
		private string _result;  //检查结果
		
		private int _lsRefFlag;  //超标标志：1-高；2-低
		
		private bool _isPanic;  //危险标志
		
		private bool _isDalta;  //上次对比超标标志
		
		private double _dalAbsolute;  //上次对比正常范围（绝对值）
		
		private double _dalPercent;  //上次对比正常范围（百分比）
		
		private double _lowValue;  //正常低值
		
		private double _highValue;  //正常高值
		
		private double _panicLow;  //危险低值
		
		private double _panicHigh;  //危险高值
		
		private bool _isPass;  //是否合格
		
		private DateTime _reportDate;  //检查时间
		
		private string _reportBy;  //检查人
		
		private bool _isPrint;  //是否需要打印
		
		private string _memo;  //报告备注
		
		private string _parentID;  //父ID
		
		private string _textRange;  //文本型的范围
		
		private double _price;  //价格
		
		private double _discount;  //折扣
		
		private string _testGroupId;  //检查分组
		
		private string _itemId;  //项目Id
		
		private string _appId;  //应用Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 体检ID,CkMain.Id
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 项目代码
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 上次检查结果
		/// </summary>
		public string LastResult
		{
			get { return _lastResult;}
			set { _lastResult = value;}
		}                                    
		
		/// <summary>
		/// 检查结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
		}                                    
		
		/// <summary>
		/// 超标标志：1-高；2-低
		/// </summary>
		public int LsRefFlag
		{
			get { return _lsRefFlag;}
			set { _lsRefFlag = value;}
		}                                    
		
		/// <summary>
		/// 危险标志
		/// </summary>
		public bool IsPanic
		{
			get { return _isPanic;}
			set { _isPanic = value;}
		}                                    
		
		/// <summary>
		/// 上次对比超标标志
		/// </summary>
		public bool IsDalta
		{
			get { return _isDalta;}
			set { _isDalta = value;}
		}                                    
		
		/// <summary>
		/// 上次对比正常范围（绝对值）
		/// </summary>
		public double DalAbsolute
		{
			get { return _dalAbsolute;}
			set { _dalAbsolute = value;}
		}                                    
		
		/// <summary>
		/// 上次对比正常范围（百分比）
		/// </summary>
		public double DalPercent
		{
			get { return _dalPercent;}
			set { _dalPercent = value;}
		}                                    
		
		/// <summary>
		/// 正常低值
		/// </summary>
		public double LowValue
		{
			get { return _lowValue;}
			set { _lowValue = value;}
		}                                    
		
		/// <summary>
		/// 正常高值
		/// </summary>
		public double HighValue
		{
			get { return _highValue;}
			set { _highValue = value;}
		}                                    
		
		/// <summary>
		/// 危险低值
		/// </summary>
		public double PanicLow
		{
			get { return _panicLow;}
			set { _panicLow = value;}
		}                                    
		
		/// <summary>
		/// 危险高值
		/// </summary>
		public double PanicHigh
		{
			get { return _panicHigh;}
			set { _panicHigh = value;}
		}                                    
		
		/// <summary>
		/// 是否合格
		/// </summary>
		public bool IsPass
		{
			get { return _isPass;}
			set { _isPass = value;}
		}                                    
		
		/// <summary>
		/// 检查时间
		/// </summary>
		public DateTime ReportDate
		{
			get { return _reportDate;}
			set { _reportDate = value;}
		}                                    
		
		/// <summary>
		/// 检查人
		/// </summary>
		public string ReportBy
		{
			get { return _reportBy;}
			set { _reportBy = value;}
		}                                    
		
		/// <summary>
		/// 是否需要打印
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 报告备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 父ID
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 文本型的范围
		/// </summary>
		public string TextRange
		{
			get { return _textRange;}
			set { _textRange = value;}
		}                                    
		
		/// <summary>
		/// 价格
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 折扣
		/// </summary>
		public double Discount
		{
			get { return _discount;}
			set { _discount = value;}
		}                                    
		
		/// <summary>
		/// 检查分组
		/// </summary>
		public string TestGroupId
		{
			get { return _testGroupId;}
			set { _testGroupId = value;}
		}                                    
		
		/// <summary>
		/// 项目Id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 应用Id
		/// </summary>
		public string AppId
		{
			get { return _appId;}
			set { _appId = value;}
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


