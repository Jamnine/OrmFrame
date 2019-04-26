using ELinq.Mapping.Fluent;  
using ELinq;  
using Orm;  
using Orm.Model;  
  
namespace Orm.MapContext  
{
    /// <summary>  
    /// 体检记录 
    /// </summary>  
    public partial class TjItemRecordMapping: ClassMap<TjItemRecord>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjItemRecordMapping()  
        {  
            this.TableName("TJITEMRECORD").Schema("orm");  
            this.Column(p => p.MzRegId).ColumnName("MzRegId");  
            this.Column(p => p.TjItemCode).ColumnName("TjItemCode");
            this.Column(p => p.GroupItemCode).ColumnName("GroupItemCode");  
            this.Column(p => p.TjResult).ColumnName("TjResult");
            this.Column(p => p.Describe).ColumnName("Describe");
            this.Column(p => p.IsAbNormal).ColumnName("IsAbNormal");  
            this.Column(p => p.AbnormalTips).ColumnName("AbnormalTips");  
            this.Column(p => p.IsGroup).ColumnName("IsGroup");  
            this.Column(p => p.DoctorId).ColumnName("DoctorId");  
            this.Column(p => p.TjLocationID).ColumnName("TjLocationID");  
            this.Column(p => p.IsCharge).ColumnName("IsCharge");  
            this.Column(p => p.IsOver).ColumnName("IsOver");  
            this.Column(p => p.OperId).ColumnName("OperId");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.PatID).ColumnName("PatID");
            this.Column(p => p.RecipeDtlId).ColumnName("RecipeDtlId");
            this.Column(p => p.ItemId).ColumnName("ItemId");
            this.Column(p => p.ItemInterface).ColumnName("ItemInterface");
            this.Column(p => p.Commentary).ColumnName("COMMENTARY");
            this.Column(p => p.SourceId).ColumnName("SOURCEID");
            this.Column(p => p.Properties).ColumnName("PROPERTIES");
            this.Column(p => p.SampleNum).ColumnName("SampleNum");
            this.Column(p => p.QCstandId).ColumnName("QCstandId");
            this.Column(p => p.CommonProblem).ColumnName("COMMONPROBLEM");
            this.Column(p => p.TestIllustration).ColumnName("TESTILLUSTRATION");
            this.Column(p => p.CKMId).ColumnName("CKMId");
            this.Column(p => p.SendStatus).ColumnName("SendStatus");
            this.Column(p => p.QCReagentlot).ColumnName("QCReagentlot");
            this.Column(p => p.IsApproval).ColumnName("IsApproval");
            this.Column(p => p.TjResultCopy).ColumnName("TjResultCopy");
            this.Column(p => p.ItemName).ColumnName("ItemName");
            this.Column(p => p.ApprovalTime).ColumnName("ApprovalTime");
            this.Column(p => p.ReferLow).ColumnName("ReferLow");
            this.Column(p => p.ReferTop).ColumnName("ReferTop");

               
              
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }  
  
    }  
}  
  
  

