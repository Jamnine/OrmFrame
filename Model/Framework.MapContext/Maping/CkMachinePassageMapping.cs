

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验仪器项目通道号 - 实体类
	/// </summary>
	public partial class CkMachinePassageMapping: ClassMap<CkMachinePassage>
	{   
		/// <summary>
		/// 检验仪器项目通道号 - 实体类
		/// </summary>
		public CkMachinePassageMapping()
		{
			this.TableName("CKMACHINEPASSAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.TestID).ColumnName("TESTID");
			  
			this.Column(p =>p.PassAgeNum).ColumnName("PASSAGENUM");
			  
			this.Column(p =>p.Modulus).ColumnName("MODULUS");
			  
			this.Column(p =>p.IsQc).ColumnName("ISQC");
			  
			this.Column(p =>p.EngshortName).ColumnName("ENGSHORTNAME");
			  
			this.Column(p =>p.Factor).ColumnName("FACTOR");
			  
			this.Column(p =>p.TestType).ColumnName("TESTTYPE");
			  
			this.Column(p =>p.Isdiluction).ColumnName("ISDILUCTION");
			  
			this.Column(p =>p.Precision).ColumnName("PRECISION");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.TjItemCode).ColumnName("TJITEMCODE");
      
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

