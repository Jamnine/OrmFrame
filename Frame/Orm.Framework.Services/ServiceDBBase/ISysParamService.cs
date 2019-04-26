using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;
using Orm.Model.EnumDefine;

namespace Orm.Framework.Services
{
    public interface ISysParamService
    {
        #region 系统参数
        T GetByName<T>(string name);

        T[] GetByName<T>(string name, ParamDelimiter delimiter);

        bool Contains<T>(string name, T value, ParamDelimiter delimiter);

        List<GblSetting> GetByNames(string[] names);

        List<GblSetting> GetByNames(IEnumerable<string> names);
        #endregion

    }
}
