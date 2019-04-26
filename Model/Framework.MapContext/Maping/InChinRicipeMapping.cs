

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院中药处方单 - 实体类
	/// </summary>
	public partial class InChinRicipeMapping: ClassMap<InChinRicipe>
	{   
		/// <summary>
		/// 住院中药处方单 - 实体类
		/// </summary>
		public InChinRicipeMapping()
		{
			this.TableName("INCHINRICIPE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecipeNo).ColumnName("RECIPENO");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.DrugNum).ColumnName("DRUGNUM");
			  
			this.Column(p =>p.DecoctNum).ColumnName("DECOCTNUM");
			  
			this.Column(p =>p.IsConfirm).ColumnName("ISCONFIRM");
			  
			this.Column(p =>p.LsCookSelf).ColumnName("LSCOOKSELF");
			  
			this.Column(p =>p.ConfirmOperID).ColumnName("CONFIRMOPERID");
			  
			this.Column(p =>p.ConfirmOperTime).ColumnName("CONFIRMOPERTIME");
			  
			this.Column(p =>p.IsBack).ColumnName("ISBACK");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.BackTime).ColumnName("BACKTIME");
			  
			this.Column(p =>p.CookMinute).ColumnName("COOKMINUTE");
			  
			this.Column(p =>p.LsFire).ColumnName("LSFIRE");
			  
			this.Column(p =>p.AdviceLocationId).ColumnName("ADVICELOCATIONID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.CookSelfDtlId).ColumnName("COOKSELFDTLID");
			  
			this.Column(p =>p.AuthOper).ColumnName("AUTHOPER");
			  
			this.Column(p =>p.AuthTime).ColumnName("AUTHTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

