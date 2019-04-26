

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验结果 - 实体类
	/// </summary>
	public partial class CkLabResultMapping: ClassMap<CkLabResult>
	{   
		/// <summary>
		/// 检验结果 - 实体类
		/// </summary>
		public CkLabResultMapping()
		{
			this.TableName("CKLABRESULT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Labid).ColumnName("LABID");

            this.Column(p => p.DoctorId).ColumnName("DOCTORID");

            this.Column(p =>p.Testid).ColumnName("TESTID");
			  
			this.Column(p =>p.LastResult).ColumnName("LASTRESULT");
			  
			this.Column(p =>p.Result).ColumnName("RESULT");
			  
			this.Column(p =>p.Unit).ColumnName("UNIT");
			  
			this.Column(p =>p.LsrefFlag).ColumnName("LSREFFLAG");
			  
			this.Column(p =>p.IsPanic).ColumnName("ISPANIC");
			  
			this.Column(p =>p.IsDalta).ColumnName("ISDALTA");
			  
			this.Column(p =>p.DalabSolute).ColumnName("DALABSOLUTE");
			  
			this.Column(p =>p.DalPercent).ColumnName("DALPERCENT");
			  
			this.Column(p =>p.LowValue).ColumnName("LOWVALUE");
			  
			this.Column(p =>p.HighValue).ColumnName("HIGHVALUE");

            this.Column(p =>p.Paniclow).ColumnName("PANICLOW");
			  
			this.Column(p =>p.PanicHigh).ColumnName("PANICHIGH");
			  
			this.Column(p =>p.IsPass).ColumnName("ISPASS");
			  
			this.Column(p =>p.IsReport).ColumnName("ISREPORT");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");

            this.Column(p =>p.Isprint).ColumnName("ISPRINT");
			  
			this.Column(p =>p.PrintTime).ColumnName("PRINTTIME");

            this.Column(p =>p.PrintOperid).ColumnName("PRINTOPERID");
			  
			this.Column(p =>p.TextRange).ColumnName("TEXTRANGE");
			  
			this.Column(p =>p.Deviate).ColumnName("DEVIATE");

            this.Column(p =>p.AuthDocname).ColumnName("AUTHDOCNAME");
			  
			this.Column(p =>p.AuthDocTime).ColumnName("AUTHDOCTIME");
			  
			this.Column(p =>p.CheckNo).ColumnName("CHECKNO");
			  
			this.Column(p =>p.Itemname).ColumnName("ITEMNAME");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.Commentary).ColumnName("COMMENTARY");

            this.Column(p => p.CommonProblem).ColumnName("COMMONPROBLEM");

            this.Column(p => p.AbnormalTips).ColumnName("ABNORMALTIPS");

            this.Column(p => p.TestIllustration).ColumnName("TESTILLUSTRATION");

            this.Column(p => p.IsGroup).ColumnName("ISGROUP");

            this.Column(p => p.Properties).ColumnName("PROPERTIES");

            this.Column(p => p.GroupItemCode).ColumnName("GROUPITEMCODE");

            this.Column(p => p.ItemTerface).ColumnName("ITEMTERFACE");

             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

