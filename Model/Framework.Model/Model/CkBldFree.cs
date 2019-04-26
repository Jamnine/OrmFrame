

using System;
namespace Orm.Model
{
	/// <summary>
	/// 免交互助金献血 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkBldFree :BaseModel
	{   
		
		private string _hospId;  //住院病人对应InHosinfo.Id
		
		private string _locationId;  //科室
		
		private string _transType;  //免交互助金类型
		
		private string _memo;  //备注
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //


		
		/// <summary>
		/// 住院病人对应InHosinfo.Id
		/// </summary>
		public string HospId
		{
			get { return _hospId;}
			set { _hospId = value;}
		}                                    
		
		/// <summary>
		/// 科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 免交互助金类型
		/// </summary>
		public string TransType
		{
			get { return _transType;}
			set { _transType = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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


