using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    /// BsLinkUp.  Mapping  
    /// </summary>  
    public partial class BsLinkUpMapping: ClassMap<BsLinkUp>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public BsLinkUpMapping()  
        {  
            this.TableName("BSLINKUP").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Title).ColumnName("TITLE");  
            this.Column(p => p.ParentID).ColumnName("PARENTID");  
            this.Column(p => p.FileAddress).ColumnName("FILEADDRESS");  
            this.Column(p => p.LsType).ColumnName("LSTYPE");  
            this.Column(p => p.LsOperType).ColumnName("LSOPERTYPE");  
            this.Column(p => p.Memo).ColumnName("MEMO");  
            this.Column(p => p.OperId).ColumnName("OPERID");  
            this.Column(p => p.OperTime).ColumnName("OPERTIME");  
            this.Column(p => p.IsActive).ColumnName("ISACTIVE");
            this.Column(p => p.IsCommon).ColumnName("ISCOMMON");  
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

