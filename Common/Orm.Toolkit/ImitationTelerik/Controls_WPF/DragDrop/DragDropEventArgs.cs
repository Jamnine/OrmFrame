using System;
using System.Linq;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	/// <summary>
    /// 用于各种拖动/拖放事件参数和降相关事件。Add CCR
	/// The event args used for various drag and drop related events.
	/// </summary>
	public class DragDropEventArgs : Telerik.Windows.RadRoutedEventArgs
	{
		/// <summary>
        /// DragDropEventArgs类的初始化一个新的实例。
		/// Initializes a new instance of the DragDropEventArgs class.
		/// </summary>
		/// <param name="routedEvent">
        /// 路由事件标识符RoutedEventArgs类的实例。
		/// The routed event identifier for this instance of the RoutedEventArgs class.
		/// </param>
		/// <param name="source">
        /// 在处理事件时将报告的另一个源程序。
        /// 这个预填充源属性。
		/// An alternate source that will be reported when the event is handled. 
		/// This pre-populates the Source property.
		/// </param>
        /// <param name="options">The drag event options.拖动事件选项。</param>
		public DragDropEventArgs(RoutedEvent routedEvent, object source, DragDropOptions options)
			: base(routedEvent, source)
		{
			this.Options = options;
		}

		/// <summary>
        /// 获取此拖动/拖放事件的拖放信息。
		/// Gets the drag drop information about this drag drop event.
		/// </summary>
		public DragDropOptions Options
		{
			get;
			internal set;
		}

		/// <summary>
        /// 在派生类中被重写时，提供了一种方法，在一个特定类型的方法调用事件处理程序，可以实现提高效率的基础。
		/// When overridden in a derived class, provides a way to invoke event handlers in a type-specific way, which can increase efficiency over the base implementation.
		/// </summary>
        /// <param name="genericHandler">The generic handler / delegate implementation to be invoked.被调用的泛型处理程序/委派实现。</param>
        /// <param name="genericTarget">The target on which the provided handler should be invoked.应调用所提供的处理程序的目标。</param>
		protected override void InvokeEventHandler(System.Delegate genericHandler, object genericTarget)
		{
			(genericHandler as EventHandler<DragDropEventArgs>)(genericTarget, this);
		}

        /// <summary>
        /// 返回最顶层的元素的在dragpoint型坐标。
        /// Returns the top-most element of the given type 
        /// at the DragPoint coordinates.
        /// </summary>
        /// <typeparam name="T">The type of the element to be returned.返回元素的类型。</typeparam>
        public T GetElement<T>(System.Windows.Point dragPoint) where T : System.Windows.FrameworkElement
        {
            // 注意：这不是要工作在WinForms！你可以使用扩展方法，将发现根视觉相对第一个参数（这个）。
			// NOTE: This is not going to work in WinForms! You could use the extension method that will find to root visual 
			// relatively to the first argument (this).
            return VisualTreeHelperExtensions.GetElementsInScreenCoordinates<T>(dragPoint).FirstOrDefault();
        }
	}
}