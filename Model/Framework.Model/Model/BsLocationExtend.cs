

using System;
using System.ComponentModel;

namespace Orm.Model
{
    /// <summary>
    /// 科室 - 实体类
    /// </summary>
    /// 
    public partial class BsLocation
    {

        private string _userName;  //唯一标识

        private String _specName;

        private string _provinceId;

        private string _regionId;

        private string _areaId;

        private bool _isRequiredMedicalCard;

        private string _address;

        private byte[] _certificate;

        private string _email;

        private string _phone;

        private byte[] _license;
        private string _cashierReport;


        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsAudit { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }


        /// <summary>
        /// 许可证
        /// </summary>
        public byte[] License
        {
            get { return _license; }
            set { _license = value; }
        }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string  EMail
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// //管理员手机号作为诊所默认联系号码
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        /// <summary>
        /// 证书
        /// </summary>
        public byte[] Certificate
        {
            get { return _certificate; }
            set { _certificate = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
			get { return _userName; }
			set { _userName = value;}
		}

        public bool IsLocationDiagSee { get; set; }


        public string SpecName
        {
            get
            {
                return this._specName;
            }
            set
            {
                this._specName = value;
            }
        }

        /// <summary>
        /// 省
        /// </summary>
     
        public string ProvinceId
        {
            get
            {
                return this._provinceId;
            }
            set
            {
                this._provinceId = value;
            }
        }

        /// <summary>
        /// 市/县
        /// </summary>
       
        public string RegionId
        {
            get
            {
                return this._regionId;
            }
            set
            {
                this._regionId = value;
            }
        }


        /// <summary>
        /// 区/村
        /// </summary>
        
        public string AreaId
        {
            get
            {
                return this._areaId;
            }
            set
            {
                this._areaId = value;
            }
        }
        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }



        public bool IsRequiredMedicalCard
        {
            get { return _isRequiredMedicalCard; }
            set { _isRequiredMedicalCard = value; }
        }

        /// <summary>
        /// 是否选中 用于单次操作
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// 专家名称
        /// </summary>
        public string BsSpeciaNameLists { get; set; }

        /// <summary>
        /// 专家ID
        /// </summary>
        public string BsSpeciaIDLists { get; set; }

        /// <summary>
        /// 收费模板打印设置
        /// </summary>
        public string CashierReport
        {
            get
            {
                return this._cashierReport;
            }
            set
            {
                this._cashierReport = value;
            }
        }
    }
}           


