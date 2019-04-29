using System;
using System.Collections;


namespace Orm.Utilities
{
    /// <summary>
    /// Summary description for Errors.
    /// </summary>
    /// <remarks>by Simon 2006-1-3</remarks>
    public class Errors
    {
        public const int SUCCESS = 1;
        /// <summary>
        /// 系统错误,不明原因
        /// </summary>
        public const int ERROR_Authorize_FAILED = -1000;
        /// <summary>
        /// 审核错误
        /// </summary>
		public const int ERROR_FAILD = -1;
        /// <summary>
        /// 密码不符合规则
        /// </summary>
        public const int ERROR_PASSWORD_FAIL = -5;
        /// <summary>
        /// 是否出现重复
        /// </summary>
        public const int ERROR_SQL_DUPLICATE = -20;
        /// <summary>
        /// Email已经被注册过
        /// </summary>
        public const int ERROR_EMAIL_DUPLICATE = -25;
        /// <summary>
        /// 用户名不能包含特殊字符
        /// </summary>
        public const int ERROR_INVALID_USERNAME = -30;
        /// <summary>
        /// 不明SQL错误
        /// </summary>
        public const int ERROR_SQL_FAILD = -100;
        /// <summary>
        /// 删除失败
        /// </summary>
        public const int ERROR_DELETE_FAILED = -200;
        /// <summary>
        /// 删除时有子节点
        /// </summary>
        public const int ERROR_DELETE_HASCHILD = -300;
        /// <summary>
        /// 参数无效
        /// </summary>
        public const int ERROR_PARAMETER_INVALID = -400;
        /// <summary>
        /// SQL外键引用错误
        /// </summary>
        public const int ERROR_SQL_REFERENCE = -500;
        /// <summary>
        /// 无效对象
        /// </summary>
        public const int ERROR_SQL_INVALIDOBJECT = -600;

        /// <summary>
        /// 删除类别时使用，提示用户该类别不允许删除
        /// </summary>
        public const int ERROR_DELETE_NOTHING = -700;
        /// <summary>
        /// 配置节不合法，请重新设置
        /// </summary>
        public const int ERROR_ItemTemplateConfigError = -800;

        /// <summary>
        /// 模板下有属性
        /// </summary>
        public const int ERROR_TemplateHasAttributes = -900;

        /// <summary>
        /// 操作的集合记录数为0
        /// </summary>
        public const int OPERATOR_LISTCOUNT_ZERO = 222;
        /// <summary>
        /// 模板为空
        /// </summary>
        public const int TEMPLATE_NULL = -2000;
        /// <summary>
        /// 模板格式无效
        /// </summary>
        public const int TEMPLATE_INVALID = -2100;
        /// <summary>
        /// 模板没有子模板
        /// </summary>
        public const int TEMPLATE_NONEITEM = -2200;

        #region private static int GetSQLExceptionCode(System.Data.SqlClient.SqlException ex)
        /// <summary>
        /// 捕捉SQL Exception
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static int GetSQLExceptionCode(System.Data.SqlClient.SqlException ex)
        {
            if (ex == null) return ERROR_SQL_FAILD;
            Hashtable ht = new Hashtable();
            ht.Add(547, ERROR_SQL_REFERENCE);
            ht.Add(208, ERROR_SQL_INVALIDOBJECT);
            if (ht[ex.Number] == null) return ERROR_SQL_FAILD;
            return Int32.Parse(ht[ex.Number].ToString());
        }
        #endregion

        #region private static int GetSystemExceptionCode(System.Exception ex)
        //捕捉System Exception
        private static int GetSystemExceptionCode(System.Exception ex)
        {
            return ERROR_FAILD;
        }
        #endregion

        #region public static int GetExceptionCode(System.Exception ex)
        /// <summary>
        /// 返回Exception Code
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static int GetExceptionCode(System.Exception ex)
        {

            System.Type type = ex.GetType();

            if (type.FullName == "System.Data.SqlClient.SqlException")
            {
                System.Data.SqlClient.SqlException sqlex = (System.Data.SqlClient.SqlException)ex;
                return GetSQLExceptionCode(sqlex);
            }
            return GetSystemExceptionCode(ex);
        }
        #endregion

        /// <summary>
        /// 得到错误信息
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetErrorMessage(int number)
        {
            Hashtable ht = new Hashtable();
            ht.Add(SUCCESS, "操作成功");
            ht.Add(ERROR_FAILD, "操作失败");
            ht.Add(ERROR_PASSWORD_FAIL, "密码不符合要求");
            ht.Add(ERROR_INVALID_USERNAME, "用户名不能包含特殊字符");
            ht.Add(ERROR_SQL_DUPLICATE, "名称已经存在");
            ht.Add(ERROR_EMAIL_DUPLICATE, "Email已经被注册过");
            ht.Add(ERROR_SQL_FAILD, "数据库操作发生错误");
            ht.Add(ERROR_DELETE_FAILED, "删除失败");
            ht.Add(ERROR_DELETE_HASCHILD, "该项目有子节点，请先删除子节点，才能继续");
            ht.Add(ERROR_PARAMETER_INVALID, "传入的参数无效");
            ht.Add(ERROR_SQL_REFERENCE, "该项目已经使用，不能删除;或者没有找到对应的引用值");
            ht.Add(ERROR_SQL_INVALIDOBJECT, "SQL系统错误，请与系统管理员联系");
            ht.Add(ERROR_DELETE_NOTHING, "该类别不允许删除");
            ht.Add(ERROR_ItemTemplateConfigError, "配置节不合法，请重新设置");
            ht.Add(ERROR_TemplateHasAttributes, "模板下有属性");

            //模板
            ht.Add(TEMPLATE_NULL, "模板不能为空");
            ht.Add(TEMPLATE_INVALID, "模板格式无效");
            ht.Add(TEMPLATE_NONEITEM, "模板没有子模板");
            ht.Add(ERROR_Authorize_FAILED, "审核错误");
            if (ht[number] == null) return "操作失败";
            return ht[number].ToString();
        }
    }
}
