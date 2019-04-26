using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 通知服务，短信/邮件/站内信
    /// </summary>
    public interface INoticeService
    {
        /// <summary>
        /// 创建邮件信息
        /// </summary>
        /// <param name="email">邮件信息</param>
        /// <returns></returns>
        bool CreateEmail(EmailInfo email);

        /// <summary>
        /// 创建短信信息
        /// </summary>
        /// <param name="message">短信信息</param>
        /// <returns></returns>
        bool CreateMessage(MessageInfo message);
    }

    /// <summary>
    /// 邮件信息
    /// </summary>
    public class EmailInfo
    {
        /// <summary>
        /// 邮件类型编码
        /// </summary>
        public string TypeCode { get; set; }
        /// <summary>
        /// 收件人地址
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        public object DataSource { get; set; }
        /// <summary>
        /// 邮件标题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 优先级
        /// 0:Normal,
        /// 1:Low,
        /// 2:High
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public int Source { get; set; }

    }


    /// <summary>
    /// 邮件来源枚举
    /// </summary>
    public enum EmailSource
    {

        /// <summary>
        /// 1、客服
        /// </summary>
        Kefu = 1,

        /// <summary>
        /// 3、淘宝   康爱多大药房旗舰店
        /// </summary>
        Taobao = 3,
        /// <summary>
        /// 4、拍拍
        /// </summary>
        Paipai = 4,
        /// <summary>
        /// 5、818平台   818医药网
        /// </summary>
        Yiyao818 = 5,
        /// <summary>
        /// 7、药房网
        /// </summary>
        Yaofang = 7,
        /// <summary>
        /// 8、药城网
        /// </summary>
        Yaocheng = 8,
        /// <summary>
        /// 10、买药网
        /// </summary>
        Maiyao = 10,
        /// <summary>
        /// 11、360kad.cn   康爱多特药馆
        /// </summary>
        Kadcn = 11,
        /// <summary>
        /// 12、手机平台   康爱多手机商城
        /// </summary>
        mobile = 12
    }

    /// <summary>
    /// 邮件发送优先级
    /// </summary>
    public enum EmailPriority
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 低
        /// </summary>
        Low = 1,
        /// <summary>
        /// 高
        /// </summary>
        High = 2
    }

    /// <summary>
    /// 短信信息
    /// </summary>
    public class MessageInfo
    {
        /// <summary>
        /// 类型编码
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        public string ReceiverName { get; set; }
        /// <summary>
        /// 接收人联系电话
        /// </summary>
        public string ReceiverMobilePhone { get; set; }


        /// <summary>
        /// 数据源
        /// </summary>
        public object DataSource { get; set; }

        /// <summary>
        /// 优先级 0-255,1级最优
        /// </summary>
        public int Priority { get; set; }
    }
}
