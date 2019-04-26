using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    internal class TimeSlotCollectionViewGroupRoot
    {
        private readonly TimeSlotCollectionView collectionView;
        private readonly ObservableCollection<TimeSlotGroup> groupsCollection;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotCollectionViewGroupRoot"/> class.
        /// </summary>
        /// <param name="collectionView">The collection view.</param>
        /// <exception cref="ArgumentNullException"><c>collectionView</c> is null.</exception>
        internal TimeSlotCollectionViewGroupRoot(TimeSlotCollectionView collectionView)
        {
            if (collectionView == null)
            {
                throw new ArgumentNullException("collectionView");
            }

            this.collectionView = collectionView;
            this.collectionView.CollectionChanged += this.OnViewCollectionChanged;

            this.GroupDescriptions = new ObservableCollection<GroupDescription>();
            this.GroupDescriptions.CollectionChanged += this.OnGroupDescriptionsCollectionChanged;

            this.groupsCollection = new ObservableCollection<TimeSlotGroup>();
            this.Groups = new ReadOnlyObservableCollection<TimeSlotGroup>(this.groupsCollection);
        }

        internal ObservableCollection<GroupDescription> GroupDescriptions { get; private set; }
        internal ReadOnlyObservableCollection<TimeSlotGroup> Groups { get; private set; }

        internal virtual void RefreshGroups()
        {
            if (this.collectionView.IsRefreshDeferred)
            {
                return;
            }

            this.groupsCollection.Clear();

            // For now we use only the first group description
            GroupDescription description = this.GroupDescriptions.FirstOrDefault();

            if (description != null)
            {
                IEnumerable<TimeSlotGroup> groups =
                    from timeSlot in this.collectionView
                    group timeSlot by description.GroupNameFromItem(timeSlot, 1, this.collectionView.Culture)
                    into g
                        select new TimeSlotGroup(g);

                foreach (TimeSlotGroup group in groups)
                {
                    this.groupsCollection.Add(group);
                }
            }
            else
            {
                this.groupsCollection.Add(new TimeSlotGroup(this.collectionView));
            }
        }

        // TODO: check for optimizations here
        private void OnGroupDescriptionsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.RefreshGroups();
        }

        private void OnViewCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.RefreshGroups();
        }
    }
}