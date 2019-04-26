

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class EqCheck:BaseModel
	{    
		private string _equipmentId;  //
		
		private DateTime _operTime;  //操作时间
		
		private string _operID;  //操作人
		
		private string _code;  //凭据号
		
		private DateTime _checkTime;  //计量时间
		
		private string _checkMan;  //计量者
		
		private string _result;  //计量结果
		
		private string _memo;  //备注
		
		private bool _isAuthed;  //是否封存

        public EqCheck() { }
         
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
		/// 计量时间
		/// </summary>
		public DateTime CheckTime
		{
			get { return _checkTime;}
			set { _checkTime = value;}
		}                                    
		
		/// <summary>
		/// 计量者
		/// </summary>
		public string CheckMan
		{
			get { return _checkMan;}
			set { _checkMan = value;}
		}                                    
		
		/// <summary>
		/// 计量结果
		/// </summary>
		public string Result
		{
			get { return _result;}
			set { _result = value;}
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


