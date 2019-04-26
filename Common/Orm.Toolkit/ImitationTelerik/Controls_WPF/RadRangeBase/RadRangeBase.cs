using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Represents an element that has a value within a specific range.
	/// </summary>
	public abstract class RadRangeBase : Control
	{
		/// <summary>
		/// Identifies the LargeChange dependency property.
		/// </summary>
		public static readonly DependencyProperty LargeChangeProperty = DependencyProperty.Register("LargeChange", typeof(double), typeof(RadRangeBase), new PropertyMetadata(10d, new PropertyChangedCallback(OnLargeChangePropertyChanged)));

		/// <summary>
		/// Identifies the LargeChange dependency property.
		/// </summary>
		public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(double), typeof(RadRangeBase), new PropertyMetadata(double.MaxValue, new PropertyChangedCallback(OnMaximumPropertyChanged)));

		/// <summary>
		/// Identifies the LargeChange dependency property.
		/// </summary>
		public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register("Minimum", typeof(double), typeof(RadRangeBase), new PropertyMetadata(double.MinValue, new PropertyChangedCallback(OnMinimumPropertyChanged)));

		/// <summary>
		/// Identifies the LargeChange dependency property.
		/// </summary>
		public static readonly DependencyProperty SmallChangeProperty = DependencyProperty.Register("SmallChange", typeof(double), typeof(RadRangeBase), new PropertyMetadata(1d, new PropertyChangedCallback(OnSmallChangePropertyChanged)));

		/// <summary>
		/// Identifies the LargeChange dependency property.
		/// </summary>
		public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(double?), typeof(RadRangeBase), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnValuePropertyChanged)));

		/// <summary>
		/// Identifies the AutoReverse dependency property.
		/// </summary>
		public static readonly DependencyProperty AutoReverseProperty = DependencyProperty.Register("AutoReverse", typeof(bool), typeof(RadRangeBase), null);

		private int levelsFromRootCall;
		private double initialMax;
		private double? initialVal;
		private double requestedMax = double.MaxValue;
		private double? requestedVal;

		/// <summary>
		/// Initializes a new instance of the <see cref="RadRangeBase"/> class.
		/// </summary>
		protected RadRangeBase()
		{
		}

		/// <summary>
		///  Occurs when the range value changes.
		/// </summary>
		public event EventHandler<RadRangeBaseValueChangedEventArgs> ValueChanged;

		/// <summary>
		/// Gets or sets the value that specifies whether the control will change its value to its minimum when it reaches its maximum, or vice versa.
		/// </summary>
		public bool AutoReverse
		{
			get { return (bool)GetValue(AutoReverseProperty); }
			set { SetValue(AutoReverseProperty, value); }
		}

		/// <summary>
		/// Gets or sets a value to be added to or subtracted from the Value of a NullableRangeBase control.
		/// </summary>
		public double LargeChange
		{
			get { return (double)GetValue(LargeChangeProperty); }
			set { SetValue(LargeChangeProperty, value); }
		}

		/// <summary>
		///  Gets or sets the highest possible NullableRangeBase.Value of the range element.
		/// </summary>

		public double Maximum
		{
			get { return (double)GetValue(MaximumProperty); }
			set { SetValue(MaximumProperty, value); }
		}

		/// <summary>
		///  Gets or sets the lowest possible NullableRangeBase.Value of the range element.
		/// </summary>

		public double Minimum
		{
			get { return (double)GetValue(MinimumProperty); }
			set { SetValue(MinimumProperty, value); }
		}

		/// <summary>
		/// Gets or sets the value to be added to or subtracted from the NullableRangeBase.Value.
		/// </summary>
		public double SmallChange
		{
			get { return (double)GetValue(SmallChangeProperty); }
			set { SetValue(SmallChangeProperty, value); }
		}

		/// <summary>
		/// Gets or sets the current setting of the range control, which may be coerced.
		/// </summary>

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
		public double? Value
		{
			get { return (double?)GetValue(ValueProperty); }
			set { SetValue(ValueProperty, value); }
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, "{0} Minimum:{1} Maximum:{2} Value:{3}", new object[] { base.ToString(), this.Minimum, this.Maximum, this.Value });
		}

		/// <summary>
		/// Adds the provided delta to the current value.
		/// </summary>
		/// <param name="delta">The amount to add to Value</param>
		protected internal virtual void ChangeValue(double delta)
		{
			if (!this.Value.HasValue)
			{
				this.Value = 0;
			}
			else
			{
				if (this.AutoReverse && this.Value == this.Maximum && delta > 0)
				{
					this.Value = this.Minimum;
				}
				else if (this.AutoReverse && this.Value == this.Minimum && delta < 0)
				{
					this.Value = this.Maximum;
				}
				else
				{
					this.Value += delta;
				}
			}
		}

		/// <summary>
		/// Called when the NullableRangeBase.Maximum property changes.
		/// </summary>
		/// <param name="oldMaximum">Old value of the NullableRangeBase.Maximum property.</param>
		/// <param name="newMaximum">New value of the NullableRangeBase.Maximum property.</param>
		protected virtual void OnMaximumChanged(double oldMaximum, double newMaximum)
		{
		}

		/// <summary>
		/// Called when the NullableRangeBase.Minimum property changes.
		/// </summary>
		/// <param name="oldMinimum">Old value of the NullableRangeBase.Minimum property.</param>
		/// <param name="newMinimum">New value of the NullableRangeBase.Minimum property.</param>
		protected virtual void OnMinimumChanged(double oldMinimum, double newMinimum)
		{
		}

		/// <summary>
		/// Raises the NullableRangeBase.ValueChanged routed event.
		/// </summary>
		/// <param name="oldValue">Old value of the NullableRangeBase.Value property.</param>
		/// <param name="newValue">New value of the NullableRangeBase.Value property.</param>
		protected virtual void OnValueChanged(double? oldValue, double? newValue)
		{
			this.OnValueChanged(new RadRangeBaseValueChangedEventArgs(oldValue, newValue));
		}

		/// <summary>
		/// Raises the NullableRangeBase.ValueChanged routed event.
		/// </summary>
		protected virtual void OnValueChanged(RadRangeBaseValueChangedEventArgs e)
		{
			var valueChanged = this.ValueChanged;
			if (valueChanged != null)
			{
				valueChanged(this, e);
			}
		}

		private static bool DoubleUtilAreClose(double? one, double? two)
		{
			if (one.HasValue && two.HasValue)
			{
				return DoubleUtil.AreClose(one.Value, two.Value);
			}
			return false;
		}

		private static bool IsValidChange(object value)
		{
			var val = (double)value;
			return IsValidDoubleValue(val) && val >= 0d;
		}

		private static bool IsValidDoubleValue(double value)
		{
			return !double.IsNaN(value) && !double.IsInfinity(value);
		}

		private static bool IsValidDoubleValue(double? value)
		{
			if (value.HasValue)
			{
				return !double.IsNaN(value.Value) && !double.IsInfinity(value.Value);
			}
			return true;
		}

		private static void OnLargeChangePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (!IsValidChange(e.NewValue))
			{
				throw new ArgumentException("Invalid LargeChange");
			}
		}

		private static void OnMaximumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadRangeBase nullableRangeBase = d as RadRangeBase;
			if (!IsValidDoubleValue((double)e.NewValue))
			{
				throw new ArgumentException("Invalid Maximum");
			}
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				nullableRangeBase.requestedMax = (double)e.NewValue;
				nullableRangeBase.initialMax = (double)e.OldValue;
				nullableRangeBase.initialVal = nullableRangeBase.Value;
			}
			nullableRangeBase.levelsFromRootCall++;
			nullableRangeBase.CoerceMaximum();
			nullableRangeBase.CoerceValue();
			nullableRangeBase.levelsFromRootCall--;
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				////RangeBaseAutomationPeer automationPeer = base2.GetAutomationPeer() as RangeBaseAutomationPeer;
				double maximum = nullableRangeBase.Maximum;
				if (!DoubleUtilAreClose(nullableRangeBase.initialMax, maximum))
				{
					////if (automationPeer != null)
					////{
					////    automationPeer.RaiseMaximumPropertyChangedEvent(base2._initialMax, maximum);
					////}
					nullableRangeBase.OnMaximumChanged(nullableRangeBase.initialMax, maximum);
				}
				double? num2 = nullableRangeBase.Value;
				if (!DoubleUtilAreClose(nullableRangeBase.initialVal, num2))
				{
					////if (automationPeer != null)
					////{
					////    automationPeer.RaiseValuePropertyChangedEvent(base2._initialVal, num2);
					////}
					nullableRangeBase.OnValueChanged(nullableRangeBase.initialVal, num2);
				}
			}
		}

		private static void OnMinimumPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadRangeBase nullableRangeBase = d as RadRangeBase;
			if (!IsValidDoubleValue((double)e.NewValue))
			{
				throw new ArgumentException("Invalid Minimum");
			}
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				nullableRangeBase.initialMax = nullableRangeBase.Maximum;
				nullableRangeBase.initialVal = nullableRangeBase.Value;
			}
			nullableRangeBase.levelsFromRootCall++;
			nullableRangeBase.CoerceMaximum();
			nullableRangeBase.CoerceValue();
			nullableRangeBase.levelsFromRootCall--;
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				////RangeBaseAutomationPeer automationPeer = base2.GetAutomationPeer() as RangeBaseAutomationPeer;
				////if (automationPeer != null)
				////{
				////    automationPeer.RaiseMinimumPropertyChangedEvent((double)e.OldValue, (double)e.NewValue);
				////}
				nullableRangeBase.OnMinimumChanged((double)e.OldValue, (double)e.NewValue);
				double maximum = nullableRangeBase.Maximum;
				if (!DoubleUtilAreClose(nullableRangeBase.initialMax, maximum))
				{
					////if (automationPeer != null)
					////{
					////    automationPeer.RaiseMaximumPropertyChangedEvent(base2._initialMax, maximum);
					////}
					nullableRangeBase.OnMaximumChanged(nullableRangeBase.initialMax, maximum);
				}
				double? value = nullableRangeBase.Value;
				if (!DoubleUtilAreClose(nullableRangeBase.initialVal, value))
				{
					////if (automationPeer != null)
					////{
					////    automationPeer.RaiseValuePropertyChangedEvent(base2._initialVal, num2);
					////}
					nullableRangeBase.OnValueChanged(nullableRangeBase.initialVal, value);
				}
			}
		}

		private static void OnSmallChangePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			if (!IsValidChange(e.NewValue))
			{
				throw new ArgumentException("Invalid SmallChange");
			}
		}

		private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			RadRangeBase nullableRangeBase = d as RadRangeBase;
			if (!IsValidDoubleValue((double?)e.NewValue))
			{
				throw new ArgumentException("Invalid Value");
			}
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				nullableRangeBase.requestedVal = (double?)e.NewValue;
				nullableRangeBase.initialVal = (double?)e.OldValue;
			}
			nullableRangeBase.levelsFromRootCall++;
			nullableRangeBase.CoerceValue();
			nullableRangeBase.levelsFromRootCall--;
			if (nullableRangeBase.levelsFromRootCall == 0)
			{
				double? value = nullableRangeBase.Value;
				if (!DoubleUtilAreClose(nullableRangeBase.initialVal, value))
				{
					////RangeBaseAutomationPeer automationPeer = base2.GetAutomationPeer() as RangeBaseAutomationPeer;
					////if (automationPeer != null)
					////{
					////    automationPeer.RaiseValuePropertyChangedEvent(base2._initialVal, num);
					////}
					nullableRangeBase.OnValueChanged(nullableRangeBase.initialVal, value);
				}
			}
		}

		private void CoerceMaximum()
		{
			double minimum = this.Minimum;
			double maximum = this.Maximum;
			if (!DoubleUtilAreClose(this.requestedMax, maximum) && (this.requestedMax >= minimum))
			{
				this.SetValue(MaximumProperty, this.requestedMax);
			}
			else if (maximum < minimum)
			{
				this.SetValue(MaximumProperty, minimum);
			}
		}

		private void CoerceValue()
		{
			double minimum = this.Minimum;
			double maximum = this.Maximum;
			double? value = this.Value;
			if ((!DoubleUtilAreClose(this.requestedVal, value) && (this.requestedVal >= minimum)) && (this.requestedVal <= maximum))
			{
				this.SetValue(ValueProperty, this.requestedVal);
			}
			else
			{
				if (value < minimum)
				{
					this.SetValue(ValueProperty, minimum);
				}
				if (value > maximum)
				{
					this.SetValue(ValueProperty, maximum);
				}
			}
		}
	}
}