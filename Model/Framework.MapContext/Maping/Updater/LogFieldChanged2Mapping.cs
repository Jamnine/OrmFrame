using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// LogFieldChanged.  Mapping  
    /// </summary>  
    public partial class LogFieldChanged2Mapping : ClassMap<LogFieldChanged2>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public LogFieldChanged2Mapping()
        {
            this.TableName("LOGFIELDCHANGED2").Schema("orm");
            this.Column(p => p.OperDate).ColumnName("OPERDATE");
            this.Column(p => p.OperId).ColumnName("OPERID");
            this.Column(p => p.OperName).ColumnName("OPERNAME");
            this.Column(p => p.OperType).ColumnName("OPERTYPE");
            this.Column(p => p.TableNum).ColumnName("TABLENUM");
            this.Column(p => p.TableDesc).ColumnName("TABLEDESC");
            this.Column(p => p.OperContent).ColumnName("OPERCONTENT");
            this.Column(p => p.OperTableName).ColumnName("OPERTABLENAME");
            this.Column(p => p.OperTableID).ColumnName("OperTableID");
            this.Column(p => p.OldValue).ColumnName("OldValue");
            this.Column(p => p.NewValue).ColumnName("NewValue");
            this.Column(p => p.ColumnName).ColumnName("ColumnName");
            this.Column(p => p.OperIP).ColumnName("OperIP");
            this.Column(p => p.MachineName).ColumnName("MachineName");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


