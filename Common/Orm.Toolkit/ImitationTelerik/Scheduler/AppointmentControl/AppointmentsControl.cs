using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
//using Orm.Toolkit.Telerik.Windows.Controls.Primitives;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;
//using Orm.Toolkit.Telerik.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Control containing appointments arranged over time slots.
	/// </summary>
	[TemplatePart(Name = AppointmentItemsControlName, Type = typeof(AppointmentItemsControl))]
	[TemplatePart(Name = TimeSlotItemsControlName, Type = typeof(TimeSlotItemsControl))]
	public class AppointmentsControl : Control,

 IWeakEventListener
	{
		/// <summary>
		/// Identifies the <see cref="Appointments"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="Appointments"/> property.</returns>
		public static readonly DependencyProperty AppointmentsProperty =
			DependencyProperty.Register(
				"Appointments",
				typeof(IList),
				typeof(AppointmentsControl),
				new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, OnAppointmentsChanged));


		/// <summary>
		/// Identifies the <see cref="Scheduler"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="Scheduler"/> property.</returns>
		public static readonly DependencyProperty SchedulerProperty =
			SchedulerPresenter.SchedulerProperty.AddOwner(typeof(AppointmentsControl));


		/// <summary>
		/// Identifies the <see cref="TimeSlots"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="TimeSlots"/> property.</returns>
		public static readonly DependencyProperty TimeSlotsProperty =
			DependencyProperty.Register(
				"TimeSlots",
				typeof(TimeSlotCollectionView),
				typeof(AppointmentsControl),
				new PropertyMetadata(null, OnTimeSlotsChanged));

		/// <summary>
		/// <see cref="AppointmentSlots"/> dependency property.
		/// </summary>
		protected internal static readonly DependencyPropertyKey AppointmentSlotsPropertyKey = DependencyPropertyExtensions.RegisterReadOnly(
				"AppointmentSlots",
				typeof(AppointmentSlotCollection),
				typeof(AppointmentsControl),
				new PropertyMetadata(null));

		/// <summary>
		/// Identifies the <see cref="AppointmentSlots"/> property.
		/// </summary>
		protected static readonly DependencyProperty AppointmentSlotsProperty = AppointmentSlotsPropertyKey.DependencyProperty;

		private const string AppointmentItemsControlName = "PART_AppointmentItemsControl";
		private const string TimeSlotItemsControlName = "PART_TimeSlotItemsControl";
		private AppointmentItemsControl appointmentItemsControl;


		/// <summary>
		/// Initializes a new instance of the <see cref="AppointmentsControl"/> class.
		/// </summary>
		public AppointmentsControl()
		{
			this.AppointmentSlots = new AppointmentSlotCollection();

		}

		/// <summary>
		/// Gets the appointment items control.
		/// </summary>
		/// <value>The appointment items control.</value>
		public AppointmentItemsControl AppointmentItemsControl
		{
			get
			{
				return this.appointmentItemsControl;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="Appointments"/> that are displayed.
		/// </summary>
		/// <returns>The current <see cref="Appointments"/>. The default value is null.</returns>  
		public IList Appointments
		{
			get
			{
				return (IList)this.GetValue(AppointmentsProperty);
			}
			set
			{
				this.SetValue(AppointmentsProperty, value);
			}
		}

		/// <summary>
		/// Gets the resource.
		/// </summary>
		/// <value>The resource.</value>
		public IResource Resource
		{
			get
			{
				return (this.DataContext as ResourceGroup).Resource;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="RadScheduler"/>. This is a dependency property.
		/// </summary>
		/// <returns>The current <see cref="RadScheduler"/>.The default value is null.</returns> 
		public RadScheduler Scheduler
		{
			get
			{
				return (RadScheduler)this.GetValue(SchedulerProperty);
			}
			set
			{
				this.SetValue(SchedulerProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="TimeSlots"/> that is used to create time slots and 
		/// arrange appointments over them. This is a dependency property.
		/// </summary>
		/// <returns>The current <see cref="TimeSlots"/>. The default value is null.</returns>  
		public TimeSlotCollectionView TimeSlots
		{
			get
			{
				return (TimeSlotCollectionView)this.GetValue(TimeSlotsProperty);
			}
			set
			{
				this.SetValue(TimeSlotsProperty, value);
			}
		}

		internal TimeSlotItemsControl TimeSlotItemsControl { get; private set; }

		/// <summary>
		/// Gets or sets the appointment slots.
		/// </summary>
		/// <value>The appointment slots.</value>
		protected internal AppointmentSlotCollection AppointmentSlots
		{
			get
			{
				return (AppointmentSlotCollection)this.GetValue(AppointmentSlotsProperty);
			}
			private set
			{
				this.SetValue(AppointmentSlotsPropertyKey, value);
			}
		}

		/// <summary>
		/// Finds <see cref="AppointmentItemsControl"/> and <see cref="TimeSlotItemsControl"/> in the template.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.Scheduler = this.ParentOfType<RadScheduler>();

			if (this.Scheduler != null && this.Scheduler.SchedulerPresenter != null)
			{
				this.Scheduler.SchedulerPresenter.SchedulerAppointmentsControls.Add(this);
			}

			if (this.appointmentItemsControl != null)
			{
				this.appointmentItemsControl.TimeSlotItemsControl = null;
			}

			this.TimeSlotItemsControl = this.GetTemplateChild(TimeSlotItemsControlName) as TimeSlotItemsControl;

			if (this.TimeSlotItemsControl != null)
			{
				this.TimeSlotItemsControl.SetBinding(
					ItemsControl.ItemsSourceProperty,
					new Binding("TimeSlots") { Source = this, Mode = BindingMode.OneWay });

				this.TimeSlotItemsControl.SetBinding(
					TimeSlotItemsControl.SelectedTimeSlotProperty,
					new Binding("Scheduler.SelectedTimeSlot") { Source = this, Mode = BindingMode.TwoWay });
			}

			this.appointmentItemsControl = this.GetTemplateChild(AppointmentItemsControlName) as AppointmentItemsControl;
			if (this.appointmentItemsControl != null)
			{
				this.appointmentItemsControl.SetBinding(
					ItemsControl.ItemsSourceProperty, new Binding("AppointmentSlots") { Source = this });

				this.appointmentItemsControl.SetBinding(
					AppointmentItemsControl.SelectedAppointmentsProperty, new Binding("Scheduler.SelectedAppointments") { Source = this });
			}

			if (this.appointmentItemsControl != null)
			{
                this.appointmentItemsControl.TimeSlotItemsControl = this.TimeSlotItemsControl;
			}

			this.AttachTimeSlots();

		}


		bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
		{
			if (managerType == typeof(CollectionChangedEventManager))
			{
				NotifyCollectionChangedEventArgs args = (NotifyCollectionChangedEventArgs)e;
				this.OnAppointmentsCollectionChanged(sender, args);
				return true;
			}
			if (managerType == typeof(PropertyChangedEventManager))
			{
				PropertyChangedEventArgs args = (PropertyChangedEventArgs)e;
				this.OnAppointmentPropertyChanged(sender, args);
				return true;
			}
			if (managerType == typeof(RecurrenceRuleChangedEventManager))
			{
				EventArgs args = (EventArgs)e;
				this.OnAppointmentRecurrenceRuleChanged(sender, args);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Recreates the appointment slots.
		/// </summary>
		protected internal virtual void RecreateAppointmentSlots()
		{
			this.AppointmentSlots.Clear();
			if (this.Appointments != null)
			{
				foreach (IAppointment appointment in this.Appointments)
				{
					foreach (AppointmentSlot slot in this.CreateAppointmentSlotsFromAppointment(appointment))
					{
						this.AppointmentSlots.Add(slot);
					}
				}
			}
		}

		/// <summary>
		/// Recreates the appointment slots for an appointment.
		/// </summary>
		/// <param name="appointment">The appointment.</param>
		protected internal void RecreateAppointmentSlots(IAppointment appointment)
		{
			if (this.appointmentItemsControl != null)
			{
				this.appointmentItemsControl.RecycleAllAppointmentItems();
			}

			this.AppointmentSlots.RemoveElementsByAppointment(appointment);

			IList<AppointmentSlot> slots = this.CreateAppointmentSlotsFromAppointment(appointment);
			if (slots.Count > 0 && this.appointmentItemsControl != null)
			{
				this.AppointmentSlots.AddRange(slots);
				this.appointmentItemsControl.SelectedItem = slots[0];
			}
		}

		/// <summary>
		/// Called when Appointments changed.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="NotifyCollectionChangedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnAppointmentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					{
						foreach (IAppointment appointment in e.NewItems)
						{
							this.HookNewAppointment(appointment);
						}
						break;
					}

				case NotifyCollectionChangedAction.Move:
					{
						break;
					}

				case NotifyCollectionChangedAction.Remove:
					{
						foreach (IAppointment appointment in e.OldItems)
						{
							this.UnHookNewAppointment(appointment);
						}
						break;
					}
				case NotifyCollectionChangedAction.Replace:
					{
						foreach (IAppointment appointment in e.OldItems)
						{
							this.UnHookNewAppointment(appointment);
						}

						foreach (IAppointment appointment in e.NewItems)
						{
							this.HookNewAppointment(appointment);
						}
						break;
					}
				case NotifyCollectionChangedAction.Reset:
					{
						IEnumerable<IGrouping<IAppointment, AppointmentSlot>> oldAppointmentsSlotsGroup =
							this.AppointmentSlots.GroupBy(a => a.Occurrence.Master);

						foreach (var appointmentSlot in oldAppointmentsSlotsGroup)
						{
							this.UnHookNewAppointment(appointmentSlot.Key);
						}

						foreach (IAppointment appointment in this.Appointments)
						{
							this.HookNewAppointment(appointment);
						}

						break;
					}
				default:
					{
						Debug.Assert(false, "Invalid NotifyCollectionChangedAction");
						break;
					}
			}
		}

		/// <summary>
		/// Creates the appointment slots from appointment.
		/// </summary>
		/// <param name="appointment">The appointment.</param>
		/// <returns></returns>
		protected virtual IList<AppointmentSlot> CreateAppointmentSlotsFromAppointment(IAppointment appointment)
		{
			if (this.TimeSlots != null)
			{
				return appointment.GetAppointmentSlots(this.TimeSlots);
			}
			return null;
		}

		/// <summary>
		/// Called when some of Appointment's property changed.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
		protected virtual void OnAppointmentPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Start" || e.PropertyName == "End" || e.PropertyName == "IsAllDayEvent" ||
				e.PropertyName == "RecurrenceRule" || e.PropertyName == "Category" || e.PropertyName == "Importance")
			{
				var appointment = sender as IAppointment;
				if (appointment == null || this.Appointments == null || !this.Appointments.Contains(appointment))
				{
					return;
				}

				this.RecreateAppointmentSlots(appointment);
			}
		}

		/// <summary>
		/// Provides derived classes an opportunity to handle changes to the <see cref="Appointments"/>.
		/// </summary>
		protected virtual void OnAppointmentsChanged(DependencyPropertyChangedEventArgs args)
		{
			var oldAppointments = args.OldValue as INotifyCollectionChanged;

			if (oldAppointments != null)
			{

				CollectionChangedEventManager.RemoveListener(oldAppointments, this);

			}

			if (args.OldValue != null)
			{
				foreach (IAppointment unhook in (IList)args.OldValue)
				{
					this.UnHookNewAppointment(unhook);
				}
			}

			var newAppointments = args.NewValue as INotifyCollectionChanged;

			if (newAppointments != null)
			{
				CollectionChangedEventManager.AddListener(newAppointments, this);

			}

			if (args.NewValue != null)
			{
				foreach (IAppointment hook in (IList)args.NewValue)
				{
					this.HookNewAppointment(hook);
				}
			}
		}


		/// <summary>
		/// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
		/// </summary>
		/// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			this.DefaultStyleKey = this.GetDefaultStyleKey();
		}


		/// <summary>
		/// Handles changes to the <see cref="Appointments"/> property.
		/// </summary>
		private static void OnAppointmentsChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
		{
			((AppointmentsControl)d).OnAppointmentsChanged(args);
		}

		private static void OnTimeSlotsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var control = (AppointmentsControl)d;
			if (control.Appointments != null)
			{
				control.RecreateAppointmentSlots();
			}
			if (e.OldValue != null)
			{
				var oldTimeSlots = (TimeSlotCollectionView)e.OldValue;
				oldTimeSlots.TimeSlotsUpdated -= control.OnTimeSlotsUpdated;
			}

			if (e.NewValue != null)
			{
				var newTimeSlots = (TimeSlotCollectionView)e.NewValue;
				newTimeSlots.TimeSlotsUpdated += control.OnTimeSlotsUpdated;
			}
		}

		private void AttachTimeSlots()
		{
			// Attach the timeslots to the appointments panel, so it can arrange the appointments
			if (this.appointmentItemsControl != null)
			{
				var panel = this.appointmentItemsControl.GetItemsPanel() as AppointmentPanel;
				if (panel != null)
				{
					panel.TimeSlotItemsControl = this.TimeSlotItemsControl;
				}
			}
		}

		private void OnAppointmentsControlLoaded(object sender, RoutedEventArgs e)
		{
			this.AttachTimeSlots();
		}

		private void HookNewAppointment(IAppointment appointment)
		{
			IList<AppointmentSlot> slots = this.CreateAppointmentSlotsFromAppointment(appointment);
			if (slots != null)
			{
				this.AppointmentSlots.AddRange(slots);
			}
	
			PropertyChangedEventManager.AddListener(appointment, this, string.Empty);
			RecurrenceRuleChangedEventManager.AddListener(appointment, this);

		}

		private void OnAppointmentRecurrenceRuleChanged(object sender, EventArgs e)
		{
			var appointment = sender as IAppointment;
			if (appointment == null || !this.Appointments.Contains(appointment))
			{
				return;
			}

			this.RecreateAppointmentSlots(appointment);
		}

		private void OnTimeSlotsUpdated(object sender, EventArgs e)
		{
			this.RecreateAppointmentSlots();
		}

		private void UnHookNewAppointment(IAppointment appointment)
		{
			if (this.appointmentItemsControl != null)
			{
				this.appointmentItemsControl.RecycleAllAppointmentItems();
			}
			this.AppointmentSlots.RemoveElementsByAppointment(appointment);
	
			PropertyChangedEventManager.RemoveListener(appointment, this, String.Empty);
			RecurrenceRuleChangedEventManager.RemoveListener(appointment, this);

		}
	}
}
