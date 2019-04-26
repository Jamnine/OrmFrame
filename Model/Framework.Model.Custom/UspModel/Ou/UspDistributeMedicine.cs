using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 处方信息组合
    /// </summary>
    [Serializable]
    public class UspDistributeMedicine
    {
      
        public UspDistributeMedicine() {
            
            OuRecipeDtlList = new List<OuRecipeDtl>();
        }
        /// <summary>
        /// 处方信息
        /// </summary>
        public OuRecipe RecipeInfo { get; set; }

        /// <summary>
        /// 中药处方用法 
        /// </summary>
        public OuRecipeChin RecipeChinInfo { get; set; }
        /// <summary>
        /// 处方明细
        /// </summary>
        public List<OuRecipeDtl> OuRecipeDtlList { get; set; }

        ///// <summary>
        ///// 每剂金额
        ///// </summary>
        //public double PerTotalAmount
        //{
        //    get
        //    { 
        //        return OuRecipeDtlList.Sum(t => t.Amount); 
        //    }
        //}
        /// <summary>
        /// 总金额
        /// </summary>
        //public double TotalAmount 
        //{
        //    get 
        //    {
        //        if (this.RecipeInfo != null)
        //        {
        //            return this.RecipeInfo.HowMany * OuRecipeDtlList.Sum(t => t.Amount);
        //        }
        //        else if ( OuRecipeDtlList.FirstOrDefault() != null)
        //        {
        //              if (OuRecipeDtlList.FirstOrDefault().LsRepType ==5)
        //                  return OuRecipeDtlList.Sum(t => t.Amount);
        //              else return 0.00;
        //        }
        //        else
        //            return 0.00;
        //    } 
        //}
    }
}
