

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadChinRicipeDtl : BaseModel
    {    
		private string _roadId;  //
		
		private string _dayGroupId;  //
		
		private string _itemId;  //项目ID
		
		private double _dosage;  //数量
		
		private string _unitTakeId;  //服用单位。外键，引用BsUnit.GUID
		
		private int _lsDecoctWay;  //煎药方法：1-无；2-先煎；3-后下；4-锔服；5-另熔；6-冲服；7-另服
		
		private string _memo;  //
		
		private string _name;  //项目名称
		
		private string _roadGroupId;  //处方对应表单ID
		
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
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位。外键，引用BsUnit.GUID
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 煎药方法：1-无；2-先煎；3-后下；4-锔服；5-另熔；6-冲服；7-另服
		/// </summary>
		public int LsDecoctWay
		{
			get { return _lsDecoctWay;}
			set { _lsDecoctWay = value;}
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
		/// 项目名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		        
	}  
}           


