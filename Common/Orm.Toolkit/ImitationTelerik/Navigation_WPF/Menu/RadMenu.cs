using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a menu control that enables you to hierarchically organize elements with associated event handlers.
	/// </summary>
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(RadMenuItem))]
	[DefaultProperty("ClickToOpen")]
	public class RadMenu : MenuBase
	{
		/// <summary>
		/// Identifies the Orientation dependency property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register("Orientation",
			typeof(Orientation),
			typeof(RadMenu),
			new System.Windows.PropertyMetadata(Orientation.Horizontal, OnOrientationChanged));

		private Panel panel;


        static RadMenu()
		{
			MenuBase.ClickToOpenProperty.OverrideMetadata(typeof(RadMenu), new PropertyMetadata(true));

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadMenu),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadMenu))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadMenu),
                new FrameworkPropertyMetadata( typeof(RadMenu)));

            ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(RadMenu), new FrameworkPropertyMetadata(GetDefaultPanel()));
            Control.IsTabStopProperty.OverrideMetadata(typeof(RadMenu), new FrameworkPropertyMetadata(false));
            KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(RadMenu), new FrameworkPropertyMetadata(KeyboardNavigationMode.Once));
			KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(RadMenu), new FrameworkPropertyMetadata(KeyboardNavigationMode.Cycle));
   
			EventManager.RegisterClassHandler(typeof(RadMenu), AccessKeyManager.AccessKeyPressedEvent, new AccessKeyPressedEventHandler(RadMenu.OnAccessKeyPressed));
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="RadMenu"/> class.
		/// </summary>
		public RadMenu()
		{
            //TelerikLicense.Verify(this); //禁止验证许可

		}

        /// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Gets or sets a value that specifies the dimension in which child 
		/// content is arranged. This is a dependency property.
		/// </summary>
		public Orientation Orientation
		{
			get { return (Orientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		internal bool ProcessKey(Key key)
		{
			int index = -1;
			switch (key)
			{
				case Key.Left:
				case Key.Right:
					if (this.CurrentSelection != null)
					{
						Orientation? orientation = this.GetPanelOrientation();
						if (orientation.HasValue && orientation.Value == Orientation.Vertical)
						{
							this.CurrentSelection.OpenSubmenuWithKeyboard();
						}
						else
						{
							int direction = key == Key.Left ? -1 : 1;
							index = this.ItemContainerGenerator.IndexFromContainer(this.CurrentSelection);
							this.MenuNavigate(index + direction, direction, this.CurrentSelection.IsSubmenuOpen);
						}

						return true;
					}
					break;

				case Key.Up:
				case Key.Down:
					if (this.CurrentSelection != null)
					{
						Orientation? orientation = this.GetPanelOrientation();
						if (orientation.HasValue && orientation == Orientation.Vertical)
						{
							int direction = key == Key.Up ? -1 : 1;
							index = this.ItemContainerGenerator.IndexFromContainer(this.CurrentSelection);
							this.MenuNavigate(index + direction, direction, this.CurrentSelection.IsSubmenuOpen);
						}
						else
						{
							this.CurrentSelection.OpenSubmenuWithKeyboard();
						}

						return true;
					}
					break;
			}

			return false;
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);

			if (this.panel == null)
			{
				this.panel = VisualTreeHelper.GetParent(element) as Panel;
				if (this.panel is StackPanel)
				{
					this.panel.SetValue(StackPanel.OrientationProperty, this.Orientation);
				}
				else if (this.panel is RadWrapPanel)
				{
					this.panel.SetValue(RadWrapPanel.OrientationProperty, this.Orientation);
				}
			}
		}

		/// <summary>
		/// Invoked when keyboard key is pressed while the element has focus.
		/// </summary>
		/// <param name="e">The KeyEventArgs that contains the event data.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled)
			{
				e.Handled = this.ProcessKey(e.Key);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{
			return new RadMenuAutomationPeer(this);
		}

        /// <summary>
        /// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.SetDefaultStyleKey();
        }



        private static ItemsPanelTemplate GetDefaultPanel()
        {
            FrameworkElementFactory root = new FrameworkElementFactory(typeof(WrapPanel));
            ItemsPanelTemplate template = new ItemsPanelTemplate(root);
            template.Seal();
            return template;
        }

        private static void OnAccessKeyPressed(object sender, AccessKeyPressedEventArgs e)
        {
            if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
            {
                e.Scope = sender;
                e.Handled = true;
            }
        }

		private static void OnOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadMenu menu = d as RadMenu;
			if (menu != null && menu.panel != null)
			{
				if (menu.panel is StackPanel)
				{
					menu.panel.SetValue(StackPanel.OrientationProperty, menu.Orientation);
				}
				else if (menu.panel is RadWrapPanel)
				{
					menu.panel.SetValue(RadWrapPanel.OrientationProperty, menu.Orientation);
				}
				menu.OnPropertyChanged("Orientation");
			}
		}

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private Orientation? GetPanelOrientation()
		{
			if (this.panel == null)
			{
				return null;
			}

			if (this.panel is StackPanel)
			{
				return (Orientation)this.panel.GetValue(StackPanel.OrientationProperty);
			}
			else if (this.panel is RadWrapPanel)
			{
				return (Orientation)this.panel.GetValue(RadWrapPanel.OrientationProperty);
			}

            else if (this.panel is WrapPanel)
            {
                return (Orientation)this.panel.GetValue(WrapPanel.OrientationProperty);
            }

			return null;
		}
	}
}