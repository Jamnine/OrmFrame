using System.Windows;
using System.Windows.Markup;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents a window that is used by <see cref="RadScheduler"/>. The main purpose of this window
    /// is to provide an implementation for theming mechanism used by telerik.
    /// </summary>
    public class SchedulerWindow :
        DialogWindow
    {
         /// <summary>
        /// Identifies the <see cref="Scheduler"/> property.
        /// </summary>
        /// <returns>The identifier for the <see cref="Scheduler"/> property</returns>
        public static readonly DependencyProperty SchedulerProperty =
            DependencyProperty.Register(
                "Scheduler",
                typeof(IScheduler),
                typeof(SchedulerWindow),
                new PropertyMetadata(null, OnSchedulerChanged));

        /// <summary>
        /// Gets or sets the scheduler that this window will use. This is a dependency property.
        /// </summary>
        /// <returns>The scheduler that have created this window. The default value is null.</returns>  
        public IScheduler Scheduler
        {
            get
            {
                return (IScheduler)this.GetValue(SchedulerProperty);
            }
            set
            {
                this.SetValue(SchedulerProperty, value);
            }
        }
        
        private static void OnSchedulerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = (SchedulerWindow)d;
            
            var scheduler = e.NewValue as RadScheduler;
            if (scheduler != null)
            {
                Theme theme = StyleManager.GetTheme(scheduler);
                StyleManager.SetTheme(window.WindowWrapper.PopupWindow, theme);

                window.Language = XmlLanguage.GetLanguage(scheduler.GetCultureInUse().IetfLanguageTag);

            }
        }
    }
}