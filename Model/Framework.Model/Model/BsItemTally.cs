

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应病人大类 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemTally : BaseModel
	{   
		 
		private string _tallytypeId;  //病人大类ID,BsTallyType.Id
		
		private string _itemId;  //BsItem.Id
		
		private double _discDiag;  //门诊自付比例
		
		private double _discIn;  //住院自付比例
		
		private string _invMzItemId;  //门诊发票项目ID
		
		private string _invInItemId;  //住院发票项目ID
		
		private string _limitGroupId;  //限额
		
		private int _iconIndex;  //图标类型

        public BsItemTally() { }
         
		/// <summary>
		/// 病人大类ID,BsTallyType.Id
		/// </summary>
		public string TallytypeId
		{
			get { return _tallytypeId;}
			set { _tallytypeId = value;}
		}                                    
		
		/// <summary>
		/// BsItem.Id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 门诊自付比例
		/// </summary>
		public double DiscDiag
		{
			get { return _discDiag;}
			set { _discDiag = value;}
		}                                    
		
		/// <summary>
		/// 住院自付比例
		/// </summary>
		public double DiscIn
		{
			get { return _discIn;}
			set { _discIn = value;}
		}                                    
		
		/// <summary>
		/// 门诊发票项目ID
		/// </summary>
		public string InvMzItemId
		{
			get { return _invMzItemId;}
			set { _invMzItemId = value;}
		}                                    
		
		/// <summary>
		/// 住院发票项目ID
		/// </summary>
		public string InvInItemId
		{
			get { return _invInItemId;}
			set { _invInItemId = value;}
		}                                    
		
		/// <summary>
		/// 限额
		/// </summary>
		public string LimitGroupId
		{
			get { return _limitGroupId;}
			set { _limitGroupId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		        
	}  
}           


