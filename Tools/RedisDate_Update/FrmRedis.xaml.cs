using ELinq;
using OracleDataToRedis.DataAccess;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Services;
using OracleDataToRedis.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using XYHis.Redis;

namespace RedisDate_Update
{
    /// <summary>
    /// FrmRedis.xaml 的交互逻辑
    /// </summary>
    public partial class FrmRedis : Window
    {
        public FrmRedis()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                SynchronizationContext.SetSynchronizationContext(new
                DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                SynchronizationContext.Current.Post(pl =>
                {
                    Lith.Value = 0;
                    Msg.Text += "【开始更新】 ：" + tableName.Text + "\r\n";
                }, null);
            });
            Task t = new Task(() =>
            {
                LongRunningProcess(false);
            });
            t.Start();
        }
        public void LongRunningProcess(bool isAll)
        {
            string dataSource = ConfigurationManager.AppSettings["Data Source"].ToString().Trim();
            string passWord = ConfigurationManager.AppSettings["Password"].ToString().Trim();
            string userId = ConfigurationManager.AppSettings["Redis.DefaultKey"].ToString().Trim();
            DataBaseHelper.ConnectionString = string.Format("Data Source={0};User ID={1};Password={2};", dataSource, userId, passWord);

            List<DbTable> databaseTableList = new List<DbTable>();//所有基础表变量
            var allTablesInDB = DbTableService.Instance.GetAllOfTables();
            if (isAll)
            {
                databaseTableList = allTablesInDB.Where(t => t.Name.ToUpper().Contains("BS") || t.Name.ToUpper().Contains("GBL")).ToList();
                DbTable dbTable = databaseTableList.Find(t => t.Name == "BSITEMFREQUENCY");
                DbTable dbTable1 = databaseTableList.Find(t => t.Name == "BSITEMLOCATION");
                DbTable dbTable2 = databaseTableList.Find(t => t.Name == "BSREDISTABLE");
                DbTable dbTable3 = databaseTableList.Find(t => t.Name == "BSBPCURE");
                databaseTableList.Remove(dbTable);
                databaseTableList.Remove(dbTable2);
                databaseTableList.Remove(dbTable1);
                databaseTableList.Remove(dbTable3);
                ImportDataToRedis(databaseTableList);
            }
            else
            {
                this.Dispatcher.Invoke(new Action(() =>
                {
                    databaseTableList = allTablesInDB.Where(t => t.Name.ToUpper() == this.tableName.Text.ToString().ToUpper()).ToList();
                }));

                if (databaseTableList.Count == 0)
                {
                    ThreadPool.QueueUserWorkItem(delegate
                    {
                        SynchronizationContext.SetSynchronizationContext(new
                        DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                        SynchronizationContext.Current.Post(pl =>
                        {
                            Msg.Text += "【更新结果】 ：" + "表不存在" + "\n";

                        }, null);
                    });
                    return;
                }
                else
                {
                    ThreadPool.QueueUserWorkItem(delegate
                    {
                        SynchronizationContext.SetSynchronizationContext(new
                        DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                        SynchronizationContext.Current.Post(pl =>
                        {
                            Msg.Text += "【状态信息】 ：.  .   .   .   .   ." + "\n";
                        }, null);
                    });
                }
                Task task = new Task(() =>
                {
                    ImportDataToRedis(databaseTableList);
                });
                task.Start();

            }
        }

        /// <summary>
        /// 将数据库数据插入到redis
        /// </summary>
        /// <param name="databaseTableList">所有基础表</param>
        private void ImportDataToRedis(List<DbTable> databaseTableList)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                //try
                //{
                int dataTableCount = databaseTableList.Count;

                Assembly assembly = Assembly.Load(@"XYHis.Model");
                Type[] classTableTypes = assembly.GetTypes();//所有的model类
                Assembly mapContextAssembly = Assembly.Load(@"XYHis.MapContext");
                Type[] mapContextTypes = mapContextAssembly.GetTypes();//所有的映射类
                XYHis.Framework.Services.DBServiceBase db = new XYHis.Framework.Services.DBServiceBase();
                RedisWriteExHelper redisExHelper = new RedisWriteExHelper();
                int tableIndex = 0;
                int recordCount = 0;
                DbConfiguration dbConfiguration = db.GetCurrentDBContext().DbConfiguration;//当前数据库上下文
                string tablename = string.Empty;
                string tablename2 = string.Empty;
                foreach (DbTable dt in databaseTableList)
                {
                    //获取表记录大小
                    string sql = string.Format("select count(*) from {0}", dt.Name);
                    recordCount = int.Parse(SqlHelper.ExecuteScalar(CommandType.Text, sql).ToString());//数据库记录数量
                    if (recordCount > 40000)
                    {
                        dataTableCount -= 1;
                        //MessageBox.Show("数据大于40000，暂不更新");
                        continue;
                    }
                    if (recordCount == 0)
                    {
                        dataTableCount -= 1;
                        //MessageBox.Show("数据大于40000，暂不更新");
                        continue;
                    }
                    tableIndex += 1;

                    var ss = DbRelationService.Instance.SetParentRelations(dt, databaseTableList);
                    string[] relationColumns = new string[dt.ParentRelations.Count];//表的所有外键
                    int k = 0;
                    foreach (DbRelation relation in dt.ParentRelations)
                    {
                        relationColumns[k] = relation.FK_Relation_Column;
                        k++;
                    }

                    List<Type> classTypeList = classTableTypes.Where(t => t.Name.ToUpper() == dt.Name).ToList();//model类
                    List<Type> mapTypeList = mapContextTypes.Where(t => t.Name.ToUpper().Contains(dt.Name + "MAPPING")).ToList();//映射类

                    if (classTypeList.Count > 0 && mapTypeList.Count > 0)
                    {//model类和映射类都有的情况才进行导入
                        Type currentClssType = classTypeList[0];
                        RedisWriteHelper.KeyDelete(currentClssType.Name);//导入前先删除已有的数据
                        try
                        {
                            dbConfiguration.GetClass(currentClssType);
                        }
                        catch
                        {
                            dataTableCount -= 1;
                            continue;
                        }
                        Type dbServiceBaseType = db.GetType();
                        MethodInfo mi = dbServiceBaseType.GetMethod("GetAllListUseInDataImport", new Type[] { }).MakeGenericMethod(currentClssType);
                        object obj = mi.Invoke(db, null);
                        Type redisExHelperType = redisExHelper.GetType();
                        mi = redisExHelperType.GetMethod("ImportDataToSet").MakeGenericMethod(currentClssType);
                        mi.Invoke(redisExHelper, new object[] { currentClssType.Name, obj, relationColumns, recordCount });
                        tablename2 = currentClssType.Name;
                        if (tableIndex <= 1)
                        {
                            tablename = currentClssType.Name;

                        }
                    }
                    else
                    {
                        dataTableCount -= 1;
                    }
                    if (tableIndex <= 1)
                    {
                        ThreadPool.QueueUserWorkItem(delegate
                        {
                            SynchronizationContext.SetSynchronizationContext(new
                            DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                            SynchronizationContext.Current.Post(pl =>
                            {
                                //总数
                                Msg.Text += "【更新总数】 ：" + dataTableCount.ToString() + " 张表信息" + "\n";
                                //this.allcountText.Text = dataTableCount.ToString() + " ";
                                //更新数
                                Msg.Text += "【已更新数】 ：" + tableIndex.ToString() + " 张表信息" + "\n";
                                //this.currcount.Text = tableIndex.ToString() + " ";
                                //成功数
                                Msg.Text += "【状态信息】 ：" + tablename2.ToString() + " " + "共 " + recordCount + " 行记录更新" + "\n";
                                //this.succcount.Text = tablename2.ToString() + " " + "" + recordCount;
                                //更新百分比
                                this.Lith.Value = Convert.ToDouble(tableIndex) / Convert.ToDouble(dataTableCount) * 100;
                                //this.Lith.Value = Convert.ToDouble(tableIndex) / Convert.ToDouble(dataTableCount) * 100;
                                //更新百分比数字
                                Msg.Text += "【状态信息】 ：" + "已更新 " + Math.Round(this.Lith.Value).ToString() + " %" + "\n";
                                //this.LithText.Text = Math.Round(this.Lith.Value).ToString() + " %";
                                //消息
                                Msg.Text += "【状态信息】 ：" + string.Format("成功更新 [{0}] 表", tablename) + "\n";
                                //this.msg.Text = string.Format("成功更新 [{0}] 表", tablename);
                            }, null);
                        });
                    }
                    else if (tableIndex == dataTableCount)
                    {

                    }
                    if (tableIndex != 1)
                    {
                        ThreadPool.QueueUserWorkItem(delegate
                        {
                            SynchronizationContext.SetSynchronizationContext(new
                            DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                            SynchronizationContext.Current.Post(pl =>
                            {
                                //总数
                                Msg.Text += "【更新总数】 ：" + dataTableCount.ToString() + " 张表信息" + "\n";
                                //this.allcountText.Text = dataTableCount.ToString() + " ";
                                //更新数
                                Msg.Text += "【已更新数】 ：" + tableIndex.ToString() + " 张表信息" + "\n";
                                //this.currcount.Text = tableIndex.ToString() + " ";
                                //成功数
                                Msg.Text += "【状态信息】 ：" + tablename2.ToString() + " " + "共 " + recordCount + " 行记录更新" + "\n";
                                //this.succcount.Text = tablename2.ToString() + " " + "" + recordCount;
                                //更新百分比
                                this.Lith.Value = Convert.ToDouble(tableIndex) / Convert.ToDouble(dataTableCount) * 100;
                                //this.Lith.Value = Convert.ToDouble(tableIndex) / Convert.ToDouble(dataTableCount) * 100;
                                //更新百分比数字
                                Msg.Text += "【状态信息】 ：" + "已更新 " + Math.Round(this.Lith.Value).ToString() + " %" + "\n";
                                //this.LithText.Text = Math.Round(this.Lith.Value).ToString() + " %";
                                //消息
                                Msg.Text += "【状态信息】 ：" + string.Format("成功更新 [{0}] 表", tablename) + "\n";
                                //this.msg.Text = string.Format("成功更新 [{0}] 表", tablename);

                            }, null);
                        });
                    }
                }
            });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 在此处添加事件处理程序实现。
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Msg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
