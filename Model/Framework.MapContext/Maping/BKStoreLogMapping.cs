

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 自助机支付日志 - 实体类
	/// </summary>
	public partial class BKStoreLogMapping: ClassMap<BKStoreLog>
	{   
		/// <summary>
		/// 自助机支付日志 - 实体类
		/// </summary>
		public BKStoreLogMapping()
		{
			this.TableName("BKSTORELOG").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.HappenTime).ColumnName("HAPPENTIME");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
			  
			this.Column(p =>p.PatCardid).ColumnName("PATCARDID");
			  
			this.Column(p =>p.BKRegNo).ColumnName("BKREGNO");
			  
			this.Column(p =>p.LsActType).ColumnName("LSACTTYPE");
			  
			this.Column(p =>p.BeforeMoney).ColumnName("BEFOREMONEY");
			  
			this.Column(p =>p.HappenMoney).ColumnName("HAPPENMONEY");
			  
			this.Column(p =>p.AfterMoney).ColumnName("AFTERMONEY");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.TransactionNum).ColumnName("TRANSACTIONNUM");
			  
			this.Column(p =>p.BHosName).ColumnName("BHOSNAME");
			  
			this.Column(p =>p.PayWayId).ColumnName("PAYWAYID");
			  
			this.Column(p =>p.IDType).ColumnName("IDTYPE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

