using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A class for a typical collection of resource types.
    /// </summary>
    public class ResourceTypeCollection : ObservableCollection<ResourceType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypeCollection"/> class.
        /// </summary>
        public ResourceTypeCollection()
            : base()
        {
        }
    }
}
