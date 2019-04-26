

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 历史住院领药申请 - 实体类
	/// </summary>
	public partial class HistInDrugReqdtlMapping: ClassMap<HistInDrugReqdtl>
	{   
		/// <summary>
		/// 历史住院领药申请 - 实体类
		/// </summary>
		public HistInDrugReqdtlMapping()
		{
			this.TableName("HISTINDRUGREQDTL").Schema("orm");
			  
			this.Column(p =>p.InSertTime).ColumnName("INSERTTIME");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RequestId).ColumnName("REQUESTID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.ForDate).ColumnName("FORDATE");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitReq).ColumnName("UNITREQ");
			  
			this.Column(p =>p.UnitTake).ColumnName("UNITTAKE");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.IsIssued).ColumnName("ISISSUED");
			  
			this.Column(p =>p.IsConfirm).ColumnName("ISCONFIRM");
			  
			this.Column(p =>p.ConfirmOperId).ColumnName("CONFIRMOPERID");
			  
			this.Column(p =>p.ConfirmOperTime).ColumnName("CONFIRMOPERTIME");
			  
			this.Column(p =>p.DetailId).ColumnName("DETAILID");
			  
			this.Column(p =>p.ExecuteId).ColumnName("EXECUTEID");
			  
			this.Column(p =>p.RegDate).ColumnName("REGDATE");
			  
			this.Column(p =>p.LsSecMarkType).ColumnName("LSSECMARKTYPE");
			  
			this.Column(p =>p.BedName).ColumnName("BEDNAME");
			  
			this.Column(p =>p.Refusal).ColumnName("REFUSAL");
			  
			this.Column(p =>p.IsArrearage).ColumnName("ISARREARAGE");
			  
			this.Column(p =>p.DoctorID).ColumnName("DOCTORID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.LsArrearage).ColumnName("LSARREARAGE");
			  
			this.Column(p =>p.DoctorName).ColumnName("DOCTORNAME");
			  
			this.Column(p =>p.IsOutDrug).ColumnName("ISOUTDRUG");
			  
			this.Column(p =>p.UsageMemo).ColumnName("USAGEMEMO");
			  
			this.Column(p =>p.UseTime).ColumnName("USETIME");
			  
			this.Column(p =>p.UseTimeEnd).ColumnName("USETIMEEND");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

