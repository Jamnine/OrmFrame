using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///更新版本信息
    /// </summary>  
    public partial class UpVersionMapping : ClassMap<UpVersion>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public UpVersionMapping()
        {
            this.TableName("UPVERSION").Schema("orm");
            this.Column(p => p.VersionId).ColumnName("VersionId");
            this.Column(p => p.VersionNum).ColumnName("VersionNum");
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.UpLoadHostName).ColumnName("UpLoadHostName");
            this.Column(p => p.UpLoadIp).ColumnName("UpLoadIp");
            this.Column(p => p.TestId).ColumnName("TestId");
            this.Column(p => p.IsMust).ColumnName("IsMust");
            this.Column(p => p.LastVersion).ColumnName("LastVersion");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.DbVersionNum).ColumnName("DbVersionNum");
            this.Column(p => p.VersionIisFilePath).ColumnName("VersionIisFilePath");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


