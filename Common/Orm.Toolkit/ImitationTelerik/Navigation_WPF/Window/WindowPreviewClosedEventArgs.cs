using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// WindowClosingEventArgs exposes DialogResult and PromptResult property
    /// for handling the closing event of a window.
    /// </summary>
    public class WindowPreviewClosedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the WindowPreviewClosedEventArgs class.
        /// </summary>
        public WindowPreviewClosedEventArgs()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether the RadWindow closing will be canceled.
        /// </summary>
        public Nullable<bool> Cancel
        {
			get;
            set;
        }
    }
}