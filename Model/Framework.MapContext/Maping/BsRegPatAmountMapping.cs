

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 挂号费用 - 实体类
	/// </summary>
	public partial class BsRegPatAmountMapping: ClassMap<BsRegPatAmount>
	{   
		/// <summary>
		/// 挂号费用 - 实体类
		/// </summary>
		public BsRegPatAmountMapping()
		{
			this.TableName("BSREGPATAMOUNT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RegTypeID).ColumnName("REGTYPEID");
			  
			this.Column(p =>p.PatTypeID).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.RegFee).ColumnName("REGFEE");
			  
			this.Column(p =>p.DiagnoFee).ColumnName("DIAGNOFEE");
			  
			this.Column(p =>p.OtherFee1).ColumnName("OTHERFEE1");
			  
			this.Column(p =>p.OtherFee2).ColumnName("OTHERFEE2");
			  
			this.Column(p =>p.PaySel).ColumnName("PAYSEL");
			  
			this.Column(p =>p.TallyFee).ColumnName("TALLYFEE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.DiagFeeItemId).ColumnName("DIAGFEEITEMID");
			  
			this.Column(p =>p.ZyFee).ColumnName("ZYFEE");
			  
			this.Column(p =>p.Upcode).ColumnName("UPCODE");
			  
			this.Column(p =>p.YbCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.ModiOperID).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

