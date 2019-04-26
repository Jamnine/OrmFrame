

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 标本对应用血 - 实体类
	/// </summary>
	public partial class CkLabBoodMapping: ClassMap<CkLabBood>
	{   
		/// <summary>
		/// 标本对应用血 - 实体类
		/// </summary>
		public CkLabBoodMapping()
		{
			this.TableName("CKLABBOOD").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BdBankId).ColumnName("BDBANKID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

