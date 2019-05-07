using Aspose.Cells;
using System;
using System.Data;

//using System.Data;
using System.Windows.Forms; 
//using System.Windows.Input;
//using System.Windows.Data;

namespace Orm.Client.Common
{
    public static class ExcelImport
    {
        public static System.Data.DataTable ImportExcelToDataTable()
       {
            var ofd = new System.Windows.Forms.OpenFileDialog()
            {
                //Filter = "Microsoft Office Excel 工作簿(*.xls)|*.xls|*.xlsx",
                Filter = "Excel (*.XLSX)|*.xlsx",
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.Cancel) return null; 
            System.Data.DataTable tempdt = new System.Data.DataTable();
            tempdt.TableName = "Excel";

            //Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            object obj = System.Reflection.Missing.Value;
            //Workbook _wBook = app.Workbooks.Open(ofd.FileName, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj);
            //Worksheet _wSheet = (Worksheet)_wBook.Worksheets.get_Item(1);
            Workbook _wBook = new Workbook(ofd.FileName);
            Worksheet _wSheet = _wBook.Worksheets[0];
            Cells _cells = _wSheet.Cells;
            //return _cells.ExportDataTableAsString(0, 0, _cells.MaxDataRow + 1, _cells.MaxDataColumn + 1, true);
            try
            {
                DataRow newRow = null;
                DataColumn newColumn = null;
                for (int i = 2; i <= _cells.MaxDataRow; i++)//_wSheet.UsedRange.Rows.Count
                {
                    newRow = tempdt.NewRow();
                    for (int j = 1; j <= _cells.MaxDataColumn ; j++)
                    {
                        if (i == 2)
                        {
                            if (_cells[1, j].Value != null)
                            { 
                                string str = _cells[1, j].Value.ToString();
                                newColumn = new DataColumn(str);
                                newRow.Table.Columns.Add(newColumn);
                            }
                        }
                        if (_cells[i, j] != null && !"".Equals(_cells[i, j].ToString()))
                        {
                            newRow[j - 1] = _cells[i, j].Value;
                        }
                    }
                    tempdt.Rows.Add(newRow);
                }
                //for (int i = 2; i <= _wSheet.UsedRange.Rows.Count; i++)
                //{
                //    newRow = tempdt.NewRow();
                //    for (int j = 1; j <= _wSheet.UsedRange.Columns.Count; j++)
                //    {
                //        if (i == 2 && j == 1)
                //        {
                //            //表头
                //            for (int k = 1; k <= _wSheet.UsedRange.Columns.Count; k++)
                //            {
                //                string str = (_wSheet.UsedRange[1, k] as Range).Value2.ToString();
                //                newColumn = new DataColumn(str);
                //                newRow.Table.Columns.Add(newColumn);
                //            }
                //        }
                //        Range range = _wSheet.Cells[i, j] as Range;
                //        if (range != null && !"".Equals(range.Text.ToString()))
                //        {
                //            newRow[j - 1] = range.Value2;

                //        }
                //    }
                //    tempdt.Rows.Add(newRow);
                //}
                return tempdt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //_wBook.Close(false);
                //app.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
        }
    }

    
}
