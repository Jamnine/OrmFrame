

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBPItemToYBItem:BaseModel
	{   
		
		private string _bPItemName;  //BP项目名称
		
		private string _yBItemName;  //医保项目名称

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// BP项目名称
		/// </summary>
		public string BPItemName
		{
			get { return _bPItemName;}
			set { _bPItemName = value;}
		}                                    
		
		/// <summary>
		/// 医保项目名称
		/// </summary>
		public string YBItemName
		{
			get { return _yBItemName;}
			set { _yBItemName = value;}
		}

 
    }  
}           


