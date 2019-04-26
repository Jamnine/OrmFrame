

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院每天固定收费项目(针对单个病人) - 实体类
	/// </summary>
	[Serializable]
	public partial class InDayAdd : BaseModel
	{   
		 
		private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见
		
		private string _itemId;  //Pub_Med_Item价项目表
		
		private DateTime _beginTime;  //开始时间
		
		private double _totality;  //发生数量
		
		private string _unitId;  //发生单位
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDayAdd() { }
         
		/// <summary>
		/// 住院号（相当于门诊的流水号）,用户不可见
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// Pub_Med_Item价项目表
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime BeginTime
		{
			get { return _beginTime;}
			set { _beginTime = value;}
		}                                    
		
		/// <summary>
		/// 发生数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


