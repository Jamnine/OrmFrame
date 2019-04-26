

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院中药煎药表 - 实体类
	/// </summary>
	[Serializable]
	public partial class InChinRicipExec : BaseModel
	{    
		private string _recipeId;  //处方号
		
		private string _execTime;  //执行时间
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InChinRicipExec() { }
                                    
		
		/// <summary>
		/// 处方号
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
		}                                    
		
		/// <summary>
		/// 执行时间
		/// </summary>
		public string ExecTime
		{
			get { return _execTime;}
			set { _execTime = value;}
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


