

using System;
namespace Orm.Model
{
    /// <summary>
    /// 电子病历 - 实体类
    /// </summary>
    [Serializable]
    public partial class InEMR : BaseModel
    {

        private string _recNo;  //编号

        private string _hospId;  //住院号（相当于门诊的流水号）,用户不可见

        private DateTime _operTime;  //创建时间

        private string _operID;  //操作员

        private DateTime _modifyOperTime;  //修改时间

        private string _modifyOperID;  //操作员

        private string _catalogId;  //病案类别

        private byte[] _content;  //病历内容

        private string _xMLFile;  //xml文件

        private bool _isAuth;  //是否审核

        private DateTime _authOperTime;  //审核日期

        private string _authOperId;  //审核人

        private byte[] _xMLContent;  //xml内容

        private bool _isRealease;  //是否提交

        private DateTime _realeaseTime;  //提交日期

        private string _realeaseOperId;  //提交人

        private bool _isPrint;  //是否打印

        private DateTime _printTime;  //打印日期

        private string _printOperId;  //打印人

        private bool _isClosed;  //是否归档

        private DateTime _closedTime;  //归档日期

        private string _closedOperId;  //归档人

        private bool _isCheck;  //是否上级医生审核

        private string _locationId;  //科室ID,BsLocation.Id

        private bool _isDelete;  //是否删除

        private DateTime _operTime2;  //创建时间备份

        private string _nodeOrderBy;  //节点显示排序

        private string _deptName;  //科室名称

        private string _bedName;  //床位名称

        private string _emrTypeName;  //病历类型名称

        private int _secretLevel;  //保密等级

        private bool _isAuthed;  //已经封存，不可改删

        private int _hospitalId;  //

        private int _hisType;

        private DateTime _insertTime;

        private bool _isNew;
        public InEMR() { }


        /// <summary>
        /// 编号
        /// </summary>
        public string RecNo
        {
            get { return _recNo; }
            set { _recNo = value; }
        }

        /// <summary>
        /// 住院号（相当于门诊的流水号）,用户不可见
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OperID
        {
            get { return _operID; }
            set { _operID = value; }
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyOperTime
        {
            get { return _modifyOperTime; }
            set { _modifyOperTime = value; }
        }

        /// <summary>
        /// 操作员
        /// </summary>
        public string ModifyOperID
        {
            get { return _modifyOperID; }
            set { _modifyOperID = value; }
        }

        /// <summary>
        /// 病案类别
        /// </summary>
        public string CatalogId
        {
            get { return _catalogId; }
            set { _catalogId = value; }
        }

        /// <summary>
        /// 病历内容
        /// </summary>
        public byte[] Content
        {
            get { return _content; }
            set { _content = value; }
        }

        /// <summary>
        /// xml文件
        /// </summary>
        public string XMLFile
        {
            get { return _xMLFile; }
            set { _xMLFile = value; }
        }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsAuth
        {
            get { return _isAuth; }
            set { _isAuth = value; }
        }

        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime AuthOperTime
        {
            get { return _authOperTime; }
            set { _authOperTime = value; }
        }

        /// <summary>
        /// 审核人
        /// </summary>
        public string AuthOperId
        {
            get { return _authOperId; }
            set { _authOperId = value; }
        }

        /// <summary>
        /// xml内容
        /// </summary>
        public byte[] XMLContent
        {
            get { return _xMLContent; }
            set { _xMLContent = value; }
        }

        /// <summary>
        /// 是否提交
        /// </summary>
        public bool IsRealease
        {
            get { return _isRealease; }
            set { _isRealease = value; }
        }

        /// <summary>
        /// 提交日期
        /// </summary>
        public DateTime RealeaseTime
        {
            get { return _realeaseTime; }
            set { _realeaseTime = value; }
        }

        /// <summary>
        /// 提交人
        /// </summary>
        public string RealeaseOperId
        {
            get { return _realeaseOperId; }
            set { _realeaseOperId = value; }
        }

        /// <summary>
        /// 是否打印
        /// </summary>
        public bool IsPrint
        {
            get { return _isPrint; }
            set { _isPrint = value; }
        }

        /// <summary>
        /// 打印日期
        /// </summary>
        public DateTime PrintTime
        {
            get { return _printTime; }
            set { _printTime = value; }
        }

        /// <summary>
        /// 打印人
        /// </summary>
        public string PrintOperId
        {
            get { return _printOperId; }
            set { _printOperId = value; }
        }

        /// <summary>
        /// 是否归档
        /// </summary>
        public bool IsClosed
        {
            get { return _isClosed; }
            set { _isClosed = value; }
        }

        /// <summary>
        /// 归档日期
        /// </summary>
        public DateTime ClosedTime
        {
            get { return _closedTime; }
            set { _closedTime = value; }
        }

        /// <summary>
        /// 归档人
        /// </summary>
        public string ClosedOperId
        {
            get { return _closedOperId; }
            set { _closedOperId = value; }
        }

        /// <summary>
        /// 是否上级医生审核
        /// </summary>
        public bool IsCheck
        {
            get { return _isCheck; }
            set { _isCheck = value; }
        }

        /// <summary>
        /// 科室ID,BsLocation.Id
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete
        {
            get { return _isDelete; }
            set { _isDelete = value; }
        }

        /// <summary>
        /// 创建时间备份
        /// </summary>
        public DateTime OperTime2
        {
            get { return _operTime2; }
            set { _operTime2 = value; }
        }

        /// <summary>
        /// 节点显示排序
        /// </summary>
        public string NodeOrderBy
        {
            get { return _nodeOrderBy; }
            set { _nodeOrderBy = value; }
        }

        /// <summary>
        /// 科室名称
        /// </summary>
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }

        /// <summary>
        /// 床位名称
        /// </summary>
        public string BedName
        {
            get { return _bedName; }
            set { _bedName = value; }
        }

        /// <summary>
        /// 病历类型名称
        /// </summary>
        public string EmrTypeName
        {
            get { return _emrTypeName; }
            set { _emrTypeName = value; }
        }

        /// <summary>
        /// 保密等级
        /// </summary>
        public int SecretLevel
        {
            get { return _secretLevel; }
            set { _secretLevel = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        public bool IsNew
        {
            get { return _isNew; }
            set { _isNew = value; }
        }
    }
}


