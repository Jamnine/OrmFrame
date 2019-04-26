using System.Windows;
using System;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	/// <summary>
    /// 用于各种拖动和拖放事件参数和降相关事件。Add ChenChunRu
	/// The event args used for various drag and drop related events.
	/// </summary>
	public class DragDropQueryEventArgs : DragDropEventArgs
	{
		/// <summary>
        /// 初始化类的新实例的dragdropqueryeventargs。
		/// Initializes a new instance of the DragDropQueryEventArgs class.
		/// </summary>
		/// <param name="routedEvent">
        /// 路由事件的routedeventargs这类实例标识符。
		/// The routed event identifier for this instance of the RoutedEventArgs class.
		/// </param>
		/// <param name="source">
        /// 在处理事件时将报告的另一个源程序。
        /// 这个预填充源属性。
		/// An alternate source that will be reported when the event is handled. 
		/// This pre-populates the Source property.
		/// </param>
        /// <param name="options">The drag event options.拖动事件选项。</param>
		public DragDropQueryEventArgs(RoutedEvent routedEvent, object source, DragDropOptions options)
			: base(routedEvent, source, options)
		{
			Options = options;
		}

		/// <summary>
        /// 获取或设置的查询结果。这个结果在denies拖放或行动的过程。
		/// Gets or sets the result of the query. This result allows or denies actions in the drag drop process.
		/// </summary>
		public bool? QueryResult
		{
			get;
			set;
		}

		/// <summary>
        /// 在派生类中被重写时，提供了一种方法，在一个特定类型的方法调用事件处理程序，可以实现提高效率的基础。
		/// When overridden in a derived class, provides a way to invoke event handlers in a type-specific way, which can increase efficiency over the base implementation.
		/// </summary>
        /// <param name="genericHandler">The generic handler / delegate implementation to be invoked.被调用的泛型处理程序/委派实现。</param>
        /// <param name="genericTarget">The target on which the provided handler should be invoked.应调用所提供的处理程序的目标。</param>
		protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget)
		{
			(genericHandler as EventHandler<DragDropQueryEventArgs>)(genericTarget, this);
		}
	}
}