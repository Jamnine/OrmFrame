using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 服务派工单
    /// </summary>
    [Serializable]
    public class OuOrderInfo : BaseModel
    {
       
        private string _billNo;
        /// <summary>
        /// 工单号
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        private string _patId;
        /// <summary>
        /// 客人编号
        /// </summary>
        public string PatId
        {
            get { return _patId; }
            set { _patId = value; }
        }

        private string _itemId;
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        private int _orderStart;
        /// <summary>
        /// 订单状态编号
        /// </summary>
        public int OrderStart
        {
            get { return _orderStart; }
            set { _orderStart = value; }
        }

        private int _orderLive;
        /// <summary>
        /// 订单等级编号
        /// </summary>
        public int OrderLive
        {
            get { return _orderLive; }
            set { _orderLive = value; }
        }

        private int _orderType;
        /// <summary>
        /// 派工单类别
        /// </summary>
        public int OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }

        private int _payWay;
        /// <summary>
        /// 支付方式编号
        /// </summary>
        public int PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }

        private int _payStart;
        /// <summary>
        /// 支付状态编号
        /// </summary>
        public int PayStart
        {
            get { return _payStart; }
            set { _payStart = value; }
        }

        private string _operId;
        /// <summary>
        /// 服务员编号
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        private string _provinceId;
        /// <summary>
        /// 省编号
        /// </summary>
        public string ProvinceId
        {
            get { return _provinceId; }
            set { _provinceId = value; }
        }

        private string _regionId;
        /// <summary>
        /// 市编号
        /// </summary>
        public string RegionId
        {
            get { return _regionId; }
            set { _regionId = value; }
        }

        private string _areaId;
        /// <summary>
        /// 区编号
        /// </summary>
        public string AreaId
        {
            get { return _areaId; }
            set { _areaId = value; }
        }

        private string _address;
        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private bool _isActive;
        /// <summary>
        /// 是否有效（撤销）
        /// </summary>
        [DefaultValue(true)]
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 服务时间
        /// </summary>
        private DateTime _serviceTime = DateTime.Now;
        public DateTime ServiceTime {
            get { return _serviceTime; }
            set { _serviceTime = value; }
        }
       
        private string _dateRemarks;
        /// <summary>
        /// 时间备注
        /// </summary>
        public string DateRemarks
        {
            get { return _dateRemarks; }
            set { _dateRemarks = value; }
        }


        #region Usp
        /// <summary>
        /// 服务员姓名
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 客人姓名
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string SexName { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 省名称
        /// </summary>
        public string ProvinceName { get; set; }
        /// <summary>
        /// 市名称
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// 区名称
        /// </summary>
        public string AreaName { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderStartName { get; set; }
        /// <summary>
        /// 订单等级
        /// </summary>
        public string OrderLiveName { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        public string PayWayName { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public string PayStartName { get; set; }

        public string OrderTypeName { get; set; }
        #endregion
    }
}
