

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemBPId : BaseModel
	{   
		 
		private string _bPItemId;  //
		
		private string _hISItemId;  //
		
		private DateTime _operTime;  //操作时间
		
		private string _userId;  //用户Id,对应BsUser.Id

        public BsItemBPId() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string BPItemId
		{
			get { return _bPItemId;}
			set { _bPItemId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string HISItemId
		{
			get { return _hISItemId;}
			set { _hISItemId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		        
	}  
}           


