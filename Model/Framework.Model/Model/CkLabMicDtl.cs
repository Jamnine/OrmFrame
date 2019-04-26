

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验细菌明细表 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLabMicDtl : BaseModel
	{   
		 
		private string _micId;  //细菌记录
		
		private string _drugId;  //抗生素
		
		private string _result;  //药敏结果
		
		private string _lsMic;  //Mic值：1-敏感；2-中介；3-耐药
		
		private string _memo;  //备注
		
		private string _labIdStr;  //微生物项目和时间点
		
		private string _labIdStrDtl;  //微生物项目和时间点明细
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 细菌记录
		/// </summary>
		public string MicId
		{
			get { return _micId;}
			set { _micId = value;}
		}                                    
		
		/// <summary>
		/// 抗生素
		/// </summary>
		public string DrugId
		{
			get { return _drugId;}
			set { _drugId = value;}
		}                                    
		
		/// <summary>
		/// 药敏结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
		}                                    
		
		/// <summary>
		/// Mic值：1-敏感；2-中介；3-耐药
		/// </summary>
		public string LsMic
		{
			get { return _lsMic;}
			set { _lsMic = value;}
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
		/// 微生物项目和时间点
		/// </summary>
		public string LabIdStr
		{
			get { return _labIdStr;}
			set { _labIdStr = value;}
		}                                    
		
		/// <summary>
		/// 微生物项目和时间点明细
		/// </summary>
		public string LabIdStrDtl
		{
			get { return _labIdStrDtl;}
			set { _labIdStrDtl = value;}
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


