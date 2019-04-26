using System;
using System.Windows.Input;

namespace Orm.Toolkit.Telerik.Windows.Controls
{

    /// <summary>
    /// All commands that the <see cref="RadScheduler"/> exposes.
    /// </summary>
    public static class RadSchedulerCommands
    {
        private static readonly int CommandsCount = Enum.GetNames(typeof(CommandId)).Length;  

        private static readonly RoutedUICommand[] InternalCommands = new RoutedUICommand[CommandsCount];

        private enum CommandId : byte
        {
            /// <summary>
            /// Create appointment command.
            /// </summary>
            CreateAppointment = 0,

            /// <summary>
            /// Edit appointment command.
            /// </summary>
            EditAppointment = 1,

            /// <summary>
            /// Save appointment command.
            /// </summary>
            SaveAppointment = 2,

            /// <summary>
            /// Delete appointment command.
            /// </summary>
            DeleteAppointment = 3,

            /// <summary>
            /// Edit recurrence rule command.
            /// </summary>
            EditRecurrenceRule = 4,

            /// <summary>
            /// Save recurrence rule command.
            /// </summary>
            SaveRecurrenceRule = 5,

            /// <summary>
            /// Delete recurrence rule command.
            /// </summary>
            DeleteRecurrenceRule = 6,

            /// <summary>
            /// Edit parent appointment command.
            /// </summary>
            EditParentAppointment = 7,

            /// <summary>
            /// Increase visible date small command.
            /// </summary>
            IncreaseVisibleDateSmall = 8,

            /// <summary>
            /// Decrease visible date small command.
            /// </summary>
            DecreaseVisibleDateSmall = 9,

            /// <summary>
            /// Increase visible date large command.
            /// </summary>
            IncreaseVisibleDateLarge = 10,

            /// <summary>
            /// Decrease visible date large command.
            /// </summary>
            DecreaseVisibleDateLarge = 11,

            /// <summary>
            /// Set day view mode command.
            /// </summary>
            SetDayViewMode = 12,

            /// <summary>
            /// Set week view mode command.
            /// </summary>
            SetWeekViewMode = 13,

            /// <summary>
            /// Set month view mode command.
            /// </summary>
            SetMonthViewMode = 14,

            /// <summary>
            /// Change recurrence state command.
            /// </summary>
            ChangeRecurrenceState = 15,

            /// <summary>
            /// Change TimePickerVisibility command.
            /// </summary>
            ChangeTimePickersVisibility = 16,
            
            /// <summary>
	        /// Set month view mode command.
            /// </summary>
            SetTimelineViewMode = 17,

            /// <summary>
            /// Set appointment importnace command.
            /// </summary>
            SetAppointmentImportance = 18
        }

        /// <summary>
        /// Gets value that represents the create appointment command.
        /// </summary>
        /// <value>The create appointment command.</value>
        public static RoutedUICommand CreateAppointment
        {
            get
            {
                return EnsureCommand(CommandId.CreateAppointment);
            }
        }

        /// <summary>
        /// Gets value that represents the small decrease visible date large command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that decreases the visible date by the same amount as indicated
        /// by the <see cref="ViewDefinitionBase.LargeChangeInterval"/> property of the active view definition.
        /// </returns>
        public static RoutedUICommand DecreaseVisibleDateLarge
        {
            get
            {
                return EnsureCommand(CommandId.DecreaseVisibleDateLarge);
            }
        }

        /// <summary>
        /// Gets value that represents the small decrease visible date small command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that decreases the visible date by the same amount as indicated
        /// by the <see cref="ViewDefinitionBase.SmallChangeInterval"/> property of the active view definition.
        /// </returns>
        public static RoutedUICommand DecreaseVisibleDateSmall
        {
            get
            {
                return EnsureCommand(CommandId.DecreaseVisibleDateSmall);
            }
        }

        /// <summary>
        /// Gets value that represents the delete appointment command.
        /// </summary>
        /// <value>The delete appointment command.</value>
        public static RoutedUICommand DeleteAppointment
        {
            get
            {
                return EnsureCommand(CommandId.DeleteAppointment);
            }
        }

        /// <summary>
        /// Gets value that represents the delete recurrence command.
        /// </summary>
        /// <value>The delete recurrence command.</value>
        public static RoutedUICommand DeleteRecurrenceRule
        {
            get
            {
                return EnsureCommand(CommandId.DeleteRecurrenceRule);
            }
        }

        /// <summary>
        /// Gets the state of the change recurrence.
        /// </summary>
        /// <value>The state of the change recurrence.</value>
        public static RoutedUICommand ChangeRecurrenceState
        {
            get
            {
                return EnsureCommand(CommandId.ChangeRecurrenceState);
            }
        }

         /// <summary>
        /// Gets the state of the change recurrence.
        /// </summary>
        /// <value>The state of the change recurrence.</value>
        public static RoutedUICommand ChangeTimePickersVisibility
        {
            get
            {
                return EnsureCommand(CommandId.ChangeTimePickersVisibility);
            }
        }

        /// <summary>
        /// Gets the set appointment importance.
        /// </summary>
        /// <value>The set appointment importance.</value>
        public static RoutedUICommand SetAppointmentImportance
        {
            get
            {
                return EnsureCommand(CommandId.SetAppointmentImportance);
            }
        }

        /// <summary>
        /// Gets value that represents the edit appointment command.
        /// </summary>
        /// <value>The edit appointment command.</value>
        public static RoutedUICommand EditAppointment
        {
            get
            {
                return EnsureCommand(CommandId.EditAppointment);
            }
        }

        /// <summary>
        /// Gets value that represents the edit recurrence rule command.
        /// </summary>
        /// <value>The edit recurrence rule command.</value>
        public static RoutedUICommand EditParentAppointment
        {
            get
            {
                return EnsureCommand(CommandId.EditParentAppointment);
            }
        }        

        /// <summary>
        /// Gets value that represents the edit recurrence command.
        /// </summary>
        /// <value>The edit recurrence command.</value>
        public static RoutedUICommand EditRecurrenceRule
        {
            get
            {
                return EnsureCommand(CommandId.EditRecurrenceRule);
            }
        }

        /// <summary>
        /// Gets value that represents the small increase visible date large command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that increases the visible date by the same amount as indicated
        /// by the <see cref="ViewDefinitionBase.LargeChangeInterval"/> property of the active view definition.
        /// </returns>
        public static RoutedUICommand IncreaseVisibleDateLarge
        {
            get
            {
                return EnsureCommand(CommandId.IncreaseVisibleDateLarge);
            }
        }

        /// <summary>
        /// Gets value that represents the small increase visible date small command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that increases the visible date by the same amount as indicated
        /// by the <see cref="ViewDefinitionBase.SmallChangeInterval"/> property of the active view definition.
        /// </returns>
        public static RoutedUICommand IncreaseVisibleDateSmall
        {
            get
            {
                return EnsureCommand(CommandId.IncreaseVisibleDateSmall);
            }
        }

        /// <summary>
        /// Gets value that represents the save appointment command.
        /// </summary>
        /// <value>The save appointment command.</value>
        public static RoutedUICommand SaveAppointment
        {
            get
            {
                return EnsureCommand(CommandId.SaveAppointment);
            }
        }

        /// <summary>
        /// Gets value that represents the save recurrence command.
        /// </summary>
        /// <value>The save recurrence command.</value>
        public static RoutedUICommand SaveRecurrenceRule
        {
            get
            {
                return EnsureCommand(CommandId.SaveRecurrenceRule);
            }
        }

        /// <summary>
        /// Gets value that represents the set day view mode command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that sets the <see cref="RadScheduler.ViewMode"/> 
        /// to <see cref="SchedulerViewMode.Day"/>.
        /// </returns>
        public static RoutedUICommand SetDayViewMode
        {
            get
            {
                return EnsureCommand(CommandId.SetDayViewMode);
            }
        }

        /// <summary>
        /// Gets value that represents the set month view mode command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that sets the <see cref="RadScheduler.ViewMode"/> 
        /// to <see cref="SchedulerViewMode.Month"/>.
        /// </returns>
        public static RoutedUICommand SetMonthViewMode
        {
            get
            {
                return EnsureCommand(CommandId.SetMonthViewMode);
            }
        }

        /// <summary>
        /// Gets value that represents the set month view mode command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that sets the <see cref="RadScheduler.ViewMode"/> 
        /// to <see cref="SchedulerViewMode.Timeline"/>.
        /// </returns>
        public static RoutedUICommand SetTimelineViewMode
        {
            get
            {
                return EnsureCommand(CommandId.SetTimelineViewMode);
            }
        }

        /// <summary>
        /// Gets value that represents the set day view mode command.
        /// </summary>
        /// <returns>
        /// <see cref="RoutedCommand"/> that sets the <see cref="RadScheduler.ViewMode"/> 
        /// to <see cref="SchedulerViewMode.Week"/>.
        /// </returns>
        public static RoutedUICommand SetWeekViewMode
        {
            get
            {
                return EnsureCommand(CommandId.SetWeekViewMode);
            }
        }

        private static RoutedUICommand EnsureCommand(CommandId commandId)
        {
            var id = (int)commandId;
            if ((id < 0) || (id >= CommandsCount))
            {
                return null;
            }
            lock (InternalCommands.SyncRoot)
            {
                if (InternalCommands[id] == null)
                {
                    var newCommand = new RoutedUICommand(
                        GetUIText(commandId), commandId.ToString(), typeof(RadSchedulerCommands));

                    InternalCommands[id] = newCommand;
                }
            }

            return InternalCommands[id];
        }

        private static string GetUIText(CommandId commandId)
        {
            string text = string.Empty;

            switch (commandId)
            {
                case CommandId.CreateAppointment:
                    text = LocalizationManager.GetString("CreateAppointment");
                    break;
                case CommandId.EditAppointment:
                    text = LocalizationManager.GetString("EditAppointment");
                    break;
                case CommandId.SaveAppointment:
                    text = LocalizationManager.GetString("SaveAppointment");
                    break;
                case CommandId.DeleteAppointment:
                    text = LocalizationManager.GetString("DeleteAppointment");
                    break;
                case CommandId.EditRecurrenceRule:
                    text = LocalizationManager.GetString("EditRecurrence");
                    break;
                case CommandId.SaveRecurrenceRule:
                    text = LocalizationManager.GetString("SaveRecurrence");
                    break;
                case CommandId.EditParentAppointment:
                    text = LocalizationManager.GetString("EditParentAppointment");
                    break;
                case CommandId.SetDayViewMode:
                    text = LocalizationManager.GetString("SetDayViewMode");
                    break;
                case CommandId.SetWeekViewMode:
                    text = LocalizationManager.GetString("SetWeekViewMode");
                    break;
                case CommandId.SetMonthViewMode:
                    text = LocalizationManager.GetString("SetMonthViewMode");
                    break;
                case CommandId.SetTimelineViewMode:
                    text = LocalizationManager.GetString("SetTimelineViewMode");
                    break;
                default:
                    break;
            }

            return text;
        }
    }
}
