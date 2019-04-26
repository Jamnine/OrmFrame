using ELinq.Mapping.Fluent;
using ELinq;
using Orm;
using Orm.Model;

namespace Orm.MapContext
{
    public partial class ToothImageMapping : ClassMap<ToothImage>
    {
        /// <summary>
        /// 无参构造方法.
        /// </summary>
        public ToothImageMapping()
        {
            this.TableName("TOOTHIMAGE").Schema("orm");

            this.Column(p => p.ImageTypePath).ColumnName("IMAGETYPEPATH");
            this.Column(p => p.ToothCaseHistoryId).ColumnName("TOOTHCASEHISTORYID");
            this.Column(p => p.PatId).ColumnName("PatId");
            this.Column(p => p.MzRegId).ColumnName("MzRegId");
            this.Column(p => p.TjCode).ColumnName("TjCode");
            this.Column(p => p.TjLocationId).ColumnName("TjLocationId");

            this.Column(p => p.FileType).ColumnName("FileType");
            this.Column(p => p.OperTime).ColumnName("OperTime");
            this.Column(p => p.ImageName).ColumnName("ImageName");
            this.Column(p => p.FileWhere).ColumnName("FileWhere");
            this.Column(p => p.FollowId).ColumnName("FollowId");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
