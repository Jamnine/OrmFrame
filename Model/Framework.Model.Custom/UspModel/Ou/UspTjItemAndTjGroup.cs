using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 自定义Model类，用于问诊就诊，查询体检项目列表和体检项目明细列表
    /// </summary>
    [Serializable]
    public class UspTjItemAndTjGroup
    {
        public UspTjItemAndTjGroup()
        {
            Items = new List<BsItem>();
            TjItems = new List<BsTjItem>();
        }
        
        /// <summary>
        /// 项目集合
        /// </summary>
        public List<BsItem> Items { get; set; }

        /// <summary>
        /// 体检项目集合
        /// </summary>
        public List<BsTjItem> TjItems { get; set; }
    }
}
