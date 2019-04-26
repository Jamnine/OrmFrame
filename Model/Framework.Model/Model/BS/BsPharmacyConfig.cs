using System;
namespace Orm.Model
{
    /// <summary>
    /// 药房配置表
    /// </summary>
    public partial class BsPharmacyConfig : BaseModel
    {
        private string _intpharmacyNo; //药房编号
        private string _pharmacyName; //药房名称
        private string _pharmacyAdss;//药房地址
        private bool _isDefault;//是否默认
        private bool _isActive;//是否启用
        private int _hosPharmacyId;//hospitalID
        private int _pharmacytype;

        /// <summary>
        /// 药房编号
        /// </summary>
        public string PharmacyNo
        {
            get { return _intpharmacyNo; }
            set { _intpharmacyNo = value; }
        }
        /// <summary>
        /// 药房名称
        /// </summary>
        public string PharmacyName
        {
            get { return _pharmacyName; }
            set { _pharmacyName = value; }
        }
        /// <summary>
        /// 药房地址
        /// </summary>
        public string PharmacyAdss
        {
            get { return _pharmacyAdss; }
            set { _pharmacyAdss = value; }
        }
        /// <summary>
        /// 是否默认
        /// </summary>
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        /// <summary>
        /// hospitalID
        /// </summary>
        public int HosPharmacyId
        {
            get { return _hosPharmacyId; }
            set { _hosPharmacyId = value; }
        }
        /// <summary>
        /// 药房类型
        /// </summary>
        public int Pharmacytype
        {
            get { return _pharmacytype; }
            set { _pharmacytype = value; }
        }
    }
}
