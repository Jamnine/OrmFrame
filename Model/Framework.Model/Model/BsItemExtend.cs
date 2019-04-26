using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// 收费项目表 - 实体类
    /// </summary>
   
    public partial class BsItem
    {
        private string _mzFeetyType;  //药品类型

        private string _kcName;  //项目ID

        private string _tjLocationName; //行心云:体验科室名称

        private string _unitDiag;//门诊单位

        private string _classID; //类别ID（关联表BsTjItemClass的ID）

        private string _unitTakeName;//单位名称

        private bool _isVipChage; // 是否为会员

        private int _days = 1;
        private double _totality = 1;

        private int _pharmacyRatio;

        private string _bsBusinessCityTypeId; //商城类型ID

        private string _ratioUnitNmae1;
        private string _ratioUnitNmae2;
        private double _drugRatio;
        public string RatioUnitNmae1
        {
            get { return this._ratioUnitNmae1; }
            set { this._ratioUnitNmae1 = value; }
        }
        public string RatioUnitNmae2
        {
            get { return this._ratioUnitNmae2; }
            set { this._ratioUnitNmae2 = value; }
        }
        public double DrugRatio
        {
            get { return this._drugRatio; }
            set { this._drugRatio = value; }
        }



        /// <summary>
        /// 商城类型ID
        /// </summary>
        public string BsBusinessCityTypeId
        {
            get { return this._bsBusinessCityTypeId; }
            set { this._bsBusinessCityTypeId = value; }
        }

        /// <summary>
        /// 与药房剂量比例
        /// </summary>
        public int PharmacyRatio
        {
            get { return this._pharmacyRatio; }
            set { this._pharmacyRatio = value; }
        }

        /// <summary>
        /// 库存名字
        /// </summary>
        public string KcName
        {
            get { return _kcName; }
            set { _kcName = value; }
        }

        /// <summary>
        /// 行心云:体验科室名称
        /// </summary>
        public string TjLocationName
        {
            get { return _tjLocationName; }
            set { _tjLocationName = value; }
        }

        /// <summary>
        /// 门诊单位
        /// </summary>
        public string UnitDiag
        {
            get { return _unitDiag; }
            set { _unitDiag = value; }
        }

        /// <summary>
        /// 类别ID（关联表BsTjItemClass的ID）
        /// </summary>
        public string ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }
        public string UnitDiagName { get; set; }
        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitTakeName
        {
            get { return _unitTakeName; }
            set { _unitTakeName = value; }
        }
        public string _medicalCode = string.Empty;

        /// <summary>
        /// 单位名称
        /// </summary>
        public string MedicalCode
        {
            get { return _medicalCode; }
            set { _medicalCode = value; }
        }
        /// <summary>
        /// 修改操作人ID
        /// </summary>
        public string ModiOperId { get; set; }

        /// <summary>
        /// 是否检查
        /// </summary>
        public bool IsCheck { get; set; }

    

        /// <summary>
        /// 是否BP项目
        /// </summary>
        public bool IsBP { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        public double Totality
        {
            get { return _totality; }
            set { _totality = value; }
        }

        /// <summary>
        /// 天数
        /// </summary>
        public int Day
        {
            get { return this._days; }
            set { this._days = value; }
        }

        /// <summary>
        /// 是否会员优惠项目
        /// </summary>
        public bool IsVipChage
        {
            get { return _isVipChage; }
            set { this._isVipChage = value; }
        }


        /// <summary>
        /// 标本类型
        /// </summary>
        public string _drugFormId = string.Empty;

        public string DrugFormId
        {
            get { return this._drugFormId; }
            set { this._drugFormId = value; }
        }

        
        /// <summary>
        ///  药品类型编码
        /// </summary>
        public string MzFeetyType
        {
            get { return this._mzFeetyType; }
            set { this._mzFeetyType = value; }
        }


        /// <summary>
        /// 是否会员优惠项目
        /// </summary>
        public bool IsSkinTest { get; set; }

        /// <summary> 
        /// 是否抗菌药
        /// </summary>
        public bool IsAntibiosis { get; set; }

        /// <summary>
        /// 是否麻醉药
        /// </summary>
        public bool IsNarcotic { get; set; }

        /// <summary>
        /// 项目类型ID
        /// </summary>
        public string ItemTypeID { get; set; }
        public string CookType { get; set; }
        public int ItemNumber { get; set; }
        public List<CkItem> BsChangTjitem { get; set; }
        public object SelectGroup { get; set; }
        public string ModiOperName { get; set; }
        public string XdRpId { get; set; }
 
    }
}


