

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房人员 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserRoom : BaseModel
    {   
		
		
		
		private string _operId;  //用户名
		
		private string _roomId;  //所属药房
		
		private int _iconIndex;  //图标类型

        public BsUserRoom() { }
         
		/// <summary>
		/// 用户名
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 所属药房
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		        
	}  
}           


