

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊执行单明细(注射) - 实体类
	/// </summary>
	[Serializable]
	public partial class OuExecuteDtl : BaseModel  
	{   
		 	
		private string _executeId;  //执行ID
		
		private string _recipeDtlId;  //处方明细ID
		
		private int _listNum;  //序号
		
		private string _itemId;  //项目Id,BsItem.id
		
		private double _dosage;  //发生数量
		
		private string _unitId;  //发生单位
		
		private string _usageId;  //用法
		
		private string _frequencyId;  //频率
		
		private int _days;  //天数
		
		private double _totality;  //发药总量
		
		private string _unitDiagId;  //门诊单位
		
		private DateTime _issueTime;  //发药时间
		
		private DateTime _backTime;  //退药时间
		
		private bool _isExecuted;  //是否执行
		
		private DateTime _executedTime;  //执行时间
		
		private string _operId;  //执行人
		
		private DateTime _operTime;  //操作时间
		
		private string _sTMemo;  //皮试备注
		
		private string _usageName;  //用法
		
		private string _prepareTime;  //打印日期
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isSkinTest;  //是否皮试
		
		private int _HospitalID;  //
		                                  
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 处方明细ID
		/// </summary>
		public string RecipeDtlId
		{
			get { return _recipeDtlId;}
			set { _recipeDtlId = value;}
		}                                    
		
		/// <summary>
		/// 序号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 项目Id,BsItem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 发生数量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 发生单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 频率
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 发药总量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 门诊单位
		/// </summary>
		public string UnitDiagId
		{
			get { return _unitDiagId;}
			set { _unitDiagId = value;}
		}                                    
		
		/// <summary>
		/// 发药时间
		/// </summary>
		public DateTime IssueTime
		{
			get { return _issueTime;}
			set { _issueTime = value;}
		}                                    
		
		/// <summary>
		/// 退药时间
		/// </summary>
		public DateTime BackTime
		{
			get { return _backTime;}
			set { _backTime = value;}
		}                                    
		
		/// <summary>
		/// 是否执行
		/// </summary>
		public bool IsExecuted
		{
			get { return _isExecuted;}
			set { _isExecuted = value;}
		}                                    
		
		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime ExecutedTime
		{
			get { return _executedTime;}
			set { _executedTime = value;}
		}                                    
		
		/// <summary>
		/// 执行人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 皮试备注
		/// </summary>
		public string STMemo
		{
			get { return _sTMemo;}
			set { _sTMemo = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageName
		{
			get { return _usageName;}
			set { _usageName = value;}
		}                                    
		
		/// <summary>
		/// 打印日期
		/// </summary>
		public string PrepareTime
		{
			get { return _prepareTime;}
			set { _prepareTime = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 是否皮试
		/// </summary>
		public bool IsSkinTest
		{
			get { return _isSkinTest;}
			set { _isSkinTest = value;}
		}                                    
		                                  
		        
	}  
}           


