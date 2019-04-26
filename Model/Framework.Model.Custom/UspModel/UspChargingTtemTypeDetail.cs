using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace Orm.Model.Custom.UspModel
namespace Orm.Model.Custom
{
    /// <summary>
    /// 收费项目的分类明细(数据分析中报表使用)
    /// </summary>
    [Serializable]
    public class UspChargingTtemTypeDetail
    {
        /// <summary>
        /// 医生名称
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// 病历号
        /// </summary>
        public string PatientCardNo { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 收费项目
        /// </summary>
        public string ChargingItem { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// 手机
        /// </summary>
        public string Cellphone { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }



        /// <summary>
        /// 护士
        /// </summary>
        public string Nurse { get; set; }

        /// <summary>
        /// /子分类
        /// </summary>
        public string Subclassification { get; set; }



        /// <summary>
        /// 收费单总备注
        /// </summary>
        public string ChargingTotalRemark { get; set; }

        /// <summary>
        /// 明细项中备注
        /// </summary>
        public string DetailItmeRemarl { get; set; }

        /// <summary>
        /// 项目类别
        /// </summary>
        public string ItmeType { get; set; }



        /// <summary>
        /// 患者来源
        /// </summary>
        public string PatSource { get; set; }

        /// <summary>
        /// 医生计费
        /// </summary>
        public string DoctorCharge { get; set; }
    }
}
