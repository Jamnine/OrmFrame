

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadGroupPat : BaseModel
    {    
		private string _roadId;  //
		
		private string _dayGroupId;  //第几天。对应dgdaygroup.id
		
		private string _dgBsGroupId;  //
		
		private string _dgRoadGroupId;  //
		
		private string _name;  //
		
		private int _lsAdvType;  //医嘱类别：1、长嘱，2、临嘱
		
		private int _lsCureType;  //1、主要诊疗工作2、重点医嘱
		
		private string _cataLogId;  //
		
		private int _days;  //
		
		private bool _isNeed;  //
		
		private bool _isReason;  //
		
		private string _memo;  //
		
		private int _groupNum;  //
		
		private string _hospId;  //
		
		private string _roadDtlName;  //路径明细名称
		
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
		/// 第几天。对应dgdaygroup.id
		/// </summary>
		public string DayGroupId
		{
			get { return _dayGroupId;}
			set { _dayGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DgBsGroupId
		{
			get { return _dgBsGroupId;}
			set { _dgBsGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DgRoadGroupId
		{
			get { return _dgRoadGroupId;}
			set { _dgRoadGroupId = value;}
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
		/// 医嘱类别：1、长嘱，2、临嘱
		/// </summary>
		public int LsAdvType
		{
			get { return _lsAdvType;}
			set { _lsAdvType = value;}
		}                                    
		
		/// <summary>
		/// 1、主要诊疗工作2、重点医嘱
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
		public int Days
		{
			get { return _days;}
			set { _days = value;}
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
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 路径明细名称
		/// </summary>
		public string RoadDtlName
		{
			get { return _roadDtlName;}
			set { _roadDtlName = value;}
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


