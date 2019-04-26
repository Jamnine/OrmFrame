

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 分院 - 实体类
	/// </summary>
	public partial class BsHospitalMapping: ClassMap<BsHospital>
	{   
		/// <summary>
		/// 分院 - 实体类
		/// </summary>
		public BsHospitalMapping()
		{
			this.TableName("BSHOSPITAL").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.Area).ColumnName("AREA");
			  
			this.Column(p =>p.Farthest).ColumnName("FARTHEST");
			  
			this.Column(p =>p.Address).ColumnName("ADDRESS");
			  
			this.Column(p =>p.Phone).ColumnName("PHONE");
			  
			this.Column(p =>p.Email).ColumnName("EMAIL");
			  
			this.Column(p =>p.ResidentPopulation).ColumnName("RESIDENTPOPULATION");
			  
			this.Column(p =>p.TentPopulation).ColumnName("TENTPOPULATION");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.CentralCode).ColumnName("CENTRALCODE");
			  
			this.Column(p =>p.MedicalCode).ColumnName("MEDICALCODE");
			  
			this.Column(p =>p.Certificate).ColumnName("CERTIFICATE");
			  
			this.Column(p =>p.EngDesc).ColumnName("ENGDESC");
			  
			this.Column(p =>p.License).ColumnName("LICENSE");
			  
			this.Column(p =>p.ManageUser).ColumnName("MANAGEUSER");
			  
			this.Column(p =>p.IsAudit).ColumnName("ISAUDIT");
			  
			this.Column(p =>p.AreaId).ColumnName("AREAID");
			  
			this.Column(p =>p.RegionId).ColumnName("REGIONID");
			  
			this.Column(p =>p.ProvinceId).ColumnName("PROVINCEID");
			  
			this.Column(p =>p.UserId).ColumnName("USERID");
            this.Column(p => p.BsSpeciaNameLists).ColumnName("BSSPECIALISTNAMES");
            this.Column(p => p.BsSpeciaIDLists).ColumnName("BSSPECIALISTIDS");

            this.Column(p => p.CashierReport).ColumnName("CashierReport");
            this.Column(p => p.UnionId).ColumnName("UNIONID");
            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Column(p=>p.IsInterface).ColumnName("ISINTERFACE");
            this.Column(p => p.IsInterUMP).ColumnName("ISINTERUMP");
            this.Column(p => p.ReportTitle).ColumnName("REPORTTITLE");

            this.Column(p => p.IsEnableFreshInventory).ColumnName("ISENABLEFRESHINVENTORY");
            this.Column(p => p.IsEnableInventory).ColumnName("ISENABLEINVENTORY");
            this.Column(p => p.ContrastCode).ColumnName("CONTRASTCODE");
            this.Id(T => T.ID).DbGenerated();
            this.SequenceId(t => t.ID).SequenceName("BsHospital_ID_SEQ");
            this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

