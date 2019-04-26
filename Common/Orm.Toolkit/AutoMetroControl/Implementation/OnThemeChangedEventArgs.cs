using System;
using System.Runtime.CompilerServices;

namespace Orm.Toolkit.Metro
{
    public class OnThemeChangedEventArgs : EventArgs
    {
        public Accent Accent { get; set; }

        public Theme Theme { get; set; }
    }
}
