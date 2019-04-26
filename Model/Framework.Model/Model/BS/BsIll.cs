using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Data;

namespace Orm.Model
{
    /// <summary>
    /// BP治疗方案说明
    /// </summary>
    [Serializable]

    public partial class BsIll : BaseModel
    {
        string _name;
        string _patientGroup;
        string _treatment;
        string _detail;
        int _orderby;
        int _treatOrderby;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public BsIll()
        {
            MethodGroup = new List<string>();
        }
        
        /// <summary>
        /// 方法组(所有项目)
        /// </summary>
        public List<BsItemList> LstItemList { get; set; }

        /// <summary>
        /// 第几选择
        /// </summary>
        public List<string> MethodGroup { get; set; }

        /// <summary>
        /// 治疗原则排序
        /// </summary>
        public int TreatOrderby
        {
            get
            {
                return _treatOrderby;
            }
            set
            {
                _treatOrderby = value;
            }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

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
        /// 治疗原则
        /// </summary>
        public string Treatment
        {
            get
            {
                return _treatment;
            }
            set
            {
                _treatment = value;
            }
        }

        /// <summary>
        /// 小字说明
        /// </summary>
        public string Detail
        {
            get
            {
                return _detail;
            }
            set
            {
                _detail = value;
            }
        }

        /// <summary>
        /// 患者分组
        /// </summary>
        public string PatientGroup
        {
            get
            {
                return _patientGroup;
            }
            set
            {
                _patientGroup = value;
            }
        }
    }

}



