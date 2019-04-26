

using System;
namespace Orm.Model
{
	/// <summary>
	/// 仓库药库出库单(对应药房领药) - 实体类
	/// </summary>
	[Serializable]
	public partial class HuOut:BaseModel
	{    
		private string _billNo;  //单据ID
		
		private string _houseId;  //批号Id,HuStores.id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _applyId;  //药房领药申请单ID
		
		private string _operId;  //制表人ID
		
		private DateTime _operTime;  //操作时间
		
		private string _outMemo;  //出库备注
		
		private bool _yFSign;  //药房确认标志
		
		private string _yFOperId;  //药房审核人
		
		private DateTime _yFOperTime;  //药房审核时间
		
		private bool _isSign;  //是否已审核：0:未审核,1:已审核
		
		private DateTime _signTime;  //审核日期
		
		private string _signOperId;  //审核人
		
		private string _apperId;  //
		
		private string _outWayId;  //
		
		private bool _isAuthed;  //已经封存，不可改删

        private string  _depotId;

        /// <summary>
        /// 单据ID
        /// </summary>
        public string BillNo
		{
			get { return _billNo;}
			set { _billNo = value;}
		}                                    
		
		/// <summary>
		/// 批号Id,HuStores.id
		/// </summary>
		public string HouseId
		{
			get { return _houseId;}
			set { _houseId = value;}
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
		/// 药房领药申请单ID
		/// </summary>
		public string ApplyId
		{
			get { return _applyId;}
			set { _applyId = value;}
		}                                    
		
		/// <summary>
		/// 制表人ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
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
		/// 出库备注
		/// </summary>
		public string OutMemo
		{
			get { return _outMemo;}
			set { _outMemo = value;}
		}                                    
		
		/// <summary>
		/// 药房确认标志
		/// </summary>
		public bool YFSign
		{
			get { return _yFSign;}
			set { _yFSign = value;}
		}                                    
		
		/// <summary>
		/// 药房审核人
		/// </summary>
		public string YFOperId
		{
			get { return _yFOperId;}
			set { _yFOperId = value;}
		}                                    
		
		/// <summary>
		/// 药房审核时间
		/// </summary>
		public DateTime YFOperTime
		{
			get { return _yFOperTime;}
			set { _yFOperTime = value;}
		}                                    
		
		/// <summary>
		/// 是否已审核：0:未审核,1:已审核
		/// </summary>
		public bool IsSign
		{
			get { return _isSign;}
			set { _isSign = value;}
		}                                    
		
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime SignTime
		{
			get { return _signTime;}
			set { _signTime = value;}
		}                                    
		
		/// <summary>
		/// 审核人
		/// </summary>
		public string SignOperId
		{
			get { return _signOperId;}
			set { _signOperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string ApperId
		{
			get { return _apperId;}
			set { _apperId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string OutWayId
		{
			get { return _outWayId;}
			set { _outWayId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}

        private string _billNo2;
        /// <summary>
        /// 行心云:单据No
        /// </summary>
        public string BillNo2
        {
            get { return _billNo2; }
            set { _billNo2 = value; }
        }
        
        /// <summary>
        /// 调拨入库记录???
        /// </summary>
        public string  DepotId
        {
            get { return _depotId; }
            set { _depotId = value; }
        }

    }  
}           


