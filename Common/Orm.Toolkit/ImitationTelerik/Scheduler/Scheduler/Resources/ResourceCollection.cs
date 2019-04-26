using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Base class for a typical collection of resources.
    /// </summary>
    public class ResourceCollection : ObservableCollection<IResource>
    {
        private string resourceType;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCollection"/> class.
        /// </summary>
        public ResourceCollection()
            : base()
        {
        }

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        public string ResourceType
        {
            get
            {
                return this.resourceType;
            }
            set
            {
                if (this.resourceType != value)
                {
                    this.resourceType = value;
                    foreach (IResource resource in this)
                    {
                        resource.ResourceType = value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the first resource (if any) of the specified type.
        /// </summary>
        /// <param name="type">The type of resource to search for.</param>
        /// <returns>The first resource of the specified type; null if no resource matches.</returns>
        public IResource GetResourceByType(string type)
        {
            foreach (IResource resource in this)
            {
                if (resource.ResourceType == type)
                {
                    return resource;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the resources of the specified type.
        /// </summary>
        /// <param name="type">The type of resource to search for.</param>
        /// <returns>The resources of the specified type.</returns>
        public IEnumerable<IResource> GetResourcesByType(string type)
        {
            List<IResource> resources = new List<IResource>();
            foreach (IResource resource in this)
            {
                if (resource.ResourceType == type)
                {
                    resources.Add(resource);
                }
            }
            return resources;
        }

        /// <summary>
        /// Inserts an item into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        protected override void InsertItem(int index, IResource item)
        {
            base.InsertItem(index, item);
            if (item != null)
            {
                item.ResourceType = this.ResourceType ?? item.ResourceType;
            }
        }

        /// <summary>
        /// Replaces the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to replace.</param>
        /// <param name="item">The new value for the element at the specified index.</param>
        protected override void SetItem(int index, IResource item)
        {
            base.SetItem(index, item);
            item.ResourceType = this.ResourceType ?? item.ResourceType;
        }
    }
}
