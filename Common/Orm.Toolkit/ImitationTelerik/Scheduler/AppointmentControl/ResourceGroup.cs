using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// ResourceGroup class.
	/// </summary>
	public class ResourceGroup
	{
		private readonly AppointmentCollectionView appointments;

		/// <summary>
		/// Initializes a new instance of the <see cref="ResourceGroup"/> class.
		/// </summary>
		public ResourceGroup()
		{
			this.appointments = new AppointmentCollectionView();
		}

		/// <summary>
		/// Gets or sets the resource.
		/// </summary>
		/// <value>The resource.</value>
		public IResource Resource
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the resource.
		/// </summary>
		/// <value>The resource.</value>
		public ResourceStyleMapping ResourceStyleMapping
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the appointments.
		/// </summary>
		/// <value>The appointments.</value>
		public AppointmentCollectionView Appointments
		{
			get
			{
				return this.appointments;
			}
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
	}
}
