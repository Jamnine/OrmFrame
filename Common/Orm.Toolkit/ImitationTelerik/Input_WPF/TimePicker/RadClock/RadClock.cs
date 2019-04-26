using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Orm.Toolkit.Telerik.Windows.Controls;
using Orm.Toolkit.Telerik.Windows.Controls.Primitives;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	///  Represents a selection control that allows you to slect time from grid.
	/// </summary>
	[DefaultProperty("SelectedTime")]
	[DefaultEvent("SelectedTimeChanged")]

    [Themable]
    public class RadClock : HeaderedItemsControl, IThemable
    {

		/// <summary>
		///     Identifies the IsReadOnly property.
		/// </summary>
		public static readonly DependencyProperty IsReadOnlyProperty = DependencyProperty.Register("IsReadOnly",
																				typeof(bool),
																				typeof(RadClock),
																				new PropertyMetadata(false, null, null));

		/// <summary>
		/// Identifies the TimeIntervalProperty property.
		/// </summary>
		public static readonly DependencyProperty TimeIntervalProperty = DependencyPropertyExtensions.Register("TimeInterval",
																					typeof(TimeSpan),
																					typeof(RadClock),
																					new PropertyMetadata(RadClock.TimeIntervalDefaultValue, new PropertyChangedCallback(RadClock.OnTimeIntervalChanged), null));

		/// <summary>
		/// Identifies the EndTimeProperty property.
		/// </summary>
		public static readonly DependencyProperty EndTimeProperty = DependencyProperty.Register("EndTime",
																		typeof(TimeSpan),
																		typeof(RadClock),
																		new PropertyMetadata(RadClock.EndTimeDefaultValue, new PropertyChangedCallback(RadClock.OnEndTimeChanged), null));

		/// <summary>
		/// Identifies the StartTimeProperty property.
		/// </summary>
		public static readonly DependencyProperty StartTimeProperty = DependencyProperty.Register("StartTime",
																			typeof(TimeSpan),
																			typeof(RadClock),
																			new PropertyMetadata(RadClock.StartTimeDefaultValue, new PropertyChangedCallback(RadClock.OnStartTimeChanged), null));

		/// <summary>
		/// Identifies the SelectedTimeProperty property.
		/// </summary>
		public static readonly DependencyProperty SelectedTimeProperty = DependencyPropertyExtensions.Register("SelectedTime",
																				typeof(TimeSpan?),
																				typeof(RadClock),
																				new PropertyMetadata(null, new PropertyChangedCallback(RadClock.OnSelectedTimePropertyChanged), null));

		/// <summary>
		/// Identifies the CultureProperty property.
		/// </summary>
		public static readonly DependencyProperty CultureProperty = DependencyProperty.Register("Culture",
																		typeof(CultureInfo),
																		typeof(RadClock),
																		null);

		internal static readonly TimeSpan EndTimeDefaultValue = new TimeSpan(23, 59, 0);
		internal static readonly TimeSpan StartTimeDefaultValue = new TimeSpan(0, 0, 0);
		internal static readonly TimeSpan TimeIntervalDefaultValue = new TimeSpan(1, 0, 0);

		private RadClockItem selectedClockItem = null;


        static RadClock()
        {
            //DefaultStyleKeyProperty.OverrideMetadata(typeof(RadClock),
            //        new FrameworkPropertyMetadata(new ThemeResourceKey(typeof(Office_BlackTheme), typeof(RadClock))));

            DefaultStyleKeyProperty.OverrideMetadata(typeof(RadClock),
                  new FrameworkPropertyMetadata(typeof(RadClock)));
        }


		/// <summary>
		/// Initializes a new instance of the <see cref="RadClock"/> class.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1805:DoNotInitializeUnnecessarily")]
		public RadClock()
		{
            //TelerikLicense.Verify(this);//禁止验证许可

		}

		/// <summary>
		/// Occurs when [selected time changed].
		/// </summary>
		public event EventHandler SelectedTimeChanged;

		/// <summary>
		/// Gets or sets a value indicating whether this instance is read only.
		/// </summary>
		/// <value>
		/// 	<c>True</c> if this instance is read only; otherwise, <c>false</c>.
		/// </value>
		public bool IsReadOnly
		{
			get { return (bool)GetValue(IsReadOnlyProperty); }
			set { SetValue(IsReadOnlyProperty, value); }
		}

		/// <summary>
		/// Gets or sets the time interval.
		/// </summary>
		/// <value>The time interval.</value>
		public TimeSpan TimeInterval
		{
			get
			{
				return (TimeSpan)this.GetValue(RadClock.TimeIntervalProperty);
			}
			set
			{
				SetValue(RadClock.TimeIntervalProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the start time.
		/// </summary>
		/// <value>The start time.</value>
		public TimeSpan StartTime
		{
			get
			{
				return (TimeSpan)this.GetValue(RadClock.StartTimeProperty);
			}
			set
			{
				SetValue(RadClock.StartTimeProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the end time.
		/// </summary>
		/// <value>The end time.</value>
		public TimeSpan EndTime
		{
			get
			{
				return (TimeSpan)this.GetValue(RadClock.EndTimeProperty);
			}
			set
			{
				SetValue(RadClock.EndTimeProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the culture.
		/// </summary>
		/// <value>The culture.</value>
		public CultureInfo Culture
		{
			get
			{
				return (CultureInfo)this.GetValue(RadClock.CultureProperty);
			}
			set
			{
				SetValue(RadClock.CultureProperty, value);
			}
		}

		/// <summary>
		/// Gets or sets the selected time.
		/// </summary>
		/// <value>The selected time.</value>
		[TypeConverter(typeof(TimeSpanConverter))]
		public TimeSpan? SelectedTime
		{
			get
			{
				return (TimeSpan?)this.GetValue(RadClock.SelectedTimeProperty);
			}
			set
			{
				SetValue(RadClock.SelectedTimeProperty, value);
			}
		}

		internal RadClockItem SelectedClockItem
		{
			get
			{
				return this.selectedClockItem;
			}
		}


        /// <summary>
        /// Resets the theme.
        /// </summary>
        public void ResetTheme()
        {
            this.SetDefaultStyleKey();
        }


		/// <summary>
		/// When overridden in a derived class, is invoked whenever application code or internal processes (such as a rebuilding layout pass) call <see cref="M:System.Windows.Controls.Control.ApplyTemplate"/>.
		/// </summary>
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();

			if (this.ItemsSource == null)
			{
				this.ItemsSource = this.GenerateItemsSource();
			}
		}

		internal void NotifyClockItemSelected(RadClockItem clockItem)
		{
			if (this.SelectedClockItem != clockItem)
			{
				if (this.SelectedClockItem != null)
				{
					this.SelectedClockItem.IsSelected = false;

				}
			}
			if (clockItem != null)
			{
				this.selectedClockItem = clockItem;
				clockItem.IsSelected = true;


				this.SelectedTime = TimeSpan.Parse(clockItem.DataContext.ToString());
			}
		}

		internal void UnSelectAllItems()
		{
			foreach (var item in this.Items)
			{
				var clockItem = this.ItemContainerGenerator.ContainerFromItem(item) as RadClockItem;
				if (clockItem != null)
				{
					clockItem.IsSelected = false;

				}
			}
		}

		internal void SelectItem(RadClockItem item)
		{
			if (item != null)
			{

				this.NotifyClockItemSelected(item);
				item.Focus();
			}
		}

		internal void ProcessItem(int itemIndex)
		{
			RadClockItem selectedItem = this.ItemContainerGenerator.ContainerFromIndex(itemIndex) as RadClockItem;
			this.SelectItem(selectedItem);
		}

		internal void ProcessKey(int itemIndex)
		{
			int itemsCount = this.Items.Count;
			if (itemIndex < 0)
			{
				itemIndex = itemsCount - 1;
			}
			else if (itemIndex > itemsCount - 1)
			{
				itemIndex = 0;
			}
			this.ProcessItem(itemIndex);
		}

		internal CultureInfo GetCultureToUse()
		{
			return this.Culture ?? CultureInfo.CurrentCulture;
		}

		/// <summary>
		/// Called when [selected time changed].
		/// </summary>
		protected virtual void OnSelectedTimeChanged()
		{
			if (!this.IsReadOnly)
			{
				////this.Focus();
				if (this.SelectedTimeChanged != null)
				{
					this.SelectedTimeChanged(this, EventArgs.Empty);
				}

			}
		}

		/// <summary>
		/// Determines if the specified item is (or is eligible to be) its own container.
		/// </summary>
		/// <param name="item">The item to check.</param>
		/// <returns>
		/// True if the item is (or is eligible to be) its own container; otherwise, false.
		/// </returns>
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is RadClockItem;
		}

		/// <summary>
		/// Creates or identifies the element that is used to display the given item.
		/// </summary>
		/// <returns></returns>
		protected override DependencyObject GetContainerForItemOverride()
		{
			return new RadClockItem();
		}

		/// <summary>
		/// Prepares the specified element to display the specified item.
		/// </summary>
		/// <param name="element">Element used to display the specified item.</param>
		/// <param name="item">Specified item.</param>
		protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			RadClockItem clockItem = element as RadClockItem;
			if (clockItem == null)
			{
				return;
			}

			clockItem.ClockControl = this;
			if (clockItem != item)
			{
				TimeSpan currentItem = TimeSpan.Parse(item.ToString());
				clockItem.Content = string.Format(string.Format(this.GetCultureToUse(), "{0:t}", DateTime.MinValue.Add(currentItem)));
			}
			StyleManager.SetThemeFromParent(clockItem, this);
		}

		/// <summary>
		/// When overridden in a derived class, undoes the effects of the <see cref="M:System.Windows.Controls.ItemsControl.PrepareContainerForItemOverride(System.Windows.DependencyObject,System.Object)"/> method.
		/// </summary>
		/// <param name="element">The container element.</param>
		/// <param name="item">The Item.</param>
		protected override void ClearContainerForItemOverride(DependencyObject element, object item)
		{
			RadClockItem clockItem = element as RadClockItem;
			if (clockItem != null)
			{
				clockItem.ClockControl = null;
			}
			base.ClearContainerForItemOverride(element, item);
		}

		/// <summary>
		/// Generates the items source.
		/// </summary>
		/// <returns></returns>
		protected virtual IEnumerable GenerateItemsSource()
		{
			TimeSpan time = this.StartTime;
			TimeSpan endTime = this.EndTime;
			if (endTime <= time)
			{
				endTime = RadClock.EndTimeDefaultValue;
				time = RadClock.StartTimeDefaultValue;
			}
			TimeSpan timeInterval = this.TimeInterval;

			if (time != null && endTime != null && timeInterval != null && timeInterval.Ticks > 0)
			{
				while (time <= endTime)
				{
					yield return time;
					time = time.Add(timeInterval);
				}
				yield break;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationPeer OnCreateAutomationPeer()
		{

            return null;

		}


        /// <summary>
        /// Raises the <see cref="E:System.Windows.FrameworkElement.Initialized"/> event. This method is invoked whenever <see cref="P:System.Windows.FrameworkElement.IsInitialized"/> is set to true internally.
        /// </summary>
        /// <param name="e">The <see cref="T:System.Windows.RoutedEventArgs"/> that contains the event data.</param>
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            this.SetDefaultStyleKey();
        }


		private static void OnSelectedTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadClock radClock = d as RadClock;
			if (!radClock.IsReadOnly)
			{
				if (radClock != null)
				{
					radClock.OnSelectedTimeChanged();
				}
			}
		}

		private static void OnTimeIntervalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadClock clock = d as RadClock;
			if (clock == null)
			{
				return;
			}

			// NOTE: This cannot be true! TimeInterval is of type TimeSpan which is not nullable!
			if (clock.TimeInterval != null)
			{
				clock.TimeInterval = clock.ValidateTimeSpan(clock.TimeInterval);
			}
			if (clock.ItemsSource != null)
			{
				clock.ItemsSource = clock.GenerateItemsSource();
			}
		}

		private static void OnEndTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadClock clock = d as RadClock;
			if (clock == null)
			{
				return;
			}

			if (clock.ItemsSource != null)
			{
				clock.ItemsSource = clock.GenerateItemsSource();
			}
		}

		private static void OnStartTimeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadClock clock = d as RadClock;
			if (clock == null)
			{
				return;
			}

			if (clock.ItemsSource != null)
			{
				clock.ItemsSource = clock.GenerateItemsSource();
			}
		}

		private void RadClock_KeyDown(object sender, KeyEventArgs e)
		{
			RadClock clock = sender as RadClock;
			TimeSpan? selectedItem;
			if (this.SelectedTime != null)
			{
				selectedItem = clock.SelectedTime;
			}
			else
			{
				selectedItem = this.SelectedTime;
			}
			int index = this.Items.IndexOf(selectedItem);
			switch (e.Key)
			{
				case System.Windows.Input.Key.Right:
					this.ProcessKey(index + 1);
					e.Handled = true;
					break;
				case System.Windows.Input.Key.Left:
					this.ProcessKey(index - 1);
					e.Handled = true;
					break;
				case System.Windows.Input.Key.Home:
					this.ProcessKey(0);
					e.Handled = true;
					break;
				case System.Windows.Input.Key.End:
					this.ProcessKey(this.Items.Count - 1);
					e.Handled = true;
					break;
				default:
					break;
			}
		}

		private TimeSpan ValidateTimeSpan(TimeSpan time)
		{
			if ((time > new TimeSpan(0, 0, int.MinValue)) && (time < new TimeSpan(0, 0, 60)))
			{
				time = RadClock.TimeIntervalDefaultValue;
			}
			else
			{
				time = this.TimeInterval;
			}

			return time;
		}

        private void SetDefaultStyleKey()
        {
            Theme theme = StyleManager.GetTheme(this);
            //this.DefaultStyleKey = ThemeResourceKey.GetDefaultStyleKey(theme, typeof(RadClock));

            this.DefaultStyleKey = typeof(RadClock);
        }

	}
}
