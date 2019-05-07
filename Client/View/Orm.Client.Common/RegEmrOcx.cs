using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    public class RegEmrOcx
    {

        [DllImport("EHREditor.ocx")]
        public static extern int DllRegisterServer();//注册时用
        [DllImport("EHREditor.ocx")]
        public static extern int DllUnregisterServer();//取消注册时用接下来就不难啦：
    }
}
