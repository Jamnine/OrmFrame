using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface IExcelWriter
    {
        ExcelExportResult Write(ExcelExporterParameter parameter);
    }
}
