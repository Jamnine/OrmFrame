using System;


namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents basic <see cref="IAppointment"/> implementation.
    /// </summary>

    [Serializable]
    public class Appointment : AppointmentBase
    {
        private string body;
        private string location;
        private string uniqueId;
        private string url;
        /// <summary>
        /// Initializes a new instance of the <see cref="Appointment"/> class.
        /// </summary>
        public Appointment()
        {
            this.uniqueId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the body of the <see cref="IAppointment"/> object.
        /// </summary>
        /// <value></value>
        public virtual string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                if (this.body != value)
                {
                    this.body = value;
                    this.OnPropertyChanged("Body");
                }
            }
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (this.location != value)
                {
                    this.location = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        /// <summary>
        /// Gets or sets the unique Id.
        /// </summary>
        /// <value>The unique Id.</value>
        public string UniqueId
        {
            get
            {
                return this.uniqueId;
            }
            set
            {
                if (value != this.uniqueId)
                {
                    this.uniqueId = value;
                    this.OnPropertyChanged("UniqueId");
                }
            }
        }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                if (this.url != value)
                {
                    this.url = value;
                    this.OnPropertyChanged("Url");
                }
            }
        }
         

        

        /// <summary>
        /// 	<b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>
        /// A <b>deep</b> copy of the current object.
        /// </returns>
        public override IAppointment Copy()
        {
            IAppointment appointment = new Appointment();
            appointment.CopyFrom(this);
            return appointment;
        }

        /// <summary>
        /// <b>Deep</b> copies all properties from <paramref name="other"/> to this <see cref="Appointment"/>.
        /// </summary>
        /// <param name="other">The <see cref="Appointment"/> which properties are copied.</param>
        public override void CopyFrom(IAppointment other)
        {
            base.CopyFrom(other);

            var otherAppointment = other as Appointment;
            if (otherAppointment == null)
                return;
            this.Resources.Clear();
            foreach (var resource in otherAppointment.Resources)
            {
                this.Resources.Add(resource);
            }
            this.Body = otherAppointment.Body;
            this.UniqueId = otherAppointment.UniqueId;
            this.Url = otherAppointment.Url;
            this.Location = otherAppointment.Location;
        } 
    }
}