
using System.Windows;
namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Base class for all animation classes that have direction.
	/// </summary>
	public abstract class OrientedAnimation : BaseAnimation
	{
		private static readonly DependencyProperty ShouldSkipDelayProperty = DependencyProperty.RegisterAttached("ShouldSkipDelay", typeof(bool), typeof(OrientedAnimation), null);

		/// <summary>
		/// Gets or sets a value indicating whether the animated object is comming in or out of view.
		/// </summary>
		public AnimationDirection Direction
		{
			get;
			set;
		}		

		/// <summary>
		/// Gets the delay that should pass before run the animation.
		/// </summary>
		/// <param name="target">The target of the animation.</param>
		/// <returns>The delay that should pass before run the animation.</returns>
		protected double GetDelay(DependencyObject target)
		{
			if (this.Direction == AnimationDirection.In && !GetShouldSkipDelay(target))
			{
				SetShouldSkipDelay(target, true);
				return 0.100;
			}
			return 0.0;
		}

		/// <summary>
		/// If the current Orientation of the animation is In, returns the inValue,
		/// otherwize - the outValue.
		/// </summary>
		/// <typeparam name="T">The type that will be used.</typeparam>
		/// <param name="inValue">The value to be returned if the current Direction is In.</param>
		/// <param name="outValue">The value to be returned if the current Direction is Out.</param>
		/// <returns>If the current Orientation of the animation is In - the inValue, 
		/// otherwize - the outValue.</returns>
		protected T GetValueDependingOnDirection<T>(T inValue, T outValue)
		{
			if (this.Direction == AnimationDirection.In)
			{
				return inValue;
			}
			else
			{
				return outValue;
			}
		}

		private static bool GetShouldSkipDelay(DependencyObject d)
		{
			return (bool)d.GetValue(ShouldSkipDelayProperty);
		}

		private static void SetShouldSkipDelay(DependencyObject d, bool value)
		{
			d.SetValue(ShouldSkipDelayProperty, value);
		}
	}
}
