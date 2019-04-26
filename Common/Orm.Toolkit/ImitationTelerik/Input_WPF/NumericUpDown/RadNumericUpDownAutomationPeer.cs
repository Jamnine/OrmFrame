////#define INHERIT_IRangeValueProvider
////#define INHERIT_IRangeValueProvider_IValueProvider
#define INHERIT_RangeBaseAutomationPeer
#define TRACE_RadNumericUpDownAutomationPeer

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
#if( INHERIT_IRangeValueProvider || INHERIT_IRangeValueProvider_IValueProvider)
	/// <summary>
	/// 
	/// </summary>
	public partial class RadNumericUpDownAutomationPeer
		: FrameworkElementAutomationPeer
		, IRangeValueProvider
#if INHERIT_IRangeValueProvider_IValueProvider
		, IValueProvider // do more debugging prior to decide removing of this iterface!
#endif
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="owner"></param>
		public RadNumericUpDownAutomationPeer(RadNumericUpDown owner)
			: base(owner)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public double LargeChange
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.LargeChange.get:  owner = " +
					this.OwnerAsRadNumericUpDown());
#endif
				return (double)this.OwnerAsRadNumericUpDown().LargeChange;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double Maximum
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.Maximum.get:  owner = " +
					this.OwnerAsRadNumericUpDown());
#endif
				return (double)this.OwnerAsRadNumericUpDown().Maximum;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double Minimum
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.Minimum.get:  owner = " +
					this.OwnerAsRadNumericUpDown());
#endif
				return (double)this.OwnerAsRadNumericUpDown().Minimum;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double SmallChange
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.SmallChange.get:  owner = " +
					this.OwnerAsRadNumericUpDown());
#endif
				return (double)this.OwnerAsRadNumericUpDown().SmallChange;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseMaximumPropertyChangedEvent(double oldValue, double newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseMaximumPropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.MaximumProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseMinimumPropertyChangedEvent(double oldValue, double newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseMinimumPropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.MinimumProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseValuePropertyChangedEvent(double oldValue, double newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseValuePropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.ValueProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseSmallChangePropertyChangedEvent(double oldValue, double newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseSmallChangePropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.SmallChangeProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseLargeChangePropertyChangedEvent(double oldValue, double newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseLargeChangePropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.LargeChangeProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseIsReadOnlyPropertyChangedEvent(bool oldValue, bool newValue)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.RaiseIsReadOnlyPropertyChangedEvent:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			base.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.IsReadOnlyProperty, oldValue, newValue);
		}

		void IRangeValueProvider.SetValue(double value)
		{
			this.GuarantyEnabled();
			RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();

			if (value < owner.Minimum || value > owner.Maximum)
			{
				throw new ArgumentOutOfRangeException("value");
			}

			owner.Value = value;
		}

		/// <summary>
		/// 
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
				bool isEditable = owner.IsEditable;
				bool isEnabled = base.IsEnabled();
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.IValueProvider.IsReadOnly.get >> isEditable = " +
					isEditable + " && isEnabled = " + isEnabled + "; owner = " + owner);
				return !(isEditable && isEnabled);
#else
				return !(this.OwnerAsRadNumericUpDown().IsEditable && base.IsEnabled());
#endif
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="patternInterface"></param>
		/// <returns></returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			if (patternInterface == PatternInterface.RangeValue
#if INHERIT_IRangeValueProvider_IValueProvider
				|| patternInterface == PatternInterface.Value
#endif
				)
			{
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.GetPattern: " +
					"patternInterface ===" + patternInterface +
					"; owner = " + this.OwnerAsRadNumericUpDown());
				return this;
			}
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetPattern: " +
					"patternInterface = " + patternInterface +
					"; owner = " + this.OwnerAsRadNumericUpDown());
#else
			if (patternInterface == PatternInterface.RangeValue
#if INHERIT_IRangeValueProvider_IValueProvider
				|| patternInterface == PatternInterface.Value
#endif
				)
			{
				return this;
			}
#endif
			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		public double Value
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				System.Diagnostics.Debug.WriteLine("RadNumericUpDownAutomationPeer.Value[double].get:");
#endif
				return this.GetValue();
			}
		}

		internal virtual double GetValue()
		{
			RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
			int decimals = owner.GetDecimals();
			double ownerValue = owner.Value;
			double result = Math.Round(ownerValue, decimals);

#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(string.Format(
				"RadNumericUpDownAutomationPeer.GetValue() >> result:> {0} = round( {1}, {2}) owner = {3}",
				result, ownerValue, decimals, owner));
#endif

			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override bool IsContentElementCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.IsContentElementCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override bool IsControlElementCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.IsControlElementCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetAutomationControlTypeCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return AutomationControlType.Spinner;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetClassNameCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return "RadNumericUpDown";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override Point GetClickablePointCore()
		{
			// Currently we do not support clickable area
			return new Point(double.NaN, double.NaN);
		}

#if INHERIT_IRangeValueProvider_IValueProvider

		bool IValueProvider.IsReadOnly
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
				bool isEditable = owner.IsEditable;
				bool isEnabled = base.IsEnabled();
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.IValueProvider.IsReadOnly.get >> isEditable = " +
					isEditable + " && isEnabled = " + isEnabled + "; owner = " + owner);
				return !(isEditable && isEnabled);
#else
				return !(this.OwnerAsRadNumericUpDown().IsEditable && base.IsEnabled());
#endif
			}
		}

		/// <summary>
		/// 
		/// </summary>
		string IValueProvider.Value
		{
			get
			{
#if TRACE_RadNumericUpDownAutomationPeer
				RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
				string str = owner.ContentText;
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.IValueProvider.Value[string].get >> " +
					"owner.ContentText = " + str + "; owner = " + owner);
				return str;
#else
				return this.OwnerAsRadNumericUpDown().ContentText;
#endif
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		void IValueProvider.SetValue(string value)
		{
			if (!base.IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
			RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
			if (!owner.IsEditable)
			{
				throw new InvalidOperationException();
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}

			// throw new System.NotImplementedException();
			owner.ContentText = value;
		}
#endif

		RadNumericUpDown OwnerAsRadNumericUpDown()
		{
			RadNumericUpDown owner = base.Owner as RadNumericUpDown;
			if (null == owner)
			{
				throw new InvalidOperationException("The Owner have to be a RadNumericUpDown");
			}
			return owner;
		}

		void GuarantyEnabled()
		{
			if (!IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}
	}
#endif // INHERIT_IRangeValueProvider

#if INHERIT_RangeBaseAutomationPeer
	/// <summary>
	/// 
	/// </summary>
	public sealed class RadNumericUpDownAutomationPeer
		: FrameworkElementAutomationPeer, IRangeValueProvider
	{
		/// <summary>
		/// Initializes a new instance of the RadNumericUpDownAutomationPeer class.
		/// </summary>
		/// <param name="control"></param>
		public RadNumericUpDownAutomationPeer(RadNumericUpDown control)
			: base(control)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public bool IsReadOnly
		{
			get
			{
				return !this.IsEnabled();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double LargeChange
		{
			get
			{
				return this.OwnerAsRangeBase().LargeChange;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double Maximum
		{
			get
			{
				return this.OwnerAsRangeBase().Maximum;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double Minimum
		{
			get
			{
				return this.OwnerAsRangeBase().Minimum;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double SmallChange
		{
			get
			{
				return this.OwnerAsRangeBase().SmallChange;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double Value
		{
			get
			{
				System.Diagnostics.Debug.WriteLine("RangeBaseAutomationPeer.Value.get:");
				return this.GetValue();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		void IRangeValueProvider.SetValue(double value)
		{
			this.SetOwnerValue(value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="patternInterface"></param>
		/// <returns></returns>
		public override object GetPattern(PatternInterface patternInterface)
		{
#if TRACE_RadNumericUpDownAutomationPeer
			if (patternInterface == PatternInterface.RangeValue)
			{
				System.Diagnostics.Debug.WriteLine(
					"RadNumericUpDownAutomationPeer.GetPattern: " +
					"patternInterface ===" + patternInterface +
					"; owner = " + this.OwnerAsRadNumericUpDown());
				return this;
			}
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetPattern: " +
					"patternInterface = " + patternInterface +
					"; owner = " + this.OwnerAsRadNumericUpDown());
#else
			if (patternInterface == PatternInterface.RangeValue)
			{
				return this;
			}
#endif
			return base.GetPattern(patternInterface);
		}

		internal double GetValue()
		{
			RadNumericUpDown owner = this.OwnerAsRadNumericUpDown();
			int decimals = owner.GetDecimals();
			double ownerValue = owner.Value.Value;
			double result = Math.Round(ownerValue, decimals);

#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(string.Format(
				CultureInfo.InvariantCulture,
				"RadNumericUpDownAutomationPeer.GetValue() >> result:> {0} = round( {1}, {2}) owner = {3}",
				result,
				ownerValue,
				decimals,
				owner));
#endif

			return result;
		}

		internal RadNumericUpDown OwnerAsRadNumericUpDown()
		{
			RadNumericUpDown owner = this.Owner as RadNumericUpDown;
			if (null == owner)
			{
				throw new InvalidOperationException("The Owner have to be a RadNumericUpDown");
			}
			return owner;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseMaximumPropertyChangedEvent(double oldValue, double newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.MaximumProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseMinimumPropertyChangedEvent(double oldValue, double newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.MinimumProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseValuePropertyChangedEvent(double oldValue, double newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.ValueProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseSmallChangePropertyChangedEvent(double oldValue, double newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.SmallChangeProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseLargeChangePropertyChangedEvent(double oldValue, double newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.LargeChangeProperty, oldValue, newValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="oldValue"></param>
		/// <param name="newValue"></param>
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RaiseIsReadOnlyPropertyChangedEvent(bool oldValue, bool newValue)
		{
			this.RaisePropertyChangedEvent(RangeValuePatternIdentifiers.IsReadOnlyProperty, oldValue, newValue);
		}

		internal void SetOwnerValue(double value)
		{
			this.GuarantyEnabled();
			RadRangeBase owner = this.OwnerAsRangeBase();
			if ((value < owner.Minimum) || (value > owner.Maximum))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			owner.Value = value;
		}

		/// <summary>
		/// 
		/// </summary>
		internal void GuarantyEnabled()
		{
			if (!IsEnabled())
			{
				throw new ElementNotEnabledException();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override string GetClassNameCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetClassNameCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return "RadNumericUpDown";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		protected override AutomationControlType GetAutomationControlTypeCore()
		{
#if TRACE_RadNumericUpDownAutomationPeer
			System.Diagnostics.Debug.WriteLine(
				"RadNumericUpDownAutomationPeer.GetAutomationControlTypeCore:  owner = " +
				this.OwnerAsRadNumericUpDown());
#endif
			return AutomationControlType.Spinner;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private RadRangeBase OwnerAsRangeBase()
		{
			RadRangeBase owner = this.Owner as RadRangeBase;
			if (null == owner)
			{
				throw new InvalidOperationException("The Owner have to be a RangeBase or a Descendant");
			}
			return owner;
		}
	}
#endif // #if INHERIT_RangeBaseAutomationPeer
}