using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadWindowManager class exposes methods that apply to all
	/// RadWindows which are in the current RootVisual element.
	/// </summary>
	public class RadWindowManager
	{
		private static RadWindowManager instnace;

		private List<RadWindow> windows;

		private RadWindowManager()
		{
			this.windows = new List<RadWindow>();

		}

		/// <summary>
		/// Gets the singleton instance.
		/// </summary>
		/// <value>The current instance.</value>
		public static RadWindowManager Current
		{
			get
			{
				if (instnace == null)
				{
					instnace = new RadWindowManager();
				}

				return instnace;
			}
		}

		internal IEnumerable<RadWindow> Windows
		{
			get { return this.windows.Where(w => w != null); }
		}

		/// <summary>
		/// Closes all RadWindows that are open.
		/// </summary>
		public void CloseAllWindows()
		{
			this.Go(
			   w => w.IsOpen,
			   w => w.Close());
		}

		/// <summary>
		/// Minimizes all RadWindows that are open and can be minimized.
		/// </summary>
		public void MinimizeAllWindows()
		{
			this.Go(
				w => w.IsOpen && w.ResizeMode != ResizeMode.NoResize,
				w => w.WindowState = System.Windows.WindowState.Minimized);
		}

		/// <summary>
		/// Maximizes all RadWindows that are open and can be maximized.
		/// </summary>
		public void MaximizeAllWindows()
		{
			this.Go(
				w => w.IsOpen && w.ResizeMode == ResizeMode.CanResize,
                w => w.WindowState = System.Windows.WindowState.Maximized);
		}

		/// <summary>
		/// Restores all RadWindows that are open.
		/// </summary>
		public void NormalAllWindows()
		{
			this.Go(
				w => w.IsOpen,
                w => w.WindowState = System.Windows.WindowState.Normal);
		}

		/// <summary>
		/// Returns collection of RadWindows.
		/// </summary>
		/// <returns>Collection of RadWindows.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public IList<RadWindow> GetWindows()
		{
			return new ReadOnlyCollection<RadWindow>(this.Windows.ToList());
		}

		internal void BringToFront(RadWindow window)
		{
			if (!window.IsActiveWindow)
			{
				this.MarkWindowAsActive(window);

				window.Popup.BringToFront();
			}
		}

		internal void AddWindow(RadWindow window)
		{
			this.windows.Add(window);
			this.MarkWindowAsActive(window);
		}

		internal void RemoveWindow(RadWindow window)
		{
			this.windows.Remove(window);
			if (window.IsActiveWindow)
			{
				var wnd = this.Windows.OrderBy(w => w.Z).LastOrDefault();
				if (wnd != null)
				{
					wnd.BringToFront();
				}
				window.IsActiveWindow = false;
			}
		}

		private void MarkWindowAsActive(RadWindow window)
		{
			window.IsActiveWindow = true;
			this.Windows
				.Where(w => w != window)
				.ToList()
				.ForEach(w => w.IsActiveWindow = false);			
		}

		private void Go(Func<RadWindow, bool> filter, Action<RadWindow> method)
		{
			if (this.Windows != null)
			{
				this.Windows
					.Where(w => filter(w))
					.ToList()
					.ForEach(method);
			}
		}
	}
}