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

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents basic <see cref="IResource"/> implementation.
    /// </summary>
    public class Resource : IResource
    {
        private string name;
        private string type;
        private string displayName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        public Resource()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Resource(string name)
        {
            this.ResourceName = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public Resource(string name, string type) : this(name)
        {
            this.ResourceType = type;
        }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the name of the <see cref="IResource"/> object.
        /// </summary>
        /// <value></value>
        public string ResourceName
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
                if (!string.IsNullOrWhiteSpace(this.ResourceType))
                {
                    if (this.ResourceType == "DiogRoom")
                    {
                        return this.DiagRoomName;
                    }
                }
                if (String.IsNullOrEmpty(this.DoctorName))
                {
                    return this.ResourceName;
                }
                if (string.IsNullOrWhiteSpace(DiagRoomName))
                {
                    return this.DoctorName;
                }
                else
                    return this.DoctorName + "(" + DiagRoomName + ")";
                
            }
        }

        public string DiagRoomName { get; set; }

        public string DoctorName { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the type of the <see cref="IResource"/> object.
        /// </summary>
        /// <value></value>
        public string ResourceType
        {
            get
            {
                return this.type;
            }
            set
            {
                if (this.type != value)
                {
                    this.type = value;
                }
            }
        }    
    }
}
