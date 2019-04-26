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
    [ContentProperty("Resources")]
    public class ResourceType : INotifyPropertyChanged
    {
        private ResourceCollection resources;

        private string name;

        private string displayName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceType"/> class.
        /// </summary>
        public ResourceType()
        {
            this.resources = new ResourceCollection();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceType"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public ResourceType(string name)
        {
            this.resources = new ResourceCollection();
            this.Resources.ResourceType = name;
            this.Name = name;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.Resources.ResourceType = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName
        {
            get
            {
                if (String.IsNullOrEmpty(this.displayName))
                {
                    return this.Name;
                }
                return this.displayName;
            }

            set
            {
                if (this.displayName != value)
                {
                    this.displayName = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [multiple selection].
        /// </summary>
        /// <value><c>True</c> if [multiple selection]; otherwise, <c>false</c>.</value>
        public bool AllowMultipleSelection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        public ResourceCollection Resources
        {
           get
            {
               return this.resources;
            }
        }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>The resources.</value>
        public Brush Brush
        {
            get;
            set;
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
