

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class List_Example : BaseModel
    {   
		
		private string _dname;  //
        


        /// <summary>
        /// 
        /// </summary>
        public string Dname
		{
			get { return _dname;}
			set { _dname = value;}
		}                                    
		        
	}  
}           


