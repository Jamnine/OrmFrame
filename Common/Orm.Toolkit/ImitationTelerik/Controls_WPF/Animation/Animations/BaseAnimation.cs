using System.Windows;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Base class for all animation classes that have easing and targeted element.
	/// </summary>
	public abstract class BaseAnimation : RadAnimation
	{
		/// <summary>
		/// Initializes a new instance of the ScaleAnimation class.
		/// </summary>
		protected BaseAnimation()
		{

		}

		/// <summary>
		/// Gets or sets a value describing the easing function to be used for the animation.
		/// </summary>
		public IEasingFunction Easing
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the name of the animated object, part of the ControlTemplate of the control.
		/// </summary>
		public string TargetElementName
		{
			get;
			set;
		}

		/// <summary>
		/// Creates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation is needed.</param>
		/// <returns>The newly created animation.</returns>
		public sealed override Storyboard CreateAnimation(FrameworkElement control)
		{
			var target =
				string.IsNullOrEmpty(this.TargetElementName) ?
					control :
					FindTarget(control, this.TargetElementName);
			if (target == null)
			{
				return new Storyboard();
			}
			else
			{
				return this.CreateAnimationOverride(control, target);
			}
		}

		/// <summary>
		/// Updates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation needs to be updated.</param>
		/// <param name="storyboard">Storyvoard that needs to be updated.</param>
		/// <param name="args"></param>
		/// <remarks>
		/// Currently the method sets the SpeedRatio of the storyboard to
		/// the global <strong>AnimationSpeedRatio</strong> if the local SpeedRatio is null.
		/// If the local SpeedRatio value is set, it will be used.
		/// </remarks>
		public sealed override void UpdateAnimation(FrameworkElement control, Storyboard storyboard, params object[] args)
		{
			var target = FindTarget(control, this.TargetElementName);

			if (target != null)
			{
				this.UpdateAnimationOverride(control, storyboard, target, args);
			}

			base.UpdateAnimation(control, storyboard);
		}

		/// <summary>
		/// Creates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation is needed.</param>
		/// <param name="target">The targeted element of the animation.</param>
		/// <returns>The newly created animation.</returns>
		protected abstract Storyboard CreateAnimationOverride(FrameworkElement control, FrameworkElement target);

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
		protected abstract void UpdateAnimationOverride(FrameworkElement control, Storyboard storyboard, FrameworkElement target, params object[] args);
	}
}
