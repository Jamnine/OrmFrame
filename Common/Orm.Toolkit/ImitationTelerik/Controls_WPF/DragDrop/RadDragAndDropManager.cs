using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

using System.Windows.Threading;
using Orm.Toolkit.Telerik.Windows.Controls.Common;

using Orm.Toolkit.ImitationTelerik;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1064:ExceptionsShouldBePublic")]
	internal interface IWindow
	{
		bool IsOpen
		{
			get;
		}

		int Z
		{
			get;
		}
	}

	/// <summary>
    /// 一个管理类，管理对象之间的拖动/拖放操作。Add ChenChunRu
	/// A manager class that enables drag drop operations between objects.
	/// </summary>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "It may be decoupled later.")]
	public static class RadDragAndDropManager
	{
		/// <summary>
        /// 确定允许拖动附加属性。
		/// Identifies the AllowDrag attached property.
		/// </summary>
		public static readonly DependencyProperty AllowDragProperty = DependencyProperty.RegisterAttached("AllowDrag", typeof(bool), typeof(RadDragAndDropManager), new PropertyMetadata(false, OnAllowDragChanged));

		/// <summary>
        /// 确定允许拖放附加属性。
		/// Identifies the AllowDrop attached property.
		/// </summary>
		public static readonly DependencyProperty AllowDropProperty = DependencyProperty.RegisterAttached("AllowDrop", typeof(bool), typeof(RadDragAndDropManager), new PropertyMetadata(false, null));

		/// <summary>
        /// 确定拖动信息事件。
		/// Identifies the DragInfo event.
		/// </summary>
		public static readonly RoutedEvent DragInfoEvent = EventManager.RegisterRoutedEvent("DragInfo", RoutingStrategy.Bubble, typeof(EventHandler<DragDropEventArgs>), typeof(RadDragAndDropManager));

		/// <summary>
        /// 确定拖放信息事件。
		/// Identifies the DropInfo event.
		/// </summary>
		public static readonly RoutedEvent DropInfoEvent = EventManager.RegisterRoutedEvent("DropInfo", RoutingStrategy.Bubble, typeof(EventHandler<DragDropEventArgs>), typeof(RadDragAndDropManager));

		/// <summary>
        /// 确定拖动查询事件。
		/// Identifies the DragQuery event.
		/// </summary>
		public static readonly RoutedEvent DragQueryEvent = EventManager.RegisterRoutedEvent("DragQuery", RoutingStrategy.Bubble, typeof(EventHandler<DragDropQueryEventArgs>), typeof(RadDragAndDropManager));

		/// <summary>
        /// 确定拖放查询事件。
		/// Identifies the DragQuery event.
		/// </summary>
		public static readonly RoutedEvent DropQueryEvent = EventManager.RegisterRoutedEvent("DropQuery", RoutingStrategy.Bubble, typeof(EventHandler<DragDropQueryEventArgs>), typeof(RadDragAndDropManager));

		/// <summary>
        /// 确定布局更改附加属性时的可见性。
		/// Identifies the VisibilityDuringLayoutChange attached property.
		/// </summary>
		internal static readonly DependencyProperty HideDuringLayoutChangeProperty = DependencyProperty.RegisterAttached("HideDuringLayoutChange", typeof(bool), typeof(RadDragAndDropManager), new PropertyMetadata(false, HideDuringLayoutChangeHelper.OnHideDuringLayoutChangeChanged));

		private static WeakReference coverRectangle = new WeakReference(null);
		private static Grid CoverRectangle
		{
			get
			{
				return coverRectangle.Target as Grid;
			}
			set
			{
				coverRectangle = new WeakReference(value);
			}
		}

		private static void AddRootVisualHandlers(FrameworkElement root)
		{
			if (root != null)
			{
				root.KeyDown += new KeyEventHandler(OnRootVisualKeyDown);
				root.KeyUp += new KeyEventHandler(OnRootVisualKeyUp);
				root.AddHandler(UIElement.MouseLeftButtonUpEvent, new MouseButtonEventHandler(OnCoverRectangleMouseLeftButtonUp), true);

				root.AddHandler(UIElement.MouseMoveEvent, new MouseEventHandler(OnCoverRectangleMouseMove), true);

			}
		}

		private static void RemoveRootVisualHandlers(FrameworkElement root)
		{
			root.KeyDown -= OnRootVisualKeyDown;
			root.KeyUp -= OnRootVisualKeyUp;

			root.RemoveHandler(UIElement.MouseMoveEvent, new MouseEventHandler(OnCoverRectangleMouseMove));

			root.RemoveHandler(UIElement.MouseLeftButtonUpEvent, new MouseButtonEventHandler(OnCoverRectangleMouseLeftButtonUp));
		}

		private static WeakReference rootVisual = new WeakReference(null);
		//private static FrameworkElement rootVisual;
		private static FrameworkElement lastApprovedDestination;

		private static Point mouseClickPoint;
		private static Point relativeCLick;

        //当鼠标移动时，基于时间的自动滚动只会发生：
		// Time-based auto-scrolling will only take place if the mouse has not moved:
		private static IList<ScrollViewer> scrollViewersToAdjust;
		private static Point previousScrollAdjustPosition;
		private static DispatcherTimer scrollViewerScrollTimer;

		/// <summary>
		/// In WPF isMouseDown is used only for testing.
		/// </summary>
		private static bool isMouseDown;
		private static bool isInitialized;
		private static bool isDragCuePositioned;
		private static double dragStartThreshold = 4.0;

		private static List<UIElement> dropTargetsHelper = new List<UIElement>(40);
		private static WeakReference adorner = new WeakReference(null);
		private static DragDropAdorner Adorner
		{
			get
			{
				return adorner.Target as DragDropAdorner;
			}
			set
			{
				adorner = new WeakReference(value);
			}
		}
		private static bool isCancelling;

		private static FrameworkElement hostRootVisual;

		//internal static FrameworkElement RootVisual
		//{
		//    get
		//    {
		//        return rootVisual;
		//    }
		//    set
		//    {
		//        rootVisual = value;
		//    }
		//}

		/// <summary>
        /// 获取一个值，说明是否有一个拖动过程。
		/// Gets a value indicating whether there is a dragging in process.
		/// </summary>
		public static bool IsDragging
		{
			get;
			internal set;
		}

		/// <summary>
        /// 得到当前的拖动/拖放过程的状态。
		/// Gets the status of the current drag and drop process.
		/// </summary>
		public static DragDropOptions Options
		{
			get;
			private set;
		}

		/// <summary>
        /// 获取或设置一个值，指示是否应自动滚动的滚动视图将内容为视角。
		/// Gets or sets a value indicating whether the ScrollViews should automatically scroll to bring content into view.
		/// </summary>
		public static bool AutoBringIntoView
		{
			get;
			set;
		}

		/// <summary>
        /// 获取或设置箭头的最小长度。
		/// Gets or sets the minimun length of the arrow that needs to be reached before it is shown.
		/// </summary>
		public static double ArrowVisibilityMinimumThreshold
		{
			get;
			set;
		}

		/// <summary>
        /// 获取或设置用户需要在一个实际拖动操作开始前拖动一个对象的像素的距离。这可以防止鼠标按下附带的拖动。
		/// Gets or sets the distance in pixels that the user needs to drag an object
		/// before a real drag operation starts. This prevents incidental drag on mouse press.
		/// </summary>
		public static double DragStartThreshold
		{
			get
			{
				return dragStartThreshold;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value", "DragStartThreshold cannot be smaller than 0");
				}
				dragStartThreshold = value;
			}
		}

		internal static bool IsMouseDown
		{
			get
			{

				return Mouse.LeftButton == MouseButtonState.Pressed || isMouseDown;

			}
			set
			{
				isMouseDown = value;
			}
		}

		internal static FrameworkElement RootVisual
		{
			get
			{
				return rootVisual.Target as FrameworkElement;
			}
			set
			{
				if (rootVisual.Target != null && rootVisual.IsAlive)
				{
					RemoveRootVisualHandlers(rootVisual.Target as FrameworkElement);
				}

				rootVisual = new WeakReference(value);

				if (value != null)
				{
					AddRootVisualHandlers(value);
				}
			}
		}

		/// <summary>
        /// 获取允许拖动附加属性。
		/// Gets the AllowDrag attached property.
		/// </summary>
        /// <param name="obj">The object to get the property for.获取对象的属性。</param>
		public static bool GetAllowDrag(DependencyObject obj)
		{
			return (bool)obj.GetValue(AllowDragProperty);
		}

		/// <summary>
        /// 设置允许拖动附加属性。
		/// Sets the AllowDrag attached property.
		/// </summary>
		/// <param name="obj">The object to set the property to.</param>
		/// <param name="value">The value of the property.</param>
		public static void SetAllowDrag(DependencyObject obj, bool value)
		{
			obj.SetValue(AllowDragProperty, value);
		}

		/// <summary>
        /// 获取允许拖放附加属性。
		/// Gets the AllowDrop attached property.
		/// </summary>
		/// <param name="obj">The object to get the property for.</param>
		public static bool GetAllowDrop(DependencyObject obj)
		{
			return (bool)obj.GetValue(AllowDropProperty);
		}

		/// <summary>
        /// 设置允许拖放附加属性。
		/// Sets the AllowDrop attached property.
		/// </summary>
		/// <param name="obj">The object to set the property to.</param>
		/// <param name="value">The value of the property.</param>
		public static void SetAllowDrop(DependencyObject obj, bool value)
		{
			obj.SetValue(AllowDropProperty, value);
		}

		/// <summary>
        /// 基于拖动/拖放管理器的默认设置创建拖放视觉提示。
		/// Creates a drag/drop visual cue based on the default settings of the Drag/Drop manager.
		/// </summary>
		public static DragVisualCue GenerateVisualCue()
		{
			return GenerateVisualCue(null);
		}

		/// <summary>
        /// 基于拖动/拖放管理器的默认设置创建拖放视觉提示。
		/// Creates a drag/drop visual cue based on the default settings of the Drag/Drop manager.
		/// </summary>
        /// <param name="source">If provided, the properties of the visual cue will be set to match this element.如果提供，视觉提示的属性将被设置为匹配这个元素。</param>
        /// <returns>A new instance of the DragVisualCue class.拖动视觉提示类的一个新实例。</returns>
		public static DragVisualCue GenerateVisualCue(FrameworkElement source)
		{
			var result = new DragVisualCue();

			if (source != null)
			{
				result.Width = source.ActualWidth;
				result.Height = source.ActualHeight;
				result.MinWidth = source.MinWidth;
				result.MaxWidth = source.MaxWidth;
				result.MinHeight = source.MinHeight;
				result.MaxHeight = source.MaxHeight;
				result.Margin = source.Margin;
			}

			return result;
		}

		/// <summary>
        /// 产生一个箭头的内容控制，可用于作为箭头提示在拖放操作。
		/// Generates an arrow content control that can be used in as an arrow cue in the drag/drop operation.
		/// </summary>
        /// <returns>A new drag arrow cue element.一种新的拖动箭头提示元素。</returns>
		public static ContentControl GenerateArrowCue()
		{
			var dragArrowElement = new DragArrow();
			dragArrowElement.HorizontalAlignment = HorizontalAlignment.Left;
			dragArrowElement.VerticalAlignment = VerticalAlignment.Top;
			dragArrowElement.Height = 30;
			TransformGroup group = new TransformGroup();
			group.Children.Add(new ScaleTransform());
			group.Children.Add(new RotateTransform());
			group.Children.Add(new TranslateTransform());
			dragArrowElement.RenderTransform = group;
			dragArrowElement.Padding = new Thickness(30, 0, 30, 0);
			dragArrowElement.RenderTransformOrigin = new Point(0, 0.5);

			return dragArrowElement;
		}

		/// <summary>
        /// 为拖动查询路由事件添加一个处理程序。
		/// Adds a handler to for the DragQuery routed event.
		/// </summary>
        /// <param name="target">The element to add handler to.添加处理程序的元素。</param>
        /// <param name="handler">The handler for the event.事件处理程序。</param>
		public static void AddDragQueryHandler(DependencyObject target, EventHandler<DragDropQueryEventArgs> handler)
		{
			InitHostRoot(target);


			(target as UIElement).AddHandler(RadDragAndDropManager.DragQueryEvent, handler);
		}

		/// <summary>
        /// 删除拖动查询路由事件的处理程序。
		/// Removes a handler for the DragQuery routed event.
		/// </summary>
        /// <param name="target">The element to remove the handler from.删除该处理程序的元素。</param>
        /// <param name="handler">The handler for the event.事件处理程序。</param>
		public static void RemoveDragQueryHandler(DependencyObject target, EventHandler<DragDropQueryEventArgs> handler)
		{

			InitHostRoot(target);


			(target as UIElement).RemoveHandler(RadDragAndDropManager.DragQueryEvent, handler);
		}

		/// <summary>
        /// 将处理程序添加到拖放查询路由事件。
		/// Adds a handler to for the DropQuery routed event.
		/// </summary>
        /// <param name="target">The element to add handler to.添加处理程序的元素。</param>
        /// <param name="handler">The handler for the event.事件处理程序。</param>
		public static void AddDropQueryHandler(DependencyObject target, EventHandler<DragDropQueryEventArgs> handler)
		{

			InitHostRoot(target);


			(target as UIElement).AddHandler(RadDragAndDropManager.DropQueryEvent, handler);
		}

		/// <summary>
        /// 删除拖放查询路由事件的处理程序。
		/// Removes a handler for the DropQuery routed event.
		/// </summary>
		/// <param name="target">The element to remove the handler from.</param>
		/// <param name="handler">The handler for the event.</param>
		public static void RemoveDropQueryHandler(DependencyObject target, EventHandler<DragDropQueryEventArgs> handler)
		{

			InitHostRoot(target);

			(target as UIElement).RemoveHandler(RadDragAndDropManager.DropQueryEvent, handler);
		}

		/// <summary>
        /// 为拖动信息路由事件添加一个处理程序。
		/// Adds a handler to for the DragInfo routed event.
		/// </summary>
		/// <param name="target">The element to add handler to.</param>
		/// <param name="handler">The handler for the event.</param>
		public static void AddDragInfoHandler(DependencyObject target, EventHandler<DragDropEventArgs> handler)
		{

			InitHostRoot(target);

			(target as UIElement).AddHandler(RadDragAndDropManager.DragInfoEvent, handler);
		}


		private static void InitHostRoot(DependencyObject target)
		{
			var visualElement = target as System.Windows.Media.Visual;

			if (visualElement != null &&
				hostRootVisual == null &&
				Application.Current==null &&
				RadControl.IsInElementHost(target))
			{
				PresentationSource source = System.Windows.Interop.HwndSource.FromVisual(visualElement);
				hostRootVisual = source.RootVisual as FrameworkElement;
			}
		}


		/// <summary>
        /// 删除拖动信息路由事件的处理程序。
		/// Removes a handler for the DragInfo routed event.
		/// </summary>
		/// <param name="target">The element to remove the handler from.</param>
		/// <param name="handler">The handler for the event.</param>
		public static void RemoveDragInfoHandler(DependencyObject target, EventHandler<DragDropEventArgs> handler)
		{
			(target as UIElement).RemoveHandler(RadDragAndDropManager.DragInfoEvent, handler);
		}

		/// <summary>
		/// Adds a handler to for the DropInfo routed event.
		/// </summary>
		/// <param name="target">The element to add handler to.</param>
		/// <param name="handler">The handler for the event.</param>
		public static void AddDropInfoHandler(DependencyObject target, EventHandler<DragDropEventArgs> handler)
		{
			(target as UIElement).AddHandler(RadDragAndDropManager.DropInfoEvent, handler);
		}

		/// <summary>
        /// 删除拖放信息路由事件的处理程序。
		/// Removes a handler for the DropInfo routed event.
		/// </summary>
		/// <param name="target">The element to remove the handler from.</param>
		/// <param name="handler">The handler for the event.</param>
		public static void RemoveDropInfoHandler(DependencyObject target, EventHandler<DragDropEventArgs> handler)
		{
			(target as UIElement).RemoveHandler(RadDragAndDropManager.DropInfoEvent, handler);
		}

		/// <summary>
        /// 取消当前拖动操作。
		/// Cancels the current drag operation.
		/// </summary>
		public static void CancelDrag()
		{
			if (IsDragging)
			{
				CancelDragging();
			}
			else
			{
				ResetEverything();
			}
		}

		/// <summary>
        /// 启动拖动操作。拖动源参数不能为空。
		/// Starts a drag operation. The DragSource parameter cannot be null.
		/// </summary>
        /// <param name="dragSource">The element that is a source of the DragDrop.这是一个拖动/拖放元素的源。</param>
        /// <param name="payload">The payload of the DragDrop. Can be null.有效的拖动/拖放。可以空。</param>
        /// <param name="dragCue">The drag cue of the DragDrop. Can be null.虚的拖动/拖放提示。可以空。</param>
		public static void StartDrag(FrameworkElement dragSource, object payload, object dragCue)
		{
			if (!IsDragging)
			{
				if (dragSource == null)
				{
					throw new ArgumentNullException("dragSource");
				}
				if (!isInitialized)
				{
					Initialize(dragSource);
				}
				Options.Source = dragSource;
				Options.Payload = payload;
				Options.DragCue = dragCue;
				StartDragging();
			}
		}

		internal static void OnAllowDragChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			if (RadControl.IsInDesignMode)
			{
				return;
			}

			if (!isInitialized)
			{

				Initialize(sender as FrameworkElement);
			}

			UIElement element = sender as UIElement;

			if ((bool)e.NewValue)
			{
				element.LostMouseCapture += new MouseEventHandler(OnSourceLostMouseCapture);

				element.AddHandler(UIElement.PreviewMouseLeftButtonDownEvent,
					new MouseButtonEventHandler(OnTrackedPartMouseLeftButtonDown),
					true);

			}
			else
			{
				element.LostMouseCapture -= OnSourceLostMouseCapture;

				element.RemoveHandler(UIElement.PreviewMouseLeftButtonDownEvent,
					new MouseButtonEventHandler(OnTrackedPartMouseLeftButtonDown));

			}
		}

		internal static void OnCoverRectangleMouseLeftButtonUpInternal()
		{

			if (Options.Status != DragStatus.DropPossible)
			{
				if (IsDragging)
				{
					CancelDragging();
				}
				else
				{
					ResetEverything();
				}
			}
			else
			{
				OnDrop();
			}
		}

		/// <summary>
        /// 拖动开始时获取隐藏。
		/// Gets the hide when drag started.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <returns></returns>
		internal static bool GetHideDuringLayoutChange(DependencyObject obj)
		{
			return (bool)obj.GetValue(HideDuringLayoutChangeProperty);
		}

		/// <summary>
        /// 拖动开始时设置隐藏。
		/// Sets the hide when drag started.
		/// </summary>
		/// <param name="obj">The obj.</param>
		/// <param name="value">If set to <c>true</c> value.</param>
		internal static void SetHideDuringLayoutChange(DependencyObject obj, bool value)
		{
			obj.SetValue(HideDuringLayoutChangeProperty, value);
		}


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "GetPosition can throw unexpected errors")]
		internal static void OnTrackedPartMouseLeftButtonDownInternal(object sender, IMouseButtonEventArgs e)
		{

			if (IsDragging)
			{
				CancelDragging();
			}

			var element = sender as FrameworkElement;

			Options = GetDefaultOptions();

			Options.Source = element;
			try
			{
				// TODO: Review why the line below was cahnged to this:
				// mouseClickPoint = e.GetPosition(ApplicationHelper.GetRootVisual(sender as DependencyObject));
				// It may have something to do with browser zoom!
				mouseClickPoint = e.GetPosition(null);
				relativeCLick = e.GetPosition(e.OriginalSource as UIElement);
			}
			catch
			{
				ResetEverything();
			}
			Options.CurrentDragPoint = mouseClickPoint;

			if (element != null)
			{
				InitHostRoot(element);
			}

			FindRootVisual();

		}

		/// <summary>
        /// 初始化RadDragAndDropManager类的设置
		/// Initialize the RadDragAndDropManager settings.
		/// </summary>
		/// <param name="sourceElement">Instance of the element been involved in the grad, needed to resolve root element in specific cases (Element Hosts).</param>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "sourceElement")]
		private static void Initialize(FrameworkElement sourceElement)
		{
			isInitialized = true;

			ArrowVisibilityMinimumThreshold = 60;

			isDragCuePositioned = false;
			if (RadControl.IsInDesignMode)
			{
				return;
			}

			AutoBringIntoView = true;
			Options = GetDefaultOptions();


			if (sourceElement != null)
			{
				InitHostRoot(sourceElement);
			}


			FindRootVisual();


			scrollViewerScrollTimer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(0.02) };
			scrollViewerScrollTimer.Tick += new EventHandler(OnScrollViewerScrollTimerCompleted);
		}

		private static void OnScrollViewerScrollTimerCompleted(object sender, EventArgs e)
		{
			if (IsDragging
				&& ArePointsNear(previousScrollAdjustPosition, Options.CurrentDragPoint, 5)
				&& scrollViewersToAdjust != null)
			{
				foreach (var scrollViewer in scrollViewersToAdjust)
				{
					AdjustScrollViewer(scrollViewer, previousScrollAdjustPosition);
				}
			}
			else
			{
				scrollViewerScrollTimer.Stop();
				scrollViewersToAdjust = null;
			}
		}

		private static void OnRootVisualKeyUp(object sender, KeyEventArgs e)
		{
			if (IsDragging)
			{
				e.Handled = true;
			}
		}

		private static void OnRootVisualKeyDown(object sender, KeyEventArgs e)
		{
			if (IsDragging)
			{
				if (e.Key == Key.Escape)
				{
					CancelDragging();
				}
				e.Handled = true;
			}
		}

		private static void OnCoverRectangleMouseLeftButtonUp(object sender, EventArgs e)
		{
			OnCoverRectangleMouseLeftButtonUpInternal();
		}

		private static void RaiseDropInfo()
		{
			if (Options.Destination != null)
			{
				Options.Destination.RaiseEvent(new DragDropEventArgs(DropInfoEvent, Options.Destination, Options));
			}
		}

		private static void RaiseDragInfo()
		{
			if (Options.Source != null)
			{
				Options.Source.RaiseEvent(new DragDropEventArgs(DragInfoEvent, Options.Source, Options));
			}
		}

		private static bool? RaiseDragQuery()
		{
			if (Options.Source != null)
			{
				var args = new DragDropQueryEventArgs(DragQueryEvent, Options.Source, Options);
				Options.Source.RaiseEvent(args);
				return args.QueryResult;
			}
			return null;
		}

		private static bool? RaiseDropQuery()
		{
			if (Options.Destination != null)
			{
				var args = new DragDropQueryEventArgs(DropQueryEvent, Options.Destination, Options);
				Options.Destination.RaiseEvent(args);
				return args.QueryResult;
			}
			return null;
		}

		private static void OnDrop()
		{

            // Drag complete拖动完成
			Options.Status = DragStatus.DragComplete;
			RaiseDragInfo();

            // Drop complete拖放完成
			Options.Status = DragStatus.DropComplete;
			RaiseDropInfo();

            // Reset values:重置值：
			IsDragging = false;


			Options.Status = DragStatus.None;

			ResetEverything();
		}

		/// <summary>
		/// This method is not used at runtime, it replicates the OnCoverRectangleMouseMove. 
		/// This way MouseEvent wrappers are not created unnecessarily at runtime.
		/// </summary>
		/// <param name="e"></param>
		internal static void OnCoverRectangleMouseMoveInternal(IMouseEventArgs e)
		{
			if (IsMouseDown)
			{
				if (IsDragging)
				{
					OnRealDrag(e);
				}
				else
				{
					OnTrackedElementMouseMoveInternal(e);
				}
			}
		}

		private static void OnCoverRectangleMouseMove(object sender, MouseEventArgs e)
		{
			if (IsMouseDown)
			{
				if (IsDragging)
				{
					OnRealDrag(new TestableMouseEventArgs(e));
				}
				else
				{
					OnTrackedElementMouseMoveInternal(new TestableMouseEventArgs(e));
				}
			}
		}

		private static void ResetEverything()
		{

			if (CoverRectangle != null)
			{
				CoverRectangle.Children.Clear();
			}

			if (Options.ParticipatingVisualRoots != null)
			{
				foreach (var item in Options.ParticipatingVisualRoots)
				{
					if (item != null)
					{
						item.MouseMove -= OnCoverRectangleMouseMove;
					}
				}

				Options.ParticipatingVisualRoots = null;
			}


			if (Application.Current == null &&
					Options != null &&
					Options.Source != null &&
					RadControl.IsInElementHost(Options.Source))
			{
				RootVisual = null;
				hostRootVisual = null;
				isInitialized = false;
			}


			Options = GetDefaultOptions();

			lastApprovedDestination = null;

			isDragCuePositioned = false;

			ClosePopup();

		}



		private static void OnTrackedPartMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			OnTrackedPartMouseLeftButtonDownInternal(sender, new TestableMouseButtonEventArgs(e as MouseButtonEventArgs));
		}

		private static void OnTrackedElementMouseMoveInternal(IMouseEventArgs e)
		{

			if (!IsDragging && !isCancelling)
			{

				if (IsMouseDown)
				{
					if (!IsDragging)
					{
						TryStartDrag(e);
					}
				}
			}
		}

		private static DragDropOptions GetDefaultOptions()
		{
			return new DragDropOptions()
			{
			};
		}

		private static void TryStartDrag(IMouseEventArgs e)
		{
			if (!IsDragging)
			{
				isDragCuePositioned = false;

				Options.ParticipatingVisualRoots = new List<UIElement>(10);

				Options.CurrentDragPoint = e.GetPosition(null);

				if (ArePointsNear(Options.CurrentDragPoint, mouseClickPoint))
				{
					return;
				}

				Options.MouseClickPoint = mouseClickPoint;



				Options.ArrowCue = null;
				Options.DragCue = null;
				Options.Status = DragStatus.DragQuery;

				var sourceControl = Options.Source;

				var result = RaiseDragQuery();
				if (result == true)
				{

					if (Mouse.Captured != null)
					{
						Mouse.Captured.ReleaseMouseCapture();
					}
					else
					{
						StartDragging();
						PositionPopup(e);
					}

				}
			}
		}

		private static bool ArePointsNear(Point currentPoint, Point mouseClickPoint)
		{
			return ArePointsNear(currentPoint, mouseClickPoint, DragStartThreshold);
		}

		private static bool ArePointsNear(Point currentPoint, Point mouseClickPoint, double threshold)
		{
			return Math.Abs(currentPoint.X - mouseClickPoint.X) < threshold
				&& Math.Abs(currentPoint.Y - mouseClickPoint.Y) < threshold;
		}

		private static void StartDragging()
		{
			IsDragging = true;
			Options.Status = DragStatus.DragInProgress;
			RaiseDragInfo();


			if (Options.DragCue != null)
			{
				if (CoverRectangle == null)
				{
					CoverRectangle = new Grid();
					CoverRectangle.RenderTransform = new TranslateTransform();
					CoverRectangle.Background = new SolidColorBrush(Colors.Transparent);
					CoverRectangle.MouseMove += new MouseEventHandler(OnCoverRectangleMouseMove);
					CoverRectangle.MouseLeftButtonUp += new MouseButtonEventHandler(OnCoverRectangleMouseLeftButtonUp);
				}

				FrameworkElement visualDragCue = Options.DragCue as FrameworkElement;

				var dragCueHost = new ContentControl()
				{
					Content = Options.DragCue
				};
				dragCueHost.HorizontalAlignment = HorizontalAlignment.Left;
				dragCueHost.VerticalAlignment = VerticalAlignment.Top;

				CoverRectangle.Children.Add(dragCueHost);

				OpenPopup();

			}
		}


		private static void OpenPopup()
		{
			var window = RootVisual;//Window.GetWindow(Options.Source);

			var adornedElement = window.GetFirstDescendantOfType<Panel>() as FrameworkElement;

			if (adornedElement != null)
			{
				var layer = AdornerLayer.GetAdornerLayer(adornedElement);

				// We need an adorner layer.
				if (layer == null)
				{
					adornedElement = adornedElement.GetFirstDescendantOfType<ContentPresenter>();

					if (adornedElement != null)
					{
						// in case the WPF window is used with ResizeMode=CanResizeWithGrip
						layer = AdornerLayer.GetAdornerLayer(adornedElement);
					}

					if (layer == null)
					{
                        throw new InvalidOperationException(Strings.DragDropMissingAdornerLayer);
					}
				}

				if (Adorner != null)
				{
					var oldLayer = AdornerLayer.GetAdornerLayer(Adorner.AdornedElement);
					if (oldLayer != null)
					{
						oldLayer.Remove(Adorner);
					}

					Adorner.Dispose();
					Adorner = null;
				}

				if (Adorner == null)
				{
					Adorner = new DragDropAdorner(adornedElement, CoverRectangle);
					layer.Add(Adorner);
				}
			}

			CoverRectangle.Visibility = Visibility.Visible;
		}


		private static void FindRootVisual()
		{

			if (RootVisual != null)
			{
				FrameworkElement newRootVisual = null;
				if (Options.Source == null)
				{
					if (Application.Current != null
						&& Application.Current.CheckAccess()
						&& Application.Current.MainWindow != null)
					{
						newRootVisual = Application.Current.MainWindow.Content as FrameworkElement;
					}
				}
				else
				{
					newRootVisual = Window.GetWindow(Options.Source);
				}

				if (newRootVisual == null)
				{
					newRootVisual = hostRootVisual;
				}

				if (newRootVisual == RootVisual)
				{
					return;
				}

				RootVisual = null;
			}


			if (RootVisual == null)
			{

				if (Options.Source == null)
				{
					if (Application.Current != null
						&& Application.Current.CheckAccess()
						&& Application.Current.MainWindow != null)
					{
						RootVisual = Application.Current.MainWindow.Content as FrameworkElement;
					}
				}
				else
				{
					RootVisual = Window.GetWindow(Options.Source);
				}

				if (RootVisual == null)
				{
					RootVisual = hostRootVisual;
				}

			}
		}

		private static void OnSourceLostMouseCapture(object sender, MouseEventArgs e)
		{
			// The mouse has clearly been captured by a child of the source, so potentially mouse events 
			// have gone missing and the drag/drop should be cancelled.
			if (IsDragging)
			{
				CancelDragging();
			}

		}

		private static void CancelDragging()
		{

			isCancelling = true;
			try
			{

				IsDragging = false;

				NotifyPreviousApprovedDestination();


				ClosePopup();


				Options.Status = DragStatus.DragCancel;
				RaiseDragInfo();

				Options.Status = DragStatus.None;

				ResetEverything();

			}
			finally
			{
				isCancelling = false;
			}

		}


		private static void ClosePopup()
		{
			if (CoverRectangle != null)
			{
				CoverRectangle.Visibility = Visibility.Collapsed;
			}
		}


        private static TimeSpan afterComputingCurrentDestination;
	    private static DateTime afterDestination;
		private static void OnRealDrag(IMouseEventArgs e)
		{
			DragStatus originalStatus = Options.Status;

			Options.CurrentDragPoint = e.GetPosition(null);

			PositionPopup(e);
			PositionArrow();
			IList<FrameworkElement> dropZones;
			FindDropZones(out dropZones, ref scrollViewersToAdjust);

			bool isDropPossible = false;

		    var beforeDestination = Options.Destination;

			foreach (var zone in dropZones)
			{
				// ask source;
				Options.Status = DragStatus.DropDestinationQuery;
				Options.Destination = zone;
				Options.RelativeDragPoint = e.GetPosition(zone);

				var destinationApproval = RaiseDropQuery();
				bool? sourceApproval = null;

				if (destinationApproval == true)
				{
					Options.Status = DragStatus.DropSourceQuery;
					sourceApproval = RaiseDragQuery();
                }

                #region 判断拖放是否合法  --Add ChenChunRu  暂时注释
                

                //var intervalTime = Options.Source.GetType().GetProperty("Scheduler").GetValue(Options.Source, null).ReflectGetProperty("ActiveViewDefinition") as Orm.Toolkit.Telerik.Windows.Controls.DayViewDefinition;
                //if (intervalTime!=null)
                //{
                //    var starTime = Convert.ToDateTime(Options.Source.GetType().GetProperty("Scheduler").GetValue(Options.Source, null).ReflectGetProperty("VisibleRangeStart"));
                //    var endTimeTemp = TimeSpan.Parse(Convert.ToDateTime(Options.Source.GetType().GetProperty("Scheduler").GetValue(Options.Source, null).ReflectGetProperty("VisibleRangeEnd")).ToString("HH:mm"));
                //    var endTime = DateTime.MinValue.Add(endTimeTemp);
                //    var currentAppointmentTimeZones = Convert.ToDecimal(Options.DragCue.GetType().GetProperty("Content").GetValue(Options.DragCue, null).ReflectGetProperty("Appointment").ReflectGetProperty("TotalTime"));
                //    var currentCount = Math.Floor(currentAppointmentTimeZones/intervalTime.TimeSlotLength.Minutes);
                //    if (intervalTime.TimeSlotLength.Hours == 0)
                //    {
                //        TimeSpan afterComputingTime = new TimeSpan(0,intervalTime.TimeSlotLength.Minutes * Convert.ToInt32(currentCount),0); 
                        
                //        endTime = endTime.Add(-afterComputingTime);
                //        var currentDestinationTemp= TimeSpan.Parse(Convert.ToDateTime(Options.Destination.DataContext.GetType().GetProperty("Start").GetValue(Options.Destination.DataContext, null)).ToString("HH:mm"));
                //        var currentDestination = DateTime.MinValue.Add(currentDestinationTemp);
                //        var currentAppointmentStartTimeTemp = TimeSpan.Parse(Convert.ToDateTime(Options.DragCue.GetType().GetProperty("Content").GetValue(Options.DragCue, null).ReflectGetProperty("Appointment").ReflectGetProperty("Start")).ToString("HH:mm"));
                //        var currentAppointmentStartTime = DateTime.MinValue.Add(currentAppointmentStartTimeTemp);
                //        if (beforeDestination == null)
                //        {
                //            if (currentDestination > currentAppointmentStartTime || currentDestination < currentAppointmentStartTime)
                //            {
                //                afterComputingCurrentDestination = currentDestination - currentAppointmentStartTime;
                //                if (afterComputingCurrentDestination.Minutes==60)
                //                {
			                        
                //                }
                //            }
                //            else
                //            {
                //                afterComputingCurrentDestination=new TimeSpan();
                //            }
                //        }
                //        else if(afterDestination == currentDestination)
                //        {
                //            if (currentDestination == currentAppointmentStartTime)
                //            {
                //                afterComputingCurrentDestination = intervalTime.TimeSlotLength;
                //                if (afterComputingCurrentDestination.Minutes == 60)
                //                {

                //                }
                //            }
                //            else
                //            {
                //                afterComputingCurrentDestination = new TimeSpan();
                //            }
                //        }
                //        if (afterComputingCurrentDestination > new TimeSpan())
                //        {
                //            endTime=endTime.Add(afterComputingCurrentDestination);
                //        }

                //        if (currentDestination==DateTime.MinValue ||currentDestination >= endTime)
                //        {
                //            destinationApproval = false;
                //            isDropPossible = false;
                //        }
                //        afterDestination = currentDestination;
                //    }
                //}


                #endregion

                // Drop is ok.
				if (destinationApproval == true && sourceApproval == true)
				{
					Options.Status = DragStatus.DropPossible;

					RaiseDropInfo();
					RaiseDragInfo();
					OnDropPossible();

					isDropPossible = true;
					break;
				}
				else
				{
					// i.e. Drop denied
					Options.Status = DragStatus.DropImpossible;

					if (originalStatus != DragStatus.DropImpossible)
					{
						OnDropImpossible();
					}

					// If the drag/drop is explicitly denied, cancel further asking:
					if (destinationApproval == false || sourceApproval == false)
					{
						break;
					}
				}
			}

			foreach (var viewer in scrollViewersToAdjust)
			{
				AdjustScrollViewer(viewer, Options.CurrentDragPoint);
			}

			if (scrollViewersToAdjust.Any())
			{
				previousScrollAdjustPosition = Options.CurrentDragPoint;
				if (scrollViewerScrollTimer != null)
				{
					scrollViewerScrollTimer.Start();
				}
			}
			else
			{
				scrollViewerScrollTimer.Stop();
			}

			if (!isDropPossible)
			{
				OnDropImpossible();
			}
		}

		private static void AdjustScrollViewer(ScrollViewer viewer, Point currentPoint)
		{
			var p = currentPoint;

			var visual = viewer.TransformToVisual(RootVisual);
			var topLeft = visual.Transform(new Point(0, 0));
			var relative = new Point(p.X - topLeft.X, p.Y - topLeft.Y);

			if (relative.Y > 0 && relative.Y < 40)
			{
				viewer.ScrollToVerticalOffset(viewer.VerticalOffset - (20 * ((40 - relative.Y) / 40)));
			}

			if (relative.Y > viewer.ActualHeight - 40 && relative.Y < viewer.ActualHeight)
			{
				viewer.ScrollToVerticalOffset(viewer.VerticalOffset + (20 * ((40 - (viewer.ActualHeight - relative.Y)) / 40)));
			}

			if (relative.X > 0 && relative.X < 40)
			{
				viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset - (20 * ((40 - relative.X) / 40)));
			}

			if (relative.X > viewer.ActualWidth - 40 && relative.X < viewer.ActualWidth)
			{
				viewer.ScrollToHorizontalOffset(viewer.HorizontalOffset + (20 * ((40 - (viewer.ActualWidth - relative.X)) / 40)));
			}
		}

		private static void OnDropPossible()
		{
			// Notify previous drag container:
			if (Options.Destination != lastApprovedDestination && lastApprovedDestination != null)
			{
				NotifyPreviousApprovedDestination();
			}


			lastApprovedDestination = Options.Destination;

		}

		private static void NotifyPreviousApprovedDestination()
		{
			if (lastApprovedDestination != null)
			{
				Options.Status = DragStatus.DropImpossible;
				var originalDestination = Options.Destination;
				var originalStatus = Options.Status;

				Options.Destination = lastApprovedDestination;

				RaiseDropInfo();
				RaiseDragInfo();

				Options.Destination = originalDestination;

				if (originalDestination != null)
				{
					Options.Status = originalStatus;
					RaiseDropInfo();
				}

				lastApprovedDestination = null;
			}
		}

		private static void OnDropImpossible()
		{
			NotifyPreviousApprovedDestination();
		}

		private static void FindDropZones(out IList<FrameworkElement> dropZones, ref IList<ScrollViewer> scrollViewers)
		{
			var elements = new List<UIElement>(100);


			// Include windows in the zone search:
			if (Options.ParticipatingVisualRoots != null)
			{
				foreach (var root in Options.ParticipatingVisualRoots)
				{
					VisualTreeHelper.HitTest(RootVisual,
						null,
						el =>
						{
							AddHitTestToDropZones(el);
							return HitTestResultBehavior.Continue;
						},
						new PointHitTestParameters(Options.CurrentDragPoint));

					elements.AddRange(dropTargetsHelper);
					dropTargetsHelper.Clear();
				}
			}

			VisualTreeHelper.HitTest(RootVisual as Visual,
				null,
				el =>
				{
					AddHitTestToDropZones(el);
					return HitTestResultBehavior.Continue;
				},
				new PointHitTestParameters(Options.CurrentDragPoint));

			foreach (var item in dropTargetsHelper)
			{
				if (!elements.Contains(item) && item != null)
				{
					elements.Add(item);
				}
				foreach (var ancestor in item.GetAncestors<UIElement>())
				{
					if (!elements.Contains(ancestor) && ancestor != null)
					{
						elements.Add(ancestor);
					}
				}
			}
			dropTargetsHelper.Clear();

			var results = new List<FrameworkElement>(4);
			scrollViewers = new List<ScrollViewer>(3);

			foreach (var element in elements)
			{
				var allowDrop = GetAllowDrop(element);
				if (allowDrop)
				{
					results.Add(element as FrameworkElement);
				}
				ScrollViewer viewer = element as ScrollViewer;
				if (AutoBringIntoView && viewer != null)
				{
					scrollViewers.Add(viewer);
				}
				if (element.GetType().Name == "RadWindow")
				{
					break;
				}
			}
			dropZones = results;
		}

		private static void AddHitTestToDropZones(HitTestResult hitTest)
		{
			var frameworkElement = hitTest.VisualHit as FrameworkElement;
			if (frameworkElement != null && frameworkElement.IsHitTestVisible)
			{
				dropTargetsHelper.Add(frameworkElement);
			}
		}

		private static void PositionArrow()
		{
			if (Options.ArrowCue != null)
			{
				var dragArrowElement = Options.ArrowCue;

				if (!CoverRectangle.Children.Contains(dragArrowElement))
				{
					CoverRectangle.Children.Add(dragArrowElement);
				}

				// Distance:
				var horizontalDif = mouseClickPoint.X - Options.CurrentDragPoint.X;
				var verticalDif = mouseClickPoint.Y - Options.CurrentDragPoint.Y;
				var distance = Math.Sqrt((horizontalDif * horizontalDif) + (verticalDif * verticalDif));

				if (distance > ArrowVisibilityMinimumThreshold)
				{
					TransformGroup group = dragArrowElement.RenderTransform as TransformGroup;
					ScaleTransform scale = group.Children[0] as ScaleTransform;
					RotateTransform rotate = group.Children[1] as RotateTransform;
					TranslateTransform translate = group.Children[2] as TranslateTransform;

					translate.X = mouseClickPoint.X;
					translate.Y = mouseClickPoint.Y - 15;

					dragArrowElement.Width = distance;

					if (horizontalDif != 0)
					{
						rotate.Angle = Math.Atan(verticalDif / horizontalDif) * 180 / Math.PI;
					}
					else
					{
						rotate.Angle = verticalDif < 0 ? 90 : -90;
					}

					if (horizontalDif > 0)
					{
						rotate.Angle += 180;
						scale.ScaleY = -1;
					}
					else
					{
						scale.ScaleY = 1;
					}

					dragArrowElement.Visibility = Visibility.Visible;
				}
				else
				{
					dragArrowElement.Visibility = Visibility.Collapsed;
				}
			}
		}

		private static void PositionPopup(IMouseEventArgs e)
		{

			if (CoverRectangle == null || CoverRectangle.Children.Count == 0)
			{
				return;
			}
			var element = CoverRectangle.Children[0] as FrameworkElement;


			if (!isDragCuePositioned && element.ActualHeight != 0 && element.ActualWidth != 0)
			{
				isDragCuePositioned = true;
				element.Opacity = 1;

				var position = e.GetPosition(element);

				if (position.X < 0 || position.X > element.ActualWidth)
				{
					relativeCLick.X = element.ActualWidth / 2;
				}

				if (position.Y < 0 || position.Y > element.ActualHeight)
				{
					relativeCLick.Y = element.ActualHeight / 2;
				}
			}

			var renderTransform = element.RenderTransform as TranslateTransform;
			if (renderTransform == null)
			{
				renderTransform = new TranslateTransform();
				element.RenderTransform = renderTransform;
			}

			renderTransform.Y = Options.CurrentDragPoint.Y - relativeCLick.Y;
			renderTransform.X = Options.CurrentDragPoint.X - relativeCLick.X;
		}

	}
}

