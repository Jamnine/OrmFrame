using Orm.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebBridgeContract;

namespace WebApiResponder
{
    internal class ApiCore
    {
        /// <summary>
        /// 方法契约。
        /// </summary>
        MethodDC theContract;

        /// <summary>
        /// 序列化器。
        /// </summary>
        IJsonSerializer Serializer { get; set; }

        public ApiCore(MethodDC Contract)
        {
            Serializer = ServiceTaker.GetService<IJsonSerializer>();
            theContract = Contract;
        }

        /// <summary>
        /// 运行方法
        /// </summary>
        /// <returns></returns>
        public InvokeResult Invoke()
        {
            object Result = null;

            object theApi = ServiceTaker.GetServiceByKey(theContract.InterfaceName, theContract.ApiConfigKey);

            List<object> paramList = GetParamList(theContract);
            var theType = theApi.GetType();
            int generic = theContract.MethodName.IndexOf("<");
            var methodName = generic >= 0 ?
                theContract.MethodName.Substring(0, generic) : theContract.MethodName;

            var methods = theType.GetMethods().Where(m => m.Name == methodName);


            //如果找不到方法
            if (methods.Count() == 0)
            {
                throw new Exception("找不到目标方法");
            }

            var method = GetMethod(methods, theContract.TypeArguments, paramList);
            if (method == null)
            {
                throw new Exception("未能找到方法名:" + methodName + "接口名称:" + theContract.InterfaceName);
            }
            if (!method.IsPublic)
            {
                throw new Exception("目标方法不是公有的");
            }

            if (method.IsAbstract) //如果是抽象方法。
            {
                throw new Exception("目标方法是抽象方法");
            }

            InvokeResult theRes = new InvokeResult();
            if (generic < 0)
            {
                Result = method.Invoke(theApi, paramList.ToArray());
                theRes.ResultType = method.ReturnType;
            }
            else
            {

                MethodInfo methodInfo;
                Type[] types = null;
                if (theContract.TypeArguments != null)
                {
                    types = new Type[theContract.TypeArguments.Length];
                    for (int i = 0; i < theContract.TypeArguments.Length; i++)
                    {

                        types[i] = Type.GetType(theContract.TypeArguments[i]);
                    }
                }
                if (types == null)
                {
                    methodInfo = method.MakeGenericMethod();
                }
                else
                {
                    methodInfo = method.MakeGenericMethod(types);
                }
                Result = methodInfo.Invoke(theApi, paramList.ToArray());
                theRes.ResultType = methodInfo.ReturnType;
            }
            theRes.ResultValue = Result;
            return theRes;
        }
        private MethodInfo GetMethod(IEnumerable<MethodInfo> methods, string[] argus, List<object> paramList)
        {

            if (methods.Count() == 1)
            {
                return methods.First();
            }

            foreach (var item in methods)
            {
                var paras = item.GetParameters();
                if (paras.Length != paramList.Count)
                {
                    continue;
                }
                bool find = true;
                for (int i = 0; i < paras.Length; i++)
                {
                    if (paras[i].ParameterType.Name != paramList[i].GetType().Name)
                    {
                        find = false;
                        break;
                    }
                }
                if (find)
                    return item;
            }
            return methods.First();
        }

        /// <summary>
        /// 从契约中反序列化取参数列表
        /// </summary>
        /// <param name="theContract">方法数据契约</param>
        /// <returns>参数列表</returns>
        private List<object> GetParamList(MethodDC theContract)
        {
            List<object> relParamList = new List<object>();

            foreach (ParameterDC aparamet in theContract.ParameterList)
            {
                Type relType = Type.GetType(aparamet.TypeQualifiedName);
                object value = Serializer.Deserialize(aparamet.JsonValue, relType);
                relParamList.Add(value);
            }

            return relParamList;
        }


        /// <summary>
        /// 运行方法
        /// </summary>
        /// <returns></returns>
        public InvokeResult Invoke(object theApi)
        {
            object Result = null;

            //object theApi = ServiceTaker.GetServiceByKey(theContract.InterfaceName, theContract.ApiConfigKey);

            List<object> paramList = GetParamList(theContract);
            var theType = theApi.GetType();
            int generic = theContract.MethodName.IndexOf("<");
            var methodName = generic >= 0 ? theContract.MethodName.Substring(0, generic) : theContract.MethodName;

            var methods = theType.GetMethods().Where(m => m.Name == methodName);


            //如果找不到方法
            if (methods.Count() == 0)
            {
                throw new Exception("找不到目标方法");
            }

            var method = GetMethod(methods, theContract.TypeArguments, paramList);
            if (!method.IsPublic)
            {
                throw new Exception("目标方法不是公有的");
            }

            if (method.IsAbstract) //如果是抽象方法。
            {
                throw new Exception("目标方法是抽象方法");
            }

            InvokeResult theRes = new InvokeResult();
            if (generic < 0)
            {
                Result = method.Invoke(theApi, paramList.ToArray());
                theRes.ResultType = method.ReturnType;
            }
            else
            {

                MethodInfo methodInfo;
                Type[] types = null;
                if (theContract.TypeArguments != null)
                {
                    types = new Type[theContract.TypeArguments.Length];
                    for (int i = 0; i < theContract.TypeArguments.Length; i++)
                    {

                        types[i] = Type.GetType(theContract.TypeArguments[i]);
                    }
                }
                if (types == null)
                {
                    methodInfo = method.MakeGenericMethod();
                }
                else
                {
                    methodInfo = method.MakeGenericMethod(types);
                }
                Result = methodInfo.Invoke(theApi, paramList.ToArray());
                theRes.ResultType = methodInfo.ReturnType;
            }
            theRes.ResultValue = Result;
            return theRes;
        }
    }
}
