using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	internal static partial class AnimationExtensions
	{
		public static AnimationContext Update(this Storyboard target)
		{
			var result = new AnimationContext();
			result.Instance = target;
			result.IsUpdate = true;
			return result;
		}

		internal static AnimationContext Create()
		{
			return new AnimationContext();
		}

		internal static AnimationContext Scale(this AnimationContext target, params double[] args)
		{
			var values = args.ToList();

			if (args.Length % 2 != 0)
			{
				throw new InvalidOperationException("Params should come in a time-value pair");
			}

			foreach (var element in target.Targets)
			{
				if (target.IsUpdate)
				{
					throw new NotImplementedException();
				}
				else
				{
					var scaleX = new DoubleAnimationUsingKeyFrames();
					Storyboard.SetTarget(scaleX, element);
					Storyboard.SetTargetProperty(scaleX, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"));

					var scaleY = new DoubleAnimationUsingKeyFrames();
					Storyboard.SetTarget(scaleY, element);
					Storyboard.SetTargetProperty(scaleY, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"));

					for (int i = 0; i < values.Count; i += 2)
					{
						scaleX.KeyFrames.Add(new EasingDoubleKeyFrame()
						{
							KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i])),
							Value = values[i + 1]
						});

						scaleY.KeyFrames.Add(new EasingDoubleKeyFrame()
						{
							KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i])),
							Value = values[i + 1]
						});
					}

					target.Instance.Children.Add(scaleX);
					target.Instance.Children.Add(scaleY);
				}
			}

			target.StartIndex = target.EndIndex;
			target.EndIndex += 2 * target.Targets.Count;

			return target;
		}

		internal static AnimationContext RotationY(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.Projection).(PlaneProjection.RotationY)", args);
		}

		internal static AnimationContext ScaleX(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)", args);
		}

		internal static AnimationContext ScaleY(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)", args);
		}

		internal static AnimationContext MoveX(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)", args);
		}

		internal static AnimationContext MoveY(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)", args);
		}

		internal static AnimationContext Opacity(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.Opacity)", args);
		}

		internal static AnimationContext OpacityMaskRelativeMoveY(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.OpacityMask).(Brush.RelativeTransform).(TranslateTransform.Y)", args);
		}

		internal static AnimationContext OpacityMaskRelativeMoveX(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.OpacityMask).(Brush.RelativeTransform).(TranslateTransform.X)", args);
		}

		internal static AnimationContext OpacityMaskMoveY(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.OpacityMask).(Brush.Transform).(TranslateTransform.Y)", args);
		}

		internal static AnimationContext OpacityMaskMoveX(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(UIElement.OpacityMask).(Brush.Transform).(TranslateTransform.X)", args);
		}

		internal static AnimationContext Height(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(FrameworkElement.Height)", args);
		}

		internal static AnimationContext Width(this AnimationContext target, params double[] args)
		{
			return target.SingleProperty("(FrameworkElement.Width)", args);
		}

		internal static AnimationContext Easings(this AnimationContext target, IEasingFunction easing)
		{
			return target.Easings(1, easing);
		}

		internal static AnimationContext EaseAll(this AnimationContext target, IEasingFunction easing)
		{
			for (var num = target.StartIndex; num < target.EndIndex; num++)
			{
				var animation = target.Instance.Children[num] as DoubleAnimationUsingKeyFrames;
				foreach (var keyFrame in animation.KeyFrames.Cast<EasingDoubleKeyFrame>())
				{
					keyFrame.EasingFunction = easing;
				}
			}
			return target;
		}

		internal static AnimationContext Easings(this AnimationContext target, int index, IEasingFunction easing)
		{
			for (var num = target.StartIndex; num < target.EndIndex; num++)
			{
				var animation = target.Instance.Children[num] as DoubleAnimationUsingKeyFrames;
				var keyFrame = animation.KeyFrames[index] as EasingDoubleKeyFrame;
				keyFrame.EasingFunction = easing;
			}
			return target;
		}

		internal static AnimationContext Origin(this AnimationContext target, double x1, double x2)
		{
			foreach (var element in target.Targets)
			{
				element.RenderTransformOrigin = new Point(x1, x2);
			}
			return target;
		}

		internal static AnimationContext Animate(this AnimationContext target, params FrameworkElement[] newTargets)
		{
			target.Targets.Clear();
			foreach (var newElement in newTargets)
			{
				target.Targets.Add(newElement);
			}
			return target;
		}


		internal static void EnsureDefaultTransforms(this UIElement element)
		{
			var group = element.RenderTransform as TransformGroup;
			if (group == null || group.Children.Count < 4 ||
				!(group.Children[0] is ScaleTransform) ||
				!(group.Children[1] is SkewTransform) ||
				!(group.Children[2] is RotateTransform) ||
				!(group.Children[3] is TranslateTransform))
			{
				group = new TransformGroup();
				group.Children.Add(new ScaleTransform());
				group.Children.Add(new SkewTransform());
				group.Children.Add(new RotateTransform());
				group.Children.Add(new TranslateTransform());

				element.RenderTransform = group;
			}
		}

		internal static ScaleTransform GetScaleTransform(this UIElement element)
		{
			element.EnsureDefaultTransforms();
			return (element.RenderTransform as TransformGroup).Children[0] as ScaleTransform;
		}

		internal static SkewTransform GetSkewTransform(this UIElement element)
		{
			element.EnsureDefaultTransforms();
			return (element.RenderTransform as TransformGroup).Children[1] as SkewTransform;
		}

		internal static RotateTransform GetRotateTransform(this UIElement element)
		{
			element.EnsureDefaultTransforms();
			return (element.RenderTransform as TransformGroup).Children[2] as RotateTransform;
		}

		internal static TranslateTransform GetTranslateTransform(this UIElement element)
		{
			element.EnsureDefaultTransforms();
			return (element.RenderTransform as TransformGroup).Children[3] as TranslateTransform;
		}

		internal static AnimationContext EnsureDefaultTransforms(this AnimationContext target)
		{
			foreach (var element in target.Targets)
			{
				TransformGroup group = element.RenderTransform as TransformGroup;
				if (group == null || group.Children.Count < 4 ||
					!(group.Children[0] is ScaleTransform) ||
					!(group.Children[1] is SkewTransform) ||
					!(group.Children[2] is RotateTransform) ||
					!(group.Children[3] is TranslateTransform))
				{
					group = new TransformGroup();
					group.Children.Add(new ScaleTransform());
					group.Children.Add(new SkewTransform());
					group.Children.Add(new RotateTransform());
					group.Children.Add(new TranslateTransform());

					element.RenderTransform = group;
				}
			}
			return target;
		}

		/// <summary>
		///		Makes sure that the animated object has the needed opacity mask.
		/// </summary>
		/// <remarks>
		///		<para>
		///			Adds a vertical or horizontal opacity mask of the kind:
		///		</para>
		///		<![CDATA[
		///		<LinearGradientBrush EndPoint="0 1">
		///		    <LinearGradientBrush.RelativeTransform>
		///		        <TranslateTransform Y="0" />
		///		    </LinearGradientBrush.RelativeTransform>
		///		    <GradientStop Offset="0" Color="Transparent" />
		///		    <GradientStop Offset="0" Color="Black" />
		///		    <GradientStop Offset="1" Color="Black" />
		///		    <GradientStop Offset="1" Color="Transparent" />
		///		</LinearGradientBrush>
		///		]]>
		///		</remarks>
		/// <param name="target">The object to set the mask for.</param>
		internal static AnimationContext EnsureOpacityMask(this AnimationContext target)
		{
			foreach (var element in target.Targets)
			{
				var mask = new LinearGradientBrush()
				{
					EndPoint = new Point(0, 1)
				};
				mask.GradientStops.Add(new GradientStop() { Offset = 0, Color = Colors.Transparent });
				mask.GradientStops.Add(new GradientStop() { Offset = 0, Color = Colors.Black });
				mask.GradientStops.Add(new GradientStop() { Offset = 1, Color = Colors.Black });
				mask.GradientStops.Add(new GradientStop() { Offset = 1, Color = Colors.Transparent });
				mask.RelativeTransform = new TranslateTransform();
				mask.Transform = new TranslateTransform();
				element.OpacityMask = mask;
			}
			return target;
		}

		internal static AnimationContext With(this AnimationContext target, params FrameworkElement[] newElements)
		{
			foreach (var elements in newElements)
			{
				target.Targets.Add(elements);
			}
			return target;
		}

		internal static AnimationContext Without(this AnimationContext target, params FrameworkElement[] newElements)
		{
			foreach (var elements in newElements)
			{
				target.Targets.Remove(elements);
			}
			return target;
		}

		internal static AnimationContext SingleProperty(this AnimationContext target, DependencyProperty propertyPath, params double[] args)
		{
			var values = args.ToList();

			if (args.Length % 2 != 0)
			{
				throw new InvalidOperationException("Params should come in a time-value pair");
			}

			target.StartIndex = target.EndIndex;
			target.EndIndex += target.Targets.Count;

			var elementCount = 0;

			foreach (var element in target.Targets)
			{
				if (target.IsUpdate)
				{
					var moveX = target.Instance.Children[target.StartIndex + elementCount] as DoubleAnimationUsingKeyFrames;

					for (int i = 0; i < values.Count; i += 2)
					{
						var keyFrame = moveX.KeyFrames[i / 2] as EasingDoubleKeyFrame;
						keyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i]));
						keyFrame.Value = values[i + 1];
					}
					elementCount++;
				}
				else
				{
					var moveX = new DoubleAnimationUsingKeyFrames();
					Storyboard.SetTarget(moveX, element);
					Storyboard.SetTargetProperty(moveX, new PropertyPath(propertyPath));

					for (int i = 0; i < values.Count; i += 2)
					{
						moveX.KeyFrames.Add(new EasingDoubleKeyFrame()
						{
							KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i])),
							Value = values[i + 1]
						});
					}

					target.Instance.Children.Add(moveX);
				}
			}

			return target;
		}

		internal static AnimationContext Discrete(this AnimationContext target, DependencyProperty propertyPath, params object[] args)
		{
			var values = args.ToList();

			if (args.Length % 2 != 0)
			{
				throw new InvalidOperationException("Params should come in a time-value pair");
			}

			target.StartIndex = target.EndIndex;
			target.EndIndex += target.Targets.Count;

			var elementCount = 0;

			foreach (var element in target.Targets)
			{
				if (target.IsUpdate)
				{
					var moveX = target.Instance.Children[target.StartIndex + elementCount] as ObjectAnimationUsingKeyFrames;

					for (int i = 0; i < values.Count; i += 2)
					{
						var keyFrame = moveX.KeyFrames[i / 2] as DiscreteObjectKeyFrame;
						keyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(Convert.ToDouble(values[i], CultureInfo.InvariantCulture)));
						keyFrame.Value = values[i + 1];
					}
					elementCount++;
				}
				else
				{
					var moveX = new ObjectAnimationUsingKeyFrames();
					Storyboard.SetTarget(moveX, element);
					Storyboard.SetTargetProperty(moveX, new PropertyPath(propertyPath));

					for (int i = 0; i < values.Count; i += 2)
					{
						moveX.KeyFrames.Add(new DiscreteObjectKeyFrame()
						{
							KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(Convert.ToDouble(values[i], CultureInfo.InvariantCulture))),
							Value = values[i + 1]
						});
					}

					target.Instance.Children.Add(moveX);
				}
			}

			return target;
		}

		internal static AnimationContext AdjustSpeed(this AnimationContext target)
		{
			target.Instance.SpeedRatio = AnimationManager.AnimationSpeedRatio;
			return target;
		}

		internal static AnimationContext PlayIfPossible(this AnimationContext target, Control hostControl)
		{
			if (AnimationManager.IsGlobalAnimationEnabled && AnimationManager.GetIsAnimationEnabled(hostControl))
			{
				target.Instance.Begin();
			}
			return target;
		}

		internal static AnimationContext OnComplete(this AnimationContext target, Action callback)
		{
			if (target.Instance != null)
			{
				EventHandler completeHandler = null;
				completeHandler = (s, e) =>
					{
						callback();
						target.Instance.Completed -= completeHandler;
					};
				target.Instance.Completed += completeHandler;
			}
			return target;
		}

		internal static AnimationContext StopFillBehavior(this AnimationContext target)
		{
			target.Instance.FillBehavior = FillBehavior.Stop;
			return target;
		}

		internal static AnimationContext HoldEndFillBehavior(this AnimationContext target)
		{
			target.Instance.FillBehavior = FillBehavior.HoldEnd;
			return target;
		}

		private static AnimationContext SingleProperty(this AnimationContext target, string propertyPath, params double[] args)
		{
			var values = args.ToList();

			if (args.Length % 2 != 0)
			{
				throw new InvalidOperationException("Params should come in a time-value pair");
			}

			target.StartIndex = target.EndIndex;
			target.EndIndex += target.Targets.Count;

			var elementCount = 0;

			foreach (var element in target.Targets)
			{
				if (target.IsUpdate)
				{
					var moveX = target.Instance.Children[target.StartIndex + elementCount] as DoubleAnimationUsingKeyFrames;

					for (int i = 0; i < values.Count; i += 2)
					{
						var keyFrame = moveX.KeyFrames[i / 2] as EasingDoubleKeyFrame;
						keyFrame.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i]));
						keyFrame.Value = values[i + 1];
					}
					elementCount++;
				}
				else
				{
					var moveX = new DoubleAnimationUsingKeyFrames();
					Storyboard.SetTarget(moveX, element);
					Storyboard.SetTargetProperty(moveX, new PropertyPath(propertyPath));

					for (int i = 0; i < values.Count; i += 2)
					{
						moveX.KeyFrames.Add(new EasingDoubleKeyFrame()
						{
							KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(values[i])),
							Value = values[i + 1]
						});
					}

					target.Instance.Children.Add(moveX);
				}
			}

			return target;
		}

		/// <summary>
		///		A helper class, used for chain-creation and update of storyboards in a  jQuery way.
		/// </summary>
		/// <remarks>
		///		The Result storybard is a collection of DoubleAnimationUsingKeyFrame collection.
		/// </remarks>
		internal class AnimationContext
		{
			public AnimationContext()
			{
				this.Instance = new Storyboard()
				{
					FillBehavior = FillBehavior.HoldEnd
				};

				this.Targets = new List<FrameworkElement>(8);
			}

			/// <summary>
			/// Gets or sets the starting index or the currently affected DoubleAnimation targets.
			/// </summary>
			public int StartIndex
			{
				get;
				set;
			}

			/// <summary>
			/// Gets or sets the end index of the currently affected DoubleAnimation targets.
			/// </summary>
			public int EndIndex
			{
				get;
				set;
			}

			/// <summary>
			/// Gets a collection of the elemetns that is currently being animated.
			/// </summary>
			internal ICollection<FrameworkElement> Targets
			{
				get;
				private set;
			}

			/// <summary>
			/// Gets or sets the resultant Storyboard for the AnimationContext.
			/// </summary>
			internal Storyboard Instance
			{
				get;
				set;
			}

			/// <summary>
			/// Gets or sets a value idicating whether currently an animation is being created or updated.
			/// </summary>
			internal bool IsUpdate
			{
				get;
				set;
			}
		}
	}
}
