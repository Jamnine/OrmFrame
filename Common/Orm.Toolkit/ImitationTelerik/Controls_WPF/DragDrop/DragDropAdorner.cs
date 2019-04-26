using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	/// <summary>
    /// 一个装饰器用于在拖动/拖放显示的视觉效果。Add CCR
	/// An adorner used for displaying visuals during DragDrop.
	/// </summary>
	internal class DragDropAdorner : Adorner, IDisposable
	{
		private VisualCollection visualChildren;
		private Panel dragPanel;

		/// <summary>
        /// DragDropAdorner类的初始化一个新的实例。
		/// Initializes a new instance of the DragDropAdorner class.
		/// </summary>
		/// <param name="adornedElement">The adorned element.</param>
		/// <param name="dragPanel">The drag panel.</param>
		public DragDropAdorner(UIElement adornedElement, Panel dragPanel)
			: base(adornedElement)
		{
			this.visualChildren = new VisualCollection(this);
			this.dragPanel = dragPanel;

			this.visualChildren.Add(dragPanel);
		}

		/// <summary>
        /// 获取此元素内的视觉子元素的数目。
		/// Gets the number of visual child elements within this element.
		/// </summary>
		/// <value></value>
		/// <returns>
        /// 这个元素的视觉子元素的数目。
		/// The number of visual child elements for this element.
		/// </returns>
		protected override int VisualChildrenCount 
		{ 
			get 
			{
				return this.visualChildren.Count; 
			} 
		}

		/// <summary>
        /// 执行应用定义的任务与释放，释放非托管资源，或复位。
		/// Performs application-defined tasks associated with freeing, 
		/// releasing, or resetting unmanaged resources.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification="There may be other things that need to be GC-ed.")]
		public void Dispose()
		{
			this.visualChildren.Clear();
		}

		/// <summary>
        /// 重写 <see cref="M:System.Windows.Media.Visual.GetVisualChild(System.Int32)"/> 并返回指定索引集合中的子元素的孩子。
		/// Overrides <see cref="M:System.Windows.Media.Visual.GetVisualChild(System.Int32)"/>, 
		/// and returns a child at the specified index from a collection of child elements.
		/// </summary>
        /// <param name="index">The zero-based index of the requested child element in the collection.集合中请求的子元素的零基索引。</param>
		/// <returns>
        /// 请求的子元素。这不应该返回空；如果所提供的索引是不在范围内，则抛出异常。
		/// The requested child element. This should not return null; if the provided index 
		/// is out of range, an exception is thrown.
		/// </returns>
		protected override Visual GetVisualChild(int index) 
		{
			return this.visualChildren[index]; 
		}

		/// <summary>
        /// 在派生类中重写时,子元素和位置决定了派生类的大小。
		/// When overridden in a derived class, positions child elements and determines a size for a 
		/// <see cref="T:System.Windows.FrameworkElement"/> derived class.
		/// </summary>
        /// 最后区域内的父级,这个元素应该使用安排本身和它的子级。
		/// <param name="finalSize">The final area within the parent that this element should use 
		/// to arrange itself and its children.</param>
        /// <returns>The actual size used.所使用的实际大小。</returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			// adornerWidth & adornerHeight are used for placement.
			double adornerWidth = this.DesiredSize.Width;
			double adornerHeight = this.DesiredSize.Height;

			this.dragPanel.Arrange(new Rect(0, 0, adornerWidth, adornerHeight));

			return finalSize;
		}
	}
}
