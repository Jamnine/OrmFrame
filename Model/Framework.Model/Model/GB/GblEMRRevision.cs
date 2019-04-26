using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class GblEMRRevision : BaseModel
    {
        /// <summary>
        /// 电子病人修改记录表 构造函数
        /// </summary>
        public GblEMRRevision()
        {
        }

        #region 字段  CatalogId, HospId, InEmrId, Revision-修改记录

        public string GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        public string CatalogId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        public string HospId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        public string InEmrId { get; set; }

        /// <summary>
        /// 修改记录
        /// </summary>	
        public string Revision { get; set; }
        #endregion
    }
}
