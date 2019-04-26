using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 更新版本sql脚本
    /// </summary>  
    public class UpdateVersionSqlScriptMapping : ClassMap<UpdateVersionSqlScript>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public UpdateVersionSqlScriptMapping()
        {
            this.TableName("UpdateVersionSqlScript").Schema("orm");
            this.Column(p => p.UpVersionId).ColumnName("UpVersionId");
            this.Column(p => p.SQLScript).ColumnName("SQLScript");
            this.Column(p => p.UpdateOrderBy).ColumnName("UpdateOrderBy");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
