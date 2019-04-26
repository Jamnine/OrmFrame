

using System;
namespace Orm.Model
{
    /// <summary>
    /// 检验机器表 - 实体类
    /// </summary>
    [Serializable]
    public partial class CKMachine : BaseModel
    {
         
        private string _code;  //

        private string _name;  //

        private string _testTypeID;  //

        private int _typeNum;  //

        private string _machineNum;  //

        private string _firstSampleNum;  //

        private string _lastSampleNum;  //

        private string _pyCode;  //

        private string _orderBy;  //

        private int _iconIndex;  //

        private bool _isActive;  //

        private DateTime _simpleBeginDate;  //

        private string _filePath;  //

        private string _dataSource;  //

        private string _result;  //

        private int _endCode;  //

        private string _wbCode;  //

        private int _parseTime;  //

        private string _port;  //

        private int _baudRate;  //

        private string _comPort;  //

        private string _className;  //

        private string _barcode;  //

        private int _handshake;  //

        private int _stopBit;  //

        private int _parity;  //

        private int _portNo;  //

        private string _hostIP;  //

        private int _instrumentTest;  //

        private string _communicateMode;  //

        private string _communicateType;  //

        private string _dataFormat;  //

        private int _dataBit;  //

        private string _assemblyName;  //

        private int _responseCode;  //

        private string _responseAt;  //

        private string _accessPassword;  //

        private string _accessUserID;  //

        private string _responseAts;  //

        private string _virtualInstrumentID;  //

        private int _emergencypreseq;  //

        private string _ipAddress;  //

        private int _instrumentSplits;  //

        private int _maintenanceMan;  //

        private string _dictLabDeptID;  //

        private string _dictSpecimentypeId;  //

        private string _engshortName;  //

        private DateTime _testDate;  //

        private DateTime _machineSampleTime;  //行心云:仪器号匹配时间

        private int _ckMnume;  //行心云:流水号

        private int _hospitalId;  //


        /// <summary>
        /// 
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Collumn(HeaderName = "仪器名称", RelatedTableType = null)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TestTypeID
        {
            get { return _testTypeID; }
            set { _testTypeID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int TypeNum
        {
            get { return _typeNum; }
            set { _typeNum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string MachineNum
        {
            get { return _machineNum; }
            set { _machineNum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FirstSampleNum
        {
            get { return _firstSampleNum; }
            set { _firstSampleNum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastSampleNum
        {
            get { return _lastSampleNum; }
            set { _lastSampleNum = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SimpleBeginDate
        {
            get { return _simpleBeginDate; }
            set { _simpleBeginDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int EndCode
        {
            get { return _endCode; }
            set { _endCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ParseTime
        {
            get { return _parseTime; }
            set { _parseTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ComPort
        {
            get { return _comPort; }
            set { _comPort = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Handshake
        {
            get { return _handshake; }
            set { _handshake = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int StopBit
        {
            get { return _stopBit; }
            set { _stopBit = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int PortNo
        {
            get { return _portNo; }
            set { _portNo = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string HostIP
        {
            get { return _hostIP; }
            set { _hostIP = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int InstrumentTest
        {
            get { return _instrumentTest; }
            set { _instrumentTest = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CommunicateMode
        {
            get { return _communicateMode; }
            set { _communicateMode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string CommunicateType
        {
            get { return _communicateType; }
            set { _communicateType = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DataFormat
        {
            get { return _dataFormat; }
            set { _dataFormat = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DataBit
        {
            get { return _dataBit; }
            set { _dataBit = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AssemblyName
        {
            get { return _assemblyName; }
            set { _assemblyName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int ResponseCode
        {
            get { return _responseCode; }
            set { _responseCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ResponseAt
        {
            get { return _responseAt; }
            set { _responseAt = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AccessPassword
        {
            get { return _accessPassword; }
            set { _accessPassword = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AccessUserID
        {
            get { return _accessUserID; }
            set { _accessUserID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ResponseAts
        {
            get { return _responseAts; }
            set { _responseAts = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VirtualInstrumentID
        {
            get { return _virtualInstrumentID; }
            set { _virtualInstrumentID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Emergencypreseq
        {
            get { return _emergencypreseq; }
            set { _emergencypreseq = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int InstrumentSplits
        {
            get { return _instrumentSplits; }
            set { _instrumentSplits = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int MaintenanceMan
        {
            get { return _maintenanceMan; }
            set { _maintenanceMan = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DictLabDeptID
        {
            get { return _dictLabDeptID; }
            set { _dictLabDeptID = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string DictSpecimentypeId
        {
            get { return _dictSpecimentypeId; }
            set { _dictSpecimentypeId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EngshortName
        {
            get { return _engshortName; }
            set { _engshortName = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime TestDate
        {
            get { return _testDate; }
            set { _testDate = value; }
        }

        /// <summary>
        /// 行心云:仪器号匹配时间
        /// </summary>
        public DateTime MachineSampleTime
        {
            get { return _machineSampleTime; }
            set { _machineSampleTime = value; }
        }

        /// <summary>
        /// 行心云:流水号
        /// </summary>
        public int CkMnume
        {
            get { return _ckMnume; }
            set { _ckMnume = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

    }
}


