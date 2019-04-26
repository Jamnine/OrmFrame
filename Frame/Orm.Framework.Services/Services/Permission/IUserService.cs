using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public sealed class Company
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ParentId { get; set; }

        public List<Company> Children { get; set; }
    }

    public sealed class Department
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ParentId { get; set; }

        public List<Department> Children { get; set; }
    }

    public sealed class User
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        public string LoginName { get; set; }
    }

    public interface IUserService
    {
        string kadCompanyId { get; }

        List<User> GetUserList(string userName);

        User GetUser(string loginName);

        List<User> GetUsers(string departmentId);

        List<User> GetAllUsers(string companyId);

        Company GetCompany(string companyId);

        List<Company> GetCompanys();

        Department GetDepartment(string departmentId);

        List<Department> GetDepartments(string companyId);
    }
}
