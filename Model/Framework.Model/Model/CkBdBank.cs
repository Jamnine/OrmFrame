

using System;
namespace Orm.Model
{
    /// <summary>
    /// 血库血袋表 - 实体类
    /// </summary>
    [Serializable]
    public partial class CkBdBank : BaseModel
    {

        private string _serialNo;  //血袋号

        private string _bloodTypeId;  //血液种类：1-普通血浆；2-手工分悬液红细胞；3-手工分浓缩血小板；4-新鲜冰冻血浆;5-全血；6-冷沉淀；7-冷冻血小板；8-冰冻血小板；9-机采血小板；10-洗涤红细胞；11-手工分白细胞；12-

        private string _bloodGroup;  //血型：1-A;2-B;3-O;4-AB

        private DateTime _recieveDate;  //入库时间

        private string _recieveOperId;  //入库员

        private int _lsSource;  //血液来源:1-血站送血；2-自身贮血;

        private string _account;  //单位

        private DateTime _expireDate;  //有效期限

        private string _offerMan;  //献血者

        private DateTime _collectDate;  //采血日期

        private string _collectMan;  //采血人

        private double _vollume;  //血量

        private double _price;  //入库价

        private int _lsStatus;  //状态：1-在库；2-退回；3-发出；4-报废

        private DateTime _backDate;  //退回时间

        private string _backOperId;  //退回人

        private string _backMemo;  //退回备注

        private string _unit;  //单位

        private string _discardReason;  //报废的原因

        private DateTime _discardTime;  //报废时间

        private string _discardOperID;  //报废操作者

        private int _limitDays;  //有效天数

        private double _withPrice;  //配血费

        private double _storagePrice;  //存储费

        private double _retailPrice;  //详细价格

        private double _processingPrice;  //加工费

        private string _applyId;  //对应CkBldApply的ID

        private string _hospId;  //对应住院病人ID

        private string _mzRegId;  //对应门诊病人ID

        private string _locationId;  //对应科室ID

        private string _doctorId;  //对应医生ID

        private string _sendOperId;  //对应BsUser表ID

        private DateTime _sendTime;  //发送时间

        private string _labId;  //对应CkLab表ID

        private string _bloodGroup2;  //血型：1-A;2-B;3-O;4-AB

        private bool _isAuthed;  //已经封存，不可改删

        private int _hospitalId;  //

        private string _rhd;

        public CkBdBank() { }

        /// <summary>
        /// 血袋号
        /// </summary>
        public string SerialNo
        {
            get { return _serialNo; }
            set { _serialNo = value; }
        }

        /// <summary>
        /// 血液种类：1-普通血浆；2-手工分悬液红细胞；3-手工分浓缩血小板；4-新鲜冰冻血浆;5-全血；6-冷沉淀；7-冷冻血小板；8-冰冻血小板；9-机采血小板；10-洗涤红细胞；11-手工分白细胞；12-
        /// </summary>
        public string BloodTypeId
        {
            get { return _bloodTypeId; }
            set { _bloodTypeId = value; }
        }

        /// <summary>
        /// 血型：1-A;2-B;3-O;4-AB
        /// </summary>
        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }

        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime RecieveDate
        {
            get { return _recieveDate; }
            set { _recieveDate = value; }
        }

        /// <summary>
        /// 入库员
        /// </summary>
        public string RecieveOperId
        {
            get { return _recieveOperId; }
            set { _recieveOperId = value; }
        }

        /// <summary>
        /// 血液来源:1-血站送血；2-自身贮血;
        /// </summary>
        public int LsSource
        {
            get { return _lsSource; }
            set { _lsSource = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string Account
        {
            get { return _account; }
            set { _account = value; }
        }

        /// <summary>
        /// 有效期限
        /// </summary>
        public DateTime ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }

        /// <summary>
        /// 献血者
        /// </summary>
        public string OfferMan
        {
            get { return _offerMan; }
            set { _offerMan = value; }
        }

        /// <summary>
        /// 采血日期
        /// </summary>
        public DateTime CollectDate
        {
            get { return _collectDate; }
            set { _collectDate = value; }
        }

        /// <summary>
        /// 采血人
        /// </summary>
        public string CollectMan
        {
            get { return _collectMan; }
            set { _collectMan = value; }
        }

        /// <summary>
        /// 血量
        /// </summary>
        public double Vollume
        {
            get { return _vollume; }
            set { _vollume = value; }
        }

        /// <summary>
        /// 入库价
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// 状态：1-在库；2-退回；3-发出；4-报废
        /// </summary>
        public int LsStatus
        {
            get { return _lsStatus; }
            set { _lsStatus = value; }
        }

        /// <summary>
        /// 退回时间
        /// </summary>
        public DateTime BackDate
        {
            get { return _backDate; }
            set { _backDate = value; }
        }

        /// <summary>
        /// 退回人
        /// </summary>
        public string BackOperId
        {
            get { return _backOperId; }
            set { _backOperId = value; }
        }

        /// <summary>
        /// 退回备注
        /// </summary>
        public string BackMemo
        {
            get { return _backMemo; }
            set { _backMemo = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        /// <summary>
        /// 报废的原因
        /// </summary>
        public string DiscardReason
        {
            get { return _discardReason; }
            set { _discardReason = value; }
        }

        /// <summary>
        /// 报废时间
        /// </summary>
        public DateTime DiscardTime
        {
            get { return _discardTime; }
            set { _discardTime = value; }
        }

        /// <summary>
        /// 报废操作者
        /// </summary>
        public string DiscardOperID
        {
            get { return _discardOperID; }
            set { _discardOperID = value; }
        }

        /// <summary>
        /// 有效天数
        /// </summary>
        public int LimitDays
        {
            get { return _limitDays; }
            set { _limitDays = value; }
        }

        /// <summary>
        /// 配血费
        /// </summary>
        public double WithPrice
        {
            get { return _withPrice; }
            set { _withPrice = value; }
        }

        /// <summary>
        /// 存储费
        /// </summary>
        public double StoragePrice
        {
            get { return _storagePrice; }
            set { _storagePrice = value; }
        }

        /// <summary>
        /// 详细价格
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        /// 加工费
        /// </summary>
        public double ProcessingPrice
        {
            get { return _processingPrice; }
            set { _processingPrice = value; }
        }

        /// <summary>
        /// 对应CkBldApply的ID
        /// </summary>
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }

        /// <summary>
        /// 对应住院病人ID
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        /// <summary>
        /// 对应门诊病人ID
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 对应科室ID
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 对应医生ID
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        /// <summary>
        /// 对应BsUser表ID
        /// </summary>
        public string SendOperId
        {
            get { return _sendOperId; }
            set { _sendOperId = value; }
        }

        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime
        {
            get { return _sendTime; }
            set { _sendTime = value; }
        }

        /// <summary>
        /// 对应CkLab表ID
        /// </summary>
        public string LabId
        {
            get { return _labId; }
            set { _labId = value; }
        }

        /// <summary>
        /// 血型：1-A;2-B;3-O;4-AB
        /// </summary>
        public string BloodGroup2
        {
            get { return _bloodGroup2; }
            set { _bloodGroup2 = value; }
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

        public string RHD
        {
            get { return _rhd; }
            set { _rhd = value; }
        }
    }
}


