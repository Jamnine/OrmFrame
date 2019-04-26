

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 需要设置报表打印的rpt - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblFieldDesc : BaseModel
    {   
		
		
		
		private string _tableName;  //RPT名称
		
		private string _fieldName;  //类别
		
		private string _description;  //描述
		
		private bool _isActive;  //是否有效标识
		
		private int _orderBy;  //显示顺序
		
		private string _groupName;  //分组
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// RPT名称
		/// </summary>
		public string TableName
		{
			get { return _tableName;}
			set { _tableName = value;}
		}                                    
		
		/// <summary>
		/// 类别
		/// </summary>
		public string FieldName
		{
			get { return _fieldName;}
			set { _fieldName = value;}
		}                                    
		
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			get { return _description;}
			set { _description = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 分组
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


