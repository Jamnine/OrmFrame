

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史门诊处方执行 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistOuExecuteDtl : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		 
		private string _executeId;  //执行ID
		
		private string _recipeDtlId;  //处方明细ID,OuRecipeDtl.id
		
		private int _listNum;  //方号
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _dosage;  //每次量
		
		private string _unitId;  //药房单位
		
		private string _usageId;  //用法对应BsUsage.Id
		
		private string _frequencyId;  //频率对应BsFrequency.Id
		
		private int _days;  //天数
		
		private double _totality;  //数量
		
		private string _unitDiagId;  //门诊单位
		
		private DateTime _issueTime;  //发药时间
		
		private DateTime _backTime;  //退药时间
		
		private bool _isExecuted;  //是否已执行
		
		private DateTime _executedTime;  //执行时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _sTMemo;  //皮试备注
		
		private string _usageName;  //用法
		
		private string _prepareTime;  //打印时间
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
		}                                    
		                                
		
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 处方明细ID,OuRecipeDtl.id
		/// </summary>
		public string RecipeDtlId
		{
			get { return _recipeDtlId;}
			set { _recipeDtlId = value;}
		}                                    
		
		/// <summary>
		/// 方号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 每次量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 药房单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
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
		/// 数量
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
		/// 是否已执行
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
		/// 操作员ID,BsUser.Id
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
		/// 打印时间
		/// </summary>
		public string PrepareTime
		{
			get { return _prepareTime;}
			set { _prepareTime = value;}
		}                                    
		                                  
		        
	}  
}           


