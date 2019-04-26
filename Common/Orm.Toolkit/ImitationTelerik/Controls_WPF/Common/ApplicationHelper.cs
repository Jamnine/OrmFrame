using System.Windows;
using System.Linq;
using System.Windows.Interop;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class ApplicationHelper
	{
		// XXX It is a wrong assumption that the XBAP application has one part!
		internal static Size ApplicationSize
		{
			get
			{
				if (BrowserInteropHelper.IsBrowserHosted)
				{
					var element = Application.Current.MainWindow.Content as FrameworkElement ?? Application.Current.MainWindow;
					return new Size(element.ActualWidth, element.ActualHeight);
				}
				else
				{
                    return new Size(System.Windows.SystemParameters.VirtualScreenWidth, System.Windows.SystemParameters.VirtualScreenHeight);
                    ////System.Windows.SystemParameters.VirtualScreenWidth
                    ////return System.Windows.SystemParameters.WorkArea.Size;
				}
			}
		}

		internal static FrameworkElement GetRootVisual(DependencyObject element)
		{
			if (element == null)
			{
				return RootVisual;
			}

			DependencyObject parent = null;
			while (element != null)
			{
				// Walk up the visual tree.  If we hit the root, try using the framework element's
				// parent.  We do this because Popups behave differently with respect to the visual tree,
				// and it could have a parent even if the VisualTreeHelper doesn't find it.
				parent = VisualTreeHelper.GetParent(element);
				if (parent == null)
				{
					FrameworkElement childElement = element as FrameworkElement;
					if (childElement != null)
					{
						parent = childElement.Parent;
						if (parent == null)
						{
							parent = element;
							break;
						}
					}
				}
				element = parent;
			}

			return parent as FrameworkElement;
		}

		internal static FrameworkElement RootVisual
		{
			get
			{
				if (Application.Current == null)
				{
					return null;
				}
				if (Application.Current.Dispatcher.CheckAccess())
				{
					return Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w.IsActive);
				}
				return null;
			}
		}

		internal static GeneralTransform TransformToScreenRoot(UIElement target)
		{

			return target.TransformToAncestor(GetRootVisual(target));
		}
	}
}
