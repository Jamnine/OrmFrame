using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal interface ISchedulerConverter : IValueConverter
    {
        IScheduler Scheduler { get; set; }
    }
}