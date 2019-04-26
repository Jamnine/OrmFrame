using ELinq.Mapping.Fluent;
using Orm.Model;

namespace Orm.MapContext
{
    /// <summary>  
    /// 版本文件
    /// </summary>  
    public partial class VersionFileMapping : ClassMap<VersionFile>
    {
        /// <summary>  
        /// Stru  
        /// </summary>  
        public VersionFileMapping()
        {
            this.TableName("VERSIONFILE").Schema("orm");
            this.Column(p => p.UpVersionId).ColumnName("UpVersionId");
            this.Column(p => p.FileName).ColumnName("FileName");
            this.Column(p => p.FileNames).ColumnName("FileNames");
            this.Column(p => p.FileSize).ColumnName("FileSize");
            this.Column(p => p.FileTime).ColumnName("FileTime");
            this.Column(p => p.FileContent).ColumnName("FileContent");
            this.Column(p => p.Memo).ColumnName("Memo");
            this.Column(p => p.IsZip).ColumnName("IsZip");
            this.Column(p => p.DownLoadLocation).ColumnName("DownLoadLocation");
             
            
            
            this.Id(t => t.GUID);  this.Ignore(p => p.IsModify); 
        }

    }
}


