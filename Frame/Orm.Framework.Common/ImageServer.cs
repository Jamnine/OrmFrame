using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model.Custom;
using Orm.Model.Custom.UspModel;

namespace Orm.Framework.Common
{
    public class StationCheckData
    {
        public bool HasStation { get; set; }
        public string CheckBody { get; set; }
        public bool IsSupportChinese { get; set; }
        public Action<UspPsApplyReportByApplyNo, DateTime> OnSavedData { get; set; }
    }

    public class ImageServer
    {
       
    }
}
