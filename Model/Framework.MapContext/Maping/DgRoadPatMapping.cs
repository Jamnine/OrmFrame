

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	///  - 实体类
	/// </summary>
	public partial class DgRoadPatMapping: ClassMap<DgRoadPat>
	{   
		/// <summary>
		///  - 实体类
		/// </summary>
		public DgRoadPatMapping()
		{
			this.TableName("DGROADPAT").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.HospId).ColumnName("HOSPID");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.OperId).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.IsChk).ColumnName("ISCHK");
			  
			this.Column(p =>p.ChkOperTime).ColumnName("CHKOPERTIME");
			  
			this.Column(p =>p.ChkOperId).ColumnName("CHKOPERID");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.ChangeReason).ColumnName("CHANGEREASON");
			  
			this.Column(p =>p.RoadLocName).ColumnName("ROADLOCNAME");
			  
			this.Column(p =>p.RoadDocName).ColumnName("ROADDOCNAME");
			  
			this.Column(p =>p.IsExit).ColumnName("ISEXIT");
			  
			this.Column(p =>p.ExitDoctorId).ColumnName("EXITDOCTORID");
			  
			this.Column(p =>p.ExitOperTime).ColumnName("EXITOPERTIME");
			  
			this.Column(p =>p.SignNurseUsertTime).ColumnName("SIGNNURSEUSERTTIME");
			  
			this.Column(p =>p.LsTimeType).ColumnName("LSTIMETYPE");
			  
			this.Column(p =>p.CurRstage).ColumnName("CURRSTAGE");
			  
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

