

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验质控 - 实体类
	/// </summary>
	public partial class CkItemQcMapping: ClassMap<CkItemQc>
	{   
		/// <summary>
		/// 检验质控 - 实体类
		/// </summary>
		public CkItemQcMapping()
		{
			this.TableName("CKITEMQC").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.TestId).ColumnName("TESTID");
			  
			this.Column(p =>p.QcName).ColumnName("QCNAME");
			  
			this.Column(p =>p.Dev3).ColumnName("DEV3");
			  
			this.Column(p =>p.Dev2).ColumnName("DEV2");
			  
			this.Column(p =>p.Dev1).ColumnName("DEV1");
			  
			this.Column(p =>p.DevM1).ColumnName("DEVM1");
			  
			this.Column(p =>p.DevM2).ColumnName("DEVM2");
			  
			this.Column(p =>p.DevM3).ColumnName("DEVM3");
			  
			this.Column(p =>p.AvgValue).ColumnName("AVGVALUE");
			  
			this.Column(p =>p.CtrlId).ColumnName("CTRLID");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

