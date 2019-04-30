using Orm.Framework.Services;
using Orm.IServices.ITestSercive;
using Orm.Model;
using System;
using System.Collections.Generic;

namespace Orm.Services.TestSercive
{
    public class TestDemoServices : DBServiceBase, ITestDemoServices
    {
        public List<BsHospital> GetLocHouseRoomName()
        {
            return this.GetAllList<BsHospital>();
        }

        public BsHospital GetLocHouseRoomName(string id)
        {
            return this.GetModelByGuid<BsHospital>(id);
        }
    }
}
