

using System;
namespace Orm.Model
{
	/// <summary>
	/// 支付方式表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsPayWay:BaseModel
	{    
		private string _code;  //支付方式ID
		
		private string _name;  //支付方式
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _groupType;  //类别分组
		
		private bool _isShowAmount;  //显示格式：0-,1-现金:28.00
		
		private bool _isBackByCash;  //判断原来的按金单收款方式是否可以用现金退回
		
		private bool _isnotModified;  //行心云:是否允许修改
		
		private string _modioPerId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private string _memo;  //行心云:F4备注，例如合同欠费
		
		private bool _isShowinInvoice;  //行心云:F1是否在发票显示
		
		private bool _isBackCash;  //行心云:F1是否要求现金退款
		
		private int _HospitalID;  //
		 
         
		/// <summary>
		/// 支付方式ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}

        /// <summary>
        /// 支付方式
        /// </summary>
        [Collumn(HeaderName = "支付方式", RelatedTableType = null)]
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
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
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
		/// 类别分组
		/// </summary>
		public string GroupType
		{
			get { return _groupType;}
			set { _groupType = value;}
		}                                    
		
		/// <summary>
		/// 显示格式：0-,1-现金:28.00
		/// </summary>
		public bool IsShowAmount
		{
			get { return _isShowAmount;}
			set { _isShowAmount = value;}
		}                                    
		
		/// <summary>
		/// 判断原来的按金单收款方式是否可以用现金退回
		/// </summary>
		public bool IsBackByCash
		{
			get { return _isBackByCash;}
			set { _isBackByCash = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否允许修改
		/// </summary>
		public bool IsnotModified
		{
			get { return _isnotModified;}
			set { _isnotModified = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioPerId
		{
			get { return _modioPerId;}
			set { _modioPerId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F4备注，例如合同欠费
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}

        /// <summary>
        /// 行心云:F1是否在发票显示
        /// </summary>
        [Collumn(HeaderName = "是否在发票显示", RelatedTableType = null)]
        public bool IsShowinInvoice
		{
			get { return _isShowinInvoice;}
			set { _isShowinInvoice = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1是否要求现金退款
		/// </summary>
		public bool IsBackCash
		{
			get { return _isBackCash;}
			set { _isBackCash = value;}
		}                                    
		
	                               
		        
	}  
}           


