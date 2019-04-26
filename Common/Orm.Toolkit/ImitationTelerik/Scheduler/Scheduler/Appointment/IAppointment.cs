using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Defines basic methods and properties of an appointment.
    /// </summary>
    public interface IAppointment : IDateSpan, INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when <see cref="RecurrencePattern"/> status is changed.
        /// </summary>
        event EventHandler RecurrenceRuleChanged;

        /// <summary>
        /// Gets or sets the <see cref="DateTime"/> value determining the end date and time of the <see cref="IAppointment"/>. 
        /// </summary>
        new DateTime End { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="bool"/> value indicating if the current <see cref="IAppointment"/> is an All-day one. 
        /// </summary>
        bool IsAllDayEvent { get; set; }

        /// <summary>
        /// Gets or sets the recurrence rule.
        /// </summary>
        /// <value>The recurrence rule.</value>
        RecurrenceRule RecurrenceRule { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DateTime"/> value determining the start date and time of the <see cref="IAppointment"/>.
        /// </summary>
        new DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the subject of the <see cref="IAppointment"/> object. 
        /// </summary>
        string Subject { get; set; }

        string StartShortTime { get;  }
        string EndShortTime { get;  }

        string TotalTime { get; }

        bool IsReadOnly { get; }

        bool IsFlickering { get; set; }
        bool CanEdit { get; set; }

        /// <summary>
        /// Gets or sets the appointment time zone.
        /// </summary>
        /// <value>The appointment time zone.</value>
        TimeZoneInfo TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        ResourceCollection Resources
        {
            get;
        }

        /// <summary>
        /// <b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>A <b>deep</b> copy of the current object.</returns>
        IAppointment Copy();

        /// <summary>
        /// <b>Deep</b> copies all properties from <paramref name="other"/> to this <see cref="IAppointment"/>.
        /// </summary>
        /// <param name="other">The <see cref="IAppointment"/> which properties are copied.</param>
        void CopyFrom(IAppointment other);
    }
}