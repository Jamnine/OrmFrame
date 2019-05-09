using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Domain;

namespace OracleDataToRedis.Coders.Domain
{
    public class DomainCoder
    {
        public static void Write(DbTable table)
        {
            string path = BaseParams.DomainPath;
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path, table.TitleCaseName + ".cs");

            #region 创建domain cs文件
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            CommentsCoder.CreateCsComments(table.Comments, sw);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Runtime.Serialization;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.DomainNameSpace + "");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine("    /// " + table.Comments + "类型");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine("    [Serializable]");
            sw.WriteLine("    [DataContract(IsReference = true)]");
            sw.WriteLine("    public class " + table.TitleCaseName + " : BaseEntity");
            sw.WriteLine("    {");
            sw.WriteLine("        #region 私有变量");
            foreach (DbColumn dc in table.Columns)
            {
                if (dc.IsGenerateField == true)
                    sw.WriteLine("        private " + dc.FieldType + " " + dc.FieldCaseName + "; // " + dc.Comments + "");
            }
            foreach (DbRelation dr in table.ParentRelations)
            {
                sw.WriteLine("        private " + dr.ParentTable.TitleCaseName + " " + dr.ParentFieldCaseName + "; // " + dr.ParentTable.Comments + "");
            }
            foreach (DbRelation dr in table.ChildRelations)
            {
                if (dr.ParentColumns[0].IsPrimaryKey == true && dr.ChildColumns[0].IsPrimaryKey == true)
                    sw.WriteLine("        private " + dr.ChildTable.TitleCaseName + " " + dr.ChildFieldCaseName + "; // " + dr.ChildTable.Comments + "");
                else
                    sw.WriteLine("        private IList<" + dr.ChildTable.TitleCaseName + "> " + dr.ChildFieldCaseName + "; // " + dr.ChildTable.Comments + "");
            }
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 构造函数");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 构造函数");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public " + table.TitleCaseName + "()");
            sw.WriteLine("        {");
            sw.WriteLine("            ");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 构造函数");
            sw.WriteLine("        /// </summary>");
            foreach (DbColumn dc in table.Columns)
            {
                if (dc.IsGenerateField == true)
                    sw.WriteLine("        /// <param name=\"" + dc.ParamCaseName + "\">" + dc.Comments + "</param>");
            }
            sw.WriteLine("        public " + table.TitleCaseName + "(" + table.ConstractParams + ")");
            sw.WriteLine("        {");
            foreach (DbColumn dc in table.Columns)
            {
                if (dc.IsGenerateField == true)
                    sw.WriteLine("            this." + dc.TitleCaseName + " = " + dc.ParamCaseName + ";");
            }
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        #region 公共属性");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 获取对象的主键.");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public override object EntityID");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                return this." + table.PrimaryKey.Columns[0].FieldCaseName + ";");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            foreach (DbColumn dc in table.Columns)
            {
                if (dc.IsGenerateField == true)
                {
                    sw.WriteLine("        /// <summary>");
                    sw.WriteLine("        /// " + dc.Comments + "");
                    sw.WriteLine("        /// </summary> ");
                    sw.WriteLine("        [DataMember]");
                    sw.WriteLine("        public virtual " + dc.FieldType + " " + dc.TitleCaseName + "");
                    sw.WriteLine("        {");
                    sw.WriteLine("            get");
                    sw.WriteLine("            {");
                    sw.WriteLine("                return " + dc.FieldCaseName + ";");
                    sw.WriteLine("            }");
                    sw.WriteLine("            set");
                    sw.WriteLine("            {");
                    //if (dc.FieldType == "String")
                    //{
                    //    sw.WriteLine("                if (value != null && Encoding.Default.GetByteCount(value.ToString()) > " + dc.ColumnLength + ")");
                    //    sw.WriteLine("                    throw new ArgumentOutOfRangeException(\"" + dc.TitleCaseName + "\", value.ToString(), \"" + dc.Comments + "_长度超出限制(" + dc.ColumnLength + ")!\");");
                    //}
                    if (dc.FieldType.ToLower() == "decimal?")
                    {
                        sw.WriteLine("                if (value != null)");
                        sw.WriteLine("                {");
                        sw.WriteLine("                    value = Decimal.Parse(value.Value.ToString(\"0.0000\"));");
                        sw.WriteLine("                    value = Decimal.Round(value.Value, 4, MidpointRounding.AwayFromZero);");
                        sw.WriteLine("                }");
                        sw.WriteLine("");
                    }
                    sw.WriteLine("                _isChanged |= (" + dc.FieldCaseName + " != value); ");
                    sw.WriteLine("                " + dc.FieldCaseName + " = value;");
                    sw.WriteLine("            }");
                    sw.WriteLine("        }");
                    sw.WriteLine("");
                }
            }

            foreach (DbRelation dr in table.ParentRelations)
            {
                sw.WriteLine("        /// <summary>");
                sw.WriteLine("        /// " + dr.ParentTable.Comments + "");
                sw.WriteLine("        /// </summary> ");
                sw.WriteLine("        [DataMember]");
                sw.WriteLine("        public virtual " + dr.ParentTable.TitleCaseName + " " + dr.ParentTitleCaseName + "");
                sw.WriteLine("        {");
                sw.WriteLine("            get");
                sw.WriteLine("            {");
                //sw.WriteLine("                if(this." + dr.ParentFieldCaseName + " == null)");
                //sw.WriteLine("                    this." + dr.ParentFieldCaseName + " = new " + dr.ParentTable.TitleCaseName + "();");
                sw.WriteLine("                return " + dr.ParentFieldCaseName + ";");
                sw.WriteLine("            }");
                sw.WriteLine("            set");
                sw.WriteLine("            {");
                sw.WriteLine("                _isChanged |= (value != null); " + dr.ParentFieldCaseName + " = value;");
                sw.WriteLine("            }");
                sw.WriteLine("        }");
                sw.WriteLine("");
            }

            foreach (DbRelation dr in table.ChildRelations)
            {
                sw.WriteLine("        /// <summary>");
                sw.WriteLine("        /// " + dr.ChildTable.Comments + "");
                sw.WriteLine("        /// </summary> ");
                if (dr.ParentColumns[0].IsPrimaryKey == true && dr.ChildColumns[0].IsPrimaryKey == true)
                {
                    sw.WriteLine("        [DataMember]");
                    sw.WriteLine("        public virtual " + dr.ChildTable.TitleCaseName + " " + dr.ChildTitleCaseName + "");
                    sw.WriteLine("        {");
                    sw.WriteLine("            get");
                    sw.WriteLine("            {");
                    sw.WriteLine("                return " + dr.ChildFieldCaseName + ";");
                    sw.WriteLine("            }");
                    sw.WriteLine("            set");
                    sw.WriteLine("            {");
                    sw.WriteLine("                _isChanged |= (value != null); " + dr.ChildFieldCaseName + " = value;");
                    sw.WriteLine("            }");
                    sw.WriteLine("        }");
                    sw.WriteLine("");
                }
                else
                {
                    sw.WriteLine("        [DataMember]");
                    sw.WriteLine("        public virtual IList<" + dr.ChildTable.TitleCaseName + "> " + dr.ChildTitleCaseName + "");
                    sw.WriteLine("        {");
                    sw.WriteLine("            get");
                    sw.WriteLine("            {");
                    sw.WriteLine("                return " + dr.ChildFieldCaseName + " = (" + dr.ChildFieldCaseName + " == null) ? (new List<" + dr.ChildTable.TitleCaseName + ">()) : " + dr.ChildFieldCaseName + ";");
                    sw.WriteLine("            }");
                    sw.WriteLine("            set");
                    sw.WriteLine("            {");
                    sw.WriteLine("                " + dr.ChildFieldCaseName + " = value;");
                    sw.WriteLine("            }");
                    sw.WriteLine("        }");
                    sw.WriteLine("");
                }
            }

            if (BaseParams.IsGenerateParentProperty == true)
            {
                // 在子表中创建父表属性
                foreach (DbRelation dr in table.ParentRelations)
                {
                    foreach (DbColumn pdc in dr.ParentTable.Columns)
                    {
                        if (pdc.IsPrimaryKey == true)
                        {
                            sw.WriteLine("        /// <summary>");
                            sw.WriteLine("        /// " + pdc.Comments + "");
                            sw.WriteLine("        /// </summary> ");
                            sw.WriteLine("        public virtual " + pdc.FieldType + " " + dr.ParentTitleCaseName + "_" + pdc.TitleCaseName + "");
                            sw.WriteLine("        {");
                            sw.WriteLine("            get");
                            sw.WriteLine("            {");
                            sw.WriteLine("                return (this." + dr.ParentTitleCaseName + " == null) ? null : this." + dr.ParentTitleCaseName + "." + pdc.TitleCaseName + ";");
                            sw.WriteLine("            }");
                            sw.WriteLine("        }");
                            sw.WriteLine("");
                        }
                    }
                }
            }
            sw.WriteLine("        #endregion");
            sw.WriteLine("      }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion
        }
    }
}
