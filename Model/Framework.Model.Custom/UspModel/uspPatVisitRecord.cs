using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 病人就诊记录
    /// </summary>
    [Serializable]
    public class uspPatVisitRecord
    {
        public uspPatVisitRecord()
        {

        }

        /// <summary>
        /// 挂号信息
        /// </summary>
        public UspOuHosInfoQry PatOuHosInfo{ get; set; }

        private List<OuRecipeDtl> _lstOuRecipeDtl = new List<OuRecipeDtl>();
        /// <summary>
        /// 处方明细列表
        /// </summary>
        public List<OuRecipeDtl> OuRecipeDtlList
        {
            get { return _lstOuRecipeDtl; }
            set
            {
                _lstOuRecipeDtl = value; 
            }
        }
        private List<OuRecipeDtl> _examinationItemList = new List<OuRecipeDtl>();
        /// <summary>
        /// 检验项目列表
        /// </summary>
        public List<OuRecipeDtl> ExaminationItemList
        {
            get { return _examinationItemList; }
            set
            {
                _examinationItemList = value;
            }
        }
        private List<OuRecipeDtl> _checkItemList = new List<OuRecipeDtl>();
        /// <summary>
        /// 检查项目列表
        /// </summary>
        public List<OuRecipeDtl> CheckItemList
        {
            get { return _checkItemList; }
            set
            {
                _checkItemList = value;
            }
        }
        /// <summary>
        /// 中药项目
        /// </summary>
        public List<OuRecipeDtl> RecipeChinList { get; set; }

        /// <summary>
        /// 西药项目
        /// </summary>
        public List<OuRecipeDtl> RecipeWestList { get; set; }

        /// <summary>
        /// 治疗项目
        /// </summary>
        public List<OuRecipeDtl> RecipeCureList { get; set; }

        /// <summary>
        /// 检查项目
        /// </summary>
        public ObservableCollection<UspTjItemRecords> TjItemRecordChecklist { get; set; }

        /// <summary>
        /// 检验项目
        /// </summary>
        public ObservableCollection<UspTjItemRecords> TjItemRecordChemilist { get; set; }
    }
}
