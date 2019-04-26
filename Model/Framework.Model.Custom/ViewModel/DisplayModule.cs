using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 显示模块
    /// </summary>
    [Serializable]
    public class DisplayModule
    {
        public string ID { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string MenuId { get; set; }

        /// <summary>
        /// 中文标签
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 实体名称（类名）
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Path类型样式
        /// </summary>
        public object PathStyle { get; set; }
        /// <summary>
        /// 快捷键名称
        /// </summary>
        public string ShortcutKeyName { get; set; }
        /// <summary>
        /// 帮助网页地址
        /// </summary>
        public string HelpAddress { get; set; }

        /// <summary>
        /// 是否是添加功能
        /// 0 不是 1 是
        /// </summary>
        public int IsAdd { get; set; }

        /// <summary>
        /// 累计点击次数
        /// </summary>
        public int CumulativeClicks { get; set; }

        private object _instance=null;
        /// <summary>
        /// 界面实例
        /// </summary>
        public object Instance { get {if(this._instance==null){
                 this._instance =  this.CreateElement(this.EntityName);
        }
        return this._instance;
        } }
        /// <summary>
        /// 创建界面实例委托
        /// </summary>
        public Func<string,object> CreateElement { private get; set; }

    }
}
