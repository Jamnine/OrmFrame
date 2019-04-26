

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房调价明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class RmAdjustDtl : BaseModel
    {   
		 
		private string _billId;  //单据Id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _inBatchId;  //药房库存表Id，RmStores.id
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _drugNum;  //数量
		
		private double _newPrice;  //门诊新价格
		
		private double _oldPrice;  //旧价格
		
		private double _profLoss;  //调价损益
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public RmAdjustDtl() { }

                                   
		
		/// <summary>
		/// 单据Id
		/// </summary>
		public string BillId
		{
			get { return _billId;}
			set { _billId = value;}
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
		/// 药房库存表Id，RmStores.id
		/// </summary>
		public string InBatchId
		{
			get { return _inBatchId;}
			set { _inBatchId = value;}
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
		/// 数量
		/// </summary>
		public double DrugNum
		{
			get { return _drugNum;}
			set { _drugNum = value;}
		}                                    
		
		/// <summary>
		/// 门诊新价格
		/// </summary>
		public double NewPrice
		{
			get { return _newPrice;}
			set { _newPrice = value;}
		}                                    
		
		/// <summary>
		/// 旧价格
		/// </summary>
		public double OldPrice
		{
			get { return _oldPrice;}
			set { _oldPrice = value;}
		}                                    
		
		/// <summary>
		/// 调价损益
		/// </summary>
		public double ProfLoss
		{
			get { return _profLoss;}
			set { _profLoss = value;}
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


