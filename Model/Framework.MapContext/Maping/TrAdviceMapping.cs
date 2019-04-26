﻿

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 医生医嘱修改记录 - 实体类
	/// </summary>
	public partial class TrAdviceMapping: ClassMap<TrAdvice>
	{   
		/// <summary>
		/// 医生医嘱修改记录 - 实体类
		/// </summary>
		public TrAdviceMapping()
		{
			this.TableName("TRADVICE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.AdviceId).ColumnName("ADVICEID");
			  
			this.Column(p =>p.LsMarkType).ColumnName("LSMARKTYPE");
			  
			this.Column(p =>p.Type).ColumnName("TYPE");
			  
			this.Column(p =>p.Before).ColumnName("BEFORE");
			  
			this.Column(p =>p.After).ColumnName("AFTER");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

