

using System; 

namespace XYHis.Model
{
    /// <summary>
    /// 行心云:医联体管理 - 实体类***********
    /// </summary>
    [Serializable]
    public partial class BsHospitalUnion : BaseModel
    {

        private double _iD;  //

        private double _provinceId;  //省ID

        private double _regionId;  //市ID

        private double _areaId;  //区ID

        private string _address;  //详细地址

        private string _name;  //名称

        private double _adminId;  //管理员ID

        private bool _isParent;  //是否父级

        private double _parentId;  //父级ID

        private bool _isActive;  //是否有效

        private double _operId;  //操作人ID

        private DateTime _operLastDate;  //最后的操作时间

        private int _hospitalId;  //



        /// <summary>
        /// 
        /// </summary>
        public double ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        /// <summary>
        /// 省ID
        /// </summary>
        public double ProvinceId
        {
            get { return _provinceId; }
            set { _provinceId = value; }
        }

        /// <summary>
        /// 市ID
        /// </summary>
        public double RegionId
        {
            get { return _regionId; }
            set { _regionId = value; }
        }

        /// <summary>
        /// 区ID
        /// </summary>
        public double AreaId
        {
            get { return _areaId; }
            set { _areaId = value; }
        }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 管理员ID
        /// </summary>
        public double AdminId
        {
            get { return _adminId; }
            set { _adminId = value; }
        }

        /// <summary>
        /// 是否父级
        /// </summary>
        public bool IsParent
        {
            get { return _isParent; }
            set { _isParent = value; }
        }

        /// <summary>
        /// 父级ID
        /// </summary>
        public double ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// 操作人ID
        /// </summary>
        public double OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 最后的操作时间
        /// </summary>
        public DateTime OperLastDate
        {
            get { return _operLastDate; }
            set { _operLastDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }
         
        
    }
}


