﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class BsCareGroupMapping: ClassMap<BsCareGroup>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public BsCareGroupMapping()
		{
			this.TableName("BSCAREGROUP").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.NurseUserId).ColumnName("NURSEUSERID");
			  
			this.Column(p =>p.GuardUserId).ColumnName("GUARDUSERID");
			  
			this.Column(p =>p.OtherUserId).ColumnName("OTHERUSERID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

