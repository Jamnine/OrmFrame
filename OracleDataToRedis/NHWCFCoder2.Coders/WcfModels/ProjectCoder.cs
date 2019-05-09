using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.WcfModels
{
    public class ProjectCoder
    {

        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            ProjectCoder.CreateProject(dts);
            BaseMainServiceCoder.Write();
            ValidatorCoder.Write();
            MainServiceFactoryCoder.Write(dts);
            NHibernateUnProxyHelperCorder.Write();
            MyWcfTranserObjectCoder.Write(dts);
        }

        #region 创建WcfModels项目文件
        private static void CreateProject(IList<DbTable> dts)
        {
            string path = BaseParams.WcfModelsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, BaseParams.WcfModelsNameSpace + ".csproj");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            sw.WriteLine("  <PropertyGroup>");
            sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
            sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
            sw.WriteLine("    <ProductVersion>9.0.30729</ProductVersion>");
            sw.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
            sw.WriteLine("    <ProjectGuid>{" + BaseParams.WcfModelsNo + "}</ProjectGuid>");
            sw.WriteLine("    <OutputType>Library</OutputType>");
            sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
            sw.WriteLine("    <RootNamespace>" + BaseParams.WcfModelsNameSpace + "</RootNamespace>");
            sw.WriteLine("    <AssemblyName>" + BaseParams.WcfModelsNameSpace + "</AssemblyName>");
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
            sw.WriteLine("    <Reference Include=\"NHibernate, Version=2.0.1.4000, Culture=neutral, PublicKeyToken=aa95f207798dfdb4, processorArchitecture=MSIL\">");
            sw.WriteLine("      <SpecificVersion>False</SpecificVersion>");
            sw.WriteLine("      <HintPath>..\\External_bin\\NHibernate.dll</HintPath>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=1b44e1d426115821, processorArchitecture=MSIL\">");
            sw.WriteLine("      <SpecificVersion>False</SpecificVersion>");
            sw.WriteLine("      <HintPath>..\\External_bin\\log4net.dll</HintPath>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System\" />");
            sw.WriteLine("    <Reference Include=\"System.Data\" />");
            sw.WriteLine("    <Reference Include=\"System.Runtime.Serialization\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.ServiceModel\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.IdentityModel\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.Xml\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Compile Include=\"Properties\\AssemblyInfo.cs\" />");
            sw.WriteLine("    <Compile Include=\"MyUserNamePasswordValidator.cs\" />");
            sw.WriteLine("    <Compile Include=\"IMainService.cs\" />");
            sw.WriteLine("    <Compile Include=\"MainService.cs\" />");
            sw.WriteLine("    <Compile Include=\"MyWcfTranserObject.cs\" />");
            sw.WriteLine("    <Compile Include=\"NHibernateUnProxyHelper.cs\" />");
            sw.WriteLine("    <Compile Include=\"MainServiceFactory.cs\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.PersistenceNameSpace + "\\" + BaseParams.PersistenceNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.PersistenceNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.PersistenceNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.ServicesNameSpace + "\\" + BaseParams.ServicesNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.ServicesNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.ServicesNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.DomainNameSpace + "\\" + BaseParams.DomainNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.DomainNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.DomainNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.UtilityNameSpace + "\\" + BaseParams.UtilityNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.UtilityNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.UtilityNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
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
            AssemblyInfoCoder.Write(path, BaseParams.WcfModelsNameSpace, BaseParams.WcfModelsNo);
        }
        #endregion

    }
}
