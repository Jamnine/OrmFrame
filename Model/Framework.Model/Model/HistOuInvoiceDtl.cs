

using System;
namespace Orm.Model
{
	/// <summary>
	/// 历史门诊费用明细 - 实体类
	/// </summary>
	[Serializable]
	public partial class HistOuInvoiceDtl : BaseModel
    {   
		
		private DateTime _inSertTime;  //插入时间
		 
		private string _invoId;  //发票ID
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _totality;  //数量
		
		private string _unitId;  //药房单位
		
		private double _price;  //单价
		
		private double _discDiag;  //门诊自付比例
		
		private bool _isModiDisc;  //是否修改自付比例
		
		private double _discSelf;  //医院优惠比例
		
		private double _amount;  //金额
		
		private double _amountFact;  //自付金额，等于(自负金额+自费金额)Pay_Amou
		
		private double _amountSelf;  //自负金额
		
		private double _amountTally;  //可记帐金额
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private int _lsPerform;  //1为收费，2退费
		
		private string _limitGroupId;  //所属住院限额。外键，引用BsLimitGroup.GUID
		
		private double _limitFee;  //住院限额
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _invItemId;  //发票分类BsInvInItem.Id
		
		private string _feeId;  //基础分类
		
		private string _feeHsId;  //核算分类
		
		private string _xDRpId;  //协定处方Id,BsXdRp.Id
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private string _memo;  //备注
		
		private string _recipeItemId;  //处方Id,OuRecipeDtl.id
		
		private string _recipeGroupId;  //
		
		private string _docLocID;  //
		
		private string _usagememo;  //用法备注
		
		private string _usageid;  //用法对应BsUsage.Id
		
		private string _formid;  //剂型对应BsFormDrug.id
		
		private string _frequencyid;  //频率对应BsFrequency.Id
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 插入时间
		/// </summary>
		public DateTime InSertTime
		{
			get { return _inSertTime;}
			set { _inSertTime = value;}
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
		/// 项目ID对应Bsitem.id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 药房单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 单价
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
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
		/// 是否修改自付比例
		/// </summary>
		public bool IsModiDisc
		{
			get { return _isModiDisc;}
			set { _isModiDisc = value;}
		}                                    
		
		/// <summary>
		/// 医院优惠比例
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
		/// 自付金额，等于(自负金额+自费金额)Pay_Amou
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
		/// 1为收费，2退费
		/// </summary>
		public int LsPerform
		{
			get { return _lsPerform;}
			set { _lsPerform = value;}
		}                                    
		
		/// <summary>
		/// 所属住院限额。外键，引用BsLimitGroup.GUID
		/// </summary>
		public string LimitGroupId
		{
			get { return _limitGroupId;}
			set { _limitGroupId = value;}
		}                                    
		
		/// <summary>
		/// 住院限额
		/// </summary>
		public double LimitFee
		{
			get { return _limitFee;}
			set { _limitFee = value;}
		}                                    
		
		/// <summary>
		/// 执行科室BsLocation.id
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
		}                                    
		
		/// <summary>
		/// 医生Id,BsDoctor.Id
		/// </summary>
		public string DoctorId
		{
			get { return _doctorId;}
			set { _doctorId = value;}
		}                                    
		
		/// <summary>
		/// 发票分类BsInvInItem.Id
		/// </summary>
		public string InvItemId
		{
			get { return _invItemId;}
			set { _invItemId = value;}
		}                                    
		
		/// <summary>
		/// 基础分类
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 核算分类
		/// </summary>
		public string FeeHsId
		{
			get { return _feeHsId;}
			set { _feeHsId = value;}
		}                                    
		
		/// <summary>
		/// 协定处方Id,BsXdRp.Id
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
		/// 处方Id,OuRecipeDtl.id
		/// </summary>
		public string RecipeItemId
		{
			get { return _recipeItemId;}
			set { _recipeItemId = value;}
		}                                    
		
		/// <summary>
		/// 
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
		                                 
		        
	}  
}           


