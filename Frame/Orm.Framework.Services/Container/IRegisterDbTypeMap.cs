using System.Collections.Generic;

namespace Orm.Framework.Services
{
    public interface  IRegisterDbTypeMap
    {
        void RegisterTypeMapFromConfigDB(List<TypeMap> map);
    }
}
