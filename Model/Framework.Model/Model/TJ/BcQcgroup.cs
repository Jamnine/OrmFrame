using System;

namespace Orm.Model
{
    /// <summary>  
    /// 标准样品
    /// </summary>  
    [Serializable]

    public partial class BcQcgroup : BaseModel
    {
        private string _qcgroupName = String.Empty;
        /// <summary>  
        /// 质控组名称  
        /// </summary>  
        [Collumn(HeaderName = "组合名称", RelatedTableType = null, Length = 50)]
        public string QcgroupName
        {
            get { return _qcgroupName; }
            set { _qcgroupName = value; }
        }
    }
}
