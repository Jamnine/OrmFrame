

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuInvoiceDtl  :  BaseModel  
	{   

		private string _invoId;  //发票ID
		
		private string _itemId;  //收费项目
		
		private double _totality;  //总用量
		
		private string _unitId;  //门诊单位
		
		private double _price;  //单价
		
		private double _discDiag;  //自付比例
		
		private bool _isModiDisc;  //是否修改自付比例
		
		private double _discSelf;  //自费部分的打折比例
		
		private double _amount;  //金额
		
		private double _amountFact;  //自付金额，等于(自负金额+自费金额)
		
		private double _amountSelf;  //自负金额
		
		private double _amountTally;  //可记帐金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private int _lsPerform;  //执行类别：1-收费；2-退费
		
		private string _limitGroupId;  //所属门诊限额
		
		private double _limitFee;  //门诊限额
		
		private string _execLocId;  //执行科室
		
		private string _doctorId;  //项目生成的医生
		
		private string _invItemId;  //门诊发票项目ID
		
		private string _feeId;  //门诊收费类别，参照Pub_Med_Feety（MZorZY=1）
		
		private string _feeHsId;  //核算收据类别
		
		private string _xDRpId;  //协定处方ID
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private string _memo;  //备注
		
		private string _recipeItemId;  //对应处方明细
		
		private string _recipeGroupId;  //对应处方明细套餐项目
		
		private string _docLocID;  //
		
		private string _usagememo;  //用法备注
		
		private string _usageid;  //用法对应BsUsage.Id
		
		private string _formid;  //剂型对应BsFormDrug.id
		
		private string _frequencyid;  //频率对应BsFrequency.Id
		
		private bool _isAutoCharged;  //自动收
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _vipDeductionCount;  //行心云:会员扣减数量
		
		private bool _isVipDeduction;  //行心云:是否会员消费扣减项目
		
		private string _tjPackageID;  //行心云:体检套餐ID
		
		private int _HospitalID;  //

        private bool _aka185;      //是否限制用药

        private bool _isYbItems;   //是否医保项目

        /// <summary>
        /// 是否限制用药
        /// </summary>
        public bool Aka185
        {
            get { return _aka185; }
            set
            {
                _aka185 = value;
            }
        }

        /// <summary>
        /// 是否限制用药
        /// </summary>
        public bool IsYbItems
        {
            get { return _isYbItems; }
            set
            {
                _isYbItems = value;
            }
        }



        /// <summary>
        /// 发票ID
        /// </summary>
        public string InvoId
		{
			get { return _invoId;}
			set { _invoId = value;}
		}                                    
		
		/// <summary>
		/// 收费项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 总用量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 门诊单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 单价(原价)
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 自付比例
		/// </summary>
		public double DiscDiag
		{
			get { return _discDiag;}
			set { _discDiag = value;}
		}                                    
		
		/// <summary>
		/// 是否修改自付比例
		/// </summary>
		public bool IsModiDisc
		{
			get { return _isModiDisc;}
			set { _isModiDisc = value;}
		}                                    
		
		/// <summary>
		/// 自费部分的打折比例
		/// </summary>
		public double DiscSelf
		{
			get { return _discSelf;}
			set { _discSelf = value;}
		}                                    
		
		/// <summary>
		/// 金额
		/// </summary>
		public double Amount
		{
			get { return _amount;}
			set { _amount = value;}
		}                                    
		
		/// <summary>
		/// 自付金额，等于(自负金额+自费金额)
		/// </summary>
		public double AmountFact
		{
			get { return _amountFact;}
			set { _amountFact = value;}
		}                                    
		
		/// <summary>
		/// 自负金额
		/// </summary>
		public double AmountSelf
		{
			get { return _amountSelf;}
			set { _amountSelf = value;}
		}                                    
		
		/// <summary>
		/// 可记帐金额
		/// </summary>
		public double AmountTally
		{
			get { return _amountTally;}
			set { _amountTally = value;}
		}                                    
		
		/// <summary>
		/// 实际应交金额（乘以DiscSelf后的金额）
		/// </summary>
		public double AmountPay
		{
			get { return _amountPay;}
			set { _amountPay = value;}
		}                                    
		
		/// <summary>
		/// 执行类别：1-收费；2-退费
		/// </summary>
		public int LsPerform
		{
			get { return _lsPerform;}
			set { _lsPerform = value;}
		}                                    
		
		/// <summary>
		/// 所属门诊限额
		/// </summary>
		public string LimitGroupId
		{
			get { return _limitGroupId;}
			set { _limitGroupId = value;}
		}                                    
		
		/// <summary>
		/// 门诊限额
		/// </summary>
		public double LimitFee
		{
			get { return _limitFee;}
			set { _limitFee = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 项目生成的医生
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 门诊发票项目ID
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 门诊收费类别，参照Pub_Med_Feety（MZorZY=1）
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 核算收据类别
		/// </summary>
		public string FeeHsId
		{
			get { return _feeHsId;}
			set { _feeHsId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string XDRpId
		{
			get { return _xDRpId;}
			set { _xDRpId = value;}
		}                                    
		
		/// <summary>
		/// 公费报销报表费用类别
		/// </summary>
		public int LsReportType
		{
			get { return _lsReportType;}
			set { _lsReportType = value;}
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
		/// 对应处方明细
		/// </summary>
		public string RecipeItemId
		{
			get { return _recipeItemId;}
			set { _recipeItemId = value;}
		}                                    
		
		/// <summary>
		/// 对应处方明细套餐项目
		/// </summary>
		public string RecipeGroupId
		{
			get { return _recipeGroupId;}
			set { _recipeGroupId = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string DocLocID
		{
			get { return _docLocID;}
			set { _docLocID = value;}
		}                                    
		
		/// <summary>
		/// 用法备注
		/// </summary>
		public string Usagememo
		{
			get { return _usagememo;}
			set { _usagememo = value;}
		}                                    
		
		/// <summary>
		/// 用法对应BsUsage.Id
		/// </summary>
		public string Usageid
		{
			get { return _usageid;}
			set { _usageid = value;}
		}                                    
		
		/// <summary>
		/// 剂型对应BsFormDrug.id
		/// </summary>
		public string Formid
		{
			get { return _formid;}
			set { _formid = value;}
		}                                    
		
		/// <summary>
		/// 频率对应BsFrequency.Id
		/// </summary>
		public string Frequencyid
		{
			get { return _frequencyid;}
			set { _frequencyid = value;}
		}                                    
		
		/// <summary>
		/// 自动收
		/// </summary>
		public bool IsAutoCharged
		{
			get { return _isAutoCharged;}
			set { _isAutoCharged = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 儿童价格
		/// </summary>
		public double ChildPrice
		{
			get { return _childPrice;}
			set { _childPrice = value;}
		}                                    
		
		/// <summary>
		/// 折扣价格
		/// </summary>
		public double DiscountPrice
		{
			get { return _discountPrice;}
			set { _discountPrice = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
		/// <summary>
		/// 行心云:会员扣减数量
		/// </summary>
		public int VipDeductionCount
		{
			get { return _vipDeductionCount;}
			set { _vipDeductionCount = value;}
		}                                    
		
		/// <summary>
		/// 行心云:是否会员消费扣减项目
		/// </summary>
		public bool IsVipDeduction
		{
			get { return _isVipDeduction;}
			set { _isVipDeduction = value;}
		}                                    
		
		/// <summary>
		/// 行心云:体检套餐ID
		/// </summary>
		public string TjPackageID
		{
			get { return _tjPackageID;}
			set { _tjPackageID = value;}
		}                                    
		
                                  
		        
	}  
}           


