

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院病人诊断表 - 实体类
	/// </summary>
	public partial class InHosMzIllMapping: ClassMap<InHosMzIll>
	{   
		/// <summary>
		/// 住院病人诊断表 - 实体类
		/// </summary>
		public InHosMzIllMapping()
		{
			this.TableName("INHOSMZILL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.ListNum).ColumnName("LISTNUM");
			  
			this.Column(p =>p.IcdId).ColumnName("ICDID");
			  
			this.Column(p =>p.IllDesc).ColumnName("ILLDESC");
			  
			this.Column(p =>p.LsInOut).ColumnName("LSINOUT");
			  
			this.Column(p =>p.LsWestChin).ColumnName("LSWESTCHIN");
			  
			this.Column(p =>p.IsInfect).ColumnName("ISINFECT");
			  
			this.Column(p =>p.IsCoincidence).ColumnName("ISCOINCIDENCE");
			  
			this.Column(p =>p.CheckOperId).ColumnName("CHECKOPERID");
			  
			this.Column(p =>p.CheckTime).ColumnName("CHECKTIME");
			  
			this.Column(p =>p.BPGroupId).ColumnName("BPGROUPID");
			  
			this.Column(p =>p.IsDg).ColumnName("ISDG");
			  
			this.Column(p =>p.IsBP).ColumnName("ISBP");
			  
			this.Column(p =>p.IllType).ColumnName("ILLTYPE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalID).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

