

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 病人类别 - 实体类
	/// </summary>
	public partial class BsPatTypeMapping: ClassMap<BsPatType>
	{   
		/// <summary>
		/// 病人类别 - 实体类
		/// </summary>
		public BsPatTypeMapping()
		{
			this.TableName("BSPATTYPE").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.LimitFee).ColumnName("LIMITFEE");
			  
			this.Column(p =>p.LimitIn).ColumnName("LIMITIN");
			  
			this.Column(p =>p.ArrearFei).ColumnName("ARREARFEI");
			  
			this.Column(p =>p.DiscDiag).ColumnName("DISCDIAG");
			  
			this.Column(p =>p.DiscIn).ColumnName("DISCIN");
			  
			this.Column(p =>p.HeadNo).ColumnName("HEADNO");
			  
			this.Column(p =>p.TallyTypeId).ColumnName("TALLYTYPEID");
			  
			this.Column(p =>p.ArrearAmount).ColumnName("ARREARAMOUNT");
			  
			this.Column(p =>p.LsGFPatType).ColumnName("LSGFPATTYPE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.TwoDiscIn1).ColumnName("TWODISCIN1");
			  
			this.Column(p =>p.TwoDiscIn2).ColumnName("TWODISCIN2");
			  
			this.Column(p =>p.UpCode).ColumnName("UPCODE");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.YBCode).ColumnName("YBCODE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

