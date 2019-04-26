using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Fade animation for showing/hiding elements.
	/// </summary>
	public class FadeAnimation : OrientedAnimation
	{
		/// <summary>
		/// Initializes a new instance of the FadeAnimation class.
		/// </summary>
		public FadeAnimation()
		{
			this.MinOpacity = 0.0;
			this.MaxOpacity = 1.0;
		}

		/// <summary>
		/// Gets or sets a value that describes the maximum opacity during the animation.
		/// </summary>
		public double MaxOpacity
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value that describes the minimum opacity during the animation.
		/// </summary>
		public double MinOpacity
		{
			get;
			set;
		}

		/// <summary>
		/// Creates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation is needed.</param>
		/// <param name="target">The targeted element of the animation.</param>
		/// <returns>The newly created animation.</returns>
		protected override Storyboard CreateAnimationOverride(FrameworkElement control, FrameworkElement target)
		{
			var relativeFrom =
				this.GetValueDependingOnDirection(this.MinOpacity, this.MaxOpacity);
			var relativeTo =
				this.GetValueDependingOnDirection(this.MaxOpacity, this.MinOpacity);

			var result = AnimationExtensions.Create()
						.Animate(target)
						.Opacity(0, relativeFrom, 0, relativeTo)
						.AdjustSpeed()
						.Instance;

			return result;
		}

		/// <summary>
		/// Updates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation needs to be updated.</param>
		/// <param name="storyboard">Storyvoard that needs to be updated.</param>
		/// <param name="target">The targeted element of the animation.</param>
		/// <param name="args"></param>
		/// <remarks>
		/// Currently the method sets the SpeedRatio of the storyboard to
		/// the global <strong>AnimationSpeedRatio</strong> if the local SpeedRatio is null.
		/// If the local SpeedRatio value is set, it will be used.
		/// </remarks>
		protected override void UpdateAnimationOverride(FrameworkElement control, Storyboard storyboard, FrameworkElement target, params object[] args)
		{
			var relativeFrom = 
				this.GetValueDependingOnDirection(this.MinOpacity, this.MaxOpacity);
			var relativeTo = 
				this.GetValueDependingOnDirection(this.MaxOpacity, this.MinOpacity);

			var duration = RadAnimation.GetDurationSecondsForLength(200.0);

			storyboard.Update()
				.Animate(target)
				.Opacity(0, relativeFrom, duration, relativeTo)
				.Easings(this.Easing)
				.AdjustSpeed();
		}
	}
}
