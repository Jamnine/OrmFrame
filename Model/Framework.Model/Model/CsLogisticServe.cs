

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CsLogisticServe : BaseModel
    {   
		 
		private string _code;  //院内服务项目代码
		
		private string _name;  //院内服务项目名称
		
		private string _unit;  //单位
		
		private double _unitPrice;  //参考单价
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 院内服务项目代码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 院内服务项目名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string Unit
		{
			get { return _unit;}
			set { _unit = value;}
		}                                    
		
		/// <summary>
		/// 参考单价
		/// </summary>
		public double UnitPrice
		{
			get { return _unitPrice;}
			set { _unitPrice = value;}
		}                                    
		
                                  
		        
	}  
}           


