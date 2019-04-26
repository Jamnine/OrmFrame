

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class CkMachineTestMapping: ClassMap<CkMachineTest>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public CkMachineTestMapping()
		{
			this.TableName("CKMACHINETEST").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.DictTestid).ColumnName("DICTTESTID");
			  
			this.Column(p =>p.Wbm).ColumnName("WBM");
			  
			this.Column(p =>p.Pym).ColumnName("PYM");
			  
			this.Column(p =>p.TestCode).ColumnName("TESTCODE");
			  
			this.Column(p =>p.EngShortName).ColumnName("ENGSHORTNAME");
			  
			this.Column(p =>p.EngLongName).ColumnName("ENGLONGNAME");
			  
			this.Column(p =>p.TestName).ColumnName("TESTNAME");
			  
			this.Column(p =>p.PrintName).ColumnName("PRINTNAME");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.DisplayOrder).ColumnName("DISPLAYORDER");
			  
			this.Column(p =>p.Precision).ColumnName("PRECISION");
			  
			this.Column(p =>p.RefMethod).ColumnName("REFMETHOD");
			  
			this.Column(p =>p.DeltaCheckType).ColumnName("DELTACHECKTYPE");
			  
			this.Column(p =>p.DeltaCheckValue).ColumnName("DELTACHECKVALUE");
			  
			this.Column(p =>p.KeepStorageDay).ColumnName("KEEPSTORAGEDAY");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.ResultType).ColumnName("RESULTTYPE");
			  
			this.Column(p =>p.ResultTips).ColumnName("RESULTTIPS");
			  
			this.Column(p =>p.DefaultResult).ColumnName("DEFAULTRESULT");
			  
			this.Column(p =>p.ForSex).ColumnName("FORSEX");
			  
			this.Column(p =>p.PrintAlias).ColumnName("PRINTALIAS");
			  
			this.Column(p =>p.ClinicRemark).ColumnName("CLINICREMARK");
			  
			this.Column(p =>p.OperationComment).ColumnName("OPERATIONCOMMENT");
			  
			this.Column(p =>p.Remark).ColumnName("REMARK");
			  
			this.Column(p =>p.IsCaculateItem).ColumnName("ISCACULATEITEM");
			  
			this.Column(p =>p.IsSendoutItem).ColumnName("ISSENDOUTITEM");
			  
			this.Column(p =>p.IsPrivacy).ColumnName("ISPRIVACY");
			  
			this.Column(p =>p.IsImportantItem).ColumnName("ISIMPORTANTITEM");
			  
			this.Column(p =>p.IsSpecialItem).ColumnName("ISSPECIALITEM");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.DictResultOptionid).ColumnName("DICTRESULTOPTIONID");
			  
			this.Column(p =>p.DictTestMethodid).ColumnName("DICTTESTMETHODID");
			  
			this.Column(p =>p.DictTubeGroupid).ColumnName("DICTTUBEGROUPID");
			  
			this.Column(p =>p.DictContainerid).ColumnName("DICTCONTAINERID");
			  
			this.Column(p =>p.DictSpecimenTypeid).ColumnName("DICTSPECIMENTYPEID");
			  
			this.Column(p =>p.DictMedicalTypeid).ColumnName("DICTMEDICALTYPEID");
			  
			this.Column(p =>p.DictLabDeptid).ColumnName("DICTLABDEPTID");
			  
			this.Column(p =>p.IsGroup).ColumnName("ISGROUP");
			  
			this.Column(p =>p.IsReport).ColumnName("ISREPORT");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

