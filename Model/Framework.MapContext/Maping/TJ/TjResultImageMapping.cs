using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 体检结果图片
    /// </summary>
    public partial class TjResultImageMapping : ClassMap<TjResultImage> 
    {
        public TjResultImageMapping()
        {
            this.TableName("TJRESULTIMAGE").Schema("orm");
            this.Column(p => p.MzRegId).ColumnName("MZREGID");
            this.Column(p => p.PatID).ColumnName("PATID");
            this.Column(p => p.ImageTypePath).ColumnName("IMAGETYPEPATH");
            this.Column(p => p.TjLocationID).ColumnName("TJLOCATIONID");
            this.Column(p => p.Image).ColumnName("IMAGE");
            this.Column(p => p.RecipeDtlId).ColumnName("RecipeDtlId");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify);   
        }
    }
}
