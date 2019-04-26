using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    ///备份恢复 
    /// </summary>
    public partial class GblBackupRestoreMapping : ClassMap<GblBackupRestore>
    {
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public GblBackupRestoreMapping()
        {
            this.TableName("GBLBACKUPRESTORE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperName).ColumnName("OperName");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.DataSize).ColumnName("DATASIZE");
            this.Column(p => p.LsType).ColumnName("LsType");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
