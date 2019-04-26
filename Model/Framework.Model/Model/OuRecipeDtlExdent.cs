

using System;
using System.Text.RegularExpressions;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
    /// <summary>
    /// 门诊处方明细 - 实体类
    /// </summary> 
    public partial class OuRecipeDtl 
    {
        private string _recipeDtlId;
        private string _itemName; // 项目ID
        private string _itemCode; // 项目编码
        private Double _priceDiag;
        private Double _amount;
        private string _unitDiag;
        private Double _vipPriceDiag;
        private Double _oldPriceDiag;
        private bool _isPatExecute = false;   /// 行心云:是否客人执行
        
        private string _typeTokenCode;
        private bool _isOper; //行心云:是否重新保存(重新获取病人处方数据)
        private string _spec;  //规格
        private string _unitTakeName;  //单位
        private string _frequencyName;
        private string _usageName;
        private int _lsRepType;
        private string _memoOperID;
        private string _tjLocationID;
      
        private bool _canModify = true;
        private bool _isRed = false;

        private string _feeMzIdCode;

      


        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }





        /// <summary>
        /// 处方类型
        /// </summary>
        public string FeeMzIdCode
        {
            get { return _feeMzIdCode; }
            set { _feeMzIdCode = value; }
        }
      
        /// <summary>
        /// 处方明细ID
        /// </summary>
        public string RecipeDtlId
        {
            get { return _recipeDtlId; }
            set { _recipeDtlId = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        /// <summary>
        /// 单价
        /// </summary>
        public Double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        /// <summary>
        /// 金额
        /// </summary>
        public Double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public string UnitDiag
        {
            get { return _unitDiag; }
            set { _unitDiag = value; }
        }

        /// <summary>
        /// 会员价
        /// </summary>
        public double VipPriceDiag
        {
            get { return _vipPriceDiag; }
            set { _vipPriceDiag = value; }
        }

        /// <summary>
        /// 原价
        /// </summary> 
        public double OldPriceDiag
        {
            get { return _oldPriceDiag; }
            set { _oldPriceDiag = value; }
        }

        /// <summary>
        /// 是否病人执行
        /// </summary>
        public bool IsPatExecute
        {
            get { return _isPatExecute; }
            set { _isPatExecute = value; }
        }

        

        /// <summary>
        /// 套餐标记
        /// </summary>
        public string TypeTokenCode
        {
            get
            {
                return _typeTokenCode;
            }

            set
            {
                _typeTokenCode = value;
            }
        }

        /// <summary>
        /// 是否重新保存
        /// </summary>
        public bool IsOper
        {
            get { return this._isOper; }
            set { this._isOper = value; }
        }

        /// <summary>
        /// 备注人ID
        /// </summary>
        public string MemoOperID
        {
            get { return _memoOperID; }
            set { _memoOperID = value; }
        }

        /// <summary>
        /// 项目(处方)类型id,关联BsMzFeeTy
        /// </summary>
        public string FeeMzId { get; set; }

        /// <summary>
        /// 红色显示
        /// </summary>
        public bool IsRed
        {
            get { return this._isRed; }
            set { this._isRed = value; }
        }
        /// <summary>
        ///  冗余字段 处方种类：1-治疗项目；2-理疗项目；3-体检项目；4-中草药处方. 5-西药
        /// </summary>
        public int LsRepType
        {
            get { return this._lsRepType; }
            set { this._lsRepType = value; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string UnitTakeName
        {
            get { return _unitTakeName; }
            set { _unitTakeName = value; }
        }

        /// <summary>
        /// 频率名称
        /// </summary>
        public string FrequencyName
        {
            get { return _frequencyName; }
            set { _frequencyName = value; }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageName
        {
            get { return _usageName; }
            set { _usageName = value; }
        }

        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }


        /// <summary>
        /// 是否清理
        /// </summary>
        public bool IsDisposal { get; set; }
        /// <summary>
        /// 保存BsItem.Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        ///支付金额
        /// </summary>
        public double AmountPay { get; set; }
        /// <summary>
        ///折扣金额
        /// </summary>
        public double AmountDiscount { get; set; }
       
        /// <summary>
        /// 减号套餐名称
        /// </summary>
        public string ComboName { get; set; }
      
        /// <summary>
        /// 体检科室名称
        /// </summary>
        public string TjLocationName { get; set; } 
        /// <summary>
        /// 是否可以修改
        /// </summary>
        public bool CanModify
        {
            get { return _canModify; }
            set { _canModify = value; }
        }
        /// <summary>
        /// 是否已收费
        /// </summary>
        public bool IsCharge { get; set; }

        /// <summary>
        /// 处方号
        /// </summary> 
        public DateTime InputTime { get; set; }
 
        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 执行人姓名
        /// </summary>
        public string ExecOpeName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 药品说明
        /// </summary>
        public string DrugInstruction { get; set; }
        /// <summary>
        /// 药品功效
        /// </summary>
        public string DrugEfficacy { get; set; }
        /// <summary>
        ///挂号id
        /// </summary>
        public string MzRegId { get; set; }
        /// <summary>
        /// 药品禁忌
        /// </summary>
        public string DrugTaboos { get; set; }
        /// <summary>
        /// 收费类别名称
        /// </summary>
        public string FeeMzName { get; set; }
        
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        
        /// <summary>
        ///标本类型id
        /// </summary>
        public string SourceId { get; set; }
        /// <summary>
        /// 标本编号
        /// </summary>
        public string SpecimenCode { get; set; }
        /// <summary>
        ///标本类型id
        /// </summary>
        public string DrugFormId { get; set; }
        /// <summary>
        ///标本类型id
        /// </summary>
        public int TjStatus { get; set; }
        /// <summary>
        ///接收时间
        /// </summary>
        public DateTime ReceiveTime { get; set; }
        /// <summary>
        ///采集时间
        /// </summary>
        public DateTime AcquisitionTime { get; set; }
        /// <summary>
        ///休息时间
        /// </summary>
        public string RestTime { get; set; }
        /// <summary>
        ///体检项目id
        /// </summary>
        public string TjItemCodeID { get; set; }
        /// <summary>
        ///执行时间
        /// </summary>
        public DateTime OverTime { get; set; }
        /// <summary>
        ///剂型名称
        /// </summary>
        public string DrugFormName { get; set; }
        /// <summary>
        ///门诊id
        /// </summary>
        public string ClinicNo { get; set; }

        /// <summary>
        /// 冗余字段 门诊流水号
        /// </summary>
        public string MzRegNo { get; set; }
       

        /// <summary>
        /// 是否接收
        /// </summary>
        public bool IsReceive { get; set; }

        /// <summary>
        /// 是否采集
        /// </summary>
        public bool IsAcquisition { get; set; }

        public int HowMany { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo { get; set; }

        public DateTime BirthDate { get; set; }
        /// <summary>
        /// 煮前水量
        /// </summary>
        public string BeforeWater { get; set; }
        /// <summary>
        /// 煮后水量
        /// </summary>
        public string AfterWater { get; set; }
        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsStart { get; set; }
        /// <summary>
        /// 煎药分钟
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsSkinTest
        {
            get;
            set;
        }

        private bool _isOnlyForSys;
        /// <summary>
        /// 医院内部使用的项目
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }
        private bool _isNotLsRepType = false;
        public bool u_IsNotLsRepType
        {
            get
            {
                if (LsRepType != (int)EnumRecipeType.治疗)
                {
                    _isNotLsRepType = true;
                }
                else
                {
                    _isNotLsRepType = false;
                }
                return _isNotLsRepType;
            }
            set { _isNotLsRepType = value; }
        }
        private bool _isLsRepType = false;
        public bool u_IsLsRepType
        {
            get
            {
                if (LsRepType == (int)EnumRecipeType.治疗)
                {
                    _isLsRepType = true;
                }
                else
                {
                    _isLsRepType = false;
                }
                return _isLsRepType;
            }
            set { _isLsRepType = value; }
        }
        private bool _isWestern = false;
        public bool u_IsWestern
        {
            get
            {
                if (LsRepType == (int)EnumRecipeType.西药)
                {
                    _isWestern = true;
                }
                else
                {
                    _isWestern = false;
                }
                return _isWestern;
            }
            set { _isWestern = value; }
        }
        private bool _isChineseMedicine = false;
        public bool u_IsChineseMedicine
        {
            get
            {
                if (LsRepType == (int)EnumRecipeType.中药)
                {
                    _isChineseMedicine = true;
                }
                else
                {
                    _isChineseMedicine = false;
                }
                return _isChineseMedicine;
            }
            set { _isChineseMedicine = value; }
        }
        private bool _isMedical = false;
        public bool u_IsMedical
        {
            get
            {
                if (LsRepType == (int)EnumRecipeType.体检)
                {
                    _isMedical = true;
                }
                else
                {
                    _isMedical = false;
                }
                return _isMedical;
            }
            set { _isMedical = value; }
        }
    }
}


