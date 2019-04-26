

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 提示信息发送信息表 - 实体类
	/// </summary>
	public partial class GblEmailMapping: ClassMap<GblEmail>
	{   
		/// <summary>
		/// 提示信息发送信息表 - 实体类
		/// </summary>
		public GblEmailMapping()
		{
			this.TableName("GBLEMAIL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Title).ColumnName("TITLE");
			  
			this.Column(p =>p.Content).ColumnName("CONTENT");
			  
			this.Column(p =>p.FileName).ColumnName("FILENAME");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.IsPriority).ColumnName("ISPRIORITY");
			  
			this.Column(p =>p.IsFeedback).ColumnName("ISFEEDBACK");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

