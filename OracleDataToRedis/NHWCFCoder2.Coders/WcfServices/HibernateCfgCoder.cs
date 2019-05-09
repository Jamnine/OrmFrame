using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WcfServices
{
    public class HibernateCfgCoder
    {
        public static void Write()
        {
            string path = BaseParams.WcfServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建AppConfig
            string filepath = Path.Combine(path, "hibernate.cfg.xml");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<hibernate-configuration xmlns=\"urn:nhibernate-configuration-2.2\">");
            sw.WriteLine("<session-factory >");
            switch (DataBaseHelper.CurrentDbType)
            {
                case DataBaseType.Oracle9:
                    sw.WriteLine("  <property name=\"connection.provider\">NHibernate.Connection.DriverConnectionProvider</property>");
                    sw.WriteLine("   <property name=\"connection.driver_class\">NHibernate.Driver.OracleClientDriver </property>");
                    sw.WriteLine("   <property name=\"connection.connection_string\">" + DataBaseHelper.ConnectionString + "</property>");
                    sw.WriteLine("   <property name=\"show_sql\">true</property>");
                    sw.WriteLine("   <property name=\"dialect\">NHibernate.Dialect.Oracle9Dialect</property>");
                    sw.WriteLine("   <!--<property name=\"proxyfactory.factory_class\">NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle</property>--> ");
                    sw.WriteLine("   <property name=\"use_outer_join\">true</property>");
                    sw.WriteLine("   <mapping assembly=\"" + BaseParams.DomainNameSpace + "\" />");
                    break;
                case DataBaseType.SqlServer2005:
                case DataBaseType.SqlServer2008:
                    sw.WriteLine("   <property name=\"connection.provider\">NHibernate.Connection.DriverConnectionProvider</property>");
                    sw.WriteLine("   <property name=\"connection.driver_class\">NHibernate.Driver.SqlClientDriver</property>");
                    sw.WriteLine("   <property name=\"connection.connection_string\">" + DataBaseHelper.ConnectionString + "</property>");
                    sw.WriteLine("   <property name=\"show_sql\">true</property>");
                    sw.WriteLine("   <property name=\"dialect\">NHibernate.Dialect.MsSql2005Dialect</property>");
                    sw.WriteLine("   <property name=\"use_outer_join\">true</property>");
                    sw.WriteLine("   <mapping assembly=\"" + BaseParams.DomainNameSpace + "\" />");
                    break;
            }
            sw.WriteLine("</session-factory>");
            sw.WriteLine("</hibernate-configuration>");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
