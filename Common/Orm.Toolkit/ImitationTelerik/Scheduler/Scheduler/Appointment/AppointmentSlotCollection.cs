using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Observable collection from appointment slots.
    /// </summary>
    public class AppointmentSlotCollection : ObservableCollection<AppointmentSlot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSlotCollection"/> class.
        /// </summary>
        public AppointmentSlotCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentSlotCollection"/> class.
        /// </summary>
        /// <param name="appointmentSlots">The appointment slots that will be added.</param>
        public AppointmentSlotCollection(IEnumerable<AppointmentSlot> appointmentSlots)
        {
            this.AddRange(appointmentSlots);
        }

        /// <summary>
        /// Gets a list with appointment slots that have the specified appointment.
        /// </summary>
        /// <param name="occurrence">The occurrence.</param>
        /// <returns>A list with appointment slots.</returns>
        public IList<AppointmentSlot> GetElementsByOccurrence(Occurrence occurrence)
        {
            return
                (from elem in this
                 where elem.Occurrence == occurrence
                 select elem).ToList();
        }

        /// <summary>
        /// Removes all elements that have the specified appointment.
        /// </summary>
        /// <param name="appointment">The appointment that will be searched for.</param>
        public void RemoveElementsByAppointment(IAppointment appointment)
        {
            IList<AppointmentSlot> removed = this.GetElementsByAppointmentOrByParent(appointment);

            while (removed.Count > 0)
            {
                this.Remove(removed[0]);
                removed.RemoveAt(0);
            }
        }

        private IList<AppointmentSlot> GetElementsByAppointmentOrByParent(IAppointment appointment)
        {
            return
                (from elem in this
                 where
                     elem.Occurrence.Master == appointment ||
                     (elem.Occurrence.Exception != null && elem.Occurrence.Exception == appointment)
                 select elem).ToList();
        }
    }
}