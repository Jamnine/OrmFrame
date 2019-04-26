

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户相片 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserImage:BaseModel
	{   
		 
		private string _userId;  //用户Id,对应BsUser.Id
		
		private byte[] _userImage;  //用户相片

        private int _HospitalID;//医院ID

         
		/// <summary>
		/// 用户Id,对应BsUser.Id
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 用户相片
		/// </summary>
		public byte[] UserImage
		{
			get { return _userImage;}
			set { _userImage = value;}
		}

   
    }  
}           


