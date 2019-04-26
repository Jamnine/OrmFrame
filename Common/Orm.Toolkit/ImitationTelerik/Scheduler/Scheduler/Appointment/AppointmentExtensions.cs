using System;
using System.Collections.Generic;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Extension methods for <see cref="IAppointment"/> interface.
    /// </summary>
    public static class AppointmentExtensions
    {
        /// <summary>
        /// Gets occurrences of the appointment. Generate the appointment's occurrences for a given interval.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <param name="from">From date.</param>
        /// <param name="to">To date.</param>
        /// <returns></returns>
        public static IList<Occurrence> GetOccurrences(
            this IAppointment appointment,
            DateTime from,
            DateTime to)
        {
            IList<Occurrence> occurrences = new List<Occurrence>();

            if (appointment.IsRecurring())
            {
                to = to.AddMilliseconds(-1);
                from = from.Subtract(appointment.Duration()).AddMilliseconds(1);
                List<DateTime> dateTimes =
                    appointment.RecurrenceRule.Pattern.GetOccurrences(appointment.Start, from, to).ToList();

                foreach (ExceptionOccurrence exception in appointment.RecurrenceRule.Exceptions)
                {
                    while (dateTimes.Contains(exception.ExceptionDate))
                        dateTimes.Remove(exception.ExceptionDate);
                    if (exception.Appointment != null)
                    {
                        occurrences.Add(Occurrence.CreateException(appointment, exception.Appointment));
                    }
                }

                TimeSpan duration = appointment.End - appointment.Start;

                foreach (DateTime dateTime in dateTimes)
                {
                    occurrences.Add(Occurrence.CreateOccurrence(appointment, dateTime, dateTime.Add(duration)));
                }
            }
            else
            {
                occurrences.Add(Occurrence.CreateMaster(appointment));
            }

            return occurrences;
        }

        /// <summary>
        /// Determines whether is specified appointment all day.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <returns>
        /// 	<c>True</c> if IsAllDayEvent or Duration is more then one day; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAllDay(this IAppointment appointment)
        {
            TimeSpan duration = appointment.End - appointment.Start;
            return appointment.IsAllDayEvent || duration.Days >= 1;
        }

        internal static IList<AppointmentSlot> GetAppointmentSlots(
            this IAppointment appointment, TimeSlotCollectionView timeSlots)
        {
            var slots = new List<AppointmentSlot>();

            var effectiveRange = new TimeSlotGroup(timeSlots);

            foreach (Occurrence occurrence in appointment.GetOccurrences(effectiveRange.Start, effectiveRange.End))
            {
                slots.AddRange(
                    CreateAppointmentSlots(
                        timeSlots, occurrence, timeSlot => new AppointmentSlot(occurrence, timeSlot)));
            }

            return slots;
        }

        /// <summary>
        /// Determines whether the specified appointment is recurring.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <returns>
        /// 	<c>true</c> if the specified appointment is recurring; otherwise, <c>false</c>.
        /// </returns>
        internal static bool IsRecurring(this IAppointment appointment)
        {
            return appointment.RecurrenceRule != null;
        }

        private static IEnumerable<AppointmentSlot> CreateAppointmentSlots(
            TimeSlotCollectionView timeSlots, IDateSpan intersection, Func<TimeSlot, AppointmentSlot> slotCreator)
        {
            return
                from g in timeSlots.Groups
                let intersected =
                    from slot in g.TimeSlots
                    where intersection.IntersectsWith(slot)
                    select slot
                where intersected.Count() > 0
                select slotCreator(new TimeSlotGroup(intersected));
        }
    }
}