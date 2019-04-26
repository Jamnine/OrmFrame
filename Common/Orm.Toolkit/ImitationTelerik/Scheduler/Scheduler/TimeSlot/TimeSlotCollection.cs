using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents a collection of <see cref="TimeSlot"/>.
    /// </summary>
    public class TimeSlotCollection : Collection<TimeSlot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotCollection"/> class.
        /// </summary>
        public TimeSlotCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotCollection"/> class.
        /// </summary>
        /// <param name="items">The list that is wrapped by the new collection.</param>
        /// <exception cref="ArgumentNullException"><paramref name="items"/> is null.</exception>
        public TimeSlotCollection(IEnumerable<TimeSlot> items)
        {
            if (items != null)
            {
                this.AddRange(items);
            }
        }
    }
}