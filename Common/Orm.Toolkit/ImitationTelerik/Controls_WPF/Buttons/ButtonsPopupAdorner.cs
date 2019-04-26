using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
     class ButtonsPopupAdorner : BrowserButtonPopup
		{
			private static List<WeakReference> popups = new List<WeakReference>();

            private static ButtonsPopupAdorner currentlyOpenedModal;

         

			private class WindowPopupAdorner : System.Windows.Documents.Adorner
			{
				private VisualCollection visualChildren;
				private Panel contentPanel;
                


                
				/// <summary>
				/// Initializes a new instance of the DragDropAdorner class.
				/// </summary>
				/// <param name="adornedElement">The adorned element.</param>
				/// <param name="contentPanel">The content panel.</param>
				public WindowPopupAdorner(UIElement adornedElement, Panel contentPanel)
					: base(adornedElement)
				{
					this.visualChildren = new VisualCollection(this);
					this.contentPanel = contentPanel;

					this.visualChildren.Add(contentPanel);
				}

				/// <summary>
				/// Gets the number of visual child elements within this element.
				/// </summary>
				/// <value></value>
				/// <returns>
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
				/// Overrides <see cref="M:System.Windows.Media.Visual.GetVisualChild(System.Int32)"/>, 
				/// and returns a child at the specified index from a collection of child elements.
				/// </summary>
				/// <param name="index">The zero-based index of the requested child element in the collection.</param>
				/// <returns>
				/// The requested child element. This should not return null; if the provided index 
				/// is out of range, an exception is thrown.
				/// </returns>
				protected override Visual GetVisualChild(int index)
				{
					return this.visualChildren[index];
				}

				/// <summary>
				/// When overridden in a derived class, positions child elements and determines a size for a 
				/// <see cref="T:System.Windows.FrameworkElement"/> derived class.
				/// </summary>
				/// <param name="finalSize">The final area within the parent that this element should use 
				/// to arrange itself and its children.</param>
				/// <returns>The actual size used.</returns>
				protected override Size ArrangeOverride(Size finalSize)
				{
					// adornerWidth & adornerHeight are used for placement.
					double adornerWidth = this.DesiredSize.Width;
					double adornerHeight = this.DesiredSize.Height;

					this.contentPanel.Arrange(new Rect(0, 0, adornerWidth, adornerHeight));

					return finalSize;
				}
			}

			private WindowPopupAdorner adorner;
			private AdornerLayer adornerLayer;
			private Panel content;

			public ButtonsPopupAdorner()
			{
				this.content = new Canvas();
			}

            

			public override int GetZIndex()
			{
				return Canvas.GetZIndex(this.content);
			}

			private void SezZIndex(int index)
			{
				Canvas.SetZIndex(this.content, index);
			}

            public double VerticalOffset { get; set; }
            public double HorizontalOffset { get; set; }

			public override UIElement GetVisual()
			{
				return this.content;
			}

            public System.Windows.Controls.Primitives.PlacementMode Placement { get; set; }

			public override void BringToFront()
			{
				int maxZIndex = popups
					.Where(wr => wr.IsAlive)
					.Select(wr => (wr.Target as ButtonsPopupAdorner).GetZIndex())
					.Max();

				this.SezZIndex(maxZIndex + 1);

				if (this.adornerLayer != null)
				{
					this.adornerLayer.Remove(this.adorner);
					this.adornerLayer.Add(this.adorner);
				}
			}

			public override void Move(double left, double top)
			{
				Canvas.SetLeft(this.Child, left + this.HorizontalOffset);
				Canvas.SetTop(this.Child, top + this.VerticalOffset);
			}

			protected override void OpenPopup()
			{
				base.OpenPopup();
				if (this.IsModal && currentlyOpenedModal == null)
				{
                    currentlyOpenedModal = this;
					this.content.Children.Add(this.ModalCanvas);
				}
				this.content.Children.Add(this.Child);
                var window = this.Child as UIElement ;
                if (window != null)
                {

                   // this.Move(window.Left, window.Top);
                }
				if (this.adorner == null)
				{
					if (Application.Current.MainWindow.Content == null)
					{
						Application.Current.MainWindow.Loaded += this.MainWindow_Loaded;
					}
					else
					{
						this.InitializeAdorner();
					}
				}
				else
				{
					this.content.Visibility = Visibility.Visible;
					this.OnOpened();
				}

				popups.Add(new WeakReference(this));				
			}

			protected override void ClosePopup()
			{
				this.content.Children.Clear();
				this.content.Visibility = Visibility.Visible;

				var thisWR = popups.Where(wr => wr.Target == this).FirstOrDefault();
				if (thisWR != null)
				{
					popups.Remove(thisWR);
				}

                if (this == currentlyOpenedModal)
                {
                    currentlyOpenedModal = null;
                }
			}

			private void MainWindow_Loaded(object sender, RoutedEventArgs e)
			{
				this.InitializeAdorner();
				Application.Current.MainWindow.Loaded -= this.MainWindow_Loaded;
			}

			private void InitializeAdorner()
			{
				this.adorner = new WindowPopupAdorner(Application.Current.MainWindow.Content as UIElement, this.content);

				var visual = Application.Current.MainWindow.Content as Visual;

				var layer = AdornerLayer.GetAdornerLayer(visual);

				if (layer != null)
				{
					layer.Add(this.adorner);
					this.adornerLayer = layer;
				}
				this.OnOpened();

				this.AttachEvents();
			}

			private void AttachEvents()
			{
				Application.Current.MainWindow.SizeChanged += (s, e) => this.InvalidateArrange();
			}
		}
}
