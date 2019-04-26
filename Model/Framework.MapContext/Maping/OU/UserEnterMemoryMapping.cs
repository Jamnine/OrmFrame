using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 用户输入记忆
    /// </summary>
    public partial class UserEnterMemoryMapping : ClassMap<UserEnterMemory>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public UserEnterMemoryMapping()  
        {
            this.TableName("USERENTERMEMORY").Schema("orm");
            this.Column(p => p.OwnerID).ColumnName("OwnerID");
            this.Column(p => p.Content).ColumnName("Content");
            this.Column(p => p.ModifyTime).ColumnName("ModifyTime");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");
            this.Column(p => p.Source).ColumnName("Source"); 
             
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

