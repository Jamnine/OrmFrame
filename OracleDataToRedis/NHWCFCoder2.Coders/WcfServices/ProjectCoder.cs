using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfServices
{
    public class ProjectCoder
    {

        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.WcfServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            ProjectCoder.CreateProject(dts);
            HibernateCfgCoder.Write();
            WebConfigCoder.Write();
            MainServiceCoder.Write();
            Log4netConfigCoder.Write();
        }

        #region 创建WcfServices项目文件
        private static void CreateProject(IList<DbTable> dts)
        {
            string path = BaseParams.WcfServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, BaseParams.WcfServicesNameSpace + ".csproj");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            sw.WriteLine("  <PropertyGroup>");
            sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
            sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
            sw.WriteLine("    <ProductVersion>9.0.30729</ProductVersion>");
            sw.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
            sw.WriteLine("    <ProjectGuid>{"+BaseParams.WcfServicesNo+"}</ProjectGuid>");
            sw.WriteLine("    <ProjectTypeGuids>{349c5851-65df-11da-9384-00065b846f21};{fae04ec0-301f-11d3-bf4b-00c04f79efbc}</ProjectTypeGuids>");
            sw.WriteLine("    <OutputType>Library</OutputType>");
            sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
            sw.WriteLine("    <RootNamespace>" + BaseParams.WcfServicesNameSpace + "</RootNamespace>");
            sw.WriteLine("    <AssemblyName>" + BaseParams.WcfServicesNameSpace + "</AssemblyName>");
            sw.WriteLine("    <TargetFrameworkVersion>v3.0</TargetFrameworkVersion>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">");
            sw.WriteLine("    <DebugSymbols>true</DebugSymbols>");
            sw.WriteLine("    <DebugType>full</DebugType>");
            sw.WriteLine("    <Optimize>false</Optimize>");
            sw.WriteLine("    <OutputPath>bin\\</OutputPath>");
            sw.WriteLine("    <DefineConstants>DEBUG;TRACE</DefineConstants>");
            sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
            sw.WriteLine("    <WarningLevel>4</WarningLevel>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">");
            sw.WriteLine("    <DebugType>pdbonly</DebugType>");
            sw.WriteLine("    <Optimize>true</Optimize>");
            sw.WriteLine("    <OutputPath>bin\\</OutputPath>");
            sw.WriteLine("    <DefineConstants>TRACE</DefineConstants>");
            sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
            sw.WriteLine("    <WarningLevel>4</WarningLevel>");
            sw.WriteLine("  </PropertyGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Reference Include=\"System\" />");
            sw.WriteLine("    <Reference Include=\"System.Data\" />");
            sw.WriteLine("    <Reference Include=\"System.Drawing\" />");
            sw.WriteLine("    <Reference Include=\"System.Runtime.Serialization\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.ServiceModel\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.Web\" />");
            sw.WriteLine("    <Reference Include=\"System.Xml\" />");
            sw.WriteLine("    <Reference Include=\"System.Configuration\" />");
            sw.WriteLine("    <Reference Include=\"System.Web.Services\" />");
            sw.WriteLine("    <Reference Include=\"System.EnterpriseServices\" />");
            sw.WriteLine("    <Reference Include=\"System.Web.Mobile\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Content Include=\"hibernate.cfg.xml\">");
            sw.WriteLine("      <CopyToOutputDirectory>Always</CopyToOutputDirectory>");
            sw.WriteLine("    </Content>");
            sw.WriteLine("    <Content Include=\"log4net.config\">");
            sw.WriteLine("      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>");
            sw.WriteLine("    </Content>");
            sw.WriteLine("    <Content Include=\"MainService.svc\" />");
            sw.WriteLine("    <Content Include=\"Web.config\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Compile Include=\"Properties\\AssemblyInfo.cs\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.WcfModelsNameSpace + "\\" + BaseParams.WcfModelsNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.WcfModelsNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.WcfModelsNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Folder Include=\"App_Data\\\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <Import Project=\"$(MSBuildBinPath)\\Microsoft.CSharp.targets\" />");
            sw.WriteLine("  <Import Project=\"$(MSBuildExtensionsPath)\\Microsoft\\VisualStudio\\v9.0\\WebApplications\\Microsoft.WebApplication.targets\" />");
            sw.WriteLine("  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. ");
            sw.WriteLine("       Other similar extension points exist, see Microsoft.Common.targets.");
            sw.WriteLine("  <Target Name=\"BeforeBuild\">");
            sw.WriteLine("  </Target>");
            sw.WriteLine("  <Target Name=\"AfterBuild\">");
            sw.WriteLine("  </Target>");
            sw.WriteLine("  -->");
            sw.WriteLine("  <ProjectExtensions>");
            sw.WriteLine("    <VisualStudio>");
            sw.WriteLine("      <FlavorProperties GUID=\"{349c5851-65df-11da-9384-00065b846f21}\">");
            sw.WriteLine("        <WebProjectProperties>");
            sw.WriteLine("          <UseIIS>False</UseIIS>");
            sw.WriteLine("          <AutoAssignPort>True</AutoAssignPort>");
            sw.WriteLine("          <DevelopmentServerPort>"+BaseParams.WcfServicePort+"</DevelopmentServerPort>");
            sw.WriteLine("          <DevelopmentServerVPath>/</DevelopmentServerVPath>");
            sw.WriteLine("          <IISUrl>");
            sw.WriteLine("          </IISUrl>");
            sw.WriteLine("          <NTLMAuthentication>False</NTLMAuthentication>");
            sw.WriteLine("          <UseCustomServer>False</UseCustomServer>");
            sw.WriteLine("          <CustomServerUrl>");
            sw.WriteLine("          </CustomServerUrl>");
            sw.WriteLine("          <SaveServerSettingsInUserFile>False</SaveServerSettingsInUserFile>");
            sw.WriteLine("        </WebProjectProperties>");
            sw.WriteLine("      </FlavorProperties>");
            sw.WriteLine("    </VisualStudio>");
            sw.WriteLine("  </ProjectExtensions>");
            sw.WriteLine("</Project>");
            sw.Close();
            file.Close();
            AssemblyInfoCoder.Write(path, BaseParams.WcfServicesNameSpace, BaseParams.WcfServicesNo);
        }
        #endregion

    }
}
