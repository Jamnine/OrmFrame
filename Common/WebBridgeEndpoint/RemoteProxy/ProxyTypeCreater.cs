using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace WebBridgeEndpoint
{
    public class ProxyTypeCreater
    {
        /// <summary>
        /// 接口的命名空间。
        /// </summary>
        string InterfaceNamespace { get; set; }

        /// <summary>
        /// 代理类的命名空间。
        /// </summary>
        string ProxyNamespace
        {
            get
            {
                return ProxyCreaterSetting.ProxyNamespacePrefix + InterfaceNamespace;
            }
        }

        /// <summary>
        /// 接口的类名。
        /// </summary>
        string InterfaceName { get; set; }

        /// <summary>
        /// 代理类的类名。
        /// </summary>
        string ProxyClassName
        {
            get
            {
                return ProxyCreaterSetting.ProxyClassPrefix + InterfaceName;
            }
        }

        /// <summary>
        /// 代理类全名。
        /// </summary>
        string ProxyClassFullName
        {
            get
            {
                return ProxyNamespace + "." + ProxyClassName;
            }
        }

        /// <summary>
        /// 接口的类型。
        /// </summary>
        Type ContractInterface { get; set; }

        public ProxyTypeCreater()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        #region 类型生成
        Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return null;
        }

        public Type GenerateProxy(Type contractInterface)
        {
            if (contractInterface.IsGenericType)
            {
                throw new Exception("暂不支持泛型接口。");
            }

            Type TheProxyType = null;

            InterfaceName = contractInterface.Name;
            InterfaceNamespace = contractInterface.Namespace;
            ContractInterface = contractInterface;

            var CodeProvider = CodeDomProvider.CreateProvider("c#");
            CompilerParameters objCompilerParameters = InitalCompiler();

            string csCode = CreatCalssCode();
        
            CompilerResults cr = CodeProvider.CompileAssemblyFromSource(objCompilerParameters, csCode);

            if (cr.Errors.HasErrors)
            {
                Console.WriteLine("编译错误：");
                foreach (CompilerError err in cr.Errors)
                {
                    Console.WriteLine(err.ErrorText);
                }
            }
            else
            {
                //通过反射，调用HelloWorld的实例
                TheProxyType = cr.CompiledAssembly.GetType(ProxyClassFullName);
            }

            return TheProxyType;
        }

        private CompilerParameters InitalCompiler()
        {
            CompilerParameters objCompilerParameters = new CompilerParameters();

            string basePath = string.Empty;
            string binPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");

            if (Directory.Exists(binPath))
            {
                basePath = binPath;
            }else
            {
                basePath = AppDomain.CurrentDomain.BaseDirectory;
            }

            //添加公用引用。
            objCompilerParameters.ReferencedAssemblies.Add("Microsoft.CSharp.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Core.dll");
            objCompilerParameters.ReferencedAssemblies.Add(Path.Combine(basePath, "Orm.Framework.Services.dll"));
            objCompilerParameters.ReferencedAssemblies.Add(Path.Combine(basePath, "WebBridgeContract.dll"));
            objCompilerParameters.ReferencedAssemblies.Add(Path.Combine(basePath, "WebBridgeEndpoint.dll"));

            //添加非公用引用。
            AddReference(ContractInterface.Assembly, objCompilerParameters, basePath);

            objCompilerParameters.GenerateExecutable = false;
            objCompilerParameters.GenerateInMemory = true;

            return objCompilerParameters;
        }

        private HashSet<string> AddedRefHS = new HashSet<string>();

        private void AddReference(Assembly assembly, CompilerParameters objCompilerParameters, string basePath)
        {
            if (!AddedRefHS.Contains(assembly.FullName))
            {
                string fullPathName = Path.Combine(basePath, assembly.ManifestModule.Name);
                string nonPathName = assembly.ManifestModule.Name;

                string correctName = string.Empty;
                if (File.Exists(fullPathName))
                {
                    correctName = fullPathName;
                }
                else
                {
                    correctName = nonPathName;
                }

                if (!objCompilerParameters.ReferencedAssemblies.Contains(correctName))
                {
                    objCompilerParameters.ReferencedAssemblies.Add(correctName);
                }
                AddedRefHS.Add(assembly.FullName);

                List<string> RefNameList = assembly.GetReferencedAssemblies().Select(ss => ss.FullName).ToList();
                //添加接口依赖的程序集引用
                foreach (string strRefName in RefNameList)
                {
                    if (!AddedRefHS.Contains(strRefName))
                    {
                        Assembly subAssem = Assembly.Load(strRefName);
                        AddReference(subAssem, objCompilerParameters, basePath);
                    }
                }
            }
        }
        #endregion

        #region 代码生成。
        /// <summary>
        /// 类代码生成。
        /// </summary>
        /// <returns></returns>
        string CreatCalssCode()
        {
            StringBuilder sb = new StringBuilder();

            //using段
            sb.Append(@"using System;
            using System.Collections.Generic;
            using Orm.Framework.Services;
            using WebBridgeContract;
            using WebBridgeEndpoint;
            ");
            sb.Append(Environment.NewLine);


            //命名空间，类名，继承关系。
            sb.Append("namespace " + ProxyNamespace);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("      public class " + ProxyClassName + ": WebBridgeEndpoint.ProxyBase ," + ContractInterface.FullName);
            sb.Append(Environment.NewLine);
            sb.Append("      {");

            //IApiExtend接口的成员
            sb.Append(Environment.NewLine);

            //Api接口的成员
            CreatCalssMember(sb);

            //类尾
            sb.Append(@"      }
              }");

            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// 类成员代码生成。
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <returns></returns>
        StringBuilder CreatCalssMember(StringBuilder stringBuilder)
        {
            MemberInfo[] members = ContractInterface.GetMembers();
            foreach (MemberInfo member in members)
            {
                //剔除属性访问器默认方法和事件属性访问器默认方法
                if (!CheckMember(member, ContractInterface))
                {
                    continue;
                }

                //事件生成。
                if (member.MemberType == MemberTypes.Event)
                {
                    EventInfo evInfo = member as EventInfo;
                    stringBuilder= CreatOneEvent(evInfo, stringBuilder);
                }

                //方法生成。
                if (member.MemberType == MemberTypes.Method)
                {
                    MethodInfo mtInfo = member as MethodInfo;
                  
                    stringBuilder= CreatOneMethod(mtInfo, stringBuilder);
                }

                //属性生成。
                if (member.MemberType == MemberTypes.Property)
                {
                    throw new Exception("不支持属性。");
                }
            }

            return stringBuilder;
        }

        /// <summary>
        /// 生成一个事件的代码。
        /// </summary>
        /// <param name="evInfo">事件信息</param>
        /// <param name="stringBuilder">生成的代码到指定的类代码字符串</param>
        /// <returns>生成的代码到指定的类代码字符串</returns>
        StringBuilder CreatOneEvent(EventInfo evInfo, StringBuilder stringBuilder)
        {
            ParameterInfo[] parameters = evInfo.EventHandlerType.GetMethod("Invoke").GetParameters();

            //事件名。
            string evName = evInfo.Name;

            //事件类型名。
            string evTypeName = GetTypeNameStr(evInfo.EventHandlerType);

            //形参表串，就是声名方法时带类型和参数名。
            string strFormalParameters = string.Empty;

            //实参串，调用方法时的只有参数名。
            string strActualParameters = string.Empty;

            foreach (ParameterInfo parameter in parameters)
            {
                if (!string.IsNullOrWhiteSpace(strFormalParameters))
                {
                    strFormalParameters += ", ";
                }
                string strParameterTypeName = GetTypeNameStr(parameter.ParameterType);
                strFormalParameters += (strParameterTypeName + " " + parameter.Name);

                if (!string.IsNullOrWhiteSpace(strActualParameters))
                {
                    strActualParameters += ", ";
                }
                strActualParameters += parameter.Name;
            }

            string strCode = @" private event  #EventTypeName# field_#EventName#;

                            public event #EventTypeName# #EventName#
                            {
                                add
                                {
                                    EventDC theDc = new EventDC();
                                    theDc.EventName =" + "\"" + "#EventName#" + "\"" + @";
                                    theDc.SenderInterfaceName = ApiTypeMap.InterfaceName;
                                    theDc.SenderTypeName  = ApiTypeMap.MapToType;

                                    EventService.ListenEvent(theDc, AppSettings.AppRuntimeName, value.Method.DeclaringType.FullName, value.Method.Name);
                                    TheManager.LisetenEvent(ApiTypeMap,  theDc.EventName, value.Method.DeclaringType.FullName, value.Method.Name);
                                    field_#EventName# += value;
                                }
                                remove
                                {
                                    EventDC theDc = new EventDC();
                                    theDc.EventName =" + "\"" + "#EventName#" + "\"" + @";
                                    theDc.SenderInterfaceName = ApiTypeMap.InterfaceName;
                                    theDc.SenderTypeName = ApiTypeMap.MapToType;

                                    EventService.RepealListen(theDc, AppSettings.AppRuntimeName, value.Method.DeclaringType.FullName, value.Method.Name);
                                    TheManager.RepealListen(ApiTypeMap, theDc.EventName, value.Method.DeclaringType.FullName, value.Method.Name);
                                    field_#EventName# -= value;
                                }
                            }

                            public void trigger_#EventName#(#FormalParameters#)
                            {
                                field_#EventName#(#ActualParameters#);
                            }";

            strCode = strCode.Replace(ProxyCreaterSetting.EventName, evName);
            strCode = strCode.Replace(ProxyCreaterSetting.EventTypeName, evTypeName);
            strCode = strCode.Replace(ProxyCreaterSetting.FormalParameters, strFormalParameters);
            strCode = strCode.Replace(ProxyCreaterSetting.ActualParameters, strActualParameters);

            stringBuilder.Append(strCode);
            return stringBuilder;
        }

        /// <summary>
        /// 生成一个方法的代码。
        /// </summary>
        /// <param name="mtInfo">方法信息</param>
        /// <param name="stringBuilder">生成的代码到指定的类代码字符串</param>
        /// <returns>生成的代码到指定的类代码字符串</returns>
        StringBuilder CreatOneMethod(MethodInfo mtInfo, StringBuilder stringBuilder)
        {
            string strReturnType = string.Empty;
            string strMethodName = mtInfo.Name;
            string strFormalParameters = string.Empty;
            string strMethodConstraint = string.Empty;
            string strMethodArgType = string.Empty;

            strReturnType = GetTypeNameStr(mtInfo.ReturnType);
            strMethodName = GetMethodNameStr(mtInfo);
            strMethodConstraint = GetMethodConstraint(mtInfo);
            strMethodArgType= GetMethodTypeArgs(mtInfo);

            ParameterInfo[] parameters = mtInfo.GetParameters();
            List<string> paramNameList = new List<string>();
            foreach (ParameterInfo parameter in parameters)
            {
                if (!string.IsNullOrWhiteSpace(strFormalParameters))
                {
                    strFormalParameters += ", ";
                }
                string paramTypeNameStr = GetTypeNameStr(parameter.ParameterType);
                strFormalParameters += (paramTypeNameStr + " " + parameter.Name);
                paramNameList.Add(parameter.Name);
            }


            string returnTypeChangeStr = strReturnType != "void" ? "return (" + strReturnType + ")" : "";

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("public " + strReturnType + " " + strMethodName + "( " + strFormalParameters + " )");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(strMethodConstraint);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("{");

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(@"List<Object> ParamList = new List<Object>();");
            foreach (string paramName in paramNameList)
            {
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(@"ParamList.Add(" + paramName + ");");
            }

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(strMethodArgType);
            stringBuilder.Append(Environment.NewLine);

            stringBuilder.Append(returnTypeChangeStr + "TheReQuseter.RequseteWeb( ApiTypeMap.MapConfigKey, "
                + "\"" + ContractInterface.FullName + "\"" + ", "
                + "\"" + strMethodName + "\"" + ", ParamList, TypeArgs,GetOneUrl()) ;");

            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("          }");
            stringBuilder.Append(Environment.NewLine);

            return stringBuilder;
        }

        /// <summary>
        /// 得到能在代码中使用的类型名，可能是泛型或Void，不能简单通过Full得到。
        /// </summary>
        /// <param name="TheType">目标类型</param>
        /// <returns>能在代码中使用的类型名</returns>
        private string GetTypeNameStr(Type TheType)
        {
            string retTypeStr = string.Empty;

            if (!TheType.IsGenericType)
            {
                var strName = string.IsNullOrWhiteSpace(TheType.FullName) ? TheType.Name : TheType.FullName;
                retTypeStr = strName.Trim() != "System.Void" ? strName : "void";
            }
            else
            {
                string genericName = string.Empty;
                if (TheType.FullName != null)
                {
                    var reg = new Regex(@"^.*(?=`\d*\[)");
                    genericName = reg.Match(TheType.FullName).Value;
                }
                else {
                    genericName = TheType.Name.Substring(0,TheType.Name.Length-2);
                }

                string strTypeArgs = string.Empty;
                foreach (var TypeArg in TheType.GetGenericArguments())
                {
                    if(!string.IsNullOrWhiteSpace( strTypeArgs))
                    {
                        strTypeArgs += ",";
                    }
                    if (string.IsNullOrWhiteSpace(TypeArg.FullName)) {
                        strTypeArgs += TypeArg.Name;
                    }
                    else
                    {
                        strTypeArgs += TypeArg.FullName;
                    }
                }

                retTypeStr = genericName + "<" + strTypeArgs + ">";
            }

           return retTypeStr;
        }

        /// <summary>
        /// 得到能在代码中使用的方法名，可能是泛型，不能简单通过Full得到。
        /// </summary>
        /// <param name="mtInfo">目标方法</param>
        /// <returns>能在代码中使用的方法名</returns>
        private string GetMethodNameStr(MethodInfo mtInfo)
        {
            string retStr = string.Empty;
            if (mtInfo.IsGenericMethod)
            {
                string strTypeArgs = string.Empty;
                foreach (var TypeArg in mtInfo.GetGenericArguments())
                {
                    if (!string.IsNullOrWhiteSpace(strTypeArgs))
                    {
                        strTypeArgs += ",";
                    }
                    if (string.IsNullOrWhiteSpace(TypeArg.FullName)) {
                        strTypeArgs += TypeArg.Name;
                    }
                    else
                    {
                        strTypeArgs += TypeArg.FullName;
                    }
                }
                retStr = mtInfo.Name + "<" + strTypeArgs + ">";
            }
            else
            {
                retStr = mtInfo.Name;
            }
            return retStr;
        }

        private string GetMethodConstraint(MethodInfo mtInfo)
        {
            string retTypeStr = string.Empty;
            if (!mtInfo.IsGenericMethod)
                return retTypeStr;
            var gnInfo = mtInfo.GetGenericMethodDefinition();
            var args = gnInfo.GetGenericArguments();
            foreach (var TypeArg in args)
            {
                string strTypeArgs = string.Empty;
                if (!TypeArg.IsGenericParameter)
                    continue;
                 
                var attributes = TypeArg.GenericParameterAttributes;
                if ((int)attributes == 0)
                    continue;

                if (!string.IsNullOrWhiteSpace(strTypeArgs))
                {
                    strTypeArgs += ",";
                }
                else {
                    strTypeArgs = " where "+TypeArg.Name +":";
                }
          
              

                if ((attributes & GenericParameterAttributes.Contravariant) != 0)
                {
                  
                    strTypeArgs += string.Empty;
                }

                if ((attributes & GenericParameterAttributes.Covariant) != 0)
                {
                    strTypeArgs += string.Empty;
                }

                if ((attributes & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                {
                    strTypeArgs += string.Empty;
                }

                if ((attributes & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                {
                    strTypeArgs += "class";
                }

                if ((attributes & GenericParameterAttributes.SpecialConstraintMask) != 0
                    && 
                   ( attributes & GenericParameterAttributes.ReferenceTypeConstraint) == 0
                    )
                {
                    if (!string.IsNullOrWhiteSpace(TypeArg.BaseType.FullName))
                    {
                        if (!strTypeArgs.EndsWith(":"))
                        {
                            strTypeArgs += ",";
                        }
                        strTypeArgs += TypeArg.BaseType.FullName;
                    }
                }

                if ((attributes & GenericParameterAttributes.VarianceMask) != 0)
                {
                    strTypeArgs += string.Empty;
                }

                if ((attributes & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                {
                    if (!strTypeArgs.EndsWith(":"))
                    {
                        strTypeArgs += ",";
                    }
                    strTypeArgs += " new()";
                }

                retTypeStr += strTypeArgs;
             
            }

          
            return retTypeStr;
        }

        private string GetMethodTypeArgs(MethodInfo mtInfo)
        {

            if (!mtInfo.IsGenericMethod)
                return "string[] TypeArgs=null;";

            var args = mtInfo.GetGenericArguments();
            if (args.Length == 0)
                return "string[] TypeArgs=null;";
            string retTypeStr = "var TypeArgs=new string[]{";
            foreach (var TypeArg in args)
            {
                string strTypeArgs = string.Empty;
                if (!TypeArg.IsGenericParameter)
                    continue;

                var attributes = TypeArg.GenericParameterAttributes;
                if ((int)attributes == 0)
                    continue;

                if (!retTypeStr.EndsWith("{")) {
                    strTypeArgs = ",";
                }
                strTypeArgs += " typeof( " + TypeArg.Name + ").AssemblyQualifiedName";
                retTypeStr += strTypeArgs;

            }

            return retTypeStr+"};";
        }

        /// <summary>
        /// 检验成员，过滤一些属性或字段的默认方法以避免冲突。
        /// </summary>
        /// <param name="member">成员信息</param>
        /// <param name="ContractInterface">要检验的类型。</param>
        /// <returns></returns>
        private bool CheckMember(MemberInfo member, Type ContractInterface)
        {
            MemberInfo[] members = ContractInterface.GetMembers();
            return !members.ToList().Exists(mm => "add_" + mm.Name == member.Name
                || "remove_" + mm.Name == member.Name
                || "get_" + mm.Name == member.Name
                || "set_" + mm.Name == member.Name);
        }
        #endregion
    }
}
