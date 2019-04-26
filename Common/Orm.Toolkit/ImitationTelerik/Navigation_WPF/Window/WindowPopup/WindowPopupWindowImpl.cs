using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup
{
	internal partial class WindowPopupWindowFactory
	{
		private class WindowPopupWindowImpl : WindowPopup
		{
			private const double leftMargin = 50.0;
			private const double topMargin = 50.0;

			private const double rightMargin = 50.0;
			private const double bottomMargin = 50.0;

			private System.Windows.Window window;
			private RadWindow radWindow;
			private Panel canvas;

			//private bool changingState;
			private bool closing;

			public WindowPopupWindowImpl()
			{
			}

			public double LeftMargin
			{
				get
				{
					return Math.Min(this.Left, leftMargin);
				}
			}

			public static double RightMargin
			{
				get
				{
					return rightMargin;
				}
			}

			public double TopMargin
			{
				get
				{
					return Math.Min(this.Top, topMargin);
				}
			}

			public static double BottomMargin
			{
				get
				{
					return bottomMargin;
				}
			}

			public double Left
			{
				get
				{
					return double.IsNaN(this.window.Left) ? 0 : this.window.Left;
				}
			}

			public double Top
			{
				get
				{
					return double.IsNaN(this.window.Top) ? 0 : this.window.Top;
				}
			}

			public override System.Windows.Size GetRootSize()
			{
				return new Size(System.Windows.SystemParameters.WorkArea.Size.Width - 1, System.Windows.SystemParameters.WorkArea.Size.Height - 1);
			}

			public override Point GetRootPosition()
			{
				return System.Windows.SystemParameters.WorkArea.Location;
			}

			public override int GetZIndex()
			{
				return 0;
			}

			public override void Move(double left, double top)
			{
				////this.Left = left - this.LeftMargin;
				////this.Top = top - this.TopMargin;
				////this.radWindow.Margin = new Thickness(left, top, 0, 0);
				Canvas.SetLeft(this.radWindow, left - System.Windows.SystemParameters.VirtualScreenLeft);
				Canvas.SetTop(this.radWindow, top - System.Windows.SystemParameters.VirtualScreenTop);
			}

			public override void BringToFront()
			{
				if (this.IsOpen && !this.window.IsActive)
				{
					this.window.Activate();
				}
			}

			public override System.Windows.UIElement GetVisual()
			{
				return this.window;
			}

			protected override void OpenPopup()
			{
				var radWindowOwner = this.Owner as RadWindow;
				if (radWindowOwner != null && !radWindowOwner.IsOpen)
				{
					throw new InvalidOperationException("Cannot set Owner property to a RadWindow that has not been shown previously.");
				}

				this.window = new Window
				{
					Background = Brushes.Transparent,
					AllowsTransparency = true,
					WindowStyle = WindowStyle.None,
					WindowStartupLocation = System.Windows.WindowStartupLocation.Manual,
					ShowInTaskbar = false,
					IsTabStop = false
				};

				var appSize = ApplicationHelper.ApplicationSize;

				this.window.Width = appSize.Width;
				this.window.Height = appSize.Height;
				this.window.Left = System.Windows.SystemParameters.VirtualScreenLeft;
				this.window.Top = System.Windows.SystemParameters.VirtualScreenTop;

				////this.window.RenderTransform = new TranslateTransform { X = this.window.Left, Y = this.window.Top };

				// TODO: Uncomment this when all issues about it are fixed.
				//this.window.StateChanged += this.window_StateChanged;

				this.window.Closing += this.OnWindowClosing;
				this.window.Loaded += this.OnWindowLoaded;
				var owner = this.Owner as Window;
				var radOwner = this.Owner as RadWindow;
				if (owner != null)
				{
					this.window.Owner = owner;
				}
				else if (radOwner != null)
				{
					var impl = radOwner.Popup as WindowPopupWindowImpl;
					if (impl != null)
					{
						this.window.Owner = impl.window;
					}
				}

				this.radWindow = this.Child as RadWindow;
				if (this.canvas == null)
				{
					this.canvas = new Canvas();
					this.canvas.Children.Add(this.Child);
				}
				this.window.Content = this.canvas;

				if (this.radWindow != null)
				{
					this.Move(this.radWindow.Left, this.radWindow.Top);

					this.UpdateWindowSize();

					//this.radWindow.Margin = new Thickness(LeftMargin, TopMargin, LeftMargin, TopMargin);

					// TODO: Uncomment this when all issues about it are fixed.
					//this.radWindow.WindowStateChanged += this.radWindow_WindowStateChanged;
					this.radWindow.SizeChanged += this.radWindow_SizeChanged;
				}

				if (this.IsModal)
				{
					this.window.ShowDialog();
				}
				else
				{
					this.window.Show();
				}
			}

			private void UpdateWindowSize()
			{
				////this.window.Width = this.radWindow.Width + this.LeftMargin + this.RightMargin;
				////this.window.Height = this.radWindow.Height + this.TopMargin + this.BottomMargin;
			}

			private void OnWindowLoaded(object sender, EventArgs args)
			{
				this.window.Loaded -= this.OnWindowLoaded;
				this.OnOpened();
			}

			protected override void ClosePopup()
			{
				this.closing = true;
				this.window.Close();
				if (this.radWindow != null)
				{
					// TODO: Uncomment this when all issues about it are fixed.
					////this.radWindow.WindowStateChanged -= this.radWindow_WindowStateChanged;

					this.radWindow.SizeChanged -= this.radWindow_SizeChanged;
				}
				this.window.ClearValue(System.Windows.Window.ContentProperty);
				this.window = null;
			}

			protected override void OnOpened(EventArgs args)
			{
				base.OnOpened(args);
				if (this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterOwner ||
                    this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterScreen)
				{
					this.PositionWindow();
				}
			}

			private void PositionWindow()
			{
				// TODO: Decouple this method from RadWindow class.
				if (this.radWindow == null)
				{
					return;
				}

				if (this.radWindow.ActualWidth <= 0 || this.radWindow.ActualHeight <= 0)
				{
					this.radWindow.LayoutUpdated += this.OnWindowLayoutUpdated;
					return;
				}

                if (this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterOwner &&
					this.Owner != null &&
					(this.Owner.ActualWidth <= 0 || this.Owner.ActualHeight <= 0))
				{
					this.Owner.LayoutUpdated += this.OnWindowOwnerLayoutUpdated;
					return;
				}

				Point parentStart = new Point(this.radWindow.LeftOffset, this.radWindow.TopOffset);
				Size parentSize = this.GetRootSize();
				var radOwner = this.Owner as RadWindow;
				var windowOwner = this.Owner as Window;
                if (this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterOwner)
				{
					if ((radOwner != null && radOwner.IsOpen) || (windowOwner != null && windowOwner.IsLoaded))
					{
						parentStart = this.Owner.PointToScreen(parentStart);

						parentSize = new Size(this.Owner.ActualWidth, this.Owner.ActualHeight);
					}
					else if (radOwner != null || windowOwner != null)
					{
						throw new InvalidOperationException("Cannot set Owner property to a RadWindow that has not been shown previously.");
					}
				}

				parentStart.Offset(-System.Windows.SystemParameters.VirtualScreenLeft, -System.Windows.SystemParameters.VirtualScreenTop);

				Rect parentRect = new Rect(parentStart, parentSize);
				PlacementHelper helper = new PlacementHelper(parentRect,
					new Size(radWindow.ActualWidth, radWindow.ActualHeight),
					0, 
					0,
					ApplicationHelper.ApplicationSize, this.radWindow.FlowDirection);

				Point newLocation = helper.GetPlacementOrigin(PlacementMode.Center);
				newLocation.Offset(System.Windows.SystemParameters.VirtualScreenLeft, System.Windows.SystemParameters.VirtualScreenTop);
				radWindow.Left = newLocation.X;
				radWindow.Top = newLocation.Y;
				radWindow.UpdateLayout();
			}

			////private void radWindow_WindowStateChanged(object sender, System.Windows.RoutedEventArgs e)
			////{
			////    //this.changingState = true;
			////    //this.window.WindowState = this.radWindow.WindowState;
			////    //this.changingState = false;
			////}

			private void radWindow_SizeChanged(object sender, SizeChangedEventArgs e)
			{
				this.UpdateWindowSize();
			}

			////private void window_StateChanged(object sender, System.EventArgs e)
			////{
			////    ////if (!this.changingState && this.radWindow != null)
			////    ////{
			////    ////    this.radWindow.WindowState = this.window.WindowState;
			////    ////}
			////}

			private void OnWindowClosing(object sender, CancelEventArgs e)
			{
				if (!this.closing && this.radWindow != null)
				{
					e.Cancel = true;
					this.window.Dispatcher.BeginInvoke(new Action(() => this.radWindow.Close()));
				}
			}

			private void OnWindowLayoutUpdated(object sender, EventArgs e)
			{
				if (this.window != null)
				{
					if (this.window.ActualWidth > 0 && this.window.ActualHeight > 0)
					{
						this.window.LayoutUpdated -= this.OnWindowLayoutUpdated;
						this.PositionWindow();
					}
				}
			}

			private void OnWindowOwnerLayoutUpdated(object sender, EventArgs e)
			{
				if (this.Owner.ActualWidth > 0 && this.Owner.ActualHeight > 0)
				{
					this.Owner.LayoutUpdated -= this.OnWindowOwnerLayoutUpdated;
					this.PositionWindow();
				}
			}
		}
	}
}
