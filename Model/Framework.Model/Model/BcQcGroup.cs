

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:质控组 - 实体类
	/// </summary>
	[Serializable]
	public partial class BcQcGroup : BaseModel
    {   
		
		private string _qcGroupName;  //质控组名称
		
		private int _hoSpitalId;  //

        public BcQcGroup() { }

       
		/// <summary>
		/// 质控组名称
		/// </summary>
		public string QcGroupName
		{
			get { return _qcGroupName;}
			set { _qcGroupName = value;}
		}                                    
		

 
    }  
}           


