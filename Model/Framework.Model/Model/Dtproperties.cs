

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class Dtproperties : BaseModel
    {    
		private string _objectid;  //
		
		private string _property;  //
		
		private string _value;  //
		
		private string _uvalue;  //
		
		private byte[] _lvalue;  //
		
		private int _version;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public Dtproperties() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string objectid
		{
			get { return _objectid;}
			set { _objectid = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string property
		{
			get { return _property;}
			set { _property = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string value
		{
			get { return _value;}
			set { _value = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string uvalue
		{
			get { return _uvalue;}
			set { _uvalue = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public byte[] lvalue
		{
			get { return _lvalue;}
			set { _lvalue = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int Version
		{
			get { return _version;}
			set { _version = value;}
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


