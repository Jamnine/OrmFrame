using System;
using System.Collections.Generic;

namespace XYHis.Model
{
    /// <summary>
    /// 收费项目表 - 实体类***********
    /// </summary>
   
    public partial class BsItem
    {

        private string _kcName;  //项目ID

        private string _tjLocationName; //行心云:体验科室名称

        private string _unitDiag;//门诊单位

        private int _classID; //类别ID（关联表BsTjItemClass的ID）

        private string _unitTakeName;//单位名称

        private bool _isVipChage; // 是否为会员



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
        public int ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string UnitTakeName
        {
            get { return _unitTakeName; }
            set { _unitTakeName = value; }
        }
        /// <summary>
        /// 修改操作人ID
        /// </summary>
        public int ModiOperId { get; set; }

        /// <summary>
        /// 项目医保编号
        /// </summary>
        public string MedicalCode { get; set; }

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
        public double Totality { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        public int Day { get; set; }

     

        /// <summary>
        /// 标本类型
        /// </summary>
        public int DrugFormId { get; set; }


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
        public int ItemTypeID { get; set; }
        public string CookType { get; set; }
        public int ItemNumber { get; set; }
        public List<CkItem> BsChangTjitem { get; set; }
        public object SelectGroup { get; set; }
    }
}


