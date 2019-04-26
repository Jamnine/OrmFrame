using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Provides class, working with recurring appointment.
    /// </summary>
    public class RecurrenceRule
    {
        private readonly ICollection<ExceptionOccurrence> exceptions = new Collection<ExceptionOccurrence>();
        private RecurrencePattern pattern;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecurrenceRule"/> class.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        public RecurrenceRule(RecurrencePattern pattern)
        {
            this.pattern = pattern;
            this.pattern.PropertyChanged += this.PatternPropertyChanged;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="RecurrenceRule"/> class from being created.
        /// </summary>
        private RecurrenceRule()
        {
        }

        /// <summary>
        /// Occurs when state of the rule changed.
        /// </summary>
        public event EventHandler StateChanged;

        /// <summary>
        /// Gets the exceptions.
        /// </summary>
        /// <value>The exceptions.</value>
        public IEnumerable<ExceptionOccurrence> Exceptions
        {
            get
            {
                return this.exceptions;
            }
        }

        /// <summary>
        /// Gets or sets the recurrence pattern.
        /// </summary>
        /// <value>The recurrence pattern.</value>
        public RecurrencePattern Pattern
        {
            get
            {
                return this.pattern;
            }
            set
            {
                if (this.pattern != value)
                {
                    if (this.pattern != null)
                    {
                        this.pattern.PropertyChanged -= this.PatternPropertyChanged;
                    }

                    this.pattern = value;

                    if (this.pattern != null)
                    {
                        this.pattern.PropertyChanged += this.PatternPropertyChanged;
                    }

                    this.OnStateChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Adds the exception date.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public void AddException(DateTime dateTime)
        {
            this.AddException(dateTime, null);
        }

        /// <summary>
        /// Adds the exception on given date.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        /// <param name="appointment">The appointment.</param>
        public void AddException(DateTime dateTime, IAppointment appointment)
        {
            this.exceptions.Add(new ExceptionOccurrence { ExceptionDate = dateTime, Appointment = appointment });
            this.OnStateChanged(EventArgs.Empty);
        }

        /// <summary>
        /// 	<b>Deep</b> copies this instance.
        /// </summary>
        /// <returns>
        /// A <b>deep</b> copy of the current object.
        /// </returns>
        public RecurrenceRule Copy()
        {
            var rule = new RecurrenceRule();
            rule.CopyFrom(this);
            return rule;
        }

        /// <summary>
        /// Copies from.
        /// </summary>
        /// <param name="other">The other.</param>
        public void CopyFrom(RecurrenceRule other)
        {
            if (this.GetType().FullName != other.GetType().FullName)
            {
                throw new ArgumentException("Invalid type");
            }

            this.Pattern = other.Pattern.Copy();
            this.exceptions.Clear();
            foreach (ExceptionOccurrence exception in other.exceptions)
            {
                this.exceptions.Add(exception.Copy());
            }

            this.OnStateChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Removes the appointment exception. Converts it to an exception with missing occurrence.
        /// </summary>
        /// <param name="appointment">The exceptional appointment.</param>
        public void RemoveException(IAppointment appointment)
        {
            this.exceptions.ForEach(
                ex =>
                    {
                        if (ex.Appointment == appointment)
                        {
                            ex.Appointment = null;
                        }
                    });
            this.OnStateChanged(EventArgs.Empty);
        }

        /// <summary>
        /// Replaces exception occurrence from exceptions collection. 
        /// </summary>
        /// <param name="appointment">The exceptional appointment which represents the exception to replace.</param>
        public void ReplaceExceptionOccurrence(IAppointment appointment)
        {
            var tempDate = new DateTime();
            this.exceptions.ForEach(
                delegate(ExceptionOccurrence ex)
                    {
                        if (ex.Appointment == appointment)
                        {
                            tempDate = ex.ExceptionDate;
                        }
                    });
            this.exceptions.RemoveAll(ex => ex.Appointment == appointment);
            this.AddException(tempDate, appointment);
        }

        /// <summary>
        /// Raises the <see cref="StateChanged"/> event.
        /// </summary>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnStateChanged(EventArgs args)
        {
            if (this.StateChanged != null)
            {
                this.StateChanged(this, args);
            }
        }

        private void PatternPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.OnStateChanged(EventArgs.Empty);
        }
    }
}