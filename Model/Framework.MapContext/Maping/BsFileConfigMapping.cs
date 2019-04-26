using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>
    /// 文件配置表
    /// </summary>
    public class BsFileConfigMapping : ClassMap<BsFileConfig>
    {
        /// <summary>
        /// 文件配置表
        /// </summary>
        public BsFileConfigMapping()
        {
            this.TableName("BsFileConfig").Schema("orm");

            this.Column(p => p.GUID).ColumnName("GUID");

            this.Column(p => p.LinkType).ColumnName("LinkType");

            this.Column(p => p.FilePath).ColumnName("FilePath");

            this.Column(p => p.ServerPath).ColumnName("ServerPath");

            this.Column(p => p.UserName).ColumnName("UserName");

            this.Column(p => p.UserPassword).ColumnName("UserPassword");

            this.Column(p => p.IsActive).ColumnName("IsActive");

            this.Column(p => p.HospitalId).ColumnName("HospitalID");

             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }
    }
}
