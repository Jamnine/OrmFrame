using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 加工单数据
    /// </summary>
    [Serializable]
    /// <summary>
    /// WorkSheet
    /// </summary>
    public partial class RptWorkSheet:BaseModel{

        private string _patId;
        private string _patName;    
        private string _toothPosition;        
        private string  _processingFactory;
        private string _processingFactoryName;
        private string  _salesMan;
        private string _salesManName;
        private string  _orderType;
        private string _orderTypeName;
        private string  _restoration;
        private string _restorationName;
        private string  _colorimetric;
        private string _colorimetricName;
        private double _amount;
        private int _repairType;
        private string _billNo;
        private string _doctorId;
        private string _doctorName;
        private double _priceIn;
        private double _price;
        private DateTime _sendTime = DateTime.Now;
        private string  _emergencyType;
        private string _emergencyTypeName;
        private DateTime _finishTime = DateTime.Now;
        private DateTime _tryoutTime = DateTime.Now;
        private string _memo;
        private int _attachment;
        private string _attachmentName;
        /// <summary>
        /// 左上位
        /// </summary>
        public string LeftTopTooth { get; set; }
        /// <summary>
        /// 左下位
        /// </summary>
        public string LeftBottonTooth { get; set; }
        /// <summary>
        /// 右上位
        /// </summary>
        public string RightTopTooth { get; set; }
        /// <summary>
        /// 右下位
        /// </summary>
        public string RightBottonTooth { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public int TotalAmount { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// 未完工
        /// </summary>
        public DateTime NoDoTime { get; set; }
        /// <summary>
        /// 已完工
        /// </summary>
        public DateTime DoneTime{ get; set; }
        /// <summary>
        /// 已取件
        /// </summary>
        public DateTime GetOutime { get; set; }
        /// <summary>
        /// 试戴
        /// </summary>
        public DateTime WearTime{ get; set; }
        /// <summary>
        /// 已戴走
        /// </summary>
        public DateTime TakeOutime{ get; set; }
        /// <summary>
        /// 返工
        /// </summary>
        public DateTime ReturnTime{ get; set; }
        /// <summary>
        /// 工种ID
        /// </summary>
        public string WorkTypeId { get; set; }

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public RptWorkSheet()
        {
        }

        /// <summary>
        /// 加工厂.
        /// </summary>
        public string PatID
        {
            get { return this._patId; }
            set { this._patId = value; }
        }
        /// <summary>
        /// 患者.
        /// </summary>
        public string PatName
        {
            get { return this._patName; }
            set { this._patName = value; }
        }

        /// <summary>
        /// 牙位.
        /// </summary>
        public string ToothPosition
        {
            get { return this._toothPosition; }
            set { this._toothPosition = value; }
        }

        /// <summary>
        /// 加工厂.
        /// </summary>
        public string  ProcessingFactory
        {
            get { return this._processingFactory; }
            set { this._processingFactory = value; }
        }

        /// <summary>
        /// 加工厂名称.
        /// </summary>
        public string ProcessingFactoryName
        {
            get { return this._processingFactoryName; }
            set { this._processingFactoryName = value; }
        }

        /// <summary>
        /// 业务员.
        /// </summary>
        public string  SalesMan
        {
            get { return this._salesMan; }
            set { this._salesMan = value; }
        }

        /// <summary>
        /// 业务员Name.
        /// </summary>
        public string SalesManName
        {
            get { return this._salesManName; }
            set { this._salesManName = value; }
        }

        /// <summary>
        /// 订单类型.
        /// </summary>
        public string  OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }

        /// <summary>
        /// 订单类型Name.
        /// </summary>
        public string OrderTypeName
        {
            get { return this._orderTypeName; }
            set { this._orderTypeName = value; }
        }

        /// <summary>
        /// 修复体.
        /// </summary>
        public string  Restoration
        {
            get { return this._restoration; }
            set { this._restoration = value; }
        }

        /// <summary>
        /// 修复体Name.
        /// </summary>
        public string RestorationName
        {
            get { return this._restorationName; }
            set { this._restorationName = value; }
        }

        /// <summary>
        /// 比色.
        /// </summary>
        public  string   Colorimetric
        {
            get { return this._colorimetric; }
            set { this._colorimetric = value; }
        }

        /// <summary>
        /// 比色Name.
        /// </summary>
        public string ColorimetricName
        {
            get { return this._colorimetricName; }
            set { this._colorimetricName = value; }
        }

        /// <summary>
        /// 数量.
        /// </summary>
        public double Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        /// <summary>
        /// 保修期.
        /// </summary>
        public int RepairType
        {
            get { return this._repairType; }
            set { this._repairType = value; }
        }
        /// <summary>
        /// 附件
        /// </summary>
        public int Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }
        /// <summary>
        /// 附件Name
        /// </summary>
        public string AttachmentName
        {
            get { return this._attachmentName; }
            set { this._attachmentName = value; }
        }

        /// <summary>
        /// 单号.
        /// </summary>
        public string BillNo
        {
            get { return this._billNo; }
            set { this._billNo = value; }
        }

        /// <summary>
        /// 医生Id.
        /// </summary>
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }
        /// <summary>
        /// 医生Name.
        /// </summary>
        public string DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }
        /// <summary>
        ///  总价格.
        /// </summary>
        public double PriceIn
        {
            get { return this._priceIn; }
            set { this._priceIn = value; }
        }
        /// <summary>
        /// 单品价格
        /// </summary>
        public double Price
        {
            get { return this._price; }
            set { this._price= value; }
        }

        /// <summary>
        /// 送件日期.
        /// </summary>
        public DateTime SendTime
        {
            get { return this._sendTime; }
            set { this._sendTime = value; }
        }

        /// <summary>
        /// 紧急程度.
        /// </summary>
        public  string  EmergencyType
        {
            get { return this._emergencyType; }
            set { this._emergencyType = value; }
        }

        /// <summary>
        /// 紧急程度Name.
        /// </summary>
        public string EmergencyTypeName
        {
            get { return this._emergencyTypeName; }
            set { this._emergencyTypeName = value; }
        }


        /// <summary>
        /// 完成时间.
        /// </summary>
        public DateTime FinishTime
        {
            get { return this._finishTime; }
            set { this._finishTime = value; }
        }

        /// <summary>
        /// 试代日期.
        /// </summary>
        public DateTime TryoutTime
        {
            get { return this._tryoutTime; }
            set { this._tryoutTime = value; }
        }

        /// <summary>
        /// 备注.
        /// </summary>
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }
        /// <summary>
        /// 总和
        /// </summary>
        public double Count { get; set; }

        /// <summary>
        /// 门诊id
        /// </summary>
        public string HosId { get; set; }

        /// <summary>
        /// 加工单状态
        /// </summary>
        public string WorkTypeName { get; set; }

        

    }
}



