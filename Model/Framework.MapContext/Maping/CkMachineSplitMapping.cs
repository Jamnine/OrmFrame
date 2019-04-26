

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineSplitMapping: ClassMap<CkMachineSplit>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineSplitMapping()
		{
			this.TableName("CKMACHINESPLIT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DictInstrumentSplitid).ColumnName("DICTINSTRUMENTSPLITID");
			  
			this.Column(p =>p.DictInstrumentid).ColumnName("DICTINSTRUMENTID");
			  
			this.Column(p =>p.TypeCode).ColumnName("TYPECODE");
			  
			this.Column(p =>p.TypeName).ColumnName("TYPENAME");
			  
			this.Column(p =>p.BeginAt).ColumnName("BEGINAT");
			  
			this.Column(p =>p.BeginLetter).ColumnName("BEGINLETTER");
			  
			this.Column(p =>p.EndAt).ColumnName("ENDAT");
			  
			this.Column(p =>p.EndLetter).ColumnName("ENDLETTER");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

