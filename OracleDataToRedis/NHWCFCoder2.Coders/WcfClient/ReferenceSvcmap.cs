using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfClient
{
    public class ReferenceSvcmap
    {
        public static void Write()
        {
            string path = Path.Combine(BaseParams.WcfClientPath,"Service References\\ServiceReference1");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建WcfClientFactory类
            string filepath = Path.Combine(path, "Reference.svcmap");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<ReferenceGroup xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" ID=\"0305e66a-53c0-4455-9137-c796bd3963d6\" xmlns=\"urn:schemas-microsoft-com:xml-wcfservicemap\">");
            sw.WriteLine("  <ClientOptions>");
            sw.WriteLine("    <GenerateAsynchronousMethods>false</GenerateAsynchronousMethods>");
            sw.WriteLine("    <EnableDataBinding>true</EnableDataBinding>");
            sw.WriteLine("    <ExcludedTypes />");
            sw.WriteLine("    <ImportXmlTypes>false</ImportXmlTypes>");
            sw.WriteLine("    <GenerateInternalTypes>false</GenerateInternalTypes>");
            sw.WriteLine("    <GenerateMessageContracts>false</GenerateMessageContracts>");
            sw.WriteLine("    <NamespaceMappings />");
            sw.WriteLine("    <CollectionMappings>");
            sw.WriteLine("      <CollectionMapping TypeName=\"System.Collections.Generic.List`1\" Category=\"List\" />");
            sw.WriteLine("    </CollectionMappings>");
            sw.WriteLine("    <GenerateSerializableTypes>true</GenerateSerializableTypes>");
            sw.WriteLine("    <Serializer>Auto</Serializer>");
            sw.WriteLine("    <ReferenceAllAssemblies>true</ReferenceAllAssemblies>");
            sw.WriteLine("    <ReferencedAssemblies />");
            sw.WriteLine("    <ReferencedDataContractTypes />");
            sw.WriteLine("    <ServiceContractMappings />");
            sw.WriteLine("  </ClientOptions>");
            sw.WriteLine("  <MetadataSources>");
            sw.WriteLine("    <MetadataSource Address=\"http://localhost:" + BaseParams.WcfServicePort + "/MainService.svc\" Protocol=\"http\" SourceId=\"1\" />");
            sw.WriteLine("  </MetadataSources>");
            sw.WriteLine("  <Metadata>");
            sw.WriteLine("  </Metadata>");
            sw.WriteLine("  <Extensions>");
            sw.WriteLine("    <ExtensionFile FileName=\"configuration91.svcinfo\" Name=\"configuration91.svcinfo\" />");
            sw.WriteLine("    <ExtensionFile FileName=\"configuration.svcinfo\" Name=\"configuration.svcinfo\" />");
            sw.WriteLine("  </Extensions>");
            sw.WriteLine("</ReferenceGroup>");

            sw.Close();
            file.Close();
            #endregion
        }
    }
}
