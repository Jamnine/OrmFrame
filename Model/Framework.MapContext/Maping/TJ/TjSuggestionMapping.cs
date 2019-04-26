
﻿using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 体检诊断建议 
    /// </summary>  
    public partial class TjSuggestionMapping: ClassMap<TjSuggestion>  
    {  
        /// <summary>  
        /// Stru  
        /// </summary>  
        public TjSuggestionMapping()  
        {  
            this.TableName("CKSUGGESTION").Schema("orm");  
            this.Column(p => p.Name).ColumnName("Name");  
            this.Column(p => p.DiseaseCode).ColumnName("DiseaseCode");  
            this.Column(p => p.TestTypeId).ColumnName("TESTTYPEID");  
            this.Column(p => p.Suggestion).ColumnName("Suggestion");  
            this.Column(p => p.Flag).ColumnName("Flag");  
            this.Column(p => p.IsCommonDisease).ColumnName("IsCommonDisease");  
            this.Column(p => p.IsImportantDisease).ColumnName("IsImportantDisease");  
            this.Column(p => p.IsNotify).ColumnName("IsNotify");  
            this.Column(p => p.PyCode).ColumnName("PyCode");  
            this.Column(p => p.WbCode).ColumnName("WbCode");  
            this.Column(p => p.ModiTime).ColumnName("ModiTime");  
            this.Column(p => p.ModiOperId).ColumnName("ModiOperId");  
            this.Column(p => p.OrderBy).ColumnName("OrderBy");  
            this.Column(p => p.IsActive).ColumnName("IsActive");
            this.Column(p => p.Complaint).ColumnName("Complaint");
            this.Column(p => p.PresentHistory).ColumnName("PresentHistory");
            this.Column(p => p.GUID).ColumnName("GUID");
            this.Id(T => T.GUID).DbGenerated();
            this.Ignore(p => p.IsModify);  
        }  
  
    }  
}  
  
  

