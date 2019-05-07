using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Toolkit;

namespace Orm.Client.Common
{
    public class CacheDownloadItems
    {
        public string FileType { get; set; }
        public int PatID { get; set; }
        public DownloadItem ItemInfo { get; set; }
    }
}
