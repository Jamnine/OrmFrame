using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Slide animation for showing/hiding popups.
	/// </summary>
	public class OldSlideAnimation : OrientedAnimation
	{
		/// <summary>
		/// Gets or sets the direction (side) that the object will appear from or slide out to.
		/// </summary>
		public SlideMode SlideMode
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the name of the animated object, part of the ControlTemplate of the control.
		/// </summary>
		public string TargetName 
		{ 
			get { return this.TargetElementName; }
			set { this.TargetElementName = value; }
		}

		/// <summary>
		/// Creates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation is needed.</param>
		/// <param name="target">The targeted element of the animation.</param>
		/// <returns>The newly created animation.</returns>
		protected override Storyboard CreateAnimationOverride(FrameworkElement control, FrameworkElement target)
		{
			var nonZeroValue = this.SlideMode == SlideMode.Top ? 1.0 : -1.0;
			var relativeFrom = this.GetValueDependingOnDirection(nonZeroValue, 0.0);
			var relatoveTo = this.GetValueDependingOnDirection(0.0, nonZeroValue);

			var result = AnimationExtensions.Create()
						.Animate(target)
							.EnsureDefaultTransforms()
							.EnsureOpacityMask()
							.OpacityMaskRelativeMoveY(0, relativeFrom, 0, relatoveTo)
							.MoveY(0, 0, 0, 0)
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
			this.UpdateSlideMode(target, args);

			if (target.ActualHeight == 0)
			{
				// TODO: Discuss LayoutUpdate here.
				target.UpdateLayout();
			}

			var value = target.ActualHeight;

			var nonZeroValue = this.SlideMode == SlideMode.Top ? 1.0 : -1.0;
			var relativeFrom = this.GetValueDependingOnDirection(nonZeroValue, 0.0);
			var relatoveTo = this.GetValueDependingOnDirection(0.0, nonZeroValue);

			value *= -1 * nonZeroValue;
			var fromValue = this.GetValueDependingOnDirection(value, 0.0);
			var endValue = this.GetValueDependingOnDirection(0.0, value);

			var duration = RadAnimation.GetDurationSecondsForLength(Math.Abs(value));

			var splineToUse = this.GetValueDependingOnDirection(Easings.SlideDown1, Easings.SlideUp1);

			storyboard.Update()
				.Animate(target)
					.OpacityMaskRelativeMoveY(0, relativeFrom, duration, relatoveTo)
						.Easings(splineToUse)
					.MoveY(0, fromValue, duration, endValue)
						.Easings(splineToUse);

			DisableControlWhileAnimationIsRunning(target, storyboard);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "args"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "target")]
		private void UpdateSlideMode(FrameworkElement target, object[] args)
		{

		}

		private void DisableControlWhileAnimationIsRunning(FrameworkElement target, Storyboard storyboard)
		{
			FrameworkElement firstChild = null;

			target.IsHitTestVisible = false;

			var childCount = VisualTreeHelper.GetChildrenCount(target);
			if (childCount > 0)
			{
				firstChild = VisualTreeHelper.GetChild(target, 0) as FrameworkElement;

				firstChild.IsHitTestVisible = false;

				if (this.Direction == AnimationDirection.In)
				{
					EventHandler completeHandler = null;
					completeHandler += (sender, e) =>
					{
						firstChild.IsHitTestVisible = true;
						target.IsHitTestVisible = true;
						storyboard.Completed -= completeHandler;
					};
					storyboard.Completed += completeHandler;
				}
			}
		}
	}
}
