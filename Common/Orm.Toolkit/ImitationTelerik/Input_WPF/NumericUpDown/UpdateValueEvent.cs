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
    /// Specifies when the Value property will be changed.
    /// </summary>
    public enum UpdateValueEvent
    {
        /// <summary>
        /// The Value property will be changed immediately after the user input.
        /// </summary>
        PropertyChanged,

        /// <summary>
        /// The Value property will be changed when the focus leaves the control.
        /// </summary>
        LostFocus
    }
}