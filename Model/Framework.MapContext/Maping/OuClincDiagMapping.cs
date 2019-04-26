

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 门诊病人诊断表 - 实体类
	/// </summary>
	public partial class OuClincDiagMapping: ClassMap<OuClincDiag>
	{   
		/// <summary>
		/// 门诊病人诊断表 - 实体类
		/// </summary>
		public OuClincDiagMapping()
		{
			this.TableName("OUCLINCDIAG").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");
			  
			this.Column(p =>p.LsDiagType).ColumnName("LSDIAGTYPE");
			  
			this.Column(p =>p.SequenceNum).ColumnName("SEQUENCENUM");
			  
			this.Column(p =>p.IcdCodeZy).ColumnName("ICDCODEZY");
			  
			this.Column(p =>p.IllDescZy).ColumnName("ILLDESCZY");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsDocInput).ColumnName("ISDOCINPUT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

