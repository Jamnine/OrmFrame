

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class EqTransfer:BaseModel
	{    
		private string _equipmentId;  //
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作人
		
		private string _code;  //凭据号
		
		private DateTime _changeTime;  //迁移时间
		
		private string _reason;  //迁移原因
		
		private string _fromLocId;  //原科室
		
		private string _toLocId;  //转至科室
		
		private string _toPlace;  //转至单位
		
		private string _recieveMan;  //接收人
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //是否封存

        public EqTransfer() { }
         
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
		/// 迁移时间
		/// </summary>
		public DateTime ChangeTime
		{
			get { return _changeTime;}
			set { _changeTime = value;}
		}                                    
		
		/// <summary>
		/// 迁移原因
		/// </summary>
		public string Reason
		{
			get { return _reason;}
			set { _reason = value;}
		}                                    
		
		/// <summary>
		/// 原科室
		/// </summary>
		public string FromLocId
		{
			get { return _fromLocId;}
			set { _fromLocId = value;}
		}                                    
		
		/// <summary>
		/// 转至科室
		/// </summary>
		public string ToLocId
		{
			get { return _toLocId;}
			set { _toLocId = value;}
		}                                    
		
		/// <summary>
		/// 转至单位
		/// </summary>
		public string ToPlace
		{
			get { return _toPlace;}
			set { _toPlace = value;}
		}                                    
		
		/// <summary>
		/// 接收人
		/// </summary>
		public string RecieveMan
		{
			get { return _recieveMan;}
			set { _recieveMan = value;}
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


