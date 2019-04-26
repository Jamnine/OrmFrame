using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Arranges child appointment slots, stacking intersected ones according the <see cref="Orientation"/> property. 
	/// </summary>
	public class AppointmentPanel : Panel
	{
		/// <summary>
		/// Identifies the <see cref="Orientation"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="Orientation"/> property.</returns>
		public static readonly DependencyProperty OrientationProperty =
			DependencyProperty.Register(
				"Orientation",
				typeof(Orientation),
				typeof(AppointmentPanel),
				new FrameworkPropertyMetadata(Orientation.Vertical, FrameworkPropertyMetadataOptions.AffectsMeasure));

		/// <summary>
		/// Identifies the <see cref="AppointmentsRightPadding"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="AppointmentsRightPadding"/> property</returns>
		public static readonly DependencyProperty AppointmentsRightPaddingProperty =
			DependencyProperty.Register("AppointmentsRightPadding", typeof(double), typeof(AppointmentPanel), new FrameworkPropertyMetadata(null));

		// TODO: Check if this is required in MeasureOverride and ArrangeOverride and refactor if necessary
		private Dictionary<TimeSlotItem, bool> timeSlotsScrolling;

		private TimeSlotItemsControl timeSlotItemsControl;

		private LayoutState layoutState;

		private EventHandler updateShowMoreButtons;
		private EventHandler invalidateMeasureForArrange;



		/// <summary>
		/// Used in the MeasureOverride and ArrangeOverride to force and wait for the timeslot items to update and escape gracefully cases where items force measure in arrange phase.
		/// </summary>
		private enum LayoutState
		{
			/// <summary>
			/// Default layout state.
			/// </summary>
			Default,

			/// <summary>
			/// MeasureInvalidatedInArrange layout state.
			/// </summary>
			MeasureInvalidatedInArrange,

			/// <summary>
			/// MeasuredForArrange layout state.
			/// </summary>
			MeasuredForArrange
		}

		/// <summary>
		/// Gets or sets <see cref="AppointmentsRightPaddingProperty"/>. This is a dependency property.
		/// </summary>
		/// <returns>the <see cref="AppointmentsRightPaddingProperty"/>. The default value is 0.0</returns>  
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

		/// <summary>
		/// Gets or sets the orientation of the appointment slots. If there are intersecting appointment slots,
		/// they are stacked using the specified orientation. This is a dependency property.
		/// </summary>
		/// <returns>
		/// The current <see cref="Orientation"/>.
		/// The default value is <see cref="System.Windows.Controls.Orientation.Vertical"/>.
		/// </returns>
		public Orientation Orientation
		{
			get
			{
				return (Orientation)this.GetValue(OrientationProperty);
			}
			set
			{
				this.SetValue(OrientationProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the time slot items control.
		/// </summary>
		/// <value>The time slot items control.</value>
		protected internal TimeSlotItemsControl TimeSlotItemsControl
		{
			get
			{
				return this.timeSlotItemsControl;
			}
			set
			{
				if (this.timeSlotItemsControl != value)
				{
					if (this.timeSlotItemsControl != null)
					{

						((INotifyCollectionChanged)this.timeSlotItemsControl.Items).CollectionChanged -=
							this.OnTimeSlotItemsControlLayoutUpdated;

					}

					if (value != null)
					{
						this.timeSlotItemsControl = value;



						((INotifyCollectionChanged)this.timeSlotItemsControl.Items).CollectionChanged +=
							this.OnTimeSlotItemsControlLayoutUpdated;

					}
				}
			}
		}

		/// <summary>
		/// Provides the behavior for the Measure pass of Silverlight layout. Classes can override this method to define their own Measure pass behavior.
		/// </summary>
		/// <param name="availableSize">The available size that this object can give to child objects. Infinity can be specified as a value to indicate that the object will size to whatever content is available.</param>
		/// <returns>The size that this object determines it needs during layout, based on its calculations of child object allotted sizes.</returns>
		protected override Size MeasureOverride(Size availableSize)
		{
			if (this.layoutState == LayoutState.MeasureInvalidatedInArrange)
			{
				this.layoutState = LayoutState.MeasuredForArrange;
			}
			else if (this.layoutState == LayoutState.Default)
			{
				return base.MeasureOverride(availableSize);
			}

			List<TimeSlotItem> timeSlotItems = this.GetTimeSlotItems();

			// Get cached from Arrange timeSlotsScrolling keys determing the showmorebuttons visibility and set up the ShowMoreButton
			AppointmentPanel.SetTimeSlotItemShowMoreButtonVisibility(timeSlotItems, this.timeSlotsScrolling);

			// Force premature update to the TimeSlotItems control so we can assure the timeslots are measured and arranged properly
			if (this.timeSlotItemsControl != null) this.timeSlotItemsControl.UpdateLayout();

			var elementSizes = new List<Rect>(this.Children.Count);
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			this.AlocateChildren(timeSlotItems, elementSizes);

			// insert measure... 
			for (int i = 0; i < this.Children.Count; i++)
			{
				if (isHorizontal)
				{
					this.Children[i].Measure(new Size(elementSizes[i].Width, elementSizes[i].Height));
				}
				else
				{
					this.Children[i].Measure(new Size(elementSizes[i].Width, Double.PositiveInfinity));
				}
			}

			// Deal with overlapping appointments and determin visibility for appointments and ShowMoreButton
			Dictionary<UIElement, bool> elementsHidden = new Dictionary<UIElement, bool>();
			this.timeSlotsScrolling = new Dictionary<TimeSlotItem, bool>();

			this.AlocateOverlappingChildren(timeSlotItems, elementSizes, elementsHidden, this.timeSlotsScrolling);

			for (int i = 0; i < this.Children.Count; i++)
			{
				this.Children[i].Measure(new Size(elementSizes[i].Width, elementSizes[i].Height));
			}

			Size currentDesiredSize = new Size();

			if (Children.Count > 0)
			{
				var appointmentItem = (AppointmentItem)this.Children[0];
				if (appointmentItem.Scheduler != null && (appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Week || appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Day))
				{
					foreach (var elementSize in elementSizes)
					{
						currentDesiredSize.Height = Math.Max(currentDesiredSize.Height, elementSize.Bottom);
					}
				}
			}

			return currentDesiredSize;
		}

		/// <summary>
		/// Positions child elements and determines a size for a <see cref="FrameworkElement"/> derived class.
		/// </summary>
		/// <param name="finalSize">The final area within the parent that this element should use to arrange itself and its children.</param>
		/// <returns>The actual size used.</returns>
		protected override Size ArrangeOverride(Size finalSize)
		{
			if (this.layoutState == LayoutState.Default)
			{
				// We need measure before arrange
				if (this.invalidateMeasureForArrange == null) this.invalidateMeasureForArrange = new EventHandler(this.InvalidateMeasureOnLayoutUpdated);
				this.LayoutUpdated += this.invalidateMeasureForArrange;
				this.layoutState = LayoutState.MeasureInvalidatedInArrange;
				return base.ArrangeOverride(finalSize);
			}
			else
			{
				this.layoutState = LayoutState.Default;
			}
			if (this.timeSlotItemsControl != null)
			{
				this.timeSlotItemsControl.UpdateLayout();
			}

			List<TimeSlotItem> timeSlotItems = this.GetTimeSlotItems();
			var elementSizes = new List<Rect>(this.Children.Count);
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			this.AlocateChildren(timeSlotItems, elementSizes);

			// Deal with overlapping appointments and determin visibility for appointments and ShowMoreButton
			Dictionary<UIElement, bool> elementsHidden = new Dictionary<UIElement, bool>();
			this.timeSlotsScrolling = new Dictionary<TimeSlotItem, bool>();

			this.AlocateOverlappingChildren(timeSlotItems, elementSizes, elementsHidden, this.timeSlotsScrolling);

			bool invalidShowMoreButtons = false;
			foreach (TimeSlotItem timeSlot in timeSlotItems)
			{
				if (timeSlot.ShowMoreButton != null)
				{
					if (this.timeSlotsScrolling.ContainsKey(timeSlot) && this.timeSlotsScrolling[timeSlot] == true)
					{
						if (timeSlot.ShowMoreButton.Visibility != Visibility.Visible)
						{
							invalidShowMoreButtons = true;
							break;
						}
					}
					else
					{
						if (timeSlot.ShowMoreButton.Visibility != Visibility.Collapsed)
						{
							invalidShowMoreButtons = true;
							break;
						}
					}
				}
			}
			if (invalidShowMoreButtons)
			{
				// finish this layout cycle and try again...
				if (this.updateShowMoreButtons == null) this.updateShowMoreButtons = new EventHandler(this.InvalidateMeasureForShowMoreButtonsOnLayoutUpdated);
				this.LayoutUpdated += this.updateShowMoreButtons;
			}

			IList<Rect> rects = elementSizes;
			if (rects.Count > 0)
			{
				for (int i = 0; i < this.Children.Count; i++)
				{
					UIElement child = this.Children[i];
					if (elementsHidden.ContainsKey(child) && elementsHidden[child] == true)
					{

						if (child.Visibility == Visibility.Visible) child.Visibility = Visibility.Hidden;
						child.Arrange(new Rect(rects[i].X, rects[i].Y, 0, 0));

					}
					else
					{

						if (child.Visibility == Visibility.Hidden) child.Visibility = Visibility.Visible;

						child.Arrange(rects[i]);
					}
				}
			}

			return finalSize;
		}

		private static List<List<Rect>> GetGroupedIntersectedRects(IEnumerable<Rect> intersectingGroup)
		{
			var rectGroups = new List<List<Rect>>();
			foreach (
				Rect rect in
					intersectingGroup.OrderBy(r => r.Top).ThenByDescending(r => r.Width).ThenByDescending(
						r => r.Height))
			{
				bool shouldAddNewGroup = true;
				foreach (var list in rectGroups)
				{
					if (list.Any(r => r.IntersectsWithExclusively(rect)))
					{
						continue;
					}

					list.Add(rect);
					shouldAddNewGroup = false;
					break;
				}

				if (shouldAddNewGroup)
				{
					rectGroups.Add(new List<Rect> { rect });
				}
			}

			return rectGroups;
		}

		private static IEnumerable<List<List<Rect>>> GetIntersectedRectsAsGroups(IEnumerable<Rect> rects)
		{
			var rectsToProcess = new List<Rect>(rects);
			var rectGroups = new List<List<Rect>>();

			while (rectsToProcess.Count > 0)
			{
				Rect rect = rectsToProcess[0];
				rectGroups.Add(new List<Rect> { rect });

				var intersectedToProcess = new Queue<Rect>();
				//// Start with the first rectangle and process all that intersect it
				intersectedToProcess.Enqueue(rect);

				while (intersectedToProcess.Count > 0)
				{
					Rect intersectedRect = intersectedToProcess.Dequeue();
					rectsToProcess.Remove(intersectedRect);

					List<Rect> intersectedRects =
						(from r in rectsToProcess
						 where r.IntersectsWithExclusively(intersectedRect) && !intersectedToProcess.Contains(r)
						 select r).ToList();

					//// Enqueue all intersected so we can process them on the next pass
					intersectedRects.ForEach(intersectedToProcess.Enqueue);

					rectGroups.Last().AddRange(intersectedRects);
				}
			}

			foreach (var set in rectGroups)
			{
				//// Each intersection set should be grouped by its rect's intersections
				yield return GetGroupedIntersectedRects(set);
			}
		}

		private static void SetTimeSlotItemShowMoreButtonVisibility(List<TimeSlotItem> timeSlotItemsList, Dictionary<TimeSlotItem, bool> visibilityKeys)
		{
			if (visibilityKeys != null)
			{
				foreach (TimeSlotItem timeSlot in timeSlotItemsList)
				{
					if (timeSlot.ShowMoreButton != null)
					{
						if (visibilityKeys.ContainsKey(timeSlot) && visibilityKeys[timeSlot] == true)
						{
							if (timeSlot.ShowMoreButton.Visibility != Visibility.Visible)
							{
								timeSlot.ShowMoreButton.Visibility = Visibility.Visible;
							}
						}
						else
						{
							if (timeSlot.ShowMoreButton.Visibility != Visibility.Collapsed)
							{
								timeSlot.ShowMoreButton.Visibility = Visibility.Collapsed;
							}
						}
					}
				}
			}
		}

		private void AlocateChildren(List<TimeSlotItem> timeSlotItems, List<Rect> elementSizes)
		{
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			// Compute the elementSizes
			for (int i = 0; i < this.Children.Count; i++)
			{
				var item = this.Children[i] as AppointmentItem;

				List<FrameworkElement> overlaidElements =
					(from t in timeSlotItems
					 where item.AppointmentSlot.TimeSlot.Contains(t.TimeSlot) && t.ContentHost != null
					 select t.ContentHost).ToList();

				var finalRect = new Rect();
				bool isFirst = true;

				foreach (FrameworkElement element in overlaidElements)
				{
					Point offset = this.GetOffsetFromVisual(element);
					if (isFirst)
					{
						finalRect = new Rect(offset, new Size(element.ActualWidth, element.ActualHeight));
						isFirst = false;
					}
					else
					{
						if (finalRect.X > offset.X && isHorizontal)
						{
							finalRect.X = offset.X;
						}
						if (finalRect.Y > offset.Y && !isHorizontal)
						{
							finalRect.Y = offset.Y;
						}
						finalRect.Union(new Rect(offset, new Size(element.ActualWidth, element.ActualHeight)));
					}
				}

				// SL fix for small appointments
				finalRect.Width = Math.Floor(finalRect.Width);

				// Somewhat padding...
				if (finalRect.Width > this.AppointmentsRightPadding)
				{
					finalRect.Width -= this.AppointmentsRightPadding;
				}

				elementSizes.Insert(i, finalRect);
			}
		}

		private void AlocateOverlappingChildren(List<TimeSlotItem> timeSlotItems, List<Rect> elementSizes, Dictionary<UIElement, bool> elementsHidden, Dictionary<TimeSlotItem, bool> showMoreButtonVisibilityKeys)
		{
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			IEnumerable<List<List<Rect>>> intersectedRectsAsGroups = GetIntersectedRectsAsGroups(elementSizes);
			int maxGroupCount = 0;

			foreach (var group in intersectedRectsAsGroups)
			{
				double offset = 0;

				for (int i = 0; i < group.Count; i++)
				{
					double groupMaxOffset = 0;
					List<Rect> list = group[i];
					for (int j = 0; j < list.Count; j++)
					{
						Rect rect = list[j];
						int indexToChange = elementSizes.IndexOf(list[j]);

						if (indexToChange >= 0)
						{
							var appointmentItem = (AppointmentItem)this.Children[indexToChange];

							if (isHorizontal)
							{
								rect.Width /= group.Count;
								rect.X += offset;

								groupMaxOffset = Math.Max(groupMaxOffset, rect.Width);
							}
							else
							{
								rect.Y += offset;

								groupMaxOffset = Math.Max(groupMaxOffset, appointmentItem.DesiredSize.Height);
								rect.Height = appointmentItem.DesiredSize.Height;
								{
									List<TimeSlotItem> overlaidTimeslotItems =
															(from t in timeSlotItems
															 where appointmentItem.AppointmentSlot.TimeSlot.Contains(t.TimeSlot) && t.ContentHost != null
															 select t).ToList();

									bool scrollSlots = false;
									foreach (TimeSlotItem timeSlotItem in overlaidTimeslotItems)
									{
										if (timeSlotItem.ShowMoreButton != null)
										{
											FrameworkElement appointmentsHost = timeSlotItem.GetChildByName("PART_ContentHost");
											Point bottomRight = this.GetOffsetFromVisual(appointmentsHost);
											bottomRight.X += appointmentsHost.ActualWidth;
											bottomRight.Y += appointmentsHost.ActualHeight;

											if (rect.Bottom > bottomRight.Y)
											{
												elementsHidden[appointmentItem] = true;
												scrollSlots = true;
												break;
											}
										}
									}

									if (scrollSlots)
									{
										foreach (TimeSlotItem timeSlotItem in overlaidTimeslotItems)
										{
											showMoreButtonVisibilityKeys[timeSlotItem] = true;
										}
									}
								}

								if (appointmentItem.Scheduler != null && (appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Week || appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Day))
								{
									int newMaxGroupCount = intersectedRectsAsGroups.Max(gr => gr.Count);
									if (maxGroupCount < newMaxGroupCount) maxGroupCount = newMaxGroupCount;
								}
							}
							elementSizes[indexToChange] = rect;
						}
					}
					offset += groupMaxOffset;
				}
			}
		}

		private void InvalidateMeasureForShowMoreButtonsOnLayoutUpdated(object sender, EventArgs e)
		{
			this.InvalidateMeasure();
			this.LayoutUpdated -= this.updateShowMoreButtons;
		}

		private void InvalidateMeasureOnLayoutUpdated(object sender, EventArgs e)
		{
			this.InvalidateMeasure();
			this.LayoutUpdated -= this.invalidateMeasureForArrange;
		}


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		private void MeasureAppointmentItemAndConfigureShowMoreButton(AppointmentItem appointmentItem, List<TimeSlotItem> timeSlotItems, ref Rect rect)
		{
			List<TimeSlotItem> overlaidTimeslotItems =
									(from t in timeSlotItems
									 where appointmentItem.AppointmentSlot.TimeSlot.Contains(t.TimeSlot) && t.ContentHost != null
									 select t).ToList();
			foreach (TimeSlotItem timeSlotItem in overlaidTimeslotItems)
			{
				Rect slotRect = rect;
				if (timeSlotItem.ShowMoreButton != null)
				{
					FrameworkElement appointmentsHost = timeSlotItem.GetChildByName("PART_ContentHost");
					Point bottomRight = this.GetOffsetFromVisual(appointmentsHost);
					bottomRight.X += appointmentsHost.ActualWidth;
					bottomRight.Y += appointmentsHost.ActualHeight;
					if (rect.Bottom > bottomRight.Y)
					{
						timeSlotItem.ShowMoreButton.Visibility = Visibility.Visible;
					}
				}
			}
		}

		private List<TimeSlotItem> GetTimeSlotItems()
		{
			var items = new List<TimeSlotItem>();
			if (this.timeSlotItemsControl != null)
			{
				items.AddRange(this.timeSlotItemsControl.TimeSlotItems);
			}

			return items;
		}

		private IList<Rect> MeasureElements()
		{
			List<TimeSlotItem> timeSlotItems = this.GetTimeSlotItems();
			var elementSizes = new List<Rect>(this.Children.Count);
			if (timeSlotItems.Count == 0)
			{
				return elementSizes;
			}
			bool isHorizontal = this.Orientation == Orientation.Horizontal;

			for (int i = 0; i < this.Children.Count; i++)
			{
				var item = this.Children[i] as AppointmentItem;

				List<FrameworkElement> overlaidElements =
					(from t in timeSlotItems
					 where item.AppointmentSlot.TimeSlot.Contains(t.TimeSlot) && t.ContentHost != null
					 select t.ContentHost).ToList();

				var finalRect = new Rect();
				bool isFirst = true;
				foreach (FrameworkElement element in overlaidElements)
				{
					Point offset = this.GetOffsetFromVisual(element);

					// if this is the first element get its rectangle
					if (isFirst)
					{
						finalRect = new Rect(offset, new Size(element.ActualWidth, element.ActualHeight));

						isFirst = false;
					}
					else
					{
						// check if the rectangle will expand
						if (finalRect.X > offset.X && isHorizontal)
						{
							finalRect.X = offset.X;
						}
						if (finalRect.Y > offset.Y && !isHorizontal)
						{
							finalRect.Y = offset.Y;
						}

						finalRect.Union(new Rect(offset, new Size(element.ActualWidth, element.ActualHeight)));
					}
				}

				if (finalRect.Width > this.AppointmentsRightPadding)
				{
					finalRect.Width -= this.AppointmentsRightPadding;
				}

				elementSizes.Insert(i, finalRect);
			}

			IEnumerable<List<List<Rect>>> intersectedRectsAsGroups = GetIntersectedRectsAsGroups(elementSizes);
			int maxGroupCount = 0;

			foreach (var group in intersectedRectsAsGroups)
			{
				double offset = 0;

				for (int i = 0; i < group.Count; i++)
				{
					double groupMaxOffset = 0;
					List<Rect> list = group[i];
					for (int j = 0; j < list.Count; j++)
					{
						Rect rect = list[j];
						int indexToChange = elementSizes.IndexOf(list[j]);

						if (indexToChange >= 0)
						{
							var appointmentItem = (AppointmentItem)this.Children[indexToChange];

							if (isHorizontal)
							{
								rect.Width /= group.Count;
								rect.X += offset;

								// appointmentItem.Measure(new Size(rect.Width, rect.Height));
								groupMaxOffset = Math.Max(groupMaxOffset, rect.Width);
							}
							else
							{
								rect.Y += offset;

								groupMaxOffset = Math.Max(groupMaxOffset, appointmentItem.DesiredSize.Height);
								rect.Height = appointmentItem.DesiredSize.Height;

								this.MeasureAppointmentItemAndConfigureShowMoreButton(appointmentItem, timeSlotItems, ref rect);

								////we want to stack items if the orientation is vertivcal

								// resize the AppointmentPanel in order not to shrink the AppointmentItems in Day/Week view
								if (appointmentItem.Scheduler != null && (appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Week || appointmentItem.Scheduler.ViewMode == SchedulerViewMode.Day))
								{
									int newMaxGroupCount = intersectedRectsAsGroups.Max(gr => gr.Count);
									if (maxGroupCount < newMaxGroupCount) maxGroupCount = newMaxGroupCount;
									this.Height = (((maxGroupCount * rect.Height) + 2) < this.MinHeight) ? this.MinHeight : ((maxGroupCount * rect.Height) + 2);
								}
							}

							elementSizes[indexToChange] = rect;
						}
					}

					offset += groupMaxOffset;
				}
			}

			return elementSizes;
		}

		private void OnTimeSlotItemsControlLayoutUpdated(object sender, EventArgs e)
		{
			this.InvalidateMeasure();
		}
	}
}