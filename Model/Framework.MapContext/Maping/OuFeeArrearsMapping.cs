

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊病人欠费库 - 实体类
	/// </summary>
	public partial class OuFeeArrearsMapping: ClassMap<OuFeeArrears>
	{   
		/// <summary>
		/// 门诊病人欠费库 - 实体类
		/// </summary>
		public OuFeeArrearsMapping()
		{
			this.TableName("OUFEEARREARS").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.IsPay).ColumnName("ISPAY");
			  
			this.Column(p =>p.PayTime).ColumnName("PAYTIME");
			  
			this.Column(p =>p.OuInvoicePayId).ColumnName("OUINVOICEPAYID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

