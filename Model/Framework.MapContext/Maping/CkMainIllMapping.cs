

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检诊断 - 实体类
	/// </summary>
	public partial class CkMainIllMapping: ClassMap<CkMainIll>
	{   
		/// <summary>
		/// 体检诊断 - 实体类
		/// </summary>
		public CkMainIllMapping()
		{
			this.TableName("CKMAINILL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");
			  
			this.Column(p =>p.IllAdviceMemo).ColumnName("ILLADVICEMEMO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

