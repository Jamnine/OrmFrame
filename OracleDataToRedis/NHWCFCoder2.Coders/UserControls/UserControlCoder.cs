using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.UserControls
{
    public class UserControlCreater
    {
        public static void Write(DbTable dt)
        {

            string path = Path.Combine(BaseParams.UserControlsPath, "Details");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类detail文件

            string className = Path.Combine(path, "Uc" + dt.TitleCaseName + "Detail.cs");
            FileStream file = new FileStream(className, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments(dt.Comments, sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.ControlsNameSpace + ";");
            //sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ";");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.UserControlsNameSpace + ".Details");
            sw.WriteLine("{");
            sw.WriteLine("    public partial class Uc" + dt.TitleCaseName + "Detail : MyUserControl");
            sw.WriteLine("    {");
            sw.WriteLine("        public Uc" + dt.TitleCaseName + "Detail()");
            sw.WriteLine("        {");
            sw.WriteLine("            InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private System.Windows.Forms.BindingSource " + dt.FieldCaseName + "bindingsource;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// " + dt.Comments + "");
            sw.WriteLine("        /// </summary> ");
            sw.WriteLine("        public System.Windows.Forms.BindingSource " + dt.TitleCaseName + "BindingSource");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this." + dt.FieldCaseName + "bindingsource; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                this." + dt.FieldCaseName + "bindingsource = value;");
            sw.WriteLine("                if (this." + dt.FieldCaseName + "bindingsource != null)");
            sw.WriteLine("                {");
            sw.WriteLine("                    // 在此处插入数据绑定的用户代码");
            sw.WriteLine("");
            sw.WriteLine("                    // 绑定数据源");
            sw.WriteLine("                    FormHelper.BindData(this, this." + dt.FieldCaseName + "bindingsource);");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("        private IList<" + dr.ParentTable.TitleCaseName + "> " + dr.ParentFieldCaseName + "List;");
                sw.WriteLine("        /// <summary>");
                sw.WriteLine("        /// " + dr.ParentTable.Comments + "");
                sw.WriteLine("        /// </summary> ");
                sw.WriteLine("        public IList<" + dr.ParentTable.TitleCaseName + "> " + dr.ParentTitleCaseName + "List");
                sw.WriteLine("        {");
                sw.WriteLine("            get { return this." + dr.ParentFieldCaseName + "List; }");
                sw.WriteLine("            set");
                sw.WriteLine("            {");
                sw.WriteLine("                this." + dr.ParentFieldCaseName + "List = value;");
                sw.WriteLine("                if (this." + dr.ParentFieldCaseName + "List != null)");
                sw.WriteLine("                {");
                sw.WriteLine("                    // 绑定数据源");
                sw.WriteLine("                    this.cbb" + dr.ParentTitleCaseName + ".DataSource = this." + dr.ParentTitleCaseName + "List;");
                bool displayMemberCreated = false;
                foreach (DbColumn col in dr.ParentTable.Columns)
                {
                    if (col.Name.ToLower().Contains("name") || col.Name.ToLower().Contains("title"))
                    {
                        sw.WriteLine("                    this.cbb" + dr.ParentTitleCaseName + ".DisplayMember = \"" + col.TitleCaseName + "\";");
                        displayMemberCreated = true;
                        break;
                    }
                }
                if (displayMemberCreated == false)
                    sw.WriteLine("                    this.cbb" + dr.ParentTitleCaseName + ".DisplayMember = \"" + dr.ParentColumns[0].TitleCaseName + "\";");
                sw.WriteLine("                    this.cbb" + dr.ParentTitleCaseName + ". ValueMember= \"" + dr.ParentColumns[0].TitleCaseName + "\";");
                sw.WriteLine("                }");
                sw.WriteLine("            }");
                sw.WriteLine("        }");
                sw.WriteLine("");
            }

            sw.WriteLine("");
            sw.WriteLine("        public void ConstrolsDataDefault()");
            sw.WriteLine("        {");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            this.cbb" + dr.ParentTable.TitleCaseName + ".SelectedIndex = -1;");
            }
            sw.WriteLine("        }");

            sw.WriteLine("        private void Data_Validating(object sender, CancelEventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (((Control)sender).Text.Trim() == \"\" && ((IControlBind)sender).Nullable == false)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.ErrorProvider.SetError((Control)sender, \"此为必填项,不允许为空！\");");
            sw.WriteLine("                e.Cancel = true;");
            sw.WriteLine("            }");
            sw.WriteLine("            if (sender is ComboBox && ((IControlBind)sender).Nullable == false");
            sw.WriteLine("              && ((Control)sender).Text.Trim() != \"\" && ((ComboBox)sender).SelectedIndex < 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.ErrorProvider.SetError((Control)sender, \"所输入的值超出对应范围！\");");
            sw.WriteLine("                e.Cancel = true;");
            sw.WriteLine("            }");
            sw.WriteLine("            int textLength = Encoding.Default.GetByteCount(((Control)sender).Text);");
            sw.WriteLine("            TextBoxBase txt = sender as TextBoxBase;");
            sw.WriteLine("            if(txt != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                int maxLength = txt.MaxLength;");
            sw.WriteLine("                if ( textLength > maxLength)");
            sw.WriteLine("                {");
            sw.WriteLine("                    this.ErrorProvider.SetError((Control)sender, \"输入的字符串长度(\" + textLength.ToString() + \")超过指定的长度(\" + maxLength.ToString() + \")！\");");
            sw.WriteLine("                    e.Cancel = true;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            if (e.Cancel == false)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.ErrorProvider.SetError((Control)sender, \"\");");
            sw.WriteLine("            }");
            sw.WriteLine("            else");
            sw.WriteLine("            {");
            sw.WriteLine("                return;");
            sw.WriteLine("            }");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            if (this.cbb" + dr.ParentTitleCaseName + ".SelectedItem != null");
                sw.WriteLine("              && (((" + dt.TitleCaseName + ")this." + dt.FieldCaseName + "bindingsource.Current)." + dr.ParentTitleCaseName + " == null");
                sw.WriteLine("              || ((" + dt.TitleCaseName + ")this." + dt.FieldCaseName + "bindingsource.Current)." + dr.ParentTitleCaseName + "."
                    + dr.ParentColumns[0].TitleCaseName + " != ((" + dr.ParentTable.TitleCaseName + ")this.cbb" + dr.ParentTitleCaseName + ".SelectedItem)." + dr.ParentColumns[0].TitleCaseName + "))");
                sw.WriteLine("            {");
                sw.WriteLine("                ((" + dt.TitleCaseName + ")this." + dt.FieldCaseName + "bindingsource.Current)." + dr.ParentTitleCaseName
                                              + " = (" + dr.ParentTable.TitleCaseName + ")this.cbb" + dr.ParentTitleCaseName + ".SelectedItem;");
                sw.WriteLine("                this." + dt.TitleCaseName + "BindingSource.ResetCurrentItem();");
                sw.WriteLine("            }");
            }
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion

            #region 创建detail Designer类文件

            className = Path.Combine(path, "Uc" + dt.TitleCaseName + "Detail.Designer.cs");
            file = new FileStream(className, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("namespace " + BaseParams.UserControlsNameSpace + ".Details");
            sw.WriteLine("{");
            sw.WriteLine("    partial class Uc" + dt.TitleCaseName + "Detail");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 必需的设计器变量。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private System.ComponentModel.IContainer components = null;");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 清理所有正在使用的资源。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"disposing\">如果应释放托管资源,为 true；否则为 false。</param>");
            sw.WriteLine("        protected override void Dispose(bool disposing)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (disposing && (components != null))");
            sw.WriteLine("            {");
            sw.WriteLine("                components.Dispose();");
            sw.WriteLine("            }");
            sw.WriteLine("            base.Dispose(disposing);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #region 组件设计器生成的代码");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 设计器支持所需的方法 - 不要");
            sw.WriteLine("        /// 使用代码编辑器修改此方法的内容。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.components = new System.ComponentModel.Container();");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyComboBox();");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyLabel();");
            }

            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    switch (dc.FieldType)
                    {
                        case "DateTime?":
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyDateTimePicker();");
                            break;
                        default:
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyTextBox();");
                            break;
                    }
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyLabel();");
                }
            }

            sw.WriteLine("            this.ErrorProvider = new " + BaseParams.ControlsNameSpace + ".MyErrorProvider();");
            sw.WriteLine("            this.SuspendLayout();");

            int y = 9; // 设置控件高度            
            int tabindex = 0; // 设置tab顺序键值
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            // ");
                sw.WriteLine("            // lbl" + dr.ParentTitleCaseName + "");
                sw.WriteLine("            // ");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".AutoSize = true;");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".Location = new System.Drawing.Point(3, " + (y + 4) + ");");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".Name = \"lbl" + dr.ParentTitleCaseName + "\";");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".Size = new System.Drawing.Size(53, 12);");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".TabIndex = 0;");
                sw.WriteLine("            this.lbl" + dr.ParentTitleCaseName + ".Text = \"" + dr.ParentTable.Comments + "\";");
                sw.WriteLine("            // ");
                sw.WriteLine("            // cbb" + dr.ParentTitleCaseName + "");
                sw.WriteLine("            // ");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".IsNeedBind = true;");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".Location = new System.Drawing.Point(62, " + y + ");");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".Name = \"cbb" + dr.ParentTitleCaseName + "\";");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".FieldName = \"" + dr.ParentTitleCaseName + "_" + dr.ParentColumns[0].TitleCaseName + "\";");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".MaxLength = " + dr.ParentColumns[0].Length + ";");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".Nullable = " + dr.ParentColumns[0].Nullable.ToString().ToLower() + ";");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".Size = new System.Drawing.Size(240, 21);");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".TabIndex = " + tabindex.ToString() + ";");
                sw.WriteLine("            this.cbb" + dr.ParentTitleCaseName + ".Validating += new System.ComponentModel.CancelEventHandler(this.Data_Validating);");
                y += 30;
                tabindex++;
            }
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    sw.WriteLine("            // ");
                    sw.WriteLine("            // lbl" + dc.TitleCaseName + "");
                    sw.WriteLine("            // ");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".AutoSize = true;");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".Location = new System.Drawing.Point(3, " + (y + 4) + ");");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".Name = \"lbl" + dc.TitleCaseName + "\";");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".Size = new System.Drawing.Size(53, 12);");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".TabIndex = 0;");
                    sw.WriteLine("            this.lbl" + dc.TitleCaseName + ".Text = \"" + dc.Comments + "\";");
                    switch (dc.FieldType)
                    {
                        case "DateTime?":
                            sw.WriteLine("            // ");
                            sw.WriteLine("            // dtp" + dc.TitleCaseName + "");
                            sw.WriteLine("            // ");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".IsNeedBind = true;");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".Location = new System.Drawing.Point(62, " + y + ");");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".Name = \"dtp" + dc.TitleCaseName + "\";");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".Size = new System.Drawing.Size(240, 21);");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".TabIndex = " + tabindex.ToString() + ";");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".Nullable = " + dc.Nullable.ToString().ToLower() + ";");
                            sw.WriteLine("            this.dtp" + dc.TitleCaseName + ".Validating += new System.ComponentModel.CancelEventHandler(this.Data_Validating);");
                            break;
                        default:
                            sw.WriteLine("            // ");
                            sw.WriteLine("            // txt" + dc.TitleCaseName + "");
                            sw.WriteLine("            // ");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".IsNeedBind = true;");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".Location = new System.Drawing.Point(62, " + y.ToString() + ");");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".Name = \"txt" + dc.TitleCaseName + "\";");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".MaxLength = " + dc.Length + ";");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".Nullable = " + dc.Nullable.ToString().ToLower() + ";");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".Size = new System.Drawing.Size(240, 21);");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".TabIndex = " + tabindex.ToString() + ";");
                            if (dc.FieldType.ToLower() == "decimal?")
                                sw.WriteLine("            this.txt" + dc.TitleCaseName + ".TextAlign = System.Windows.Forms.HorizontalAlignment.Right;");
                            sw.WriteLine("            this.txt" + dc.TitleCaseName + ".Validating += new System.ComponentModel.CancelEventHandler(this.Data_Validating);");
                            break;
                    }
                    y += 30;
                    tabindex++;
                }
            }

            sw.WriteLine("            // ");
            sw.WriteLine("            // ErrorProvider");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.ErrorProvider.ContainerControl = this;");
            sw.WriteLine("            // ");
            sw.WriteLine("            // Uc" + dt.TitleCaseName + "Detail");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);");
            sw.WriteLine("            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;");

            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            this.Controls.Add(this.cbb" + dr.ParentTitleCaseName + ");");
                sw.WriteLine("            this.Controls.Add(this.lbl" + dr.ParentTitleCaseName + ");");
            }
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    switch (dc.FieldType)
                    {
                        case "DateTime?":
                            sw.WriteLine("            this.Controls.Add(this.dtp" + dc.TitleCaseName + ");");
                            break;
                        default:
                            sw.WriteLine("            this.Controls.Add(this.txt" + dc.TitleCaseName + ");");
                            break;
                    }
                    sw.WriteLine("            this.Controls.Add(this.lbl" + dc.TitleCaseName + ");");
                }
            }
            sw.WriteLine("            this.Name = \"Uc" + dt.TitleCaseName + "Detail\";");
            sw.WriteLine("            this.Size = new System.Drawing.Size(437, 164);");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("            this.PerformLayout();");
            sw.WriteLine("");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("        public " + BaseParams.ControlsNameSpace + ".MyComboBox cbb" + dr.ParentTitleCaseName + ";");
                sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyLabel lbl" + dr.ParentTitleCaseName + ";");
            }
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    switch (dc.FieldType)
                    {
                        case "DateTime?":
                            sw.WriteLine("        public " + BaseParams.ControlsNameSpace + ".MyDateTimePicker dtp" + dc.TitleCaseName + ";");
                            break;
                        default:
                            sw.WriteLine("        public " + BaseParams.ControlsNameSpace + ".MyTextBox txt" + dc.TitleCaseName + ";");
                            break;
                    }
                    sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyLabel lbl" + dc.TitleCaseName + ";");
                }
            }
            sw.WriteLine("        public " + BaseParams.ControlsNameSpace + ".MyErrorProvider ErrorProvider;");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion

            path = Path.Combine(BaseParams.UserControlsPath, "Grids");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类grid文件

            className = Path.Combine(path, "Uc" + dt.TitleCaseName + "Grid.cs");
            file = new FileStream(className, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments(dt.Comments, sw);
            sw.WriteLine("");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.ControlsNameSpace + ";");
            //sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ";");

            sw.WriteLine("namespace " + BaseParams.UserControlsNameSpace + ".Grids");
            sw.WriteLine("{");
            sw.WriteLine("    public partial class Uc" + dt.TitleCaseName + "Grid : MyUserControl");
            sw.WriteLine("    {");
            sw.WriteLine("        public Uc" + dt.TitleCaseName + "Grid()");
            sw.WriteLine("        {");
            sw.WriteLine("            InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private System.Windows.Forms.BindingSource " + dt.FieldCaseName + "bindingsource;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// " + dt.Comments + "");
            sw.WriteLine("        /// </summary> ");
            sw.WriteLine("        public System.Windows.Forms.BindingSource " + dt.TitleCaseName + "BindingSource");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this." + dt.FieldCaseName + "bindingsource; }");
            sw.WriteLine("            set");
            sw.WriteLine("            {");
            sw.WriteLine("                this." + dt.FieldCaseName + "bindingsource = value;");
            sw.WriteLine("                if (this." + dt.FieldCaseName + "bindingsource != null)");
            sw.WriteLine("                {");
            sw.WriteLine("                    // 在此处插入数据绑定的用户代码");
            sw.WriteLine("");
            sw.WriteLine("                    // 绑定数据源");
            sw.WriteLine("                    this.dgv" + dt.TitleCaseName + ".DataSource = this." + dt.FieldCaseName + "bindingsource;");
            sw.WriteLine("                    // 让所有列宽自动调整一下。");
            sw.WriteLine("                    this.dgv" + dt.TitleCaseName + ".AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            #region 已注释
            //foreach (DbParentTable dpt in dt.DbParentTables)
            //{
            //    sw.WriteLine("        private IList<" + dpt.TitleCaseName + "> " + dpt.FieldCaseName + "List;");
            //    sw.WriteLine("        /// <summary>");
            //    sw.WriteLine("        /// " + dpt.Comments + "");
            //    sw.WriteLine("        /// </summary> ");
            //    sw.WriteLine("        public IList<" + dpt.TitleCaseName + "> " + dpt.TitleCaseName + "List");
            //    sw.WriteLine("        {");
            //    sw.WriteLine("            get { return this." + dpt.FieldCaseName + "List; }");
            //    sw.WriteLine("            set");
            //    sw.WriteLine("            {");
            //    sw.WriteLine("                this." + dpt.FieldCaseName + "List = value;");
            //    sw.WriteLine("                if (this." + dpt.FieldCaseName + "List != null)");
            //    sw.WriteLine("                {");
            //    sw.WriteLine("                    // 绑定数据源");
            //    sw.WriteLine("                    this.clm" + dpt.Columns[0].TitleCaseName + ".DataSource = this." + dpt.FieldCaseName + "List;");
            //    sw.WriteLine("                    this.clm" + dpt.Columns[0].TitleCaseName + ".DisplayMember = \"" + dpt.Columns[0].TitleCaseName + "\";");
            //    sw.WriteLine("                    this.clm" + dpt.Columns[0].TitleCaseName + ".ValueMember = \"" + dpt.Columns[0].TitleCaseName + "\";");
            //    sw.WriteLine("                }");
            //    sw.WriteLine("            }");
            //    sw.WriteLine("        }");
            //    sw.WriteLine("");
            //}
            #endregion
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion

            #region 创建类grid Designer文件

            className = Path.Combine(path, "Uc" + dt.TitleCaseName + "Grid.Designer.cs");
            file = new FileStream(className, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("namespace " + BaseParams.UserControlsNameSpace + ".Grids");
            sw.WriteLine("{");
            sw.WriteLine("    partial class Uc" + dt.TitleCaseName + "Grid");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 必需的设计器变量。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private System.ComponentModel.IContainer components = null;");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 清理所有正在使用的资源。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        /// <param name=\"disposing\">如果应释放托管资源,为 true；否则为 false。</param>");
            sw.WriteLine("        protected override void Dispose(bool disposing)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (disposing && (components != null))");
            sw.WriteLine("            {");
            sw.WriteLine("                components.Dispose();");
            sw.WriteLine("            }");
            sw.WriteLine("            base.Dispose(disposing);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #region 组件设计器生成的代码");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary> ");
            sw.WriteLine("        /// 设计器支持所需的方法 - 不要");
            sw.WriteLine("        /// 使用代码编辑器修改此方法的内容。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.components = new System.ComponentModel.Container();");
            sw.WriteLine("            this.dgv" + dt.TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyDataGridView();");
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + " = new System.Windows.Forms.DataGridViewTextBoxColumn();");
            }
            if (BaseParams.IsGenerateParentProperty == true)
            {
                foreach (DbRelation dr in dt.ParentRelations)
                {
                    DbTable dpt = dr.ParentTable;
                    foreach (DbColumn dc in dpt.Columns)
                    {
                        if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + " = new System.Windows.Forms.DataGridViewTextBoxColumn();");
                    }
                }
            }
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this.dgv" + dt.TitleCaseName + ")).BeginInit();");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // dgv" + dt.TitleCaseName + "");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.dgv" + dt.TitleCaseName + ".Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {");
            int i = 0;
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    if (i == 0)
                        sw.WriteLine("            this.clm" + dc.TitleCaseName);
                    else
                        sw.WriteLine("            , this.clm" + dc.TitleCaseName);
                    i++;
                }
            }

            if (BaseParams.IsGenerateParentProperty == true)
            {
                foreach (DbRelation dr in dt.ParentRelations)
                {
                    DbTable dpt = dr.ParentTable;
                    foreach (DbColumn dc in dpt.Columns)
                    {
                        if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                            sw.WriteLine("            , this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + "");
                    }
                }
            }
            sw.Write("});");

            sw.WriteLine("            this.dgv" + dt.TitleCaseName + ".Dock = System.Windows.Forms.DockStyle.Fill;");
            sw.WriteLine("            this.dgv" + dt.TitleCaseName + ".Location = new System.Drawing.Point(0, 0);");
            sw.WriteLine("            this.dgv" + dt.TitleCaseName + ".Name = \"dgv" + dt.TitleCaseName + "\";");
            sw.WriteLine("            this.dgv" + dt.TitleCaseName + ".TabIndex = 0;");
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    sw.WriteLine("            // ");
                    sw.WriteLine("            // clm" + dc.TitleCaseName + "");
                    sw.WriteLine("            // ");
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + ".DataPropertyName = \"" + dc.TitleCaseName + "\";");
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + ".HeaderText = \"" + dc.Comments + "\";");
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + ".Name = \"clm" + dc.TitleCaseName + "\";");
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + ".ReadOnly = true;");
                    sw.WriteLine("            this.clm" + dc.TitleCaseName + ".Width = 80;");
                    if (dc.FieldType == "DateTime?")
                        sw.WriteLine("            this.clm" + dc.TitleCaseName + ".DefaultCellStyle.Format = \"yyyy-MM-dd\";");
                    else if (dc.FieldType.ToLower() == "decimal?")
                        sw.WriteLine("            this.clm" + dc.TitleCaseName + ".DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;");
                }
            }

            if (BaseParams.IsGenerateParentProperty == true)
            {
                foreach (DbRelation dr in dt.ParentRelations)
                {
                    DbTable dpt = dr.ParentTable;
                    foreach (DbColumn dc in dpt.Columns)
                    {
                        if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                        {
                            sw.WriteLine("            // ");
                            sw.WriteLine("            // clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + "");
                            sw.WriteLine("            // ");
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".DataPropertyName = \"" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + "\";");
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".HeaderText = \"" + dc.Comments + "\";");
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".Name = \"clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + "\";");
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".ReadOnly = true;");
                            sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".Width = 80;");
                            if (dc.FieldType == "DateTime?")
                                sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".DefaultCellStyle.Format = \"yyyy-MM-dd\";");
                            else if (dc.FieldType.ToLower() == "decimal?")
                                sw.WriteLine("            this.clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ".DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;");
                        }
                    }
                }
            }

            sw.WriteLine("            // ");
            sw.WriteLine("            // Uc" + dt.TitleCaseName + "Grid");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);");
            sw.WriteLine("            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;");
            sw.WriteLine("            this.Controls.Add(this.dgv" + dt.TitleCaseName + ");");
            sw.WriteLine("            this.Name = \"Uc" + dt.TitleCaseName + "Grid\";");
            sw.WriteLine("            this.Size = new System.Drawing.Size(660, 326);");
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this.dgv" + dt.TitleCaseName + ")).EndInit();");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        public " + BaseParams.ControlsNameSpace + ".MyDataGridView dgv" + dt.TitleCaseName + ";");
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                    sw.WriteLine("        private System.Windows.Forms.DataGridViewTextBoxColumn clm" + dc.TitleCaseName + ";");
            }

            if (BaseParams.IsGenerateParentProperty == true)
            {
                foreach (DbRelation dr in dt.ParentRelations)
                {
                    DbTable dpt = dr.ParentTable;
                    foreach (DbColumn dc in dpt.Columns)
                    {
                        if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                            sw.WriteLine("        private System.Windows.Forms.DataGridViewTextBoxColumn clm" + dr.ParentTitleCaseName + "_" + dc.TitleCaseName + ";");
                    }
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
