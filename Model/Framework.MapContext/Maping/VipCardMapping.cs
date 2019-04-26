

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 会员卡表 - 实体类
	/// </summary>
	public partial class VipCardMapping: ClassMap<VipCard>
	{   
		/// <summary>
		/// 会员卡表 - 实体类
		/// </summary>
		public VipCardMapping()
		{
			this.TableName("VIPCARD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.CardNo).ColumnName("CARDNO");
			  
			this.Column(p =>p.VipLevelId).ColumnName("VIPLEVELID");
			  
			this.Column(p =>p.Discount).ColumnName("DISCOUNT");
			  
			this.Column(p =>p.Password).ColumnName("PASSWORD");
			  
			this.Column(p =>p.CreateTime).ColumnName("CREATETIME");
			  
			this.Column(p =>p.InvalidDate).ColumnName("INVALIDDATE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.CardStatus).ColumnName("CARDSTATUS");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IntroducerId).ColumnName("INTRODUCERID");
			  
			this.Column(p =>p.IntroducerOperId).ColumnName("INTRODUCEROPERID");
			  
			this.Column(p =>p.ModiTime).ColumnName("MODITIME");
			  
			this.Column(p =>p.ModiOperId).ColumnName("MODIOPERID");
			  
			this.Column(p =>p.SalesDate).ColumnName("SALESDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.IntroducerReward).ColumnName("INTRODUCERREWARD");
			  
			this.Column(p =>p.FirstintRoducerId).ColumnName("FIRSTINTRODUCERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

