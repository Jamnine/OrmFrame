

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 血库血袋表 - 实体类
	/// </summary>
	public partial class CkBdBankMapping: ClassMap<CkBdBank>
	{   
		/// <summary>
		/// 血库血袋表 - 实体类
		/// </summary>
		public CkBdBankMapping()
		{
			this.TableName("CKBDBANK").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.SerialNo).ColumnName("SERIALNO");
			  
			this.Column(p =>p.BloodTypeId).ColumnName("BLOODTYPEID");
			  
			this.Column(p =>p.BloodGroup).ColumnName("BLOODGROUP");
			  
			this.Column(p =>p.RecieveDate).ColumnName("RECIEVEDATE");
			  
			this.Column(p =>p.RecieveOperId).ColumnName("RECIEVEOPERID");
			  
			this.Column(p =>p.LsSource).ColumnName("LSSOURCE");
			  
			this.Column(p =>p.Account).ColumnName("ACCOUNT");
			  
			this.Column(p =>p.ExpireDate).ColumnName("EXPIREDATE");
			  
			this.Column(p =>p.OfferMan).ColumnName("OFFERMAN");
			  
			this.Column(p =>p.CollectDate).ColumnName("COLLECTDATE");
			  
			this.Column(p =>p.CollectMan).ColumnName("COLLECTMAN");
			  
			this.Column(p =>p.Vollume).ColumnName("VOLLUME");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.LsStatus).ColumnName("LSSTATUS");
			  
			this.Column(p =>p.BackDate).ColumnName("BACKDATE");
			  
			this.Column(p =>p.BackOperId).ColumnName("BACKOPERID");
			  
			this.Column(p =>p.BackMemo).ColumnName("BACKMEMO");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.DiscardReason).ColumnName("DISCARDREASON");
			  
			this.Column(p =>p.DiscardTime).ColumnName("DISCARDTIME");
			  
			this.Column(p =>p.DiscardOperID).ColumnName("DISCARDOPERID");
			  
			this.Column(p =>p.LimitDays).ColumnName("LIMITDAYS");
			  
			this.Column(p =>p.WithPrice).ColumnName("WITHPRICE");
			  
			this.Column(p =>p.StoragePrice).ColumnName("STORAGEPRICE");
			  
			this.Column(p =>p.RetailPrice).ColumnName("RETAILPRICE");
			  
			this.Column(p =>p.ProcessingPrice).ColumnName("PROCESSINGPRICE");
			  
			this.Column(p =>p.ApplyId).ColumnName("APPLYID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.DoctorId).ColumnName("DOCTORID");
			  
			this.Column(p =>p.SendOperId).ColumnName("SENDOPERID");
			  
			this.Column(p =>p.SendTime).ColumnName("SENDTIME");
			  
			this.Column(p =>p.LabId).ColumnName("LABID");
			  
			this.Column(p =>p.BloodGroup2).ColumnName("BLOODGROUP2");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

