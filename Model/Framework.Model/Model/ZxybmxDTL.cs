

using System;
namespace Orm.Model
{
	/// <summary>
	/// 医保系统病人费用明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class ZxybmxDTL : BaseModel
	{   
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public ZxybmxDTL() { }
        
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 医院ID
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


