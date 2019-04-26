using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal static class RectExtensions
    {
        public static bool IntersectsWithExclusively(this Rect source, Rect other)
        {
            if (source.IsEmpty || other.IsEmpty)
            {
                return false;
            }
            if (source == other)
            {
                return true;
            }
            return (((other.Left < source.Right) && (other.Right > source.Left)) &&
                    (other.Top < source.Bottom)) && (other.Bottom > source.Top);
        }
    }
}