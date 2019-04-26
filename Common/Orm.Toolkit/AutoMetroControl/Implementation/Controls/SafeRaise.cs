using System;
using System.Runtime.CompilerServices;
    

namespace Orm.Toolkit.Metro.Controls
{
    internal static class SafeRaise
    {
        public static void Raise(EventHandler eventToRaise, object sender)
        {
            if (eventToRaise != null)
            {
                eventToRaise(sender, EventArgs.Empty);
            }
        }

        public static void Raise(EventHandler<EventArgs> eventToRaise, object sender)
        {
            Raise<EventArgs>(eventToRaise, sender, EventArgs.Empty);
        }

        public static void Raise<T>(EventHandler<T> eventToRaise, object sender, T args) where T : EventArgs
        {
            if (eventToRaise != null)
            {
                eventToRaise(sender, args);
            }
        }

        public static void Raise<T>(EventHandler<T> eventToRaise, object sender, GetEventArgs<T> getEventArgs) where T : EventArgs
        {
            if (eventToRaise != null)
            {
                eventToRaise(sender, getEventArgs());
            }
        }

        public delegate T GetEventArgs<T>() where T : EventArgs;
    }
}
