

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkLabBankMapping: ClassMap<CkLabBank>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkLabBankMapping()
		{
			this.TableName("CKLABBANK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BankId).ColumnName("BANKID");
			  
			this.Column(p =>p.SerialNo).ColumnName("SERIALNO");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

