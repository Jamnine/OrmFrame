

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 问题库 - 实体类
	/// </summary>
	public partial class BsQuestionMapping: ClassMap<BsQuestion>
	{   
		/// <summary>
		/// 问题库 - 实体类
		/// </summary>
		public BsQuestionMapping()
		{
			this.TableName("BSQUESTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Question).ColumnName("QUESTION");
			  
			this.Column(p =>p.Answer).ColumnName("ANSWER");
			  
			this.Column(p =>p.OptionA).ColumnName("OPTIONA");
			  
			this.Column(p =>p.OptionB).ColumnName("OPTIONB");
			  
			this.Column(p =>p.OptionC).ColumnName("OPTIONC");
			  
			this.Column(p =>p.OptionD).ColumnName("OPTIOND");
			  
			this.Column(p =>p.SubjectId).ColumnName("SUBJECTID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

