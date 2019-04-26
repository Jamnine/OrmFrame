

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检公式 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkFormula : BaseModel
	{   
		
		
		private string _testId;  //项目代码
		
		private string _formula;  //公式
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删

        private int _HospitalID;  //


        /// <summary>
        /// 项目代码
        /// </summary>
        public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 公式
		/// </summary>
		public string Formula
		{
			get { return _formula;}
			set { _formula = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}

  

    }  
}           


