

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 家庭档案 - 实体类
	/// </summary>
	public partial class BsFamilyMapping: ClassMap<BsFamily>
	{   
		/// <summary>
		/// 家庭档案 - 实体类
		/// </summary>
		public BsFamilyMapping()
		{
			this.TableName("BSFAMILY").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p =>p.Code).ColumnName("CODE");
			  
			this.Column(p =>p.CommitteeId).ColumnName("COMMITTEEID");
			  
			this.Column(p =>p.Name).ColumnName("NAME");
			  
			this.Column(p =>p.AddressHome).ColumnName("ADDRESSHOME");
			  
			this.Column(p =>p.PhoneHome).ColumnName("PHONEHOME");
			  
			this.Column(p =>p.PostCodeHome).ColumnName("POSTCODEHOME");
			  
			this.Column(p =>p.AreaCodeHome).ColumnName("AREACODEHOME");
			  
			this.Column(p =>p.TotalPersons).ColumnName("TOTALPERSONS");
			  
			this.Column(p =>p.HousePersons).ColumnName("HOUSEPERSONS");
			  
			this.Column(p =>p.WorkingPersons).ColumnName("WORKINGPERSONS");
			  
			this.Column(p =>p.LsFamilyType).ColumnName("LSFAMILYTYPE");
			  
			this.Column(p =>p.LsPeriod).ColumnName("LSPERIOD");
			  
			this.Column(p =>p.LsHouseType).ColumnName("LSHOUSETYPE");
			  
			this.Column(p =>p.Acreage).ColumnName("ACREAGE");
			  
			this.Column(p =>p.LsFuel).ColumnName("LSFUEL");
			  
			this.Column(p =>p.LsWarm).ColumnName("LSWARM");
			  
			this.Column(p =>p.LsCold).ColumnName("LSCOLD");
			  
			this.Column(p =>p.LsWater).ColumnName("LSWATER");
			  
			this.Column(p =>p.LsSaniFamily).ColumnName("LSSANIFAMILY");
			  
			this.Column(p =>p.LsSaniPerson).ColumnName("LSSANIPERSON");
			  
			this.Column(p =>p.LsSaniHabit).ColumnName("LSSANIHABIT");
			  
			this.Column(p =>p.LsNeighbourhood).ColumnName("LSNEIGHBOURHOOD");
			  
			this.Column(p =>p.LsWC).ColumnName("LSWC");
			  
			this.Column(p =>p.IsHealthBin).ColumnName("ISHEALTHBIN");
			  
			this.Column(p =>p.LsIncome).ColumnName("LSINCOME");
			  
			this.Column(p =>p.Memo).ColumnName("MEMO");
			  
			this.Column(p =>p.PyCode).ColumnName("PYCODE");
			  
			this.Column(p =>p.WbCode).ColumnName("WBCODE");
			  
			this.Column(p =>p.OrderBy).ColumnName("ORDERBY");
			  
			this.Column(p =>p.OperTime).ColumnName("OPERTIME");
			  
			this.Column(p =>p.OperID).ColumnName("OPERID");
			  
			this.Column(p =>p.IsActive).ColumnName("ISACTIVE");
			  
			this.Column(p =>p.InActiveReason).ColumnName("INACTIVEREASON");
			  
			this.Column(p =>p.InActiveTime).ColumnName("INACTIVETIME");
			  
			this.Column(p =>p.InActiveOperID).ColumnName("INACTIVEOPERID");
			  
			this.Column(p =>p.IconIndex).ColumnName("ICONINDEX");
			  
			this.Column(p =>p.RoadId).ColumnName("ROADID");
			  
			this.Column(p =>p.IsSign).ColumnName("ISSIGN");
			  
			this.Column(p =>p.IsCareMan).ColumnName("ISCAREMAN");
			  
			this.Column(p =>p.SignDoctorId).ColumnName("SIGNDOCTORID");
			  
			this.Column(p =>p.SignGroupId).ColumnName("SIGNGROUPID");
			 
			 
			
			
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

