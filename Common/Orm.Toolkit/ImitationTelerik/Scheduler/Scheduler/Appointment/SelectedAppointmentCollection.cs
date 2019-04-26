using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents observable collection with ability to select an appointment.
    /// </summary>
    internal class SelectedAppointmentCollection : DeferrableObservableCollection<IAppointment>
    {
        private IAppointment selectedAppointment;
        private bool shouldUpdateSelectedAppointment = true;
        private bool shouldUpdateSelectedAppointments = true;

        public IAppointment SelectedAppointment
        {
            get
            {
                return this.selectedAppointment;
            }
            set
            {
                if (this.selectedAppointment != value)
                {
                    this.selectedAppointment = value;
                    this.OnSelectedAppointmentChanged();
                    this.OnPropertyChanged(new PropertyChangedEventArgs("SelectedAppointment"));
                }
            }
        }

        /// <summary>
        /// Adds the appointment if it is not present in the collection.
        /// </summary>
        /// <param name="appointment">The appointment that should be added.</param>
        /// <returns>
        /// <c>true</c> if the appointment is successfully added, otherwise <c>false</c>.
        /// </returns>
        public bool AddIfNotPresent(IAppointment appointment)
        {
            if (!this.Contains(appointment))
            {
                this.Add(appointment);
                return true;
            }
            return false;
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnCollectionChanged(e);

            if (!this.shouldUpdateSelectedAppointment)
            {
                return;
            }

            if (this.IsRefreshDeferred)
            {
                return;
            }

            IAppointment firstAppointment = this.FirstOrDefault();
            if (this.SelectedAppointment != firstAppointment)
            {
                this.shouldUpdateSelectedAppointments = false;
                this.SelectedAppointment = firstAppointment;
                this.shouldUpdateSelectedAppointments = true;
            }
        }

        private void OnSelectedAppointmentChanged()
        {
            // If the update of SelectedAppoitment is triggered by changing SelectedAppointments do nothing.
            if (!this.shouldUpdateSelectedAppointments)
            {
                return;
            }

            if (this.selectedAppointment != null)
            {
                if (this.Contains(this.selectedAppointment))
                {
                    this.RemoveAll<IAppointment>(a => a != this.selectedAppointment);
                }
                else
                {
                    // Note: not using clear but removing one by one, to match WPF Selector's behaviour

                    // Do not update selected appointment when collection is changed (by removing all elements),
                    // because when we have 0 elements SelectedAppointment will be set to null, which is not the
                    // desired behaviour.
                    this.shouldUpdateSelectedAppointment = false;

                    this.RemoveAll();
                    this.Add(this.selectedAppointment);

                    this.shouldUpdateSelectedAppointment = true;
                }
            }
            else
            {
                this.RemoveAll();
            }
        }
    }
}