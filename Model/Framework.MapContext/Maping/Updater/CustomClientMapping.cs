using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 客户端信息
    /// </summary>  
    public partial class CustomClientMapping : ClassMap<CustomClient>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public CustomClientMapping()
        {
            this.TableName("CUSTOMCLIENT").Schema("orm");
            this.Column(p => p.CustomId).ColumnName("CustomId");
            this.Column(p => p.LastVersionNum).ColumnName("LastVersionNum");
            this.Column(p => p.DownLoadTime).ColumnName("DownLoadTime");
            this.Column(p => p.DownLoadHostName).ColumnName("DownLoadHostName");
            this.Column(p => p.DownLoadIp).ColumnName("DownLoadIp");
            this.Column(p => p.CustomerVersionNum).ColumnName("CUSTOMERVERSIONNUM");
            this.Column(p => p.UpdatedVersionNum).ColumnName("UPDATEDVERSIONNUM");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


