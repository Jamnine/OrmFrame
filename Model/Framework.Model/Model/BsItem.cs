

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
    /// <summary>
    /// 收费项目表 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsItem : BaseModel
    {
        private int _lsGroupType;  //项目分类：1-药品；2-治疗；3-物资材料

        private string _code="";  //编码

        private string _wbCode;  //五笔码（固定）

        private string _pyCode;  //拼音码（固定）

        private string _strokeCode;  //化学名五笔码

        private string _otherCode;  //化学名拼音码

        private string _groupMainId = string.Empty;  //主组

        private string _groupSubId;  //子组

        private string _name="";  //简称

        private string _longDesc;  //全称

        private string _engDesc;  //英文名

        private string _spec=string.Empty;  //规格

        private string _unitInId;  //住院单位

        private double _priceIn;  //住院价格

        private string _unitDiagId = string.Empty;  //门诊单位

        private double _priceDiag;  //门诊价格

        private double _addPercent;  //加成率

        private int _lsRpType;  //处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-卫生材料;10-物资

        private double _dosage;  //用量

        private string _unitTakeId = string.Empty;  //服用单位

        private string _frequencyId = string.Empty;  //频率

        private string _usageId = string.Empty;  //用法

        private string _feeMzId= string.Empty;  //门诊收费类别

        private int _feeMzIdCode;  //门诊收费类别，对应 EnumFeeMzId 中的项

        private string _feeZyId;  //住院收费类别

        private int _lsGfType;  //公费类别：1-公费；2-自费；3-按固定自付比例

        private double _gfFixDisc;  //固定的自付比例

        private bool _optionPrice;  //国基

        private double _limitTotalMz;  //单位剂量

        private double _limitTotalZy;  //住院计价最小用量

        private string _typeGFXEId;  //公费限额类别

        private bool _isSpecSum;  //省基

        private bool _isNew;  //

        private bool _isOnlyForSys;  //医院内部使用的项目

        private bool _isRpForbid;  //禁止临床开药

        private bool _isChildAdd;  //是否儿科加收20%

        private bool _isBedFee;  //是否床位费

        private bool _isOpsAdd;  //是否加收布类费用

        private int _lsfeeTurn;  //限制使用地点：1-全部;2-门诊;3-住院(原意义：长期医嘱附加收费的周期：1-每次收费；2-每天收费；3-每周收费)

        private int _lsAdviceType;  //医嘱类别：1-医嘱；2-附加收费

        private string _locationId;  //执行科室

        private string _lISCode;  //检验ID,对应CkItem.Id

        private string _coverPicture;  //封面图片

        private string _memoPicture;  //说明书扫描图

        private string _memo= string.Empty;  //备注

        private bool _isActive =true;  //有效标志

        private int _iconIndex;  //图标类型

        private bool _isInoculate;  //按小时计费

        private double _priceHighLine;  //最高零售价

        private int _orderBy;  //显示顺序

        private string _groupSubId2;  //三级分组

        private DateTime _lastTime;  //输入时间

        private double _priceSub;  //一级医院价格

        private string _checkId;  //对应基本检查

        private string _nurseId;  //对应基本护理

        private string _cureId;  //对应基本治疗

        private string _drugID;  //药典ID

        private string _copyId = string.Empty;  //

        private int _mzUnitTotal;  //门诊计价最小用量

        private int _zyUnitTotal;  //住院计价最小用量

        private bool _isMtDrug;  //是否门特用药

        private string _packageSpec = string.Empty;  //包装规格

        private bool _isCitySum;  //是否市基

        private double _yBAvgPrice;  //医保均价

        private string _provinceCode;  //省统一码

        private string _operName = string.Empty;  //最近修改操作员

        private bool _isFirstRecommend;  //行心云:是否已经从中成药推荐界面开过药

        private string _drugEfficacy = string.Empty;  //行心云:药品功效

        private string _drugInstruction = string.Empty;  //行心云:药品说明

        private string _drugTaboos = string.Empty;  //行心云:药物禁忌

        private string _commonNameId;  //行心云:通用名id

        private string _commonName= string.Empty;  //行心云:通用名

        private int _duration;  //行心云:F3是否自动收

        private double _vipPrice;  //行心云:会员价

        private int _termYear;  //行心云:有效期限-年

        private int _termMonth;  //行心云:有效期限-月

        private bool _isDiscounts=true;  //行心云:是否打折

        private string _tjLocationId;  //行心云: 体检科室

        private bool _isPrintName;  //行心云:是否打印套餐名

        private int _HospitalID;  //

        private string _manuId= string.Empty;

        private int _samlingType; //行心云:采样类型

        private string _businessCity = string.Empty;

        //private string _xdRpId; //套餐主表ID

        private DateTime _insertTime;

        private int _hisType;

        private bool _isYBIrems;  //是否医保项目目录

        private bool _isIndustries;  //是否集团产业

        private string _posStocks;
        public string PosStocks
        {
            get { return this._posStocks; }
            set { this._posStocks = value; }
        }

        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }


        /// <summary>
        /// 项目分类：1-药品；2-治疗；3-物资材料
        /// </summary>
        public int LsGroupType
        {
            get { return _lsGroupType; }
            set { _lsGroupType = value; }
        }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 五笔码（固定）
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 拼音码（固定）
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 化学名五笔码
        /// </summary>
        public string StrokeCode
        {
            get { return _strokeCode; }
            set { _strokeCode = value; }
        }

        /// <summary>
        /// 化学名拼音码
        /// </summary>
        public string OtherCode
        {
            get { return _otherCode; }
            set { _otherCode = value; }
        }

        /// <summary>
        /// 主组
        /// </summary>
        public string GroupMainId
        {
            get { return _groupMainId; }
            set { _groupMainId = value; }
        }

        /// <summary>
        /// 子组
        /// </summary>
        public string GroupSubId
        {
            get { return _groupSubId; }
            set { _groupSubId = value; }
        }

        /// <summary>
        /// 简称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 全称
        /// </summary>
        public string LongDesc
        {
            get { return _longDesc; }
            set { _longDesc = value; }
        }

        /// <summary>
        /// 英文名
        /// </summary>
        public string EngDesc
        {
            get { return _engDesc; }
            set { _engDesc = value; }
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
        /// 住院单位
        /// </summary>
        public string UnitInId
        {
            get { return _unitInId; }
            set { _unitInId = value; }
        }

        /// <summary>
        /// 住院价格
        /// </summary>
        public double PriceIn
        {
            get { return _priceIn; }
            set { _priceIn = value; }
        }

        /// <summary>
        /// 门诊单位
        /// </summary>
        public string UnitDiagId
        {
            get { return _unitDiagId; }
            set { _unitDiagId = value; }
        }

        /// <summary>
        /// 门诊价格
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        /// <summary>
        /// 加成率
        /// </summary>
        public double AddPercent
        {
            get { return _addPercent; }
            set { _addPercent = value; }
        }

        /// <summary>
        /// 处方项目：1-中成药；2-西药；3-中药；4-检验；5-检查；6-手术；7-治疗；8-床位；9-卫生材料;10-物资
        /// </summary>
        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }

        /// <summary>
        /// 用量
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }

        /// <summary>
        /// 服用单位
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }

        /// <summary>
        /// 频率
        /// </summary>
        public string FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// 用法
        /// </summary>
        public string UsageId
        {
            get { return _usageId; }
            set { _usageId = value; }
        }

        /// <summary>
        /// 门诊收费类别
        /// </summary>
        public string FeeMzId
        {
            get { return _feeMzId; }
            set { _feeMzId = value; }
        }

        /// <summary>
        /// 住院收费类别
        /// </summary>
        public string FeeZyId
        {
            get { return _feeZyId; }
            set { _feeZyId = value; }
        }

        /// <summary>
        /// 公费类别：1-公费；2-自费；3-按固定自付比例
        /// </summary>
        public int LsGfType
        {
            get { return _lsGfType; }
            set { _lsGfType = value; }
        }

        /// <summary>
        /// 固定的自付比例
        /// </summary>
        public double GfFixDisc
        {
            get { return _gfFixDisc; }
            set { _gfFixDisc = value; }
        }

        /// <summary>
        /// 国基
        /// </summary>
        public bool OptionPrice
        {
            get { return _optionPrice; }
            set { _optionPrice = value; }
        }

        /// <summary>
        /// 单位剂量
        /// </summary>
        public double LimitTotalMz
        {
            get { return _limitTotalMz; }
            set { _limitTotalMz = value; }
        }

        /// <summary>
        /// 住院计价最小用量
        /// </summary>
        public double LimitTotalZy
        {
            get { return _limitTotalZy; }
            set { _limitTotalZy = value; }
        }

        /// <summary>
        /// 公费限额类别
        /// </summary>
        public string TypeGFXEId
        {
            get { return _typeGFXEId; }
            set { _typeGFXEId = value; }
        }

        /// <summary>
        /// 省基
        /// </summary>
        public bool IsSpecSum
        {
            get { return _isSpecSum; }
            set { _isSpecSum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsNew
        {
            get { return _isNew; }
            set { _isNew = value; }
        }

        /// <summary>
        /// 医院内部使用的项目
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }

        /// <summary>
        /// 禁止临床开药
        /// </summary>
        public bool IsRpForbid
        {
            get { return _isRpForbid; }
            set { _isRpForbid = value; }
        }

        /// <summary>
        /// 是否儿科加收20%
        /// </summary>
        public bool IsChildAdd
        {
            get { return _isChildAdd; }
            set { _isChildAdd = value; }
        }

        /// <summary>
        /// 是否床位费
        /// </summary>
        public bool IsBedFee
        {
            get { return _isBedFee; }
            set { _isBedFee = value; }
        }

        /// <summary>
        /// 是否加收布类费用
        /// </summary>
        public bool IsOpsAdd
        {
            get { return _isOpsAdd; }
            set { _isOpsAdd = value; }
        }

        /// <summary>
        /// 限制使用地点：1-全部;2-门诊;3-住院(原意义：长期医嘱附加收费的周期：1-每次收费；2-每天收费；3-每周收费)
        /// </summary>
        public int LsfeeTurn
        {
            get { return _lsfeeTurn; }
            set { _lsfeeTurn = value; }
        }

        /// <summary>
        /// 医嘱类别：1-医嘱；2-附加收费
        /// </summary>
        public int LsAdviceType
        {
            get { return _lsAdviceType; }
            set { _lsAdviceType = value; }
        }

        /// <summary>
        /// 执行科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 检验ID,对应CkItem.Id
        /// </summary>
        public string LISCode
        {
            get { return _lISCode; }
            set { _lISCode = value; }
        }

        /// <summary>
        /// 封面图片
        /// </summary>
        public string CoverPicture
        {
            get { return _coverPicture; }
            set { _coverPicture = value; }
        }

        /// <summary>
        /// 说明书扫描图
        /// </summary>
        public string MemoPicture
        {
            get { return _memoPicture; }
            set { _memoPicture = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 有效标志
        /// </summary>
        public bool IsActive
        {
            get{ return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 图标类型
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// 按小时计费
        /// </summary>
        public bool IsInoculate
        {
            get { return _isInoculate; }
            set { _isInoculate = value; }
        }

        /// <summary>
        /// 最高零售价
        /// </summary>
        public double PriceHighLine
        {
            get { return _priceHighLine; }
            set { _priceHighLine = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 三级分组
        /// </summary>
        public string GroupSubId2
        {
            get { return _groupSubId2; }
            set { _groupSubId2 = value; }
        }

        /// <summary>
        /// 输入时间
        /// </summary>
        public DateTime LastTime
        {
            get { return _lastTime; }
            set { _lastTime = value; }
        }

        /// <summary>
        /// 一级医院价格
        /// </summary>
        public double PriceSub
        {
            get { return _priceSub; }
            set { _priceSub = value; }
        }

        /// <summary>
        /// 对应基本检查
        /// </summary>
        public string CheckId
        {
            get { return _checkId; }
            set { _checkId = value; }
        }

        /// <summary>
        /// 对应基本护理
        /// </summary>
        public string NurseId
        {
            get { return _nurseId; }
            set { _nurseId = value; }
        }

        /// <summary>
        /// 对应基本治疗
        /// </summary>
        public string CureId
        {
            get { return _cureId; }
            set { _cureId = value; }
        }

        /// <summary>
        /// 药典ID
        /// </summary>
        public string DrugID
        {
            get { return _drugID; }
            set { _drugID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CopyId
        {
            get { return _copyId; }
            set { _copyId = value; }
        }

        /// <summary>
        /// 门诊计价最小用量
        /// </summary>
        public int MzUnitTotal
        {
            get { return _mzUnitTotal; }
            set { _mzUnitTotal = value; }
        }

        /// <summary>
        /// 住院计价最小用量
        /// </summary>
        public int ZyUnitTotal
        {
            get { return _zyUnitTotal; }
            set { _zyUnitTotal = value; }
        }

        /// <summary>
        /// 是否门特用药
        /// </summary>
        public bool IsMtDrug
        {
            get { return _isMtDrug; }
            set { _isMtDrug = value; }
        }

        /// <summary>
        /// 包装规格
        /// </summary>
        public string PackageSpec
        {
            get { return _packageSpec; }
            set { _packageSpec = value; }
        }

        /// <summary>
        /// 是否市基
        /// </summary>
        public bool IsCitySum
        {
            get { return _isCitySum; }
            set { _isCitySum = value; }
        }

        /// <summary>
        /// 医保均价
        /// </summary>
        public double YBAvgPrice
        {
            get { return _yBAvgPrice; }
            set { _yBAvgPrice = value; }
        }

        /// <summary>
        /// 省统一码
        /// </summary>
        public string ProvinceCode
        {
            get { return _provinceCode; }
            set { _provinceCode = value; }
        }

        /// <summary>
        /// 最近修改操作员
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }

        /// <summary>
        /// 行心云:是否已经从中成药推荐界面开过药
        /// </summary>
        public bool IsFirstRecommend
        {
            get { return _isFirstRecommend; }
            set { _isFirstRecommend = value; }
        }

        /// <summary>
        /// 行心云:药品功效
        /// </summary>
        public string DrugEfficacy
        {
            get { return _drugEfficacy; }
            set { _drugEfficacy = value; }
        }

        /// <summary>
        /// 行心云:药品说明
        /// </summary>
        public string DrugInstruction
        {
            get { return _drugInstruction; }
            set { _drugInstruction = value; }
        }

        /// <summary>
        /// 行心云:药物禁忌
        /// </summary>
        public string DrugTaboos
        {
            get { return _drugTaboos; }
            set { _drugTaboos = value; }
        }

        /// <summary>
        /// 行心云:通用名id
        /// </summary>
        public string CommonNameId
        {
            get { return _commonNameId; }
            set { _commonNameId = value; }
        }

        /// <summary>
        /// 行心云:通用名
        /// </summary>
        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        /// <summary>
        /// 行心云:F3是否自动收
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        /// <summary>
        /// 行心云:会员价
        /// </summary>
        public double VipPrice
        {
            get { return _vipPrice; }
            set { _vipPrice = value; }
        }

        /// <summary>
        /// 行心云:有效期限-年
        /// </summary>
        public int TermYear
        {
            get { return _termYear; }
            set { _termYear = value; }
        }

        /// <summary>
        /// 行心云:有效期限-月
        /// </summary>
        public int TermMonth
        {
            get { return _termMonth; }
            set { _termMonth = value; }
        }

        /// <summary>
        /// 行心云:是否打折
        /// </summary>
        public bool IsDiscounts
        {
            get { return _isDiscounts; }
            set { _isDiscounts = value; }
        }

        /// <summary>
        /// 行心云: 体检科室
        /// </summary>
        public string TjLocationId
        {
            get { return _tjLocationId; }
            set { _tjLocationId = value; }
        }

        /// <summary>
        /// 行心云:是否打印套餐名
        /// </summary>
        public bool IsPrintName
        {
            get { return _isPrintName; }
            set { _isPrintName = value; }
        }

    

        /// <summary>
        /// 生产商ID 关联bsmanufacturer.
        /// </summary> 
        public string ManuId
        {
            get { return this._manuId; }
            set { this._manuId = value; }
        }



        /// <summary>
        /// 
        /// </summary>
        public int SamlingType
        {
            get { return this._samlingType; }
            set { this._samlingType = value; }
        }

        /// <summary>
        /// 商城类型ID
        /// </summary>
        public string BusinessCity
        {
            get { return this._businessCity; }
            set { this._businessCity = value; }
        }

        ///// <summary>
        ///// 套餐主表ID
        ///// </summary>
        //public string XdRpId
        //{
        //    get { return _xdRpId; }
        //    set { _xdRpId = value; }
        //}

        /// <summary>
        /// 门诊收费类别，对应 EnumFeeMzId 中的项
        /// </summary>
        public int FeeMzIdCode
        {
            get { return _feeMzIdCode; }
            set { _feeMzIdCode = value; }
        }

        private string _operId;
        /// <summary>  
        /// 录入人  
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        private bool _aKA185;

        /// <summary>
        /// 是否限制用药
        /// </summary>
        public bool AKA185
        {
            get { return _aKA185; }
            set { _aKA185 = value; }
        }
          

        private bool _isReimbursement;
        /// <summary>
        /// 是否报销
        /// </summary>
        public bool IsReimbursement
        {
            get { return _isReimbursement; }
            set { _isReimbursement = value; }
        }

        private int _ckItemType;
        /// <summary>
        /// 检验组合类型:1.检查项目 2.检验项目
        /// </summary>
        public int CkItemType
        {
            get { return _ckItemType; }
            set { _ckItemType = value; }
        }

        /// <summary>
        /// 是否报销
        /// </summary>
        public bool IsYBItems
        {
            get { return _isYBIrems; }
            set { _isYBIrems = value; }
        }

        /// <summary>
        /// 是否集团项目
        /// </summary>
        public bool IsIndustries
        {
            get { return _isIndustries; }
            set { _isIndustries = value; }
        }
        private bool _isWestern = false;
        public bool u_IsWestern
        {
            get
            {
                if (FeeMzIdCode == ((int)EnumRecipeType.西药))
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
                if (FeeMzIdCode == ((int)EnumRecipeType.中药))
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
    }
}


