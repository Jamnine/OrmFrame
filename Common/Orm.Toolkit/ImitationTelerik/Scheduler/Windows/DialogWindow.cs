using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Orm.Toolkit.Telerik.Windows;
using Orm.Toolkit.Telerik.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A dialog window for adding and editing appointments.
    /// </summary>
    public class DialogWindow : Control, IThemable
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty IsModalProperty =
        DependencyProperty.Register("IsModal",
                                    typeof(bool),
                                    typeof(DialogWindow),
                                    new FrameworkPropertyMetadata(false));

        /// <summary>
        /// Identifies the <see cref="HeaderTemplate"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="HeaderTemplate"/> property.</returns>
        public static readonly DependencyProperty HeaderTemplateProperty =
            DependencyProperty.Register("HeaderTemplate", typeof(DataTemplate), typeof(DialogWindow), new PropertyMetadata(null, OnHeaderTemplatePropertyChanged));

        /// <summary>
        /// Identifies the <see cref="Title"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Title"/> property.</returns>
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title",
                                        typeof(string),
                                        typeof(DialogWindow),
                                        new FrameworkPropertyMetadata(string.Empty, OnTitleChanged));

        /// <summary>
        /// Identifies the <see cref="IconTemplate"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="IconTemplate"/> property.</returns>
        public static readonly DependencyProperty IconTemplateProperty =
                 DependencyProperty.Register("IconTemplate",
                                             typeof(DataTemplate),
                                             typeof(DialogWindow),
                                             new FrameworkPropertyMetadata(null, OnIconTemplateChanged));

        /// <summary>
        /// Identifies the <see cref="Closing"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="Closing"/> event.</returns>
        public static readonly RoutedEvent ClosingEvent =
            EventManager.RegisterRoutedEvent("Closing",
                                            RoutingStrategy.Direct,
                                            typeof(EventHandler<CancelRoutedEventArgs>),
                                            typeof(DialogWindow));

        /// <summary>
        /// Identifies the <see cref="Closed"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="Closed"/> event.</returns>
        public static readonly RoutedEvent ClosedEvent =
            EventManager.RegisterRoutedEvent("Closed",
                                            RoutingStrategy.Direct,
                                            typeof(RoutedEventHandler),
                                            typeof(DialogWindow));

        private readonly WindowWrapper window;

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogWindow"/> class.
        /// </summary>
        public DialogWindow()
        {
            this.window = new WindowWrapper(this);
        }

        /// <summary>
        /// Occurs directly after <see cref="Close()"/>  is called and can be handled to cancel window closure.
        /// </summary>
        public event RoutedEventHandler Closing
        {
            add
            {
                this.AddHandler(ClosingEvent, value);
            }
            remove
            {
                this.RemoveHandler(ClosingEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the window is about to be closed.
        /// </summary>    
        public event RoutedEventHandler Closed
        {
            add
            {
                this.AddHandler(ClosedEvent, value);
            }
            remove
            {
                this.RemoveHandler(ClosedEvent, value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is modal.
        /// </summary>
        /// <value><c>True</c> if this instance is modal; otherwise, <c>false</c>.</value>
        public bool IsModal
        {
            get
            {
                return (bool)GetValue(IsModalProperty);
            }
            set
            {
                SetValue(IsModalProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the window's title. This is a dependency property.
        /// </summary>
        /// <returns>A <see cref="string"/> that contains the window's title.</returns>
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets the window's HeaderTemplate. This is a dependency property.
        /// </summary>
        /// <returns>A <see cref="DataTemplate"/> that represents how the window is displaying its title.</returns>
        public DataTemplate HeaderTemplate
        {
            get { return (DataTemplate)GetValue(HeaderTemplateProperty); }
            set { SetValue(HeaderTemplateProperty, value); }
        }
       
        /// <summary>
        /// Gets or sets the window's title. This is a dependency property.
        /// </summary>
        /// <returns>A <see cref="string"/> that contains the window's title.</returns>
        public DataTemplate IconTemplate
        {
            get
            {
                return (DataTemplate)GetValue(IconTemplateProperty);
            }
            set
            {
                SetValue(IconTemplateProperty, value);
            }
        }

        /// <summary>
        /// Gets the popup window.
        /// </summary>
        /// <value>The popup window.</value>
        internal WindowWrapper WindowWrapper
        {
            get
            {
                return this.window;
            }
        }

        /// <summary>
        /// Opens the window.
        /// </summary>
        public void Show()
        {
            this.window.Show();
        }

        /// <summary>
        /// Manually closes the window.
        /// </summary>
        public void Close()
        {
            var args = new CancelRoutedEventArgs(ClosingEvent, this)
            {
                Cancel = false
            };
            this.OnClosing(args);
            if (!args.Cancel)
            {
                this.window.Close();
                this.OnClosed(new RadRoutedEventArgs(ClosedEvent));
            }
        }

        /// <summary>
        /// Resets the theme.
        /// </summary>
        public void ResetTheme()
        {
            StyleManager.SetTheme(this.window, StyleManager.GetTheme(this));
        }

        /// <summary>
        /// Raises the <see cref="Closing"/> event.
        /// </summary>
        /// <param name="args">The <see cref="Telerik.Windows.Controls.CancelRoutedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnClosing(CancelRoutedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="Closed"/> event.
        /// </summary>
        /// <param name="args">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnClosed(RadRoutedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        private static bool ValidateText(object value)
        {
            return value != null;
        }

        private static void OnHeaderTemplatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dialogWindow = (DialogWindow)d;
            dialogWindow.window.PopupWindow.HeaderTemplate = (DataTemplate)e.NewValue;
        }

        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dialogWindow = (DialogWindow)d;
            var key = LocalizationManager.GetString((string)e.NewValue);
            if (key != null)
            {
                dialogWindow.window.Title = LocalizationManager.GetString((string)e.NewValue);
            }
            else
            {
                dialogWindow.window.Title = (string)e.NewValue;
            }
        }
        private static void OnIconTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dialogWindow = (DialogWindow)d;
            dialogWindow.window.IconTemplate = (DataTemplate)e.NewValue;
        }
    }
}
