using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;


namespace Orm.Toolkit.Telerik.Windows.Controls
{

    internal class AppointmentResizeManager
    {
        private readonly AppointmentItemsControl itemsControl;
        private Cursor cursor;

        private AppointmentSlot resizedAppointmentSlot;
        private AppointmentResizeMode resizeMode;
        private TimeSpan? resizeOffset;
        private List<TimeSlotItem> timeSlotItems;

        public AppointmentResizeManager(AppointmentItemsControl itemsControl)
        {
            this.itemsControl = itemsControl;
        }
        
        internal AppointmentItemsControl ItemsControl
        {
            get
            {
                return this.itemsControl;
            }
        }
        internal TimeSlotItemsControl TimeSlotItemsControl
        {
            get
            {
                if (this.AppointmentsControl != null)
                {
                    return this.AppointmentsControl.FindChildByType<TimeSlotItemsControl>();
                }
                return null;
            }
        }
        internal Point? StartDragPoint { get; set; }

        internal List<TimeSlotItem> TimeSlotItems
        {
            get
            {
                if (this.timeSlotItems == null)
                {
                    ////HACK: move the drag drop manager to AppointmentsControl
                    AppointmentsControl owner = this.AppointmentsControl;
                    if (owner != null && owner.TimeSlotItemsControl.TimeSlotItems != null)
                    {
                        this.timeSlotItems = owner.TimeSlotItemsControl.TimeSlotItems.ToList();
                    }
                }
                return this.timeSlotItems;
            }
            set
            {
                this.timeSlotItems = value;
            }
        }

        private AppointmentsControl AppointmentsControl
        {
            get
            {
                return this.itemsControl.TemplatedParent as AppointmentsControl;

            }
        }    

        public void OnAppointmentResizeElementMouseDown(AppointmentItem item, object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;

            if (item.AppointmentSlot.Occurrence.CanResizeOrMove() && !this.itemsControl.Scheduler.IsReadOnly)
            {
                var editingEvent = this.RaiseAppointmentEditingEvent(item.AppointmentSlot.Occurrence.Appointment, AppointmentEditAction.Resize);
                if (!editingEvent.Cancel)
                {
                    this.resizedAppointmentSlot = item.AppointmentSlot;

					AppointmentResizeMode appointmentResizeMode = item.ResizeStartElement == sender
								  ? AppointmentResizeMode.Start
								  : AppointmentResizeMode.End;

					this.StartResize(appointmentResizeMode, item.ResizeStartElement.Cursor);
                }
            }
        }

        private AppointmentEditingEventArgs RaiseAppointmentEditingEvent(IAppointment appointment, AppointmentEditAction action)
        {
            var editingEventArgs = new AppointmentEditingEventArgs(
                RadScheduler.AppointmentEditingEvent, appointment);
            editingEventArgs.AppointmentEditAction = action;
            this.itemsControl.RaiseEvent(editingEventArgs);

            return editingEventArgs;
        }

        private void EndResize()
        {
            this.RaiseAppointmentEditedEvent(this.resizedAppointmentSlot.Occurrence.Appointment);

            this.itemsControl.IsResizing = false;

            this.MakeControlsHitTestVisible(true);

            this.resizedAppointmentSlot = null;
            this.resizeOffset = null;
            if (Application.Current != null)
            {

                Application.Current.MainWindow.Cursor = this.cursor;

            }
            this.AppointmentsControl.RemoveMouseUpHandler(this.OnAppointmentsControlMouseUp);

            this.UnhookTimeSlotItemsMouseEnter();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private bool EnsureResizing()
        {

            if (Mouse.LeftButton == MouseButtonState.Released && Mouse.RightButton == MouseButtonState.Released)
            {
                this.EndResize();
                return false;
            }

            return true;
        }

        private void HookTimeSlotItemsMouseEnter()
        {
            foreach (TimeSlotItem presenter in this.TimeSlotItems)
            {
                presenter.MouseEnter += this.OnTimeSlotItemMouseEnter;
            }
        }

      private void MakeControlsHitTestVisible(bool value)
        {
            this.itemsControl.IsHitTestVisible = value;
        }

        private void OnAppointmentsControlMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (this.itemsControl.IsResizing)
            {
                this.EndResize();
            }
        }

        private void OnTimeSlotItemMouseEnter(object sender, MouseEventArgs e)
        {
            Debug.Assert(this.itemsControl.IsResizing, "ItemsControl is able to change its size.");
            if (this.EnsureResizing() && !this.itemsControl.Scheduler.IsReadOnly)
            {
                this.ResizeAppointment((TimeSlotItem)sender);
            }
        }

        private void RaiseAppointmentEditedEvent(IAppointment appointment)
        {
            var editedEventArgs = new AppointmentEditedEventArgs(
                RadScheduler.AppointmentEditedEvent,
                appointment);
            this.itemsControl.RaiseEvent(editedEventArgs);
        }

        private void ResizeAppointment(TimeSlotItem item)
        {
            Debug.Assert(this.resizedAppointmentSlot != null, "Appointment to resize should not be null.");

            if (this.resizeMode == AppointmentResizeMode.Start)
            {
                if (item.TimeSlot.Start < this.resizedAppointmentSlot.Occurrence.Master.End)
                {
                    if (!this.resizeOffset.HasValue)
                    {
                        this.resizeOffset = this.resizedAppointmentSlot.Occurrence.Start - item.TimeSlot.Start;
                    }

                    this.resizedAppointmentSlot.Occurrence.Master.Start = item.TimeSlot.Start + this.resizeOffset.Value;
                }
            }
            else if (this.resizeMode == AppointmentResizeMode.End)
            {
                if (item.TimeSlot.End > this.resizedAppointmentSlot.Occurrence.Master.Start)
                {
                    if (!this.resizeOffset.HasValue)
                    {
                        this.resizeOffset = this.resizedAppointmentSlot.Occurrence.End - item.TimeSlot.Start;
                    }

                    this.resizedAppointmentSlot.Occurrence.Master.End = item.TimeSlot.Start + this.resizeOffset.Value;
                }
            }
        }

        private bool ShouldStartDrag(Point position)
        {
            Debug.Assert(this.StartDragPoint.HasValue, "StartDragPoint should have value.");

            return Math.Abs(position.X - this.StartDragPoint.Value.X) > SystemParameters.MinimumHorizontalDragDistance ||
                   Math.Abs(position.Y - this.StartDragPoint.Value.Y) > SystemParameters.MinimumVerticalDragDistance;
        }

		private void StartResize(AppointmentResizeMode appointmentResizeMode, Cursor resizeCursor)
        {
            this.MakeControlsHitTestVisible(false);
            this.itemsControl.IsResizing = true;
			this.resizeMode = appointmentResizeMode;

            if (Application.Current != null)
            {
                this.cursor = Application.Current.MainWindow.Cursor;
                Application.Current.MainWindow.Cursor = resizeCursor;

            }

            this.HookTimeSlotItemsMouseEnter();

            this.AppointmentsControl.AddMouseUpHandler(this.OnAppointmentsControlMouseUp);
        }



        private void UnhookTimeSlotItemsMouseEnter()
        {
            foreach (TimeSlotItem presenter in this.TimeSlotItems)
            {
                presenter.MouseEnter -= this.OnTimeSlotItemMouseEnter;
            }

            this.TimeSlotItems = null;
        }
    }
}
