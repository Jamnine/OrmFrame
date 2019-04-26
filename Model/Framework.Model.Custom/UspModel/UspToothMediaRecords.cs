using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 牙齿信息记录集合
    /// </summary>
    [Serializable]
    public class UspToothMediaRecords : BaseModel
    {
      
        public UspToothMediaRecords()  
        {
        }

        /// <summary>
        /// 图片集合
        /// </summary>
        public ObservableCollection<ToothMediaSource> LstToothImageSource { get; set; }

        /// <summary>
        /// 录音集合
        /// </summary>
        public ObservableCollection<ToothMediaSource> LstToothVoiceSource { get; set; }

        [Serializable]
        /// <summary>
        /// 图片显示源
        /// </summary>
        public class ToothMediaSource
        {
            /// <summary>
            /// ID
            /// </summary>
            public string GuId { get; set; }

            public BitmapImage BitmapImageSource { get; set; }
            //public DateTime ToothCaseHistoryTime { get; set; }

            /// <summary>
            /// 图片路径
            /// </summary>
            public string ImgPath { get; set; }

            /// <summary>
            /// 文件类型 Image:1 Voice:2
            /// </summary>
            public string FileType { get; set; }
        }
    }
}
