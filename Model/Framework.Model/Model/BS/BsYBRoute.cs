using System;

namespace Orm.Model
{
    /// <summary>
    /// 连接对应医保规则
    /// </summary>
    [Serializable]
    public class BsYBRoute : BaseModel
    {
        private string _yBInterfaceName;
        private int _ybType;
        private string _ybCenterCode;
        private string _ybHosptailCode;
        private string _ybHospitalServer;
        private bool _isUpLoadCode;
        private bool _isActive = true;
        private int _operID;
        private DateTime _operTime;
        private string _yBUserCode;
        private string _yBPassword;
        /// <summary>
        /// 医保用户
        /// </summary>
        public string YBUserCode
        {
            get { return _yBUserCode; }
            set { _yBUserCode = value; }
        }


        /// <summary>
        /// 医密码
        /// </summary>
        public string YBPassword
        {
            get { return _yBPassword; }
            set { _yBPassword = value; }
        }


        /// <summary>
        /// 医保接口名称
        /// </summary>
        public string YBInterfaceName
        {
            get { return _yBInterfaceName; }
            set { _yBInterfaceName = value; }
        }
         

        /// <summary>
        /// 医保接口类型
        /// </summary>
        public int YbType
        {
            get { return _ybType; }
            set { _ybType = value; }
        }

        /// <summary>
        /// 中心编码
        /// </summary>
        public string YbCenterCode
        {
            get
            {
                return _ybCenterCode;
            }

            set
            {
                _ybCenterCode = value;
            }
        }

        /// <summary>
        /// 医疗机构编码
        /// </summary>
        public string YbHosptailCode
        {
            get
            {
                return _ybHosptailCode;
            }

            set
            {
                _ybHosptailCode = value;
            }
        }

        /// <summary>
        /// 中心服务地址
        /// </summary>
        public string YbHospitalServer
        {
            get
            {
                return _ybHospitalServer;
            }

            set
            {
                _ybHospitalServer = value;
            }
        }

        /// <summary>
        /// 是否使用上传码上传
        /// </summary>
        public bool IsUpLoadCode
        {
            get
            {
                return _isUpLoadCode;
            }

            set
            {
                _isUpLoadCode = value;
            }
        }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive
        {
            get
            {
                return _isActive;
            }

            set
            {
                _isActive = value;
            }
        }

        /// <summary>
        /// 操作人
        /// </summary>
        public int OperID
        {
            get
            {
                return _operID;
            }

            set
            {
                _operID = value;
            }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return _operTime;
            }

            set
            {
                _operTime = value;
            }
        }
    }
}
