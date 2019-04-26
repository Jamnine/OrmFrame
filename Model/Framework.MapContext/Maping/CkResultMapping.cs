

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检单结果 - 实体类
	/// </summary>
	public partial class CkResultMapping: ClassMap<CkResult>
	{   
		/// <summary>
		/// 体检单结果 - 实体类
		/// </summary>
		public CkResultMapping()
		{
			this.TableName("CKRESULT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.CheckId).ColumnName("CHECKID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.LastResult).ColumnName("LASTRESULT");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.LsRefFlag).ColumnName("LSREFFLAG");
			  
			this.Column(p =>p.IsPanic).ColumnName("ISPANIC");
			  
			this.Column(p =>p.IsDalta).ColumnName("ISDALTA");
			  
			this.Column(p =>p.DalAbsolute).ColumnName("DALABSOLUTE");
			  
			this.Column(p =>p.DalPercent).ColumnName("DALPERCENT");
			  
			this.Column(p =>p.LowValue).ColumnName("LOWVALUE");
			  
			this.Column(p =>p.HighValue).ColumnName("HIGHVALUE");
			  
			this.Column(p =>p.PanicLow).ColumnName("PANICLOW");
			  
			this.Column(p =>p.PanicHigh).ColumnName("PANICHIGH");
			  
			this.Column(p =>p.IsPass).ColumnName("ISPASS");
			  
			this.Column(p =>p.ReportDate).ColumnName("REPORTDATE");
			  
			this.Column(p =>p.ReportBy).ColumnName("REPORTBY");
			  
			this.Column(p =>p.IsPrint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			  
			this.Column(p =>p.TextRange).ColumnName("TEXTRANGE");
			  
			this.Column(p =>p.Price).ColumnName("PRICE");
			  
			this.Column(p =>p.Discount).ColumnName("DISCOUNT");
			  
			this.Column(p =>p.TestGroupId).ColumnName("TESTGROUPID");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.AppId).ColumnName("APPID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

