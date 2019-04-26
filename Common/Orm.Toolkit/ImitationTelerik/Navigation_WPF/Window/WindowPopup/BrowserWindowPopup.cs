using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup
{
	internal abstract class BrowserWindowPopup : WindowPopup
	{
		public override Size GetRootSize()
		{
			return ApplicationHelper.ApplicationSize;
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

		protected override void OpenPopup()
		{
			var owner = this.Owner as RadWindow;
			if (owner != null && !owner.IsOpen)
			{
				throw new InvalidOperationException("Cannot set Owner property to a RadWindow that has not been shown previously.");
			}
		}

		// XXX This won't work for XBAP if in a different window than the main one.
		private void PositionWindow()
		{
			// TODO: Decouple this method from RadWindow class.
			var window = this.Child as RadWindow;
			if (window == null)
			{
				return;
			}

			var rootSize = this.GetRootSize();

			if (rootSize.Width <= 0 || rootSize.Height <= 0)
			{				
				ApplicationHelper.RootVisual.LayoutUpdated += this.OnApplicationLayoutUpdated;
				return;
			}

			if (window.ActualWidth <= 0 || window.ActualHeight <= 0)
			{
				window.LayoutUpdated += this.OnWindowLayoutUpdated;
				return;
			}

            if (this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterOwner &&
				this.Owner != null &&
				(this.Owner.ActualWidth <= 0 || this.Owner.ActualHeight <= 0))
			{
				this.Owner.LayoutUpdated += this.OnWindowOwnerLayoutUpdated;
				return;
			}

			Point parentStart = new Point(window.LeftOffset, window.TopOffset);
			Size parentSize = this.GetRootSize();

            if (this.WindowStartupLocation == System.Windows.WindowStartupLocation.CenterOwner &&
				this.Owner != null)
			{
				parentStart = this.Owner
					.TransformToVisual(ApplicationHelper.RootVisual)
					.Transform(parentStart);

				parentSize = new Size(this.Owner.ActualWidth, this.Owner.ActualHeight);
			}

			Rect parentRect = new Rect(parentStart, parentSize);
			PlacementHelper helper = new PlacementHelper(parentRect,
				new Size(window.ActualWidth, window.ActualHeight),
				0,
				0,
				this.GetRootSize(), window.FlowDirection);

			Point newLocation = helper.GetPlacementOrigin(PlacementMode.Center);

			window.Left = newLocation.X;
			window.Top = newLocation.Y;
			window.UpdateLayout();
		}

		private void OnApplicationLayoutUpdated(object sender, EventArgs e)
		{
			var app = ApplicationHelper.RootVisual;
			if (app.ActualWidth > 0 && app.ActualHeight > 0)
			{
				app.LayoutUpdated -= this.OnApplicationLayoutUpdated;
				this.PositionWindow();
			}
		}

		private void OnWindowLayoutUpdated(object sender, EventArgs e)
		{
			var window = this.Child as RadWindow;
			if (window != null)
			{
				if (window.ActualWidth > 0 && window.ActualHeight > 0)
				{
					window.LayoutUpdated -= this.OnWindowLayoutUpdated;
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
