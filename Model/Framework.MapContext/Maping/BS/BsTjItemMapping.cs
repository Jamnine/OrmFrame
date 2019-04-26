using ELinq.Mapping.Fluent;  
using Orm.Model;  
  
namespace Orm.MapContext  
{   
    /// <summary>  
    ///体检项目
    /// </summary>  
    public partial class BsTjItemMapping: ClassMap<BsTjItem>  
    {  
        /// <summary>  
        /// 体检项目
        /// </summary>  
        public BsTjItemMapping()
        {  
            this.Column(p => p.GUID).ColumnName("GUID");
            this.TableName("BSTJITEM").Schema("orm");  
            this.Column(p => p.Code).ColumnName("Code");  
            this.Column(p => p.ZdyCode).ColumnName("ZdyCode");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.ItemUnit).ColumnName("ItemUnit");  
            this.Column(p => p.Sex).ColumnName("Sex");  
            this.Column(p => p.ItemPrice).ColumnName("ItemPrice");  
            this.Column(p => p.DefaultResult).ColumnName("DefaultResult");  
            this.Column(p => p.DataType).ColumnName("DataType");  
            this.Column(p => p.ReferType).ColumnName("ReferType");  
            this.Column(p => p.LimitHigh).ColumnName("LimitHigh");  
            this.Column(p => p.LimitLow).ColumnName("LimitLow");  
            this.Column(p => p.HigherTips).ColumnName("HigherTips");  
            this.Column(p => p.LowerTips).ColumnName("LowerTips");

            this.Column(p => p.VeryLowLimit).ColumnName("VERYLOWLIMIT");
            this.Column(p => p.VeryLowTips).ColumnName("VERYLOWTIPS");
            this.Column(p => p.VeryTopLimit).ColumnName("VERYTOPLIMIT");
            this.Column(p => p.VeryTopTips).ColumnName("VERYTOPTIPS");
            this.Column(p => p.LocationId).ColumnName("HospitalID");

            this.Column(p => p.MinValue).ColumnName("MinValue");  
            this.Column(p => p.MaxValue).ColumnName("MaxValue");  
            this.Column(p => p.ClassId).ColumnName("ClassId");  
            this.Column(p => p.IsGroup).ColumnName("IsGroup");  
            this.Column(p => p.Comments).ColumnName("Comments");  
            this.Column(p => p.GuideTips).ColumnName("GuideTips");  
            this.Column(p => p.LISCode).ColumnName("LISCode");  
            this.Column(p => p.PyCode).ColumnName("PyCode");  
            this.Column(p => p.WbCode).ColumnName("WbCode");  
            this.Column(p => p.ModiTime).ColumnName("ModiTime");  
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.TjLocationID).ColumnName("TjLocationID");
            this.Column(p => p.IsAutoOver).ColumnName("IsAutoOver");
            this.Column(p => p.VIPPrice).ColumnName("VIPPrice");
            this.Column(p => p.IsDiscounts).ColumnName("IsDiscounts");
            this.Column(p => p.EngDesc).ColumnName("EngDesc");
            this.Column(p => p.IsPrintName).ColumnName("ISPRINTNAME");
            this.Column(p => p.SourceId).ColumnName("SourceId");
            this.Column(p => p.TubeTypeId).ColumnName("TubeTypeId");
            this.Column(p => p.ItemInterface).ColumnName("ItemInterface");
            this.Column(p => p.SamlingType).ColumnName("SamlingType");
            this.Column(p => p.PrintTagType).ColumnName("PRINTTAGTYPE");
            this.Column(p => p.CKMachineID).ColumnName("CKMACHINEID");
            this.Column(p => p.CommonProblem).ColumnName("CommonProblem");
            this.Column(p => p.TestIllustration).ColumnName("TestIllustration");
            this.Column(p => p.Commentary).ColumnName("Commentary");
            this.Column(p => p.TestWay).ColumnName("TestWay"); 
            this.Column(p => p.CommonName).ColumnName("CommonName");
            this.Column(p => p.CommonNameId).ColumnName("CommonNameId");
            this.Column(p => p.MedicalCode).ColumnName("MedicalCode");
               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

