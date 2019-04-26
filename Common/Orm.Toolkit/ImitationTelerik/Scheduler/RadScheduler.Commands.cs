using System;
using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <content>
    /// Contains command handlers for the RadScheduler commands.
    /// </content>
    public partial class RadScheduler
    {
        private static void OnCreateAppointmentCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var dateSpan = e.Parameter as IDateSpan;
            var scheduler = (RadScheduler)sender;
            if (!scheduler.IsInlineEditingEnabled) return;
            scheduler.CreateAppointment(dateSpan);
        }

        private static void OnDecreaseVisibleDateLargeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.DecreaseVisibleDateLarge();
        }

        private static void OnDecreaseVisibleDateSmallCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.DecreaseVisibleDateSmall();
        }

        private static void OnDeleteAppointmentCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;

            var appointment = e.Parameter as IAppointment;

            if (appointment != null)
            {
                scheduler.DeleteAppointment(appointment);
            }

            var occurrence = e.Parameter as Occurrence;

            scheduler.DeleteAppointmentOccurence(occurrence);
        }

        private static void OnEditAppointmentCommand(object sender, ExecutedRoutedEventArgs e)
        {
            Occurrence editedOccurence = null;

            var scheduler = (RadScheduler)sender;
            var sourceElement = e.OriginalSource as FrameworkElement;
            if (sourceElement != null)
            {
                var slot = sourceElement.DataContext as AppointmentSlot;
                if (slot != null)
                {
                    editedOccurence = slot.Occurrence;
                }
            }

            var editedAppointment = e.Parameter as IAppointment;
            if (editedAppointment != null)
            {
                editedOccurence = Occurrence.CreateMaster(editedAppointment);
            }

            var occurence = e.Parameter as Occurrence;
            if (occurence != null)
            {
                editedOccurence = occurence;
            }

            scheduler.EditAppointmentOccurence(editedOccurence);
        }

        private static void OnIncreaseVisibleDateLargeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.IncreaseVisibleDateLarge();
        }

        private static void OnIncreaseVisibleDateSmallCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.IncreaseVisibleDateSmall();
        }

        private static void OnQuerySetCreateAppointmentCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = !scheduler.IsReadOnly;
        }

        private static void OnQuerySetEditAppointmentCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = !scheduler.IsReadOnly;
        }
        private static void OnQuerySetDeleteAppointmentCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = !scheduler.IsReadOnly;
        }

        private static void OnQueryIncreaseVisibleDateSmallCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = scheduler.IsBackAndForwardNavigationEnabled;
        }

        private static void OnQueryDecreaseVisibleDateSmallCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = scheduler.IsBackAndForwardNavigationEnabled;
        }
        private static void OnQueryIncreaseVisibleDateLargeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = scheduler.IsBackAndForwardNavigationEnabled;
        }
        private static void OnQueryDecreaseVisibleDateLargeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            e.CanExecute = scheduler.IsBackAndForwardNavigationEnabled;
        }

        private static void OnQuerySetDayViewModeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            bool isDayViewModeAvailable = scheduler.AvailableViewModes.HasFlag(AvailableViewModes.Day);
            e.CanExecute = scheduler.ViewMode != SchedulerViewMode.Day && scheduler.IsViewModeNavigationEnabled && isDayViewModeAvailable;
        }

        private static void OnQuerySetMonthViewModeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            bool isMonthViewModeAvailable = scheduler.AvailableViewModes.HasFlag(AvailableViewModes.Month);
            e.CanExecute = scheduler.ViewMode != SchedulerViewMode.Month && scheduler.IsViewModeNavigationEnabled && isMonthViewModeAvailable;
        }

        private static void OnQuerySetWeekViewModeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            bool isWeekViewModeAvailable = scheduler.AvailableViewModes.HasFlag(AvailableViewModes.Week);
            e.CanExecute = scheduler.ViewMode != SchedulerViewMode.Week && scheduler.IsViewModeNavigationEnabled && isWeekViewModeAvailable;
        }

        private static void OnQuerySetTimelineViewModeCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            bool isTimelineViewModeAvailable = scheduler.AvailableViewModes.HasFlag(AvailableViewModes.Timeline);
            e.CanExecute = scheduler.ViewMode != SchedulerViewMode.Timeline && scheduler.IsViewModeNavigationEnabled && isTimelineViewModeAvailable;
        }

        private static void OnSetDayViewModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.TrySetVisibleDateFromExecutedArgs(e); 
            scheduler.ViewMode = SchedulerViewMode.Day;
        }

        private static void OnSetMonthViewModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.ViewMode = SchedulerViewMode.Month;

            scheduler.TrySetVisibleDateFromExecutedArgs(e);
        }

        private static void OnSetWeekViewModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.TrySetVisibleDateFromExecutedArgs(e);
			scheduler.ViewMode = SchedulerViewMode.Week;
		}

        private static void OnSetTimelineViewModeCommand(object sender, ExecutedRoutedEventArgs e)
        {
            var scheduler = (RadScheduler)sender;
            scheduler.ViewMode = SchedulerViewMode.Timeline;

            scheduler.TrySetVisibleDateFromExecutedArgs(e);
        }

        private static void RegisterCommand(ICommand command, ExecutedRoutedEventHandler executed)
        {
            CommandManager.RegisterClassCommandBinding(
                typeof(RadScheduler), new CommandBinding(command, executed));
        }

        private static void RegisterCommand(
            ICommand command,
            ExecutedRoutedEventHandler executed,
            CanExecuteRoutedEventHandler canExecute)
        {
            CommandManager.RegisterClassCommandBinding(
                typeof(RadScheduler), new CommandBinding(command, executed, canExecute));
        }

        private static void RegisterCommands()
        {
            RegisterCommand(RadSchedulerCommands.CreateAppointment, OnCreateAppointmentCommand, OnQuerySetCreateAppointmentCommand);
            RegisterCommand(RadSchedulerCommands.EditAppointment, OnEditAppointmentCommand, OnQuerySetEditAppointmentCommand);
            RegisterCommand(RadSchedulerCommands.DeleteAppointment, OnDeleteAppointmentCommand, OnQuerySetDeleteAppointmentCommand);
            RegisterCommand(RadSchedulerCommands.IncreaseVisibleDateSmall, OnIncreaseVisibleDateSmallCommand, OnQueryIncreaseVisibleDateSmallCommand);
            RegisterCommand(RadSchedulerCommands.DecreaseVisibleDateSmall, OnDecreaseVisibleDateSmallCommand, OnQueryDecreaseVisibleDateSmallCommand);
            RegisterCommand(RadSchedulerCommands.IncreaseVisibleDateLarge, OnIncreaseVisibleDateLargeCommand, OnQueryIncreaseVisibleDateLargeCommand);
            RegisterCommand(RadSchedulerCommands.DecreaseVisibleDateLarge, OnDecreaseVisibleDateLargeCommand, OnQueryDecreaseVisibleDateLargeCommand);
            RegisterCommand(RadSchedulerCommands.SetDayViewMode, OnSetDayViewModeCommand, OnQuerySetDayViewModeCommand);
            RegisterCommand(RadSchedulerCommands.SetWeekViewMode, OnSetWeekViewModeCommand, OnQuerySetWeekViewModeCommand);
            RegisterCommand(RadSchedulerCommands.SetMonthViewMode, OnSetMonthViewModeCommand, OnQuerySetMonthViewModeCommand);
            RegisterCommand(RadSchedulerCommands.SetTimelineViewMode, OnSetTimelineViewModeCommand, OnQuerySetTimelineViewModeCommand);
        }

        private static bool TryGetDateFromExecutedArgs(ExecutedRoutedEventArgs args, out DateTime dateTime)
        {
            dateTime = DateTime.MinValue;

            if (args.Parameter != null)
            {
                try
                {
                    if (args.Parameter is DateTime)
                    {
                        dateTime = (DateTime)args.Parameter;
                        return true;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
            }

            var element = args.OriginalSource as FrameworkElement;
            if (element != null && element.DataContext != null)
            {
                var dateSpan = element.DataContext as IDateSpan;
                if (dateSpan != null)
                {
                    dateTime = dateSpan.Start;
                    return true;
                }

                // When clicking on week we have a list of date spans - from first to last day of the week
                var enumerable = element.DataContext as IEnumerable;
                if (enumerable != null)
                {
                    dateSpan = enumerable.Cast<object>().FirstOrDefault() as IDateSpan;
                    if (dateSpan != null)
                    {
                        dateTime = dateSpan.Start;
                        return true;
                    }
                }
            }

            return false;
        }

        private void TrySetVisibleDateFromExecutedArgs(ExecutedRoutedEventArgs args)
        {
            DateTime date;
            if (TryGetDateFromExecutedArgs(args, out date))
            {
                var intervalDays = (int)(date.Date - this.SelectedTimeSlot.Start.Date).TotalDays;
                var dateTimeInterval = new DateTimeInterval(intervalDays, 0);
                this.View.IncreaseViewDates(dateTimeInterval);
            }
        }
    }
}