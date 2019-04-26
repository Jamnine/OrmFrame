

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CsLogisticServeDetailMapping: ClassMap<CsLogisticServeDetail>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CsLogisticServeDetailMapping()
		{
			this.TableName("CSLOGISTICSERVEDETAIL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ServeDate).ColumnName("SERVEDATE");
			  
			this.Column(p =>p.Abstract).ColumnName("ABSTRACT");
			  
			this.Column(p =>p.LogisticServeId).ColumnName("LOGISTICSERVEID");
			  
			this.Column(p =>p.BenefitLocId).ColumnName("BENEFITLOCID");
			  
			this.Column(p =>p.ServeLocId).ColumnName("SERVELOCID");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.Equivalent).ColumnName("EQUIVALENT");
			  
			this.Column(p =>p.ServeNo).ColumnName("SERVENO");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAcctMark).ColumnName("ISACCTMARK");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

