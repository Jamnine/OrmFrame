

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class EqRepair:BaseModel
	{    
		private string _equipmentId;  //
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作人
		
		private string _code;  //凭据号
		
		private DateTime _repairTime;  //维修时间
		
		private string _reason;  //故障原因
		
		private string _repairWay;  //维修措施
		
		private string _repairUnit;  //维修单位
		
		private string _repairMan;  //维修人
		
		private double _repairFee;  //维修费用
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //是否封存

        public EqRepair() { }
         
		/// <summary>
		/// 
		/// </summary>
		public string EquipmentId
		{
			get { return _equipmentId;}
			set { _equipmentId = value;}
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
		/// 操作人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		
		/// <summary>
		/// 凭据号
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 维修时间
		/// </summary>
		public DateTime RepairTime
		{
			get { return _repairTime;}
			set { _repairTime = value;}
		}                                    
		
		/// <summary>
		/// 故障原因
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 维修措施
		/// </summary>
		public string RepairWay
		{
			get { return _repairWay;}
			set { _repairWay = value;}
		}                                    
		
		/// <summary>
		/// 维修单位
		/// </summary>
		public string RepairUnit
		{
			get { return _repairUnit;}
			set { _repairUnit = value;}
		}                                    
		
		/// <summary>
		/// 维修人
		/// </summary>
		public string RepairMan
		{
			get { return _repairMan;}
			set { _repairMan = value;}
		}                                    
		
		/// <summary>
		/// 维修费用
		/// </summary>
		public double RepairFee
		{
			get { return _repairFee;}
			set { _repairFee = value;}
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
		/// 是否封存
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		        
	}  
}           


