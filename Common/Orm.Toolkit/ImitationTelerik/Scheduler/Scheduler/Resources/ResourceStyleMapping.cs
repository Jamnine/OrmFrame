using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents the resource type.
    /// </summary>
    public class ResourceStyleMapping 
    {
        private Brush appointmentBrush;
        private Brush mouseOverBrush;
        private Brush selectedBrush;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceStyleMapping"/> class.
        /// </summary>
        public ResourceStyleMapping()
        { 
        }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        public Brush ResourceBrush
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        public Brush AppointmentBrush
        {
            get
            {
                if (this.appointmentBrush != null)
                {
                    return this.appointmentBrush;
                }
                return this.ResourceBrush;
            }
            set
            {
                if (this.appointmentBrush != value)
                {
                    this.appointmentBrush = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the resource appointments brush.
        /// </summary>
        /// <value>The resource appointments brush.</value>
        public Brush MouseOverAppointmentBrush
        {
            get
            {
                if (this.mouseOverBrush != null)
                {
                    return this.mouseOverBrush;
                }
                return this.AppointmentBrush;
            }
            set
            {
                if (this.mouseOverBrush != value)
                {
                    this.mouseOverBrush = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the resource appointments brush.
        /// </summary>
        /// <value>The resource appointments brush.</value>
        public Brush SelectedAppointmentBrush
        {
            get
            {
                if (this.selectedBrush != null)
                {
                    return this.selectedBrush;
                }
                return this.AppointmentBrush;
            }
            set
            {
                if (this.selectedBrush != value)
                {
                    this.selectedBrush = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the appointment template.
        /// </summary>
        /// <value>The appointment template.</value>
        public DataTemplate AppointmentTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the header template.
        /// </summary>
        /// <value>The header template.</value>
        public DataTemplate HeaderTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the header template for a Timeline view.
        /// </summary>
        /// <value>The header template for a Timeline view.</value>
        public DataTemplate VerticalHeaderTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        /// <value>The name of the resource.</value>
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        public string ResourceType
        {
            get;
            set;
        }
    }
}
