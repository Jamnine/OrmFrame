using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal interface IAppointmentClosingDialogWindow
    {
        event RoutedEventHandler Closed;
        event RoutedEventHandler Confirmed;
        void Close();
        void Show();
    }
}