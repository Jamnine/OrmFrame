using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Domain
{
    public class NbmXmlCoder
    {
        public static void Write(DbTable dt)
        {
            string path = BaseParams.DomainPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, dt.TitleCaseName + ".hbm.xml");

            #region 创建domain xml文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sw.WriteLine("<!-- =====================================================");
            sw.WriteLine("    作    者 : " + BaseParams.Author);
            sw.WriteLine("    创建时间 : " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sw.WriteLine("    修 改 者 : ");
            sw.WriteLine("    修改时间 : ");
            sw.WriteLine("    描    述 : " + dt.Comments);
            sw.WriteLine("===================================================== -->");
            sw.WriteLine("<hibernate-mapping xmlns=\"urn:nhibernate-mapping-2.2\">");
            sw.WriteLine("  <class name=\"" + BaseParams.DomainNameSpace + "." + dt.TitleCaseName + ", " + BaseParams.DomainNameSpace + "\" table=\"" + dt.Name + "\" lazy=\"true\">");
            DbColumn pdc = dt.Columns[0];
            if (dt.PrimaryKey != null && dt.PrimaryKey.Columns.Count > 0)
            {
                pdc = dt.PrimaryKey.Columns[0];
            }
            sw.WriteLine("    <id name=\"" + pdc.TitleCaseName + "\" column=\"" + pdc.MarkName + "\" type=\"" + pdc.FieldType.Replace("?", "") + "\"  length=\"" + pdc.Length + "\"  unsaved-value=\"null\">");
            if (pdc.IsForeignKey == false)
                sw.WriteLine("      <generator class=\"uuid.hex\" />");
            else
            {
                sw.WriteLine("      <generator class=\"foreign\">");
                sw.WriteLine("          <param name=\"property\">" + pdc.Table.ParentRelations[0].ParentTitleCaseName + "</param>");
                sw.WriteLine("      </generator>");
            }
            sw.WriteLine("    </id>");
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.Name.ToLower() == "data_version")
                    sw.WriteLine("    <version name=\"DataVersion\" column=\"DATA_VERSION\" type=\"Int32\"/>");
            }
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.Name.ToLower() == "data_create_time")
                    sw.WriteLine("    <property name=\"DataCreateTime\" column=\"DATA_CREATE_TIME\" type=\"DateTime\" insert=\"true\" update=\"false\"/>");
                else if (dc.Name.ToLower() == "data_update_time")
                    sw.WriteLine("    <property name=\"DataUpdateTime\" column=\"DATA_UPDATE_TIME\" type=\"DateTime\" insert=\"true\" update=\"true\"/>");
            }
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsPrimaryKey == false)
                {
                    if (dc.Name == pdc.Name)
                    {
                        continue;
                    }
                    sw.WriteLine("    <property name=\"" + dc.TitleCaseName + "\" column=\"" + dc.MarkName + "\" type=\"" + dc.FieldType.Replace("?", "") + "\" length=\"" + dc.Length + "\" />");
                }
            }
            sw.WriteLine("    <!-- 多对一/一对一/一对多关系-->");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                if (dr.ParentColumns[0].IsPrimaryKey == true && dr.ChildColumns[0].IsPrimaryKey == true)
                {
                    sw.WriteLine("    <one-to-one name=\"" + dr.ParentTitleCaseName + "\" class=\"" + BaseParams.DomainNameSpace + "." + dr.ParentTable.TitleCaseName + ", " + BaseParams.DomainNameSpace + "\" constrained=\"true\"/>");
                }
                else
                {
                    sw.WriteLine("    <many-to-one name=\"" + dr.ParentTitleCaseName + "\" column=\"" + dr.ChildColumns[0].MarkName + "\" unique=\"true\" fetch=\"select\" not-null=\"false\"  lazy=\"proxy\"/>");
                }
            }
            foreach (DbRelation dr in dt.ChildRelations)
            {
                if (dr.ParentColumns[0].IsPrimaryKey == true && dr.ChildColumns[0].IsPrimaryKey == true)
                {
                    sw.WriteLine("      <one-to-one name=\"" + dr.ChildTitleCaseName + "\" class=\"" + BaseParams.DomainNameSpace + "." + dr.ChildTable.TitleCaseName + ", " + BaseParams.DomainNameSpace + "\" cascade=\"all\"/>");
                }
                else
                {
                    sw.WriteLine("    <bag name=\"" + dr.ChildTitleCaseName + "\" inverse=\"true\" cascade=\"save-update\" lazy=\"true\">");
                    sw.WriteLine("      <key column=\"" + dr.ParentColumns[0].MarkName + "\" />");
                    sw.WriteLine("      <one-to-many class=\"" + BaseParams.DomainNameSpace + "." + dr.ChildTable.TitleCaseName + ", " + BaseParams.DomainNameSpace + "\" />");
                    sw.WriteLine("    </bag>");
                }
            }
            sw.WriteLine("  </class>");
            sw.WriteLine("</hibernate-mapping>");

            sw.Close();
            file.Close();
            #endregion
        }
    }
}
