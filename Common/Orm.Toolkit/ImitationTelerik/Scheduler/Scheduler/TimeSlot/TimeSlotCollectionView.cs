using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Represents simple collection view that allows grouping of <see cref="TimeSlot"/>.
    /// </summary>
    public class TimeSlotCollectionView : TimeSlotObservableCollection
    {
        private readonly TimeSlotCollectionViewGroupRoot root;
        private RadScheduler scheduler;

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSlotCollectionView"/> class.
        /// </summary>
        public TimeSlotCollectionView()
        {
            this.root = new TimeSlotCollectionViewGroupRoot(this);
        }

        internal event EventHandler TimeSlotsUpdated;

        /// <summary>
        /// Gets or sets the culture information that will be used for grouping.
        /// </summary>
        /// <value>The culture.</value>
        public CultureInfo Culture { get; set; }

        /// <summary>
        /// Gets time slots for the first group.
        /// </summary>
        /// <value>The first group items.</value>
		public IEnumerable FirstGroupItemsHeaders
        {
            get
            {
				var list = new List<string>();
                TimeSlotGroup firstGroup = this.Groups.FirstOrDefault();
				if (firstGroup != null)
				{
					foreach (var item in firstGroup.TimeSlots)
					{
						item.ParentView = this;
						list.Add(item.FormattedStart);
					}

					return list;
				}
                return null;
            }
        }

		/// <summary>
		/// Gets time slots for the first group.
		/// </summary>
		/// <value>The first group items.</value>
		public IEnumerable FirstGroupItems
		{
			get
			{
				TimeSlotGroup firstGroup = this.Groups.FirstOrDefault();
				if (firstGroup != null)
				{
					foreach (var item in firstGroup.TimeSlots)
					{
						item.ParentView = this;
					    if (item.Start.Minute.ToString() == "0")
					        item.TimeIndicatorMin = "";
                        else if (item.End.Minute.ToString() == "0")
                            item.TimeIndicatorMin = Convert.ToString(item.Start.Minute);
                        else
                            item.TimeIndicatorMin = Convert.ToString(item.End.Minute - Scheduler.ActiveViewDefinition.TimeSlotLength.Minutes);
					}
					return firstGroup.TimeSlots;
				}

				return null;
			}
		}

        /// <summary>
        /// Gets a collection of <see cref="GroupDescriptions"/> objects that describe how
        /// the items in the collection are grouped in the view.
        /// </summary>
        /// <value>
        /// Collection of <see cref="GroupDescriptions"/> that will be used for populating
        /// the items in the groups.
        /// </value>
        public ObservableCollection<GroupDescription> GroupDescriptions
        {
            get
            {
                return this.root.GroupDescriptions;
            }
        }

        /// <summary>
        /// Gets or sets parent scheduler for the presenter. 
        /// </summary>
        /// <returns>The parent scheduler for this presenter. The default value is null</returns>  
        public RadScheduler Scheduler
        {
            get
            {
                return (RadScheduler)this.scheduler;
            }
            set
            {
               this.scheduler = value;
            }
        }

        /// <summary>
        /// Gets the first group items grouped by the second group description.
        /// </summary>
        /// <value>The first group items grouped by the second group description. If 
        /// <see cref="GroupDescriptions"/> are less than 1, then an empty enumerable is
        /// returned.</value>
        public IEnumerable GroupedFirstGroupItems
        {
            get
            {
                GroupDescription description = null;
                if (this.GroupDescriptions.Count > 1)
                {
                    description = this.GroupDescriptions[1];
                }

				IEnumerable firstGroupItems = this.FirstGroupItems;

                if (firstGroupItems == null || description == null)
                {
                    yield break;
                }

				IEnumerable<TimeSlotGroup> result = from TimeSlot slot in this.FirstGroupItems
                                                    group slot by description.GroupNameFromItem(slot, 2, this.Culture)
                                                    into g
                                                        select new TimeSlotGroup(g);

                foreach (TimeSlotGroup slotGroup in result)
                {
                    yield return slotGroup;
                }
            }
        }


        /// <summary>
        /// Gets all groups that are constructed based on the 
        /// <see cref="GroupDescriptions"/> property. 
        /// </summary>
        /// <value>A read-only collection of all time slots groups.</value>
        public ReadOnlyObservableCollection<TimeSlotGroup> Groups
        {
            get
            {
                return this.root.Groups;
            }
        }
		
        /// <summary>
        /// Gets count of all groups that are constructed based on the 
        /// <see cref="Groups"/> property. 
        /// </summary>
        /// <value>A read-only property.</value>
        public int GroupsCount
        {
            get
            {
                return this.Groups.Count;
            }
        }

        internal void RaiseTimeSlotsUpdated()
        {
            if (this.TimeSlotsUpdated != null)
            {
                this.TimeSlotsUpdated(this, EventArgs.Empty);
            }
            foreach (var item in this.Items)
            {
                item.ParentView = this;
            }
            this.OnPropertyChanged(new PropertyChangedEventArgs("FirstGroupItems"));
            this.OnPropertyChanged(new PropertyChangedEventArgs("GroupedFirstGroupItems"));
        }

        /// <summary>
        /// Ends the deferred refresh.
        /// </summary>
        protected override void OnEndDefer()
        {
            this.root.RefreshGroups();

            base.OnEndDefer();
        }
    }
}
