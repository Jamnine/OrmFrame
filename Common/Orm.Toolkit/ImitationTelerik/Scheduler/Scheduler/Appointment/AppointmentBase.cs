using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Importance enumeration.
    /// </summary>
    public enum Importance
    {
        /// <summary>
        /// Without importance.
        /// </summary>
        None = 0,

        /// <summary>
        /// High importance.
        /// </summary>
        High = 1,

        /// <summary>
        /// Low importance.
        /// </summary>
        Low = 2
    }

    /// <summary>
    /// Provides base class for appointments.
    /// </summary>
    public abstract class AppointmentBase : IAppointment
    {
        private DateTime end;
        private bool isAllDayEvent;
        private RecurrenceRule recurrenceRule;
        private DateTime start;
        private string subject;
        private ResourceCollection resources = new ResourceCollection();
        private TimeZoneInfo timeZone;
        private TimeMarker timeMarker;
        private Importance importance;
        private Category category;
        private bool isReadOnly;
        private bool _canEdit;


        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentBase"/> class.
        /// </summary>
        protected AppointmentBase()
        {
            this.start = DateTime.MinValue;
            this.end = DateTime.MaxValue;
            this.timeZone = TimeZoneInfo.Local;
            this.importance = Importance.None;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when <see cref="RecurrenceRule"/> status is changed.
        /// </summary>
        public event EventHandler RecurrenceRuleChanged;

        public  string StartShortTime
        {
            get
            {
                return this.Start.ToString("HH:mm");
            }
             
        }

        public string EndShortTime
        {
            get
            {
                return this.End.ToString("HH:mm");
            }

        }

        public string TotalTime
        {
            get 
            {
                return (this.End - this.Start).TotalMinutes.ToString();
            }
        }
        /// <summary>
        /// Gets or sets the <see cref="DateTime"/> value determining the end date and time of the <see cref="IAppointment"/>.
        /// </summary>
        /// <value></value>
        public virtual DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (value != this.end)
                {
                    this.end = value;
                    this.OnPropertyChanged("End");
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="bool"/> value indicating if the current <see cref="IAppointment"/> is an All-day one.
        /// </summary>
        /// <value></value>
        public virtual bool IsAllDayEvent
        {
            get
            {
                return this.isAllDayEvent;
            }
            set
            {
                if (this.isAllDayEvent != value)
                {
                    this.isAllDayEvent = value;
                    this.OnPropertyChanged("IsAllDayEvent");
                }
            }
        }

        private bool _isFlickering;
        /// <summary>
        /// 闪烁
        /// </summary>
        public virtual bool IsFlickering
        {
            get
            {
                return this._isFlickering;
            }
            set
            {
                if (this._isFlickering != value)
                {
                    this._isFlickering = value;
                    this.OnPropertyChanged("IsFlickering");
                }
            }
        }

        /// <summary>
        /// Gets or sets the recurrence rule.
        /// </summary>
        /// <value>The recurrence rule.</value>
        public virtual RecurrenceRule RecurrenceRule
        {
            get
            {
                return this.recurrenceRule;
            }
            set
            {
                if (this.recurrenceRule != value)
                {
                    if (this.recurrenceRule != null)
                    {
                        this.recurrenceRule.StateChanged -= this.OnRecurrenceRuleStateChanged;
                    }
                    this.recurrenceRule = value;
                    if (this.recurrenceRule != null)
                    {
                        this.recurrenceRule.StateChanged += this.OnRecurrenceRuleStateChanged;
                        TimeSpan duration = this.End - this.Start;
                        DateTime? next = this.recurrenceRule.Pattern.GetFirstOccurrence(this.Start);
                        if (next != null)
                        {
                            this.Start = next.Value;
                            this.End = this.Start + duration;
                        }
                    }
                    this.OnPropertyChanged("RecurrenceRule");
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="DateTime"/> value determining the start date and time of the <see cref="IAppointment"/>.
        /// </summary>
        /// <value></value>
        public virtual DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                if (value != this.start)
                {
                    this.start = value;
                    this.OnPropertyChanged("Start"); 
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the subject of the <see cref="IAppointment"/> object.
        /// </summary>
        /// <value></value>
        public virtual string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                if (this.subject != value)
                {
                    this.subject = value;
                    this.OnPropertyChanged("Subject");
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the subject of the <see cref="IAppointment"/> object.
        /// </summary>
        /// <value></value>
        public virtual ResourceCollection Resources
        {
            get
            {
                return this.resources;
            }
        }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        public virtual TimeZoneInfo TimeZone
        {
            get
            {
                return this.timeZone;
            }
            set
            {
                if (value != this.timeZone)
                {
                    this.timeZone = value;
                    this.OnPropertyChanged("TimeZone");
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the body of the <see cref="IAppointment"/> object.
        /// </summary>
        /// <value></value>
        public virtual TimeMarker TimeMarker
        {
            get
            {
                return this.timeMarker;
            }
            set
            {
                if (this.timeMarker != value)
                {
                    this.timeMarker = value;
                    this.OnPropertyChanged("TimeMarker");
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the body of the <see cref="IAppointment"/> object.
        /// </summary>
        /// <value></value>
        public virtual Category Category
        {
            get
            {
                return this.category;
            }
            set
            {
                if (this.category != value)
                {
                    this.category = value;
                    this.OnPropertyChanged("Category");
                }
            }
        }

        /// <summary>
        /// Gets or sets the importance.
        /// </summary>
        /// <value>The importance.</value>
        public virtual Importance Importance
        {
            get
            {
                return this.importance;
            }
            set
            {
                if (value != this.importance)
                {
                    this.importance = value;
                    this.OnPropertyChanged("Importance");
                }
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return this.isReadOnly;
            }
            set
            {
                if (this.isReadOnly != value)
                {
                    this.isReadOnly = value;
                    this.OnPropertyChanged("IsReadOnly");
                }
            }
        }
        /// <summary>
        /// 可以编辑
        /// </summary>
        public bool CanEdit
        {
            get
            {
                return this._canEdit;
            }
            set
            {
                if (this._canEdit != value)
                {
                    this._canEdit = value;
                    this.OnPropertyChanged("CanEdit");
                }
            }
        }

        /// <summary>
        /// 	<b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>
        /// A <b>deep</b> copy of the current object.
        /// </returns>
        public abstract IAppointment Copy();

        /// <summary>
        /// 	<b>Deep</b> copies all properties from <paramref name="other"/> to this <see cref="IAppointment"/>.
        /// </summary>
        /// <param name="other">The <see cref="IAppointment"/> which properties are copied.</param>
        public virtual void CopyFrom(IAppointment other)
        {
            this.IsAllDayEvent = other.IsAllDayEvent;
            this.Start = other.Start;
            this.End = other.End;
            this.Subject = other.Subject;
            if (other.RecurrenceRule == null)
            {
                this.RecurrenceRule = null;
            }
            else
            {
                if (this.RecurrenceRule == null)
                {
                    this.RecurrenceRule = other.RecurrenceRule.Copy();
                }
                else
                {
                    this.RecurrenceRule.CopyFrom(other.RecurrenceRule);
                }
            }
            var otherAppointment = other as AppointmentBase;
            if (otherAppointment == null)
                return;

            this.Category = otherAppointment.Category;
            this.TimeMarker = otherAppointment.TimeMarker;
            this.Importance = otherAppointment.Importance;
        }

        /// <summary>
        /// Called when some property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Raises the <see cref="RecurrenceRuleChanged"/> event.
        /// </summary>
        /// <param name="args">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected virtual void OnRecurrenceRuleChanged(EventArgs args)
        {
            if (this.RecurrenceRuleChanged != null)
            {
                this.RecurrenceRuleChanged(this, args);
            }
        }

        private void OnRecurrenceRuleStateChanged(object sender, EventArgs e)
        {
            this.OnRecurrenceRuleChanged(EventArgs.Empty);
        }
    }
}