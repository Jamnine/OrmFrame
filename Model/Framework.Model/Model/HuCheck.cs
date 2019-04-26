

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库盘点 - 实体类
	/// </summary>
	[Serializable]
	public partial class HuCheck : BaseModel
    {   
		 
		private string _billNo;  //盘点单号
		
		private string _houseId;  //药库ID
		
		private DateTime _checkTime;  //盘点时间
		
		private double _checkAmount;  //本次盘点结果
		
		private DateTime _operTime;  //新开盘点单的日期
		
		private string _operId;  //新开盘点单的操作员
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isCheck;  //行心云:是否已结转记账
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 盘点单号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药库ID
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
		}                                    
		
		/// <summary>
		/// 盘点时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 本次盘点结果
		/// </summary>
		public double CheckAmount
		{
			get { return _checkAmount;}
			set { _checkAmount = value;}
		}                                    
		
		/// <summary>
		/// 新开盘点单的日期
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 新开盘点单的操作员
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 行心云:是否已结转记账
		/// </summary>
		public bool IsCheck
		{
			get { return _isCheck;}
			set { _isCheck = value;}
		}                                    
		                                  
		        
	}  
}           


