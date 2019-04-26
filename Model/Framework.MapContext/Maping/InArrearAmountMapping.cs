

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 住院透支表 - 实体类
	/// </summary>
	public partial class InArrearAmountMapping: ClassMap<InArrearAmount>
	{   
		/// <summary>
		/// 住院透支表 - 实体类
		/// </summary>
		public InArrearAmountMapping()
		{
			this.TableName("INARREARAMOUNT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.ArrearAmount).ColumnName("ARREARAMOUNT");
			  
			this.Column(p =>p.AuthMan).ColumnName("AUTHMAN");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.ExpireDate).ColumnName("EXPIREDATE");
			  
			this.Column(p =>p.ExpireHours).ColumnName("EXPIREHOURS");
			  
			this.Column(p =>p.IsMax).ColumnName("ISMAX");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

