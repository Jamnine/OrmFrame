using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Presenting the visual cue element when dragging an appointment.
    /// </summary>
    public class DragVisualCue : INotifyPropertyChanged
    {
            private bool isDragging;
            private IAppointment app;

            /// <summary>
            /// Initializes a new instance of the <see cref="DragVisualCue"/> class.
            /// </summary>
            /// <param name="app">The app.</param>
            /// <param name="isDragging">If set to <c>true</c> [is dragging].</param>
            public DragVisualCue(IAppointment app, bool isDragging)
            {
                this.app = app;
                this.isDragging = isDragging;
            }

            /// <summary>
            /// Occurs when a property value changes.
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;

            /// <summary>
            /// Gets or sets a value indicating whether this instance is dragging possible.
            /// </summary>
            /// <value>
            /// 	<c>True</c> if this instance is dragging possible; otherwise, <c>False</c>.
            /// </value>
            public bool IsDraggingPossible
            {
                get
                {
                    return this.isDragging;
                }
                set
                {
                    if (this.isDragging != value)
                    {
                        this.isDragging = value;
                        this.OnPropertyChanged("IsDraggingPossible");
                    }
                }
            }

            /// <summary>
            /// The attendee's name.
            /// </summary>
            public IAppointment Appointment
            {
                get
                {
                    return this.app;
                }
                set
                {
                    if (this.app != value)
                    {
                        this.app = value;
                        this.OnPropertyChanged("Appointment");
                    }
                }
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
        }
}
