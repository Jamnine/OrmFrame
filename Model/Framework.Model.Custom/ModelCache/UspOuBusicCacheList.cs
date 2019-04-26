using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspOuBusicCacheList:BaseModel
    {
        /// <summary>
        /// 挂号信息
        /// </summary>
        public List<UspOuHosInfoCache> OuHosInfo { set; get; }
        /// <summary>
        /// 门诊处方
        /// </summary>
        public List<UspOuRecipeCache> OuRecipe { set; get; }
        /// <summary>
        /// 门诊处方细单
        /// </summary>
        public List<UspRmOutDtlCache> OuRecipeDtl { set; get; }
        /// <summary>
        /// 门诊诊断
        /// </summary>
        public List<UspOuClincDiagCache> OuClincDiag { set; get; }
        /// <summary>
        /// 门诊电子病历
        /// </summary>
        public List<UspOuClinicFirstCache> OuClinicFirst { set; get; }
        /// <summary>
        /// 门诊发票
        /// </summary>
        public List<UspOuInvoiceCache> OuInvoice { set; get; }
        /// <summary>
        /// 门诊发票明细
        /// </summary>
        public List<UspOuInvoiceDtlCache> OuInvoiceDtl { set; get; }
        /// <summary>
        /// 门诊发药
        /// </summary>
        public List<UspRmOutCache> RmOut { set; get; }
        /// <summary>
        /// 门诊发药单明细
        /// </summary>
        public List<UspRmOutDtlCache> RmOutDtl { set; get; }
        /// <summary>
        /// 药房其它发药
        /// </summary>
        public List<UspRmOutOthCache> RmOutOth { set; get; }
        /// <summary>
        /// 药房其它发药明细
        /// </summary>
        public List<UspRmOutOthDtlCache> RmOutOthDtl { set; get; }
    }
}
