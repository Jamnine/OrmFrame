using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.RadWindowPopup
{
	internal abstract class WindowPopup
	{
		private bool isConfigured;
		private ContentControl owner;

		public event EventHandler Opened;

		public bool IsOpen { get; private set; }
		public bool IsModal { get; private set; }
		public bool IsTopMost { get; private set; }
		public UIElement Child { get; private set; }
		public UIElement ModalCanvas { get; private set; }

        public System.Windows.WindowStartupLocation WindowStartupLocation { get; set; }
		public ContentControl Owner 
		{
			get
			{
				return this.owner;
			}
			set
			{
				this.owner = value as RadWindow;

				if (this.owner == null)
				{
					this.owner = value as Window;
				}

			}
		}

		public abstract Size GetRootSize();

        public virtual Point GetRootPosition()
        {
            return new Point();
        }

		public void Configure(UIElement child, UIElement modalCanvas, bool isTopMost)
		{
			if (this.isConfigured)
			{
				throw new InvalidOperationException("You cannot reconfigure WindowPopup");
			}

			this.IsTopMost = isTopMost;
			this.Child = child;
			this.ModalCanvas = modalCanvas;
			this.isConfigured = true;
		}

		public void Open(bool isModal)
		{
			if (this.IsOpen)
			{
				return;
			}

			this.IsModal = isModal;
			this.OpenPopup();
		}

		public void Close()
		{
			this.ClosePopup();
			this.IsOpen = false;
		}

		public abstract int GetZIndex();

		public abstract void Move(double left, double top);

		public abstract void BringToFront();

		public abstract UIElement GetVisual();

		protected virtual void OnOpened(EventArgs args)
		{
			if (this.Opened != null)
			{
				this.Opened(this, args);
			}
		}

		protected void InvalidateArrange()
		{
			if (this.Child != null && this.IsOpen)
			{
				this.Child.InvalidateArrange();
			}
		}

		protected abstract void OpenPopup();

		protected abstract void ClosePopup();

		protected void OnOpened()
		{
			this.IsOpen = true;
			this.OnOpened(EventArgs.Empty);
		}
	}
}
