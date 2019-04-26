

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
    public partial class CKMachineFormular : BaseModel
	{   
		 
		private string _dictFormularid;  //公式ID，系统内码
		
		private string _dictTestid;  //检验项ID，系统内码
		
		private string _formular;  //公式内容
		
		private string _formularDesc;  //公式描述
		
		private int _formularType;  //类型0-计算公式1-规则公式
		
		private int _alertType;  //规则公式的提醒类型0-提醒型1-强制型
		
		private string _remark;  //备注
		
		private DateTime _createDate;  //用户生成日期
		
		private string _testName;  //测试项目名称
		
		private string _formularTypeName;  //公式类型名称
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 公式ID，系统内码
		/// </summary>
		public string DictFormularid
		{
			get { return _dictFormularid;}
			set { _dictFormularid = value;}
		}                                    
		
		/// <summary>
		/// 检验项ID，系统内码
		/// </summary>
		public string DictTestid
		{
			get { return _dictTestid;}
			set { _dictTestid = value;}
		}                                    
		
		/// <summary>
		/// 公式内容
		/// </summary>
		public string Formular
		{
			get { return _formular;}
			set { _formular = value;}
		}                                    
		
		/// <summary>
		/// 公式描述
		/// </summary>
		public string FormularDesc
		{
			get { return _formularDesc;}
			set { _formularDesc = value;}
		}                                    
		
		/// <summary>
		/// 类型0-计算公式1-规则公式
		/// </summary>
		public int FormularType
		{
			get { return _formularType;}
			set { _formularType = value;}
		}                                    
		
		/// <summary>
		/// 规则公式的提醒类型0-提醒型1-强制型
		/// </summary>
		public int AlertType
		{
			get { return _alertType;}
			set { _alertType = value;}
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
		/// 用户生成日期
		/// </summary>
		public DateTime CreateDate
		{
			get { return _createDate;}
			set { _createDate = value;}
		}                                    
		
		/// <summary>
		/// 测试项目名称
		/// </summary>
		public string TestName
		{
			get { return _testName;}
			set { _testName = value;}
		}                                    
		
		/// <summary>
		/// 公式类型名称
		/// </summary>
		public string FormularTypeName
		{
			get { return _formularTypeName;}
			set { _formularTypeName = value;}
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


