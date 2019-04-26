using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  收藏病人
    /// </summary>  
    public partial class CollectPatMapping: ClassMap<CollectPat>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public CollectPatMapping()  
        {  
            this.TableName("COLLECTPAT").Schema("orm");  
            this.Column(p => p.CardNo).ColumnName("CardNo");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.Sex).ColumnName("Sex");  
            this.Column(p => p.Age).ColumnName("AgeString");  
            this.Column(p => p.PatType).ColumnName("PatType");
            this.Column(p => p.DoctorID).ColumnName("DoctorID");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.LastSeeTime).ColumnName("LastSeeTime");  
            this.Column(p => p.Mark).ColumnName("Mark");  
            this.Column(p => p.Operation).ColumnName("Operation");  
            this.Column(p => p.LastUpdateTime).ColumnName("LastUpdateTime");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

