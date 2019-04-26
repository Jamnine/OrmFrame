

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 
	/// </summary>
	public partial class YbPatSeqMapping : ClassMap<YbPatSeq>
	{   
		/// <summary>
		/// 会员积分表 - 实体类
		/// </summary>
		public YbPatSeqMapping()
		{
			this.TableName("YBPATSEQ").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.MzRegId).ColumnName("MZREGID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.YbSeq).ColumnName("YBSEQ");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.InvoId).ColumnName("INVOID");
			  
			this.Column(p =>p.CentreNum).ColumnName("CENTRENUM");
			  
			this.Column(p =>p.PayType).ColumnName("PAYTYPE");

            this.Column(p => p.PersonalNum).ColumnName("PERSONALNUM");

            this.Column(p => p.InsuranceMethod).ColumnName("INSURANCEMETHOD");

            this.Column(p => p.DoctorNum).ColumnName("DOCTORNUM");

            this.Column(p => p.DiseaseNum).ColumnName("DISEASENUM");

            this.Column(p => p.BalanceNum).ColumnName("BALANCENUM");

            this.Column(p => p.IsCancel).ColumnName("ISCANCEL");

            this.Column(p => p.IsAuthed).ColumnName("ISAUTHED");

            this.Column(p => p.InsuranceType).ColumnName("INSURANCETYPE");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

