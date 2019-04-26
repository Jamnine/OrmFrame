using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 财务报表
    /// </summary>
    [Serializable]

    public class uspFinancialStatement
    {
        private string _doctorName;
        private string _doctorId;
        private string _nurseName;
        private string _nurseId;
        private double _bePrice;

        private string _cashierId;
        private string _cashierName = string.Empty;

        /// <summary>
        /// 收银员名称
        /// </summary>
        public string CashierName
        {
            get { return this._cashierName; }
            set { this._cashierName = value; }
        }
        /// <summary>
        ///  收银员ID
        /// </summary>
        public string CashierId
        {
            get { return this._cashierId; }
            set { this._cashierId = value; }
        }

        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }
        /// <summary>
        ///  医生ID
        /// </summary>
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }
        /// <summary>
        /// 护士
        /// </summary>
        public string NurseName
        {
            get { return this._nurseName; }
            set { this._nurseName = value; }
        }
        /// <summary>
        ///  护士ID
        /// </summary>
        public string NurseId
        {
            get { return this._nurseId; }
            set { this._nurseId = value; }
        }
        /// <summary>
        /// 科室Id
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string RoomName { get; set; }
        /// <summary>
        /// 收费大类
        /// </summary> 
        public string PayName { get; set; }
        /// <summary>
        /// 费用合计
        /// </summary>
        public double Sumprice { get; set; }
        /// <summary>
        /// 应收款
        /// </summary>
        public double Receivables { get; set; }
        /// <summary>
        /// 原本费用合计
        /// </summary>
        public double Sumprices { get; set; }
        /// <summary>
        ///  原本价格
        /// </summary>
        public double BePrice
        {
            get { return this._bePrice; }
            set { this._bePrice = value; }
        }
        /// <summary>
        ///  应收款项
        /// </summary>
        public double AmountPay { get; set; }
    }
}
