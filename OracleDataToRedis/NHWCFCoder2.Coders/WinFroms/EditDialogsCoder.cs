using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WinFroms
{
    public class EditDialogsCoder
    {
        public static void Write(DbTable dt)
        {

            string path = Path.Combine(BaseParams.WinFromsPath, "EditDialogs");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类detail文件

            string className = Path.Combine(path, "dlg" + dt.TitleCaseName + "Edit.cs");
            FileStream file = new FileStream(className, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            CommentsCoder.CreateCsComments(dt.Comments, sw);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.ControlsNameSpace + ";");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ";");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ".ServiceReference1;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WinFromsNameSpace + ".EditDialogs");
            sw.WriteLine("{");
            sw.WriteLine("    public partial class dlg" + dt.TitleCaseName + "Edit : MyDialog");
            sw.WriteLine("    {");
            sw.WriteLine("        public dlg" + dt.TitleCaseName + "Edit()");
            sw.WriteLine("        {");
            sw.WriteLine("            InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        // 修改前保存当前实例的副本,以便取消时回退。");
            sw.WriteLine("        " + dt.TitleCaseName + " " + dt.FieldCaseName + "Backup = new " + dt.TitleCaseName + "();");
            sw.WriteLine("        // " + dt.TitleCaseName + ",Wcf服务代理对象");
            sw.WriteLine("        MainServiceProxy<" + dt.TitleCaseName + "> wcfProxy = MainServiceProxy<" + dt.TitleCaseName + ">.Instance;");
            sw.WriteLine("");
            sw.WriteLine("        private DialogEditType _edittype = DialogEditType.Add;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 对话框的编辑类型,新增或者修改。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public DialogEditType EditType");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._edittype; }");
            sw.WriteLine("            set { this._edittype = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private System.Windows.Forms.BindingSource " + dt.FieldCaseName + "BindingSource;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 对应类型的数据集绑定对象。");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public System.Windows.Forms.BindingSource " + dt.TitleCaseName + "BindingSource");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this." + dt.FieldCaseName + "BindingSource; }");
            sw.WriteLine("            set { this." + dt.FieldCaseName + "BindingSource = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("        private IList<" + dr.ParentTable.TitleCaseName + "> " + dr.ParentFieldCaseName + "list;");
                sw.WriteLine("        /// <summary>");
                sw.WriteLine("        /// :TCustomer的数据集绑定对象。");
                sw.WriteLine("        /// </summary>");
                sw.WriteLine("        public IList<" + dr.ParentTable.TitleCaseName + "> " + dr.ParentTitleCaseName + "List");
                sw.WriteLine("        {");
                sw.WriteLine("            get { return this." + dr.ParentFieldCaseName + "list; }");
                sw.WriteLine("            set { this." + dr.ParentFieldCaseName + "list = value; }");
                sw.WriteLine("        }");
            }
            sw.WriteLine("");
            sw.WriteLine("        private void dlg" + dt.TitleCaseName + "Edit_Load(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (this." + dt.TitleCaseName + "BindingSource == null)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        FormHelper.ShowErr(\"必需的数据集没有赋值!\");");
            sw.WriteLine("                    }");
            sw.WriteLine("                    this." + dt.TitleCaseName + "BindingSource.CurrentChanged += new EventHandler(" + dt.TitleCaseName + "BindingSource_CurrentChanged);");
            sw.WriteLine("                    this." + dt.TitleCaseName + "BindingSource.CurrentItemChanged += new EventHandler(" + dt.TitleCaseName + "BindingSource_CurrentItemChanged);");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("                    this.uc" + dt.TitleCaseName + "Detail1." + dr.ParentTitleCaseName + "List = this." + dr.ParentTitleCaseName + "List;");
            }
            sw.WriteLine("                    this.bindingNavigator" + dt.TitleCaseName + ".BindingSource = this." + dt.TitleCaseName + "BindingSource;");
            sw.WriteLine("                    this.uc" + dt.TitleCaseName + "Detail1." + dt.TitleCaseName + "BindingSource = this." + dt.TitleCaseName + "BindingSource;");
            sw.WriteLine("                    if (this.EditType == DialogEditType.Add)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        this.bindingNavigator" + dt.TitleCaseName + ".Enabled = false;");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.AddNew();");
            sw.WriteLine("                        this.SetDefaultProperty((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current);");
            sw.WriteLine("                        ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (this.EditType == DialogEditType.Edit)");
            sw.WriteLine("                    {");
            sw.WriteLine("                    this.bindingNavigator" + dt.TitleCaseName + ".Enabled = true;");
            sw.WriteLine("                        ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                        this." + dt.FieldCaseName + "Backup = ObjectHelper<" + dt.TitleCaseName + ">.Clone((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current);");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("                catch (Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    FormHelper.ShowException(ex);");
            sw.WriteLine("                }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        void " + dt.TitleCaseName + "BindingSource_CurrentItemChanged(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            // 如果有修改,就控制数据导航条的使用");
            sw.WriteLine("            if (this." + dt.TitleCaseName + "BindingSource.Current != null && ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).IsChanged == true)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.bindingNavigator" + dt.TitleCaseName + ".Enabled = false;");
            sw.WriteLine("                this.btnCancel.Enabled = true;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void " + dt.TitleCaseName + "BindingSource_CurrentChanged(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this." + dt.FieldCaseName + "Backup = ObjectHelper<" + dt.TitleCaseName + ">.Clone((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current);");
            sw.WriteLine("            // 取消修改");
            sw.WriteLine("            if (this." + dt.TitleCaseName + "BindingSource.Current != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnSave_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            sw.WriteLine("                this." + dt.TitleCaseName + "BindingSource.EndEdit();");
            sw.WriteLine("                if (this.uc" + dt.TitleCaseName + "Detail1.ValidateChildren(ValidationConstraints.TabStop) == true)");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (this._edittype == DialogEditType.Add)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        // 保存对象到数据库");
            sw.WriteLine("                        " + dt.TitleCaseName + " " + dt.ParamCaseName + " = (" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current;");
            sw.WriteLine("                        wcfProxy.Save(ref " + dt.ParamCaseName + ");");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource[this." + dt.TitleCaseName + "BindingSource.Position] = " + dt.ParamCaseName + ";");
            sw.WriteLine("                        ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else if (this._edittype == DialogEditType.Edit)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        " + dt.TitleCaseName + " " + dt.ParamCaseName + " = (" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current;");
            sw.WriteLine("                        if (" + dt.ParamCaseName + ".IsChanged == true)");
            sw.WriteLine("                        {");
            sw.WriteLine("                            // 更新对象到数据库");
            sw.WriteLine("                            wcfProxy.Update(ref " + dt.ParamCaseName + "," + dt.FieldCaseName + "Backup." + dt.PrimaryKey.Columns[0].TitleCaseName + ");");
            sw.WriteLine("                            this." + dt.TitleCaseName + "BindingSource[this." + dt.TitleCaseName + "BindingSource.Position] = " + dt.ParamCaseName + ";");
            sw.WriteLine("                            ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                        }");
            sw.WriteLine("                    }");
            sw.WriteLine("                    this.bindingNavigator" + dt.TitleCaseName + ".Enabled = true;");
            sw.WriteLine("                    // 下一条");
            sw.WriteLine("                    if (this." + dt.TitleCaseName + "BindingSource.Position == this." + dt.TitleCaseName + "BindingSource.Count - 1)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.AddNew();");
            sw.WriteLine("                        this.SetDefaultProperty((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current);");
            sw.WriteLine("                        this._edittype = DialogEditType.Add;");
            sw.WriteLine("                        this.bindingNavigator" + dt.TitleCaseName + ".Enabled = false;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else");
            sw.WriteLine("                    {");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.MoveNext();");
            sw.WriteLine("                        this._edittype = DialogEditType.Edit;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            catch (Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                FormHelper.ShowException(ex);");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnCancel_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this." + dt.TitleCaseName + "BindingSource.EndEdit();");
            sw.WriteLine("            if (this." + dt.TitleCaseName + "BindingSource.Current != null && ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).IsChanged == true)");
            sw.WriteLine("            {");
            sw.WriteLine("                if (FormHelper.ShowConfirm(\"是否确认取消保存前的所有操作！\") == false)");
            sw.WriteLine("                {");
            sw.WriteLine("                    return;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            if (this._edittype == DialogEditType.Edit)");
            sw.WriteLine("            {");
            sw.WriteLine("                // 取消修改");
            sw.WriteLine("                int i = this." + dt.TitleCaseName + "BindingSource.Position;");
            sw.WriteLine("                this." + dt.TitleCaseName + "BindingSource.Insert(i + 1, this." + dt.FieldCaseName + "Backup);");
            sw.WriteLine("            }");
            sw.WriteLine("            this._edittype = DialogEditType.Edit;");
            sw.WriteLine("            this." + dt.TitleCaseName + "BindingSource.RemoveCurrent();");
            sw.WriteLine("            if (this." + dt.TitleCaseName + "BindingSource.Current != null)");
            sw.WriteLine("            {");
            sw.WriteLine("                ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("            }");
            sw.WriteLine("            this.bindingNavigator" + dt.TitleCaseName + ".Enabled = true;");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Detail1.ErrorProvider.Clear();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnClose_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this.Close();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void dlg" + dt.TitleCaseName + "Edit_FormClosing(object sender, FormClosingEventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (this._edittype == DialogEditType.Add)");
            sw.WriteLine("            {");
            sw.WriteLine("                // 新增退出判断");
            sw.WriteLine("                if (this." + dt.TitleCaseName + "BindingSource.Current != null && ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).IsChanged == true)");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (FormHelper.ShowConfirm(\"新增的数据还未保存,您是否确认退出,选择\\\"是\\\"将不保存数据,并退出编辑界面！\") == true)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.RemoveCurrent();");
            sw.WriteLine("                        if (this." + dt.TitleCaseName + "BindingSource.Current != null)");
            sw.WriteLine("                            ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else");
            sw.WriteLine("                    {");
            sw.WriteLine("                        e.Cancel = true;");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("                else");
            sw.WriteLine("                {");
            sw.WriteLine("                    this." + dt.TitleCaseName + "BindingSource.RemoveCurrent();");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            else if (this._edittype == DialogEditType.Edit)");
            sw.WriteLine("            {");
            sw.WriteLine("                // 修改退出判断");
            sw.WriteLine("                if (this." + dt.TitleCaseName + "BindingSource.Current != null && ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).IsChanged == true)");
            sw.WriteLine("                {");
            sw.WriteLine("                    if (FormHelper.ShowConfirm(\"修改的数据还未保存,您是否确认退出,选择\\\"是\\\"将不保存数据,并退出编辑界面！\") == true)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        int i = this." + dt.TitleCaseName + "BindingSource.Position;");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.Insert(i + 1, this." + dt.FieldCaseName + "Backup);");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.RemoveCurrent();");
            sw.WriteLine("                        if (this." + dt.TitleCaseName + "BindingSource.Current != null)");
            sw.WriteLine("                            ((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource.Current).Reject();");
            sw.WriteLine("                    }");
            sw.WriteLine("                    else");
            sw.WriteLine("                    {");
            sw.WriteLine("                        e.Cancel = true;");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void bindingNavigator" + dt.TitleCaseName + "_MouseEnter(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            foreach (Control ctl in this.uc" + dt.TitleCaseName + "Detail1.Controls)");
            sw.WriteLine("            {");
            sw.WriteLine("                ComboBox cbb = ctl as ComboBox;");
            sw.WriteLine("                if (cbb != null && cbb.Focused == true)");
            sw.WriteLine("                {");
            sw.WriteLine("                    this.btnSave.Focus();");
            sw.WriteLine("                    break;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            this." + dt.TitleCaseName + "BindingSource.EndEdit();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void SetDefaultProperty(" + dt.TitleCaseName + " " + dt.ParamCaseName + ")");
            sw.WriteLine("        {");
            foreach (DbColumn dc in dt.Columns)
            {
                if (dc.IsGenerateField == true && dc.IsForeignKey == false)
                {
                    switch (dc.FieldType)
                    {
                        case "DateTime?":
                            sw.WriteLine("            " + dt.ParamCaseName + "." + dc.TitleCaseName + " = DateTime.Now;");
                            break;
                    }
                }
            }
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            " + dt.ParamCaseName + "." + dr.ParentTitleCaseName + " = new " + dr.ParentTitleCaseName + "();");
            }
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Detail1.ConstrolsDataDefault();");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();
            #endregion
            EditDialogsDesignerCoder.Write(dt);
            ResourceFileCoder.Write(Path.Combine(path, "dlg" + dt.TitleCaseName + "Edit.resx"));
        }
    }
}
