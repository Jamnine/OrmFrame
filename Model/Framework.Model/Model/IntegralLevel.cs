

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:积分等级表 - 实体类
	/// </summary>
	[Serializable]
	public partial class IntegralLevel:BaseModel
	{    
		private string _name;  //等级名称
		
		private double _proporTion;  //积分比例
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 等级名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 积分比例
		/// </summary>
		public double ProporTion
		{
			get { return _proporTion;}
			set { _proporTion = value;}
		}                                    
		                                  
		        
	}  
}           


