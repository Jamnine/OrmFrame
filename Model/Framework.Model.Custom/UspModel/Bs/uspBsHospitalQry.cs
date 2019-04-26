using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{

    /// <summary>
    /// 诊所信息
    /// </summary>
    [Serializable]
    public class uspBsHospitalQry:BaseModel 
    {
          private string _code;        
        private string _name;        
        private string _areaId;        
        private string _pyCode;        
        private string _wbCode;        
        private int _orderBy;        
        private bool _isActive;        
        private double _area;        
        private int _farthest;        
        private string _address;        
        private string _phone;        
        private string _email;        
        private int _residentPopulation;        
        private int _tentPopulation;        
        private string _memo;        
        private int _iconIndex;        
        private DateTime _modiTime;        
        private string _modiOperId;        
        private string _yBCode;        
        private string _upCode;
        private string _userId; 
        private string _clinicLng="0";
        private string _clinicLat="0";
        private byte[] _logoIcon;
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public uspBsHospitalQry()
        {
        }

        /// <summary>
        /// 联系人id
        /// </summary>
        public string UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this._userId = value;
            }
        }

        /// <summary>
        /// 联系人
        /// </summary>
        public string UserName { get; set; }

         /// <summary>
        /// 注册登记号.
        /// </summary>
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code=value;
            }
        }        
        
        /// <summary>
        /// 分院名称.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name=value;
            }
        }        
        
        /// <summary>
        /// 地区编码.
        /// </summary>
        public string AreaId
        {
            get
            {
                return this._areaId;
            }
            set
            {
                this._areaId=value;
            }
        }        
        
        /// <summary>
        /// 拼音码.
        /// </summary>
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode=value;
            }
        }        
        
        /// <summary>
        /// 五笔码.
        /// </summary>
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode=value;
            }
        }        
        
        /// <summary>
        /// 显示顺序.
        /// </summary>
        public int OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy=value;
            }
        }        
        
        /// <summary>
        /// 有效标志.
        /// </summary>
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive=value;
            }
        }        
        
        /// <summary>
        /// 单位面积（平方公里）.
        /// </summary>
        public double Area
        {
            get
            {
                return this._area;
            }
            set
            {
                this._area=value;
            }
        }        
        
        /// <summary>
        /// 最远距离（公里）.
        /// </summary>
        public int Farthest
        {
            get
            {
                return this._farthest;
            }
            set
            {
                this._farthest=value;
            }
        }        
        
        /// <summary>
        /// 联系人地址.
        /// </summary>
        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address=value;
            }
        }        
        
        /// <summary>
        /// 联系人的电话.
        /// </summary>
        public string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this._phone=value;
            }
        }        
        
        /// <summary>
        /// 电子邮件.
        /// </summary>
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email=value;
            }
        }        
        
        /// <summary>
        /// 法定常住人口.
        /// </summary>
        public int ResidentPopulation
        {
            get
            {
                return this._residentPopulation;
            }
            set
            {
                this._residentPopulation=value;
            }
        }        
        
        /// <summary>
        /// 法定暂住人口.
        /// </summary>
        public int TentPopulation
        {
            get
            {
                return this._tentPopulation;
            }
            set
            {
                this._tentPopulation=value;
            }
        }        
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get
            {
                return this._memo;
            }
            set
            {
                this._memo=value;
            }
        }        
        
        /// <summary>
        /// 图标
        /// </summary>
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex=value;
            }
        }        
        
        /// <summary>
        /// 最后修改时间.
        /// </summary>
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime=value;
            }
        }        
        
        /// <summary>
        /// 最后修改人.
        /// </summary>
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId=value;
            }
        }        
        
        /// <summary>
        /// 医保码.
        /// </summary>
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode=value;
            }
        }        
        
        /// <summary>
        /// 上报码.
        /// </summary>
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode=value;
            }
        }

        /// <summary>
        /// 网站诊所地址的经度
        /// </summary>
        public string ClinicLng
        {
            get { return _clinicLng; }
            set {  _clinicLng = value; }
        }

        /// <summary>
        /// 网站诊所地址的纬度
        /// </summary>
        public string ClinicLat
        {
            get { return _clinicLat; }
            set { _clinicLat = value; }
        }
        /// <summary>
        /// 诊所LOGO图片二进制流
        /// </summary>
        public byte[] LogoIcon
        {
            get { return _logoIcon; }
            set { _logoIcon = value; }
        }
    }
}
