using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WinFroms
{
    public class ManagerFormDesignerCoder
    {
        public static void Write(DbTable dt)
        {

            string path = Path.Combine(BaseParams.WinFromsPath, "ManagerForms");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类detail文件

            string className = Path.Combine(path, "frm" + dt.TitleCaseName + "Mng.Designer.cs");
            FileStream file = new FileStream(className, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments(dt.Comments, sw);
            sw.WriteLine("namespace " + BaseParams.WinFromsNameSpace + ".ManagerForms");
            sw.WriteLine("{");
            sw.WriteLine("    partial class frm" + dt.TitleCaseName + "Mng");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 必需的设计器变量。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private System.ComponentModel.IContainer components = null;");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
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
            sw.WriteLine("        #region Windows 窗体设计器生成的代码");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 设计器支持所需的方法 - 不要");
            sw.WriteLine("        /// 使用代码编辑器修改此方法的内容。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.components = new System.ComponentModel.Container();");
            sw.WriteLine("            this.myPanel1 = new " + BaseParams.ControlsNameSpace + ".MyPanel();");

            if (dt.PrimaryKey != null)
            {
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyLabel();");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + " = new " + BaseParams.ControlsNameSpace + ".MyTextBox();");
            }
            sw.WriteLine("            this.btnSelect = new " + BaseParams.ControlsNameSpace + ".MyButton();");
            sw.WriteLine("            this.btnClose = new " + BaseParams.ControlsNameSpace + ".MyButton();");
            sw.WriteLine("            this." + dt.TitleCaseName + "BindingSource = new System.Windows.Forms.BindingSource(this.components);");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1 = new " + BaseParams.UserControlsNameSpace + ".Grids.Uc" + dt.TitleCaseName + "Grid();");
            sw.WriteLine("            this.myPanel2 = new " + BaseParams.ControlsNameSpace + ".MyPanel();");
            sw.WriteLine("            this.ucPaging1 = new " + BaseParams.UserControlsNameSpace + ".Utility.UcPaging();");
            sw.WriteLine("            this.myPanel3 = new " + BaseParams.ControlsNameSpace + ".MyPanel();");
            sw.WriteLine("            this.btnDelete = new " + BaseParams.ControlsNameSpace + ".MyButton();");
            sw.WriteLine("            this.btnEdit = new " + BaseParams.ControlsNameSpace + ".MyButton();");
            sw.WriteLine("            this.btnAdd = new " + BaseParams.ControlsNameSpace + ".MyButton();");
            sw.WriteLine("            this.myPanel1.SuspendLayout();");
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this." + dt.TitleCaseName + "BindingSource)).BeginInit();");
            sw.WriteLine("            this.myPanel2.SuspendLayout();");
            sw.WriteLine("            this.myPanel3.SuspendLayout();");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // myPanel1");
            sw.WriteLine("            // ");
            if (dt.PrimaryKey != null)
            {
                sw.WriteLine("            this.myPanel1.Controls.Add(this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ");");
                sw.WriteLine("            this.myPanel1.Controls.Add(this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ");");
            }
            sw.WriteLine("            this.myPanel1.Controls.Add(this.btnSelect);");
            sw.WriteLine("            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Top;");
            sw.WriteLine("            this.myPanel1.Location = new System.Drawing.Point(0, 0);");
            sw.WriteLine("            this.myPanel1.Name = \"myPanel1\";");
            sw.WriteLine("            this.myPanel1.Size = new System.Drawing.Size(750, 42);");
            sw.WriteLine("            this.myPanel1.TabIndex = 0;");
            if (dt.PrimaryKey != null)
            {
                sw.WriteLine("            // ");
                sw.WriteLine("            // lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + "");
                sw.WriteLine("            // ");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".AutoSize = true;");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Location = new System.Drawing.Point(29, 14);");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Name = \"myLabel1\";");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Size = new System.Drawing.Size(0, 12);");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".TabIndex = 2;");
                sw.WriteLine("            this.lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Text = \"" + dt.PrimaryKey.Columns[0].Comments + "\";");

                sw.WriteLine("            // ");
                sw.WriteLine("            // txt" + dt.PrimaryKey.Columns[0].TitleCaseName + "");
                sw.WriteLine("            // ");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".FieldName = \"\";");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".IsNeedBind = false;");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Location = new System.Drawing.Point(88, 10);");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".MaxLength = 50;");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Name = \"txt" + dt.PrimaryKey.Columns[0].TitleCaseName + "\";");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Nullable = true;");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Size = new System.Drawing.Size(189, 21);");
                sw.WriteLine("            this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".TabIndex = 0;");
            }
            sw.WriteLine("            // ");
            sw.WriteLine("            // btnSelect");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.btnSelect.Location = new System.Drawing.Point(283, 9);");
            sw.WriteLine("            this.btnSelect.Name = \"btnSelect\";");
            sw.WriteLine("            this.btnSelect.Size = new System.Drawing.Size(75, 23);");
            sw.WriteLine("            this.btnSelect.TabIndex = 1;");
            sw.WriteLine("            this.btnSelect.Text = \"查询\";");
            sw.WriteLine("            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // uc" + dt.TitleCaseName + "Grid1");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1.Dock = System.Windows.Forms.DockStyle.Fill;");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1.Location = new System.Drawing.Point(0, 0);");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1.Name = \"uc" + dt.TitleCaseName + "Grid1\";");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1.Size = new System.Drawing.Size(750, 276);");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1.TabIndex = 1;");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1." + dt.TitleCaseName + "BindingSource = null;");
            sw.WriteLine("            // ");
            sw.WriteLine("            // myPanel2");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.myPanel2.Controls.Add(this.uc" + dt.TitleCaseName + "Grid1);");
            sw.WriteLine("            this.myPanel2.Controls.Add(this.ucPaging1);");
            sw.WriteLine("            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;");
            sw.WriteLine("            this.myPanel2.Location = new System.Drawing.Point(0, 42);");
            sw.WriteLine("            this.myPanel2.Name = \"myPanel2\";");
            sw.WriteLine("            this.myPanel2.Size = new System.Drawing.Size(750, 308);");
            sw.WriteLine("            this.myPanel2.TabIndex = 1;");
            sw.WriteLine("            // ");
            sw.WriteLine("            // ucPaging1");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.ucPaging1.DataPaging = null;");
            sw.WriteLine("            this.ucPaging1.Dock = System.Windows.Forms.DockStyle.Bottom;");
            sw.WriteLine("            this.ucPaging1.Location = new System.Drawing.Point(0, 276);");
            sw.WriteLine("            this.ucPaging1.Name = \"ucPaging1\";");
            sw.WriteLine("            this.ucPaging1.Size = new System.Drawing.Size(750, 32);");
            sw.WriteLine("            this.ucPaging1.TabIndex = 1;");
            sw.WriteLine("            this.ucPaging1.PagingChanged += new " + BaseParams.UserControlsNameSpace + ".Utility.EventPagingChanged(this.ucPaging1_PagingChanged);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // myPanel3");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.myPanel3.Controls.Add(this.btnAdd);");
            sw.WriteLine("            this.myPanel3.Controls.Add(this.btnEdit);");
            sw.WriteLine("            this.myPanel3.Controls.Add(this.btnDelete);");
            sw.WriteLine("            this.myPanel3.Controls.Add(this.btnClose);");
            sw.WriteLine("            this.myPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;");
            sw.WriteLine("            this.myPanel3.Location = new System.Drawing.Point(0, 350);");
            sw.WriteLine("            this.myPanel3.Name = \"myPanel3\";");
            sw.WriteLine("            this.myPanel3.Size = new System.Drawing.Size(750, 34);");
            sw.WriteLine("            this.myPanel3.TabIndex = 1;");
            sw.WriteLine("            // ");
            sw.WriteLine("            // btnAdd");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));");
            sw.WriteLine("            this.btnAdd.Location = new System.Drawing.Point(420, 2);");
            sw.WriteLine("            this.btnAdd.Name = \"btnAdd\";");
            sw.WriteLine("            this.btnAdd.Size = new System.Drawing.Size(75, 23);");
            sw.WriteLine("            this.btnAdd.TabIndex = 1;");
            sw.WriteLine("            this.btnAdd.Text = \"新增\";");
            sw.WriteLine("            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // btnDelete");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));");
            sw.WriteLine("            this.btnDelete.Enabled = false;");
            sw.WriteLine("            this.btnDelete.Location = new System.Drawing.Point(582, 2);");
            sw.WriteLine("            this.btnDelete.Name = \"btnDelete\";");
            sw.WriteLine("            this.btnDelete.Size = new System.Drawing.Size(75, 23);");
            sw.WriteLine("            this.btnDelete.TabIndex = 1;");
            sw.WriteLine("            this.btnDelete.Text = \"删除\";");
            sw.WriteLine("            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // btnEdit");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));");
            sw.WriteLine("            this.btnEdit.Enabled = false;");
            sw.WriteLine("            this.btnEdit.Location = new System.Drawing.Point(501, 2);");
            sw.WriteLine("            this.btnEdit.Name = \"btnEdit\";");
            sw.WriteLine("            this.btnEdit.Size = new System.Drawing.Size(75, 23);");
            sw.WriteLine("            this.btnEdit.TabIndex = 1;");
            sw.WriteLine("            this.btnEdit.Text = \"修改\";");
            sw.WriteLine("            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // btnClose");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));");
            sw.WriteLine("            this.btnClose.Location = new System.Drawing.Point(663, 2);");
            sw.WriteLine("            this.btnClose.Name = \"btnClose\";");
            sw.WriteLine("            this.btnClose.Size = new System.Drawing.Size(75, 23);");
            sw.WriteLine("            this.btnClose.TabIndex = 1;");
            sw.WriteLine("            this.btnClose.Text = \"退出\";");
            sw.WriteLine("            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);");
            sw.WriteLine("            // ");
            sw.WriteLine("            // frm" + dt.TitleCaseName + "Mng");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);");
            sw.WriteLine("            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;");
            sw.WriteLine("            this.Controls.Add(this.myPanel2);");
            sw.WriteLine("            this.Controls.Add(this.myPanel3);");
            sw.WriteLine("            this.Controls.Add(this.myPanel1);");
            sw.WriteLine("            this.Name = \"frm" + dt.TitleCaseName + "Mng\";");
            sw.WriteLine("            this.Text = \"" + dt.Comments + "\";");
            sw.WriteLine("            this.Load += new System.EventHandler(this.frm" + dt.TitleCaseName + "Mng_Load);");
            sw.WriteLine("            this.myPanel1.ResumeLayout(false);");
            sw.WriteLine("            this.myPanel1.PerformLayout();");
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this." + dt.TitleCaseName + "BindingSource)).EndInit();");
            sw.WriteLine("            this.myPanel2.ResumeLayout(false);");
            sw.WriteLine("            this.myPanel3.ResumeLayout(false);");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        #endregion");
            sw.WriteLine("");
            sw.WriteLine("        private " + BaseParams.UserControlsNameSpace + ".Grids.Uc" + dt.TitleCaseName + "Grid uc" + dt.TitleCaseName + "Grid1;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyPanel myPanel1;");

            if (dt.PrimaryKey != null)
            {
                sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyLabel lbl" + dt.PrimaryKey.Columns[0].TitleCaseName + ";");
                sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyTextBox txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ";");
            }
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyButton btnSelect;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyButton btnClose;");
            sw.WriteLine("        private System.Windows.Forms.BindingSource " + dt.TitleCaseName + "BindingSource;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyPanel myPanel2;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyPanel myPanel3;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyButton btnDelete;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyButton btnEdit;");
            sw.WriteLine("        private " + BaseParams.ControlsNameSpace + ".MyButton btnAdd;");
            sw.WriteLine("        private " + BaseParams.UserControlsNameSpace + ".Utility.UcPaging ucPaging1;");
            sw.WriteLine("");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion
        }
    }
}
