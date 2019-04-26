

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 问题答案库 - 实体类
	/// </summary>
	public partial class GblQuestionMapping: ClassMap<GblQuestion>
	{   
		/// <summary>
		/// 问题答案库 - 实体类
		/// </summary>
		public GblQuestionMapping()
		{
			this.TableName("GBLQUESTION").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Question).ColumnName("QUESTION");
			  
			this.Column(p =>p.Answer).ColumnName("ANSWER");
			  
			this.Column(p =>p.SystemId).ColumnName("SYSTEMID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

