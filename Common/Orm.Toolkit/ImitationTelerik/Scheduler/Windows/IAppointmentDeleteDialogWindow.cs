using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal interface IAppointmentDeleteDialogWindow
    {
        event RoutedEventHandler Closed;
        event RoutedEventHandler Confirmed;
        Occurrence Occurrence { get; set; }
        void Close();
        void Show();
    }
}