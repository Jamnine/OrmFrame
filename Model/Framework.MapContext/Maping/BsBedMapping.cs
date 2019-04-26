

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 床位 - 实体类
	/// </summary>
	public partial class BsBedMapping: ClassMap<BsBed>
	{   
		/// <summary>
		/// 床位 - 实体类
		/// </summary>
		public BsBedMapping()
		{
			this.TableName("BSBED").Schema("orm");
			  
			this.Column(p =>p.GUID).ColumnName("GUID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.RoomNo).ColumnName("ROOMNO");
			  
			this.Column(p =>p.LocationId).ColumnName("LOCATIONID");
			  
			this.Column(p =>p.LsBALL).ColumnName("LSBALL");
			  
			this.Column(p =>p.ItemId).ColumnName("ITEMID");
			  
			this.Column(p =>p.IsAdd).ColumnName("ISADD");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.LsClass).ColumnName("LSCLASS");
			  
			this.Column(p =>p.IsAddBed).ColumnName("ISADDBED");
			  
			this.Column(p =>p.BedGroup).ColumnName("BEDGROUP");
			  
			this.Column(p =>p.ItemIdCode1).ColumnName("ITEMIDCODE1");
			  
			this.Column(p =>p.ItemIdCode2).ColumnName("ITEMIDCODE2");
			  
			this.Column(p =>p.AddItemCode).ColumnName("ADDITEMCODE");
			  
			this.Column(p =>p.LeaveHospId).ColumnName("LEAVEHOSPID");
			  
			this.Column(p =>p.MatBedId).ColumnName("MATBEDID");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");
             
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

