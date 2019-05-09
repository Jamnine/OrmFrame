using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.WinFroms
{
    public class ManagerFormsCoder
    {
        public static void Write(DbTable dt)
        {

            string path = Path.Combine(BaseParams.WinFromsPath, "ManagerForms");
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建类detail文件

            string className = Path.Combine(path, "frm" + dt.TitleCaseName + "Mng.cs");
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
            sw.WriteLine("");
            sw.WriteLine("using " + BaseParams.UtilityNameSpace + ";");
            sw.WriteLine("using " + BaseParams.ControlsNameSpace + ";");
            sw.WriteLine("using " + BaseParams.DomainNameSpace + ";");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ";");
            sw.WriteLine("using " + BaseParams.WcfClientNameSpace + ".ServiceReference1;");
            sw.WriteLine("using " + BaseParams.WinFromsNameSpace + ".EditDialogs;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.WinFromsNameSpace + ".ManagerForms");
            sw.WriteLine("{");
            sw.WriteLine("    public partial class frm" + dt.TitleCaseName + "Mng : MyForm");
            sw.WriteLine("    {");
            sw.WriteLine("        public frm" + dt.TitleCaseName + "Mng()");
            sw.WriteLine("        {");
            sw.WriteLine("            InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        // 创建数据结构。");
            sw.WriteLine("        IList<" + dt.TitleCaseName + "> " + dt.ParamCaseName + "List = new List<" + dt.TitleCaseName + ">();");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("        IList<" + dr.ParentTable.TitleCaseName + "> " + dr.ParentTitleCaseName + "List = new List<" + dr.ParentTable.TitleCaseName + ">();");
            }

            sw.WriteLine("        // " + dt.TitleCaseName + ",Wcf服务代理对象");
            sw.WriteLine("        MainServiceProxy<" + dt.TitleCaseName + "> wcfProxy = MainServiceProxy<" + dt.TitleCaseName + ">.Instance;");

            sw.WriteLine("");
            sw.WriteLine("        private void frm" + dt.TitleCaseName + "Mng_Load(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            // 转换成可排序的数据对象");
            sw.WriteLine("            SortableBindingList<" + dt.TitleCaseName + "> sb" + dt.TitleCaseName + "List = new SortableBindingList<" + dt.TitleCaseName + ">(" + dt.ParamCaseName + "List);");
            sw.WriteLine("            " + dt.TitleCaseName + "BindingSource.DataSource = sb" + dt.TitleCaseName + "List;");
            sw.WriteLine("            // 绑定数据到控件");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1." + dt.TitleCaseName + "BindingSource = " + dt.TitleCaseName + "BindingSource;");
            sw.WriteLine("            // 刷新状态数据");
            sw.WriteLine("            FromControlsStateFlash();");
            sw.WriteLine("            ");
            sw.WriteLine("        }");
            sw.WriteLine("       ");
            sw.WriteLine("        private void btnSelect_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            if (dt.PrimaryKey != null)
            {
                sw.WriteLine("            string par = this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Text.Trim();");
                sw.WriteLine("            // 查询数据");
                sw.WriteLine("            List<object> ps = new List<object>();");
                sw.WriteLine("            string condi = \"\";");
                sw.WriteLine("            if (this.txt" + dt.PrimaryKey.Columns[0].TitleCaseName + ".Text.Trim() != \"\")");
                sw.WriteLine("            {");
                sw.WriteLine("                condi = \" where " + dt.FieldCaseName + "." + dt.PrimaryKey.Columns[0].TitleCaseName + " like ?\";");
                sw.WriteLine("                ps.Add(\"%\" + par + \"%\");");
                sw.WriteLine("            }");
                sw.WriteLine("            try");
                sw.WriteLine("            {");
                sw.WriteLine("                Paging paging = this.ucPaging1.DataPaging;");
                sw.WriteLine("                paging.CurrentPage = (sender is Paging) ? paging.CurrentPage : 1;");
                sw.WriteLine("                " + dt.ParamCaseName + "List = wcfProxy.GetObjectByHqlCondi(condi + \" order by " + dt.FieldCaseName + "." + dt.PrimaryKey.Columns[0].TitleCaseName + " asc\", QueryType.hql_pnt, ref paging, ps);");
                sw.WriteLine("                this.ucPaging1.DataPaging = paging;");
                sw.WriteLine("            }");
                sw.WriteLine("                catch(Exception ex)");
                sw.WriteLine("            {");
                sw.WriteLine("                FormHelper.ShowException(ex);");
                sw.WriteLine("            }");
            }
            sw.WriteLine("            // 转换成可排序的数据对象");
            sw.WriteLine("            SortableBindingList<" + dt.TitleCaseName + "> sb" + dt.TitleCaseName + "List = new SortableBindingList<" + dt.TitleCaseName + ">(" + dt.ParamCaseName + "List);");
            sw.WriteLine("            // 绑定数据到控件");
            sw.WriteLine("            " + dt.TitleCaseName + "BindingSource.DataSource = sb" + dt.TitleCaseName + "List;");
            sw.WriteLine("            this.uc" + dt.TitleCaseName + "Grid1." + dt.TitleCaseName + "BindingSource = " + dt.TitleCaseName + "BindingSource;");
            sw.WriteLine("            // 刷新状态控件");
            sw.WriteLine("            FromControlsStateFlash();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnAdd_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            // 获得主表数据集合");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("                if (" + dr.ParentTitleCaseName + "List.Count == 0)");
                sw.WriteLine("                {");
                sw.WriteLine("                    " + dr.ParentTitleCaseName + "List = MainServiceProxy<" + dr.ParentTable.TitleCaseName + ">.Instance.GetObjectAll(QueryType.hql_slf);");
                sw.WriteLine("                }");
            }
            sw.WriteLine("            }");
            sw.WriteLine("            catch(Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                FormHelper.ShowException(ex);");
            sw.WriteLine("            }");
            sw.WriteLine("            // 打开新增界面");
            sw.WriteLine("            dlg" + dt.TitleCaseName + "Edit dlg = new dlg" + dt.TitleCaseName + "Edit();");
            sw.WriteLine("            dlg.EditType = DialogEditType.Add;");
            sw.WriteLine("            dlg." + dt.TitleCaseName + "BindingSource = this." + dt.TitleCaseName + "BindingSource;");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            dlg." + dr.ParentTitleCaseName + "List = this." + dr.ParentTitleCaseName + "List;");
            }
            sw.WriteLine("            int tempCount = this." + dt.TitleCaseName + "BindingSource.Count;");
            sw.WriteLine("            dlg.ShowDialog();");
            sw.WriteLine("            this.ucPaging1.DataPaging.RowCount += this." + dt.TitleCaseName + "BindingSource.List.Count - tempCount;");
            sw.WriteLine("            // 刷新状态控件");
            sw.WriteLine("            FromControlsStateFlash();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnEdit_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            // 获得主表数据集合");
            sw.WriteLine("            try");
            sw.WriteLine("            {");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("                if (" + dr.ParentTitleCaseName + "List.Count == 0)");
                sw.WriteLine("                {");
                sw.WriteLine("                    " + dr.ParentTitleCaseName + "List = MainServiceProxy<" + dr.ParentTable.TitleCaseName + ">.Instance.GetObjectAll(QueryType.hql_slf);");
                sw.WriteLine("                }");
            }
            sw.WriteLine("            }");
            sw.WriteLine("            catch(Exception ex)");
            sw.WriteLine("            {");
            sw.WriteLine("                FormHelper.ShowException(ex);");
            sw.WriteLine("            }");
            sw.WriteLine("            // 打开修改界面");
            sw.WriteLine("            dlg" + dt.TitleCaseName + "Edit dlg = new dlg" + dt.TitleCaseName + "Edit();");
            sw.WriteLine("            dlg.EditType = DialogEditType.Edit;");
            sw.WriteLine("            dlg." + dt.TitleCaseName + "BindingSource = this." + dt.TitleCaseName + "BindingSource;");
            foreach (DbRelation dr in dt.ParentRelations)
            {
                sw.WriteLine("            dlg." + dr.ParentTitleCaseName + "List = this." + dr.ParentTitleCaseName + "List;");
            }
            sw.WriteLine("            int tempCount = this." + dt.TitleCaseName + "BindingSource.Count;");
            sw.WriteLine("            dlg.ShowDialog();");
            sw.WriteLine("            this.ucPaging1.DataPaging.RowCount += this." + dt.TitleCaseName + "BindingSource.List.Count - tempCount;");
            sw.WriteLine("            // 刷新状态控件");
            sw.WriteLine("            FromControlsStateFlash();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnDelete_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            // 删除选中的所有行");
            sw.WriteLine("            if (FormHelper.ShowConfirm(\"您确认删除所有选择的行吗？\"))");
            sw.WriteLine("            {");
            sw.WriteLine("                List<" + dt.TitleCaseName + "> delList = new List<" + dt.TitleCaseName + ">();");
            sw.WriteLine("                foreach (System.Windows.Forms.DataGridViewRow dvrow in this.uc" + dt.TitleCaseName + "Grid1.dgv" + dt.TitleCaseName + ".SelectedRows)");
            sw.WriteLine("                {");
            sw.WriteLine("                    delList.Add((" + dt.TitleCaseName + ")this." + dt.TitleCaseName + "BindingSource[dvrow.Index]);");
            sw.WriteLine("                }");
            sw.WriteLine("                try");
            sw.WriteLine("                {");
            sw.WriteLine("                    wcfProxy.Delete(delList);");
            sw.WriteLine("                    foreach (" + dt.TitleCaseName + " delObj in delList)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        this." + dt.TitleCaseName + "BindingSource.Remove(delObj);");
            sw.WriteLine("                        this.ucPaging1.DataPaging.RowCount += -1;");
            sw.WriteLine("                    }");
            sw.WriteLine("                    if (this." + dt.TitleCaseName + "BindingSource.Count == 0)");
            sw.WriteLine("                    {");
            sw.WriteLine("                        btnSelect_Click(this.ucPaging1.DataPaging, new EventArgs());");
            sw.WriteLine("                    }");
            sw.WriteLine("                }");
            sw.WriteLine("                catch(Exception ex)");
            sw.WriteLine("                {");
            sw.WriteLine("                    FormHelper.ShowException(ex);");
            sw.WriteLine("                }");
            sw.WriteLine("            // 刷新状态控件");
            sw.WriteLine("            FromControlsStateFlash();");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void btnClose_Click(object sender, EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this.Close();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        // 刷新状态控件");
            sw.WriteLine("        private void FromControlsStateFlash()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.btnEdit.Enabled |= (this." + dt.TitleCaseName + "BindingSource.Count > 0);");
            sw.WriteLine("            this.btnDelete.Enabled |= (this." + dt.TitleCaseName + "BindingSource.Count > 0);");
            sw.WriteLine("            if (this." + dt.TitleCaseName + "BindingSource.Position >= 0)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.uc" + dt.TitleCaseName + "Grid1.dgv" + dt.TitleCaseName + ".Rows[this." + dt.TitleCaseName + "BindingSource.Position].Selected = true;");
            sw.WriteLine("            }");
            //sw.WriteLine("            this.ucPaging1.DataPaging.PageSize = 25;            ");
            sw.WriteLine("            this.ucPaging1.PagingReflash();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void ucPaging1_PagingChanged(object sender, " + BaseParams.UserControlsNameSpace + ".Utility.MyPagingEventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            btnSelect_Click(this.ucPaging1.DataPaging, new EventArgs());");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();
            #endregion

            ManagerFormDesignerCoder.Write(dt);
            ResourceFileCoder.Write(Path.Combine(path, "frm" + dt.TitleCaseName + "Mng.resx"));
        }
    }
}
