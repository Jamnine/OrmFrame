using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using WebBridgeContract;
using System.Configuration;

namespace WebBridgeEndpoint
{
    public class ProxyBase
    {
        public TypeMap ApiTypeMap { get; set; }

        List<string> EventNameList = new List<string>();

        protected WebRequseter TheReQuseter = new WebRequseter();

        protected ProxyManager TheManager = new ProxyManager();

        protected IEventOC EventService
        {
            get
            {
                return ServiceTaker.GetRemoteService<IEventOC>();
            }
        }

        public string GetOneUrl()
        {
            Random rd=new Random();
            int id = rd.Next(0, ApiTypeMap.WebApiUrlList.Count);
            //return ApiTypeMap.WebApiUrlList[id];
            if (Environments.IISServerUrl !=string.Empty)
            {
                return Environments.IISServerUrl;
            }
             else
            {
                return ConfigurationManager.AppSettings["ServiceAddress"];
            }
        }
    }
}
