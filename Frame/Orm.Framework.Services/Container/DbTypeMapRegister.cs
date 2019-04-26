using System.Collections.Generic;

namespace Orm.Framework.Services.Container
{
    public class DbTypeMapRegister : IRegisterDbTypeMap
    {
        private static readonly object mapLoker = new object();
        public void RegisterTypeMapFromConfigDB(List<TypeMap> mapList)
        {
            var config=ServiceTaker.GetService<IConfiger>();
            List<TypeMap> listTM = config.GetMulti<TypeMap>(typeof(TypeMap).FullName);

            foreach (var aMap in listTM)
            {
                lock (mapLoker)
                {
                    mapList.Remove(aMap);
                    mapList.Add(aMap);
                }
            }
        }
    }
}

