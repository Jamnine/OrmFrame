using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.External_bin
{
    public class ProjectCoder
    {
        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.External_binPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            ProjectCoder.CreateProject(dts);
        }

        #region 创建ControlsProject项目文件
        private static void CreateProject(IList<DbTable> dts)
        {
            string path = BaseParams.External_binPath;
            if (Directory.Exists(path) == true)
            {
                foreach (string fi in Directory.GetFiles(path))
                {
                    File.Delete(fi);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }
            if (Directory.Exists(BaseParams.External_binPath) == true)
            {
                // 拷贝对应文件到项目路径下面
                foreach (string dllfile in Directory.GetFiles(Path.Combine(System.Windows.Forms.Application.StartupPath, "External_bin")))
                {
                    if (File.Exists(dllfile) == true)
                        File.Copy(dllfile, Path.Combine(path, Path.GetFileName(dllfile)));
                }
            }
            string filepath = Path.Combine(path, BaseParams.External_binNameSpace + ".csproj");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            sw.WriteLine("  <PropertyGroup>");
            sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
            sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
            sw.WriteLine("    <ProductVersion>9.0.21022</ProductVersion>");
            sw.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
            sw.WriteLine("    <ProjectGuid>{" + BaseParams.External_binNo + "}</ProjectGuid>");
            sw.WriteLine("    <OutputType>Library</OutputType>");
            sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
            sw.WriteLine("    <RootNamespace>External_bin</RootNamespace>");
            sw.WriteLine("    <AssemblyName>External_bin</AssemblyName>");
            sw.WriteLine("    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>");
            sw.WriteLine("    <FileAlignment>512</FileAlignment>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">");
            sw.WriteLine("    <DebugSymbols>true</DebugSymbols>");
            sw.WriteLine("    <DebugType>full</DebugType>");
            sw.WriteLine("    <Optimize>false</Optimize>");
            sw.WriteLine("    <OutputPath>bin\\Debug\\</OutputPath>");
            sw.WriteLine("    <DefineConstants>DEBUG;TRACE</DefineConstants>");
            sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
            sw.WriteLine("    <WarningLevel>4</WarningLevel>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">");
            sw.WriteLine("    <DebugType>pdbonly</DebugType>");
            sw.WriteLine("    <Optimize>true</Optimize>");
            sw.WriteLine("    <OutputPath>bin\\Release\\</OutputPath>");
            sw.WriteLine("    <DefineConstants>TRACE</DefineConstants>");
            sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
            sw.WriteLine("    <WarningLevel>4</WarningLevel>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Content Include=\"Castle.Core.dll\" />");
            sw.WriteLine("    <Content Include=\"Castle.DynamicProxy2.dll\" />");
            sw.WriteLine("    <Content Include=\"Iesi.Collections.dll\" />");
            sw.WriteLine("    <Content Include=\"NHibernate.dll\" />");
            sw.WriteLine("    <Content Include=\"log4net.dll\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />");
            sw.WriteLine("  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. ");
            sw.WriteLine("       Other similar extension points exist, see Microsoft.Common.targets.");
            sw.WriteLine("  <Target Name=\"BeforeBuild\">");
            sw.WriteLine("  </Target>");
            sw.WriteLine("  <Target Name=\"AfterBuild\">");
            sw.WriteLine("  </Target>");
            sw.WriteLine("  -->");
            sw.WriteLine("</Project>");

            sw.Close();
            file.Close();

            AssemblyInfoCoder.Write(path, BaseParams.External_binNameSpace, BaseParams.External_binNo);
        }
        #endregion

    }
}
