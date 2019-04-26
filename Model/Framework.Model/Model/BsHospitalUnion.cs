

using System; 

namespace Orm.Model
{
    /// <summary>
    /// 行心云:医联体管理 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsHospitalUnion : BaseModel
    {
         
        private string _provinceId;  //省ID

        private string _regionId;  //市ID

        private string _areaId;  //区ID

        private string _address;  //详细地址

        private string _name;  //名称

        private string _adminId;  //管理员ID

        private bool _isParent;  //是否父级

        private string _parentId;  //父级ID

        private bool _isActive;  //是否有效

        private string _operId;  //操作人ID

        private DateTime _operLastDate;  //最后的操作时间

        private int _HospitalID;  //
         
        /// <summary>
        /// 省ID
        /// </summary>
        public string ProvinceId
        {
            get { return _provinceId; }
            set { _provinceId = value; }
        }

        /// <summary>
        /// 市ID
        /// </summary>
        public string RegionId
        {
            get { return _regionId; }
            set { _regionId = value; }
        }

        /// <summary>
        /// 区ID
        /// </summary>
        public string AreaId
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
        public string AdminId
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
        public string ParentId
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
        public string OperId
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

    
         
        
    }
}


