

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验仪器结果主表 - 实体类
	/// </summary>
	public partial class CkMachineResultMapping: ClassMap<CkMachineResult>
	{   
		/// <summary>
		/// 检验仪器结果主表 - 实体类
		/// </summary>
		public CkMachineResultMapping()
		{
			this.TableName("CKMACHINERESULT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.LabID).ColumnName("LABID");
			  
			this.Column(p =>p.SampleNum).ColumnName("SAMPLENUM");
			  
			this.Column(p =>p.TestDate).ColumnName("TESTDATE");
			  
			this.Column(p =>p.MachineID).ColumnName("MACHINEID");
			  
			this.Column(p =>p.TestTypeID).ColumnName("TESTTYPEID");
			  
			this.Column(p =>p.BatchNo).ColumnName("BATCHNO");
			  
			this.Column(p =>p.IsUse).ColumnName("ISUSE");
			  
			this.Column(p =>p.CreateDate).ColumnName("CREATEDATE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			  
			this.Column(p =>p.HospitalId).ColumnName("HospitalID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

