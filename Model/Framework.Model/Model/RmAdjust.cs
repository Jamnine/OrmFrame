

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房调价 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmAdjust : BaseModel
    {   
		
		
		
		private string _billNo;  //单据流水号
		
		private DateTime _adjustDate;  //调价日期
		
		private string _dispUnit;  //发文单位
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmAdjust() { }

        
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 调价日期
		/// </summary>
		public DateTime AdjustDate
		{
			get { return _adjustDate;}
			set { _adjustDate = value;}
		}                                    
		
		/// <summary>
		/// 发文单位
		/// </summary>
		public string DispUnit
		{
			get { return _dispUnit;}
			set { _dispUnit = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalID
		{
			get { return _HospitalID;}
			set { _HospitalID = value;}
		}                                    
		        
	}  
}           


