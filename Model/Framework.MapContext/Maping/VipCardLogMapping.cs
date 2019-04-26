

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipCardLogMapping: ClassMap<VipCardLog>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public VipCardLogMapping()
		{
			this.TableName("VIPCARDLOG").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.VipCardId).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.OldCardNo).ColumnName("OLDCARDNO");
			  
			this.Column(p =>p.NewCardNo).ColumnName("NEWCARDNO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

