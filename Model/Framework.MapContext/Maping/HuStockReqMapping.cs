

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 仓库药库采购申请单 - 实体类
	/// </summary>
	public partial class HuStockReqMapping: ClassMap<HuStockReq>
	{   
		/// <summary>
		/// 仓库药库采购申请单 - 实体类
		/// </summary>
		public HuStockReqMapping()
		{
			this.TableName("HUSTOCKREQ").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.BillNo).ColumnName("BILLNO");
			  
			this.Column(p =>p.HouseId).ColumnName("HOUSEID");
			  
			this.Column(p =>p.ApplyTime).ColumnName("APPLYTIME");
			  
			this.Column(p =>p.ValideTime).ColumnName("VALIDETIME");
			  
			this.Column(p =>p.ApplyIdea).ColumnName("APPLYIDEA");
			  
			this.Column(p =>p.ApplyHander).ColumnName("APPLYHANDER");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.CompId).ColumnName("COMPID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.LogoperTime).ColumnName("LOGOPERTIME");
			  
			this.Column(p =>p.LogoperId).ColumnName("LOGOPERID");
			  
			this.Column(p =>p.Status).ColumnName("STATUS");
			  
			this.Column(p =>p.PatId).ColumnName("PATID");
			  
			this.Column(p =>p.MzregId).ColumnName("MZREGID");
			  
			this.Column(p =>p.PageNumber).ColumnName("PAGENUMBER");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

