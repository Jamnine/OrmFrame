using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Scale animation for showing/hiding elements.
	/// </summary>
	public class ScaleAnimation : OrientedAnimation
	{
		/// <summary>
		/// Initializes a new instance of the ScaleAnimation class.
		/// </summary>
		public ScaleAnimation()
		{
			this.MinScale = 0.01;
			this.MaxScale = 1.0;
		}

		/// <summary>
		/// Gets or sets a value that describes the maximum scale during the animation.
		/// </summary>
		public double MaxScale
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value that describes the minimum scale during the animation.
		/// </summary>
		public double MinScale
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
				this.GetValueDependingOnDirection(this.MinScale, this.MaxScale);
			var relatoveTo =
				this.GetValueDependingOnDirection(this.MaxScale, this.MinScale);

			target.RenderTransformOrigin = new Point(0.5, 0.5);
			var result = AnimationExtensions.Create()
						.Animate(target)
						.EnsureDefaultTransforms()
						.ScaleX(0, relativeFrom, 0, relatoveTo)
						.ScaleY(0, relativeFrom, 0, relatoveTo)
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
				this.GetValueDependingOnDirection(this.MinScale, this.MaxScale);
			var relativeTo =
				this.GetValueDependingOnDirection(this.MaxScale, this.MinScale);

			var duration = RadAnimation.GetDurationSecondsForLength(100.0);

			storyboard.Update()
				.Animate(target)
				.EnsureDefaultTransforms()
				.ScaleX(0, relativeFrom, duration, relativeTo)
				.Easings(this.Easing)
				.ScaleY(0, relativeFrom, duration, relativeTo)
				.Easings(this.Easing)
				.AdjustSpeed();
		}
	}
}
