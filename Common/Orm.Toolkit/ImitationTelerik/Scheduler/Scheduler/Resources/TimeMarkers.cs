using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// TimeMarkers class.
    /// </summary>
    public sealed class TimeMarkers
    {
        private TimeMarkers()
        {
        }

        /// <summary>
        /// Gets all time markers.
        /// </summary>
        /// <value>All time markers.</value>
        public static TimeMarkerCollection AllTimeMarkers
        {
            get
            {
                TimeMarkerCollection markers = new TimeMarkerCollection();
                markers.Add(TimeMarkers.Free);
                markers.Add(TimeMarkers.Busy);
                markers.Add(TimeMarkers.OutOfOffice);
                markers.Add(TimeMarkers.Tentative);
                return markers;
            }
        }

        /// <summary>
        /// Gets the free.
        /// </summary>
        /// <value>The free.</value>
        public static TimeMarker Free
        {
            get
            {
                LinearGradientBrush brush = GetTimeMarkerBrush("#FF00C800", "#FF1E841E", new Point(0.5, 0), new Point(0.5, 1));
                return new TimeMarker("Free", brush);
            }
        }

        /// <summary>
        /// Gets the out of office.
        /// </summary>
        /// <value>The out of office.</value>
        public static TimeMarker OutOfOffice
        {
            get
            {
                LinearGradientBrush brush = GetTimeMarkerBrush("#FFFFF502", "#FFF1A202", new Point(0.5, 0), new Point(0.5, 1));
             
                return new TimeMarker("OutOfOffice", brush);
            }
        }

        /// <summary>
        /// Gets the busy.
        /// </summary>
        /// <value>The busy.</value>
        public static TimeMarker Busy
        {
            get
            {
                LinearGradientBrush brush = GetTimeMarkerBrush("#FFFF0606", "#FFBF0303", new Point(0.5, 0), new Point(0.5, 1));
             
                return new TimeMarker("Busy", brush);
            }
        }

        /// <summary>
        /// Gets the tentative.
        /// </summary>
        /// <value>The tentative.</value>
        public static TimeMarker Tentative
        {
            get
            {
                LinearGradientBrush brush = new LinearGradientBrush();
                GradientStopCollection stops = new GradientStopCollection();
                var stop1 = new GradientStop();
                stop1.Offset = 0;
                stop1.Color = TimeMarkers.GetColorFromCode("#FF05529D");
                var stop2 = new GradientStop();
                stop2.Offset = 1;
                stop2.Color = TimeMarkers.GetColorFromCode("#FF05529D");
                var stop3 = new GradientStop();
                stop3.Offset = 0.25;
                stop3.Color = Colors.White;
                var stop4 = new GradientStop();
                stop4.Offset = 0.5;
                stop4.Color = TimeMarkers.GetColorFromCode("#FF05529D");
                var stop5 = new GradientStop();
                stop5.Offset = 0.741;
                stop5.Color = Colors.White;
                stops.Add(stop1);
                stops.Add(stop2);
                stops.Add(stop3);
                stops.Add(stop4);
                stops.Add(stop5);
                brush.GradientStops = stops;
                brush.StartPoint = new Point(2, 2);
                brush.EndPoint = new Point(9, 9);
                brush.SpreadMethod = GradientSpreadMethod.Repeat;
                brush.MappingMode = BrushMappingMode.Absolute;
                return new TimeMarker("Tentative", brush);
            }
        }

        private static Color GetColorFromCode(string value)
        {
            byte byA = Convert.ToByte(value.Substring(1, 2), 16);
            byte byR = Convert.ToByte(value.Substring(3, 2), 16);
            byte byG = Convert.ToByte(value.Substring(5, 2), 16);
            byte byB = Convert.ToByte(value.Substring(7, 2), 16);
            Color c = Color.FromArgb(byA, byR, byG, byB);
            return c;
        }

        private static LinearGradientBrush GetTimeMarkerBrush(string color1, string color2, Point start, Point end)
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.EndPoint = start;
            brush.StartPoint = end;
            GradientStopCollection stops = new GradientStopCollection();
            var stop1 = new GradientStop();
            stop1.Color = TimeMarkers.GetColorFromCode(color1);
            stop1.Offset = 1;
            var stop2 = new GradientStop();
            stop2.Color = TimeMarkers.GetColorFromCode(color2);
            stop2.Offset = 0;
            stops.Add(stop1);
            stops.Add(stop2);
            brush.GradientStops = stops;
            return brush;
        }
    }
}
