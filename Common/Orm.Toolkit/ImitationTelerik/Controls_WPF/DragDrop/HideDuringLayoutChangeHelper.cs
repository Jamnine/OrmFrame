using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls.DragDrop
{
	internal class HideDuringLayoutChangeHelper
	{
		private static Dictionary<FrameworkElement, HideDuringLayoutChangeHelper> hookedElements
			= new Dictionary<FrameworkElement, HideDuringLayoutChangeHelper>();

		private Visibility lastVisibility;

		private IEnumerable<INotifyLayoutChange> Parents { get; set; }
		private FrameworkElement Element { get; set; }

		internal static void OnHideDuringLayoutChangeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var element = d as FrameworkElement;
			var newValue = (bool)e.NewValue;
			if (element != null)
			{
				if (newValue)
				{
					Attach(element);
				}
				else
				{
					Detach(element);
				}
			}
		}

		private static void Detach(FrameworkElement element)
		{
			var helper = hookedElements[element];

			element.Loaded -= helper.OnElementLoaded;
			helper.DetachEvents();

			hookedElements.Remove(element);
		}

		private static void Attach(FrameworkElement element)
		{
			var helper = new HideDuringLayoutChangeHelper
				{
					Parents = INotifyLayoutChangeParents(element),
					Element = element
				};

			hookedElements.Add(element, helper);

			helper.AttachEvents();
			element.Loaded += helper.OnElementLoaded;
		}

		private static IEnumerable<INotifyLayoutChange> INotifyLayoutChangeParents(UIElement element)
		{
			if (element != null)
			{
				DependencyObject parent = VisualTreeHelper.GetParent(element);

				while (parent != null)
				{
					if (parent is INotifyLayoutChange)
					{
						yield return (INotifyLayoutChange)parent;
					}
					parent = VisualTreeHelper.GetParent(parent);
				}
			}
		}

		private void AttachEvents()
		{
			foreach (var p in this.Parents)
			{
				p.LayoutChangeStarted += this.LayoutChangeStarted;
				p.LayoutChangeEnded += this.LayoutChangeEnded;
			}
		}

		private void DetachEvents()
		{
			foreach (var p in this.Parents)
			{
				p.LayoutChangeStarted -= this.LayoutChangeStarted;
				p.LayoutChangeEnded -= this.LayoutChangeEnded;
			}
		}

		private void OnElementLoaded(object sender, EventArgs args)
		{
			this.DetachEvents();
			this.Parents = INotifyLayoutChangeParents(this.Element);
			this.AttachEvents();

			if (this.Parents.Any(p => p.IsLayoutChanging))
			{
				this.lastVisibility = this.Element.Visibility;
				this.Element.Visibility = Visibility.Collapsed;
			}
		}

		private void LayoutChangeStarted(object sender, EventArgs args)
		{
			this.lastVisibility = this.Element.Visibility;
			this.Element.Visibility = Visibility.Collapsed;
		}

		private void LayoutChangeEnded(object sender, EventArgs args)
		{
			this.Element.Visibility = this.lastVisibility;
		}
	}
}