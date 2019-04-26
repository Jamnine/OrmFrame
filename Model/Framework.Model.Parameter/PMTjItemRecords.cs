using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Parameter 
{

    /// <summary>
    /// 体检结果接受类
    /// </summary>
    [Serializable]
    
    public class PMTjItemRecords:BaseModel
    {
        /// <summary>  
        /// 标准样品id 
        /// </summary>  
        public string QCstandId { get; set; }
        /// <summary>  
        ///  就诊id 
        /// </summary>  
        public string MzRegId { get; set; }

        /// <summary>
        /// 体检项目ID
        /// </summary>
        public string BsTjItemId { get; set; }


        /// <summary>
        /// 数据类型 N 数值型 C字符型  
        /// </summary>
        public string DataType { get; set; }

        /// <summary>  
        ///  体检项目编码 
        /// </summary>  
        public string TjItemCode { get; set; }
        /// <summary>  
        /// 组合项目编码  
        /// </summary>  
        public string GroupItemCode { get; set; }

        /// <summary>  
        /// 项目结果  
        /// </summary>  
        public string TjResult { get; set; }

        /// <summary>  
        /// 该项目上次体检结果  
        /// </summary>  
        public string LastTjResult { get; set; }

        /// <summary>  
        /// 是否异常  
        /// </summary>  
        public bool IsAbNormal { get; set; }

        /// <summary>  
        /// 异常提示  
        /// </summary>  
        public string AbnormalTips { get; set; }

 
        /// <summary>  
        ///  是否组合 
        /// </summary>  
        public bool IsGroup { get; set; }

        /// <summary>  
        /// 检查医生  
        /// </summary>  
        public string DoctorId { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID { get; set; }

        /// <summary>  
        /// 是否收费  
        /// </summary>  
        public bool IsCharge { get; set; }

        /// <summary>  
        ///  是否小结 
        /// </summary>  
        public bool IsOver { get; set; }

        /// <summary>  
        /// 操作员ID
        /// </summary>  
        public string OperId { get; set; }

        /// <summary>  
        ///   操作时间
        /// </summary>  
        public DateTime OperTime { get; set; }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }
        /// <summary>
        /// 费用明细ID
        /// </summary>
        public string OuRecipeDtlID { get; set; }

        /// <summary>  
        ///   收费项目ID
        /// </summary>  
        public string ItemId { get; set; }

        /// <summary>  
        /// 项目对应仪器接口
        /// </summary>  
        public int ItemInterface { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public string Commentary { get; set; }

        /// <summary>
        /// 检测说明
        /// </summary>
        public string TestIllustration { get; set; }
        /// <summary>  
        ///  常见问题 
        /// </summary>  
        public string CommonProblem { get; set; }

        /// <summary>
        /// 标本类型
        /// </summary>
        public string SourceId { get; set; }


        /// <summary>
        /// 样本性状
        /// </summary>
        public string Properties { get; set; }

        /// <summary>  
        /// 仪器流水号 
        /// </summary>  
        public int SampleNum { get; set; }

        /// <summary>  
        /// 仪器id
        /// </summary>  
        public string CKMId { get; set; }

        /// <summary>  
        /// 是否传回 
        /// </summary>  
        public bool SendStatus { get; set; }

        /// <summary>  
        /// QC试剂批号
        /// </summary>  
        public string QCReagentlot { get; set; }

        /// <summary>  
        ///  批准医生查看检验报告
        /// </summary>  
        public bool IsApproval { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }
        /// <summary>  
        /// 保存失控结果
        /// </summary>  
        public string TjResultCopy { get; set; }

        /// <summary>  
        ///  批准时间
        /// </summary>  
        public DateTime ApprovalTime { get; set; }

        /// <summary>  
        ///   项目名称
        /// </summary>  
        public string ItemName { get; set; }

        /// <summary>
        /// 组合项目名称
        /// </summary>
        public string GroupTjName { get; set; }


        /// <summary>  
        /// 项目单位  
        /// </summary>  
        public string ItemUnit { get; set; }

        /// <summary>
        /// 参考范围+指项
        /// </summary>
        public string ReferAll { get; set; }

        /// <summary>
        /// 指项
        /// </summary>
        public double ReferTop { get; set; }

        /// <summary>
        /// 参考范围
        /// </summary>
        public double ReferLow { get; set; }


        /// <summary>  
        /// 偏高提示  
        /// </summary>  
        public string ReferTopT { get; set; }

        /// <summary>  
        /// 偏低提示  
        /// </summary>  
        public string ReferLowT { get; set; }

        /// <summary>  
        /// 极高危提示  
        /// </summary>  
        public string VeryTopT { get; set; }

        /// <summary>  
        /// 极低危提示  
        /// </summary>  
        public string VeryLowT { get; set; }

        /// <summary>
        /// 参考类型
        /// </summary>
        public string ReferType { get; set; }
    }
}
