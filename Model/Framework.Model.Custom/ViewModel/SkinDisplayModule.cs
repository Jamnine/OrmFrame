using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 皮肤展示模块
    /// </summary>
    [Serializable]
    public partial class SkinDisplayModule
    {
        /// <summary>
        /// 皮肤
        /// </summary>
        public object Skin { get; set; }

        private string _fileAddress = string.Empty;
        /// <summary>
        /// 文件地址
        /// </summary>
        public string FileAddress { get { return this._fileAddress; } set { this._fileAddress = value; } }

        /// <summary>
        /// 可删除 默认为False 不可删除
        /// </summary>
        public bool CanRemoved { get; set; }

        private string _skinTitle = string.Empty;
        /// <summary>
        /// 皮肤标题 
        /// </summary>
        public string SkinTitle { get { return this._skinTitle; } set { this._skinTitle = value; } }

        /// <summary>
        /// 使用人数
        /// </summary>
        public int UseNumber { get; set; }

        private string _author = string.Empty;
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get { return this._author; } set { this._author = value; } }

        /// <summary>
        /// 比如 0 正常 1 默认  2 新的 3 热门
        /// </summary>
        public int UseState { get; set; }

    }
}
