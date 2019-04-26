

using System;
namespace Orm.Model
{
	/// <summary>
	/// 临床路径药品 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsBaseDrug:BaseModel
	{   
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private double _priceIn;  //价格
		
		private string _memo;  //备注
		
		private string _groupMainId;  //主组
		
		private string _groupSubId;  //子组
		
		private string _groupSubId2;  //三级分组
		
		private string _engDesc;  //英文名
		
		private int _lsYbType;  //类别：1-甲类；2-乙类；3-自费
		
		private string _ybMemo;  //医保备注
		
		private string _groupSubId3;  //四级分组
		
		private string _groupSubId4;  //五级分组

        private int _hospitalId;//医院ID
                                         
		
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 价格
		/// </summary>
		public double PriceIn
		{
			get { return _priceIn;}
			set { _priceIn = value;}
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
		/// 主组
		/// </summary>
		public string GroupMainId
		{
			get { return _groupMainId;}
			set { _groupMainId = value;}
		}                                    
		
		/// <summary>
		/// 子组
		/// </summary>
		public string GroupSubId
		{
			get { return _groupSubId;}
			set { _groupSubId = value;}
		}                                    
		
		/// <summary>
		/// 三级分组
		/// </summary>
		public string GroupSubId2
		{
			get { return _groupSubId2;}
			set { _groupSubId2 = value;}
		}                                    
		
		/// <summary>
		/// 英文名
		/// </summary>
		public string EngDesc
		{
			get { return _engDesc;}
			set { _engDesc = value;}
		}                                    
		
		/// <summary>
		/// 类别：1-甲类；2-乙类；3-自费
		/// </summary>
		public int LsYbType
		{
			get { return _lsYbType;}
			set { _lsYbType = value;}
		}                                    
		
		/// <summary>
		/// 医保备注
		/// </summary>
		public string YbMemo
		{
			get { return _ybMemo;}
			set { _ybMemo = value;}
		}                                    
		
		/// <summary>
		/// 四级分组
		/// </summary>
		public string GroupSubId3
		{
			get { return _groupSubId3;}
			set { _groupSubId3 = value;}
		}                                    
		
		/// <summary>
		/// 五级分组
		/// </summary>
		public string GroupSubId4
		{
			get { return _groupSubId4;}
			set { _groupSubId4 = value;}
		}


    }  
}           


