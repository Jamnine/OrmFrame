

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class CkMachineSplit : BaseModel
    {   
		 
		private string _dictInstrumentSplitid;  //仪器数据解析ID，系统内码
		
		private string _dictInstrumentid;  //仪器ID，系统内码
		
		private string _typeCode;  //类型
		
		private string _typeName;  //
		
		private int _beginAt;  //起始位置值
		
		private  string _beginLetter;  //
		
		private int  _endAt;  //结束位置值
		
		private string _endLetter;  //结束字符
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 仪器数据解析ID，系统内码
		/// </summary>
		public string DictInstrumentSplitid
		{
			get { return _dictInstrumentSplitid;}
			set { _dictInstrumentSplitid = value;}
		}                                    
		
		/// <summary>
		/// 仪器ID，系统内码
		/// </summary>
		public string DictInstrumentid
		{
			get { return _dictInstrumentid;}
			set { _dictInstrumentid = value;}
		}                                    
		
		/// <summary>
		/// 类型
		/// </summary>
		public string TypeCode
		{
			get { return _typeCode;}
			set { _typeCode = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			get { return _typeName;}
			set { _typeName = value;}
		}                                    
		
		/// <summary>
		/// 起始位置值
		/// </summary>
		public int BeginAt
		{
			get { return _beginAt;}
			set { _beginAt = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string  BeginLetter
		{
			get { return _beginLetter;}
			set { _beginLetter = value;}
		}                                    
		
		/// <summary>
		/// 结束位置值
		/// </summary>
		public int  EndAt
		{
			get { return _endAt;}
			set { _endAt = value;}
		}                                    
		
		/// <summary>
		/// 结束字符
		/// </summary>
		public string EndLetter
		{
			get { return _endLetter;}
			set { _endLetter = value;}
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


