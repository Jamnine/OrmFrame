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
    public class ResourceStyleMappingCollection : ObservableCollection<ResourceStyleMapping>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceStyleMappingCollection"/> class.
        /// </summary>
        public ResourceStyleMappingCollection()
            : base()
        {
        }
    }
}
