using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Framework.Services
{
   

    /// <summary>
    /// 抽象windows服务,统一托管到windows服务壳程序Orm.FrameWork.SvcHost
    /// </summary>
    public abstract class BaseService
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="servicename">windows服务的名称,安装服务时指定</param>
        /// <param name="name">svcHost承载的服务名，配置文件中指定</param>
        public BaseService(string servicename,string name)
        {
            ServiceName = servicename;
            Name = name;

            string SubKey = string.Format(@"SOFTWARE\Orm\{0}\{1}", ServiceName, name);
            string ItemName = "Id";
            RegisterHelper reg = new RegisterHelper(SubKey, RegDomain.LocalMachine);
            if (reg.IsRegeditKeyExist(ItemName))
            {
                Id = reg.ReadRegeditKey(ItemName).ToString();
            }
            else
            {
                Id = System.Guid.NewGuid().ToString();
                reg.WriteRegeditKey(ItemName, Id);
            }
        }

        /// <summary>
        /// windows服务的服务名
        /// </summary>
        public string ServiceName { get; private set; }

        /// <summary>
        /// svcHost承载的内部服务ID
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// svcHost承载的内部服务名
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 启动
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// 暂停
        /// </summary>
        public abstract void Pause();

        /// <summary>
        /// 继续
        /// </summary>
        public abstract void Continue();

        /// <summary>
        /// 停止
        /// </summary>
        public abstract void Stop();
    }
}
