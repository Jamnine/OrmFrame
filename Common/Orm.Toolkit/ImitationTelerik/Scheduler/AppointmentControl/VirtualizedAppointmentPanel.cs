using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// A virtualizing panel for rendering appointments.
	/// </summary>
	public class VirtualizedAppointmentPanel : VirtualizingPanel
	{
		/// <summary>
		/// Identifies the <see cref="AppointmentsRightPadding"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentsRightPadding"/> property</returns>
		[Obsolete("This property does not affect AppointmentItem rendering anymore and will be removed in future release.")]
		public static readonly DependencyProperty AppointmentsRightPaddingProperty =
			DependencyProperty.Register("AppointmentsRightPadding", typeof(double), typeof(VirtualizedAppointmentPanel), new FrameworkPropertyMetadata(null));

		/// <summary>
		/// Identifies the Orientation dependency property.
		/// </summary>
		public static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register("Orientation", typeof(Orientation), typeof(VirtualizedAppointmentPanel), new PropertyMetadata(Orientation.Vertical));

		private static TimeSpan singleDayTimeSpan = new TimeSpan(1, 0, 0, 0, 0);

		private bool containersGenerated;
		private Size previousAvailableSize;
		private TimeSpan timeSlotTimeSpan = singleDayTimeSpan;

		private List<TimeSlotItemAppointments> slots = new List<TimeSlotItemAppointments>();
		private List<List<List<AppointmentSlotInfo>>> columns = new List<List<List<AppointmentSlotInfo>>>();

		/// <summary>
		/// Gets or sets a value that indicates the dimension by which child elements are stacked. Default value is Vertical.
		/// This is a dependency property. 
		/// </summary>
		public Orientation Orientation
		{
			get { return (Orientation)GetValue(OrientationProperty); }
			set { SetValue(OrientationProperty, value); }
		}

		/// <summary>
		/// Gets or sets <see cref="AppointmentsRightPaddingProperty"/>. This is a dependency property.
		/// </summary>
		/// <returns>the <see cref="AppointmentsRightPaddingProperty"/>. The default value is 0.0</returns>  
		[Obsolete("This property does not affect AppointmentItem rendering anymore and will be removed in future release.")]
		public double AppointmentsRightPadding
		{
			get
			{
				return (double)GetValue(AppointmentsRightPaddingProperty);
			}
			set
			{
				SetValue(AppointmentsRightPaddingProperty, value);
			}
		}

		internal List<TimeSlotItemAppointments> Slots
		{
			get
			{
				return this.slots;
			}
		}

		private int ItemCount
		{
			get
			{
				System.Windows.Controls.ItemsControl itemsOwner = ItemsControl.GetItemsOwner(this);
				if (itemsOwner == null)
				{
					return 0;
				}

				var concreteItemContainerGenerator = this.ItemContainerGenerator as System.Windows.Controls.ItemContainerGenerator;
				if (concreteItemContainerGenerator == null)
				{
					return itemsOwner.Items.Count;
				}

				return itemsOwner.Items.Count;
			}
		}



		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private bool InRecyclingMode
		{
			get
			{
				return true;
			}
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private bool IsVirtualizing
		{
			get
			{
				return true;
			}
		}

		private AppointmentItemsControl AppointmentItemsControl
		{
			get
			{
				return ItemsControl.GetItemsOwner(this) as AppointmentItemsControl;
			}
		}

		private TimeSlotItemsControl TimeSlotItemsControl
		{
			get
			{
				if (this.AppointmentItemsControl != null)
				{
					return this.AppointmentItemsControl.TimeSlotItemsControl;
				}

				return null;
			}
		}

		internal static List<AppointmentSlotInformation> InitizlieAppointmentSlotInformation(AppointmentSlotCollection source)
		{
			List<AppointmentSlotInformation> slotsInfo = new List<AppointmentSlotInformation>();

			int count = source.Count;
			for (int i = 0; i < count; i++)
			{
				var appSlot = source[i];

				slotsInfo.Add(new AppointmentSlotInformation() { Index = i, AppointmentSlot = appSlot, IsFirst = true });
				slotsInfo.Add(new AppointmentSlotInformation() { Index = i, AppointmentSlot = appSlot, IsFirst = false });
			}

			slotsInfo.Sort((si1, si2) =>
			{
				int r = si1.Time.CompareTo(si2.Time);
				if (r == 0)
				{
					r = si1.IsFirst == si2.IsFirst ? 0 : si1.IsFirst ? 1 : -1;
				}
				if (r == 0)
				{
					var duration1 = si1.AppointmentSlot.TimeSlot.Duration();
					var duration2 = si2.AppointmentSlot.TimeSlot.Duration();
					r = duration1.CompareTo(duration2) * (si1.IsFirst ? -1 : 1);
				}
				if (r == 0)
				{
					r = si1.Index.CompareTo(si2.Index);
				}
				return r;
			});

			return slotsInfo;
		}

		internal static List<AppointmentSlotGroupInfo> InitizlieAppointmentSlotGroup(List<AppointmentSlotInformation> sortedAppointmentInfo)
		{
			var result = new List<AppointmentSlotGroupInfo>();
			int counter = 0;
			var currentGroup = new AppointmentSlotGroupInfo();

			foreach (var item in sortedAppointmentInfo)
			{
				if (item.IsFirst)
				{
					counter++;
					currentGroup.AppointmentSlots.Add(item.AppointmentSlot);
				}
				else
				{
					counter--;
				}

				if (currentGroup.Columns < counter)
				{
					currentGroup.Columns = counter;
				}

				if (counter == 0)
				{
					result.Add(currentGroup);
					currentGroup = new AppointmentSlotGroupInfo();
				}
			}

			return result;
		}

		internal static List<List<AppointmentSlotInfo>> SplitToColumns(AppointmentSlotGroupInfo groupInfo)
		{
			var result = new List<List<AppointmentSlotInfo>>(groupInfo.Columns);

			var tempList = groupInfo.AppointmentSlots.ToList();

			for (int i = 0; i < groupInfo.Columns; i++)
			{
				var column = new List<AppointmentSlotInfo>();
				column.Add(new AppointmentSlotInfo { AppointmentSlot = tempList[0], CoumnsSpan = 1 });
				var currentEnd = tempList[0].TimeSlot.End;
				tempList.RemoveAt(0);

				for (int j = 0; j < tempList.Count; j++)
				{
					if (tempList[j].TimeSlot.Start >= currentEnd)
					{
						column.Add(new AppointmentSlotInfo { AppointmentSlot = tempList[j], CoumnsSpan = 1 });
						currentEnd = tempList[j].TimeSlot.End;
						tempList.RemoveAt(j--);
					}
				}

				result.Add(column);
			}

			for (int i = 0; i < groupInfo.Columns; i++)
			{
				foreach (var info in result[i])
				{
					for (int j = i + 1; j < groupInfo.Columns; j++)
					{
						if (!result[j].Any(asi => asi.AppointmentSlot.TimeSlot.IntersectsWith(info.AppointmentSlot.TimeSlot)))
						{
							info.CoumnsSpan++;
						}
						else
						{
							break;
						}
					}
				}
			}

			return result;
		}

		internal void RecycleAllAppointmentItems()
		{
			foreach (UIElement item in this.InternalChildren)
			{
				int itemIndex = ((System.Windows.Controls.ItemContainerGenerator)this.ItemContainerGenerator).IndexFromContainer(item);

				if (itemIndex > -1)
				{
					this.RecycleAppointmentItem(item, itemIndex);
				}
			}

			this.slots.Clear();
		}

		/// <summary>
		/// Provides the behavior for the Measure pass of Silverlight layout. Classes can override this method to define their own Measure pass behavior.
		/// </summary>
		/// <param name="availableSize">The available size that this object can give to child objects. Infinity can be specified as a value to indicate that the object will size to whatever content is available.</param>
		/// <returns>
		/// The size that this object determines it needs during layout, based on its calculations of child object allotted sizes.
		/// </returns>
		protected override Size MeasureOverride(Size availableSize)
		{

			// This is need for WPF to initialize ItemConteinerGenerator property.
			if (this.InternalChildren != null)
			{
			}

			int timeSlotsCount;
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			AppointmentItemsControl appointmentsItemsControl = this.AppointmentItemsControl;
			Size timeSlotSize = this.GetTimeSlotItemContentHostRenderSize(out timeSlotsCount);

			if (timeSlotSize.IsEmpty || timeSlotSize == new Size() || (this.previousAvailableSize != availableSize && !isHorizontal))
			{
				this.previousAvailableSize = availableSize;

				if (timeSlotsCount > 0)
				{
					this.containersGenerated = false;
				}

				if (!isHorizontal)
				{
					this.RecycleAllAppointmentItems();
				}

				return base.MeasureOverride(availableSize);
			}
			else
			{
				this.previousAvailableSize = availableSize;

				if (isHorizontal)
				{
					if (this.columns.Count == 0)
					{
						this.InitializeColumns();
					}
					this.GenerateContainers();
				}
				else
				{
					RadScheduler scheduler = this.AppointmentItemsControl != null ? this.AppointmentItemsControl.Scheduler : null;
					if (scheduler != null && scheduler.ActiveViewDefinition != null && scheduler.ActiveViewDefinition.TimeSlotLength != TimeSpan.Zero)
					{
						this.timeSlotTimeSpan = scheduler.ActiveViewDefinition.TimeSlotLength;
					}
					else
					{
						this.timeSlotTimeSpan = singleDayTimeSpan;
					}

					if (this.slots.Count == 0)
					{
						this.GenerateSlots(timeSlotsCount);
					}

					if (this.IsVirtualizing && this.InRecyclingMode)
					{
						this.HideShowMoreButtons();
					}

					var source = this.AppointmentItemsControl.ItemsSource as AppointmentSlotCollection;

					for (int i = 0; i < timeSlotsCount; i++)
					{
						TimeSlotItemAppointments item = this.slots[i] as TimeSlotItemAppointments;
						this.GenerateContainers(item, source);
					}
				}

				if (double.IsInfinity(availableSize.Width) || double.IsInfinity(availableSize.Height))
				{
					return this.TimeSlotItemsControl.DesiredSize;
				}

				return availableSize;
			}
		}

		/// <summary>
		///  Called when the System.Windows.Controls.ItemsControl.Items collection that
		///  is associated with the System.Windows.Controls.ItemsControl for this System.Windows.Controls.Panel changes.
		/// </summary>
		/// <param name="sender">The System.Object that raised the event.</param>
		/// <param name="args">Provides data for the System.Windows.Controls.ItemContainerGenerator.ItemsChanged event.</param>
		protected override void OnItemsChanged(object sender, ItemsChangedEventArgs args)
		{
			base.OnItemsChanged(sender, args);
			if (this.columns != null)
			{
				this.columns.Clear();
			}
			if (this.slots != null)
			{
				this.slots.Clear();
			}
		}

		/// <summary>
		/// Provides the behavior for the Arrange pass of Silverlight layout. Classes can override this method to define their own Arrange pass behavior.
		/// </summary>
		/// <param name="finalSize">The final area within the parent that this object should use to arrange itself and its children.</param>
		/// <returns>
		/// The actual size used once the element is arranged.
		/// </returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			bool isHorizontal = this.Orientation == Orientation.Horizontal;
			var source = this.AppointmentItemsControl.ItemsSource as AppointmentSlotCollection;

			if (!this.containersGenerated)
			{
				this.containersGenerated = true;
				this.Dispatcher.BeginInvoke(new Action(() => this.InvalidateMeasure()));

				return base.ArrangeOverride(finalSize);
			}
			else if (isHorizontal)
			{
				for (int i = 0; i < this.columns.Count; i++)
				{
					var columnInfo = this.columns[i];
					for (int j = 0; j < columnInfo.Count; j++)
					{
						var column = columnInfo[j];
						foreach (var appInfo in column)
						{
							AppointmentSlot appSlot = appInfo.AppointmentSlot;
							Rect arrangeRect = this.GetArrangeRectForHorizontalOrientation(appInfo, j, columnInfo.Count);
							UIElement appItem = ((System.Windows.Controls.ItemContainerGenerator)this.ItemContainerGenerator).ContainerFromItem(appSlot) as UIElement;
							if (appItem != null)
							{
								appItem.Arrange(arrangeRect);
							}
						}
					}
				}
			}
			else
			{
				foreach (var slot in this.slots)
				{
					foreach (var app in slot.Appointments)
					{
						var appSlot = app.Value;
						if (appSlot.TimeSlot.Start == slot.TimeSlot.Start)
						{
							Rect arrangeRect = this.GetLayoutSlot(appSlot);
							UIElement appointmentItem = ((System.Windows.Controls.ItemContainerGenerator)this.ItemContainerGenerator).ContainerFromItem(appSlot) as UIElement;
							if (appointmentItem != null)
							{
								double desiredHeight = appointmentItem.DesiredSize.Height;
								arrangeRect.Y += app.Key * desiredHeight;
								arrangeRect.Height = desiredHeight;

								appointmentItem.Arrange(arrangeRect);
							}
						}
					}
				}
			}

			return finalSize;
		}

		private static void PrepareContainer(UIElement child, bool newlyRealized)
		{
			if (!newlyRealized)
			{
				child.ClearValue(UIElement.VisibilityProperty);

			}
		}

		private static void RecycleContainer(UIElement child)
		{
			child.Visibility = Visibility.Collapsed;

		}

		private void RecycleAppointmentItem(UIElement item, int itemIndex)
		{
			var position = this.ItemContainerGenerator.GeneratorPositionFromIndex(itemIndex);
			position = new GeneratorPosition(position.Index, 0);
			((IRecyclingItemContainerGenerator)this.ItemContainerGenerator).Recycle(position, 1);
			RecycleContainer(item);
		}

		private Size GetTimeSlotItemContentHostRenderSize(out int timeSlotsCount)
		{
			timeSlotsCount = 0;
			Size timeSlotSize = Size.Empty;
			TimeSlotItemsControl timeSlotItemsControl = this.TimeSlotItemsControl;

			if (timeSlotItemsControl != null)
			{
				timeSlotsCount = timeSlotItemsControl.Items.Count;
				for (int i = 0; i < timeSlotsCount; i++)
				{
					TimeSlotItem item = timeSlotItemsControl.ItemContainerGenerator.ContainerFromIndex(i) as TimeSlotItem;
					if (item != null)
					{
						var contentHost = item.ContentHost ?? item;
						timeSlotSize = contentHost.RenderSize;
						break;
					}
				}
			}

			return timeSlotSize;
		}

		private void GenerateSlots(int timeSlotsCount)
		{
			var source = this.AppointmentItemsControl.ItemsSource as AppointmentSlotCollection;

			for (int i = 0; i < timeSlotsCount; i++)
			{
				TimeSlotItem item = this.TimeSlotItemsControl.ItemContainerGenerator.ContainerFromIndex(i) as TimeSlotItem;
				if (item != null)
				{
					this.slots.Add(new TimeSlotItemAppointments(item));
				}
			}

			foreach (var item in this.slots)
			{
				TimeSlotItem timeSlotItem = item.TimeSlotItem;
				TimeSlot timeSlot = item.TimeSlot;

				var appointmentSlots = (from appointmentSlot in source
										where appointmentSlot.TimeSlot.Start == timeSlot.Start
										orderby appointmentSlot.Occurrence.Duration() descending
										select appointmentSlot).ToList();

				int index = 0;

				bool indexInUse = item.Appointments.ContainsKey(index);

				while (indexInUse)
				{
					index++;
					indexInUse = item.Appointments.ContainsKey(index);
				}

				foreach (var appSlot in appointmentSlots)
				{
					int durationInDays = this.GetAppointmentSlotDuration(appSlot);

					item.Appointments[index] = appSlot;

					if (durationInDays > 1)
					{
						int timeSlotIndex = this.slots.IndexOf(item) + 1;
						int count = Math.Min(durationInDays + timeSlotIndex - 1, this.slots.Count);

						for (int i = timeSlotIndex; i < count; i++)
						{
							TimeSlotItemAppointments nextTimeSlotAppointment = this.slots[i];
							nextTimeSlotAppointment.Appointments[index] = appSlot;
						}
					}

					index++;
					indexInUse = item.Appointments.ContainsKey(index);

					while (indexInUse)
					{
						index++;
						indexInUse = item.Appointments.ContainsKey(index);
					}
				}
			}
		}

		private int GetAppointmentSlotDuration(AppointmentSlot appSlot)
		{
			RadScheduler scheduler = this.AppointmentItemsControl != null ? this.AppointmentItemsControl.Scheduler : null;
			if (scheduler != null)
			{
				TimelineViewDefinition viewDefinition = scheduler.ActiveViewDefinition as TimelineViewDefinition;
				if (viewDefinition != null && viewDefinition.CustomTimeSlotLength != DateTimeInterval.Zero)
				{
					TimeSpan customTimeSpan;

					var customTimeSlotLength = viewDefinition.CustomTimeSlotLength;
					if (customTimeSlotLength.Months > 0)
					{
						DateTime date = appSlot.TimeSlot.Start;
						DateTime startDate = appSlot.TimeSlot.Start;
						DateTime endDate = appSlot.TimeSlot.End;
						TimeSpan duration = endDate - startDate;

						int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
						int span = 0;
						while (duration.TotalSeconds > 0)
						{
							duration -= TimeSpan.FromDays(daysInMonth);
							date = date.AddMonths(1);
							daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
							span++;
						}

						if (span < 1)
						{
							return 1;
						}
						else
						{
							return span;
						}
					}
					else if (customTimeSlotLength.Weeks > 0)
					{
						customTimeSpan = TimeSpan.FromDays(customTimeSlotLength.Weeks * 7);
					}
					else
					{
						customTimeSpan = new TimeSpan(customTimeSlotLength.Days, customTimeSlotLength.Hours, 0, 0, 0);
					}

					return (int)(appSlot.TimeSlot.Duration().TotalSeconds / customTimeSpan.TotalSeconds);
				}
				else
				{
					return (int)(appSlot.TimeSlot.Duration().TotalSeconds / this.timeSlotTimeSpan.TotalSeconds);
				}
			}

			return 1;
		}

		private void HideShowMoreButtons()
		{
			bool isHorizontal = this.Orientation == Orientation.Horizontal;
			var timeSlotItemsControl = this.TimeSlotItemsControl;
			if (!isHorizontal && timeSlotItemsControl != null)
			{
				for (int i = 0; i < timeSlotItemsControl.Items.Count; i++)
				{
					TimeSlotItem item = timeSlotItemsControl.ItemContainerGenerator.ContainerFromIndex(i) as TimeSlotItem;
					if (item != null && item.ShowMoreButton != null)
					{
						item.ShowMoreButton.Opacity = 0;
						item.ShowMoreButton.IsEnabled = false;
					}
				}
			}
		}

		private void GenerateContainers(TimeSlotItemAppointments timeSlotAppointment, AppointmentSlotCollection source)
		{
			var timeSlotItem = timeSlotAppointment.TimeSlotItem;
			var timeSlot = timeSlotItem.TimeSlot;
			var contentHost = timeSlotItem.ContentHost ?? timeSlotItem;
			double contentHostHeight = contentHost.RenderSize.Height;

			int childIndex = 0;
			double stackDesiredSizeHeight = 0;
			IItemContainerGenerator generator = this.ItemContainerGenerator;
			bool generate = true;

			for (int i = 0; i < timeSlotAppointment.Appointments.Count; i++)
			{
				if (!timeSlotAppointment.Appointments.ContainsKey(i))
				{
					continue;
				}

				var appSlot = timeSlotAppointment.Appointments[i];
				if (appSlot.TimeSlot.Start != timeSlot.Start)
				{
					continue;
				}

				int itemIndex = source.IndexOf(appSlot);

				UIElement child = ((System.Windows.Controls.ItemContainerGenerator)generator).ContainerFromIndex(itemIndex) as UIElement;

				if (!generate)
				{
					if (child != null)
					{
						this.RecycleAppointmentItem(child, itemIndex);
					}
					continue;
				}

				if (child == null)
				{
					GeneratorPosition position = generator.GeneratorPositionFromIndex(itemIndex);
					child = this.GenerateContainerAtPosition(position, ref childIndex);
				}

				Rect arrangeRect = this.GetLayoutSlot(appSlot);

				if (child != null)
				{
					child.Measure(arrangeRect.Size);


					Size desiredSize = child.DesiredSize;
					int currentIndex = i + 1;
					stackDesiredSizeHeight = desiredSize.Height * currentIndex;

					if (this.IsVirtualizing && stackDesiredSizeHeight >= contentHostHeight)
					{
						var button = timeSlotItem.ShowMoreButton;
						if (button != null)
						{
							button.Opacity = 1;
							button.IsEnabled = true;
						}

						this.RecycleAppointmentItem(child, itemIndex);
						generate = false;
					}
				}
			}
		}

		private void GenerateContainers()
		{
			var source = this.AppointmentItemsControl.ItemsSource as AppointmentSlotCollection;
			var generator = this.ItemContainerGenerator;
			int childIndex = 0;

			for (int i = 0; i < this.columns.Count; i++)
			{
				var columnInfo = this.columns[i];
				for (int j = 0; j < columnInfo.Count; j++)
				{
					var column = columnInfo[j];
					foreach (var appInfo in column)
					{
						AppointmentSlot appSlot = appInfo.AppointmentSlot;
						Rect arrangeRect = this.GetArrangeRectForHorizontalOrientation(appInfo, j, columnInfo.Count);

						int itemIndex = source.IndexOf(appSlot);
						UIElement child = ((System.Windows.Controls.ItemContainerGenerator)this.ItemContainerGenerator).ContainerFromIndex(itemIndex) as UIElement;

						if (child == null)
						{
							GeneratorPosition position = generator.GeneratorPositionFromIndex(itemIndex);
							child = this.GenerateContainerAtPosition(position, ref childIndex);
						}

						if (child != null)
						{
							child.Measure(arrangeRect.Size);

						}
					}
				}
			}
		}

		private UIElement GenerateContainerAtPosition(GeneratorPosition position, ref int childIndex)
		{
			UIElement child = null;

			using (this.ItemContainerGenerator.StartAt(position, GeneratorDirection.Forward, true))
			{
				// Get next child. 
				bool newlyRealized;
				child = this.ItemContainerGenerator.GenerateNext(out newlyRealized) as UIElement;

				if (child == null)
				{
					Debug.Assert(!newlyRealized, "The generator realized a null value.");

					// We reached the end of the items
					return null;
				}

				PrepareContainer(child, newlyRealized);

				this.AddContainerFromGenerator(childIndex, child, newlyRealized);
				childIndex++;

				this.ItemContainerGenerator.PrepareItemContainer(child);
			}

			return child;
		}

		private bool AddContainerFromGenerator(int childIndex, UIElement child, bool newlyRealized)
		{
			if (!newlyRealized)
			{
				if (!this.InRecyclingMode)
				{
					return false;
				}

				IList realizedChildren = this.InternalChildren;
				if ((childIndex < realizedChildren.Count) && (realizedChildren[childIndex] == child))
				{
					return false;
				}

				if (!realizedChildren.Contains(child))
				{
					return this.InsertRecycledContainer(childIndex, child);
				}
				else
				{
					return false;
				}
			}

			this.InsertNewContainer(childIndex, child);
			return false;
		}

		private bool InsertRecycledContainer(int childIndex, UIElement container)
		{
			return this.InsertContainer(childIndex, container, true);
		}

		private void InsertNewContainer(int childIndex, UIElement container)
		{
			this.InsertContainer(childIndex, container, false);
		}

		private bool InsertContainer(int childIndex, UIElement container, bool isRecycled)
		{
			if (!isRecycled)
			{
				this.InsertInternalChild(childIndex, container);
				return true;
			}

			return false;
		}

		private Rect GetArrangeRectForHorizontalOrientation(AppointmentSlotInfo slotInfo, int index, int count)
		{
			var appSlot = slotInfo.AppointmentSlot;
			Rect layoutSlot = this.GetLayoutSlot(appSlot);

			double singleSlotWidth = layoutSlot.Width / count;
			layoutSlot.X += singleSlotWidth * index;

			int columnSpan = slotInfo.CoumnsSpan;
			layoutSlot.Width = singleSlotWidth * columnSpan;

			return layoutSlot;
		}

		private Rect GetLayoutSlot(AppointmentSlot appSlot)
		{
			var timeSlotGroup = appSlot.TimeSlot as TimeSlotGroup;

			Debug.Assert(timeSlotGroup != null, "TimeSlot should be TimeSlotGroup");
			if (timeSlotGroup == null)
			{
				return new Rect();
			}

			var firstTimeSlot = timeSlotGroup.TimeSlots.FirstOrDefault();
			Debug.Assert(firstTimeSlot != null, "TimeSlotGroup TimeSlots should not be empty");
			if (firstTimeSlot == null)
			{
				return new Rect();
			}

			var lastTimeSlot = timeSlotGroup.TimeSlots.LastOrDefault();
			Debug.Assert(lastTimeSlot != null, "TimeSlotGroup TimeSlots should not be empty");
			if (lastTimeSlot == null)
			{
				return new Rect();
			}

			var timeSlotItemsControl = this.TimeSlotItemsControl;
			Debug.Assert(timeSlotItemsControl != null, "TimeSlotItemsControl should not be null");
			if (timeSlotItemsControl == null)
			{
				return new Rect();
			}

			TimeSlotItem firstTimeSlotItem = timeSlotItemsControl.ItemContainerGenerator.ContainerFromItem(firstTimeSlot) as TimeSlotItem;
			Debug.Assert(firstTimeSlotItem != null, "First TimeSlotItem should not be null");
			if (firstTimeSlotItem == null)
			{
				return new Rect();
			}

			TimeSlotItem lastTimeSlotItem = timeSlotItemsControl.ItemContainerGenerator.ContainerFromItem(lastTimeSlot) as TimeSlotItem;
			Debug.Assert(lastTimeSlotItem != null, "Last TimeSlotItem should not be null");
			if (lastTimeSlotItem == null)
			{
				return new Rect();
			}

			var firstContentHost = firstTimeSlotItem.ContentHost ?? firstTimeSlotItem;
			var lastContentHost = lastTimeSlotItem.ContentHost ?? lastTimeSlotItem;

			Point topLeft = firstContentHost.TransformToVisual(this).Transform(new Point());
			Point bottomRight = lastContentHost.TransformToVisual(this).Transform(new Point(lastContentHost.ActualWidth, lastContentHost.ActualHeight));

			return new Rect(topLeft, bottomRight);
		}

		private void InitializeColumns()
		{
			if (this.Orientation == Orientation.Horizontal)
			{
				AppointmentSlotCollection source = this.AppointmentItemsControl != null ? this.AppointmentItemsControl.ItemsSource as AppointmentSlotCollection : null;
				if (source != null)
				{
					var sortedAppointmentInfo = InitizlieAppointmentSlotInformation(source);
					var groups = InitizlieAppointmentSlotGroup(sortedAppointmentInfo);
					for (int i = 0; i < groups.Count; i++)
					{
						var groupInfo = groups[i];
						this.columns.Add(VirtualizedAppointmentPanel.SplitToColumns(groupInfo));
					}
				}
			}
		}

		internal struct AppointmentSlotInformation
		{
			public int Index { get; set; }
			public bool IsFirst { get; set; }
			public AppointmentSlot AppointmentSlot { get; set; }
			public DateTime Time
			{
				get
				{
					return this.IsFirst ? this.AppointmentSlot.TimeSlot.Start : this.AppointmentSlot.TimeSlot.End;
				}
			}
		}

		internal class TimeSlotItemAppointments
		{
			public TimeSlotItemAppointments(TimeSlotItem timeSlotItem)
			{
				this.TimeSlotItem = timeSlotItem;
				this.Appointments = new Dictionary<int, AppointmentSlot>();
			}

			public TimeSlotItem TimeSlotItem
			{
				get;
				private set;
			}

			public Dictionary<int, AppointmentSlot> Appointments
			{
				get;
				private set;
			}

			public TimeSlot TimeSlot
			{
				get
				{
					return this.TimeSlotItem.TimeSlot;
				}
			}
		}

		internal class AppointmentSlotInfo
		{
			public AppointmentSlot AppointmentSlot { get; set; }
			public int CoumnsSpan { get; set; }
		}

		internal class AppointmentSlotGroupInfo
		{
			private List<AppointmentSlot> appointmentSlots = new List<AppointmentSlot>();

			public int Columns { get; set; }
			public DateTime Start { get; set; }
			public DateTime End { get; set; }
			public List<AppointmentSlot> AppointmentSlots
			{
				get
				{
					return this.appointmentSlots;
				}
			}
		}
	}
}