

using ELinq.Mapping.Fluent;
using Orm.Model;
namespace Orm.MapContext
{
	/// <summary>
	/// 检验项目 - 实体类
	/// </summary>
	public partial class CkItemMapping: ClassMap<CkItem>
	{   
		/// <summary>
		/// 检验项目 - 实体类
		/// </summary>
		public CkItemMapping()
		{
			this.TableName("CKITEM").Schema("orm");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Column(p => p.Code).ColumnName("Code");
            this.Column(p => p.LsTestType).ColumnName("LsTestType");
            this.Column(p => p.TestTypeId).ColumnName("TestTypeId");
            this.Column(p => p.TubeTypeId).ColumnName("TubeTypeId");
            this.Column(p => p.ShortName).ColumnName("ShortName");
            this.Column(p => p.Name).ColumnName("Name");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.OperMemo).ColumnName("OperMemo");
            this.Column(p => p.IsZero).ColumnName("IsZero");
            this.Column(p => p.LsGroup).ColumnName("LsGroup");
            this.Column(p => p.IsReport).ColumnName("IsReport");
            this.Column(p => p.UseRange).ColumnName("UseRange");
            this.Column(p => p.LsForSex).ColumnName("LsForSex");
            this.Column(p => p.SourceId).ColumnName("SourceId");
            this.Column(p => p.Price).ColumnName("Price");
            this.Column(p => p.Unit).ColumnName("Unit");
            this.Column(p => p.Format).ColumnName("Format"); 
            this.Column(p => p.LowerTips).ColumnName("LowerTips");
            this.Column(p => p.HigherTips).ColumnName("HigherTips");
            this.Column(p => p.VeryLowTips).ColumnName("VeryLowTips");
            this.Column(p => p.VeryTopTips).ColumnName("VeryTopTips");
            this.Column(p => p.LastTime).ColumnName("LastTime");
            this.Column(p => p.IsAutoOver).ColumnName("IsAutoOver");
            this.Column(p => p.InsertTime).ColumnName("InsertTime");
            this.Column(p => p.IsDisplay).ColumnName("IsDisplay");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.Dev3).ColumnName("Dev3");
            this.Column(p => p.Dev2).ColumnName("Dev2"); 
            this.Column(p => p.Dev1).ColumnName("Dev1");
            this.Column(p => p.DevM1).ColumnName("DevM1");
            this.Column(p => p.DevM2).ColumnName("DevM2");
            this.Column(p => p.DevM3).ColumnName("DevM3");
            this.Column(p => p.HospitalId).ColumnName("HospitalID");
            this.Column(p => p.HisType).ColumnName("HisType");

            this.Column(p => p.LimitHigh).ColumnName("LimitHigh");
            this.Column(p => p.LimitLow).ColumnName("LimitLow");
            this.Column(p => p.VeryLowLimit).ColumnName("VeryLowLimit");
            this.Column(p => p.VeryTopLimit).ColumnName("VeryTopLimit");

            this.Column(p => p.PrintHigh).ColumnName("PrintHigh");
            this.Column(p => p.PrintLow).ColumnName("PrintLow");
            this.Column(p => p.DataType).ColumnName("DataType");
            this.Column(p => p.ReferType).ColumnName("ReferType");
            this.Column(p => p.ZdyCode).ColumnName("ZdyCode");
            this.Column(p => p.EngDesc).ColumnName("EngDesc");
            this.Column(p => p.MedicalCode).ColumnName("MedicalCode");
            this.Column(p => p.IsPrintDetail).ColumnName("IsPrintDetail");
            this.Column(p => p.GuideTips).ColumnName("GuideTips");
            this.Column(p => p.OperId).ColumnName("OperId");


            this.Column(p => p.LocationID).ColumnName("LOCATIONID");
            this.Column(p => p.Commentary).ColumnName("COMMENTARY");
            this.Column(p => p.CommonProblem).ColumnName("COMMONPROBLEM");
            this.Column(p => p.TestIllustration).ColumnName("TESTILLUSTRATION");

            this.Column(p => p.DefaultValue).ColumnName("DefaultValue");
            this.Column(p => p.CKMachineID).ColumnName("CKMachineID");





            this.Column(p => p.DalAbsolute).ColumnName("DalAbsolute");
            this.Column(p => p.DalPercent).ColumnName("DalPercent");
            this.Column(p => p.ItemId).ColumnName("ItemId");
            this.Column(p => p.OrderBy).ColumnName("OrderBy");

            this.Column(p => p.FluidId).ColumnName("FluidId");
            this.Column(p => p.TestWay).ColumnName("TestWay");

            this.Column(p => p.AvgValue).ColumnName("AvgValue");

            this.Column(p => p.VIPPrice).ColumnName("VIPPrice");
            this.Column(p => p.PrintTagType).ColumnName("PrintTagType");
            this.Column(p => p.IsGroup).ColumnName("IsGroup");
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
		}      
	}  
}           
 

