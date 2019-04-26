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

namespace Orm.Toolkit.Telerik.Windows.Controls.Common
{
    internal class TestableMouseEventArgs : IMouseEventArgs
    {
        private MouseEventArgs originalArgs;

        internal TestableMouseEventArgs(MouseEventArgs e)
        {
            this.originalArgs = e;
        }

        public object OriginalSource
        {
            get
            {
                return this.originalArgs.OriginalSource;
            }
        }

        public Point GetPosition(UIElement relativeTo)
        {
            return this.originalArgs.GetPosition(relativeTo);
        }
    }
}
