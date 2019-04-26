using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人就诊详情
    /// </summary>
    [Serializable]
    public class uspPatCategory
    {
        /// <summary>
        /// 病人就诊详情
        /// </summary>
        public uspPatCategory()
        {
        }
        /// <summary>
        /// 医生ID
        /// </summary>
        public string DoctorID { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 挂号总人数
        /// </summary>
        public int PregisterCount { get; set; }

        /// <summary>
        /// 是否已收费
        /// </summary>
        public bool IsCharge { get; set; }

        /// <summary>
        /// 未缴费
        /// </summary>
        public string Unpaid { get; set; }

        /// <summary>
        /// 已缴费
        /// </summary>
        public string Prepaid { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        public string CordNo { get; set; }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 挂号员
        /// </summary>
        public string OperName { get; set; }

        /// <summary>
        /// 门诊机构ID
        /// </summary>
        public string LocationID { get; set; }

        /// <summary>
        /// 门诊机构名称
        /// </summary>
        public string LocationName { get;set;}

        /// <summary>
        /// 新病人人数
        /// </summary>
        public int NewPatCount { get; set; }

        /// <summary>
        /// 就诊ID
        /// </summary>
        public string MzregID { get; set; }

        /// <summary>
        /// 是否新病人
        /// </summary>
        public bool IsNewPat { get; set; }

        /// <summary>
        /// 就诊人数
        /// </summary>
        public int RegCount { get; set; }

        /// <summary>
        /// 就诊人次
        /// </summary>
        public int RegSum { get; set; }

        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊病人
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

    }
}
