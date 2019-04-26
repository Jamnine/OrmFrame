using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	/// <summary>
    /// 一个保存当前拖动/拖放操作的信息的对象。Add ChenChunRu
	/// An object that holds information about the current drag/drop operation.
	/// </summary>
	/// <remarks>
	///     <para>
    ///         用于提供有关和自定义拖动/拖放操作的信息。
	///         Used for giving information about and customizing a drag/drop operation.
	///     </para>
	/// </remarks>
	public class DragDropOptions
	{
		/// <summary>
        /// 获取或设置在拖动/拖放操作中传输的数据对象。
		/// Gets or sets the data object that is transferred in the drag/drop operation.
		/// </summary>
		/// <remarks>
		///     <para>
        ///         该属性只能在拖动查询的拖动查询阶段中设置。
		///         The Payload can only be set during the DragQuery stage of DragQuery.
		///     </para>
		/// </remarks>
		public object Payload
		{
			get;
			set;
		}

		/// <summary>
        /// 获取已注册的源，允许拖动。
		/// Gets the source that has registered with AllowDrag. 
		/// </summary>
		public FrameworkElement Source
		{
			get;
			internal set;
		}

		/// <summary>
        /// 获取已注册的“允许”拖放的元素。
		/// Gets the element that has registered the AllowDrop.
		/// </summary>
		public FrameworkElement Destination
		{
			get;
			set;
		}


		/// <summary>
        /// 获取或设置拖动时将出现的箭头。
		/// Gets or sets the arrow that will appear during dragging.
		/// </summary>
		/// <remarks>
		///     <para>
        ///         在拖动查询阶段时，源提示只能改变。
		///         The SourceCue can only be changed during the DragQuery stage. 
		///     </para>
		/// </remarks>
		public ContentControl ArrowCue
		{
			get;
			set;
		}

		/// <summary>
        /// 获取或设置将在视觉上拖动的元素。
		/// Gets or sets the element that will be dragged visually.
		/// </summary>
		/// <remarks>
		///     <para>
        ///         在拖动查询阶段时，源提示只能改变。
		///         The SourceCue can only be changed during the DragQuery stage. 
		///     </para>
		/// </remarks>
		public object DragCue
		{
			get;
			set;
		}

		/// <summary>
        /// 获取鼠标第一次按下相对于根画布的点。
		/// Gets the point where the mouse was first pressed relative to the root canvas.
		/// </summary>
		public Point MouseClickPoint
		{
			get;
			internal set;
		}

		/// <summary>
		/// Gets the point where the mouse is relative to the root canvas.
		/// </summary>
		public Point CurrentDragPoint
		{
			get;
			internal set;
		}

        /// <summary>
        /// 获取鼠标相对于根画布的点。
        ///  Gets the point where the mouse is relative to the destination element.
        /// </summary>
        public Point RelativeDragPoint
        {
            get;
            internal set;
        }

		/// <summary>
        /// 获取拖动/拖放操作的当前状态。
		/// Gets the current status of the drag and drop operation.
		/// </summary>
		public DragStatus Status
		{
			get;
			internal set;
		}

		/// <summary>
        /// 获取一个集合，其视觉根源将参与拖动/拖放操作，但不是应用程序根目录视觉的后裔。
		/// Gets a collection with the visual roots what will participate in the drag/drop operation but are not descendants of the application root visual.
		/// </summary>
		/// <remarks>
		///     <para>
        ///         所有弹出窗口应该参与拖/放应在此集合中添加。
		///         All popups that should participate in the drag/drop should be added in this collection.
		///     </para>
		/// </remarks>
		public IList<UIElement> ParticipatingVisualRoots
		{
			get;
			internal set;
		}
        private bool _isStatus = false;
        public bool u_IsStatus
        {
            get
            {
                if (Status == DragStatus.DragQuery)
                {
                    _isStatus = true;
                }
                else
                {
                    _isStatus = false;
                }
                return _isStatus;
            }
            set { _isStatus = value; }
        }
    }
}
