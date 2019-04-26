using System;

namespace Orm.Model
{
    /// <summary>  
    /// 更新版本sql脚本
    /// </summary>  
    [Serializable]

    public class UpdateVersionSqlScript : BaseModel
    {

        public virtual int ID { get; set; }
        /// <summary>
        /// 更新版本id
        /// </summary>
        public int UpVersionId { get; set; }

        /// <summary>
        /// sql脚本
        /// </summary>
        public string SQLScript{ get; set; }

        /// <summary>
        /// 更新排序
        /// </summary>
        public int UpdateOrderBy { get; set; }
    }
}
 