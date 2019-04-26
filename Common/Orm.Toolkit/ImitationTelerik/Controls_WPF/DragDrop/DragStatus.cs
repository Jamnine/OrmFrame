namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
    /// <summary>
    /// 拖动/拖放操作的状态。Add ChenChunRu
    /// </summary>
    public enum DragStatus
    {
        /// <summary>
        /// 没有进行拖动或拖放操作。
        /// </summary>
        None, 

        /// <summary>
        /// 一个鼠标鼠标已经注册的元素,现在正在查询。
        /// A mouse down mouse has moved over a registered element, it is being queried now.
        /// </summary>
        DragQuery, 

        /// <summary>
        /// 拖动已经开始,但还没有拖放元素。
        /// Dragging has started, no drop zones have been found.
        /// </summary>
        DragInProgress, 

        /// <summary>
        /// 拖动/拖放过程成功,通知源。
        /// The drag/drop process is successful, notifying the source.
        /// </summary>
        DragComplete,

        /// <summary>
        /// 拖动/拖放已经被取消了。
        /// The drag/drop has been cancelled.
        /// </summary>
        DragCancel,
 
        /// <summary>
        /// 目的地是问是否可以拖放元素。
        /// The destination is asked whether the element can be dropped.
        /// </summary>
        DropDestinationQuery,

        /// <summary>
        /// 源被问及元素canb e拖放。
        /// The source is asked whether the element canb e dropped.
        /// </summary>
        DropSourceQuery,

        /// <summary>
        /// 它的拖放是由双方确认。
        /// The drop is acknowledged by both parties.
        /// </summary>
        DropPossible,

        /// <summary>
        /// 拖放是不可能由于一个拒绝的结果。
        /// The drop is not possible due to refusal of one of the partied.
        /// </summary>
        DropImpossible,

        /// <summary>
        /// 拖放操作已成功完成。
        /// The drop operation has completed successfully.
        /// </summary>
        DropComplete,

        /// <summary>
        /// 拖放操作已被取消。
        /// The drop operation has been cancelled.
        /// </summary>
        DropCancel
    }
}
