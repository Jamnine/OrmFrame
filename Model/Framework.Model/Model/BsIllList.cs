

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsIllList : BaseModel
    {   
		
		private int _id;  //自增主键
		
		private int _illId;  //疾病编号
		
		private string _illName;  //疾病名称
		
		private int _groupId;  //患者分组编号
		
		private string _patientGroup;  //患者分组名
		
		private int _unDrugId;  //非药品项目编号
		
		private string _unDrugName;  //非药品项目名
		
		private int _groupOrder;  //分组排序
		
		private int _undrugOrder;  //
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 自增主键
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 疾病编号
		/// </summary>
		public int IllId
		{
			get { return _illId;}
			set { _illId = value;}
		}                                    
		
		/// <summary>
		/// 疾病名称
		/// </summary>
		public string IllName
		{
			get { return _illName;}
			set { _illName = value;}
		}                                    
		
		/// <summary>
		/// 患者分组编号
		/// </summary>
		public int GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 患者分组名
		/// </summary>
		public string PatientGroup
		{
			get { return _patientGroup;}
			set { _patientGroup = value;}
		}                                    
		
		/// <summary>
		/// 非药品项目编号
		/// </summary>
		public int UnDrugId
		{
			get { return _unDrugId;}
			set { _unDrugId = value;}
		}                                    
		
		/// <summary>
		/// 非药品项目名
		/// </summary>
		public string UnDrugName
		{
			get { return _unDrugName;}
			set { _unDrugName = value;}
		}                                    
		
		/// <summary>
		/// 分组排序
		/// </summary>
		public int GroupOrder
		{
			get { return _groupOrder;}
			set { _groupOrder = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int UndrugOrder
		{
			get { return _undrugOrder;}
			set { _undrugOrder = value;}
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


