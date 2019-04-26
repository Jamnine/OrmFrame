

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class InAdviceGroupMapping: ClassMap<InAdviceGroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public InAdviceGroupMapping()
		{
			this.TableName("INADVICEGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.UsageId).ColumnName("USAGEID");
			  
			this.Column(p =>p.GroupNum).ColumnName("GROUPNUM");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.MaxFrequency).ColumnName("MAXFREQUENCY");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.Times).ColumnName("TIMES");
			  
			this.Column(p =>p.Multifunction).ColumnName("MULTIFUNCTION");
			  
			this.Column(p =>p.IsGroupOnlyOne).ColumnName("ISGROUPONLYONE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

