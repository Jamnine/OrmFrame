

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class CkItem : BaseModel
	{   
		private string _code;  //检查项目编码
        private string _memo;

        private int _lsTestType;  //检查分类：1-常规体检；2-生化检查
		
		private string _testTypeId;  //检验类别CkTestType.Id
		
		private string _tubeTypeId;  //容器类型
		
		private string _shortName = string.Empty;  //简称
		
		private string _name;  //英文全称
		
		private string _operMemo;  //操作说明
		
		private bool _isZero;  //是否允许结果为零
		
		private int _lsGroup;  //组/集：1-测试组；2-测试集；3-单项
		
		private bool _isReport;  //是否需要打印报告
		
		private string _useRange;  //适用的范围
		
		private int _lsForSex;  //适用于：1-男；2-女；3-两者
		
		private string _sourceId;  //标本类型
		
		private double _price;  //价格
		
		private string _unit;  //单位
		
		private string _format;  //结果格式化
		
		private double _limitHigh;  //打印高限
		
		private string _veryLowLimit;  //极低危值
        private string _veryTopLimit;//极高危值

        private double _limitLow;  //打印低限
		
		private string _printHigh;  //超出高限时打印
		
		private string _printLow;  //超出低限时打印
		
		private double _dalAbsolute;  //上次对比正常范围（绝对值）
		
		private double _dalPercent;  //上次对比正常范围（百分比）
		
		private string _itemId;  //收费项目ID
		
		private int _orderBy;  //显示顺序
		
		private bool _isDisplay;  //是否在登记标本时显示
		
		private bool _isActive =true;  //是否可用
		
		private string _fluidId;  //标本类别对应BsFluid.Id
		
		private string _testWay;  //检验方式
		
		private double _dev3;  //标准差+3
		
		private double _dev2;  //标准差+2
		
		private double _dev1;  //标准差+1
		
		private double _devM1;  //标准差-1
		
		private double _devM2;  //标准差-2
		
		private double _devM3;  //标准差-3
		
		private double _avgValue;  //平均值
		
		private string _defaultValue;  //默认结果

        private string _cKMachineID;  //仪器ID

        private double _vipPrice; //会员价格

        private int _HospitalID;  //诊所id

        private int _histype = 2;//产品类型：0.共享 1.His 2.行心云

 
        /// <summary>
        /// 检查项目编码
        /// </summary>
        public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
        public string Memo
        {
			get { return _memo; }
			set { _memo = value;}
		}           
		/// <summary>
		/// 检查分类：1-检验项目；2-检验项目
		/// </summary>
		public int LsTestType
		{
			get { return _lsTestType;}
			set { _lsTestType = value;}
		}                                    
		
		/// <summary>
		/// 检验类别CkTestType.Id,相当之前tjlocationid
		/// </summary>
		public string TestTypeId
		{
			get { return _testTypeId;}
			set { _testTypeId = value;}
		}                                    
		
		/// <summary>
		/// 容器类型
		/// </summary>
		public string TubeTypeId
		{
			get { return _tubeTypeId;}
			set { _tubeTypeId = value;}
		}                                    
		
		/// <summary>
		/// 简称
		/// </summary>
		public string ShortName
		{
			get { return _shortName;}
			set { _shortName = value;}
		}                                    
		
		/// <summary>
		/// 英文全称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 操作说明
		/// </summary>
		public string OperMemo
		{
			get { return _operMemo;}
			set { _operMemo = value;}
		}                                    
		
		/// <summary>
		/// 是否允许结果为零
		/// </summary>
		public bool IsZero
		{
			get { return _isZero;}
			set { _isZero = value;}
		}                                    
		
		/// <summary>
		/// 组/集：1-测试组；2-测试集；3-单项
		/// </summary>
		public int LsGroup
		{
			get { return _lsGroup;}
			set { _lsGroup = value;}
		}                                    
		
		/// <summary>
		/// 是否需要打印报告
		/// </summary>
		public bool IsReport
		{
			get { return _isReport;}
			set { _isReport = value;}
		}                                    
		
		/// <summary>
		/// 适用的范围
		/// </summary>
		public string UseRange
		{
			get { return _useRange;}
			set { _useRange = value;}
		}                                    
		
		/// <summary>
		/// 适用于：1-男；2-女；3-两者
		/// </summary>
		public int LsForSex
		{
			get { return _lsForSex;}
			set { _lsForSex = value;}
		}                                    
		
		/// <summary>
		/// 标本类型
		/// </summary>
		public string SourceId
		{
			get { return _sourceId;}
			set { _sourceId = value;}
		}                                    
		
		/// <summary>
		/// 价格
		/// </summary>
		public double Price
		{
			get { return _price;}
			set { _price = value;}
		}                                    
		
		/// <summary>
		/// 单位
		/// </summary>
		public string Unit
		{
			get { return _unit;}
			set { _unit = value;}
		}                                    
		
		/// <summary>
		/// 结果格式化
		/// </summary>
		public string Format
		{
			get { return _format;}
			set { _format = value;}
		}                                    
		
		/// <summary>
		/// 打印高限
		/// </summary>
		public double LimitHigh
		{
			get { return _limitHigh;}
			set { _limitHigh = value;}
		}    
        /// <summary>
        /// 
        /// </summary>
		public string VeryLowLimit
        {
			get { return _veryLowLimit; }
			set { _veryLowLimit = value;}
		}       
        /// <summary>
        /// 
        /// </summary>
		public string VeryTopLimit
        {
			get { return _veryTopLimit; }
			set { _veryTopLimit = value;}
		}                           
		
		/// <summary>
		/// 打印低限
		/// </summary>
		public double LimitLow
		{
			get { return _limitLow;}
			set { _limitLow = value;}
		}                                    
		
		/// <summary>
		/// 超出高限时打印
		/// </summary>
		public string PrintHigh
		{
			get { return _printHigh;}
			set { _printHigh = value;}
		}                                    
		
		/// <summary>
		/// 超出低限时打印
		/// </summary>
		public string PrintLow
		{
			get { return _printLow;}
			set { _printLow = value;}
		}                                    
		
		/// <summary>
		/// 上次对比正常范围（绝对值）
		/// </summary>
		public double DalAbsolute
		{
			get { return _dalAbsolute;}
			set { _dalAbsolute = value;}
		}                                    
		
		/// <summary>
		/// 上次对比正常范围（百分比）
		/// </summary>
		public double DalPercent
		{
			get { return _dalPercent;}
			set { _dalPercent = value;}
		}                                    
		
		/// <summary>
		/// 收费项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
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
		/// 是否在登记标本时显示
		/// </summary>
		public bool IsDisplay
		{
			get { return _isDisplay;}
			set { _isDisplay = value;}
		}                                    
		
		/// <summary>
		/// 是否可用
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
		/// <summary>
		/// 标本类别对应BsFluid.Id
		/// </summary>
		public string FluidId
		{
			get { return _fluidId;}
			set { _fluidId = value;}
		}                                    
		
		/// <summary>
		/// 检验方式
		/// </summary>
		public string TestWay
		{
			get { return _testWay;}
			set { _testWay = value;}
		}                                    
		
		/// <summary>
		/// 标准差+3
		/// </summary>
		public double Dev3
		{
			get { return _dev3;}
			set { _dev3 = value;}
		}                                    
		
		/// <summary>
		/// 标准差+2
		/// </summary>
		public double Dev2
		{
			get { return _dev2;}
			set { _dev2 = value;}
		}                                    
		
		/// <summary>
		/// 标准差+1
		/// </summary>
		public double Dev1
		{
			get { return _dev1;}
			set { _dev1 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-1
		/// </summary>
		public double DevM1
		{
			get { return _devM1;}
			set { _devM1 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-2
		/// </summary>
		public double DevM2
		{
			get { return _devM2;}
			set { _devM2 = value;}
		}                                    
		
		/// <summary>
		/// 标准差-3
		/// </summary>
		public double DevM3
		{
			get { return _devM3;}
			set { _devM3 = value;}
		}                                    
		
		/// <summary>
		/// 平均值
		/// </summary>
		public double AvgValue
		{
			get { return _avgValue;}
			set { _avgValue = value;}
		}                                    
		
		/// <summary>
		/// 默认结果
		/// </summary>
		public string DefaultValue
		{
			get { return _defaultValue;}
			set { _defaultValue = value;}
		}

        /// <summary>
        /// 仪器ID
        /// </summary>
        public string CKMachineID
        {
            get { return this._cKMachineID; }
            set { this._cKMachineID = value; }
        }

        /// <summary>
        /// 会员价
        /// </summary>
        public double VIPPrice
        {
            get { return this._vipPrice; }
            set { this._vipPrice = value; }
        }



   

        private string _wbCode;
        /// <summary>
        /// 五笔码（固定）
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        private string _pyCode;
        /// <summary>
        /// 拼音码（固定）
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        private int _classId;
        /// <summary>
        /// 拼音码（固定）
        /// </summary>
        public int ClassId
        {
            get { return _classId; }
            set { _classId = value; }
        }

        private DateTime _modiTime;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }

        private string _modiOperId;
        /// <summary>
        /// 操作人
        /// </summary>
        public string ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }
        private string _commentary;
        /// <summary>
        /// 评论
        /// </summary>
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }
        private string _commonProblem;
        /// <summary>
        /// 常见问题
        /// </summary>
        public string CommonProblem
        {
            get { return _commonProblem; }
            set { _commonProblem = value; }
        }

        private string _testIllustration;
        /// <summary>
        /// 检测说明
        /// </summary>
        public string TestIllustration
        {
            get { return _testIllustration; }
            set { _testIllustration = value; }
        }

        private string _commonName;
        /// <summary>
        /// 
        /// </summary>
        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        private string _engDesc;
        /// <summary>
        /// 
        /// </summary>
        public string EngDesc
        {
            get { return _engDesc; }
            set { _engDesc = value; }
        }

        private string _commonNameId;
        /// <summary>
        /// 行心云:通用名id
        /// </summary>
        public string  CommonNameId
        {
            get { return _commonNameId; }
            set { _commonNameId = value; }
        }

        private string _tjLocationID;
        /// <summary>
        /// 行心云:通用名id
        /// </summary>
        public string LocationID
        {
            get { return _tjLocationID; }
            set { _tjLocationID = value; }
        }

        /// <summary>
        /// 产品类型：0.共享  1.His 2.行心云
        /// </summary>
        public int HisType
        {
            get { return _histype; }
            set { _histype = value; }
        }

        public string ModiOperName { get; set; }
        public bool IsPrintName { get; set; }

        private DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        private string _dataType = "C";
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        private string _referType = string.Empty;
        public string ReferType
        {
            get { return this._referType; }
            set { this._referType = value; }
        }

        private string _zdyCode = String.Empty;
        /// <summary>  
        ///  自定义码 
        /// </summary>  
        public string ZdyCode
        {
            get { return this._zdyCode; }
            set { this._zdyCode = value; }
        }

        private string _medicalCode;  //F2医疗机构编码
         /// <summary>
         /// F2医疗机构编码
         /// </summary>
        public string MedicalCode
        {
            get { return _medicalCode; }
            set { _medicalCode = value; }
        }

        private int _printTagType = 0;
        /// <summary>
        /// 打印标签类型
        /// </summary>
        public int PrintTagType
        {
            get { return this._printTagType; }
            set { this._printTagType = value; }
        }


        private string _operId;
        /// <summary>
        /// 操作人id
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        private DateTime _lastTime;

        /// <summary>
        /// 上次修改时间
        /// </summary>
        public DateTime LastTime
        {
            get { return _lastTime; }
            set { _lastTime = value; }
        }

    }  
}           


