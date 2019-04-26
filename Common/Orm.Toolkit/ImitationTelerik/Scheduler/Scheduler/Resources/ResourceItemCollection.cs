using System;
using System.Collections.ObjectModel;
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

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// A class for a typical collection of a resource item.
    /// </summary>
    public class ResourceItemCollection : ObservableCollection<ResourceItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceItemCollection"/> class.
        /// </summary>
        public ResourceItemCollection()
        {
            this.CheckedItems = new ObservableCollection<ResourceItem>();
        }

        /// <summary>
        /// Gets or sets the checked items.
        /// </summary>
        /// <value>The checked items.</value>
        public ObservableCollection<ResourceItem> CheckedItems { get; private set; }

        /// <summary>
        /// Inserts an item into the collection at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="item"/> should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        protected override void InsertItem(int index, ResourceItem item)
        {
            this.InitializeNotifications(item);
            base.InsertItem(index, item);
        }

        /// <summary>
        /// Removes the item at the specified index of the collection.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        protected override void RemoveItem(int index)
        {
            this.ClearNotifications(index);
            base.RemoveItem(index);
        }

        /// <summary>
        /// Replaces the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to replace.</param>
        /// <param name="item">The new value for the element at the specified index.</param>
        protected override void SetItem(int index, ResourceItem item)
        {
            this.ClearNotifications(index);
            this.InitializeNotifications(item);
            base.SetItem(index, item);
        }

        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        protected override void ClearItems()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.ClearNotifications(i);
            }
            base.ClearItems();
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "IsChecked")
            {
                ResourceItem item = sender as ResourceItem;
                if (item.IsChecked)
                {
                    this.AddToCheckedItems(item);
                }
                else
                {
                    this.RemoveFromCheckedItems(item);
                }
            }
        }

        private void AddToCheckedItems(ResourceItem item)
        {
            if (!this.CheckedItems.Contains(item))
            {
                this.CheckedItems.Add(item);
                this.OnPropertyChanged(new PropertyChangedEventArgs("CheckedItems"));
            }
        }

        private void RemoveFromCheckedItems(ResourceItem item)
        {
            if (this.CheckedItems.Contains(item))
            {
                this.CheckedItems.Remove(item);
                this.OnPropertyChanged(new PropertyChangedEventArgs("CheckedItems"));
            }
        }

        private void InitializeNotifications(ResourceItem item)
        {
            item.PropertyChanged += this.OnItemPropertyChanged;
            if (item.IsChecked)
                this.AddToCheckedItems(item);
            item.Owner = this;
        }

        private void ClearNotifications(int index)
        {
            if (index < this.Count)
            {
                ResourceItem item = this[index];
                item.PropertyChanged -= this.OnItemPropertyChanged;
                this.RemoveFromCheckedItems(item);
                item.Owner = null;
            }
        }
    }
}
