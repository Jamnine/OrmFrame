//using ESPlus.Rapid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    public static class ChatEngine  
    {
        //public static IRapidPassiveEngine RapidPassiveEngine;

        public static bool IsActive
        {
            get
            { 
                //if (RapidPassiveEngine == null) return false;
                //if (RapidPassiveEngine.ChannelIsBusy) return false;
                //if (!RapidPassiveEngine.Connected) return false;
                return true;
            }
        }
    }
}
