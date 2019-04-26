

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 体检组项目 - 实体类
	/// </summary>
	public partial class CkGroupItemMapping: ClassMap<CkGroupItem>
	{   
		/// <summary>
		/// 体检组项目 - 实体类
		/// </summary>
		public CkGroupItemMapping()
		{
			this.TableName("CKGROUPITEM").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p =>p.CompanyGroupId).ColumnName("COMPANYGROUPID");
			this.Column(p =>p.TestId).ColumnName("TESTID");
			this.Column(p =>p.ParentID).ColumnName("PARENTID");
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			this.Column(p =>p.AppId).ColumnName("APPID");
			this.Column(p =>p.IsAuthed).ColumnName("ISAUTHED");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HisType");
            this.Column(p => p.InsertTime).ColumnName("InsertTime");

            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

