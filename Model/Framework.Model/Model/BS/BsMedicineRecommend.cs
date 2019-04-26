using System;

namespace Orm.Model
{
    /// <summary>
    /// 中成药推荐的关系表
    /// (对应关系具体为 某个疾病的某个患者分组 对应 某个诊所的 中成药项目名称+厂商id+药品规格)
    /// </summary>
    [Serializable]
  
    public partial class BsMedicineRecommend : BaseModel
    {
        string _illName;        
        string _patientGroup = string.Empty;
        string _itemName;
        string _locationId;
        string _bsManufacturerID;
        string _indication;
        string _references;
        string _spec;
        string _phone;

        /// <summary>
        /// 疾病名字
        /// </summary>
        public string IllName
        {
            get
            {
                return _illName;
            }
            set
            {
                _illName = value;
            }
        }

        /// <summary>
        /// 患者分组
        /// </summary>
        public string PatientGroup
        {
            get { return _patientGroup; }
            set { _patientGroup = value; }
        }

        /// <summary>
        /// 生产厂商ID
        /// </summary>
        public string BsManufacturerID {
            get { return _bsManufacturerID; }
            set { _bsManufacturerID = value; }
        } 

        /// <summary>
        /// 诊所id
        /// </summary>
        public string LocationID
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 中成药项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        /// <summary>
        /// 适应症
        /// </summary>
        public string Indication
        {
            get { return _indication; }
            set { _indication = value; }
        }

        /// <summary>
        /// 参考文献
        /// </summary>
        public string References
        {
            get { return _references; }
            set { _references = value; }
        }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// 中成药项目
        /// </summary>
        public BsItem Item { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// 是否已维护
        /// </summary>
        public bool IsMaintain { get; set; }
    }
}



