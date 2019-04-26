

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 每日数据质量信息 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblTrace : BaseModel
    {   
		
		
		
		private string _sqlString;  //修改语句
		
		private string _whereCondition;  //条件
		
		private string _orderByExpression;  //排序
		
		private bool _isActive;  //是否有效标识
		
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
		/// 修改语句
		/// </summary>
		public string SqlString
		{
			get { return _sqlString;}
			set { _sqlString = value;}
		}                                    
		
		/// <summary>
		/// 条件
		/// </summary>
		public string WhereCondition
		{
			get { return _whereCondition;}
			set { _whereCondition = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public string OrderByExpression
		{
			get { return _orderByExpression;}
			set { _orderByExpression = value;}
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
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


