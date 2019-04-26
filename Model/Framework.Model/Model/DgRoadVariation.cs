

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class DgRoadVariation : BaseModel
    {    
		private string _roadId;  //
		
		private string _name;  //
		
		private string _commonCausesVariation;  //常见变异原因
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public DgRoadVariation() { }
         
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
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 常见变异原因
		/// </summary>
		public string CommonCausesVariation
		{
			get { return _commonCausesVariation;}
			set { _commonCausesVariation = value;}
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


