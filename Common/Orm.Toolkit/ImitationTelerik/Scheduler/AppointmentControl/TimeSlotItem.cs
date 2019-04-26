using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.DragDrop;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// <see cref="ListBoxItem"/> presenting a <see cref="TimeSlot"/>.
	/// </summary>
	[TemplatePart(Name = ContentHostName, Type = typeof(FrameworkElement))]
	[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "IsDropPossible", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "IsDropPossibleSelected", GroupName = "SelectionStates")]
	[TemplateVisualState(Name = "HeaderOver", GroupName = "HeaderCommonStates")]
	[TemplateVisualState(Name = "HeaderNormal", GroupName = "HeaderCommonStates")]
	[TemplateVisualState(Name = "Today", GroupName = "TodayDayStates")]
	[TemplateVisualState(Name = "FirstDay", GroupName = "DayStates")]
	[TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[TemplateVisualState(Name = "SelectedMonth", GroupName = "MonthStates")]
	[TemplateVisualState(Name = "UnSelectedMonth", GroupName = "MonthStates")]
	[TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]

	[TemplateVisualState(Name = "NormalDepth", GroupName = "DepthStates")]
	[TemplateVisualState(Name = "MouseOverDepth", GroupName = "DepthStates")]
	[TemplateVisualState(Name = "SelectedDepth", GroupName = "DepthStates")]
	[TemplateVisualState(Name = "TodayDepth", GroupName = "DepthStates")]

	public class TimeSlotItem : ListBoxItem
	{
		/// <summary>
		/// Identifies the <see cref="IsDropPossible"/> property.
		/// </summary>
		/// <returns>The identifier for the <see cref="IsDropPossible"/> property</returns>
		public static readonly DependencyProperty IsDropPossibleProperty =
			DependencyProperty.Register(
				"IsDropPossible",
				typeof(bool),
				typeof(TimeSlotItem),
				new FrameworkPropertyMetadata(false, IsDropPossibleChanged));

		private const string ContentHostName = "PART_ContentHost";
		private const string ShowMoreButtonName = "PART_ShowMoreButton";

		private Button showMoreButton;
		private TimeSlot timeSlot;



		/// <summary>
		/// Gets or sets the content host.
		/// </summary>
		/// <value>The content host.</value>
		public FrameworkElement ContentHost { get; private set; }

		/// <summary>
		/// This property shows is this timeslot a possible destination for the dragged appointment.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is drop possible; otherwise, <c>false</c>.
		/// </value>
		public bool IsDropPossible
		{
			get
			{
				return (bool)this.GetValue(IsDropPossibleProperty);
			}
			set
			{
				this.SetValue(IsDropPossibleProperty, value);
			}
		}

		/// <summary>
		/// Gets the show more button.
		/// </summary>
		/// <value>The show more button.</value>
		public Button ShowMoreButton
		{
			get
			{
				if (this.showMoreButton == null)
				{
					this.showMoreButton = this.GetTemplateChild(ShowMoreButtonName) as Button;
				}
				return this.showMoreButton;
			}
		}

		/// <summary>
		/// Gets or sets the time slot.
		/// </summary>
		/// <returns>The time slot. The default value is null</returns>  
		public TimeSlot TimeSlot
		{
			get
			{
				return this.timeSlot;
			}
			set
			{
				this.timeSlot = value;

				this.DataContext = value;
			}
		}




		private TimeSlotItemsControl ParentControl
		{
			get
			{
				return ItemsControl.ItemsControlFromItemContainer(this) as TimeSlotItemsControl;
			}
		}

		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or 
		/// internal processes call <see cref="FrameworkElement.ApplyTemplate"/>.
		/// </summary>

		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			this.SetValue(RadDragAndDropManager.AllowDropProperty, true);
			this.ContentHost = this.GetTemplateChild(ContentHostName) as FrameworkElement;

			this.ChangeVisualState(false);
		}



		/// <summary>
		/// Updates the visual state of the control.
		/// </summary>
		/// <param name="useTransitions">Indicates whether transitions should be used.</param>
		protected internal virtual void ChangeVisualState(bool useTransitions)
		{

		}


		/// <summary>
		/// Called when the user presses the right mouse button over the <see cref="T:System.Windows.Controls.ListBoxItem"/>.
		/// </summary>
		/// <param name="e">The event data.</param>
		protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.ParentControl != null && this.ParentControl.Scheduler != null)
			{
				this.ParentControl.Scheduler.IsSelectedDateChanged = true;
			}
			base.OnMouseLeftButtonDown(e);
			if (this.IsSelected && this.ParentControl != null)
			{
				this.ParentControl.SetSelectedResource();
			}
			this.ParentControl.Scheduler.IsSelectedDateChanged = false;
		}

		/// <summary>
		/// Raises the <see cref="FrameworkElement.Initialized"/> event and sets <see cref="FrameworkElement.DefaultStyleKey" /> from the active theme.
		/// </summary>
		/// <param name="e">The <see cref="RoutedEventArgs"/> that contains the event data.</param>
		protected override void OnInitialized(EventArgs e)
		{
			base.OnInitialized(e);

			this.DefaultStyleKey = this.GetDefaultStyleKey();
		}


		private static void IsDropPossibleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			TimeSlotItem item = d as TimeSlotItem;
			item.ChangeVisualState(true);
		}

	}
}
