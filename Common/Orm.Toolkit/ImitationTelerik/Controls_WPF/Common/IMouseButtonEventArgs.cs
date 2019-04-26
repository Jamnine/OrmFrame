using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Common
{
    /// <summary>
    /// Abstracts the mouse event args to allow easier testing of mouse-related events.
    /// </summary>
    internal interface IMouseButtonEventArgs : IMouseEventArgs
    {
        bool Handled
        {
            get;
            set;
        }
    }
}
