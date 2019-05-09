using Orm.Model;
using System.Collections.Generic;

namespace Orm.IServices.ITestSercive
{
    public interface ITestDemoServices
    {
        List<BsHospital> GetLocHouseRoomName();

        BsHospital GetLocHouseRoomName(string id);
    }
}
