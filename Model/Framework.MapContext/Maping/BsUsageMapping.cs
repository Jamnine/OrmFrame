

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 用法 - 实体类
	/// </summary>
	public partial class BsUsageMapping: ClassMap<BsUsage>
	{   
		/// <summary>
		/// 用法 - 实体类
		/// </summary>
		public BsUsageMapping()
		{
			this.TableName("BSUSAGE").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.PrintName).ColumnName("PRINTNAME");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.LsUseArea).ColumnName("LSUSEAREA");
			  
			this.Column(p =>p.LsPrnFormType).ColumnName("LSPRNFORMTYPE");
			  
			this.Column(p =>p.IsPrintLabel).ColumnName("ISPRINTLABEL");
			  
			this.Column(p =>p.IsPrintReject).ColumnName("ISPRINTREJECT");
			  
			this.Column(p =>p.IsPrintDrug).ColumnName("ISPRINTDRUG");
			  
			this.Column(p =>p.IsPrintAst).ColumnName("ISPRINTAST");
			  
			this.Column(p =>p.IsPrintCure).ColumnName("ISPRINTCURE");
			  
			this.Column(p =>p.IsPrintNurse).ColumnName("ISPRINTNURSE");
			  
			this.Column(p =>p.IsPrintExternal).ColumnName("ISPRINTEXTERNAL");
			  
			this.Column(p =>p.IsPrintPush).ColumnName("ISPRINTPUSH");
			  
			this.Column(p =>p.IsPrintRejSkin).ColumnName("ISPRINTREJSKIN");
			  
			this.Column(p =>p.IsPrintDietetic).ColumnName("ISPRINTDIETETIC");
			  
			this.Column(p =>p.IsPrintBlood).ColumnName("ISPRINTBLOOD");
			  
			this.Column(p =>p.IsMzDrop).ColumnName("ISMZDROP");
			  
			this.Column(p =>p.IsMzReject).ColumnName("ISMZREJECT");
			  
			this.Column(p =>p.IsMzCure).ColumnName("ISMZCURE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.IsPrintAtomization).ColumnName("ISPRINTATOMIZATION");
			  
			this.Column(p =>p.LsInOutType).ColumnName("LSINOUTTYPE");
			  
			this.Column(p =>p.IsDrugTwoDay).ColumnName("ISDRUGTWODAY");
			  
			this.Column(p =>p.ISIVGTT).ColumnName("ISIVGTT"); 
			  
			this.Column(p =>p.IsChin).ColumnName("ISCHIN"); 

            this.Column(p => p.ModiOperId).ColumnName("MODIOPERID");

            this.Column(p => p.ModiTime).ColumnName("MODITIME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.RPTName).ColumnName("RPTNAME"); 

            this.Column(p => p.IsSpecialUsage).ColumnName("ISSPECIALUSAGE");


            this.Column(p => p.ISFORWestDrug).ColumnName("ISFORWESTDRUG");


             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

