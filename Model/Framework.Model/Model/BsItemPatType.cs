

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应病人类别 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemPatType : BaseModel
	{   
		 
		private string _patTypeId;  //病人类别
		
		private string _itemId;  //项目
		
		private double _discDiag;  //门诊自付比例
		
		private double _discIn;  //住院自付比例
		
		private string _invMzItemId;  //门诊发票项目ID
		
		private string _invInItemId;  //住院发票项目ID
		
		private string _limitGroupId;  //住院限额组
		
		private int _iconIndex;  //图标类型
		
		private string _upCode;  //行心云:上报码
		
		private string _ybCode;  //行心云:医保码
		
		private string _modioperId;  //行心云:最后修改人
		
		private int _orderBy;  //行心云:F1排序

        public BsItemPatType() { }
         
		/// <summary>
		/// 病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 项目
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
		/// 住院限额组
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
		
		/// <summary>
		/// 行心云:上报码
		/// </summary>
		public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		        
	}  
}           


