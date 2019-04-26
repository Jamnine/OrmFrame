

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class InEmrFirstPageIllness : BaseModel
    {   
		  
		private string _hospid;  //
		
		private string _emrFirstPageId;  //病案首页ID,InEmrFirstPage.Id
		
		private string _illDesc;  //诊断名称
		
		private string _illCode;  //疾病编码
		
		private int _lsIllType;  //诊断类别：1主要诊断,2其它诊断
		
		private int _lsInIllness;  //入院病情：1有2临床未确定3情况不明4无
		
		private int _HospitalID;  //

        public InEmrFirstPageIllness() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string Hospid
		{
			get { return _hospid;}
			set { _hospid = value;}
		}                                    
		
		/// <summary>
		/// 病案首页ID,InEmrFirstPage.Id
		/// </summary>
		public string EmrFirstPageId
		{
			get { return _emrFirstPageId;}
			set { _emrFirstPageId = value;}
		}                                    
		
		/// <summary>
		/// 诊断名称
		/// </summary>
		public string IllDesc
		{
			get { return _illDesc;}
			set { _illDesc = value;}
		}                                    
		
		/// <summary>
		/// 疾病编码
		/// </summary>
		public string IllCode
		{
			get { return _illCode;}
			set { _illCode = value;}
		}                                    
		
		/// <summary>
		/// 诊断类别：1主要诊断,2其它诊断
		/// </summary>
		public int LsIllType
		{
			get { return _lsIllType;}
			set { _lsIllType = value;}
		}                                    
		
		/// <summary>
		/// 入院病情：1有2临床未确定3情况不明4无
		/// </summary>
		public int LsInIllness
		{
			get { return _lsInIllness;}
			set { _lsInIllness = value;}
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


