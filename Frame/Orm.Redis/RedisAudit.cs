using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Redis
{
    public class RedisAudit
    {
        //IP
        public string  ClientIP { get; set; }
        //服务名
        public string ServiceName { get; set; }
        //方法名
        public string MethodName { get; set; }
        //输入参数
        public string RequestArguments { get; set; }
        //结果
        public string Result { get; set; }
        //访问时间
        public string RequestTime { get; set; }
        //耗时
        public string ElapsedTime { get; set; }

    }
}
