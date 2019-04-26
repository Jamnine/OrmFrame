using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// View model for <see cref="ResourceType"/> class.
    /// </summary>
    public class ResourceTypeViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceTypeViewModel"/> class.
        /// </summary>
        /// <param name="resourceType">Type of the resource.</param>
        /// <param name="appointment">The appointment.</param>
        public ResourceTypeViewModel(ResourceType resourceType, IAppointment appointment)
        {
            this.Appointment = appointment;
            this.ResourceType = resourceType;

            this.ResourceItems = new ResourceItemCollection();
            this.ResourceItems.CheckedItems.CollectionChanged += this.OnCheckedItemsCollectionChanged;

            foreach (IResource resource in resourceType.Resources)
            {
                this.ResourceItems.Add(new ResourceItem() { Resource = resource, IsChecked = this.IsChecked(resource) });
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Gets the content of the "clear all" button.
		/// </summary>
		/// <value>The content of the "clear all" button.</value>
		public static string ClearAllButtonContent
		{
			get
			{
				return LocalizationManager.GetString("ClearAll");
			}
		}

        /// <summary>
        /// Gets or sets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
		public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the index of the selected.
        /// </summary>
        /// <value>The index of the selected.</value>
        public int SelectedIndex
        {
            get
            {
                return 0;
            }
            set
            {
                if (value == -1)
                {
                    for (int i = 0; i < this.ResourceItems.Count; i++)
                    {
                        this.ResourceItems[i].IsChecked = false;
                    }
                }
                this.OnPropertyChanged("SelectedIndex");
            }
        }
       
        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>The selected item.</value>
		public ResourceItem SelectedItem
		{
			get
			{
				var selectedItems = this.ResourceItems.CheckedItems;
                return selectedItems.Count == 0 ? null : selectedItems[0];
			}
			set
			{
                var selectedItems = this.ResourceItems.CheckedItems;
                if (selectedItems.Count == 0 || selectedItems[0] != value)
                {
                    for (int i = selectedItems.Count; i > 0; i--)
                    {
                        selectedItems.RemoveAt(0);
                    }
                    selectedItems.Add(value);
                }
                this.OnPropertyChanged("SelectedItem");
			}
		}

        /// <summary>
        /// Gets or sets the resource items.
        /// </summary>
        /// <value>The resource items.</value>
        public ResourceItemCollection ResourceItems { get; private set; }

        private IAppointment Appointment { get; set; }

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnCheckedItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
            this.OnPropertyChanged("SelectedIndex");
            switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
					if (e.NewItems != null)
					{
						foreach (ResourceItem item in e.NewItems)
						{
                            IResource resource = this.Appointment.Resources.FirstOrDefault(r => r.IsEqualTo(item.Resource));
							if (resource == null)
							{
								this.Appointment.Resources.Add(item.Resource);
							}
						}
					}
					break;
				case NotifyCollectionChangedAction.Remove:
					if (e.OldItems != null)
					{
						foreach (ResourceItem item in e.OldItems)
						{
                            IResource resource = this.Appointment.Resources.FirstOrDefault(r => r.IsEqualTo(item.Resource));
							if (resource != null)
							{
								this.Appointment.Resources.Remove(resource);
							}
						}
					}
					break;
				case NotifyCollectionChangedAction.Replace:
					break;
				case NotifyCollectionChangedAction.Reset:
				default:
					break;
			}
		}

		private bool IsChecked(IResource resource)
		{
            return this.Appointment.Resources.Any(r => r.IsEqualTo(resource));
		}        
    }
}
