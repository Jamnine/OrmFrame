

using System;
namespace Orm.Model
{
	/// <summary>
	/// 存取表的主键的当前最大值 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkMachineMaxID : BaseModel
	{   
		private string _tableName;  //表名
		
		private int _iDValue;  //当前ID值
		
		private string _remark;  //备注
		
		private DateTime _lastUpdate;  //
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 表名
		/// </summary>
		public string TableName
		{
			get { return _tableName;}
			set { _tableName = value;}
		}                                    
		
		/// <summary>
		/// 当前ID值
		/// </summary>
		public int IDValue
		{
			get { return _iDValue;}
			set { _iDValue = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get { return _remark;}
			set { _remark = value;}
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


