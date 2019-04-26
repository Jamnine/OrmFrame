

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验项目明细 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkLabDtl : BaseModel
	{    
		private string _labId;  //体检指引单号
		
		private string _testId;  //检验项目ID,对应CkItem.Id
		
		private string _sourceId;  //标本类型
		
		private string _tubeTypeId;  //标本类型
		
		private bool _isDownLoad;  //
		
		private bool _isPrint;  //该测试项是否已在条形码中打印过
		
		private DateTime _printTime;  //打印时间
		
		private string _printOperId;  //打印人，BsUser.Id
		
		private bool _isBilled;  //是否已传出帐单
		
		private string _memo;  //报告备注
		
		private string _parentID;  //父Id
		
		private string _recipeDtlId;  //处方明细ID
		
		private string _detailId;  //记帐表的费用ID
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private string _testTypeId;  //体检分类
		
		private string _lsMarkType;  //医嘱类型
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 体检指引单号
		/// </summary>
		public string LabId
		{
			get { return _labId;}
			set { _labId = value;}
		}                                    
		
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 标本类型
		/// </summary>
		public string SourceId
		{
			get { return _sourceId;}
			set { _sourceId = value;}
		}                                    
		
		/// <summary>
		/// 标本类型
		/// </summary>
		public string TubeTypeId
		{
			get { return _tubeTypeId;}
			set { _tubeTypeId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public bool IsDownLoad
		{
			get { return _isDownLoad;}
			set { _isDownLoad = value;}
		}                                    
		
		/// <summary>
		/// 该测试项是否已在条形码中打印过
		/// </summary>
		public bool IsPrint
		{
			get { return _isPrint;}
			set { _isPrint = value;}
		}                                    
		
		/// <summary>
		/// 打印时间
		/// </summary>
		public DateTime PrintTime
		{
			get { return _printTime;}
			set { _printTime = value;}
		}                                    
		
		/// <summary>
		/// 打印人，BsUser.Id
		/// </summary>
		public string PrintOperId
		{
			get { return _printOperId;}
			set { _printOperId = value;}
		}                                    
		
		/// <summary>
		/// 是否已传出帐单
		/// </summary>
		public bool IsBilled
		{
			get { return _isBilled;}
			set { _isBilled = value;}
		}                                    
		
		/// <summary>
		/// 报告备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 父Id
		/// </summary>
		public string ParentID
		{
			get { return _parentID;}
			set { _parentID = value;}
		}                                    
		
		/// <summary>
		/// 处方明细ID
		/// </summary>
		public string RecipeDtlId
		{
			get { return _recipeDtlId;}
			set { _recipeDtlId = value;}
		}                                    
		
		/// <summary>
		/// 记帐表的费用ID
		/// </summary>
		public string DetailId
		{
			get { return _detailId;}
			set { _detailId = value;}
		}                                    
		
		/// <summary>
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 体检分类
		/// </summary>
		public string TestTypeId
		{
			get { return _testTypeId;}
			set { _testTypeId = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类型
		/// </summary>
		public string LsMarkType
		{
			get { return _lsMarkType;}
			set { _lsMarkType = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
                                  
		        
	}  
}           


