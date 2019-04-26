using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 
    /// </summary>
   public class UspOuRecipeCache:BaseModel
    { 
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId {  get;set;   }

        /// <summary>
        /// 处方种类：1-西药；2-中药；3-检查/检验/治疗
        /// </summary>
        public int LsRepType {  get; set; }

        /// <summary>
        /// 处方号
        /// </summary>
        public string RecipeNum { get; set; }

        /// <summary>
        /// 处方日期
        /// </summary>
        public DateTime RecipeTime { get; set; }

        /// <summary>
        /// 关联到LOCATION表
        /// </summary>
        public string LocationId  {  get; set;  }

        /// <summary>
        /// 关联到DOCTOR表
        /// </summary>
        public string DoctorId {  get; set;  }

        /// <summary>
        /// 中药剂数
        /// </summary>
        public int HowMany { get; set; }

        /// <summary>
        /// 优先
        /// </summary>
        public bool IsPriority {  get; set;  }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo {get; set; }

        /// <summary>
        /// 是否挂起发药处方
        /// </summary>
        public bool IsPend { get; set; }

        /// <summary>
        /// 是否发药挂起
        /// </summary>
        public bool IsExecuted {get; set; }

        /// <summary>
        /// 病人ID，对应于Patient的Pat_Id
        /// </summary>
        public string PatId { get; set;}

        /// <summary>
        /// 是否已配药
        /// </summary>
        public bool IsDosage { get; set; }

        /// <summary>
        /// 配药人
        /// </summary>
        public string DosageOperId {  get; set; }

        /// <summary>
        /// 配药时间
        /// </summary>
        public DateTime DosageTime { get; set;}



        /// <summary>
        /// 煎药方法：1-代煎；2-自煎
        /// </summary>
        public int LsCookSelf  { get; set; }

        /// <summary>
        /// 是否已经打印
        /// </summary>
        public bool IsPrinted {get; set; }

        /// <summary>
        /// 摆药
        /// </summary>
        public bool IsPutDrug {get; set; }

        /// <summary>
        /// 代码临时使用
        /// </summary>
        public string TempStr { get; set; }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed {get; set; }

        /// <summary>
        /// 行心云:收费时间
        /// </summary>
        public DateTime OuChargeDate  {  get; set;}

        /// <summary>
        /// 行心云:金额
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        public int HospitalID{get; set;}
    }
}
