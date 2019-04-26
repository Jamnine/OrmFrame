

using System;
namespace Orm.Model
{
	/// <summary>
	/// 实时报表DI信息 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblMrk : BaseModel
    {    
		private string _mrkFile;  //Mrk标识
		
		private string _mrkContent;  //Mrk内容
		
		private bool _isActive;  //有效标志
		
		private int _HospitalID;  //
		 
                                 
		
		/// <summary>
		/// Mrk标识
		/// </summary>
		public string MrkFile
		{
			get { return _mrkFile;}
			set { _mrkFile = value;}
		}                                    
		
		/// <summary>
		/// Mrk内容
		/// </summary>
		public string MrkContent
		{
			get { return _mrkContent;}
			set { _mrkContent = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		                                  
		        
	}  
}           


