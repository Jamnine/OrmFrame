

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadPatDtl : BaseModel
    {    
		private string _roadPatId;  //
		
		private string _roadDtlId;  //
		
		private string _dayGroupId;  //
		
		private string _cureId;  //
		
		private string _drugId;  //
		
		private string _checkId;  //
		
		private string _nurseId;  //
		
		private int _lsAdvType;  //
		
		private int _lsCureType;  //
		
		private string _cataLogId;  //
		
		private double _dosAge;  //
		
		private string _unitTakeId;  //
		
		private string _frequencyId;  //
		
		private string _usageId;  //
		
		private int _days;  //
		
		private double _feeTotality;  //
		
		private string _unitId;  //
		
		private bool _isDelete;  //
		
		private bool _isChange;  //
		
		private string _reason;  //
		
		private string _adviceId;  //
		
		private int _lsmarkType;  //
		
		private string _roadTime;  //F1临床路径时间
		
		private string _addAdviceMemo;  //F2添加医嘱原因
		
		private string _upAdviceMemo;  //F3修改医嘱原因
		
		private string _unAdviceMemo;  //F4停止医嘱原因，
		
		private string _memo;  //
		
		private int _groupNum;  //
		
		private string _operId;  //
		
		private string _itemId;  //
		
		private string _lisSource;  //
		
		private string _lisBody;  //
		
		private DateTime _adviceTime;  //医嘱生成时间
		
		private bool _isAddAdvice;  //新增医嘱
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public DgRoadPatDtl() { }
                            
		
		/// <summary>
		/// 
		/// </summary>
		public string RoadPatId
		{
			get { return _roadPatId;}
			set { _roadPatId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string RoadDtlId
		{
			get { return _roadDtlId;}
			set { _roadDtlId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DayGroupId
		{
			get { return _dayGroupId;}
			set { _dayGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CureId
		{
			get { return _cureId;}
			set { _cureId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DrugId
		{
			get { return _drugId;}
			set { _drugId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CheckId
		{
			get { return _checkId;}
			set { _checkId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string NurseId
		{
			get { return _nurseId;}
			set { _nurseId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsAdvType
		{
			get { return _lsAdvType;}
			set { _lsAdvType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsCureType
		{
			get { return _lsCureType;}
			set { _lsCureType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string CataLogId
		{
			get { return _cataLogId;}
			set { _cataLogId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double DosAge
		{
			get { return _dosAge;}
			set { _dosAge = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public double FeeTotality
		{
			get { return _feeTotality;}
			set { _feeTotality = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsDelete
		{
			get { return _isDelete;}
			set { _isDelete = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsChange
		{
			get { return _isChange;}
			set { _isChange = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int LsmarkType
		{
			get { return _lsmarkType;}
			set { _lsmarkType = value;}
		}                                    
		
		/// <summary>
		/// F1临床路径时间
		/// </summary>
		public string RoadTime
		{
			get { return _roadTime;}
			set { _roadTime = value;}
		}                                    
		
		/// <summary>
		/// F2添加医嘱原因
		/// </summary>
		public string AddAdviceMemo
		{
			get { return _addAdviceMemo;}
			set { _addAdviceMemo = value;}
		}                                    
		
		/// <summary>
		/// F3修改医嘱原因
		/// </summary>
		public string UpAdviceMemo
		{
			get { return _upAdviceMemo;}
			set { _upAdviceMemo = value;}
		}                                    
		
		/// <summary>
		/// F4停止医嘱原因，
		/// </summary>
		public string UnAdviceMemo
		{
			get { return _unAdviceMemo;}
			set { _unAdviceMemo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LisSource
		{
			get { return _lisSource;}
			set { _lisSource = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LisBody
		{
			get { return _lisBody;}
			set { _lisBody = value;}
		}                                    
		
		/// <summary>
		/// 医嘱生成时间
		/// </summary>
		public DateTime AdviceTime
		{
			get { return _adviceTime;}
			set { _adviceTime = value;}
		}                                    
		
		/// <summary>
		/// 新增医嘱
		/// </summary>
		public bool IsAddAdvice
		{
			get { return _isAddAdvice;}
			set { _isAddAdvice = value;}
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


