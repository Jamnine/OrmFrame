

using System;
namespace Orm.Model
{
    /// <summary>
    /// 门诊操作日志表 - 实体类
    /// </summary>
    [Serializable]
    public partial class TrOuActionlog : BaseModel
    {
        private string _button;  //操作按钮

        private string _operId;  //操作人

        private DateTime _operTime;  //操作时间

        private string _hostName;  //客户端主机名

        private string _error;  //错误提示.

        private string _locationId;  //科室

        private string _mzRegId;  //病人ID

        private string _tableName;  //关键主表名,比如处方表,发票表,处方明细表。

        private string _pkId;  //关键主表ID

        private string _actionDesc;  //动作描述

        private int _HospitalID;  //

        private string _ui;

        private string _sql;

        private string _ip;



        /// <summary>
        /// 操作按钮
        /// </summary>
        public string Button
        {
            get { return _button; }
            set { _button = value; }
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 客户端主机名
        /// </summary>
        public string HostName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }

        /// <summary>
        /// 错误提示.
        /// </summary>
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 关键主表名,比如处方表,发票表,处方明细表。
        /// </summary>
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        /// <summary>
        /// 关键主表ID
        /// </summary>
        public string PkId
        {
            get { return _pkId; }
            set { _pkId = value; }
        }

        /// <summary>
        /// 动作描述
        /// </summary>
        public string ActionDesc
        {
            get { return _actionDesc; }
            set { _actionDesc = value; }
        }

        public string UI
        {
            get { return _ui; }
            set { _ui = value; }
        }

        public string SQL
        {
            get { return _sql; }
            set { _sql = value; }
        }

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
    }
}


