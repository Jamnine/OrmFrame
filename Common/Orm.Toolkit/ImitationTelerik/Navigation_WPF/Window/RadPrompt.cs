using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// RadPrompt exposes a textbox in which the user can put any value.
	/// </summary>
	[TemplatePart(Name = "PromptTextBox", Type = typeof(TextBox))]
	public class RadPrompt : RadConfirm
	{
		private TextBox promptTextBox;
		private DialogParameters dialogParams;


        static RadPrompt()
		{
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadPrompt),
            //    new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadPrompt))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadPrompt),
               new FrameworkPropertyMetadata( typeof(RadPrompt)));

		}
        

        /// <summary>
        /// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
        /// </summary>
        /// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(StyleManager.GetTheme(this), typeof(RadPrompt));
            this.DefaultStyleKey =  typeof(RadPrompt);
        }

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass)
		/// call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.promptTextBox = this.GetTemplateChild("PromptTextBox") as TextBox;

			if (this.promptTextBox != null)
			{
				if (!String.IsNullOrEmpty(this.dialogParams.DefaultPromptResultValue))
				{
					this.promptTextBox.Text = this.dialogParams.DefaultPromptResultValue;
				}
			}
		}

		/// <summary>
		/// Configures RadPrompt according to the RadWindow specified.
		/// </summary>
		/// <param name="window">RadWindow in which the RadPrompt will appear.</param>
		/// <param name="pars">Structure that holds all possible parameters for customizing dialog window.</param>
		public override void Configure(RadWindow window, DialogParameters pars)
		{
			this.dialogParams = pars;
			if (window.Header == null || String.IsNullOrEmpty(window.Header.ToString()))
			{
				window.Header = "Prompt";
			}

			base.Configure(window, pars);
		}

		/// <summary>
		/// Raises the <see cref="E:Ok"/> event.
		/// </summary>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		protected override void OnOk(EventArgs e)
		{
			if (this.ParentWindow != null && this.promptTextBox != null)
			{
				this.ParentWindow.PromptResult = this.promptTextBox.Text;
			}

			base.OnOk(e);
		}
	}
}