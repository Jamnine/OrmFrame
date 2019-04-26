

using System;
namespace Orm.Model
{
	/// <summary>
	/// 体检单位 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkCompany : BaseModel
	{   
		 
		private string _code;  //检查分类ID
		
		private string _name;  //检查分类
		
		private string _phone;  //工作单位的电话
		
		private string _fax;  //传真号码
		
		private string _address;  //工作单位地址
		
		private string _postCode;  //工作单位的邮政编码
		
		private string _payWayId;  //默认结算方式
		
		private double _discount;  //折扣
		
		private string _responMan;  //负责人
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型

        private int _HospitalID;  //


        /// <summary>
        /// 检查分类ID
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 检查分类
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 工作单位的电话
		/// </summary>
		public string Phone
		{
			get { return _phone;}
			set { _phone = value;}
		}                                    
		
		/// <summary>
		/// 传真号码
		/// </summary>
		public string Fax
		{
			get { return _fax;}
			set { _fax = value;}
		}                                    
		
		/// <summary>
		/// 工作单位地址
		/// </summary>
		public string Address
		{
			get { return _address;}
			set { _address = value;}
		}                                    
		
		/// <summary>
		/// 工作单位的邮政编码
		/// </summary>
		public string PostCode
		{
			get { return _postCode;}
			set { _postCode = value;}
		}                                    
		
		/// <summary>
		/// 默认结算方式
		/// </summary>
		public string PayWayId
		{
			get { return _payWayId;}
			set { _payWayId = value;}
		}                                    
		
		/// <summary>
		/// 折扣
		/// </summary>
		public double Discount
		{
			get { return _discount;}
			set { _discount = value;}
		}                                    
		
		/// <summary>
		/// 负责人
		/// </summary>
		public string ResponMan
		{
			get { return _responMan;}
			set { _responMan = value;}
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

    }  
}           


