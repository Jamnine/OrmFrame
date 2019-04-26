

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsSubject:BaseModel
	{   
		 
		private string _name;  //科目

        private int _HospitalID;//医院ID

         
		/// <summary>
		/// 科目
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}
     
    }  
}           


