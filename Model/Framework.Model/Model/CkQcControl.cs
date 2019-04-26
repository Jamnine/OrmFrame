

using System;
namespace Orm.Model
{
	/// <summary>
	/// 质控标准 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkQcControl:BaseModel
	{    
		private string _code;  //编码
		
		private string _name;  //标准名称
		
		private string _machineID;  //仪器
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 标准名称
		/// </summary>
		public string Name
        {
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 仪器
		/// </summary>
		public string MachineID
		{
			get { return _machineID;}
			set { _machineID = value;}
		}                                    
		                                  
		        
	}  
}           


