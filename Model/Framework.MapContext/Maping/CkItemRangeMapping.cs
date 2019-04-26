

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验项目范围 - 实体类
	/// </summary>
	public partial class CkItemRangeMapping: ClassMap<CkItemRange>
	{   
		/// <summary>
		/// 检验项目范围 - 实体类
		/// </summary>
		public CkItemRangeMapping()
		{
			this.TableName("CKITEMRANGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.Sex).ColumnName("SEX");
			  
			this.Column(p =>p.AgeFrom).ColumnName("AGEFROM");
			  
			this.Column(p =>p.AgeTo).ColumnName("AGETO");
			  
			this.Column(p =>p.LowValue).ColumnName("LOWVALUE");
			  
			this.Column(p =>p.HighValue).ColumnName("HIGHVALUE");
			  
			this.Column(p =>p.PanicLow).ColumnName("PANICLOW");
			  
			this.Column(p =>p.PanicHigh).ColumnName("PANICHIGH");
			  
			this.Column(p =>p.PrintResult).ColumnName("PRINTRESULT");
			  
			this.Column(p =>p.TextRange).ColumnName("TEXTRANGE");
			  
			this.Column(p =>p.LsAgeUnit).ColumnName("LSAGEUNIT");
			  
			this.Column(p =>p.MachineId).ColumnName("MACHINEID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			  
			this.Column(p =>p.ReferenceString).ColumnName("ReferenceString");
			this.Column(p =>p.ReferenExplain).ColumnName("ReferenExplain");
			this.Column(p =>p.DecimalDigits).ColumnName("DecimalDigits");
			this.Column(p =>p.VeryLowLimit).ColumnName("VeryLowLimit");
			this.Column(p =>p.VeryTopLimit).ColumnName("VeryTopLimit");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

