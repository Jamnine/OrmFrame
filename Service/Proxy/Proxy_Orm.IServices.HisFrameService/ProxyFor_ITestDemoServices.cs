using Orm.IServices.ITestSercive;
using Orm.Model;
using System;
using System.Collections.Generic;
using WebBridgeEndpoint;

namespace Proxy_Orm.IServices.ITestSercive
{
    public class ProxyFor_ITestDemoServices : ProxyBase, ITestDemoServices
    {
        public List<BsHospital> GetLocHouseRoomName()
        {
            List<Object> ParamList = new List<Object>();
            string[] TypeArgs = null;
            return (List<BsHospital>)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.IServices.ITestSercive.ITestDemoServices", "GetLocHouseRoomName", ParamList, TypeArgs, GetOneUrl());
        }

        public BsHospital GetLocHouseRoomName(string id)
        {
            List<Object> ParamList = new List<Object>
            {
                id
            };
            string[] TypeArgs = null;
            return (BsHospital)TheReQuseter.RequseteWeb(ApiTypeMap.MapConfigKey, "Orm.IServices.ITestSercive.ITestDemoServices", "GetLocHouseRoomName", ParamList, TypeArgs, GetOneUrl());
        }
    }
}
