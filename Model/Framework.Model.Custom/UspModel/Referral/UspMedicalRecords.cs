using System;
using System.Collections.Generic;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人就诊记录 处方明细 体检情况 转诊文件
    /// </summary>
    [Serializable]
    public class UspMedicalRecords
    {
        /// <summary>
        /// 病人就诊记录 处方明细 体检情况 转诊文件
        /// </summary>
        public UspMedicalRecords() { }

        /// <summary>
        /// 病人基本信息
        /// </summary>
         public BsPatient BsPatientInfo { get; set; }

        /// <summary>
        /// 挂号信息/病历信息
        /// </summary>
        public List<UspOuHosInfoQry> PatOuHosInfo { get; set; }
        
        /// <summary>
        /// 处方明细列表
        /// </summary>
        public List<UspOuRecipeDtl> LstUspOuRecipeDtl { get; set; }
          
        /// <summary>
        /// 检验检查结果
        /// </summary>
        public List<CkLabResult> CkLabResultlist { get; set; }

        /// <summary>
        /// 诊断信息
        /// </summary>
        public List<OuClincDiag> OuClincDiagInfo { get; set; }
    }
}
