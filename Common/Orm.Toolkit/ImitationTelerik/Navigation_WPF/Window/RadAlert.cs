using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadAlert notifies the user according to its invocation parameters.
	/// </summary>
	[TemplatePart(Name = "Ok", Type = typeof(Button))]
	public class RadAlert : ContentControl
	{
		private Button buttonOk;
		private DialogParameters dialogParams;


        static RadAlert()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadAlert),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadAlert))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadAlert),
              new FrameworkPropertyMetadata( typeof(RadAlert)));

		}


        /// <summary>
        /// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
        /// </summary>
        /// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadAlert));

        }

        /// <summary>
		/// Occurs when the user presses the accept button.
		/// </summary>
		public event EventHandler Ok;

		/// <summary>
		/// Gets or sets the parent window.
		/// </summary>
		/// <value>The parent window.</value>
		protected RadWindow ParentWindow
		{
			get;
			private set;
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			this.buttonOk = this.GetTemplateChild("OK") as Button;
			if (this.buttonOk != null)
			{
				this.buttonOk.Click += new RoutedEventHandler(this.OnOkButtonClicked);
				this.buttonOk.SetValue(RadWindow.ResponseButtonProperty, ResponseButton.Accept);

				if (this.dialogParams.OkButtonContent != null)
				{
					this.buttonOk.Content = this.dialogParams.OkButtonContent;
				}
			}
		}

		/// <summary>
		/// Configures RadAlert according to the RadWindow.
		/// </summary>
		/// <param name="window">RadWindow in which the RadPrompt will appear.</param>
		/// <param name="pars">Structure that holds all possible parameters for customizing dialog window.</param>
		public virtual void Configure(RadWindow window, DialogParameters pars)
		{
			if (window.Header == null || String.IsNullOrEmpty(window.Header.ToString()))
			{
				window.Header = "Alert";
			}

			this.ParentWindow = window;

			this.dialogParams = pars;
		}

		/// <summary>
		/// Raises the <see cref="E:Ok"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnOk(EventArgs e)
		{
			if (this.ParentWindow != null)
			{
				this.ParentWindow.DialogResult = true;
				this.ParentWindow.Close();
			}

			if (this.Ok != null)
			{
				this.Ok(this, e);
			}
		}

		private void OnOkButtonClicked(object sender, RoutedEventArgs e)
		{
			this.OnOk(new EventArgs());
		}
	}
}