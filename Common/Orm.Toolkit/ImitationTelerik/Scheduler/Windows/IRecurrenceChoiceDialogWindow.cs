using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal interface IRecurrenceChoiceDialogWindow
    {
        event RoutedEventHandler Closed;
        event RoutedEventHandler Confirmed;
        bool IsDeleting { get; set; }
        Occurrence Occurrence { get; set; }
        RecurrenceMode SelectedMode { get; set; }
        void Close();
        void Show();
    }
}