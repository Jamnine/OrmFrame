using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public class Platform
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Menu
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }

        public string PlatformId { get; set; }

        public string ParentId { get; set; }

        /// <summary>
        /// WinForm / Web
        /// </summary>
        public string Type { get; set; }

        public string Url { get; set; }

        public List<Menu> Children { get; set; }
    }

    public class Element
    {
        public string ViewId { get; set; }

        public string ElementId { get; set; }

        public string ElementName { get; set; }

        public string ElementType { get; set; }

        public string ElementCode { get; set; }

        public bool Visible { get; set; }

        public bool ReadOnly { get; set; }
    }
    public enum ResourceType
    {
        VIEW=1,

        API=2,

        CUSTOM=9,
    }

    /// <summary>
    /// 权限接口
    /// </summary>
    public interface IPermission
    {
        /// <summary>
        /// 判断用户是否具有指定动作的调用权限
        /// </summary>
        /// <param name="user"></param>
        /// <param name="reskey"></param>
        /// <returns></returns>
        bool Authorized(string user, string key ,ResourceType type);

        /// <summary>
        /// 返回用户在特定数据资源上的限制条件集
        /// </summary>
        /// <param name="user"></param>
        /// <param name="reskey"></param>
        /// <returns></returns>
        //List<WhereField> DataAuthorized(string user, string key);

        /// <summary>
        /// 返回用户特定页面上有权限的UI元素集合
        /// </summary>
        /// <param name="user"></param>
        /// <param name="viewid"></param>
        /// <returns></returns>
        List<Element> ViewAuthorized(string user,string viewcode);

        /// <summary>
        /// 返回用户某个系统上有权限的菜单集合
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sysid"></param>
        /// <returns></returns>
        List<Menu> MenuAuthorized(string user, string syscode);

        /// <summary>
        /// 返回用户有权限的系统集合
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Platform> SystemAuthorized(string user);
    }
}
