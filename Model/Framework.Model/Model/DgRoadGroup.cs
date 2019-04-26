

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadGroup : BaseModel
    {    
		private string _roadId;  //
		
		private string _dayGroupId;  //第几天。对应dgdaygroup.id
		
		private string _dgBsGroupId;  //
		
		private string _name;  //
		
		private int _lsAdvType;  //医嘱类别：1、长嘱，2、临嘱
		
		private int _lsCuretype;  //1、主要诊疗工作2、重点医嘱
		
		private string _cataLogId;  //
		
		private int _dayS;  //
		
		private bool _isNeed;  //
		
		private bool _isReason;  //
		
		private string _memo;  //
		
		private int _groupNum;  //
		
		private string _roadGroupOldValue;  //序号
		
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
		public int LsCuretype
		{
			get { return _lsCuretype;}
			set { _lsCuretype = value;}
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
		public int DayS
		{
			get { return _dayS;}
			set { _dayS = value;}
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
		/// 序号
		/// </summary>
		public string RoadGroupOldValue
		{
			get { return _roadGroupOldValue;}
			set { _roadGroupOldValue = value;}
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


