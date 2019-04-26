

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检诊断建议 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkSuggestion:BaseModel
	{   
		 
		private string _name;  //诊断建议名称
		
		private string _diseaseCode;  //疾病编码
		
		private string _testTypeId;  //类别ID
		
		private string _suggestion;  //建议
		
		private string _flag;  //是否疾病：1 疾病 2异常 3提示 9其他
		
		private bool _isCommonDisease;  //是否常见疾病
		
		private bool _isImportantDisease;  //是否重大疾病
		
		private bool _isNotify;  //未知定义！！！
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private DateTime _modiTime;  //修改时间
		
		private string _modiOperId;  //修改人ID
		
		private int _orderBy;  //顺序
		
		private bool _isActive;  //是否启用
		
		private string _presentHistory;  //现病史
		
		private string _complaint;  //主诉
		  
		/// <summary>
		/// 诊断建议名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 疾病编码
		/// </summary>
		public string DiseaseCode
		{
			get { return _diseaseCode;}
			set { _diseaseCode = value;}
		}                                    
		
		/// <summary>
		/// 类别ID
		/// </summary>
		public string TestTypeId
		{
			get { return _testTypeId;}
			set { _testTypeId = value;}
		}                                    
		
		/// <summary>
		/// 建议
		/// </summary>
		public string Suggestion
		{
			get { return _suggestion;}
			set { _suggestion = value;}
		}                                    
		
		/// <summary>
		/// 是否疾病：1 疾病 2异常 3提示 9其他
		/// </summary>
		public string Flag
		{
			get { return _flag;}
			set { _flag = value;}
		}                                    
		
		/// <summary>
		/// 是否常见疾病
		/// </summary>
		public bool IsCommonDisease
		{
			get { return _isCommonDisease;}
			set { _isCommonDisease = value;}
		}                                    
		
		/// <summary>
		/// 是否重大疾病
		/// </summary>
		public bool IsImportantDisease
		{
			get { return _isImportantDisease;}
			set { _isImportantDisease = value;}
		}                                    
		
		/// <summary>
		/// 未知定义！！！
		/// </summary>
		public bool IsNotify
		{
			get { return _isNotify;}
			set { _isNotify = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 修改人ID
		/// </summary>
		public string ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否启用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 现病史
		/// </summary>
		public string PresentHistory
		{
			get { return _presentHistory;}
			set { _presentHistory = value;}
		}                                    
		
		/// <summary>
		/// 主诉
		/// </summary>
		public string Complaint
		{
			get { return _complaint;}
			set { _complaint = value;}
		}                                    
		                             
		        
	}  
}           


