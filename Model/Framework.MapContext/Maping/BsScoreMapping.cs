

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 考试答题表 - 实体类
	/// </summary>
	public partial class BsScoreMapping: ClassMap<BsScore>
	{   
		/// <summary>
		/// 考试答题表 - 实体类
		/// </summary>
		public BsScoreMapping()
		{
			this.TableName("BSSCORE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.UserID).ColumnName("USERID");
			  
			this.Column(p =>p.TestPaperId).ColumnName("TESTPAPERID");
			  
			this.Column(p =>p.Score).ColumnName("SCORE");
			  
			this.Column(p =>p.Answer).ColumnName("ANSWER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

