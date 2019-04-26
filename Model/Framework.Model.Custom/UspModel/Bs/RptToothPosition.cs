using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 工作表(牙齿)
    /// </summary>
    [Serializable]
   
    public partial class RptToothPosition:BaseModel{
         
        /// <summary>
        /// 左上牙位
        /// </summary>
        public string ToothPositionLT { get; set; }
        /// <summary>
        /// 右上牙位
        /// </summary>
        public string ToothPositionRT { get; set; }
        /// <summary>
        /// 左下牙位
        /// </summary>
        public string ToothPositionLB { get; set; }
        /// <summary>
        /// 右下牙位
        /// </summary>
        public string ToothPositionRB { get; set; }
        /// <summary>
        /// 显示内容 如检查、诊断的内容等等
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 来源 如检查、诊断
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 是否洗牙
        /// </summary>
        public bool IsClearTooths { get; set; }

        /// <summary>
        /// 所有牙位，用于打印报表
        /// </summary>
        public string ToothPosition { get; set; }

    }
}



