

using System;
namespace Orm.Model
{
	/// <summary>
	/// 疾病对应ICD码 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsEducationIll : BaseModel
    {   
		
		private string _educationId;  //健康教育ID
		
		private int _listNum;  //
		
		private string _icdId;  //初诊（ICD码）
		
		private string _illDesc;  //诊断（ICD名称）

        private int _HospitalID;  //

		/// <summary>
		/// 健康教育ID
		/// </summary>
		public string EducationId
		{
			get { return _educationId;}
			set { _educationId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 初诊（ICD码）
		/// </summary>
		public string IcdId
		{
			get { return _icdId;}
			set { _icdId = value;}
		}                                    
		
		/// <summary>
		/// 诊断（ICD名称）
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}


    }  
}           


