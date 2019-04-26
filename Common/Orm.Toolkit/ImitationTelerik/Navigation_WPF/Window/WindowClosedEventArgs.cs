using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// WindowClosedEventArgs exposes DialogResult and PromptResult property
    /// for handling the closed event of a window.
    /// </summary>
    public class WindowClosedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the WindowClosedEventArgs class.
        /// </summary>
        public WindowClosedEventArgs()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets the DialogResult of the RadWindow.
        /// </summary>
        public Nullable<bool> DialogResult
        {
			get;
            set;            
        }

        /// <summary>
        /// Gets or sets the PromptResult of the RadWindow.
        /// </summary>
        public string PromptResult
        {
			get;
            set;
        }
    }
}
