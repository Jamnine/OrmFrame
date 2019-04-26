using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
	/// <summary>
	/// ResourceGroupsCollection class.
	/// </summary>
	public class ResourceGroupsCollection : ObservableCollection<ResourceGroup>
	{
		private bool shouldRecreate = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceGroupsCollection"/> class.
		/// </summary>
		/// <param name="source">The source.</param>
		/// <param name="scheduler">The scheduler.</param>
		public ResourceGroupsCollection(AppointmentCollectionView source, RadScheduler scheduler)
		{
			this.Source = source;

			this.Scheduler = scheduler;

			this.Scheduler.ResourceTypes.CollectionChanged += this.OnCollectionChanged;
			this.Scheduler.ResourceStyleMappings.CollectionChanged += this.OnCollectionChanged;
			this.Source.CollectionChanged += this.OnCollectionChanged;

			this.RecreateGroups(true);
		}

		/// <summary>
		/// Gets or sets the scheduler.
		/// </summary>
		/// <value>The scheduler.</value>
		public RadScheduler Scheduler
		{
			get;
			set;
		}

		private AppointmentCollectionView Source
		{
			get;
			set;
		}

		internal void RecreateGroups(bool createNewGroups)
		{
			this.shouldRecreate = false;
			DateTime time = DateTime.Now;
			if (createNewGroups)
			{
				this.Clear();

				SchedulerPresenter presenter = this.Scheduler.SchedulerPresenter;
				if (presenter != null)
				{
					presenter.ClearOldAppointmentsControls();
				}
			}
			bool schedulerIsGrouped = !String.IsNullOrEmpty(this.Scheduler.GroupBy);
			if (!schedulerIsGrouped || this.Scheduler.ResourceTypes.Count == 0)
			{
				ResourceGroup group;
				if (createNewGroups)
				{
					group = new ResourceGroup();
					group.Resource = null;
				}
				else
				{
					group = this.Single(g => g.Resource == null);
					group.Appointments.Clear();
				}
				if (this.Scheduler.Appointments.Count > 0)
				{
					group.Appointments.AddRange(this.Scheduler.Appointments.ToList());
				}

				if (createNewGroups)
				{
					this.Add(group);
				}
			}
			else
			{
				List<GroupItem> groupedAppointments = new List<GroupItem>();
				if (this.Scheduler.ResourceTypes.Count == 0)
				{
					throw new System.ArgumentException("The ResourceTypes collection of RadScheduler has no items to group");
				}

				ResourceType type = this.Scheduler.ResourceTypes.SingleOrDefault(item => item.Name == this.Scheduler.GroupBy);
				if (type != null)
				{
					foreach (var res in type.Resources)
					{
						IEnumerable<GroupItem> groupItems = this.GenerateGroupItems(type, res);

						this.AddGroups(groupItems, res, createNewGroups);
						groupedAppointments.AddRange(groupItems.ToList());
					}
				}

				if (this.Scheduler.DisplayEmptyGroup)
				{
					this.AddEmptyGroup(groupedAppointments, createNewGroups);
				}
			}
			this.shouldRecreate = true;
		}

		private IEnumerable<GroupItem> GenerateGroupItems(ResourceType type, IResource res)
		{
			IEnumerable<GroupItem> groupItems =
							  from c in this.Source
							  from o in c.Resources
							  where (o.ResourceName == res.ResourceName && o.ResourceType == type.Name)
							  select new GroupItem() { Resource = o, Appointment = c };
			return groupItems;
		}

		private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (this.shouldRecreate)
			{
				if ((sender as ResourceTypeCollection) != null)
				{
					foreach (var type in this.Scheduler.ResourceTypes)
					{
						type.Resources.CollectionChanged -= this.OnResourceCollectionChanged;
						type.Resources.CollectionChanged += this.OnResourceCollectionChanged;
					}
					this.RecreateGroups(true);
				}
				else if ((sender as ResourceStyleMappingCollection) != null)
				{
					this.RecreateGroups(true);
				}
				else
				{
					this.RecreateGroups(false);
				}
			}
		}
		private void OnResourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			this.RecreateGroups(true);
		}
		private void AddEmptyGroup(List<GroupItem> groupItems, bool createNewGroups)
		{
			List<IAppointment> groupedAppointments = new List<IAppointment>();
			foreach (var g in groupItems)
			{
				groupedAppointments.Add(g.Appointment);
			}

			ResourceGroup group = new ResourceGroup();
			group.Resource = null;
			if (!createNewGroups)
			{
				group = this.Single(g => g.Resource == null);
				group.Appointments.Clear();
			}
			group.Appointments.AddRange(this.Scheduler.Appointments.Except(groupedAppointments));
			foreach (var app in group.Appointments)
			{
				app.Resources.CollectionChanged -= new NotifyCollectionChangedEventHandler(this.OnCollectionChanged);
				app.Resources.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnCollectionChanged);
			}
			if (createNewGroups)
			{
				this.Add(group);
			}
		}

		private void AddGroups(IEnumerable<GroupItem> groupItems, IResource resource, bool createNewGroups)
		{
			ResourceGroup group = new ResourceGroup();
			group.ResourceStyleMapping = this.Scheduler.ResourceStyleMappings.SingleOrDefault<ResourceStyleMapping>(map => map.ResourceType == resource.ResourceType && map.ResourceName == resource.ResourceName);

			if (createNewGroups)
			{
				group.Resource = resource;
			}
			else
			{
				group = this.SingleOrDefault(g => g.Resource == resource);
				if (group != null)
				{
					group.Appointments.Clear();
				}
			}
			if (groupItems != null)
			{
				foreach (var item in groupItems.ToList())
				{
					if (group != null)
					{
						group.Appointments.Add(item.Appointment);
					}
					item.Appointment.Resources.CollectionChanged -= new NotifyCollectionChangedEventHandler(this.OnCollectionChanged);
					item.Appointment.Resources.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnCollectionChanged);
				}
			}
			if (createNewGroups)
			{
				this.Add(group);
			}
		}
	}
}
