

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 药房住院发药 - 实体类
	/// </summary>
	public partial class RmZyOutMapping: ClassMap<RmZyOut>
	{   
		/// <summary>
		/// 药房住院发药 - 实体类
		/// </summary>
		public RmZyOutMapping()
		{
			this.TableName("RMZYOUT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.RoomId).ColumnName("ROOMID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.SignTime).ColumnName("SIGNTIME");
			  
			this.Column(p =>p.SignOperId).ColumnName("SIGNOPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

