

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:用户相片 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserPhoto : BaseModel
    {   
		 
		private string _userId;  //用户ID
		
		private string _introDuce;  //介绍
		
		private byte[] _pictureSource;  //图片二进制
		
		private string _specialty;  //擅长
		
		private int _HospitalID;  //

        public BsUserPhoto(){}
         
		/// <summary>
		/// 用户ID
		/// </summary>
		public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 介绍
		/// </summary>
		public string IntroDuce
		{
			get { return _introDuce;}
			set { _introDuce = value;}
		}                                    
		
		/// <summary>
		/// 图片二进制
		/// </summary>
		public byte[] PictureSource
		{
			get { return _pictureSource;}
			set { _pictureSource = value;}
		}                                    
		
		/// <summary>
		/// 擅长
		/// </summary>
		public string Specialty
		{
			get { return _specialty;}
			set { _specialty = value;}
		}                                    
		
	                                
		        
	}  
}           


