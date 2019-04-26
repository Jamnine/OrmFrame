using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    ///  流水号配置表
    /// </summary>  
    public partial class SysSequenceConfigMapping : ClassMap<SysSequenceConfig>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public SysSequenceConfigMapping()
        {
            this.TableName("SYSSEQUENCECONFIG").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.SequenceName).ColumnName("SequenceName");
            this.Column(p => p.SequenceDesc).ColumnName("SequenceDesc");
            this.Column(p => p.SequenceLen).ColumnName("SequenceLen");
            this.Column(p => p.ResetType).ColumnName("ResetType");
            this.Column(p => p.Separator).ColumnName("Separator");
            this.Column(p => p.Prefix).ColumnName("Prefix");
            this.Column(p => p.DateFormat).ColumnName("DateFormat");
            this.Column(p => p.CurrentValue).ColumnName("CurrentValue");
            this.Column(p => p.InitialValue).ColumnName("InitialValue");
            this.Column(p => p.Step).ColumnName("Step");
            this.Column(p => p.CreatedDate).ColumnName("CreatedDate");
            this.Column(p => p.LastUpdatedDate).ColumnName("LastUpdatedDate");
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.UpdateControlID).ColumnName("UpdateControlID");
            this.Column(p => p.HospitalId).ColumnName("HospitalId");
             
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}



