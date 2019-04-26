

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云：方案表 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkPlan : BaseModel
	{    
		private double _code;  //代码
		
		private string _name;  //名称
 
		
		/// <summary>
		/// 代码
		/// </summary>
		public double Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		 
	}  
}           


