

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class Rpdgroadgroup:BaseModel
	{   
		
	 
		
		private string _cureTypeName;  //
		
		private string _dayName1;  //
		
		private string _dayName2;  //
		
		private string _menuName2;  //
		
		private string _dayName3;  //
		
		private string _menuName3;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public Rpdgroadgroup() { }

                                
		
		/// <summary>
		/// 
		/// </summary>
		public string CureTypeName
		{
			get { return _cureTypeName;}
			set { _cureTypeName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DayName1
		{
			get { return _dayName1;}
			set { _dayName1 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string dayName2
		{
			get { return _dayName2;}
			set { _dayName2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MenuName2
		{
			get { return _menuName2;}
			set { _menuName2 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DayName3
		{
			get { return _dayName3;}
			set { _dayName3 = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string MenuName3
		{
			get { return _menuName3;}
			set { _menuName3 = value;}
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


