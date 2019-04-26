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
    /// Defines basic methods and properties of a resource.
    /// </summary>
    public interface IResource 
    {
        /// <summary>
        /// Gets or sets the <see cref="string"/> value representing the name of the <see cref="IResource"/> object. 
        /// </summary>
         string ResourceName { get; set; }

         /// <summary>
         /// Gets or sets the <see cref="string"/> value representing the type of the <see cref="IResource"/> object. 
         /// </summary>
         string ResourceType { get; set; }

         /// <summary>
         /// Gets or sets the display name.
         /// </summary>
         /// <value>The display name.</value>
         string DisplayName { get; }
    }
}
