using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents a RadClockItem control.
	/// </summary>

    [Themable]
    public class RadClockItem : ContentControl, IThemable
    {

		/// <summary>
		/// Identifies the IsSelectedProperty dependency property.
		/// </summary>
		public static readonly DependencyProperty IsSelectedProperty = DependencyPropertyExtensions.Register("IsSelected",
																					typeof(bool),
																					typeof(RadClockItem),
																					new PropertyMetadata(false, new PropertyChangedCallback(RadClockItem.OnSelectionChanged), null));


		static RadClockItem()
		{

            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadClockItem),
            //        new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadClockItem))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadClockItem),
                   new FrameworkPropertyMetadata( typeof(RadClockItem)));

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RadClockItem"/> class.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public RadClockItem()
		{
			//// default template stored in generic.xaml
			this.DefaultStyleKey = typeof(RadClockItem);
			////this.MouseLeftButtonDown += this.OnMouseLeftButtonDown;
			this.MouseLeftButtonUp += this.OnMouseLeftButtonUp;

		}



		/// <summary>
		/// Gets or sets a value indicating whether this instance is mouse over.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is mouse over; otherwise, <c>false</c>.
		/// </value>
		internal bool IsSelected
		{
			get
			{
				return (bool)this.GetValue(RadClockItem.IsSelectedProperty);
			}
			set
			{
				SetValue(RadClockItem.IsSelectedProperty, value);
			}
		}

		internal RadClock ClockControl
		{
			get;
			set;
		}


        /// <summary>
        /// Resets the theme.
        /// </summary>
        public void ResetTheme()
        {
            this.SetDefaultStyleKey();
        }



		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{
            return null;

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


		private static void OnSelectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadClockItem item = d as RadClockItem;
			if (item != null)
			{
				item.IsSelected = (bool)e.NewValue;
			}
		}



		////        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		////        {
		////#if !WPF
		////            this.IsFocused = true;
		////#endif
		////            if (this.ClockControl != null && !this.ClockControl.IsReadOnly)
		////            {
		////                this.ClockControl.NotifyClockItemSelected(this);
		////            }
		////        }

		private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{

			if (this.ClockControl != null && !this.ClockControl.IsReadOnly)
			{
				this.ClockControl.NotifyClockItemSelected(this);
			}
		}


        private void SetDefaultStyleKey()
        {
            Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(RadClockItem));

            this.DefaultStyleKey = typeof(RadClockItem);
        }

	}
}
