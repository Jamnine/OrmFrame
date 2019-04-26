using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 模板引擎接口
    /// </summary>
    public interface ITempletEngine
    {
        /// <summary>
        /// Parses and returns the result of the specified string template.
        /// </summary>
        /// <param name="template">The string template.</param>
        /// <param name="model">The model instance.</param>
        /// <returns>The string result of the template.</returns>
        string Parse(string template, object model);

        /// <summary>
        /// Parses and returns the result of the specified string template.
        /// </summary>
        /// <typeparam name="T">The model type.</typeparam>
        /// <param name="template">The string template.</param>
        /// <param name="model">The model instance.</param>
        /// <returns>The string result of the template.</returns>
        string Parse<T>(string template, T model);       
    }
}
