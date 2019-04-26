

using System;
namespace Orm.Model
{
	/// <summary>
	/// 银行终端 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBank:BaseModel
	{   
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _isActive;  //是否禁用

        private int _hospitalId;//医联体ID

		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 是否禁用
		/// </summary>
		public int IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}

    }  
}           


