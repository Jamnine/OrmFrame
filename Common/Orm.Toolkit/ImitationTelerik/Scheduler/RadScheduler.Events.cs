using System;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <content>
    /// Contains events for the RadScheduler class.
    /// </content>
    public partial class RadScheduler
    {
        /// <summary>
        /// Identifies the <see cref="AppointmentAdded"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentAdded"/> event</returns>
        public static readonly RoutedEvent AppointmentAddedEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentAdded",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentAddedEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentAdding"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentAdding"/> event</returns>
        public static readonly RoutedEvent AppointmentAddingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentAdding",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentAddingEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentCreated"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentCreated"/> event</returns>
        public static readonly RoutedEvent AppointmentCreatedEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentCreated",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentCreatedEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentCreating"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentCreating"/> event</returns>
        public static readonly RoutedEvent AppointmentCreatingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentCreating",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentCreatingEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentDeleted"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentDeleted"/> event</returns>
        public static readonly RoutedEvent AppointmentDeletedEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentDeleted",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentDeletedEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentDeleting"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentDeleting"/> event</returns>
        public static readonly RoutedEvent AppointmentDeletingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentDeleting",
                RoutingStrategy.Direct,
                typeof(EventHandler<AppointmentDeletingEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentEdited"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentEdited"/> event</returns>
        public static readonly RoutedEvent AppointmentEditedEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentEdited",
                RoutingStrategy.Bubble,
                typeof(EventHandler<AppointmentEditedEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentEditing"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentEditing"/> event</returns>
        public static readonly RoutedEvent AppointmentEditingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentEditing",
                RoutingStrategy.Bubble,
                typeof(EventHandler<AppointmentEditingEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Identifies the <see cref="AppointmentSaving"/> event.
        /// </summary>
        /// <returns>The identifier for the <see cref="AppointmentSaving"/> event</returns>
        public static readonly RoutedEvent AppointmentSavingEvent =
            EventManager.RegisterRoutedEvent(
                "AppointmentSaving",
                RoutingStrategy.Bubble,
                typeof(EventHandler<AppointmentSavingEventArgs>),
                typeof(RadScheduler));

        /// <summary>
        /// Occurs when the new appointment has been added to the data source.
        /// </summary>    
        public event EventHandler<AppointmentAddedEventArgs> AppointmentAdded
        {
            add
            {
                this.AddHandler(AppointmentAddedEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentAddedEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the new appointment is going to be added to the data source.
        /// </summary>    
        public event EventHandler<AppointmentAddingEventArgs> AppointmentAdding
        {
            add
            {
                this.AddHandler(AppointmentAddingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentAddingEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the new appointment was created and edit dialog window is about to be shown.
        /// </summary>    
        public event EventHandler<AppointmentCreatedEventArgs> AppointmentCreated
        {
            add
            {
                this.AddHandler(AppointmentCreatedEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentCreatedEvent, value);
            }
        }

        /// <summary>
        /// Occurs when appointment is going to be created. You can use this event create your own 
        /// custom appointment. Also you can cancel the appointment creation. 
        /// </summary>    
        public event EventHandler<AppointmentCreatingEventArgs> AppointmentCreating
        {
            add
            {
                this.AddHandler(AppointmentCreatingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentCreatingEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the appointment has been removed from the data source.
        /// </summary>
        public event EventHandler<AppointmentDeletedEventArgs> AppointmentDeleted
        {
            add
            {
                this.AddHandler(AppointmentDeletedEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentDeletedEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the appointment is going to be removed from the data source.
        /// </summary>    
        public event EventHandler<AppointmentDeletingEventArgs> AppointmentDeleting
        {
            add
            {
                this.AddHandler(AppointmentDeletingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentDeletingEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the appointment edit has finished and the appointment changes are applied.
        /// </summary>    
        public event EventHandler<AppointmentEditedEventArgs> AppointmentEdited
        {
            add
            {
                this.AddHandler(AppointmentEditedEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentEditedEvent, value);
            }
        }

        /// <summary>
        /// Occurs when the appointment edit command is initialized and edit dialog window is about to be shown.
        /// </summary>    
        public event EventHandler<AppointmentEditingEventArgs> AppointmentEditing
        {
            add
            {
                this.AddHandler(AppointmentEditingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentEditingEvent, value);
            }
        }

        /// <summary>
        /// Occurs before the appointment is saved.
        /// </summary>    
        public event EventHandler<AppointmentSavingEventArgs> AppointmentSaving
        {
            add
            {
                this.AddHandler(AppointmentSavingEvent, value);
            }
            remove
            {
                this.RemoveHandler(AppointmentSavingEvent, value);
            }
        }

        /// <summary>
        /// Raises the <see cref="AppointmentAdded"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentAddedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentAdded(AppointmentAddedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentAdding"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentAddingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentAdding(AppointmentAddingEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentCreated"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentCreatedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentCreated(AppointmentCreatedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentCreating"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentCreatingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentCreating(AppointmentCreatingEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentDeleted"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentDeletedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentDeleted(AppointmentDeletedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentDeleting"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentDeletingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentDeleting(AppointmentDeletingEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentEdited"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentEditedEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentEdited(AppointmentEditedEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentEditing"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentEditingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentEditing(AppointmentEditingEventArgs args)
        {
            this.RaiseEvent(args);
        }

        /// <summary>
        /// Raises the <see cref="AppointmentSaving"/> event.
        /// </summary>
        /// <param name="args">The <see cref="AppointmentSavingEventArgs"/> instance containing the event data.</param>
        protected virtual void OnAppointmentSaving(AppointmentSavingEventArgs args)
        {
            this.RaiseEvent(args);
        }
    }
}