

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检小结 - 实体类
	/// </summary>
	public partial class CkResultGroupMapping: ClassMap<CkResultGroup>
	{   
		/// <summary>
		/// 体检小结 - 实体类
		/// </summary>
		public CkResultGroupMapping()
		{
			this.TableName("CKRESULTGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestGroupId).ColumnName("TESTGROUPID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.CheckDesc).ColumnName("CHECKDESC");
			  
			this.Column(p =>p.Summary).ColumnName("SUMMARY");
			  
			this.Column(p =>p.DoctorAdvice).ColumnName("DOCTORADVICE");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.ResultTime).ColumnName("RESULTTIME");
			  
			this.Column(p =>p.ResultOperId).ColumnName("RESULTOPERID");
			  
			this.Column(p =>p.AuthTime).ColumnName("AUTHTIME");
			  
			this.Column(p =>p.AuthOperId).ColumnName("AUTHOPERID");
			  
			this.Column(p =>p.TestGroupName).ColumnName("TESTGROUPNAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

