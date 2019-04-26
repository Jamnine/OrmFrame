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
    /// Specifies response buttons in window that will act as default 
    /// buttons upon keyboard strokes. Used by ResponseButton attached property.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
    public enum ResponseButton
    {
        /// <summary>
        /// Accept will invoke the button's click method when the user
        /// hits Enter.
        /// </summary>
        Accept = 1,

        /// <summary>
        /// Cancel will invoke the button's click method when the user hits ESC.
        /// </summary>
        Cancel = 2,
    }
}
