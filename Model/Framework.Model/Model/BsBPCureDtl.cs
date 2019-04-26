

using System;
using System.Collections.Generic;

namespace Orm.Model
{
    /// <summary>
    /// BP的治疗方案明细表(具体使用哪些项目) - 实体类
    /// </summary>
    [Serializable]
    public partial class BsBPCureDtl : BaseModel
    {

        private string _cureId;  //

        private string _bPItemId;  //

        private string _typeCode;  //

        private int _relationCode;  //

        private string _wayCode;  //

        private string _remark;  //

        private int _hospitalId;//医院ID

        /// <summary>
        /// 
        /// </summary>
        public string CureId
        {
            get { return _cureId; }
            set { _cureId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BPItemId
        {
            get { return _bPItemId; }
            set { _bPItemId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TypeCode
        {
            get { return _typeCode; }
            set { _typeCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int RelationCode
        {
            get { return _relationCode; }
            set { _relationCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string WayCode
        {
            get { return _wayCode; }
            set { _wayCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

        public string IitemName { get; set; }
        public bool IsSelect { get; set; }

        public List<BsItem> LstItem { get; set; }
    }
}


