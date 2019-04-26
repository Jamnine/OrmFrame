

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院长嘱 - 实体类
	/// </summary>
	public partial class InAdviceLongMapping: ClassMap<InAdviceLong>
	{   
		/// <summary>
		/// 住院长嘱 - 实体类
		/// </summary>
		public InAdviceLongMapping()
		{
			this.TableName("INADVICELONG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.AdviceTime).ColumnName("ADVICETIME");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.Dosage).ColumnName("DOSAGE");
			  
			this.Column(p =>p.UnitTakeId).ColumnName("UNITTAKEID");
			  
			this.Column(p =>p.FrequencyId).ColumnName("FREQUENCYID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.PriceIn).ColumnName("PRICEIN");
			  
			this.Column(p =>p.Totality).ColumnName("TOTALITY");
			  
			this.Column(p =>p.UnitInId).ColumnName("UNITINID");
			  
			this.Column(p =>p.IsAttach).ColumnName("ISATTACH");
			  
			this.Column(p =>p.IsSelf).ColumnName("ISSELF");
			  
			this.Column(p =>p.LsSpecialUsage).ColumnName("LSSPECIALUSAGE");
			  
			this.Column(p =>p.LsExecLoc).ColumnName("LSEXECLOC");
			  
			this.Column(p =>p.IsSkin).ColumnName("ISSKIN");
			  
			this.Column(p =>p.SkinTime).ColumnName("SKINTIME");
			  
			this.Column(p =>p.SkinTest).ColumnName("SKINTEST");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.IsPrinted).ColumnName("ISPRINTED");
			  
			this.Column(p =>p.IsChk).ColumnName("ISCHK");
			  
			this.Column(p =>p.ChkOperTime).ColumnName("CHKOPERTIME");
			  
			this.Column(p =>p.ChkOperID).ColumnName("CHKOPERID");
			  
			this.Column(p =>p.IsEnd).ColumnName("ISEND");
			  
			this.Column(p =>p.EndOperTime).ColumnName("ENDOPERTIME");
			  
			this.Column(p =>p.EndOperID).ColumnName("ENDOPERID");
			  
			this.Column(p =>p.EndDoctorID).ColumnName("ENDDOCTORID");
			  
			this.Column(p =>p.IsAuth).ColumnName("ISAUTH");
			  
			this.Column(p =>p.AuthOperTime).ColumnName("AUTHOPERTIME");
			  
			this.Column(p =>p.AuthOperID).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IsOtherFee).ColumnName("ISOTHERFEE");
			  
			this.Column(p =>p.FirstDay).ColumnName("FIRSTDAY");
			  
			this.Column(p =>p.LastDay).ColumnName("LASTDAY");
			  
			this.Column(p =>p.ExecLocId).ColumnName("EXECLOCID");
			  
			this.Column(p =>p.ExecDoctorId).ColumnName("EXECDOCTORID");
			  
			this.Column(p =>p.IsYbxj).ColumnName("ISYBXJ");
			  
			this.Column(p =>p.YbType).ColumnName("YBTYPE");
			  
			this.Column(p =>p.Colours).ColumnName("COLOURS");
			  
			this.Column(p =>p.DiscountAoumt).ColumnName("DISCOUNTAOUMT");
			  
			this.Column(p =>p.ChildPrice).ColumnName("CHILDPRICE");
			  
			this.Column(p =>p.DiscountPrice).ColumnName("DISCOUNTPRICE");
			  
			this.Column(p =>p.IsDelete).ColumnName("ISDELETE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

