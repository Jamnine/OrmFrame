

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房盘点 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmCheck : BaseModel
    {     
		private string _billNo;  //单据流水号
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private DateTime _checkTime;  //盘点时间
		
		private double _checkAmount;  //盘点金额
		
		private DateTime _operTime;  //操作时间
		
		private string _operId;  //操作员ID,BsUser.Id
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private bool _isCheck;  //行心云:????????0-??? 1-???
		
		private int _HospitalID;  //
		 
        public RmCheck() { }
                             
		
		/// <summary>
		/// 单据流水号
		/// </summary>
		public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
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
		/// 盘点金额
		/// </summary>
		public double CheckAmount
		{
			get { return _checkAmount;}
			set { _checkAmount = value;}
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
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:????????0-??? 1-???
		/// </summary>
		public bool IsCheck
		{
			get { return _isCheck;}
			set { _isCheck = value;}
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


