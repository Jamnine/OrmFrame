

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 行心云:积分使用记录表 - 实体类
	/// </summary>
	public partial class IntegralsTableMapping: ClassMap<IntegralsTable>
	{   
		/// <summary>
		/// 行心云:积分使用记录表 - 实体类
		/// </summary>
		public IntegralsTableMapping()
		{
			this.TableName("INTEGRALSTABLE").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.PatId).ColumnName("PATID");
            
                 this.Column(p => p.Integral).ColumnName("INTEGRAL");

            this.Column(p =>p.TotalIntegral).ColumnName("TOTALINTEGRAL");
			  
			this.Column(p =>p.OutIntegral).ColumnName("OUTINTEGRAL");
			  
			this.Column(p =>p.LsState).ColumnName("LSSTATE");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

