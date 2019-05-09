using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders
{
    public class SolutionCoder
    {

        #region 创建SolutionCreater项目文件
        public static string Write(IList<DbTable> dts)
        {
            string guid = System.Guid.NewGuid().ToString();
            string path = BaseParams.SolutionPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, BaseParams.SolutionNameSpace + ".sln");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("");
            sw.WriteLine("Microsoft Visual Studio Solution File, Format Version 10.00");
            sw.WriteLine("# Visual Studio 2008");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.ControlsNameSpace + "\", \"" + BaseParams.ControlsNameSpace + "\\" + BaseParams.ControlsNameSpace + ".csproj\", \"{" + BaseParams.ControlsNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.UtilityNameSpace + "\", \"" + BaseParams.UtilityNameSpace + "\\" + BaseParams.UtilityNameSpace + ".csproj\", \"{" + BaseParams.UtilityNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.DomainNameSpace + "\", \"" + BaseParams.DomainNameSpace + "\\" + BaseParams.DomainNameSpace + ".csproj\", \"{" + BaseParams.DomainNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.PersistenceNameSpace + "\", \"" + BaseParams.PersistenceNameSpace + "\\" + BaseParams.PersistenceNameSpace + ".csproj\", \"{" + BaseParams.PersistenceNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.ServicesNameSpace + "\", \"" + BaseParams.ServicesNameSpace + "\\" + BaseParams.ServicesNameSpace + ".csproj\", \"{" + BaseParams.ServicesNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.WinFromsNameSpace + "\", \"" + BaseParams.WinFromsNameSpace + "\\" + BaseParams.WinFromsNameSpace + ".csproj\", \"{" + BaseParams.WinFromsNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.RunNameSpace + "\", \"" + BaseParams.RunNameSpace + "\\" + BaseParams.RunNameSpace + ".csproj\", \"{" + BaseParams.RunNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.UserControlsNameSpace + "\", \"" + BaseParams.UserControlsNameSpace + "\\" + BaseParams.UserControlsNameSpace + ".csproj\", \"{" + BaseParams.UserControlsNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.External_binNameSpace + "\", \"" + BaseParams.External_binNameSpace + "\\" + BaseParams.External_binNameSpace + ".csproj\", \"{" + BaseParams.External_binNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.WcfModelsNameSpace + "\", \"" + BaseParams.WcfModelsNameSpace + "\\" + BaseParams.WcfModelsNameSpace + ".csproj\", \"{" + BaseParams.WcfModelsNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.WcfServicesNameSpace + "\", \"" + BaseParams.WcfServicesNameSpace + "\\" + BaseParams.WcfServicesNameSpace + ".csproj\", \"{" + BaseParams.WcfServicesNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Project(\"{" + guid + "}\") = \"" + BaseParams.WcfClientNameSpace + "\", \"" + BaseParams.WcfClientNameSpace + "\\" + BaseParams.WcfClientNameSpace + ".csproj\", \"{" + BaseParams.WcfClientNo + "}\"");
            sw.WriteLine("EndProject");
            sw.WriteLine("Global");
            sw.WriteLine("	GlobalSection(SolutionConfigurationPlatforms) = preSolution");
            sw.WriteLine("		Debug|Any CPU = Debug|Any CPU");
            sw.WriteLine("		Release|Any CPU = Release|Any CPU");
            sw.WriteLine("	EndGlobalSection");
            sw.WriteLine("	GlobalSection(ProjectConfigurationPlatforms) = postSolution");

            sw.WriteLine("		{" + BaseParams.ControlsNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.ControlsNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.ControlsNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.ControlsNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.UtilityNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.UtilityNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.UtilityNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.UtilityNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.DomainNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.DomainNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.DomainNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.DomainNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.PersistenceNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.PersistenceNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.PersistenceNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.PersistenceNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.ServicesNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.ServicesNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.ServicesNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.ServicesNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WinFromsNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WinFromsNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WinFromsNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WinFromsNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.RunNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.RunNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.RunNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.RunNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.UserControlsNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.UserControlsNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.UserControlsNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.UserControlsNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.External_binNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.External_binNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.External_binNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfClientNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfClientNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfClientNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfClientNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfServicesNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfServicesNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfServicesNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfServicesNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfModelsNo + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfModelsNo + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfModelsNo + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
            sw.WriteLine("		{" + BaseParams.WcfModelsNo + "}.Release|Any CPU.Build.0 = Release|Any CPU");

            sw.WriteLine("	EndGlobalSection");
            sw.WriteLine("	GlobalSection(SolutionProperties) = preSolution");
            sw.WriteLine("		HideSolutionNode = FALSE");
            sw.WriteLine("	EndGlobalSection");
            sw.WriteLine("EndGlobal");


            sw.Close();
            file.Close();
            return guid;
        }
        #endregion

        #region 创建AssemblyInfo文件
        private static void CreateAssemblyInfo(string path, string project, string projectid)
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
