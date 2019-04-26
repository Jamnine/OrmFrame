

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 迁移病人 - 实体类
	/// </summary>
	public partial class HistMoveHosInfoMapping: ClassMap<HistMoveHosInfo>
	{   
		/// <summary>
		/// 迁移病人 - 实体类
		/// </summary>
		public HistMoveHosInfoMapping()
		{
			this.TableName("HISTMOVEHOSINFO").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.RecordId).ColumnName("RECORDID");
			  
			this.Column(p =>p.LsInout).ColumnName("LSINOUT");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

