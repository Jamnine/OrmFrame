using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal static class VisualExtensions
    {
        public static Point GetOffsetFromVisual(this UIElement source, UIElement element)
        {
            GeneralTransform transform = element.TransformToVisual(source);
            Point rootPoint = transform.Transform(new Point());

            return rootPoint;
        }

        public static void AddMouseDownHandler(this UIElement element, MouseButtonEventHandler handler)
        {
            if (element != null)
            {
                element.MouseDown += handler;

            }
        }

        public static void RemoveMouseDownHandler(this UIElement element, MouseButtonEventHandler handler)
        {
            if (element != null)
            {

                element.MouseDown -= handler;

            }
        }

        public static void AddMouseUpHandler(this UIElement element, MouseButtonEventHandler handler)
        {
            if (element != null)
            {

                element.MouseUp += handler;

            }
        }

        public static void RemoveMouseUpHandler(this UIElement element, MouseButtonEventHandler handler)
        {
            if (element != null)
            {
                element.MouseUp -= handler;

            }
        }
    }
}