

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 实时记录病人费用情况 - 实体类
	/// </summary>
	public partial class InPatFeesListMapping: ClassMap<InPatFeesList>
	{   
		/// <summary>
		/// 实时记录病人费用情况 - 实体类
		/// </summary>
		public InPatFeesListMapping()
		{
			this.TableName("INPATFEESLIST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.BedID).ColumnName("BEDID");
			  
			this.Column(p =>p.InTime).ColumnName("INTIME");
			  
			this.Column(p =>p.OutTime).ColumnName("OUTTIME");
			  
			this.Column(p =>p.PatTypeID).ColumnName("PATTYPEID");
			  
			this.Column(p =>p.LocationID).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.LocIn).ColumnName("LOCIN");
			  
			this.Column(p =>p.DoctorID).ColumnName("DOCTORID");
			  
			this.Column(p =>p.Amount).ColumnName("AMOUNT");
			  
			this.Column(p =>p.AmountPay).ColumnName("AMOUNTPAY");
			  
			this.Column(p =>p.Deposit).ColumnName("DEPOSIT");
			  
			this.Column(p =>p.NotPay).ColumnName("NOTPAY");
			  
			this.Column(p =>p.HasPay).ColumnName("HASPAY");
			  
			this.Column(p =>p.Remain).ColumnName("REMAIN");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.InPatNo).ColumnName("INPATNO");
			  
			this.Column(p =>p.AmountNoPay).ColumnName("AMOUNTNOPAY");
			  
			this.Column(p =>p.AmountPayNoPay).ColumnName("AMOUNTPAYNOPAY");
			  
			this.Column(p =>p.DepositNoPay).ColumnName("DEPOSITNOPAY");
			  
			this.Column(p =>p.DepositMz).ColumnName("DEPOSITMZ");
			  
			this.Column(p =>p.FactGet).ColumnName("FACTGET");
			  
			this.Column(p =>p.AllFactGet).ColumnName("ALLFACTGET");
			  
			this.Column(p =>p.YPAmount).ColumnName("YPAMOUNT");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

