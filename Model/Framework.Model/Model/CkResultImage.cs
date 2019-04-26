

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检结果影像 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkResultImage:BaseModel
	{    
		private string _patID;  //病人ID
		
		private string _mzRegId;  //门诊挂号ID
		
		private string _tjLocationID;  //体验科室ID
		
		private string _imageTypePath;  //图片路径
		
		private byte[] _image;  //图片
		
		private string _itemId;  //TjItemRecord.ItemID
		
		private string _ouRecipeDtlID;  //TjItemRecord.RecipeDtlId 
		  
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 门诊挂号ID
		/// </summary>
		public string MzRegId
		{
			get { return _mzRegId;}
			set { _mzRegId = value;}
		}                                    
		
		/// <summary>
		/// 体验科室ID
		/// </summary>
		public string TjLocationID
		{
			get { return _tjLocationID;}
			set { _tjLocationID = value;}
		}                                    
		
		/// <summary>
		/// 图片路径
		/// </summary>
		public string ImageTypePath
		{
			get { return _imageTypePath;}
			set { _imageTypePath = value;}
		}                                    
		
		/// <summary>
		/// 图片
		/// </summary>
		public byte[] Image
		{
			get { return _image;}
			set { _image = value;}
		}                                    
		
		/// <summary>
		/// TjItemRecord.ItemID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// TjItemRecord.RecipeDtlId
		/// </summary>
		public string RecipeDtlId
		{
			get { return _ouRecipeDtlID;}
			set { _ouRecipeDtlID = value;}
		}                                    
		 
	}  
}           


