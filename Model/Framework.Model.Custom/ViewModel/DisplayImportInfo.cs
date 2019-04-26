using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 显示重要信息
    /// </summary>
    [Serializable]
    public class DisplayImportInfo
    {
       /// <summary>
       /// 标题
       /// </summary>
        public string Title { get; set; }

       /// <summary>
       /// 描述
       /// </summary>
        public string Description { get; set; }

    }
}
