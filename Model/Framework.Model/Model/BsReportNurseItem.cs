

using System;
namespace Orm.Model
{
	/// <summary>
	/// 护理工作量项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsReportNurseItem : BaseModel
	{    
		private string _feeName;  //显示名称
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _spec;  //规格
		
		private float _price;  //单价
		
		private string _unit;  //单位
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private int _isOuInAll;  //门诊住院1:门诊2住院
		
		private string _type;  //报表类别
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 显示名称
		/// </summary>
		public string FeeName
		{
			get { return _feeName;}
			set { _feeName = value;}
		}                                    
		
		/// <summary>
		/// 编码
		/// </summary>
		public string code
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
		/// 规格
		/// </summary>
		public string spec
		{
			get { return _spec;}
			set { _spec = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public float  Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string Unit
		{
			get { return _unit;}
			set { _unit = value;}
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
		/// 门诊住院1:门诊2住院
		/// </summary>
		public int IsOuInAll
		{
			get { return _isOuInAll;}
			set { _isOuInAll = value;}
		}                                    
		
		/// <summary>
		/// 报表类别
		/// </summary>
		public string Type
		{
			get { return _type;}
			set { _type = value;}
		}                                    
		
                                 
		        
	}  
}           


