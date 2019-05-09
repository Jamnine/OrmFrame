using Aspose.Cells;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
//using System.Data.Odbc;
//using System.Windows.Input;
//using Excel = Microsoft.Office.Interop.Excel;
//using System.Windows.Media;
//using System.Windows.Controls.Primitives;

namespace Orm.Client.Common
{
    public class ExcelHelper
    {
        /// <summary>
        /// 讲list集合转换成datatable
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static System.Data.DataTable ListToDataTable(IList list)
        {
            System.Data.DataTable result = new System.Data.DataTable();
            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {
                    //获取类型
                    Type colType = pi.PropertyType;
                    //当类型为Nullable<>时
                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }
                    result.Columns.Add(pi.Name, colType);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i], null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }


        #region 原方法，依赖Office
        //private Excel.Application _excelApp = null;
        //private Excel.Workbook _book = null;
        //private Excel.Worksheet _sheet = null;

        //private Excel.Range _range = null;
        //private Excel.Font _font = null;
        //private object _optionalValue = Missing.Value;
        //string[] _head;
        //private void ReleaseCOM(object pObj)
        //{
        //    try
        //    {
        //        if (pObj != null)
        //        {
        //            System.Runtime.InteropServices.Marshal.ReleaseComObject(pObj);
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("释放资源时发生错误！");
        //    }
        //    finally
        //    {
        //        pObj = null;
        //    }
        //}

        ///// <summary>
        ///// 把DataGrid用Excel导出
        ///// </summary>
        ///// <param name="fileName"></param>
        ///// <param name="grid"></param>
        //public void ExportToExcel(string fileName, DataGrid grid)
        //{
        //    if (grid==null)
        //    {
        //        return;
        //    }
        //    if (Type.GetTypeFromProgID("Excel.Application") == null)
        //    {
        //        MessageBox.Show("未能找到Excel！请确保正确安装了Microsoft Office 2003以上版本！如仍无法导出，建议重装Office！");
        //        return;
        //    }
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Excel (*.XLSX)|*.xlsx";
        //    saveFileDialog.AddExtension = true;//是否自动添加扩展名

        //    saveFileDialog.OverwritePrompt = true;//文件已存在是否提示覆盖
        //    saveFileDialog.CheckPathExists = true;//提示输入的文件名无效
        //    saveFileDialog.FileName = fileName;//默认的文件名
        //    try
        //    {
        //        if ((bool)saveFileDialog.ShowDialog())
        //        {
        //            if (grid.Items.Count != 0)
        //            {
        //                //Mouse.SetCursor(Cursors.Wait);
        //                CreateExcelRef();
        //                FillSheet(grid);
        //                _excelApp.DisplayAlerts = false;
        //                _book.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //                //Mouse.SetCursor(Cursors.Arrow);
        //            }
        //            else
        //            {
        //                MessageBox.Show("没有数据将不会进行保存！");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //if(ex.Message.Contains("无法将型别'System.__ComObject'的COM对象转换为接口型别'Microsoft.Office.Interop.Excel._Application'"))
        //        //if (ex.Message.Contains("无法将型别”System.__ComObject“的COM对象转换为接口型别”Microsoft.Office.Interop.Excel._Application“"))
        //        //不同机子可能复制出来的错误信息中的引号有不用，有的是单引号，有的是中文双引号。
        //        if (ex.Message.Contains("System.__ComObject")&&ex.Message.Contains("对象强制转换为接口类型")&&ex.Message.Contains("Microsoft.Office.Interop.Excel.Application"))
        //        {
        //            MessageBox.Show("请安装Microsoft Office Excel 2003以上版本");
        //        }
        //        else
        //        {
        //            throw (ex);
        //        }
        //    }
        //    finally
        //    {
        //        if (_book != null) _book.Close(false);
        //        if (_excelApp != null)
        //        {
        //            _excelApp.Quit();
        //            ReleaseCOM(_excelApp);
        //        }
        //    }


        //}

        //public void ExportToExcel(string fileName, DataTable tabel)
        //{
        //    if (tabel == null) return;
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Excel (*.XLSX)|*.xlsx";
        //    saveFileDialog.AddExtension = true;//是否自动添加扩展名

        //    saveFileDialog.OverwritePrompt = true;//文件已存在是否提示覆盖
        //    saveFileDialog.CheckPathExists = true;//提示输入的文件名无效
        //    saveFileDialog.FileName = fileName;//默认的文件名
        //    try
        //    {
        //        if ((bool)saveFileDialog.ShowDialog())
        //        {
        //            if (tabel.Rows.Count != 0)
        //            {
        //                //Mouse.SetCursor(Cursors.Wait);
        //                CreateExcelRef();
        //                FillSheet(tabel);
        //                _excelApp.DisplayAlerts = false;
        //                _book.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        //                //Mouse.SetCursor(Cursors.Arrow);
        //            }
        //            else
        //            {
        //                MessageBox.Show("没有数据将不会进行保存！");
        //            }
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {
        //        if (_book != null) _book.Close(false);
        //        if (_excelApp != null)
        //        {
        //            _excelApp.Quit();
        //            ReleaseCOM(_excelApp);
        //        }
        //    }
        //}

        // //<summary>
        // //将数据填充到内存Excel的工作表
        // //</summary>
        // //<param name="grid"></param>
        //private void FillSheet(DataGrid grid)
        //{
        //    object[] header = CreateHeader(grid);
        //    WriteData(header, grid);
        //}
        //private void WriteData(object[] header, DataGrid grid)
        //{
        //    object[,] objData = new object[grid.Items.Count, header.Length];
        //    List<object> cells = new List<object>(header.Length);
        //    for (int j = 0; j < grid.Items.Count; j++)
        //    {
        //        var obj = grid.Items[j];
        //        for (int i = 0; i < header.Length; i++)
        //        {
        //            //注意DataGrid不能有空行，否则出错
        //            objData[j, i] = Orm.Utilities.Common.GetPropertyValue(obj, _head[i]);
        //        }
        //        cells.Clear();
        //    }
        //    AddExcelRows("A2", grid.Items.Count, header.Length, objData);
        //    AutoFitColumns("A1", grid.Items.Count + 1, header.Length);
        //}


        //private void AutoFitColumns(string startRange, int rowCount, int colCount)
        //{
        //    _range = _sheet.get_Range(startRange, _optionalValue);
        //    _range = _range.get_Resize(rowCount, colCount);
        //    _range.Columns.AutoFit();
        //}

        ///// <summary>
        ///// 获取表头数据 headerToAdd 和属性名 _head[] 如："批号","PNo"
        ///// </summary>
        ///// <param name="grid"></param>
        ///// <returns></returns>
        //private object[] CreateHeader(DataGrid grid)
        //{
        //    _head = new string[grid.Columns.Count];
        //    List<object> objHeaders = new List<object>();
        //    for (int n = 0; n < grid.Columns.Count; n++)
        //    {
        //        if (grid.Columns[n].Header.ToString().Contains("选择") || grid.Columns[n].Header.ToString().Contains("选中") || grid.Columns[n].Header.ToString().Contains("是否"))
        //        {
        //            continue;
        //        }
        //        objHeaders.Add(grid.Columns[n].Header);
        //        _head[n] = grid.Columns[n].SortMemberPath;
        //    }

        //    var headerToAdd = objHeaders.ToArray();
        //    //工作表的单元是从“A1”开始
        //    AddExcelRows("A1", 1, headerToAdd.Length, headerToAdd);
        //    SetHeaderStyle();

        //    return headerToAdd;
        //}

        //private void FillSheet(DataTable tabel)
        //{
        //    object[] header = CreateHeader(tabel);
        //    WriteData(header, tabel);
        //}

        //private object[] CreateHeader(DataTable tabel)
        //{
        //    //_head = new string[tabel.Columns.Count];
        //    List<object> objHeaders = new List<object>();
        //    for (int n = 0; n < tabel.Columns.Count; n++)
        //    {
        //        if (tabel.Columns[n].ColumnName.Contains("选择") || tabel.Columns[n].ColumnName.Contains("选中") || tabel.Columns[n].ColumnName.Contains("是否"))
        //        {
        //            continue;
        //        }
        //        objHeaders.Add(tabel.Columns[n].ColumnName);
        //        //_head[n] = tabel.Columns[n].SortMemberPath;
        //    }

        //    var headerToAdd = objHeaders.ToArray();
        //    //工作表的单元是从“A1”开始
        //    AddExcelRows("A1", 1, headerToAdd.Length, headerToAdd);
        //    SetHeaderStyle();

        //    return headerToAdd;
        //}

        //private void WriteData(object[] header, DataTable tabel)
        //{

        //    object[,] objData = new object[tabel.Rows.Count, header.Length];
        //    List<object> cells = new List<object>(header.Length);
        //    for (int j = 0; j < tabel.Rows.Count; j++)
        //    {
        //        var obj = tabel.Rows[j];
        //        for (int i = 0; i < header.Length; i++)
        //        {
        //            string headerName = header[i].ToString();
        //            objData[j, i] = obj[headerName];
        //        }
        //        cells.Clear();
        //    }
        //    AddExcelRows("A2", tabel.Rows.Count, header.Length, objData);
        //    AutoFitColumns("A1", tabel.Rows.Count + 1, header.Length);
        //}

        ///// 将表头加粗显示
        //private void SetHeaderStyle()
        //{
        //    _font = _range.Font;
        //    _font.Bold = true;
        //}

        ///// 将表数据填充到Excel工作表的单元格中
        //private void AddExcelRows(string startRange, int rowCount, int colCount, object values)
        //{
        //    _range = _sheet.get_Range(startRange, _optionalValue);
        //    _range = _range.get_Resize(rowCount, colCount);
        //    _range.set_Value(_optionalValue, values);
        //}

        ///// 创建一个Excel程序实例
        //private void CreateExcelRef()
        //{
        //    _excelApp = new Excel.Application();
        //    _book = _excelApp.Workbooks.Add(_optionalValue);
        //    _sheet = (Excel.Worksheet)(_book.Worksheets[1]);
        //}
        #endregion
        //private Worksheet _sheet = null;
        //private Range _range = null;
        //private Font _font = null;
        private string[] _head;
        //private object _optionalValue = Missing.Value;


        public ExcelHelper()
        {
            // 
            //TODO: 在此处添加构造函数逻辑 
            // 
        }
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="grid"></param>
        public void ExportToExcel(string fileName, DataGrid grid)
        {
            bool isExportSuccessful=false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.XLSX)|*.xlsx";
            saveFileDialog.AddExtension = true;//是否自动添加扩展名
            
            saveFileDialog.OverwritePrompt = true;//文件已存在是否提示覆盖
            saveFileDialog.CheckPathExists = true;//提示输入的文件名无效
            saveFileDialog.FileName = fileName;//默认的文件名
            try
            {
                if ((bool)saveFileDialog.ShowDialog())
                {
                    if (grid != null && grid.Items.Count != 0)
                    {
                        isExportSuccessful=OutFileToDisk(grid, saveFileDialog.FileName);
                    }
                    else
                    {
                        //Orm.Client.Base.FrmMessageRemind.Show("没有数据将不会进行保存！", "系统提示");                 
                    }
                }
            }
            catch (System.Exception e)
            {
                //Orm.Client.Base.FrmMessageRemind.Show("单据没有数据请检查！" + e.ToString(), "系统提示");     
            }
            finally
            {
                if (isExportSuccessful)
                {
                    //Orm.Client.Base.FrmMessageRemind.Show("导出成功！" , "系统提示");
                }
            }
        }
        public void ExportToExcel(string fileName, DataTable table)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.XLSX)|*.xlsx";
            saveFileDialog.AddExtension = true;//是否自动添加扩展名

            saveFileDialog.OverwritePrompt = true;//文件已存在是否提示覆盖
            saveFileDialog.CheckPathExists = true;//提示输入的文件名无效
            saveFileDialog.FileName = fileName;//默认的文件名
            try
            {
                if ((bool)saveFileDialog.ShowDialog())
                {
                    if (table.Rows.Count != 0)
                    {
                        OutFileToDisk(table, "", saveFileDialog.FileName);
                        //OutFileToStream(table, "123");
                    }
                    else
                    {
                        //Orm.Client.Base.FrmMessageRemind.Show("没有数据将不会进行保存！", "系统提示");
                    }
                }
            }
            catch
            {

            }
            finally
            {
            }
        }

        /// <summary>
        /// 工资管理数据导出
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="table"></param>
        public bool ExportToExcelSalary(string fileName, DataTable table)
        {
            bool IsSuccess = false;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel (*.XLSX)|*.xlsx";
            saveFileDialog.AddExtension = true;//是否自动添加扩展名

            saveFileDialog.OverwritePrompt = true;//文件已存在是否提示覆盖
            saveFileDialog.CheckPathExists = true;//提示输入的文件名无效
            saveFileDialog.FileName = fileName;//默认的文件名
            try
            {
                if ((bool)saveFileDialog.ShowDialog())
                {
                    if (table.Rows.Count != 0)
                    {
                        OutFileToDiskSalary(table, fileName, saveFileDialog.FileName);
                        IsSuccess = true;
                    }
                    else
                        MessageBox.Show("没有数据将不会进行保存！");
                }
            }
            catch
            {
            }
            finally
            {
            }
            return IsSuccess;
        }

        public bool OutFileToDisk(DataGrid grid, string path)
        {
            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格  
            //样式2 
            Aspose.Cells.Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;
            //样式3 
            Aspose.Cells.Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小
            //style3.IsTextWrapped = true;
            //style3.IsGradient = true;
            style3.IsJustifyDistributed = true;
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            #region 生成表头行

            //取行数据的依据
            _head = new string[grid.Columns.Count];
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                
                if (grid.Columns[i].Visibility != Visibility.Visible || string.IsNullOrEmpty(grid.Columns[i].Header.ToString()) || grid.Columns[i].Header.ToString().Contains("选择") || grid.Columns[i].Header.ToString().Contains("选中") || grid.Columns[i].Header.ToString().Contains("是否")|| grid.Columns[i].Header.ToString().Contains("审核") || grid.Columns[i].Header.ToString()=="操作")
                {
                    continue;
                }
                cells[0, i].PutValue(grid.Columns[i].Header.ToString());
                cells[0, i].SetStyle(style2);
                if (grid.Columns[i].Header.ToString()== "买入价")
                {
                    _head[i] = "StockPrice";
                }
                else
                {
                    _head[i] = grid.Columns[i].SortMemberPath;
                }
           

            }

            #endregion

            #region 生成数据行
            object[,] objData = new object[grid.Items.Count, _head.Length];
            for (int j = 0; j < grid.Items.Count; j++)
            {
                var obj = grid.Items[j];
                for (int i = 0; i < _head.Length; i++)
                {
                    if (_head[i] != null)
                    {
                        //注意DataGrid不能有空行，否则出错
                        var property = Orm.Utilities.Common.GetPropertyValue(obj, _head[i]);
                        if (property == null)
                        {
                            
                            cells[j + 1, i].PutValue("");
                        }
                        else
                        {
                            if (property.GetType().Name == "DateTime" &&( _head[i].Trim()== "InvoTime" || _head[i].Trim() == "InputTime"))
                            {
                                cells[j + 1, i].PutValue(Convert.ToDateTime(Orm.Utilities.Common.GetPropertyValue(obj, _head[i])).ToShortDateString());
                            }
                            else
                            {
                                cells[j + 1, i].PutValue(Orm.Utilities.Common.GetPropertyValue(obj, _head[i]).ToString());
                            }
                            
                        }
                        cells[j + 1, i].SetStyle(style3);
                    }
                }
                cells.SetRowHeight(1 + j, 24);
            }
            //标准宽度，如果能自动调整列宽更好
            cells.StandardWidth = 20;
            cells.DeleteBlankColumns();
            #endregion
            sheet.AutoFitColumns();
            workbook.Save(path);

            return true;
        }
        /// <summary> 
        /// 导出数据到本地 
        /// </summary> 
        /// <param name="dt">要导出的数据</param> 
        /// <param name="tableName">表格标题</param> 
        /// <param name="path">保存路径</param> 
        public void OutFileToDisk(DataTable dt, string tableName, string path)
        {
            int tab = 1;
            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格 

            int Colnum = dt.Columns.Count;//表格列数 
            int Rownum = dt.Rows.Count;//表格行数 

            if (!string.IsNullOrWhiteSpace(tableName))
            {
                Rownum++;
                tab = 2;
                //为标题设置样式     
                Aspose.Cells.Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式 
                styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
                styleTitle.Font.Name = "宋体";//文字字体 
                styleTitle.Font.Size = 18;//文字大小 
                styleTitle.Font.IsBold = true;//粗体 

                //生成行1 标题行    
                cells.Merge(0, 0, 1, Colnum);//合并单元格 
                cells[0, 0].PutValue(tableName);//填写内容 
                cells[0, 0].SetStyle(styleTitle);
                cells.SetRowHeight(0, 38);
            }

            //样式2 
            Aspose.Cells.Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3 
            Aspose.Cells.Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小 
            style3.IsTextWrapped = true;
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //生成行2 列名行 
            for (int i = 0; i < Colnum; i++)
            {
                cells[0, i].PutValue(dt.Columns[i].ColumnName);
                cells[0, i].SetStyle(style2);
                cells.SetRowHeight(1, 25);
            }

            //生成数据行 
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[tab + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[tab + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(tab + i, 24);
            }
            cells.IsDefaultRowHeightMatched = true;
            cells.DeleteBlankColumns();
            workbook.Save(path);
        }

        /// <summary>
        /// 工资管理数据导出
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tableName"></param>
        /// <param name="path"></param>
        public void OutFileToDiskSalary(DataTable dt, string tableName, string path)
        {
            int tab = 1;
            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格 

            int Colnum = dt.Columns.Count;//表格列数 
            int Rownum = dt.Rows.Count - 1;//表格行数 

            if (!string.IsNullOrWhiteSpace(tableName))
            {
                Rownum++;
                tab = 2;
                //为标题设置样式     
                Aspose.Cells.Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式 
                styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
                styleTitle.Font.Name = "宋体";//文字字体 
                styleTitle.Font.Size = 18;//文字大小 
                styleTitle.Font.IsBold = true;//粗体 

                //生成行1 标题行    
                cells.Merge(0, 0, 1, Colnum);//合并单元格 
                cells[0, 0].PutValue(tableName);//填写内容 
                cells[0, 0].SetStyle(styleTitle);
                cells.SetRowHeight(0, 38);
            }

            //样式2 
            Aspose.Cells.Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3 
            Aspose.Cells.Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小 
            style3.IsTextWrapped = true;
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //生成行2 列名行 
            for (int i = 0; i < Colnum; i++)
            {
                cells[1, i].PutValue(dt.Columns[i].ColumnName);
                cells[1, i].SetStyle(style2);
                cells.SetRowHeight(1, 25);
            }
            //生成数据行 
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[tab + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[tab + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(tab + i, 24);
            }
            //cells.IsDefaultRowHeightMatched = true;
            cells.DeleteBlankColumns();
            workbook.Save(path);
        }

        public MemoryStream OutFileToStream(DataTable dt, string tableName)
        {
            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格 

            //为标题设置样式     
            Aspose.Cells.Style styleTitle = workbook.Styles[workbook.Styles.Add()];//新增样式 
            styleTitle.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            styleTitle.Font.Name = "宋体";//文字字体 
            styleTitle.Font.Size = 18;//文字大小 
            styleTitle.Font.IsBold = true;//粗体 

            //样式2 
            Aspose.Cells.Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3 
            Aspose.Cells.Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小 
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            int Colnum = dt.Columns.Count;//表格列数 
            int Rownum = dt.Rows.Count;//表格行数 

            //生成行1 标题行    
            cells.Merge(0, 0, 1, Colnum);//合并单元格 
            cells[0, 0].PutValue(tableName);//填写内容 
            cells[0, 0].SetStyle(styleTitle);
            cells.SetRowHeight(0, 38);

            //生成行2 列名行 
            for (int i = 0; i < Colnum; i++)
            {
                cells[1, i].PutValue(dt.Columns[i].ColumnName);
                cells[1, i].SetStyle(style2);
                cells.SetRowHeight(1, 25);
            }

            //生成数据行 
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[2 + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[2 + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(2 + i, 24);
            }

            MemoryStream ms = workbook.SaveToStream();
            return ms;
        } 
    }
}
