

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体温单数据 - 实体类
	/// </summary>
	public partial class InBodyHeatMapping: ClassMap<InBodyHeat>
	{   
		/// <summary>
		/// 体温单数据 - 实体类
		/// </summary>
		public InBodyHeatMapping()
		{
			this.TableName("INBODYHEAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
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
			  
			this.Column(p =>p.FluidM).ColumnName("FLUIDM");
			  
			this.Column(p =>p.TotalIn).ColumnName("TOTALIN");
			  
			this.Column(p =>p.UrineM).ColumnName("URINEM");
			  
			this.Column(p =>p.OtherM).ColumnName("OTHERM");
			  
			this.Column(p =>p.TotalOut).ColumnName("TOTALOUT");
			  
			this.Column(p =>p.MemoUp).ColumnName("MEMOUP");
			  
			this.Column(p =>p.MemoDn).ColumnName("MEMODN");
			  
			this.Column(p =>p.SpinTest).ColumnName("SPINTEST");
			  
			this.Column(p =>p.LowerTemp).ColumnName("LOWERTEMP");
			  
			this.Column(p =>p.IsRecheck).ColumnName("ISRECHECK");
			  
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
			  
			this.Column(p =>p.OperationTime).ColumnName("OPERATIONTIME");
			  
			this.Column(p =>p.IsLeave).ColumnName("ISLEAVE");
			  
			this.Column(p =>p.MemoUp1).ColumnName("MEMOUP1");
			  
			this.Column(p =>p.MemoDn1).ColumnName("MEMODN1");
			  
			this.Column(p =>p.RecordTime).ColumnName("RECORDTIME");
			  
			this.Column(p =>p.TimeQuantum).ColumnName("TIMEQUANTUM");
			  
			this.Column(p =>p.Drainage).ColumnName("DRAINAGE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

