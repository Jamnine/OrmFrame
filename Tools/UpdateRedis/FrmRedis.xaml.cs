using ELinq;
using OracleDataToRedis.DataAccess;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Services;
using OracleDataToRedis.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using XYHis.Redis;

namespace redis_update
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
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 在此处添加事件处理程序实现。
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Min_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lith.Value = 0;
            //allcountText.Text = " ";
            //currcount.Text = " ";
            //succcount.Text = "";
            //msg.Text = ("更新中......");
            //LithText.Text = "0 %";
            LongRunningProcess(true);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SwitchingVersionMsg();
            Operationbat("CopyFormal.bat");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SwitchingVersionMsg();
            Operationbat("CopyTest.bat");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SwitchingVersionMsg();
            Operationbat("CopyDevelopment.bat");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Operationbat("TestRedis.bat");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Operationbat("FormalRedis.bat");
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
                this.Dispatcher.Invoke(new Action(() => {
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
                                Msg.Text += "【已更新数】 ：" + tableIndex.ToString() +" 张表信息"+ "\n";
                                //this.currcount.Text = tableIndex.ToString() + " ";
                                //成功数
                                Msg.Text += "【状态信息】 ：" + tablename2.ToString() + " " + "共 " + recordCount+" 行记录更新" + "\n";
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
                    if (tableIndex!=1)
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string ss = XYHis.Framework.Services.AppSettings.ConfigDB_Key;

            string ExchangeName = ConfigurationManager.AppSettings["XYHis.RabbitMQ.ExchangeName"].ToString();
            string Routingkey = ConfigurationManager.AppSettings["XYHis.RabbitMQ.Routingkey"].ToString();
            string RedisDefaultKey = ConfigurationManager.AppSettings["Redis.DefaultKey"].ToString();
            string dataSource = ConfigurationManager.AppSettings["Data Source"].ToString().Trim();
            string ConnectString = ConfigurationManager.ConnectionStrings["RedisWriteConnection"].ToString();
            RedisDefaultKey = (RedisDefaultKey == "XXHISYYLT" ? "公司开发库" : (RedisDefaultKey == "LHZSYLT" ? "联合正式库" : (RedisDefaultKey == "LHZSYLT_TEST" ? "联合测试库" : "未知数据库")));
            string CurrentDatabasetext = dataSource + " - " + RedisDefaultKey;
            this.infomsg.Text = string.Format("当前数据库:【{0}】当前Redis:【{1}】 ", CurrentDatabasetext, ConnectString.Substring(0, 18));
            //CurrentDatabase.Text = string.Format("当前数据库:【{0}】当前Redis:【{1}】 ", CurrentDatabasetext, ConnectString.Substring(0, 18));
        }

        /// <summary>
        /// 执行执行文件
        /// </summary>
        /// <param name="FileName">执行文件名</param>
        public void Operationbat(string FileName)
        {
            Process proc = null;
            try
            {
                //命令行地址
                string targetDir = AppDomain.CurrentDomain.BaseDirectory;
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = FileName;
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;//这里设置DOS窗口不显示，经实践可行
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
        }

        /// <summary>
        /// 切换版本
        /// </summary>
        public void SwitchingVersionMsg()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                SynchronizationContext.SetSynchronizationContext(new
                DispatcherSynchronizationContext(System.Windows.Application.Current.Dispatcher));
                SynchronizationContext.Current.Post(pl =>
                {
                    //this.TableName.Text = "Redis版本切换中，自动重启";
                }, null);
            });
        }

        private void Msg_TextChanged(object sender, TextChangedEventArgs e)
        {
            Msg.ScrollToEnd();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SwitchingVersionMsg();
            Operationbat("CopyYfb.bat");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Msg.Text = "";
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Operationbat("DoubleClick.bat");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.CurrentDirectory + "\\Redisconf\\";
            string path2 = @"C:\Program Files\Redis";
            //bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
            //System.IO.File.Copy(path, path2, isrewrite);
            CopyDirectory(path, path2);

            Operationbat("TestRedis.bat");
        }
        public void CopyDirectory(string sourceDirName, string destDirName)
        {
            try
            {
                if (!Directory.Exists(destDirName))
                {
                    Directory.CreateDirectory(destDirName);
                    File.SetAttributes(destDirName, File.GetAttributes(sourceDirName));

                }

                if (destDirName[destDirName.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                    destDirName = destDirName + System.IO.Path.DirectorySeparatorChar;

                string[] files = Directory.GetFiles(sourceDirName);
                foreach (string file in files)
                {
                    if (File.Exists(destDirName + System.IO.Path.GetFileName(file)))
                        continue;
                    File.Copy(file, destDirName + System.IO.Path.GetFileName(file), true);
                    File.SetAttributes(destDirName + System.IO.Path.GetFileName(file), FileAttributes.Normal);
                    // total++;
                }

                string[] dirs = Directory.GetDirectories(sourceDirName);
                foreach (string dir in dirs)
                {
                    CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("拷贝文件失败" + ex.Message.ToString());
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string path = System.Environment.CurrentDirectory + "\\Redis\\";
            string path2 = @"C:\Program Files\Redis";
            //bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
            //System.IO.File.Copy(path, path2, isrewrite);
            CopyDirectory(path, path2);

            Operationbat("TestRedis.bat");
        }
    }
}
