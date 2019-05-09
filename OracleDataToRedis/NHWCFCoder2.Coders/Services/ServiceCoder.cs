using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.Services
{
    public class ServiceCoder
    {

        public static void Write(DbTable dt)
        {
            string path = BaseParams.ServicesPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, dt.TitleCaseName + "Service.cs");

            #region 创建domain cs文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments(dt.Comments, sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using NHibernate;");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.PersistenceNameSpace + ";");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ServicesNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    public class " + dt.TitleCaseName + "Service : BaseService<" + dt.TitleCaseName + ">");
            sw.WriteLine("    {");
            sw.WriteLine("        private static " + dt.TitleCaseName + "Service _instance = new " + dt.TitleCaseName + "Service();");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 实体数据操作对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public EntityDao<" + dt.TitleCaseName + "> " + dt.FieldCaseName + "Dao;");
            sw.WriteLine("        private " + dt.TitleCaseName + "Service()");
            sw.WriteLine("        {");
            sw.WriteLine("            this._" + dt.ParamCaseName + "Dao = new EntityDao<" + dt.TitleCaseName + ">();");
            sw.WriteLine("            // hql语句");
            sw.WriteLine("            this.hql_slf = \"  from " + dt.TitleCaseName + " " + dt.FieldCaseName + "\";");
            sw.WriteLine("            this.hql_pnt = \"  from " + dt.TitleCaseName + " " + dt.FieldCaseName + "\";");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            this.hql_pnt += \"  left join fetch " + dt.FieldCaseName + "." + dr.ParentTitleCaseName + " " + dr.ParentFieldCaseName + "\";");
            }
            //sw.WriteLine("            // 如有从表，此语句不能实施对主表的分页");
            //sw.WriteLine("            this.hql_son = \"  from " + dt.TitleCaseName + " " + dt.FieldCaseName + "\"; ");
            //foreach (DbRelation dr in dt.ChildRelations)
            //{
            //    if (dr.IncrementalValue == 1) // NH只能满足一个从表的连接
            //        sw.WriteLine("            this.hql_son += \"  left join fetch " + dt.FieldCaseName + "." + dr.ChildTitleCaseName + " " + dr.ChildFieldCaseName + "\";");
            //}
            //sw.WriteLine("            // 如有从表，此语句不能实施对主表的分页");
            //sw.WriteLine("            this.hql_pnt_son = \"  from " + dt.TitleCaseName + " " + dt.FieldCaseName + "\"; ");
            //foreach (DbRelation dr in dt.ParentRelations)
            //{
            //    sw.WriteLine("            this.hql_pnt_son += \"  left join fetch " + dt.FieldCaseName + "." + dr.ParentTitleCaseName + " " + dr.ParentFieldCaseName + "\"; ");
            //}
            //foreach (DbRelation dr in dt.ChildRelations)
            //{
            //    if (dr.IncrementalValue == 0) // NH只能满足一个从表的连接
            //        sw.WriteLine("            this.hql_pnt_son += \"  left join fetch " + dt.FieldCaseName + "." + dr.ChildTitleCaseName + " " + dr.ChildFieldCaseName + "\"; ");
            //}
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获得单件模式对象");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public static " + dt.TitleCaseName + "Service Instance");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return _instance; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            // 循环所有索引创建对应查询
            foreach (DbIndex di in dt.Indexes)
            {

                if (di.IsUnique == true)
                {
                    if (di.IsPrimaryKey == false)
                    {
                        sw.WriteLine("        /// <summary>");
                        sw.WriteLine("        /// 获取" + dt.Comments + "");
                        sw.WriteLine("        /// </summary>");
                        foreach (DbColumn dc in di.Columns)
                        {
                            sw.WriteLine("        /// <param name=\"" + dc.ParamCaseName + "\">" + dc.Comments + "</param>");
                        }
                        sw.WriteLine("        /// <param name=\"hsqtype\">查询类型</param>");
                        sw.WriteLine("        /// <returns>" + dt.Comments + "对象</returns>");
                        sw.WriteLine("        public " + dt.TitleCaseName + " Get" + dt.TitleCaseName + "By" + di.ColumnsString + "(" + di.ColumnParmsString + ", QueryType hsqtype)");
                        sw.WriteLine("        {");
                        int i = 0;
                        foreach (DbColumn dc in di.Columns)
                        {
                            i++;
                            if (i == 1)
                            {
                                sw.WriteLine("            string condi = \" where " + dt.FieldCaseName + "." + dc.TitleCaseName + " = ? \";");
                            }
                            else
                            {
                                sw.WriteLine("            condi += \" and " + dt.FieldCaseName + "." + dc.TitleCaseName + " = ? \";");
                            }
                        }
                        sw.WriteLine("            return this.UniqueResult(condi, hsqtype, " + di.ParamsString + ");");
                        sw.WriteLine("        }");
                        sw.WriteLine("");
                    }
                }
                else
                {
                    sw.WriteLine("        /// <summary>");
                    sw.WriteLine("        /// 获取" + dt.Comments + "列表");
                    sw.WriteLine("        /// </summary>");
                    foreach (DbColumn dc in di.Columns)
                    {
                        sw.WriteLine("        /// <param name=\"" + dc.ParamCaseName + "\">" + dc.Comments + "</param>");
                    }
                    sw.WriteLine("        /// <param name=\"hsqtype\">查询类型</param>");
                    sw.WriteLine("        /// <param name=\"paging\">分页对象</param>");
                    sw.WriteLine("        /// <returns>" + dt.Comments + "集合</returns>");
                    sw.WriteLine("        public IList<" + dt.TitleCaseName + "> Get" + dt.TitleCaseName + "By" + di.ColumnsString + "(" + di.ColumnParmsString + ", QueryType hsqtype, Paging paging)");
                    sw.WriteLine("        {");
                    int i = 0;
                    foreach (DbColumn dc in di.Columns)
                    {
                        i++;
                        if (i == 1)
                        {
                            sw.WriteLine("            string condi = \" where " + dt.FieldCaseName + "." + dc.TitleCaseName + " = ? \";");
                        }
                        else
                        {
                            sw.WriteLine("            condi += \" and " + dt.FieldCaseName + "." + dc.TitleCaseName + " = ? \";");
                        }
                    }
                    sw.WriteLine("            return this.GetEntitysByHqlCondi(condi, hsqtype, paging, " + di.ParamsString + ");");
                    sw.WriteLine("        }");
                    sw.WriteLine("");
                }
            }
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion
        }
    }
}
