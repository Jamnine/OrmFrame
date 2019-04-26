

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class VipBindingMapping: ClassMap<VipBinding>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public VipBindingMapping()
		{
			this.TableName("VIPBINDING").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.VipCardId).ColumnName("VIPCARDID");
			  
			this.Column(p =>p.IsCardHolder).ColumnName("ISCARDHOLDER");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.ModifiedOperId).ColumnName("MODIFIEDOPERID");
			  
			this.Column(p =>p.ModifiedOperTime).ColumnName("MODIFIEDOPERTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

