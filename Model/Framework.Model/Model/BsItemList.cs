

using System;
using System.Collections.Generic;

namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemList : BaseModel
	{   
		 
		private string _illId;  //疾病编码
		
		private string _illName;  //疾病名称
		
		private string _groupId;  //患者分组编码
		
		private string _patientGroup;  //患者分组名称
		
		private string _unDrugId;  //治疗方式编码
		
		private string _unDrugName;  //治疗方式名称
		
		private int _typeCode;  //类型编号(同一类药的编号相同)
		
		private string _itemId;  //药品编码
		
		private string _itemName;  //药品通用名
		
		private string _unitId;  //单位编码
		
		private string _unitName;  //单位名称
		
		private string _usageId;  //用法编码
		
		private string _usageName;  //用法名称
		
		private string _frequencyId;  //频次编码
		
		private string _frequencyName;  //频次名称
		
		private double _quantity;  //数量
		
		private int _relationCode;  //关联编号(多选一关系时，编号一样)
		
		private string _wayCode;  //第几选择
		
		private string _remark;  //备注
		
		private DateTime _impTime;  //导入时间

        public BsItemList() { }
         
		/// <summary>
		/// 疾病编码
		/// </summary>
		public string IllId
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
		/// 患者分组编码
		/// </summary>
		public string GroupId
		{
			get { return _groupId;}
			set { _groupId = value;}
		}                                    
		
		/// <summary>
		/// 患者分组名称
		/// </summary>
		public string PatientGroup
		{
			get { return _patientGroup;}
			set { _patientGroup = value;}
		}                                    
		
		/// <summary>
		/// 治疗方式编码
		/// </summary>
		public string UnDrugId
		{
			get { return _unDrugId;}
			set { _unDrugId = value;}
		}                                    
		
		/// <summary>
		/// 治疗方式名称
		/// </summary>
		public string UnDrugName
		{
			get { return _unDrugName;}
			set { _unDrugName = value;}
		}                                    
		
		/// <summary>
		/// 类型编号(同一类药的编号相同)
		/// </summary>
		public int TypeCode
		{
			get { return _typeCode;}
			set { _typeCode = value;}
		}                                    
		
		/// <summary>
		/// 药品编码
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 药品通用名
		/// </summary>
		public string ItemName
		{
			get { return _itemName;}
			set { _itemName = value;}
		}                                    
		
		/// <summary>
		/// 单位编码
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 单位名称
		/// </summary>
		public string UnitName
		{
			get { return _unitName;}
			set { _unitName = value;}
		}                                    
		
		/// <summary>
		/// 用法编码
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 用法名称
		/// </summary>
		public string UsageName
		{
			get { return _usageName;}
			set { _usageName = value;}
		}                                    
		
		/// <summary>
		/// 频次编码
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 频次名称
		/// </summary>
		public string FrequencyName
		{
			get { return _frequencyName;}
			set { _frequencyName = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Quantity
		{
			get { return _quantity;}
			set { _quantity = value;}
		}                                    
		
		/// <summary>
		/// 关联编号(多选一关系时，编号一样)
		/// </summary>
		public int RelationCode
		{
			get { return _relationCode;}
			set { _relationCode = value;}
		}                                    
		
		/// <summary>
		/// 第几选择
		/// </summary>
		public string WayCode
		{
			get { return _wayCode;}
			set { _wayCode = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
		}                                    
		
		/// <summary>
		/// 导入时间
		/// </summary>
		public DateTime ImpTime
		{
			get { return _impTime;}
			set { _impTime = value;}
		}

        public List<BsItem> LstItem { get; set; }
        public bool IsSelect { get; set; }
    }  
}           


