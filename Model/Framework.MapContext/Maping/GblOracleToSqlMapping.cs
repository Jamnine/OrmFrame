

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class GblOracleToSqlMapping: ClassMap<GblOracleToSql>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public GblOracleToSqlMapping()
		{
			this.TableName("GBLORACLETOSQL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OracleTable).ColumnName("ORACLETABLE");
			  
			this.Column(p =>p.OracleColumn).ColumnName("ORACLECOLUMN");
			  
			this.Column(p =>p.SqlTable).ColumnName("SQLTABLE");
			  
			this.Column(p =>p.SqlColumn).ColumnName("SQLCOLUMN");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

