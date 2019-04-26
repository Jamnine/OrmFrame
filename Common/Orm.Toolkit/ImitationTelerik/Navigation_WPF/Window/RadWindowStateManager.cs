using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal class RadWindowStateManager
	{
		private Rect normal;
		private Rect minimized;
		private Rect maximized;
		private bool firstTimeMinimized;

		public RadWindowStateManager(RadWindow window)
		{
			this.Window = window;
			this.normal = new Rect(Math.Round(this.Window.Left, 0),
									Math.Round(this.Window.Top, 0),
									Math.Round(this.Window.Width, 0),
									Math.Round(this.Window.Height, 0));

			this.minimized.Height = double.NaN;
			this.minimized.Width = double.NaN;
			this.firstTimeMinimized = true;

			this.Window.SizeChanged += this.Window_SizeChanged;
			this.Window.LocationChanged += this.Window_LocationChanged;
		}

		public Rect SizeAndPosition
		{
			get
			{
				switch (this.Window.WindowState)
				{
                    case System.Windows.WindowState.Normal:
						return this.normal;

                    case System.Windows.WindowState.Maximized:
						this.UpdateMaximize();
						return this.maximized;

                    case System.Windows.WindowState.Minimized:
						this.UpdateMinimized();
						return this.minimized;

					default:
						return new Rect(0, 0, 0, 0);
				}
			}
		}

		private RadWindow Window
		{
			get;
			set;			
		}

		public void UpdateTop(double top)
		{
			top = Math.Round(top, 0);
			if (System.Windows.WindowState.Normal == this.Window.WindowState)
			{
				this.normal.Y = top;
			}
            if (System.Windows.WindowState.Minimized == this.Window.WindowState)
			{
				this.minimized.Y = top;
				if (!this.Window.RestoreMinimizedLocation)
				{
					this.normal.Y = top;
				}
			}
		}

		public void UpdateLeft(double left)
		{
			left = Math.Round(left, 0);
            if (System.Windows.WindowState.Normal == this.Window.WindowState)
			{
				this.normal.X = left;
			}
            if (System.Windows.WindowState.Minimized == this.Window.WindowState)
			{
				this.minimized.X = left;
				if (!this.Window.RestoreMinimizedLocation)
				{
					this.normal.X = left;
				}
			}
		}

		internal void UpdateLayout()
		{
            if (System.Windows.WindowState.Normal == this.Window.WindowState)
			{
				this.normal.Width = this.Window.Width;
				this.normal.Height = this.Window.Height;
			}

			// NOTE: Why do we need to persist minimized width?
			////if (WindowState.Minimized == this.Window.WindowState)
			////{
			////    if (this.Window.RestoreMinimizedLocation)
			////    {
			////        this.minimized.Width = this.Window.Width;
			////        this.minimized.Height = this.Window.Height;
			////    }
			////}
		}

		private void Window_LocationChanged(object sender, RoutedEventArgs e)
		{
			this.UpdateLayout();
		}

		private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
		{
			this.UpdateLayout();
		}

		private void UpdateMinimized()
		{
			if (this.Window.RestoreMinimizedLocation == false || this.firstTimeMinimized)
			{
				this.minimized.Y = this.normal.Y;
				this.minimized.X = this.normal.X;
				this.firstTimeMinimized = false;
			}
		}

		private void UpdateMaximize()
		{
			if (this.Window.Popup == null)
			{
				return;
			}

			Size appSize = this.Window.Popup.GetRootSize();

			this.maximized.X = this.Window.RestrictedAreaMargin.Left;
			this.maximized.Y = this.Window.RestrictedAreaMargin.Top;

			this.maximized.Width = Math.Min(this.Window.MaxWidth, appSize.Width - this.Window.RestrictedAreaMargin.Left - this.Window.RestrictedAreaMargin.Right);
			this.maximized.Height = Math.Min(this.Window.MaxHeight, appSize.Height - this.Window.RestrictedAreaMargin.Top - this.Window.RestrictedAreaMargin.Bottom);
		}
	}
}
