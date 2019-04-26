

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 婴儿体温单数据 - 实体类
	/// </summary>
	public partial class InBabyBodyHeatMapping: ClassMap<InBabyBodyHeat>
	{   
		/// <summary>
		/// 婴儿体温单数据 - 实体类
		/// </summary>
		public InBabyBodyHeatMapping()
		{
			this.TableName("INBABYBODYHEAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.operId).ColumnName("OPERID");
			  
			this.Column(p =>p.AnimalHeat).ColumnName("ANIMALHEAT");
			  
			this.Column(p =>p.HeatType).ColumnName("HEATTYPE");
			  
			this.Column(p =>p.Pulse).ColumnName("PULSE");
			  
			this.Column(p =>p.Heart).ColumnName("HEART");
			  
			this.Column(p =>p.Breath).ColumnName("BREATH");
			  
			this.Column(p =>p.Stool).ColumnName("STOOL");
			  
			this.Column(p =>p.Urine).ColumnName("URINE");
			  
			this.Column(p =>p.Weight).ColumnName("WEIGHT");
			  
			this.Column(p =>p.Bldpress0).ColumnName("BLDPRESS0");
			  
			this.Column(p =>p.Bldpress1).ColumnName("BLDPRESS1");
			  
			this.Column(p =>p.Fluidm).ColumnName("FLUIDM");
			  
			this.Column(p =>p.Totalin).ColumnName("TOTALIN");
			  
			this.Column(p =>p.Urinem).ColumnName("URINEM");
			  
			this.Column(p =>p.Otherm).ColumnName("OTHERM");
			  
			this.Column(p =>p.TotalOut).ColumnName("TOTALOUT");
			  
			this.Column(p =>p.MemoUp).ColumnName("MEMOUP");
			  
			this.Column(p =>p.Memodn).ColumnName("MEMODN");
			  
			this.Column(p =>p.SpinTest).ColumnName("SPINTEST");
			  
			this.Column(p =>p.LowerTemp).ColumnName("LOWERTEMP");
			  
			this.Column(p =>p.IsreCheck).ColumnName("ISRECHECK");
			  
			this.Column(p =>p.IsOutSide).ColumnName("ISOUTSIDE");
			  
			this.Column(p =>p.IsMachine).ColumnName("ISMACHINE");
			  
			this.Column(p =>p.Others).ColumnName("OTHERS");
			  
			this.Column(p =>p.IsOps).ColumnName("ISOPS");
			  
			this.Column(p =>p.BirthTime).ColumnName("BIRTHTIME");
			  
			this.Column(p =>p.IsReject).ColumnName("ISREJECT");
			  
			this.Column(p =>p.DeadTime).ColumnName("DEADTIME");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.CwInject).ColumnName("CWINJECT");
			  
			this.Column(p =>p.JmInject).ColumnName("JMINJECT");
			  
			this.Column(p =>p.CwHeight).ColumnName("CWHEIGHT");
			  
			this.Column(p =>p.IsMotherFeed).ColumnName("ISMOTHERFEED");
			  
			this.Column(p =>p.IsHumanFeed).ColumnName("ISHUMANFEED");
			  
			this.Column(p =>p.UbsStool).ColumnName("UBSSTOOL");
			  
			this.Column(p =>p.UmbiliCal).ColumnName("UMBILICAL");
			  
			this.Column(p =>p.TimeQuantum).ColumnName("TIMEQUANTUM");
			  
			this.Column(p =>p.UmbilicalExplain).ColumnName("UMBILICALEXPLAIN");
			  
			this.Column(p =>p.FecesExplain).ColumnName("FECESEXPLAIN");
			  
			this.Column(p =>p.PainDegree).ColumnName("PAINDEGREE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

