using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OracleDataToRedis.Dao;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Coders;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Services;
using OracleDataToRedis.DataAccess;
using Oracle.DataAccess.Client;
using System.Web.Script.Serialization;
using System.Reflection;
using Newtonsoft.Json;
using OracleDataToRedis.StackExchange;
using System.Collections;
using Microsoft.Web.Administration;

namespace OracleDataToRedis
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private IList<DbTable> DatabaseTableList = null;

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string companyname = System.Configuration.ConfigurationManager.AppSettings["companyname"].ToString().Trim();
            string solutionname = System.Configuration.ConfigurationManager.AppSettings["solutionname"].ToString().Trim();
            string author = System.Configuration.ConfigurationManager.AppSettings["author"].ToString().Trim();


            Dictionary<string, string> medicalAllianceProjectDic = new Dictionary<string, string>();
            medicalAllianceProjectDic.Add("请选择要导入的数据库", "");
            Type enumType = typeof(EnumClass.GPProjectsEnum);
            FieldInfo[] fields = enumType.GetFields();
            for (int i = 1; i < fields.Length; i++)
            {
                string dataSource = System.Configuration.ConfigurationManager.AppSettings["Data Source"].ToString().Trim();
                string passWord = System.Configuration.ConfigurationManager.AppSettings["Password"].ToString().Trim();
                medicalAllianceProjectDic.Add(fields[i].Name, string.Format("Data Source={0};User ID={1};Password={2};", dataSource, fields[i].Name, passWord));
            }
            cbxProjects.DisplayMember = "Key";
            cbxProjects.ValueMember = "Value";
            cbxProjects.DataSource = new BindingSource(medicalAllianceProjectDic, null);
            cbxProjects.Visible = true;
            //this.txtCompanyName.Text = (companyname == "") ? this.txtCompanyName.Text : companyname;
            //this.txtSolutionName.Text = (solutionname == "") ? this.txtSolutionName.Text : solutionname;
            //this.txtAuthor.Text = (author == "") ? this.txtAuthor.Text : author;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseHelper.ConnectionString = this.txtConnectString.Text.Trim();
                BaseParams.IsGenerateParentProperty = true;
                BaseParams.TablePrefix = "T_";
                //BaseParams.TablePrefixSpilt = "_";
                this.DatabaseTableList = new List<DbTable>();
                foreach (DbTable dbTable in DbTableService.Instance.GetAllOfTables())
                {
                    if (dbTable.Name.ToUpper().Contains("BS") || dbTable.Name.ToUpper().Contains("GBL"))
                        this.DatabaseTableList.Add(dbTable);
                }
                this.dgvTable.AutoGenerateColumns = false;
                this.dgvTable.DataSource = this.DatabaseTableList;
                this.panel1.Enabled = true;
                this.panel3.Enabled = true;
                this.btnConnect.Enabled = false;
                this.btnImortAllProjectsData.Enabled = false;
                this.btnAllCheck_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (this.txtConnectString.Text == "") return;
            this.btnReset.Enabled = false;
            //BaseParams.IsGenerateParentProperty = true;
            //BaseParams.WcfServicePort = new Random().Next(8000, 9999);
            int selectedTableCount = 0;
            foreach (DataGridViewRow dv in this.dgvTable.Rows)
            {
                if (((bool)((DataGridViewCheckBoxCell)dv.Cells[0]).Value) == true)
                {
                    selectedTableCount++;
                }
            }
            if (selectedTableCount == 0)
            {
                MessageBox.Show("请选择需要生成的表格！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.panel1.Enabled = false;
            this.panel2.Enabled = false;
            this.panel3.Enabled = false;

            //BaseParams.Author = this.txtAuthor.Text.Trim();
            //BaseParams.CompanyName = this.txtCompanyName.Text.Trim();
            //BaseParams.SolutionName = this.txtSolutionName.Text.Trim();
            //BaseParams.SolutionPath = this.txtSolutionPath.Text.Trim();
            //string filepath = Path.Combine(BaseParams.SolutionPath, BaseParams.SolutionNameSpace + ".sln");
            //if ((File.Exists(filepath) == false)
            //    || (File.Exists(filepath) == true && DialogResult.Yes == MessageBox.Show("相同名称的项目已经存在于此目录，您是否需要替换掉已经存在的项目？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
            //{
            //    this.backgroundWorker1.RunWorkerAsync();
            //}
            //else
            //{
            //    this.panel1.Enabled = true;
            //    this.panel2.Enabled = true;
            //    this.panel3.Enabled = true;
            //}

            this.backgroundWorker1.RunWorkerAsync();
        }

        private int _dataBaseCount = 0;//要导入的数据库个数
        private int _completedImportCount = 0;//记录已导入完成的数据库数量
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (isImportAllProjectsData)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                Dictionary<string, string> medicalAllianceProjectDic = new Dictionary<string, string>();
                medicalAllianceProjectDic.Add("请选择要导入的数据库", "");
                Type enumType = typeof(EnumClass.GPProjectsEnum);
                FieldInfo[] fields = enumType.GetFields();
                _dataBaseCount = fields.Length - 1; ;
                for (int i = 1; i < fields.Length; i++)
                {
                    string dataSource = System.Configuration.ConfigurationManager.AppSettings["Data Source"].ToString().Trim();
                    string passWord = System.Configuration.ConfigurationManager.AppSettings["Password"].ToString().Trim();
                    txtConnectString.Text = string.Format("Data Source={0};User ID={1};Password={2};", dataSource, fields[i].Name, passWord);
                    if (txtConnectString.Text != "")
                    {
                        SqlHelper.connectionString = txtConnectString.Text;
                        SqlHelper.conn = new OracleConnection(SqlHelper.connectionString);
                    }
                    SolutionCreate();
                    _completedImportCount += 1;
                    this.backgroundWorker1.ReportProgress((int)(_completedImportCount * 100 / _dataBaseCount));
                }
                SetControlStatus(true);
            }
            else
            {
                SolutionCreate();
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                MessageBox.Show("导入成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(e.Error.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.panel1.Enabled = true;
            this.panel2.Enabled = true;
            this.panel3.Enabled = true;
            this.progressBar1.Value = 0;
            this.btnReset.Enabled = true;
            this.btnCreate.Enabled = true;
            //ConfigHelper.ModifyConfig("companyName", this.txtCompanyName.Text.Trim());
            //ConfigHelper.ModifyConfig("solutionName", this.txtSolutionName.Text.Trim());
            //ConfigHelper.ModifyConfig("author", this.txtAuthor.Text.Trim());
        }

        private void btnAllCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dv in this.dgvTable.Rows)
            {
                ((DataGridViewCheckBoxCell)dv.Cells[0]).Value = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dv in this.dgvTable.Rows)
            {
                ((DataGridViewCheckBoxCell)dv.Cells[0]).Value = dv.Selected;
            }
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dv in this.dgvTable.Rows)
            {
                ((DataGridViewCheckBoxCell)dv.Cells[0]).Value = false;
            }
        }

        /// <summary>
        /// 关闭IIS网站
        /// </summary>
        private Site CloseProjectSite(out string siteName)
        {
            int userIdIndex = txtConnectString.Text.IndexOf("User ID=");
            int passWordIndex = txtConnectString.Text.IndexOf(";Password=");
            siteName = txtConnectString.Text.Substring(userIdIndex + 8, passWordIndex - userIdIndex - 8);//数据库的实例名就是网站的名称
            ServerManager serverMgr = new ServerManager();
            SiteCollection siteCollection = serverMgr.Sites;//获取IIS里面的所有网站
            Site returnSite = null;
            foreach (Site site in siteCollection)
            {
                Console.WriteLine(site.Name);
                if (site.Name == siteName)
                {
                    site.ServerAutoStart = false;//必须加这一句，否则Stop无效
                    site.Stop();
                    returnSite = site;
                    break;
                }
            }
            return returnSite;
        }

        //private void SolutionCreate(bool isImportAllProjectsData = false)
        private void SolutionCreate()
        {
            //System.Diagnostics.Process.Start("C:\\Program Files\\Redis\\redis-server.exe");//此处为Redis的存储路径
            //var redisClient = OracleDataToRedis.Redis.RedisManager.GetClient();

            string siteName = "";
            //导入前先关闭IIS网站
            Site site = CloseProjectSite(out siteName);

            Assembly assembly = Assembly.Load(@"XYHis.Model");

            Type[] classTableTypes = assembly.GetTypes();

            Control.CheckForIllegalCrossThreadCalls = false;

            RedisHelper.DefaultKey = siteName;
            RedisHelper redisHelper = new RedisHelper();

            IList<DbTable> selectedTableList = new List<DbTable>();
            IList<String> selectedTableName = new List<String>();
            int selectedTableCount = 0;
            if (isImportAllProjectsData)
                btnConnect_Click(null, null);//触发数据库连接事件，目的是为了给DatabaseTableList赋值
            foreach (DbTable dt in this.DatabaseTableList)
            {
                if (dt.IsCreate == true)
                {
                    selectedTableList.Add(dt);
                    selectedTableName.Add(dt.Name);
                    selectedTableCount++;
                }
            }

            foreach (DbTable dt in selectedTableList)
            {
                redisHelper.KeyDelete(dt.Name.ToUpper());//导入前先删除已有的数据
            }

            SqlHelper.connectionString = txtConnectString.Text;
            int tableCount = 0;//记录当前数据库已导入的表数量
            foreach (DbTable dt in selectedTableList)
            {
                //redisHelper.KeyDelete(dt.Name.ToUpper());//导入前先删除已有的数据

                lblNote.Text = string.Format("当前导入的项目数据:{0},当前现在导入的表:{1}", siteName, dt.Name);

                string sql = string.Format("select * from {0}", dt.Name);
                DataTable dataTable = SqlHelper.ExecuteDataTable(sql, CommandType.Text, null);

                Type currentClassType = null;
                FieldInfo[] fieldInfos = null;
                foreach (Type type in classTableTypes)
                {
                    if (type.Name.ToUpper() == dt.Name)
                    {
                        currentClassType = type;
                        fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        break;
                    }
                }
                ImportDataTableToRedis(redisHelper, ref tableCount, dt, dataTable, fieldInfos);
            }
            //导入完成再重启网站
            if (site != null)
            {
                site.ServerAutoStart = true;
                site.Start();
            }
        }

        /// <summary>
        /// 将查询出来的datatable数据导入到redis
        /// </summary>
        private void ImportDataTableToRedis(RedisHelper redisHelper, ref int tableCount, DbTable dt, DataTable dataTable, FieldInfo[] fieldInfos)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                Dictionary<string, object> recordDic = new Dictionary<string, object>();
                foreach (DataColumn dc in dataTable.Columns)
                {
                    if (dr[dc.ColumnName].ToString() == "") continue;//空值不导入redis
                    if (dc.DataType == System.Type.GetType("System.Byte[]")) continue;//图片不导入redis
                    string columnValue = dr[dc.ColumnName].ToString();
                    if (dc.DataType == System.Type.GetType("System.Int16") || dc.DataType == System.Type.GetType("System.Decimal"))
                    {
                        if (fieldInfos != null)
                        {
                            foreach (FieldInfo finfo in fieldInfos)
                            {
                                if (finfo.Name.ToUpper().StartsWith("_" + dc.ColumnName) && finfo.FieldType == System.Type.GetType("System.Boolean"))
                                {
                                    columnValue = dr[dc.ColumnName].ToString() == "1" ? "true" : "false";
                                    break;
                                }
                            }
                        }
                    }
                    recordDic.Add(dc.ColumnName, columnValue);
                }
                string rowsJson = Newtonsoft.Json.JsonConvert.SerializeObject(recordDic);
                //RedisHash.SetEntryInHash(dt.Name, dr[0].ToString(), rowsJson);
                redisHelper.HashSet(dt.Name, dr[0].ToString(), rowsJson);
            }
            tableCount++;
            if (!isImportAllProjectsData)
                this.backgroundWorker1.ReportProgress((int)(tableCount * 100 / this.DatabaseTableList.Count));
        }

        private void cbxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtConnectString.Text = cbxProjects.SelectedValue.ToString();
            if (txtConnectString.Text != "")
            {
                SqlHelper.connectionString = txtConnectString.Text;
                SqlHelper.conn = new OracleConnection(SqlHelper.connectionString);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbxProjects.SelectedIndex = 0;
            dgvTable.DataSource = null;
            btnCreate.Enabled = true;
            btnConnect.Enabled = true;
            lblNote.Text = "导入提示信息";
        }

        public bool isImportAllProjectsData = false;

        /// <summary>
        /// 导入所有枚举项目的数据
        /// </summary>
        private void btnImortAllProjectsData_Click(object sender, EventArgs e)
        {
            SetControlStatus(false);
            isImportAllProjectsData = true;
            this.backgroundWorker1.RunWorkerAsync();
        }

        private void SetControlStatus(bool isEnable)
        {
            btnImortAllProjectsData.Enabled = isEnable;
            cbxProjects.Enabled = isEnable;
            txtConnectString.Enabled = isEnable;
            dgvTable.Enabled = isEnable;
            btnConnect.Enabled = isEnable;
            btnCreate.Enabled = isEnable;
            btnAllCheck.Enabled = isEnable;
            btnCheck.Enabled = isEnable;
            btnCancelCheck.Enabled = isEnable;
        }


        //private void SolutionCreate()
        //{
        //    IList<DbTable> selectedTableList = new List<DbTable>();
        //    IList<String> selectedTableName = new List<String>();
        //    int selectedTableCount = 0;
        //    foreach (DbTable dt in this.DatabaseTableList)
        //    {
        //        if (dt.IsCreate == true)
        //        {
        //            selectedTableList.Add(dt);
        //            selectedTableName.Add(dt.Name);
        //            selectedTableCount++;
        //        }
        //    }

        //    int tableCount = 0;
        //    // 准备好各种数据表中的对应关系
        //    foreach (DbTable dt in DatabaseTableList)
        //    {
        //        dt.ChildRelations.Clear();
        //    }
        //    foreach (DbTable dt in this.DatabaseTableList)
        //    {
        //        DbColumnService.Instance.SetColumns(dt);
        //        DbIndexService.Instance.SetIndexes(dt);
        //        DbIndexService.Instance.GetPrimaryKey(dt);
        //        DbRelationService.Instance.SetParentRelations(dt, DatabaseTableList);
        //        foreach (DbIndex idx in dt.Indexes)
        //        {
        //            DbColumnService.Instance.SetIndexColumns(idx);
        //        }
        //        tableCount++;
        //        this.backgroundWorker1.ReportProgress((int)(tableCount * 100 / this.DatabaseTableList.Count));
        //    }
        //    tableCount = 0;
        //    foreach (DbTable dt in this.DatabaseTableList)
        //    {
        //        foreach (DbRelation rl in dt.ParentRelations)
        //        {
        //            DbColumnService.Instance.SetParentRelationColumns(rl);
        //        }
        //        foreach (DbRelation rl in dt.ChildRelations)
        //        {
        //            DbColumnService.Instance.SetChildRelationColumns(rl);
        //        }
        //        DbRelationService.Instance.SetRelationIncrementalValue(dt);
        //        tableCount++;
        //        this.backgroundWorker1.ReportProgress((int)(tableCount * 100 / this.DatabaseTableList.Count));
        //    }

        //    // 为解决方案中的项目生成GUID项目号
        //    BaseParams.CreateProjectNo();
        //    // 开始创建解决方案代码
        //    Coders.SolutionCoder.Write(selectedTableList);
        //    Coders.External_bin.ProjectCoder.Write(selectedTableList);
        //    Coders.Controls.ProjectCoder.Write(selectedTableList);
        //    Coders.Domain.ProjectCoder.Write(selectedTableList);
        //    Coders.External_bin.ProjectCoder.Write(selectedTableList);
        //    Coders.Persistence.ProjectCoder.Write(selectedTableList);
        //    Coders.Services.ProjectCoder.Write(selectedTableList);
        //    Coders.UserControls.ProjectCoder.Write(selectedTableList);
        //    Coders.Utility.ProjectCoder.Write(selectedTableList);
        //    Coders.WcfClient.ProjectCoder.Write(selectedTableList);
        //    Coders.WcfModels.ProjectCoder.Write(selectedTableList);
        //    Coders.WcfServices.ProjectCoder.Write(selectedTableList);
        //    Coders.WinFroms.ProjectCoder.Write(selectedTableList);
        //    Coders.Run.ProjectCoder.Write(selectedTableList);
        //    int createdTableCount = 0;
        //    foreach (DbTable dt in selectedTableList)
        //    {
        //        Coders.Domain.DomainCoder.Write(dt);
        //        Coders.Domain.NbmXmlCoder.Write(dt);
        //        Coders.Services.ServiceCoder.Write(dt);
        //        //Coders.WcfModels.IWcfServiceCoder.Write(dt);
        //        //Coders.WcfModels.WcfServiceCoder.Write(dt);
        //        Coders.UserControls.UserControlCreater.Write(dt);
        //        Coders.WinFroms.EditDialogsCoder.Write(dt);
        //        Coders.WinFroms.ManagerFormsCoder.Write(dt);
        //        createdTableCount++;
        //        this.backgroundWorker1.ReportProgress((int)(createdTableCount * 100 / selectedTableList.Count));
        //    }
        //}
    }
}