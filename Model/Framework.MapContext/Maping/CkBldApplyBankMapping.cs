

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 申请退血 - 实体类
	/// </summary>
	public partial class CkBldApplyBankMapping: ClassMap<CkBldApplyBank>
	{   
		/// <summary>
		/// 申请退血 - 实体类
		/// </summary>
		public CkBldApplyBankMapping()
		{
			this.TableName("CKBLDAPPLYBANK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.BankId).ColumnName("BANKID");
			  
			this.Column(p =>p.SerilalNo).ColumnName("SERILALNO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

