

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院护士打印单记录 - 实体类
	/// </summary>
	[Serializable]
	public partial class InExecutePrint : BaseModel
	{   
		 
		private string _executeId;  //执行ID
		
		private string _adviceId;  //医嘱ID
		
		private int _lsMarkType;  //医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		
		private string _rptName;  //报表名称
		
		private string _memo;  //备注
		
		private DateTime _printDate;  //打印时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InExecutePrint() { }
         
		/// <summary>
		/// 执行ID
		/// </summary>
		public string ExecuteId
		{
			get { return _executeId;}
			set { _executeId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱ID
		/// </summary>
		public string AdviceId
		{
			get { return _adviceId;}
			set { _adviceId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别:1长嘱2临嘱3其它11中药12护嘱13辅助记账
		/// </summary>
		public int LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 报表名称
		/// </summary>
		public string RptName
		{
			get { return _rptName;}
			set { _rptName = value;}
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
		/// 打印时间
		/// </summary>
		public DateTime PrintDate
		{
			get { return _printDate;}
			set { _printDate = value;}
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


