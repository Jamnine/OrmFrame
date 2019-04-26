using System;
using System.Net;
using System.Windows;
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
    /// A browser wrapper for dialogs.
    /// </summary>
    public class WindowWrapper : Control, IThemable
    {
        private readonly DialogWindow dialogWindow;
        private readonly RadWindow popupWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowWrapper"/> class.
        /// </summary>
        /// <param name="dialogWindow">The dialog window.</param>
        public WindowWrapper(DialogWindow dialogWindow)
        {
            this.dialogWindow = dialogWindow;
            this.popupWindow = new RadWindow();
            this.popupWindow.Header = String.Empty;
            this.popupWindow.ResizeMode = ResizeMode.NoResize;
            this.popupWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.popupWindow.Closed += this.PopupWindow_Closed;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public object Title
        {
            get
            {
                return this.popupWindow.Header;
            }
            set
            {
                this.popupWindow.Header = value;
            }
        }

        /// <summary>
        /// Gets or sets the icon template.
        /// </summary>
        /// <value>The icon template.</value>
        public DataTemplate IconTemplate
        {
            get
            {
                return this.popupWindow.IconTemplate;
            }
            set
            {
                this.popupWindow.IconTemplate = value;
            }
        }

        /// <summary>
        /// Gets the popup window.
        /// </summary>
        /// <value>The popup window.</value>
        internal RadWindow PopupWindow
        {
            get
            {
                return this.popupWindow;
            }
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            this.popupWindow.Content = this.dialogWindow;
            if (this.dialogWindow.IsModal)
            {
                this.popupWindow.ShowDialog();
            }
            else
            {
                this.popupWindow.Show();
            }
            this.dialogWindow.Focus();
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        public void Close()
        {
            this.popupWindow.Close();
        }

        /// <summary>
        /// Resets the theme.
        /// </summary>
        public void ResetTheme()
        {
            StyleManager.SetTheme(this.popupWindow, StyleManager.GetTheme(this));
            StyleManager.SetTheme(this.dialogWindow, StyleManager.GetTheme(this));
        }

        private void PopupWindow_Closed(object sender, WindowClosedEventArgs e)
        {
            this.dialogWindow.Close();
        }
    }
}
