

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadDtl : BaseModel
    {    
		private string _roadId;  //
		
		private string _dayGroupId;  //
		
		private string _cureId;  //
		
		private string _drugId;  //
		
		private string _checkId;  //
		
		private string _nurseId;  //
		
		private string _name;  //
		
		private string _spec;  //
		
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
		
		private bool _isNeed;  //
		
		private bool _isReason;  //
		
		private string _memo;  //
		
		private int _groupNum;  //
		
		private string _itemId;  //
		
		private int _orderBy;  //
		
		private int _pageNum;  //
		
		private string _lisSource;  //
		
		private string _lisBody;  //
		
		private string _roadGroupId;  //处方对应表单ID
		
		private int _countDays;  //长期医嘱对应天数
		
		private int _mutexNum;  //互斥医嘱
		
		private bool _isAuthed;  //已经封存，不可改删
		  
		/// <summary>
		/// 
		/// </summary>
		public string RoadId
		{
			get { return _roadId;}
			set { _roadId = value;}
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
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
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
		public bool IsNeed
		{
			get { return _isNeed;}
			set { _isNeed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsReason
		{
			get { return _isReason;}
			set { _isReason = value;}
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
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int PageNum
		{
			get { return _pageNum;}
			set { _pageNum = value;}
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
		/// 处方对应表单ID
		/// </summary>
		public string RoadGroupId
		{
			get { return _roadGroupId;}
			set { _roadGroupId = value;}
		}                                    
		
		/// <summary>
		/// 长期医嘱对应天数
		/// </summary>
		public int CountDays
		{
			get { return _countDays;}
			set { _countDays = value;}
		}                                    
		
		/// <summary>
		/// 互斥医嘱
		/// </summary>
		public int MutexNum
		{
			get { return _mutexNum;}
			set { _mutexNum = value;}
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


