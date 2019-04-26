using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 更新服务日志
    /// </summary>  
    public partial class UpdateServiceLogMapping : ClassMap<UpdateServiceLog>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public UpdateServiceLogMapping()
        {
            this.TableName("UPDATESERVICELOG").Schema("orm");
            this.Column(p => p.CustomId).ColumnName("CUSTOMID");
            this.Column(p => p.UpVersionId).ColumnName("UPVERSIONID");
            this.Column(p => p.UpdateTime).ColumnName("UPDATETIME");
            this.Column(p => p.SqlScriptId).ColumnName("SQLSCRIPTID");
            this.Column(p => p.IsUpdateSuccess).ColumnName("ISUPDATESUCCESS");
            this.Column(p => p.Memo).ColumnName("MEMO");
            this.Column(p => p.UpdateVersionNum).ColumnName("UPDATEVERSIONNUM");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


