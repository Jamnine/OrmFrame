

using System;
namespace Orm.Model
{
	/// <summary>
	/// QC结果 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkQcResult : BaseModel
    {    
		private DateTime _resultDate;  //结果Date
		
		private string _result;  //结果
		
		private string _resultComment;  //结果Comment
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _resultStatus;  //结果Status
		
		private string _lotId;  //
		
		private string _testId;  //检验项目ID,对应CkItem.Id
		
		private string _ctrlId;  //
		
		private bool _isShowQc;  //QC图显示
		
		private string _rejectMemo;  //备注
		
		private int _lsQcState;  //偏差类型：0-在控1-失控（偏高）2-失控（偏低）3-没有维护QC检测
		
		private double _dev3;  //标准偏差+3
		
		private double _devM3;  //标准偏差-3
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 结果Date
		/// </summary>
		public DateTime ResultDate
		{
			get { return _resultDate;}
			set { _resultDate = value;}
		}                                    
		
		/// <summary>
		/// 结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
		}                                    
		
		/// <summary>
		/// 结果Comment
		/// </summary>
		public string ResultComment
		{
			get { return _resultComment;}
			set { _resultComment = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 结果Status
		/// </summary>
		public string ResultStatus
		{
			get { return _resultStatus;}
			set { _resultStatus = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string LotId
		{
			get { return _lotId;}
			set { _lotId = value;}
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
		/// 
		/// </summary>
		public string CtrlId
		{
			get { return _ctrlId;}
			set { _ctrlId = value;}
		}                                    
		
		/// <summary>
		/// QC图显示
		/// </summary>
		public bool IsShowQc
		{
			get { return _isShowQc;}
			set { _isShowQc = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string RejectMemo
		{
			get { return _rejectMemo;}
			set { _rejectMemo = value;}
		}                                    
		
		/// <summary>
		/// 偏差类型：0-在控1-失控（偏高）2-失控（偏低）3-没有维护QC检测
		/// </summary>
		public int LsQcState
		{
			get { return _lsQcState;}
			set { _lsQcState = value;}
		}                                    
		
		/// <summary>
		/// 标准偏差+3
		/// </summary>
		public double Dev3
		{
			get { return _dev3;}
			set { _dev3 = value;}
		}                                    
		
		/// <summary>
		/// 标准偏差-3
		/// </summary>
		public double DevM3
		{
			get { return _devM3;}
			set { _devM3 = value;}
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


