using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OracleDataToRedis
{
    public partial class MyDataGridView : DataGridView
    {
        public MyDataGridView()
            : base()
        {
            this.AutoGenerateColumns = true;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            try
            {
                base.OnPaint(pe);
            }
            catch
            { }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.WParam.ToInt32() == (int)Keys.Enter)
            {
                SendKeys.Send("{Tab}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                           e.RowBounds.Location.Y,
                           this.RowHeadersWidth - 4,
                           e.RowBounds.Height);
            string rowIndex = (e.RowIndex + 1).ToString();
            TextRenderer.DrawText(e.Graphics, rowIndex,
                this.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            StringFormat sf = new StringFormat(StringFormat.GenericTypographic);
            int w = (int)e.Graphics.MeasureString(rowIndex, this.RowHeadersDefaultCellStyle.Font, 1000).Width;
            if (this.RowHeadersWidth < w + 20)
                this.RowHeadersWidth = w + 20;

            base.OnRowPostPaint(e);
        }
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if (this.Columns[e.ColumnIndex].DataPropertyName.Contains(".") == true)
            {
                e.Value = EvaluateValue(this.Rows[e.RowIndex].DataBoundItem, this.Columns[e.ColumnIndex].DataPropertyName);
            }
            base.OnCellFormatting(e);
        }

        private string EvaluateValue(object obj, string property)
        {
            string prop = property;
            string ret = string.Empty;
            if (property.Contains("."))
            {
                prop = property.Substring(0, property.IndexOf("."));
                System.Reflection.PropertyInfo[] props = obj.GetType().GetProperties();
                foreach (System.Reflection.PropertyInfo propa in props)
                {
                    object obja = propa.GetValue(obj, new object[] { });
                    if (obja != null && obja.GetType().Name.Contains(prop))
                    {
                        ret = this.EvaluateValue(obja, property.Substring(property.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                System.Reflection.PropertyInfo pi = obj.GetType().GetProperty(prop);
                if (pi != null)
                {
                    object obja = pi.GetValue(obj, new object[] { });
                    if (obja != null)
                        ret = obja.ToString();
                }
            }
            return ret;
        }
    }
}
