using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A TimeMarker assigned to the appointment.
    /// </summary>
    public class TimeMarker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeMarker"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="brush">The brush.</param>
        public TimeMarker(string name, Brush brush)
        {
            this.TimeMarkerName = LocalizationManager.GetString(name);
            this.TimeMarkerBrush = brush;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeMarker"/> class.
        /// </summary>
        public TimeMarker()
        {
        }

        /// <summary>
        /// Gets or sets the name of the time marker.
        /// </summary>
        /// <value>The name of the time marker.</value>
        public string TimeMarkerName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the time marker brush.
        /// </summary>
        /// <value>The time marker brush.</value>
        public Brush TimeMarkerBrush
        {
            get;
            set;
        }
    }
}
