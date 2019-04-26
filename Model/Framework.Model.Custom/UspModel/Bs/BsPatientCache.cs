using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{   
    /// <summary>
     ///病人相关信息接收类
     /// </summary>
    [Serializable]
    public partial class BsPatientCache: BaseModel
    {
        private string _cardNo="";
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo= value; }
        }
        private string _idCardNo = "";
        /// <summary>
        /// 身份证号.
        /// </summary>
        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }
     
        private string _name = "";
        /// <summary>
        /// 病人姓名.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _sex = "";
        /// <summary>
        /// 病人性别：M，F，O.
        /// </summary>
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        private string _mobile = "";
        /// <summary>
        /// 手机号码.
        /// </summary>
        public string Mobile
        {
            get
            {
                if (_mobile == null)
                {
                    _mobile = " ";
                }
                return this._mobile;
            }
            set { _mobile = value; }
        }

        private string _phone = "";

        /// <summary>
        /// 电话.
        /// </summary>
        public string Phone
        {
            get
            {
                if (_phone == null)
                {
                    _phone = " ";
                }
                return this._phone;
            }
            set { _phone = value; }
        }

        private DateTime _birthDate = DateTime.MinValue;
        /// <summary>
        /// 生日.
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _addressHome = "";
        /// <summary>
        /// 家庭地址.
        /// </summary>
        public string AddressHome
        {
            get
            {
                if (_addressHome == null)
                {
                    _addressHome = " ";
                }
                return this._addressHome;
            }
            set { _addressHome = value; }
        }

        private string _pyCode = "";
        /// <summary>
        /// 拼音简码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }
      

        private string _wbCode = "";
        /// <summary>
        /// 五笔简码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        } 
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }

        private string _webUserCode = "";
        /// <summary>
        /// 网站平台的病人唯一号
        /// </summary>
        public string WebUserCode
        {
            get
            {
                if (_webUserCode == null)
                {
                    _webUserCode = " ";
                }
                return this._webUserCode;
            }
            set { _webUserCode = value; }
        }

        private DateTime _lastRegTime = DateTime.MinValue;
        /// <summary>
        /// 最后就诊日期
        /// </summary>
        public DateTime LastRegTime
        {
            get { return _lastRegTime; }
            set { _lastRegTime = value; }
        }

        private string _doctorName = "";
        /// <summary>
        /// 首诊医生
        /// </summary>
        public string DoctorName
        {
            get
            {
                if (_doctorName == null)
                {
                    _doctorName = "";
                }
                return this._doctorName;
            }
            set { _doctorName = value; }
        }

        private string _vipCardNo="";

        /// <summary>
        ///会员卡号
        /// </summary>
        public string VipCardNo
        {
            get 
            {
                if (_vipCardNo == null)
                {
                    _vipCardNo = "";
                }
                return _vipCardNo; 
            }
            set { _vipCardNo = value; }
        }

        private string _vipLevel="";
        /// <summary>
        /// 会员等级
        /// </summary>
        public string VipLevel
        {
            get 
            {
                if (_vipLevel == null)
                {
                    _vipLevel = "";
                }
                return _vipLevel; 
            }
            set { _vipLevel = value; }
        }
 
        private string _vipCardID;
        /// <summary>
        /// 会员卡ID
        /// </summary>
        public string VipCardID
        {
            get { return _vipCardID; }
            set { _vipCardID = value; }
        }

      
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return this._isHideIllness; }
            set { this._isHideIllness = value; }
        }

        private string _locationid;
        /// <summary>
        /// 诊所id
        /// </summary>
        public string LocationId
        {
            get
            {
                return this._locationid;
            }
            set
            {
                this._locationid = value;
            }
        } 
        /// <summary>
        /// 是否会员
        /// </summary>
        public bool IsVip { get { return string.IsNullOrWhiteSpace(VipCardID)? false : true; } }

    }
}
