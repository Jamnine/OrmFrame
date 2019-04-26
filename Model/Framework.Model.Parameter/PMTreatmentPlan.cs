using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Model.Custom;

namespace Orm.Model.Parameter
{
    /// <summary>
    /// 门诊就诊保存所需要的参数
    /// </summary>
    [Serializable]
    public class PMTreatmentPlan
    {
        public PMTreatmentPlan()
        { }
        /// <summary>
        /// 病历信息
        /// </summary>
        public OuClinicFirst ademr  = new OuClinicFirst();
        /// <summary>
        /// 主表
        /// </summary>
        public List<OuRecipe> RecipeList = new List<OuRecipe>();

        /// <summary>
        /// 中药主表
        /// </summary>
        public List<OuRecipeChin> RecipeChinList = new List<OuRecipeChin>();

        /// <summary>
        /// 删除主表ID
        /// </summary>
        public List<string> DelRecipeIDs = new List<string>();

        /// <summary>
        /// 删除中药总表
        /// </summary>
        public List<string> DelRecipeChinIDs = new List<string>();

        /// <summary>
        /// 删除细表ID
        /// </summary>
        public List<string> DelRecipeDtlIDs = new List<string>();

        /// <summary>
        /// 删除护士执行ID
        /// </summary>
        public List<string> DelExecuteIDs = new List<string>();

        /// <summary>
        /// 预约挂号删除细表ID
        /// </summary>
        public List<KeyValuePair<string, string>> DelRecipeDtlIDAndItemID = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// 删除
        /// </summary>
        public List<string> DelTjSummaryIDs = new List<string>();

        /// <summary>
        /// 细表
        /// </summary>
        public List<OuRecipeDtl> RecipeDtlList = new List<OuRecipeDtl>();

        /// <summary>
        /// 护士执行单
        /// </summary>
        public List<OuExecute> ExecuteList = new List<OuExecute>();

        /// <summary>
        /// 体检小结
        /// </summary>
        public List<CkSummary> TjSummaryList = new List<CkSummary>();

        #region 体检记录
        /// <summary>
        /// 体检记录
        /// </summary>
        public List<TjItemRecord> TjRecordList = new List<TjItemRecord>();
        /// <summary>
        /// 体检记录图片
        /// </summary>
        public List<ToothImage> TjRecordToothImage = new List<ToothImage>();
        /// <summary>
        /// 体检项目ID
        /// </summary>
        public string TjItemID;
        #endregion

        /// <summary>
        /// 病人信息+就诊信息
        /// </summary>
        public Custom.uspHisOuPatientQry CurrentPatient { get; set; }

        /// <summary>
        /// 收费信息划价
        /// </summary>
        public List<PatPricereCords> PatPricereCordsList = new List<PatPricereCords>();

        /// <summary>
        /// 就诊信息列表
        /// </summary>
        public List<uspHisOuPatientQry> OuHosInfoList = new List<uspHisOuPatientQry>();
        /// <summary>
        /// 医嘱信息列表
        /// </summary>
        public List<OuRecipeDtl> lstOuRecipeDtl = new List<OuRecipeDtl>();

        #region 健康体检
        public PMHealthCheckPlan HealthCheckPlan = new PMHealthCheckPlan();

        /// <summary>
        /// 当前操作人ID
        /// </summary>
        public string OperatorID;

        //门诊id
        public int HospitalID;
        #endregion
    }
}
