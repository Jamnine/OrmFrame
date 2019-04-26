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
    internal class TestableMouseButtonEventArgs : TestableMouseEventArgs, IMouseButtonEventArgs
    {
        private MouseButtonEventArgs originalButtonArgs;

        internal TestableMouseButtonEventArgs(MouseButtonEventArgs e) : base(e)
        {
            this.originalButtonArgs = e;
        }

        public bool Handled
        {
            get
            {
                return this.originalButtonArgs.Handled;
            }
            set
            {
                this.originalButtonArgs.Handled = value;
            }
        }
    }
}
