

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病案首页的费用类别 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemFirstPageType : BaseModel
    {    
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _groupName;  //分组
		
		private string _interfaceCode1;  //病案接口编码1
		
		private string _interfaceCode2;  //病案接口编码2

        public BsItemFirstPageType() { }
         
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
		/// 分组
		/// </summary>
		public string GroupName
		{
			get { return _groupName;}
			set { _groupName = value;}
		}                                    
		
		/// <summary>
		/// 病案接口编码1
		/// </summary>
		public string InterfaceCode1
		{
			get { return _interfaceCode1;}
			set { _interfaceCode1 = value;}
		}                                    
		
		/// <summary>
		/// 病案接口编码2
		/// </summary>
		public string InterfaceCode2
		{
			get { return _interfaceCode2;}
			set { _interfaceCode2 = value;}
		}                                    
		        
	}  
}           


