using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// ToothCheck.  Mapping  
    /// </summary>  
    public partial class ToothCheckMapping: ClassMap<ToothCheck>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public ToothCheckMapping()  
        {  
            this.TableName("TOOTHCHECK").Schema("orm");  
            this.Column(p => p.RecordId).ColumnName("RECORDID");  
            this.Column(p => p.CheckCT).ColumnName("CHECKCT");  
            this.Column(p => p.P1).ColumnName("P1");  
            this.Column(p => p.P2).ColumnName("P2");  
            this.Column(p => p.P3).ColumnName("P3");  
            this.Column(p => p.P4).ColumnName("P4");  
            this.Column(p => p.OrderBy).ColumnName("ORDERBY");  
               
              
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

