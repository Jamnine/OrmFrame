

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CKMachineFormularMapping: ClassMap<CKMachineFormular>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CKMachineFormularMapping()
		{
			this.TableName("CKMACHINEFORMULAR").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DictFormularid).ColumnName("DICTFORMULARID");
			  
			this.Column(p =>p.DictTestid).ColumnName("DICTTESTID");
			  
			this.Column(p =>p.Formular).ColumnName("FORMULAR");
			  
			this.Column(p =>p.FormularDesc).ColumnName("FORMULARDESC");
			  
			this.Column(p =>p.FormularType).ColumnName("FORMULARTYPE");
			  
			this.Column(p =>p.AlertType).ColumnName("ALERTTYPE");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.TestName).ColumnName("TESTNAME");
			  
			this.Column(p =>p.FormularTypeName).ColumnName("FORMULARTYPENAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

