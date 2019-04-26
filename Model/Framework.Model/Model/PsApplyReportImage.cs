using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class PsApplyReportImage : BaseModel
    {
        public PsApplyReportImage() { }

        #region 字段  Applyid, FileName, GUID, IsChecked, RptImage
        /// <summary>
        /// 
        /// </summary>	

        public string Applyid { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public string FileName { get; set; }

        /// <summary>
        ///  标识列 DbGenerated
        /// </summary>	

        public string GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public Boolean? IsChecked { get; set; }

        /// <summary>
        /// 
        /// </summary>	

        public Byte[] RptImage { get; set; }

        #endregion
    }
}
