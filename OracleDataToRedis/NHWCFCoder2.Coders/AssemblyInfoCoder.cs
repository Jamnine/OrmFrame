using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders
{
    public class AssemblyInfoCoder
    {
        #region 创建AssemblyInfo文件
        public static void Write(string path, string project, string projectid)
        {
            path = Path.Combine(path, "Properties");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, "AssemblyInfo.cs");
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System.Reflection;");
            sw.WriteLine("using System.Runtime.CompilerServices;");
            sw.WriteLine("using System.Runtime.InteropServices;");
            sw.WriteLine("");
            sw.WriteLine("// 有关程序集的常规信息通过下列属性集");
            sw.WriteLine("// 控制。更改这些属性值可修改");
            sw.WriteLine("// 与程序集关联的信息。");
            sw.WriteLine("[assembly: AssemblyTitle(\"" + project + "\")]");
            sw.WriteLine("[assembly: AssemblyDescription(\"\")]");
            sw.WriteLine("[assembly: AssemblyConfiguration(\"\")]");
            sw.WriteLine("[assembly: AssemblyCompany(\"Microsoft\")]");
            sw.WriteLine("[assembly: AssemblyProduct(\"" + project + "\")]");
            sw.WriteLine("[assembly: AssemblyCopyright(\"Copyright ? Microsoft 2008\")]");
            sw.WriteLine("[assembly: AssemblyTrademark(\"\")]");
            sw.WriteLine("[assembly: AssemblyCulture(\"\")]");
            if (project == BaseParams.RunNameSpace || project == BaseParams.WcfModelsNameSpace)
            {
                sw.WriteLine("[assembly: log4net.Config.XmlConfigurator(ConfigFile = \"log4net.config\", Watch = true)]");
            }
            sw.WriteLine("");
            sw.WriteLine("// 将 ComVisible 设置为 false 使此程序集中的类型");
            sw.WriteLine("// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型,");
            sw.WriteLine("// 则将该类型上的 ComVisible 属性设置为 true。");
            sw.WriteLine("[assembly: ComVisible(false)]");
            sw.WriteLine("");
            sw.WriteLine("// 如果此项目向 COM 公开,则下列 GUID 用于类型库的 ID");
            sw.WriteLine("[assembly: Guid(\"" + projectid + "\")]");
            sw.WriteLine("");
            sw.WriteLine("// 程序集的版本信息由下面四个值组成:");
            sw.WriteLine("//");
            sw.WriteLine("//      主版本");
            sw.WriteLine("//      次版本");
            sw.WriteLine("//      内部版本号");
            sw.WriteLine("//      修订号");
            sw.WriteLine("//");
            sw.WriteLine("// 可以指定所有这些值,也可以使用“内部版本号”和“修订号”的默认值,");
            sw.WriteLine("// 方法是按如下所示使用“*”:");
            sw.WriteLine("// [assembly: AssemblyVersion(\"1.0.*\")]");
            sw.WriteLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
            sw.WriteLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
            sw.Close();
            file.Close();
        }
        #endregion
    }
}
