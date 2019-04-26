

using System;
namespace Orm.Model
{
	/// <summary>
	/// 标本异常信息汇总 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineSampleInfo : BaseModel
	{   
		 
		private string _instrumentSeqInfoID;  //标本异常信息汇总ID，系统内码
		
		private string _instrumentSeqID;  //仪器流水号ID，系统内码
		
		private int _exceptionItemCount;  //异常项目数量
		
		private int _alarmItemCount;  //超危险值项目数量
		
		private int _emptyResultItemCount;  //没有结果项目数量
		
		private string _specimenTypeName;  //样本类型描述(微生物多样本类型)
		
		private DateTime _createDate;  //用户生成日期
		
		private int _itemCount;  //检验项目数量
		
		private int _calculateCount;  //计算项目的数量
		
		private string _warringMsg;  //警告信息
		
		private string _alertMsg;  //需要中断的信息记录
		
		private DateTime _lastUpdate;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 标本异常信息汇总ID，系统内码
		/// </summary>
		public string InstrumentSeqInfoID
		{
			get { return _instrumentSeqInfoID;}
			set { _instrumentSeqInfoID = value;}
		}                                    
		
		/// <summary>
		/// 仪器流水号ID，系统内码
		/// </summary>
		public string InstrumentSeqID
		{
			get { return _instrumentSeqID;}
			set { _instrumentSeqID = value;}
		}                                    
		
		/// <summary>
		/// 异常项目数量
		/// </summary>
		public int ExceptionItemCount
		{
			get { return _exceptionItemCount;}
			set { _exceptionItemCount = value;}
		}                                    
		
		/// <summary>
		/// 超危险值项目数量
		/// </summary>
		public int AlarmItemCount
		{
			get { return _alarmItemCount;}
			set { _alarmItemCount = value;}
		}                                    
		
		/// <summary>
		/// 没有结果项目数量
		/// </summary>
		public int EmptyResultItemCount
		{
			get { return _emptyResultItemCount;}
			set { _emptyResultItemCount = value;}
		}                                    
		
		/// <summary>
		/// 样本类型描述(微生物多样本类型)
		/// </summary>
		public string SpecimenTypeName
		{
			get { return _specimenTypeName;}
			set { _specimenTypeName = value;}
		}                                    
		
		/// <summary>
		/// 用户生成日期
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// 检验项目数量
		/// </summary>
		public int ItemCount
		{
			get { return _itemCount;}
			set { _itemCount = value;}
		}                                    
		
		/// <summary>
		/// 计算项目的数量
		/// </summary>
		public int CalculateCount
		{
			get { return _calculateCount;}
			set { _calculateCount = value;}
		}                                    
		
		/// <summary>
		/// 警告信息
		/// </summary>
		public string warringMsg
		{
			get { return _warringMsg;}
			set { _warringMsg = value;}
		}                                    
		
		/// <summary>
		/// 需要中断的信息记录
		/// </summary>
		public string AlertMsg
		{
			get { return _alertMsg;}
			set { _alertMsg = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastUpdate
		{
			get { return _lastUpdate;}
			set { _lastUpdate = value;}
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


