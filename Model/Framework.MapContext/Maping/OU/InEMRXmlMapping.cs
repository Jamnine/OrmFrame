using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 电子病历XML
    /// </summary>
    public partial class InEMRXmlMapping : ClassMap<InEMRXml>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public InEMRXmlMapping()  
        {  
            this.TableName("INEMRXML").Schema("orm");
            this.Column(p => p.LocationID).ColumnName("LOCATIONID");  
            this.Column(p => p.HosId).ColumnName("HOSID");
            this.Column(p => p.OperTime).ColumnName("OPERTIME");
            this.Column(p => p.CatalogId).ColumnName("CATALOGID");
            this.Column(p => p.XMLFleld).ColumnName("XMLFIELD");
            this.Column(p => p.XMLValue).ColumnName("XMLVALUE");
            this.Column(p => p.InEmrId).ColumnName("INEMRID"); 
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

