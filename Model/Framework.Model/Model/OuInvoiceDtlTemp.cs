

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票明细临时表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuInvoiceDtlTemp :  BaseModel  
	{   
		 
		private double _amount;  //金额
		
		private double _amountFact;  //自付金额，等于(自负金额+自费金额)Pay_Amou
		
		private double _amountInsurance;  //金额Insurance
		
		private double _amountPay;  //实际应交金额（乘以DiscSelf后的金额）
		
		private double _amountSelf;  //自负金额
		
		private double _amountTally;  //可记帐金额
		
		private string _code;  //编码
		
		private double _discDiag;  //门诊自付比例
		
		private double _discSelf;  //医院优惠比例
		
		private string _docLevId;  //职称
		
		private string _doctorId;  //医生Id,BsDoctor.Id
		
		private string _doctorName;  //医生名称
		
		private string _execLocId;  //执行科室BsLocation.id
		
		private string _feeHsId;  //核算分类ID
		
		private string _feeHsMzName;  //核算名称
		
		private string _feeId;  //基础分类Id
		
		private string _feeName;  //基础分类名称
		
		private string _invItemId;  //发票分类BsInvInItem.Id
		
		private string _invMzItemName;  //发票分类名称
		
		private string _invoId;  //发票ID
		
		private DateTime _invoTime;  //发票时间
		
		private bool _isBack;  //是否已退
		
		private bool _isDoctorInput;  //是否医生录入
		
		private bool _isIssue;  //是否发药
		
		private bool _isModiDisc;  //是否修改自付比例
		
		private bool _isOtherFee;  //是否附加项目
		
		private bool _isPriority;  //是否紧急
		
		private bool _isToBack;  //医生是否确认退药
		
		private string _itemId;  //项目ID对应Bsitem.id
		
		private double _limitFee;  //住院限额
		
		private string _limitGroupId;  //所属住院限额。外键，引用BsLimitGroup.GUID
		
		private double _limitTotalMz;  //门诊计价最小用量
		
		private int _listNum;  //方号
		
		private string _locationName;  //科室名称
		
		private int _lsAdviceType;  //医嘱类别：1-医嘱；2-附加收费
		
		private int _lsGfType;  //公费类别：1-公费；2-自费；3-按固定自付比例
		
		private int _lsGroupType;  //项目分类：1-药品；2-治疗；3-物资材料
		
		private int _lsPerform;  //1为收费，2退费
		
		private int _lsReportType;  //公费报销报表费用类别
		
		private int _lsRepType;  //项目类别
		
		private int _lsRpType;  //处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		
		private string _memo;  //备注
		
		private string _name;  //名称
		
		private string _prepareTime;  //打印时间
		
		private double _price;  //单价
		
		private string _recipeGroupId;  //对应处方明细套餐项目
		
		private string _recipeGroupIds;  //对应处方明细套餐项目
		
		private string _recipeId;  //处方Id,OuRecipe.id
		
		private string _recipeItemId;  //处方Id,OuRecipeDtl.id
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _spec;  //规格
		
		private double _totality;  //数量
		
		private string _typeGFXEId;  //类别GFXEId
		
		private string _unitDiagName;  //门诊单位
		
		private string _unitId;  //单位
		
		private string _xDRpId;  //协定处方Id,BsXdRp.Id
		
		private string _mzregid;  //门诊病人ID,Ouhosinfo.Id
		
		private DateTime _operTime;  //操作时间
		
		private string _usagememo;  //用法备注
		
		private string _usageid;  //用法对应BsUsage.Id
		
		private string _formid;  //剂型对应BsFormDrug.id
		
		private string _frequencyid;  //频率对应BsFrequency.Id
		
		private double _discountAoumt;  //折扣金额
		
		private double _childPrice;  //儿童价格
		
		private double _discountPrice;  //折扣价格
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		 

		 
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
		/// 金额Insurance
		/// </summary>
		public double AmountInsurance
		{
			get { return _amountInsurance;}
			set { _amountInsurance = value;}
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
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
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
		/// 医院优惠比例
		/// </summary>
		public double DiscSelf
		{
			get { return _discSelf;}
			set { _discSelf = value;}
		}                                    
		
		/// <summary>
		/// 职称
		/// </summary>
		public string DocLevId
		{
			get { return _docLevId;}
			set { _docLevId = value;}
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
		/// 医生名称
		/// </summary>
		public string DoctorName
		{
			get { return _doctorName;}
			set { _doctorName = value;}
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
		/// 核算分类ID
		/// </summary>
		public string FeeHsId
		{
			get { return _feeHsId;}
			set { _feeHsId = value;}
		}                                    
		
		/// <summary>
		/// 核算名称
		/// </summary>
		public string FeeHsMzName
		{
			get { return _feeHsMzName;}
			set { _feeHsMzName = value;}
		}                                    
		
		/// <summary>
		/// 基础分类Id
		/// </summary>
		public string FeeId
		{
			get { return _feeId;}
			set { _feeId = value;}
		}                                    
		
		/// <summary>
		/// 基础分类名称
		/// </summary>
		public string FeeName
		{
			get { return _feeName;}
			set { _feeName = value;}
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
		/// 发票分类名称
		/// </summary>
		public string InvMzItemName
		{
			get { return _invMzItemName;}
			set { _invMzItemName = value;}
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
		/// 发票时间
		/// </summary>
		public DateTime InvoTime
		{
			get { return _invoTime;}
			set { _invoTime = value;}
		}                                    
		
		/// <summary>
		/// 是否已退
		/// </summary>
		public bool IsBack
		{
			get { return _isBack;}
			set { _isBack = value;}
		}                                    
		
		/// <summary>
		/// 是否医生录入
		/// </summary>
		public bool IsDoctorInput
		{
			get { return _isDoctorInput;}
			set { _isDoctorInput = value;}
		}                                    
		
		/// <summary>
		/// 是否发药
		/// </summary>
		public bool IsIssue
		{
			get { return _isIssue;}
			set { _isIssue = value;}
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
		/// 是否附加项目
		/// </summary>
		public bool IsOtherFee
		{
			get { return _isOtherFee;}
			set { _isOtherFee = value;}
		}                                    
		
		/// <summary>
		/// 是否紧急
		/// </summary>
		public bool IsPriority
		{
			get { return _isPriority;}
			set { _isPriority = value;}
		}                                    
		
		/// <summary>
		/// 医生是否确认退药
		/// </summary>
		public bool IsToBack
		{
			get { return _isToBack;}
			set { _isToBack = value;}
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
		/// 住院限额
		/// </summary>
		public double LimitFee
		{
			get { return _limitFee;}
			set { _limitFee = value;}
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
		/// 门诊计价最小用量
		/// </summary>
		public double LimitTotalMz
		{
			get { return _limitTotalMz;}
			set { _limitTotalMz = value;}
		}                                    
		
		/// <summary>
		/// 方号
		/// </summary>
		public int ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 科室名称
		/// </summary>
		public string LocationName
		{
			get { return _locationName;}
			set { _locationName = value;}
		}                                    
		
		/// <summary>
		/// 医嘱类别：1-医嘱；2-附加收费
		/// </summary>
		public int LsAdviceType
		{
			get { return _lsAdviceType;}
			set { _lsAdviceType = value;}
		}                                    
		
		/// <summary>
		/// 公费类别：1-公费；2-自费；3-按固定自付比例
		/// </summary>
		public int LsGfType
		{
			get { return _lsGfType;}
			set { _lsGfType = value;}
		}                                    
		
		/// <summary>
		/// 项目分类：1-药品；2-治疗；3-物资材料
		/// </summary>
		public int LsGroupType
		{
			get { return _lsGroupType;}
			set { _lsGroupType = value;}
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
		/// 公费报销报表费用类别
		/// </summary>
		public int LsReportType
		{
			get { return _lsReportType;}
			set { _lsReportType = value;}
		}                                    
		
		/// <summary>
		/// 项目类别
		/// </summary>
		public int LsRepType
		{
			get { return _lsRepType;}
			set { _lsRepType = value;}
		}                                    
		
		/// <summary>
		/// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-其他；10-物资
		/// </summary>
		public int LsRpType
		{
			get { return _lsRpType;}
			set { _lsRpType = value;}
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
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 打印时间
		/// </summary>
		public string PrepareTime
		{
			get { return _prepareTime;}
			set { _prepareTime = value;}
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
		/// 对应处方明细套餐项目
		/// </summary>
		public string RecipeGroupId
		{
			get { return _recipeGroupId;}
			set { _recipeGroupId = value;}
		}                                    
		
		/// <summary>
		/// 对应处方明细套餐项目
		/// </summary>
		public string RecipeGroupIds
		{
			get { return _recipeGroupIds;}
			set { _recipeGroupIds = value;}
		}                                    
		
		/// <summary>
		/// 处方Id,OuRecipe.id
		/// </summary>
		public string RecipeId
		{
			get { return _recipeId;}
			set { _recipeId = value;}
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
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 规格
		/// </summary>
		public string Spec
		{
			get { return _spec;}
			set { _spec = value;}
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
		/// 类别GFXEId
		/// </summary>
		public string TypeGFXEId
		{
			get { return _typeGFXEId;}
			set { _typeGFXEId = value;}
		}                                    
		
		/// <summary>
		/// 门诊单位
		/// </summary>
		public string UnitDiagName
		{
			get { return _unitDiagName;}
			set { _unitDiagName = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
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
		/// 门诊病人ID,Ouhosinfo.Id
		/// </summary>
		public string Mzregid
		{
			get { return _mzregid;}
			set { _mzregid = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
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
		   
	}  
}           


