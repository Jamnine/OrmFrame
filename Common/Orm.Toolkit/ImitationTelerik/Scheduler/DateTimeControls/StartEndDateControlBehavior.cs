using System;
using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal sealed class StartEndDateControlBehavior : AttachedBehavior
    {
        private IDateTimeControl endControl;
        private IDateTimeControl startControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="StartEndDateControlBehavior"/> class.
        /// </summary>
        /// <param name="startControl">The start control.</param>
        /// <param name="endControl">The end control.</param>
        /// <exception cref="ArgumentNullException"><paramref name="startControl" /> or <paramref name="endControl"/> is null.</exception>
        public StartEndDateControlBehavior(IDateTimeControl startControl, IDateTimeControl endControl)
        {
            if (startControl == null)
            {
                throw new ArgumentNullException("startControl");
            }

            if (endControl == null)
            {
                throw new ArgumentNullException("endControl");
            }

            this.startControl = startControl;
            this.endControl = endControl;
        }

        public event EventHandler EndDateInvalidated;

        /// <summary>
        /// Gets or sets the end control.
        /// </summary>
        /// <value>The end control.</value>
        /// <exception cref="ArgumentNullException"><c>value</c> is null.</exception>
        public IDateTimeControl EndControl
        {
            get
            {
                return this.endControl;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (this.endControl != value)
                {
                    if (this.IsAttached)
                    {
                        if (this.endControl != null)
                        {
                            this.endControl.SelectedDateTimeChanged -= this.OnEndControlDateChanged;
                        }

                        value.SelectedDateTimeChanged += this.OnEndControlDateChanged;
                    }

                    this.endControl = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the start control.
        /// </summary>
        /// <value>The start control.</value>
        /// <exception cref="ArgumentNullException"><c>value</c> is null.</exception>
        public IDateTimeControl StartControl
        {
            get
            {
                return this.startControl;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                if (this.startControl != value)
                {
                    if (this.IsAttached)
                    {
                        if (this.startControl != null)
                        {
                            this.startControl.SelectedDateTimeChanged -= this.OnStartControlDateChanged;
                        }

                        value.SelectedDateTimeChanged += this.OnStartControlDateChanged;
                    }

                    this.startControl = value;
                }
            }
        }

        /// <summary>
        /// Attach the behavior.
        /// </summary>
        /// <exception cref="InvalidOperationException"><c>InvalidOperationException</c>.</exception>
        public override void Attach()
        {
            this.StartControl.SelectedDateTimeChanged += this.OnStartControlDateChanged;
            this.EndControl.SelectedDateTimeChanged += this.OnEndControlDateChanged;

            base.Attach();
            this.SetEndControlTimeItemsStart();
        }

        public override void Detach()
        {
            this.StartControl.SelectedDateTimeChanged -= this.OnStartControlDateChanged;
            this.EndControl.SelectedDateTimeChanged -= this.OnEndControlDateChanged;

            base.Detach();
        }

        private void OnEndControlDateChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            // We should not allow setting end before the start
            if (this.StartControl.SelectedDateTime > e.NewValue)
            {
                // Revert to old value
                this.EndControl.SelectedDateTime = e.OldValue;

                this.OnEndDateInvalidated();
            }
            this.SetEndControlTimeItemsStart();
        }

        private void SetEndControlTimeItemsStart()
        {
            if (!this.EndControl.SelectedDateTime.HasValue || !this.StartControl.SelectedDateTime.HasValue)
            {
                return;
            }

            var res = this.EndControl.SelectedDateTime.Value - this.StartControl.SelectedDateTime.Value;
            if (res.Days < 1)
            {
                this.EndControl.TimePickerStartTime = this.StartControl.SelectedDateTime.Value.TimeOfDay;
            }
            else
            {
                this.EndControl.TimePickerStartTime = new TimeSpan(0, 0, 0);

            }
        }

        private void OnEndDateInvalidated()
        {
            if (this.EndDateInvalidated != null)
            {
                this.EndDateInvalidated(this, EventArgs.Empty);
            }
        }

        private void OnStartControlDateChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            TimeSpan? duration = e.NewValue - e.OldValue;
            if (duration != null && !duration.Value.IsZero())
            {
                this.EndControl.SelectedDateTime += duration;
            }
            this.SetEndControlTimeItemsStart();
        }
    }
}