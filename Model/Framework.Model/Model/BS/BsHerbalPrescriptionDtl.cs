using System;

namespace Orm.Model
{
    /// <summary>
    /// 中药处方(辩证治疗/名家名医)细表
    /// </summary>
    [Serializable]
    public partial class BsHerbalPrescriptionDtl : BaseModel
    {
        string _itemName;
        /// <summary>
        /// 药品名称
        /// </summary>
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
            }
        }
        string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get
            {
                return _remark;
            }
            set
            {
                _remark = value;
            }
        }
        int _prescriptionType;
        /// <summary>
        /// 0基本处方 1加减法
        /// </summary>
        public int PrescriptionType
        {
            get
            {
                return _prescriptionType;
            }
            set
            {
                _prescriptionType = value;
            }
        }
        string _bsHerbalPrescriptionId;
        /// <summary>
        /// 中药处方主表id
        /// </summary>
        public string BsHerbalPrescriptionId
        {
            get
            {
                return _bsHerbalPrescriptionId;
            }
            set
            {
                _bsHerbalPrescriptionId = value;
            }
        }
        int _orderby;
        /// <summary>
        /// 排序
        /// </summary>
        public int Orderby
        {
            get
            {
                return _orderby;
            }
            set
            {
                _orderby = value;
            }
        }

        /// <summary>
        /// 当前是否选中
        /// </summary>
        public bool IsSelect { get; set; }
    }
}



