using System;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Structure that holds all parameters for customizing dialog window.
    /// </summary>
    public struct DialogParameters
    {
        /// <summary>
		/// Gets or sets the content to be displayed.
        /// </summary>
		/// <value>The content to be displayed.</value>
		public object Content { get; set; }

        /// <summary>
		/// Gets or sets the object to appear in the titlebar.
        /// </summary>
		/// <value>The object to appear in the titlebar.</value>
		public object Header { get; set; }

        /// <summary>
		/// Gets or sets the method that will be called when the Closed event of the Window
		/// is fired.
        /// </summary>
		/// <value>The method that will be called when the Closed event of the Window is fired.</value>
        public EventHandler<WindowClosedEventArgs> Closed { get; set; }

        /// <summary>
		/// Gets or sets the method that will be called when the Opened event of the Window
		/// is fired.
        /// </summary>
		/// <value>The method that will be called when the Opened event of the Window is fired.</value>
		public EventHandler Opened { get; set; }

        /// <summary>
		/// Gets or sets the content in the OK button.
        /// </summary>
		/// <value>The content in the OK button.</value>
		public object OkButtonContent { get; set; }

        /// <summary>
		/// Gets or sets the content in the Cancel button.
        /// </summary>
		/// <value>The content in the Cancel button.</value>
		public object CancelButtonContent { get; set; }

		/// <summary>
		/// Gets or sets the content of the icon area in the titlebar.
		/// </summary>
		/// <value>The content of the icon area in the titlebar.</value>
		public object IconContent { get; set; }

        /// <summary>
		/// Gets or sets the theme to be applied on the dialog window.
		/// <value>The theme to be applied on the dialog window.</value>
        /// </summary>
		public Theme Theme { get; set; }

        /// <summary>
        /// Gets or sets the Owner of the RadWindow.
        /// </summary>
        public ContentControl Owner
        {
            get;
            set;
        }

        /// <summary>
        /// The style to be applied to the RadWindow that will host the dialog box. This should be Style for the RadWindow class.
        /// </summary>
        public Style WindowStyle { get; set; }

        /// <summary>
        /// The style to be applied to the dialog box content. This should be Style for one of the RadAlert, RadConfir or RadPrompt classes.
        /// </summary>
        public Style ContentStyle { get; set; }

        /// <summary>
        /// Gets or sets the modal background of a dialog window.
        /// </summary>
        /// <value>The modal background.</value>
        public Brush ModalBackground { get; set; }

        /// <summary>
		/// Gets or sets the default prompt result value shown in the Prompt dialog window.
		/// <value>The default prompt result value shown in the Prompt dialog window.</value>
        /// </summary>
        public string DefaultPromptResultValue { get; set; }

        /// <summary>
        /// Implements the binary operator for equality.
        /// </summary>
		/// <param name="one">The left parameter.</param>
		/// <param name="two">The right parameter.</param>
		/// <returns>Returns true if the equality is satisfied.</returns>
        public static bool operator ==(DialogParameters one, DialogParameters two)
        {
            return one.IsEqual(two);
        }

        /// <summary>
        /// Implements the binary operator for inequality.
        /// </summary>
        /// <param name="one">The left parameter.</param>
        /// <param name="two">The right parameter.</param>
        /// <returns>Returns true if the inequality is satisfied.</returns>
        public static bool operator !=(DialogParameters one, DialogParameters two)
        {
            return !one.IsEqual(two);
        }

        /// <summary>
        /// Checks whether an instance of DialogParameters is equal to another one.
        /// </summary>
        /// <param name="obj">The checked DialogParameters instance.</param>
        /// <returns>Equality.</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(DialogParameters))
            {
                DialogParameters newObj = (DialogParameters)obj;
                if (this.IsEqual(newObj))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the sum of HashCodes of its members.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.Content.GetHashCode() + this.IconContent.GetHashCode()
                + this.Opened.GetHashCode() + this.Closed.GetHashCode() +
                this.OkButtonContent.GetHashCode() + this.CancelButtonContent.GetHashCode()
                + this.ModalBackground.GetHashCode() + this.Theme.GetHashCode() + this.Header.GetHashCode() + this.DefaultPromptResultValue.GetHashCode();
        }

        internal bool IsEqual(DialogParameters newObj)
        {
            if (this.Header == newObj.Header
                    && this.IconContent == newObj.IconContent
                    && this.Content == newObj.Content
                    && this.Opened == newObj.Opened
                    && this.Closed == newObj.Closed
                    && this.OkButtonContent == newObj.OkButtonContent
                    && this.CancelButtonContent == newObj.CancelButtonContent
                    && this.ModalBackground == newObj.ModalBackground
                    && this.Theme == newObj.Theme
                    && this.DefaultPromptResultValue == newObj.DefaultPromptResultValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}