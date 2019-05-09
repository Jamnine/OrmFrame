using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfServices
{
    public class WebConfigCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建Web.config
            string filepath = Path.Combine(path, "Web.config");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\"?>");
            sw.WriteLine("<configuration>");
            sw.WriteLine("	<appSettings/>");
            sw.WriteLine("	<connectionStrings/>");
            sw.WriteLine("	<system.web>");
            sw.WriteLine("		<!-- ");
            sw.WriteLine("            设置 compilation debug=\"true\" 可将调试符号插入");
            sw.WriteLine("            已编译的页面中。但由于这会 ");
            sw.WriteLine("            影响性能，因此只在开发过程中将此值 ");
            sw.WriteLine("            设置为 true。");
            sw.WriteLine("        -->");
            sw.WriteLine("		<compilation debug=\"true\">");
            sw.WriteLine("		</compilation>");
            sw.WriteLine("		<!--");
            sw.WriteLine("            通过 <authentication> 节可以配置 ASP.NET 用来 ");
            sw.WriteLine("            识别进入用户的");
            sw.WriteLine("            安全身份验证模式。 ");
            sw.WriteLine("        -->");
            sw.WriteLine("		<authentication mode=\"Windows\"/>");
            sw.WriteLine("		<!--");
            sw.WriteLine("            如果在执行请求的过程中出现未处理的错误，");
            sw.WriteLine("            则通过 <customErrors> 节可以配置相应的处理步骤。具体说来，");
            sw.WriteLine("            开发人员通过该节可以配置");
            sw.WriteLine("            要显示的 html 错误页");
            sw.WriteLine("            以代替错误堆栈跟踪。");
            sw.WriteLine("");
            sw.WriteLine("        <customErrors mode=\"RemoteOnly\" defaultRedirect=\"GenericErrorPage.htm\">");
            sw.WriteLine("            <error statusCode=\"403\" redirect=\"NoAccess.htm\" />");
            sw.WriteLine("            <error statusCode=\"404\" redirect=\"FileNotFound.htm\" />");
            sw.WriteLine("        </customErrors>");
            sw.WriteLine("        -->");
            sw.WriteLine("	</system.web>");
            sw.WriteLine("  <system.serviceModel>");
            sw.WriteLine("    <services>");
            sw.WriteLine("      <service behaviorConfiguration=\"" + BaseParams.WcfModelsNameSpace + ".MainServiceBehavior\"");
            sw.WriteLine("          name=\"" + BaseParams.WcfModelsNameSpace + ".MainService\">");
            sw.WriteLine("        <endpoint address=\"\" binding=\"wsHttpBinding\" bindingConfiguration=\"" + BaseParams.WcfModelsNameSpace + ".MainServiceHttpBinding\" contract=\"" + BaseParams.WcfModelsNameSpace + ".IMainService\">");
            sw.WriteLine("          <identity>");
            sw.WriteLine("            <dns value=\"MyServer\" />");
            sw.WriteLine("          </identity>");
            sw.WriteLine("        </endpoint>");
            sw.WriteLine("        <endpoint address=\"mex\" binding=\"mexHttpBinding\" contract=\"IMetadataExchange\" />");
            sw.WriteLine("      </service>");
            sw.WriteLine("    </services>");
            sw.WriteLine("    <behaviors>");
            sw.WriteLine("      <serviceBehaviors>");
            sw.WriteLine("        <behavior name=\"" + BaseParams.WcfModelsNameSpace + ".MainServiceBehavior\">");
            sw.WriteLine("          <serviceMetadata httpGetEnabled=\"true\" />");
            sw.WriteLine("          <serviceDebug includeExceptionDetailInFaults=\"true\" />");
            sw.WriteLine("          <serviceCredentials>");
            sw.WriteLine("            <clientCertificate>");
            sw.WriteLine("              <authentication certificateValidationMode=\"None\" />");
            sw.WriteLine("            </clientCertificate>");
            sw.WriteLine("            <serviceCertificate findValue=\"MyServer\" storeLocation=\"LocalMachine\" x509FindType=\"FindBySubjectName\" />");
            sw.WriteLine("            <userNameAuthentication userNamePasswordValidationMode=\"Custom\" customUserNamePasswordValidatorType= \"" + BaseParams.WcfModelsNameSpace + ".MyUserNamePasswordValidator, " + BaseParams.WcfModelsNameSpace + "\" />");
            sw.WriteLine("          </serviceCredentials>");
            sw.WriteLine("        </behavior>");
            sw.WriteLine("      </serviceBehaviors>");
            sw.WriteLine("    </behaviors>");
            sw.WriteLine("    <bindings>");
            sw.WriteLine("      <wsHttpBinding>");
            sw.WriteLine("        <binding name=\"" + BaseParams.WcfModelsNameSpace + ".MainServiceHttpBinding\" maxReceivedMessageSize=\"655360\">");
            sw.WriteLine("          <readerQuotas maxStringContentLength=\"81920\" maxArrayLength=\"16384\"/>");
            sw.WriteLine("          <security mode=\"None\">");
            sw.WriteLine("            <message clientCredentialType=\"UserName\" />");
            sw.WriteLine("          </security>");
            sw.WriteLine("        </binding>");
            sw.WriteLine("      </wsHttpBinding>");
            sw.WriteLine("    </bindings>");
            sw.WriteLine("  </system.serviceModel>");
            sw.WriteLine("</configuration>");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
