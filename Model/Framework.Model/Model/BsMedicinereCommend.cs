

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:中药推荐的关系表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsMedicinereCommend:BaseModel
	{    
		private string _illName;  //疾病名称
		
		private string _patientGroup;  //患者分组
		
		private string _locationId;  //诊所id
		
		private string _indication;  //适应症
		
		private string _references;  //参考文献
		
		private string _bsManuFacturerId;  //生产厂商id
		
		private string _itemName;  //中成药项目名称
		
		private string _spec;  //规格
		
		private string _phone;  //厂商联系电话
		
		private int _HospitalID;  //医院ID
		  
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string IllName
		{
			get { return _illName;}
			set { _illName = value;}
		}                                    
		
		/// <summary>
		/// 患者分组
		/// </summary>
		public string PatientGroup
		{
			get { return _patientGroup;}
			set { _patientGroup = value;}
		}                                    
		
		/// <summary>
		/// 诊所id
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 适应症
		/// </summary>
		public string Indication
		{
			get { return _indication;}
			set { _indication = value;}
		}                                    
		
		/// <summary>
		/// 参考文献
		/// </summary>
		public string References
		{
			get { return _references;}
			set { _references = value;}
		}                                    
		
		/// <summary>
		/// 生产厂商id
		/// </summary>
		public string BsManuFacturerId
		{
			get { return _bsManuFacturerId;}
			set { _bsManuFacturerId = value;}
		}                                    
		
		/// <summary>
		/// 中成药项目名称
		/// </summary>
		public string ItemName
		{
			get { return _itemName;}
			set { _itemName = value;}
		}                                    
		
		/// <summary>
		/// 规格
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
		}                                    
		
		/// <summary>
		/// 厂商联系电话
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
		}                                    
		
	                                    
		        
	}  
}           


