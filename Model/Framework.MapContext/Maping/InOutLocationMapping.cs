

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院转科记录表 - 实体类
	/// </summary>
	public partial class InOutLocationMapping: ClassMap<InOutLocation>
	{   
		/// <summary>
		/// 住院转科记录表 - 实体类
		/// </summary>
		public InOutLocationMapping()
		{
			this.TableName("INOUTLOCATION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.BedId).ColumnName("BEDID");
			  
			this.Column(p =>p.OutLocId).ColumnName("OUTLOCID");
			  
			this.Column(p =>p.OutOperTime).ColumnName("OUTOPERTIME");
			  
			this.Column(p =>p.OutOperId).ColumnName("OUTOPERID");
			  
			this.Column(p =>p.isReceived).ColumnName("ISRECEIVED");
			  
			this.Column(p =>p.InLocId).ColumnName("INLOCID");
			  
			this.Column(p =>p.InOperTime).ColumnName("INOPERTIME");
			  
			this.Column(p =>p.InOperId).ColumnName("INOPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

