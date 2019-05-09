using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.Domain
{
    public class ProjectCoder
    {
        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.DomainPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            ProjectCoder.CreateProject(dts);
            BaseEntityCoder.Write();
        }

        #region 创建ControlsProject项目文件
        private static void CreateProject(IList<DbTable> dts)
        {
            string path = BaseParams.DomainPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, BaseParams.DomainNameSpace + ".csproj");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            sw.WriteLine("  <PropertyGroup>");
            sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
            sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
            sw.WriteLine("    <ProductVersion>9.0.21022</ProductVersion>");
            sw.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
            sw.WriteLine("    <ProjectGuid>{" + BaseParams.DomainNo + "}</ProjectGuid>");
            sw.WriteLine("    <OutputType>Library</OutputType>");
            sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
            sw.WriteLine("    <RootNamespace>" + BaseParams.DomainNameSpace + "</RootNamespace>");
            sw.WriteLine("    <AssemblyName>" + BaseParams.DomainNameSpace + "</AssemblyName>");
            sw.WriteLine("    <TargetFrameworkVersion>v3.0</TargetFrameworkVersion>");
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
            sw.WriteLine("    <Reference Include=\"System\" />");
            sw.WriteLine("    <Reference Include=\"System.Data\" />");
            sw.WriteLine("    <Reference Include=\"System.Runtime.Serialization\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.Xml\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Compile Include=\"Properties\\AssemblyInfo.cs\" />");
            sw.WriteLine("    <Compile Include=\"BaseEntity.cs\" />");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <Compile Include=\"" + dt.TitleCaseName + ".cs\" />");
            }
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <EmbeddedResource Include=\"" + dt.TitleCaseName + ".hbm.xml\" />");
            }
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

            AssemblyInfoCoder.Write(path, BaseParams.DomainNameSpace, BaseParams.DomainNo);
        }
        #endregion

    }
}
