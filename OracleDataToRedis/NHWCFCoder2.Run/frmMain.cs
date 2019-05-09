using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OracleDataToRedis.Domain;
using OracleDataToRedis.Services;
using OracleDataToRedis.Utils;
using OracleDataToRedis.Coders;

namespace OracleDataToRedis.Run
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseParams.SolutionPath = "c:\\xijian";
            BaseParams.SolutionName = "pro";
            BaseParams.CompanyName = "com";
            BaseParams.TablePrefixSpilt = "_";
            BaseParams.IsGenerateParentProperty = true;
            DataBaseHelper.CurrentDbType = DataBaseType.Oracle9;
            DataBaseHelper.ConnectionString = "Data Source=ora92;User ID=ora92;Password=ora92;";
            //DataBaseHelper.CurrentDbType = DataBaseType.SqlServer2008;
            //DataBaseHelper.ConnectionString = "Data Source=(local);Initial Catalog=shengfengcaigou;User Id=sa;Password=0925;";
            IList<DbTable> tables = DbTableService.Instance.GetAllOfTables();
            Coders.Utility.ProjectCoder.Write(tables);
            Coders.Persistence.EntityDaoCoder.Write();
            Coders.Persistence.EntityDaoTransationCoder.Write();
            Coders.Persistence.SessionFactoryCoder.Write();
            Coders.Services.BaseServiceCoder.Write();
            foreach (DbTable dt in tables)
            {
                DbColumnService.Instance.SetColumns(dt);
                DbIndexService.Instance.SetIndexes(dt);
                DbRelationService.Instance.SetParentRelations(dt, tables);
                foreach (DbIndex idx in dt.Indexes)
                {
                    DbColumnService.Instance.SetIndexColumns(idx);
                }
            }
            foreach (DbTable dt in tables)
            {
                foreach (DbRelation rl in dt.ParentRelations)
                {
                    DbColumnService.Instance.SetParentRelationColumns(rl);
                }
                foreach (DbRelation rl in dt.ChildRelations)
                {
                    DbColumnService.Instance.SetChildRelationColumns(rl);
                }
                DbRelationService.Instance.SetRelationIncrementalValue(dt);
            }

            // 为解决方案中的项目生成GUID项目号
            BaseParams.CreateProjectNo();
            // 开始创建解决方案代码
            Coders.SolutionCoder.Write(tables);
            Coders.Controls.ProjectCoder.Write(tables);
            Coders.Domain.ProjectCoder.Write(tables);
            //Coders.External_bin.ProjectCoder.Write(tables);
            Coders.Persistence.ProjectCoder.Write(tables);
            Coders.Services.ProjectCoder.Write(tables);
            Coders.UserControls.ProjectCoder.Write(tables);
            Coders.Utility.ProjectCoder.Write(tables);
            Coders.WcfClient.ProjectCoder.Write(tables);
            Coders.WcfModels.ProjectCoder.Write(tables);
            Coders.WcfServices.ProjectCoder.Write(tables);
            Coders.WinFroms.ProjectCoder.Write(tables);
            Coders.Run.ProjectCoder.Write(tables);

            foreach (DbTable dt in tables)
            {
                Coders.Domain.DomainCoder.Write(dt);
                Coders.Domain.NbmXmlCoder.Write(dt);
                Coders.Services.ServiceCoder.Write(dt);
                //Coders.WcfModels.IWcfServiceCoder.Write(dt);
                //Coders.WcfModels.WcfServiceCoder.Write(dt);
                Coders.UserControls.UserControlCreater.Write(dt);
                Coders.WinFroms.EditDialogsCoder.Write(dt);
                Coders.WinFroms.ManagerFormsCoder.Write(dt);
            }
            this.dataGridView1.DataSource = tables;
        }
    }
}
