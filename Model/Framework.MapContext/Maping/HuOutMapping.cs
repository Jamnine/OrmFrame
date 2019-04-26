

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库出库单(对应药房领药) - 实体类
	/// </summary>
	public partial class HuOutMapping: ClassMap<HuOut>
	{   
		/// <summary>
		/// 仓库药库出库单(对应药房领药) - 实体类
		/// </summary>
		public HuOutMapping()
		{
			this.TableName("HUOUT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OutMemo).ColumnName("OUTMEMO");
			  
			this.Column(p =>p.YFSign).ColumnName("YFSIGN");
			  
			this.Column(p =>p.YFOperId).ColumnName("YFOPERID");
			  
			this.Column(p =>p.YFOperTime).ColumnName("YFOPERTIME");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.ApperId).ColumnName("APPERID");
			  
			this.Column(p =>p.OutWayId).ColumnName("OUTWAYID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.DepotId).ColumnName("DepotId"); 

            this.Column(p => p.BillNo2).ColumnName("BillNo2");

            this.Column(p => p.HospitalId).ColumnName("HOSPITALID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

