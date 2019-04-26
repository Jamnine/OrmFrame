using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Class representing the group item.
    /// </summary>
    public class GroupItem
    {
        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        /// <value>The resource.</value>
        public IResource Resource
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the appointment.
        /// </summary>
        /// <value>The appointment.</value>
        public IAppointment Appointment
        {
            get;
            set;
        }
    }
}
