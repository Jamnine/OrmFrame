using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 提供一个类，用于对行类型转换等操作
    /// </summary>
    public interface IEmitService
    {
        M ConvertTo<N, M>(N entity)
            where N : class
            where M : class;
        List<M> ConvertTo<N, M>(List<N> list)
            where N : class
            where M : class;
        object Merge<M, N>(M target, N dataObj, string[] dataNeed, string[] alias, bool add)
            where M : class
            where N : class;
        List<object> Merge<M, N>(List<M> target, List<N> dataObj, string[] dataNeed, string[] alias, Func<M, string> selectTarget, Func<N, string> selectData, bool add)
            where M : class
            where N : class;
        List<object> Alias<N>(List<N> list, string[] original, string[] alias)
            where N : class;

        [Obsolete("该方法已过期, 请改为使用Orm.Utilities.Common.SetPropertyValue!", true)]
        void SetPropertyValue(object classInstance, string propertyName, object propertSetValue);

        [Obsolete("该方法已过期, 请改为使用Orm.Utilities.Common.GetPropertyValue!", true)]
        object GetPropertyValue(object classInstance, string propertyName);
        bool HasProperty(object target, string propertyName);


    }
}
