using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadConfirm requests the user the confirm given question.
	/// </summary>
	[TemplatePart(Name = "Cancel", Type = typeof(Button))]
	public class RadConfirm : RadAlert
	{
		private Button cancelButton;
		private DialogParameters dialogParams;

        static RadConfirm()
		{
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadConfirm),
                new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadConfirm))));

		}
            


        /// <summary>
        /// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
        /// </summary>
        /// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadConfirm));
            this.DefaultStyleKey = typeof(RadConfirm);
        }

        /// <summary>
		/// Occurs when the user presses the cancel button.
		/// </summary>
		public event EventHandler Cancel;

		/// <summary>
		///     When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) 
		///     call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this.cancelButton = this.GetTemplateChild("Cancel") as Button;
			if (this.cancelButton != null)
			{
				this.cancelButton.Click += this.OnCancelButtonClicked;
				this.cancelButton.SetValue(RadWindow.ResponseButtonProperty, ResponseButton.Cancel);

				if (this.dialogParams.CancelButtonContent != null)
				{
					this.cancelButton.Content = this.dialogParams.CancelButtonContent;
				}
			}
		}

		/// <summary>
		/// Configures RadConfirm according to the RadWindow specified.
		/// </summary>
		/// <param name="window">RadWindow in which the RadConfirm will appear.</param>
		/// <param name="pars">Structure that holds all possible parameters for customizing dialog window.</param>
		public override void Configure(RadWindow window, DialogParameters pars)
		{
			this.dialogParams = pars;

			if (window.Header == null || String.IsNullOrEmpty(window.Header.ToString()))
			{
				window.Header = "Confirm";
			}

			base.Configure(window, pars);
		}

		/// <summary>
		/// Raises the <see cref="E:Cancel"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected virtual void OnCancel(EventArgs e)
		{
			if (this.ParentWindow != null)
			{
				this.ParentWindow.DialogResult = false;
				this.ParentWindow.Close();
			}

			if (this.Cancel != null)
			{
				this.Cancel(this, e);
			}
		}

		private void OnCancelButtonClicked(object sender, RoutedEventArgs e)
		{
			this.OnCancel(new EventArgs());
		}
	}
}
