using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 体检项目结果模板 
    /// </summary>  
    public partial class TjItemResultTmpMapping: ClassMap<TjItemResultTmp>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjItemResultTmpMapping()  
        {  
            this.TableName("TJITEMRESULTTMP").Schema("orm");  
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");  
            this.Column(p => p.ReferResult).ColumnName("ReferResult");  
            this.Column(p => p.Diagnosis).ColumnName("Diagnosis");  
            this.Column(p => p.Suggestion).ColumnName("Suggestion");  
            this.Column(p => p.IsAbNormal).ColumnName("IsAbNormal");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

