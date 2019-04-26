

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:诊断意见表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuDiangNosis : BaseModel
    {   
		 
		private string _medicalrecordid;  //病历ID
		
		private string _tjsuggestionid;  //诊断建议ID
		
		private string _diseasename;  //疾病名称
		
		private string _diseasecode;  //疾病编码
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 病历ID
		/// </summary>
		public string Medicalrecordid
		{
			get { return _medicalrecordid;}
			set { _medicalrecordid = value;}
		}                                    
		
		/// <summary>
		/// 诊断建议ID
		/// </summary>
		public string Tjsuggestionid
		{
			get { return _tjsuggestionid;}
			set { _tjsuggestionid = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string Diseasename
		{
			get { return _diseasename;}
			set { _diseasename = value;}
		}                                    
		
		/// <summary>
		/// 疾病编码
		/// </summary>
		public string Diseasecode
		{
			get { return _diseasecode;}
			set { _diseasecode = value;}
		}                                    
		                                  
		        
	}  
}           


