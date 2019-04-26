using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
    /// <summary>
    /// 一个辅助类，在拖放操作中充当视觉提示。Add ChenChunRu
    /// A helper class, that serves as a visual cue during drag and drop operations.
    /// </summary>
    public class DragVisualCue : ContentControl
    {
        /// <summary>
        /// 初始化类的新实例的dragvisualcue。
        /// Initializes a new instance of the DragVisualCue class.
        /// </summary>
        public DragVisualCue()
        {
            DefaultStyleKey = typeof(DragVisualCue);
        }
    }
}
