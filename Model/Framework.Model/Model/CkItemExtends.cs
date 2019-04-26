

using System;
namespace Orm.Model
{
    /// <summary>
    /// 检验项目 - 实体类
    /// </summary> 
    public partial class CkItem  
    {
        /// <summary>
        /// 偏低提示
        /// </summary>
        public string LowerTips { get; set; }

        /// <summary>
        /// 偏高提示
        /// </summary>
        public string HigherTips { get; set; }

        /// <summary>
        /// 极低危提示
        /// </summary>
        public string VeryLowTips { get; set; }

        /// <summary>
        /// 极高危提示
        /// </summary>
        public string VeryTopTips { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Comments { get; set; }
        /// <summary>
        /// 是否组合项目
        /// </summary>
        public bool IsGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsPrintDetail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsAutoOver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GuideTips { get; set; }
       
        
    }  
}           


