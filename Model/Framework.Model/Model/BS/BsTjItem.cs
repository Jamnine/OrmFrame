// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjItem.cs  
//   
// Copyright   
// History:  
// 2015/12/18 16:56:42: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// 体检项目 
    /// </summary>  
    [Serializable]
   
    public partial class BsTjItem : BaseModel
    {
        private string _code = String.Empty;
        private string _zdyCode = String.Empty;
        private string _name = String.Empty;
        private string _itemUnit = String.Empty;
        private string _sex = String.Empty;
        private double _itemPrice;
        private string _defaultResult = String.Empty;
        private string _dataType = String.Empty;
        private string _referType = String.Empty;
        private double _referTopLimit;
        private double _referLowerLimit;
        private string _higherTips = String.Empty;
        private string _lowerTips = String.Empty;

        private double _veryTopLimit;
        private double _veryLowLimit;
        private string _veryTopTips = String.Empty;
        private string _veryLowTips = String.Empty;

        private string _minValue = String.Empty;
        private string _maxValue = String.Empty;
        private string _classId;
        private bool _isGroup = false;
        private string _comments = String.Empty;
        private string _guideTips = String.Empty;
        private string _lISCode = String.Empty;
        private string _pyCode = String.Empty;
        private string _wbCode = String.Empty;
        private DateTime _modiTime;
        private string _modiOperId;
        private int _orderBy;
        private bool _isActive = true;
        private string _tjLocationID;
        private string _modiOperName = String.Empty;
        private double _vipPrice = 0;
        private bool _isDiscounts = false;
        private string _engDesc;
        private bool _isPrintName = false;
        protected string _sourceId;
        protected string _tubeTypeId;
        private string _itemInterface = String.Empty;
        private int _printTagType = 0;
        private int _cKMachineID = 0;
        private int _totality = 1;
        private bool _isChecked = false;
        private string  _locationId;
        private string _commonName;
        private  int _commonNameId;

        private bool _isAutoOver;
        private string _medicalCode;
        private int _samlingType;
        private string _commentary = string.Empty;
        private string _commonProblem = string.Empty;
        private string _testIllustration = string.Empty;
        private string _testWay = string.Empty;
        private string _tjLocationName;
        public BsTjItem()
        {
        }

        /// <summary>
        /// 通用名id
        /// </summary>
        public int CommonNameId
        {
            get
            {
                return _commonNameId;
            }
            set
            {
                _commonNameId = value;
            }
        }

        /// <summary>
        /// 通用名
        /// </summary>
        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        /// <summary>
        /// 诊所id
        /// </summary>
        public string  LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>  
        ///  项目编号 
        /// </summary>  
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        /// <summary>  
        /// 自定义码  
        /// </summary>  
        public string ZdyCode
        {
            get { return this._zdyCode; }
            set { this._zdyCode = value; }
        }

        /// <summary>  
        ///  项目名称 
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        /// 项目单位  
        /// </summary>  
        public string ItemUnit
        {
            get { return this._itemUnit; }
            set { this._itemUnit = value; }
        }

        /// <summary>  
        ///  性别限制 M男 F女 A通用 
        /// </summary>  
        public string Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        /// <summary>  
        /// 项目价格  
        /// </summary>  
        public double ItemPrice
        {
            get { return this._itemPrice; }
            set { this._itemPrice = value; }
        }

        /// <summary>  
        /// 默认结果  
        /// </summary>  
        public string DefaultResult
        {
            get { return this._defaultResult; }
            set { this._defaultResult = value; }
        }

        /// <summary>  
        /// 数据类型 N 数值型 C字符型  
        /// </summary>  
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        /// <summary>  
        /// 参考类型 (X-Y  >X  <Y  字符串 其他)
        /// </summary>  
        public string ReferType
        {
            get { return this._referType; }
            set { this._referType = value; }
        }

        /// <summary>  
        /// 参考上限  
        /// </summary>  
        public double LimitHigh
        {
            get { return this._referTopLimit; }
            set { this._referTopLimit = value; }
        }

        /// <summary>  
        /// 参考下限  
        /// </summary>  
        public double LimitLow
        {
            get { return this._referLowerLimit; }
            set { this._referLowerLimit = value; }
        }

        /// <summary>  
        /// 偏高提示  
        /// </summary>  
        public string HigherTips
        {
            get { return this._higherTips; }
            set { this._higherTips = value; }
        }

        /// <summary>  
        /// 偏低提示  
        /// </summary>  
        public string LowerTips
        {
            get { return this._lowerTips; }
            set { this._lowerTips = value; }
        }

        /// <summary>  
        /// 极低危值  
        /// </summary>  
        public double VeryLowLimit
        {
            get { return this._veryLowLimit; }
            set { this._veryLowLimit = value; }
        }

        /// <summary>  
        /// 极高危值  
        /// </summary>  
        public double VeryTopLimit
        {
            get { return this._veryTopLimit; }
            set { this._veryTopLimit = value; }
        }

        /// <summary>  
        /// 极低危提示  
        /// </summary>  
        public string VeryLowTips
        {
            get { return this._veryLowTips; }
            set { this._veryLowTips = value; }
        }

        /// <summary>  
        /// 极高危提示  
        /// </summary>  
        public string VeryTopTips
        {
            get { return this._veryTopTips; }
            set { this._veryTopTips = value; }
        }
        /// <summary>  
        /// 最小值  
        /// </summary>  
        public string MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        /// <summary>  
        /// 最大值  
        /// </summary>  
        public string MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        /// <summary>  
        ///  体检项目类别ID (BsTjItemClass的ID)
        /// </summary>  
        public string ClassId
        {
            get { return this._classId; }
            set { this._classId = value; }
        }

        /// <summary>  
        /// 是否组合项目  
        /// </summary>  
        public bool IsGroup
        {
            get { return this._isGroup; }
            set { this._isGroup = value; }
        }

        /// <summary>  
        ///  备注 
        /// </summary>  
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        /// <summary>  
        /// 指引提示  
        /// </summary>  
        public string GuideTips
        {
            get { return this._guideTips; }
            set { this._guideTips = value; }
        }

        /// <summary>  
        ///   LIS编码
        /// </summary>  
        public string LISCode
        {
            get { return this._lISCode; }
            set { this._lISCode = value; }
        }

        /// <summary>  
        ///   拼音码
        /// </summary>  
        public string PyCode
        {
            get { return this._pyCode; }
            set { this._pyCode = value; }
        }

        /// <summary>  
        ///   五笔码
        /// </summary>  
        public string WbCode
        {
            get { return this._wbCode; }
            set { this._wbCode = value; }
        }

        /// <summary>  
        /// 最后修改时间  
        /// </summary>  
        public DateTime ModiTime
        {
            get { return this._modiTime; }
            set { this._modiTime = value; }
        }

        /// <summary>  
        /// 最后修改人  
        /// </summary>  
        public string ModiOperId
        {
            get { return this._modiOperId; }
            set { this._modiOperId = value; }
        }

        /// <summary>  
        ///   排序
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        /// <summary>  
        ///   是否启用
        /// </summary>  
        public bool IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        /// <summary>  
        ///   体验项目名称
        /// </summary>  
        public string ModiOperName
        {
            get { return this._modiOperName; }
            set { this._modiOperName = value; }
        }

        /// <summary>  
        /// 体检科室ID  
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }
        /// <summary>
        /// 体检科室名称
        /// </summary>
        public string TjLocationName
        {
            get { return this._tjLocationName; }
            set { this._tjLocationName = value; }
        }

        /// <summary>
        /// 会员价
        /// </summary>
        public double VIPPrice
        {
            get { return this._vipPrice; }
            set { this._vipPrice = value; }
        }

        /// <summary>
        /// 是否打折
        /// </summary>
        public bool IsDiscounts
        {
            get { return this._isDiscounts; }
            set { this._isDiscounts = value; }
        }

        /// <summary>
        /// 英文名.
        /// </summary>
        public string EngDesc
        {
            get
            {
                return this._engDesc;
            }
            set
            {
                this._engDesc = value;
            }
        }
        /// <summary>  
        /// 是否打印套餐名
        /// </summary>  
        public bool IsPrintName
        {
            get { return this._isPrintName; }
            set { this._isPrintName = value; }
        }

        /// <summary>  
        /// 标本id  
        /// </summary>  
        public string SourceId
        {
            get { return _sourceId; }
            set { _sourceId = value; }
        }

        /// <summary>  
        /// 容器类型id  
        /// </summary>  
        public string TubeTypeId
        {
            get { return _tubeTypeId; }
            set { _tubeTypeId = value; }
        }

        /// <summary>  
        /// 项目接口(仪器转出端口)
        /// </summary>  
        public string ItemInterface
        {
            get { return _itemInterface; }
            set { _itemInterface = value; }
        }

        /// <summary>
        /// 打印标签类型
        /// </summary>
        public int PrintTagType
        {
            get { return this._printTagType; }
            set { this._printTagType = value; }
        }

        /// <summary>
        /// 仪器ID
        /// </summary>
        public int CKMachineID
        {
            get { return this._cKMachineID; }
            set { this._cKMachineID = value; }
        }

        /// <summary>
        /// 总量
        /// </summary>
        public int Totality
        {
            get
            {
                return _totality;
            }
            set
            {
                _totality = value;
            }
        }

        /// <summary>
        /// 是否已添加OuRecipeDtl
        /// </summary>
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
            }
        }

        /// <summary>
        /// 医保编号
        /// </summary>
        public string MedicalCode
        {
            get
            {
                return _medicalCode;
            }
            set
            {
                _medicalCode = value;
            }
        }

        /// <summary>  
        /// 是否自动结束  
        /// </summary>  
        public bool IsAutoOver
        {
            get { return this._isAutoOver; }
            set { this._isAutoOver = value; }
        }

        /// <summary>
        /// 采样方式
        /// </summary>
        public int SamlingType
        {
            get { return this._samlingType; }
            set { this._samlingType = value; }
        }

        /// <summary>
        /// 评论
        /// </summary>
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }

        /// <summary>  
        ///  常见问题 
        /// </summary>  
        public string CommonProblem
        {
            get { return _commonProblem; }
            set { _commonProblem = value; }
        }

        /// <summary>
        /// 检测说明
        /// </summary>
        public string TestIllustration
        {
            get { return _testIllustration; }
            set { _testIllustration = value; }
        }
        /// <summary>
        /// 检测方法
        /// </summary> 
        public string TestWay
        {
            get
            {
                return _testWay;
            }

            set
            {
                _testWay = value;
            }
        }

    }
}

