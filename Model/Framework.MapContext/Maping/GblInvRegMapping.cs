

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 发票设置 - 实体类
	/// </summary>
	public partial class GblInvRegMapping: ClassMap<GblInvReg>
	{   
		/// <summary>
		/// 发票设置 - 实体类
		/// </summary>
		public GblInvRegMapping()
		{
			this.TableName("GBLINVREG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.InvType).ColumnName("INVTYPE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.StartInvoNo).ColumnName("STARTINVONO");
			  
			this.Column(p =>p.EndInvoNo).ColumnName("ENDINVONO");
			  
			this.Column(p =>p.IsEnd).ColumnName("ISEND");
			  
			this.Column(p =>p.EndTime).ColumnName("ENDTIME");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");




            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

