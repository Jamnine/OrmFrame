

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 科室 - 实体类
	/// </summary>
	public partial class BsLocationMapping: ClassMap<BsLocation>
	{
        /// <summary>
        /// 科室 - 实体类
        /// </summary>
        public BsLocationMapping()
        {
            this.TableName("BSLOCATION").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.Code).ColumnName("CODE");

            this.Column(p => p.Name).ColumnName("NAME");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

            this.Column(p => p.LsInOut).ColumnName("LSINOUT");

            this.Column(p => p.IsForwomen).ColumnName("ISFORWOMEN");

            this.Column(p => p.PhoneCode).ColumnName("PHONECODE");

            this.Column(p => p.MedicineRatio).ColumnName("MEDICINERATIO");

            this.Column(p => p.OrderBy).ColumnName("ORDERBY");

            this.Column(p => p.IsActive).ColumnName("ISACTIVE");

            this.Column(p => p.IconIndex).ColumnName("ICONINDEX");

            this.Column(p => p.SpecialityId).ColumnName("SPECIALITYID");

            this.Column(p => p.BedSum).ColumnName("BEDSUM");

            this.Column(p => p.BaSysCode).ColumnName("BASYSCODE");

            this.Column(p => p.Director).ColumnName("DIRECTOR");

            this.Column(p => p.DeptTypeId).ColumnName("DEPTTYPEID");

            this.Column(p => p.IsCostApp).ColumnName("ISCOSTAPP");

            this.Column(p => p.AppLevel).ColumnName("APPLEVEL");

            this.Column(p => p.PyCode).ColumnName("PYCODE");

            this.Column(p => p.WbCode).ColumnName("WBCODE");

            this.Column(p => p.Area).ColumnName("AREA");

            this.Column(p => p.OuRoomId).ColumnName("OUROOMID");

            this.Column(p => p.InRoomId).ColumnName("INROOMID");

            this.Column(p => p.IsPriceSub).ColumnName("ISPRICESUB");

            this.Column(p => p.IsClinical).ColumnName("ISCLINICAL");

            this.Column(p => p.IsChinLocation).ColumnName("ISCHINLOCATION");

            this.Column(p => p.IsRegLocation).ColumnName("ISREGLOCATION");

            this.Column(p => p.IsAllLocation).ColumnName("ISALLLOCATION");

            this.Column(p => p.Moditime).ColumnName("MODITIME");

            this.Column(p => p.ModioperId).ColumnName("MODIOPERID");

            this.Column(p => p.HisType).ColumnName("HISTYPE");

            this.Id(t => t.GUID);
            this.Ignore(p => p.IsModify);






        }
	}  
}           
 

