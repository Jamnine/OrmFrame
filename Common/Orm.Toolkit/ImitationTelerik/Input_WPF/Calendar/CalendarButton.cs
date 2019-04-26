
using System;

using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
    /// <summary>
    /// The class of the calendar button.
    /// </summary>
    /// <remarks>
    /// The CalendarButton class is not to be used outside the RadCalendar control. If you need a button functionality,
    /// use the ButtonBase or Button classes.
    /// </remarks>

	[DefaultProperty("IsSelected")]
	public class CalendarButton : ContentControl
	{
		/// <summary>
		///     Identifies the ButtonType property.
		/// </summary>
		public static readonly DependencyProperty ButtonTypeProperty = DependencyProperty.Register("ButtonType", typeof(CalendarButtonType), typeof(CalendarButton), new PropertyMetadata(OnButtonTypeChanged));

		/// <summary>
		///     Identifies the IsFromCurrentView property.
		/// </summary>
		public static readonly DependencyProperty IsFromCurrentViewProperty = DependencyProperty.Register("IsFromCurrentView", typeof(bool), typeof(CalendarButton), new PropertyMetadata(IsFromCurrentViewChanged));

		/// <summary>
		/// Identifies the IsInAnotherView property.
		/// </summary>
		public static readonly DependencyProperty IsInAnotherViewProperty = DependencyProperty.Register("IsInAnotherView", typeof(bool), typeof(CalendarButton), new PropertyMetadata(IsInAnotherViewChanged));

		/// <summary>
		///     Identifies the IsSelected property.
		/// </summary>
		public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(CalendarButton), new PropertyMetadata(IsSelectedChanged));

		/// <summary>
		///     Identifies the Text property.
		/// </summary>
		public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(CalendarButton), null);




        static CalendarButton()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarButton),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(CalendarButton))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarButton),
               new FrameworkPropertyMetadata(typeof(CalendarButton)));

            System.Windows.Input.KeyboardNavigation.AcceptsReturnProperty.OverrideMetadata(typeof(CalendarButton), new FrameworkPropertyMetadata(true));
            System.Windows.Input.InputMethod.IsInputMethodEnabledProperty.OverrideMetadata(typeof(CalendarButton), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits));
        }


		/// <summary>
		/// Initializes a new instance of the <see cref="CalendarButton"/> class.
		/// </summary>
		public CalendarButton()
		{

			this.Loaded += new RoutedEventHandler(this.OnLoaded);
		}


		/// <summary>
		///     Gets or sets the type of the button. This is a dependency property.
		/// </summary>
		public CalendarButtonType ButtonType
		{
			get { return (CalendarButtonType)GetValue(ButtonTypeProperty); }
			set { SetValue(ButtonTypeProperty, value); }
		}

		/// <summary>
		///     Gets or sets whether the button belongs to the current month/year/decade/century. This is a dependency property.
		/// </summary>
		public bool IsFromCurrentView
		{
			get { return (bool)GetValue(IsFromCurrentViewProperty); }
			set { SetValue(IsFromCurrentViewProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether a button with the same content exists in another view (in a multi-view calendar). This is a dependency property.
		/// </summary>
		public bool IsInAnotherView
		{
			get { return (bool)GetValue(IsInAnotherViewProperty); }
			set { SetValue(IsInAnotherViewProperty, value); }
		}

		/// <summary>
		///     Gets or sets the text displayed by the button. This is a dependency property.
		/// </summary>
		public string Text
		{
			get { return (string)GetValue(TextProperty); }
			set { SetValue(TextProperty, value); }
		}

		/// <summary>
		///     Gets or sets whether the button is selected. This is a dependency property.
		/// </summary>
		public bool IsSelected
		{
			get { return (bool)GetValue(IsSelectedProperty); }
			set { SetValue(IsSelectedProperty, value); }
		}

		/// <summary>
		/// Gets or sets whether to focus the CalendarButton when it is loaded.
		/// </summary>
		internal bool FocusOnLoad
		{
			get;
			set;
		}



		/// <summary>
		/// Called when the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property changes.
		/// </summary>
		/// <param name="oldContent">The old value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		/// <param name="newContent">The new value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.</param>
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			CalendarButtonContent buttonContent = newContent as CalendarButtonContent;
			if (buttonContent != null)
			{
				buttonContent.Owner = this;
				this.ButtonType = buttonContent.ButtonType;
				this.IsFromCurrentView = buttonContent.IsFromCurrentView;
				this.IsInAnotherView = buttonContent.IsInAnotherView;
				this.IsSelected = buttonContent.IsSelected;
				this.Text = buttonContent.Text;
				this.IsEnabled = buttonContent.IsEnabled;
			}

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

       


        private static void OnButtonTypeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private static void IsFromCurrentViewChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private static void IsInAnotherViewChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            bool shouldBeVisible = !(bool)e.NewValue;
            CalendarButton calendarButton = sender as CalendarButton;
            calendarButton.Visibility = shouldBeVisible ? Visibility.Visible : Visibility.Collapsed;

        }

        private static void IsSelectedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {

        }


        private void SetDefaultStyleKey()
        {
            //Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(CalendarButton));

            this.DefaultStyleKey = typeof(CalendarButton);
        }




		private void OnLoaded(object sender, RoutedEventArgs e)
		{
			this.Loaded -= new RoutedEventHandler(this.OnLoaded);
			if (this.FocusOnLoad)
			{
				this.FocusOnLoad = false;
				this.Focus();
			}
		}
	}
}