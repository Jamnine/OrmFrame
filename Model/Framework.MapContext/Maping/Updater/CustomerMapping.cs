using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///客户端信息
    /// </summary> 
    public partial class CustomerMapping : ClassMap<Customer>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public CustomerMapping()
        {
            this.TableName("CUSTOMER").Schema("orm");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.Address).ColumnName("Address");
            this.Column(p => p.Mobile).ColumnName("Mobile");
            this.Column(p => p.VersionId).ColumnName("VersionId");
            this.Column(p => p.IsUpdate).ColumnName("IsUpdate");
            this.Column(p => p.CustomerGuid).ColumnName("CUSTOMERGUID");
            this.Column(p => p.IisUrl).ColumnName("IISURL");
            this.Column(p => p.DbVersionNum).ColumnName("DbVersionNum");
            this.Column(p => p.IisVersionNum).ColumnName("IisVersionNum");            
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.IsStartUsing).ColumnName("IsStartUsing");
            this.Column(p => p.StartUsingDate).ColumnName("StartUsingDate");
            this.Column(p => p.IisFilePath).ColumnName("IisFilePath");
            this.Column(p => p.IisServerLwIp).ColumnName("IisServerLwIp");
            this.Column(p => p.DbUpdateTime).ColumnName("DbUpdateTime");
            this.Column(p => p.IisUpdateTime).ColumnName("IisUpdateTime");            
	
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


