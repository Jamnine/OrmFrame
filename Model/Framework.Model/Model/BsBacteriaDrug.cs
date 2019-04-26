

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病菌对应抗菌药表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBacteriaDrug : BaseModel
    {   
		 
		private string _bactriaId;  //对应BsBacteria.Id
		
		private string _drugId;  //药品Id,BsItem.Id
		
		private int _hoSpitalId;  //

        public BsBacteriaDrug() { }
 
		/// <summary>
		/// 对应BsBacteria.Id
		/// </summary>
		public string BactriaId
		{
			get { return _bactriaId;}
			set { _bactriaId = value;}
		}                                    
		
		/// <summary>
		/// 药品Id,BsItem.Id
		/// </summary>
		public string DrugId
		{
			get { return _drugId;}
			set { _drugId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HoSpitalId
		{
			get { return _hoSpitalId;}
			set { _hoSpitalId = value;}
		}                                    
		        
	}  
}           


