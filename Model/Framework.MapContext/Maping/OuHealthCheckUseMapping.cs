

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:病人档案?? - 实体类
	/// </summary>
	public partial class OuHealthCheckUseMapping: ClassMap<OuHealthCheckUse>
	{   
		/// <summary>
		/// 行心云:病人档案?? - 实体类
		/// </summary>
		public OuHealthCheckUseMapping()
		{
			this.TableName("OUHEALTHCHECKUSE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.Operid).ColumnName("OPERID");
			  
			this.Column(p =>p.OperLastDate).ColumnName("OPERLASTDATE");
			  
			this.Column(p =>p.HealthEvaluate).ColumnName("HEALTHEVALUATE");
			  
			this.Column(p =>p.Error1).ColumnName("ERROR1");
			  
			this.Column(p =>p.Error2).ColumnName("ERROR2");
			  
			this.Column(p =>p.Error3).ColumnName("ERROR3");
			  
			this.Column(p =>p.IsHealthManage).ColumnName("ISHEALTHMANAGE");
			  
			this.Column(p =>p.IsReview).ColumnName("ISREVIEW");
			  
			this.Column(p =>p.IsReferral).ColumnName("ISREFERRAL");
			  
			this.Column(p =>p.IsQuitSmok).ColumnName("ISQUITSMOK");
			  
			this.Column(p =>p.IsQuitDrink).ColumnName("ISQUITDRINK");
			  
			this.Column(p =>p.IsHealthFood).ColumnName("ISHEALTHFOOD");
			  
			this.Column(p =>p.IsSports).ColumnName("ISSPORTS");
			  
			this.Column(p =>p.IsReduceWeight).ColumnName("ISREDUCEWEIGHT");
			  
			this.Column(p =>p.isVaccine).ColumnName("ISVACCINE");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

