using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 组合的搜索条件
    /// </summary>
    [Serializable]
    public class PMDocumentQuery
    {
        private string _invoNo ="";
        /// <summary>
        /// 搜索的单据号
        /// </summary>
        public string InvoNo
        {
            get { return _invoNo; }
            set { _invoNo = value; }
        }

        private string _operId;
        /// <summary>
        /// 搜索的收款人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        private DateTime _startTime=DateTime.Now;
        /// <summary>
        /// 搜索的开始时间
        /// </summary>
        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        private DateTime _endTime=DateTime.Now;
        /// <summary>
        /// 搜索的结束时间
        /// </summary>
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        private string _patName ="";
        /// <summary>
        /// 搜索的病人姓名
        /// </summary>
        public string PatName
        {
            get { return _patName; }
            set { _patName = value; }
        }

        private int _HospitalID;
        /// <summary>
        /// 搜索的分院名称
        /// </summary>
        public int  HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }

        private string _hospitalGuid;
        /// <summary>
        /// 搜索的分院名称
        /// </summary>
        public string HospitalGuid
        {
            get { return _hospitalGuid; }
            set { _hospitalGuid = value; }
        }

        private string _doctorId;
        /// <summary>
        /// 搜索的医生姓名
        /// </summary>
        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        private string _payWay=string.Empty;
        /// <summary>
        /// 搜索的收款方式
        /// </summary>
        public string PayWay
        {
            get { return _payWay; }
            set { _payWay = value; }
        }

    }
}
