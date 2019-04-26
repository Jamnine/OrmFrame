

using System;
namespace Orm.Model
{
	/// <summary>
	/// pacs近线影像文件 - 实体类
	/// </summary>
	[Serializable]
	public partial class PsNearAreaFile : BaseModel
	{   
		
		private string _fileName;  //文件名
		
		private string _location;  //保存地址
		
		private string _studyInstanceUID;  //检查UID
		
		private string _seriesUID;  //系列UID
		
		private string _seriesDesc;  //系列描述
		
		private int _instanceNumber;  //图象序号
		
		private bool _isImage;  //是否是图像
		
		private string _labels;  //图像上的标注
		
		private string _applyNo;  //申请单号
		
		private int _HospitalID;  //

		/// <summary>
		/// 文件名
		/// </summary>
		public string FileName
		{
			get { return _fileName;}
			set { _fileName = value;}
		}                                    
		
		/// <summary>
		/// 保存地址
		/// </summary>
		public string Location
		{
			get { return _location;}
			set { _location = value;}
		}                                    
		
		/// <summary>
		/// 检查UID
		/// </summary>
		public string StudyInstanceUID
		{
			get { return _studyInstanceUID;}
			set { _studyInstanceUID = value;}
		}                                    
		
		/// <summary>
		/// 系列UID
		/// </summary>
		public string SeriesUID
		{
			get { return _seriesUID;}
			set { _seriesUID = value;}
		}                                    
		
		/// <summary>
		/// 系列描述
		/// </summary>
		public string SeriesDesc
		{
			get { return _seriesDesc;}
			set { _seriesDesc = value;}
		}                                    
		
		/// <summary>
		/// 图象序号
		/// </summary>
		public int InstanceNumber
		{
			get { return _instanceNumber;}
			set { _instanceNumber = value;}
		}                                    
		
		/// <summary>
		/// 是否是图像
		/// </summary>
		public bool IsImage
		{
			get { return _isImage;}
			set { _isImage = value;}
		}                                    
		
		/// <summary>
		/// 图像上的标注
		/// </summary>
		public string Labels
		{
			get { return _labels;}
			set { _labels = value;}
		}                                    
		
		/// <summary>
		/// 申请单号
		/// </summary>
		public string ApplyNo
		{
			get { return _applyNo;}
			set { _applyNo = value;}
		}                                    
		                               
		        
	}  
}           


