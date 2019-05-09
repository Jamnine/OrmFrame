using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Coders.Controls
{
    public class ControlsCoder
    {
        public static void Write()
        {
            string path = Path.Combine(BaseParams.SolutionPath, BaseParams.ControlsNameSpace);
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            #region 创建IControlBind类
            string filepath = Path.Combine(path, "IControlBind.cs");

            FileStream file = new FileStream(filepath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public interface IControlBind");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        bool IsNeedBind");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定的字段名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        string FieldName");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否允许以为空");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        bool Nullable");
            sw.WriteLine("        {");
            sw.WriteLine("            get;");
            sw.WriteLine("            set;");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建MyButton类
            filepath = Path.Combine(path, "MyButton.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyButton : Button");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (msg.WParam.ToInt32() == (int)Keys.Enter)");
            sw.WriteLine("            {");
            sw.WriteLine("                SendKeys.Send(\"{Tab}\");");
            sw.WriteLine("            }");
            sw.WriteLine("            return base.ProcessCmdKey(ref msg, keyData);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyComboBox类
            filepath = Path.Combine(path, "MyComboBox.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyComboBox : ComboBox, IControlBind");
            sw.WriteLine("    {");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (msg.WParam.ToInt32() == (int)Keys.Enter)");
            sw.WriteLine("            {");
            sw.WriteLine("                if (this.SelectedIndex >= 0)");
            sw.WriteLine("                {");
            sw.WriteLine("                    SendKeys.Send(\"{Tab}\");");
            sw.WriteLine("                    return true;");
            sw.WriteLine("                }");
            sw.WriteLine("                else");
            sw.WriteLine("                {");
            sw.WriteLine("                    SendKeys.Send(\"{Down}\");");
            sw.WriteLine("                    return true;");
            sw.WriteLine("                }");
            sw.WriteLine("            }");
            sw.WriteLine("            else if (this.Focused == true && msg.WParam.ToInt32() != (int)Keys.Tab)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.DroppedDown |= true;");
            sw.WriteLine("            }");
            sw.WriteLine("            return base.ProcessCmdKey(ref msg, keyData);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnGotFocus(EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnGotFocus(e);");
            sw.WriteLine("            this.SelectAll();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _isNeedBind = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsNeedBind");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._isNeedBind; }");
            sw.WriteLine("            set { this._isNeedBind = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private string _fieldName = \"\";");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定的字段名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public string FieldName");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                if (this._fieldName.ToString() == \"\" && this._isNeedBind == true && this.Name.Length > 3)");
            sw.WriteLine("                {");
            sw.WriteLine("                    return this.Name.Substring(3);");
            sw.WriteLine("                }");
            sw.WriteLine("                return this._fieldName;");
            sw.WriteLine("            }");
            sw.WriteLine("            set { this._fieldName = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _nullable = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否允许以为空");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool Nullable");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._nullable; }");
            sw.WriteLine("            set { this._nullable = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyDataGridView类

            filepath = Path.Combine(path, "MyDataGridView.cs");
            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyDataGridView : DataGridView");
            sw.WriteLine("    {");
            sw.WriteLine("        public MyDataGridView()");
            sw.WriteLine("        {");
            sw.WriteLine("            if (this.DesignMode == false)");
            sw.WriteLine("            {");
            sw.WriteLine("                this.AutoGenerateColumns = false;");
            sw.WriteLine("            }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnDataSourceChanged(EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnDataSourceChanged(e);");
            sw.WriteLine("            this.SetDefaultCellStyle();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void SetDefaultCellStyle()");
            sw.WriteLine("        {");
            sw.WriteLine("            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();");
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // MyDataGridView");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.AllowUserToAddRows = false;");
            sw.WriteLine("            this.AllowUserToDeleteRows = false;");
            sw.WriteLine("            dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));");
            sw.WriteLine("            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;");
            sw.WriteLine("            this.AutoGenerateColumns = false;");
            sw.WriteLine("            this.ReadOnly = true;");
            sw.WriteLine("            this.RowTemplate.Height = 23;");
            sw.WriteLine("            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;");
            sw.WriteLine("            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected void SetColumnStyle(DataGridViewTextBoxColumn dc, string format)");
            sw.WriteLine("        {");
            sw.WriteLine("            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();");
            sw.WriteLine("            dataGridViewCellStyle.Format = format;");
            sw.WriteLine("            dc.DefaultCellStyle = dataGridViewCellStyle;");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (msg.WParam.ToInt32() == (int)Keys.Enter)");
            sw.WriteLine("            {");
            sw.WriteLine("                SendKeys.Send(\"{Tab}\");");
            sw.WriteLine("                return true;");
            sw.WriteLine("            }");
            sw.WriteLine("            return base.ProcessCmdKey(ref msg, keyData);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,");
            sw.WriteLine("                           e.RowBounds.Location.Y,");
            sw.WriteLine("                           this.RowHeadersWidth - 4,");
            sw.WriteLine("                           e.RowBounds.Height);");
            sw.WriteLine("            string rowIndex = (e.RowIndex + 1).ToString();");
            sw.WriteLine("            TextRenderer.DrawText(e.Graphics, rowIndex,");
            sw.WriteLine("                this.RowHeadersDefaultCellStyle.Font,");
            sw.WriteLine("                rectangle,");
            sw.WriteLine("                this.RowHeadersDefaultCellStyle.ForeColor,");
            sw.WriteLine("                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);");
            sw.WriteLine("            StringFormat sf = new StringFormat(StringFormat.GenericTypographic);");
            sw.WriteLine("            int w = (int)e.Graphics.MeasureString(rowIndex, this.RowHeadersDefaultCellStyle.Font, 1000).Width;");
            sw.WriteLine("            if (this.RowHeadersWidth < w + 20)");
            sw.WriteLine("                this.RowHeadersWidth = w + 20;");
            sw.WriteLine("");
            sw.WriteLine("            base.OnRowPostPaint(e);");
            sw.WriteLine("        }");
            //sw.WriteLine("        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)");
            //sw.WriteLine("        {");
            //sw.WriteLine("            if (this.Columns[e.ColumnIndex].DataPropertyName.Contains(\".\") == true)");
            //sw.WriteLine("            {");
            //sw.WriteLine("                e.Value = EvaluateValue(this.Rows[e.RowIndex].DataBoundItem, this.Columns[e.ColumnIndex].DataPropertyName);");
            //sw.WriteLine("            }");
            //sw.WriteLine("            base.OnCellFormatting(e);");
            //sw.WriteLine("        }");
            //sw.WriteLine("");
            //sw.WriteLine("        private string EvaluateValue(object obj, string property)");
            //sw.WriteLine("        {");
            //sw.WriteLine("            string prop = property;");
            //sw.WriteLine("            string ret = string.Empty;");
            //sw.WriteLine("            if (property.Contains(\".\"))");
            //sw.WriteLine("            {");
            //sw.WriteLine("                prop = property.Substring(0, property.IndexOf(\".\"));");
            //sw.WriteLine("                System.Reflection.PropertyInfo[] props = obj.GetType().GetProperties();");
            //sw.WriteLine("                foreach (System.Reflection.PropertyInfo propa in props)");
            //sw.WriteLine("                {");
            //sw.WriteLine("                    object obja = propa.GetValue(obj, new object[] { });");
            //sw.WriteLine("                    if (obja != null && obja.GetType().Name.Contains(prop))");
            //sw.WriteLine("                    {");
            //sw.WriteLine("                        ret = this.EvaluateValue(obja, property.Substring(property.IndexOf(\".\") + 1));");
            //sw.WriteLine("                        break;");
            //sw.WriteLine("                    }");
            //sw.WriteLine("                }");
            //sw.WriteLine("            }");
            //sw.WriteLine("            else");
            //sw.WriteLine("            {");
            //sw.WriteLine("                System.Reflection.PropertyInfo pi = obj.GetType().GetProperty(prop);");
            //sw.WriteLine("                if (pi != null)");
            //sw.WriteLine("                {");
            //sw.WriteLine("                    object obja = pi.GetValue(obj, new object[] { });");
            //sw.WriteLine("                    if (obja != null)");
            //sw.WriteLine("                        ret = obja.ToString();");
            //sw.WriteLine("                }");
            //sw.WriteLine("            }");
            //sw.WriteLine("            return ret;");
            //sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建MyDateTimePicker类
            filepath = Path.Combine(path, "MyDateTimePicker.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyDateTimePicker : DateTimePicker, IControlBind");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _isNeedBind = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsNeedBind");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._isNeedBind; }");
            sw.WriteLine("            set { this._isNeedBind = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private string _fieldName = \"\";");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定的字段名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public string FieldName");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                if (this._fieldName.ToString() == \"\" && this._isNeedBind == true && this.Name.Length > 3)");
            sw.WriteLine("                {");
            sw.WriteLine("                    return this.Name.Substring(3);");
            sw.WriteLine("                }");
            sw.WriteLine("                return this._fieldName;");
            sw.WriteLine("            }");
            sw.WriteLine("            set { this._fieldName = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _nullable = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否允许以为空");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool Nullable");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._nullable; }");
            sw.WriteLine("            set { this._nullable = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyDialog类
            filepath = Path.Combine(path, "MyDialog.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyDialog : MyForm");
            sw.WriteLine("    {");
            sw.WriteLine("        public MyDialog()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // MyDialog");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.ClientSize = new System.Drawing.Size(800, 571);");
            sw.WriteLine("            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;");
            sw.WriteLine("            this.MaximizeBox = false;");
            sw.WriteLine("            this.MinimizeBox = false;");
            sw.WriteLine("            this.Name = \"MyDialog\";");
            sw.WriteLine("            this.ShowInTaskbar = false;");
            sw.WriteLine("            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;");
            sw.WriteLine("            this.Text = \"对话框\";");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyErrorProvider类
            filepath = Path.Combine(path, "MyErrorProvider.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyErrorProvider : ErrorProvider");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建MyForm类
            filepath = Path.Combine(path, "MyForm.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyForm : System.Windows.Forms.Form");
            sw.WriteLine("    {");
            sw.WriteLine("        public MyForm()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // MyForm");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.ClientSize = new System.Drawing.Size(800, 571);");
            sw.WriteLine("            this.Name = \"MyForm\";");
            sw.WriteLine("            this.ShowInTaskbar = false;");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyGroupBox类
            filepath = Path.Combine(path, "MyGroupBox.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.CompanyName + ".Controls ");
            sw.WriteLine("{");
            sw.WriteLine("    public class MyGroupBox : GroupBox");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建MyLabel类
            filepath = Path.Combine(path, "MyLabel.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyLabel : Label");
            sw.WriteLine("    {");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");

            sw.Close();
            file.Close();

            #endregion

            #region 创建MyMaskedTextBox类
            filepath = Path.Combine(path, "MyMaskedTextBox.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyMaskedTextBox : MaskedTextBox, IControlBind");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (msg.WParam.ToInt32() == (int)Keys.Enter)");
            sw.WriteLine("            {");
            sw.WriteLine("                SendKeys.Send(\"{Tab}\");");
            sw.WriteLine("            }");
            sw.WriteLine("            return base.ProcessCmdKey(ref msg, keyData);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnGotFocus(EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this.SelectAll();");
            sw.WriteLine("            base.OnGotFocus(e);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _isNeedBind = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsNeedBind");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._isNeedBind; }");
            sw.WriteLine("            set { this._isNeedBind = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private string _fieldName = \"\";");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定的字段名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public string FieldName");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                if (this._fieldName.ToString() == \"\" && this._isNeedBind == true && this.Name.Length > 3)");
            sw.WriteLine("                {");
            sw.WriteLine("                    return this.Name.Substring(3);");
            sw.WriteLine("                }");
            sw.WriteLine("                return this._fieldName;");
            sw.WriteLine("            }");
            sw.WriteLine("            set { this._fieldName = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _nullable = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否允许以为空");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool Nullable");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._nullable; }");
            sw.WriteLine("            set { this._nullable = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyPanel类
            filepath = Path.Combine(path, "MyPanel.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyPanel : Panel");
            sw.WriteLine("    {");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MySplitter类
            filepath = Path.Combine(path, "MySplitter.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MySplitter : Splitter");
            sw.WriteLine("    {");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyTextBox类
            filepath = Path.Combine(path, "MyTextBox.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyTextBox : TextBox,IControlBind");
            sw.WriteLine("    {");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)");
            sw.WriteLine("        {");
            sw.WriteLine("            if (msg.WParam.ToInt32() == (int)Keys.Enter)");
            sw.WriteLine("            {");
            sw.WriteLine("                SendKeys.Send(\"{Tab}\");");
            sw.WriteLine("            }");
            sw.WriteLine("            return base.ProcessCmdKey(ref msg, keyData);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        protected override void OnGotFocus(EventArgs e)");
            sw.WriteLine("        {");
            sw.WriteLine("            this.SelectAll();");
            sw.WriteLine("            base.OnGotFocus(e);");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _isNeedBind = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否需要绑定数据");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool IsNeedBind");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._isNeedBind; }");
            sw.WriteLine("            set { this._isNeedBind = value; }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private string _fieldName = \"\";");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 绑定的字段名称");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public string FieldName");
            sw.WriteLine("        {");
            sw.WriteLine("            get");
            sw.WriteLine("            {");
            sw.WriteLine("                if (this._fieldName.ToString() == \"\" && this._isNeedBind == true && this.Name.Length > 3)");
            sw.WriteLine("                {");
            sw.WriteLine("                    return this.Name.Substring(3);");
            sw.WriteLine("                }");
            sw.WriteLine("                return this._fieldName;");
            sw.WriteLine("            }");
            sw.WriteLine("            set { this._fieldName = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private bool _nullable = true;");
            sw.WriteLine("        /// <summary>");
            sw.WriteLine("        /// 是否允许以为空");
            sw.WriteLine("        /// </summary>");
            sw.WriteLine("        public bool Nullable");
            sw.WriteLine("        {");
            sw.WriteLine("            get { return this._nullable; }");
            sw.WriteLine("            set { this._nullable = value;  }");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyTreeView类
            filepath = Path.Combine(path, "MyTreeView.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Diagnostics;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyTreeView : TreeView");
            sw.WriteLine("    {");
            sw.WriteLine("        protected override void OnPaint(PaintEventArgs pe)");
            sw.WriteLine("        {");
            sw.WriteLine("            base.OnPaint(pe);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");


            sw.Close();
            file.Close();

            #endregion

            #region 创建MyUserControl类
            filepath = Path.Combine(path, "MyUserControl.cs");

            file = new FileStream(filepath, FileMode.Create);
            sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.ComponentModel;");
            sw.WriteLine("using System.Drawing;");
            sw.WriteLine("using System.Data;");
            sw.WriteLine("using System.Text;");
            sw.WriteLine("using System.Windows.Forms;");
            sw.WriteLine("");
            sw.WriteLine("namespace " + BaseParams.ControlsNameSpace);
            sw.WriteLine("{");
            sw.WriteLine("    public partial class MyUserControl : UserControl");
            sw.WriteLine("    {");
            sw.WriteLine("        public MyUserControl()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.InitializeComponent();");
            sw.WriteLine("        }");
            sw.WriteLine("");
            sw.WriteLine("        private void InitializeComponent()");
            sw.WriteLine("        {");
            sw.WriteLine("            this.SuspendLayout();");
            sw.WriteLine("            // ");
            sw.WriteLine("            // MyUserControl");
            sw.WriteLine("            // ");
            sw.WriteLine("            this.AutoScroll = true;");
            sw.WriteLine("            this.Name = \"MyUserControl\";");
            sw.WriteLine("            this.ResumeLayout(false);");
            sw.WriteLine("        }");
            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Close();
            file.Close();

            #endregion
        }
    }
}
