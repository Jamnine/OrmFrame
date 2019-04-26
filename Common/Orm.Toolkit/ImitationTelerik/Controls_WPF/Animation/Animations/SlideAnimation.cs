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
	/// Fade animation for showing/hiding elements.
	/// </summary>
	public class SlideAnimation : OrientedAnimation
	{
		/// <summary>
		/// Initializes a new instance of the SlideAnimation class.
		/// </summary>
		public SlideAnimation()
		{
			this.PixelsToAnimate = double.NaN;
			this.Easing = null;
			this.Duration = TimeSpan.MinValue;
			this.Orientation = Orientation.Vertical;
		}

		/// <summary>
		/// Gets or sets the direction (side) that the object will appear from or slide out to.
		/// </summary>
		public SlideMode SlideMode
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets a value, describing the orientation of the animation.
		/// </summary>
		public Orientation Orientation { get; set; }

		/// <summary>
		/// Gets or sets a value that describes the amount of pixels to be animated.
		/// </summary>
		public double PixelsToAnimate { get; set; }

		/// <summary>
		/// Gets or sets a value that describes the duration of the animation.
		/// </summary>
		public TimeSpan Duration { get; set; }

		/// <summary>
		/// Creates the slide animation.
		/// </summary>
		/// <param name="control">The control for which the animation is needed.</param>
		/// <param name="target">The targeted element of the animation.</param>
		/// <returns>The newly created animation.</returns>
		protected override Storyboard CreateAnimationOverride(FrameworkElement control, FrameworkElement target)
		{
			return AnimationExtensions.Create()
						.Animate(target)
							.SingleProperty(ClipStartXProperty, 0, 0, 0, 0, 0, 0)
							.SingleProperty(ClipStartYProperty, 0, 0, 0, 0, 0, 0)
							.EnsureDefaultTransforms()
							.MoveX(0, 0, 0, 0, 0, 0)
							.MoveY(0, 0, 0, 0, 0, 0)
						.Instance;
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
			var orientation = this.Orientation;
			var slideMode = this.SlideMode;

			if (args.Length > 0 && args[0] is Orientation)
			{
				orientation = (Orientation)args[0];
			}

			if (args.Length > 1 && args[1] is SlideMode)
			{
				slideMode = (SlideMode)args[1];
			}

			var value = this.GetPixelsToAnimate();
			var valueCoeficient = slideMode == SlideMode.Top ? -1 : 1;

			var fromValue = this.GetValueDependingOnDirection(value * valueCoeficient, 0.0);
			var endValue = this.GetValueDependingOnDirection(0.0, value * valueCoeficient);

			var delay = this.GetDelay(target);
			var duration = this.GetAnimationDuration() + delay;

			if (orientation == Orientation.Vertical)
			{
				storyboard.Update()
					.Animate(target)
					.SingleProperty(ClipStartXProperty, 0, 0, delay, 0, duration, 0)
					.SingleProperty(ClipStartYProperty, 0, -fromValue, delay, -fromValue, duration, -endValue)
					.Easings(this.GetEasing())
					.MoveX(0, 0, delay, 0, duration, 0)
					.MoveY(0, fromValue, delay, fromValue, duration, endValue)
					.Easings(this.GetEasing());
			}
			else
			{
				storyboard.Update()
					.Animate(target)
					.SingleProperty(ClipStartXProperty, 0, -fromValue, delay, -fromValue, duration, -endValue)
					.SingleProperty(ClipStartYProperty, 0, 0, delay, 0, duration, 0)
					.Easings(this.GetEasing())
					.MoveX(0, fromValue, delay, fromValue, duration, endValue)
					.MoveY(0, 0, delay, 0, duration, 0)
					.Easings(this.GetEasing());
			}

			ClipControlWhileAnimationIsRunning(target, storyboard);
			//DisableControlWhileAnimationIsRunning(target, storyboard);
		}

		private double GetAnimationDuration()
		{
			return this.Duration == TimeSpan.MinValue ? this.GetValueDependingOnDirection(0.265, 0.165) : this.Duration.TotalSeconds;
			//return this.Duration == TimeSpan.MinValue ? this.GetValueDependingOnDirection(2.65, 1.65) : this.Duration.TotalSeconds;
		}

		private double GetPixelsToAnimate()
		{
			return double.IsNaN(this.PixelsToAnimate) ? this.GetValueDependingOnDirection(75.0, 50.0) : this.PixelsToAnimate;
		}

		private IEasingFunction GetEasing()
		{
			return this.Easing ?? this.GetValueDependingOnDirection(Easings.CircleOut, Easings.CircleIn);
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

		private static void ClipControlWhileAnimationIsRunning(FrameworkElement target, Storyboard storyboard)
		{
			target.Clip = new RectangleGeometry();
			EventHandler completeHandler = null;
			completeHandler += (sender, e) =>
			{

				target.Dispatcher.BeginInvoke(new Action(() => target.ClearValue(UIElement.ClipProperty)));
			
				storyboard.Completed -= completeHandler;
			};
			storyboard.Completed += completeHandler;
		}

		private static readonly DependencyProperty ClipStartYProperty =
			DependencyProperty.RegisterAttached("ClipStartY", typeof(double), typeof(SlideAnimation), new PropertyMetadata(OnClipStartYChanged));

		private static void OnClipStartYChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var element = d as UIElement;
			var clip = d.GetValue(UIElement.ClipProperty) as RectangleGeometry;
			if (clip == null)
			{
				element.Clip = clip = new RectangleGeometry();
			}

			clip.Rect = new Rect(0, (double)e.NewValue, Math.Max(element.DesiredSize.Width, element.RenderSize.Width), Math.Max(element.DesiredSize.Height, element.RenderSize.Height));
		}

		private static readonly DependencyProperty ClipStartXProperty =
			DependencyProperty.RegisterAttached("ClipStartX", typeof(double), typeof(SlideAnimation), new PropertyMetadata(OnClipStartXChanged));

		private static void OnClipStartXChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			var element = d as UIElement;
			var clip = d.GetValue(UIElement.ClipProperty) as RectangleGeometry;
			if (clip == null)
			{
				element.Clip = clip = new RectangleGeometry();
			}

			clip.Rect = new Rect((double)e.NewValue, 0, Math.Max(element.DesiredSize.Width, element.RenderSize.Width), Math.Max(element.DesiredSize.Height, element.RenderSize.Height));
		}
	}
}
