

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 考试问题分配表 - 实体类
	/// </summary>
	public partial class BsTestPaperMapping: ClassMap<BsTestPaper>
	{   
		/// <summary>
		/// 考试问题分配表 - 实体类
		/// </summary>
		public BsTestPaperMapping()
		{
			this.TableName("BSTESTPAPER").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.GenerateTime).ColumnName("GENERATETIME");
			  
			this.Column(p =>p.QuestionId).ColumnName("QUESTIONID");
			  
			this.Column(p =>p.UsersId).ColumnName("USERSID");
			  
			this.Column(p =>p.Minute).ColumnName("MINUTE");
            this.Column(p => p.ModioperId).ColumnName("MODIOPERID");
            this.Column(p => p.Moditime).ColumnName("MODITIME");


            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

