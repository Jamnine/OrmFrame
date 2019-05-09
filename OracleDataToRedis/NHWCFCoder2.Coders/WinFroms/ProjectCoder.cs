using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WinFroms
{
    public class ProjectCoder
    {
        public static void Write(IList<DbTable> dts)
        {
            string path = BaseParams.WinFromsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            ProjectCoder.CreateProject(dts);
            DialogEditTypeCoder.Write();

        }

        #region 创建WcfServices项目文件
        private static void CreateProject(IList<DbTable> dts)
        {
            string path = BaseParams.WinFromsPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            string filepath = Path.Combine(path, BaseParams.WinFromsNameSpace + ".csproj");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<Project ToolsVersion=\"3.5\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            sw.WriteLine("  <PropertyGroup>");
            sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
            sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
            sw.WriteLine("    <ProductVersion>9.0.30729</ProductVersion>");
            sw.WriteLine("    <SchemaVersion>2.0</SchemaVersion>");
            sw.WriteLine("    <ProjectGuid>{" + BaseParams.WinFromsNo + "}</ProjectGuid>");
            sw.WriteLine("    <OutputType>Library</OutputType>");
            sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
            sw.WriteLine("    <RootNamespace>" + BaseParams.WinFromsNameSpace + "</RootNamespace>");
            sw.WriteLine("    <AssemblyName>" + BaseParams.WinFromsNameSpace + "</AssemblyName>");
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
            sw.WriteLine("    <Reference Include=\"System.Drawing\" />");
            sw.WriteLine("    <Reference Include=\"System.ServiceModel\">");
            sw.WriteLine("      <RequiredTargetFramework>3.0</RequiredTargetFramework>");
            sw.WriteLine("    </Reference>");
            sw.WriteLine("    <Reference Include=\"System.Windows.Forms\" />");
            sw.WriteLine("    <Reference Include=\"System.Xml\" />");
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <Compile Include=\"Properties\\AssemblyInfo.cs\" />");
            sw.WriteLine("    <Compile Include=\"DialogEditType.cs\" />");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <Compile Include=\"EditDialogs\\dlg" + dt.TitleCaseName + "Edit.cs\">");
                sw.WriteLine("      <SubType>Form</SubType>");
                sw.WriteLine("    </Compile>");
                sw.WriteLine("    <Compile Include=\"EditDialogs\\dlg" + dt.TitleCaseName + "Edit.Designer.cs\">");
                sw.WriteLine("      <DependentUpon>dlg" + dt.TitleCaseName + "Edit.cs</DependentUpon>");
                sw.WriteLine("    </Compile>");
            }
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <Compile Include=\"ManagerForms\\frm" + dt.TitleCaseName + "Mng.cs\">");
                sw.WriteLine("      <SubType>Form</SubType>");
                sw.WriteLine("    </Compile>");
                sw.WriteLine("    <Compile Include=\"ManagerForms\\frm" + dt.TitleCaseName + "Mng.Designer.cs\">");
                sw.WriteLine("      <DependentUpon>frm" + dt.TitleCaseName + "Mng.cs</DependentUpon>");
                sw.WriteLine("    </Compile>");
            }
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <EmbeddedResource Include=\"EditDialogs\\dlg" + dt.TitleCaseName + "Edit.resx\">");
                sw.WriteLine("      <DependentUpon>dlg" + dt.TitleCaseName + "Edit.cs</DependentUpon>");
                sw.WriteLine("    </EmbeddedResource>");
            }
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            foreach (DbTable dt in dts)
            {
                sw.WriteLine("    <EmbeddedResource Include=\"ManagerForms\\frm" + dt.TitleCaseName + "Mng.resx\">");
                sw.WriteLine("      <DependentUpon>frm" + dt.TitleCaseName + "Mng.cs</DependentUpon>");
                sw.WriteLine("      <SubType>Designer</SubType>");
                sw.WriteLine("    </EmbeddedResource>");
            }
            sw.WriteLine("  </ItemGroup>");
            sw.WriteLine("  <ItemGroup>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.ControlsNameSpace + "\\" + BaseParams.ControlsNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.ControlsNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.ControlsNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.DomainNameSpace + "\\" + BaseParams.DomainNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.DomainNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.DomainNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.UtilityNameSpace + "\\" + BaseParams.UtilityNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.UtilityNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.UtilityNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.UserControlsNameSpace + "\\" + BaseParams.UserControlsNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.UserControlsNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.UserControlsNameSpace + "</Name>");
            sw.WriteLine("    </ProjectReference>");
            sw.WriteLine("    <ProjectReference Include=\"..\\" + BaseParams.WcfClientNameSpace + "\\" + BaseParams.WcfClientNameSpace + ".csproj\">");
            sw.WriteLine("      <Project>{" + BaseParams.WcfClientNo + "}</Project>");
            sw.WriteLine("      <Name>" + BaseParams.WcfClientNameSpace + "</Name>");
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
            AssemblyInfoCoder.Write(path, BaseParams.WinFromsNameSpace, BaseParams.WinFromsNo);
        }
        #endregion

    }
}
