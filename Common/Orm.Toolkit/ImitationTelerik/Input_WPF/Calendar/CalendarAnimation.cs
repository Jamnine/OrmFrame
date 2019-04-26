using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// Class that governs the transition animations in the calendar.
	/// </summary>
	public static class CalendarAnimation
	{
		private const string StoryboardName = "trasnlateStoryboard{0}";
		private const string TargetTempName = "generatedName{0}";

		private static int storyboardCounter;
		private static Dictionary<string, RequestBase> delayedExecution = new Dictionary<string, RequestBase>(4);


        private static int tempNameCounter;


		/// <summary>
		/// Slides the given element into view. This is an extension method.
		/// </summary>
		/// <param name="target">The given element.</param>
		/// <param name="duration">How long should the transition take.</param>
		public static void SlideIn(this FrameworkElement target, TimeSpan duration)
		{
			target.Visibility = Visibility.Visible;
			if (target.ActualWidth == 0)
			{
				target.InvalidateMeasure();
				target.InvalidateArrange();
				target.UpdateLayout();
			}
			target.Translate(-target.ActualWidth, null, 0, null, duration);
		}

		/// <summary>
		/// Slides the given element into view. This is an extension method.
		/// </summary>
		/// <param name="target">The target.</param>
		public static void SlideIn(this FrameworkElement target)
		{
			target.SlideIn(TimeSpan.FromMilliseconds(200));
		}

		/// <summary>
		/// Slides the given element out of view. This is an extension method.
		/// </summary>
		/// <param name="target">The target element.</param>
		/// <param name="duration">How long should the transition take.</param>
		public static void SlideOut(this FrameworkElement target, TimeSpan duration)
		{
			target.Translate(0, null, -target.ActualWidth - 10, null, duration, new ActionRequest<FrameworkElement>(o => o.Visibility = Visibility.Collapsed, target));
		}

		/// <summary>
		/// Slides the given element out of view. This is an extension method.
		/// </summary>
		/// <param name="target">The target.</param>
		public static void SlideOut(this FrameworkElement target)
		{
			target.SlideOut(TimeSpan.FromMilliseconds(200));
		}

		/// <summary>
		///     Translates the target element as requested by the parameters.
		/// </summary>
		/// <param name="target">The given element.</param>
		/// <param name="fromX">The starting x Translate transform value.</param>
		/// <param name="fromY">The starting y Translate transform value.</param>
		/// <param name="toX">The final x Translate transform value.</param>
		/// <param name="toY">The final y Translate transform value.</param>
		/// <param name="duration">How long should the transition take.</param>
		public static void Translate(this FrameworkElement target, double? fromX, double? fromY, double? toX, double? toY, TimeSpan duration)
		{
			Translate(target, fromX, fromY, toX, toY, duration, null);
		}

		/// <summary>
		///     Translates the target element as requested by the parameters and executes the action request.
		/// </summary>
		/// <param name="target">The given element.</param>
		/// <param name="fromX">The starting x Translate transform value.</param>
		/// <param name="fromY">The starting y Translate transform value.</param>
		/// <param name="toX">The final x Translate transform value.</param>
		/// <param name="toY">The final y Translate transform value.</param>
		/// <param name="duration">How long should the transition take.</param>
		/// <param name="action">The action request to be executed later.</param>
		public static void Translate(this FrameworkElement target, double? fromX, double? fromY, double? toX, double? toY, TimeSpan duration, RequestBase action)
		{
			Storyboard board = GetAndCreateStoryboardIfNotPresent(target);

			if (fromX != null && toX != null)
			{
				(board.Children[0] as DoubleAnimation).From = fromX;
				(board.Children[0] as DoubleAnimation).To = toX;
				(board.Children[0] as DoubleAnimation).Duration = new Duration(duration);
			}
			if (fromY != null && toY != null)
			{
				(board.Children[1] as DoubleAnimation).From = fromY;
				(board.Children[1] as DoubleAnimation).To = toY;
				(board.Children[1] as DoubleAnimation).Duration = new Duration(duration);
			}

			string boardName = board.GetValue(FrameworkElement.NameProperty) as string;

			if (delayedExecution.ContainsKey(boardName))
			{
				delayedExecution.Remove(boardName);
			}
			if (action != null)
			{
				delayedExecution.Add(boardName, action);
				board.Completed += CompletedHandler;
			}

            board.Begin(target);

		}

		internal static void ChangeScaleAndOpacity(FrameworkElement target, double? scaleFrom, double? scaleTo, double? opacityFrom, double? opacityTo, TimeSpan duration, RequestBase action)
		{
			Storyboard board = GetAndCreateStoryboardIfNotPresent(target);

			if (scaleFrom != null && scaleTo != null)
			{
				(board.Children[0] as DoubleAnimation).From = scaleFrom;
				(board.Children[0] as DoubleAnimation).To = scaleTo;
				(board.Children[0] as DoubleAnimation).Duration = new Duration(duration);
				(board.Children[1] as DoubleAnimation).From = scaleFrom;
				(board.Children[1] as DoubleAnimation).To = scaleTo;
				(board.Children[1] as DoubleAnimation).Duration = new Duration(duration);
			}
			if (opacityFrom != null && opacityTo != null)
			{
				(board.Children[2] as DoubleAnimation).From = opacityFrom;
				(board.Children[2] as DoubleAnimation).To = opacityTo;
				(board.Children[2] as DoubleAnimation).Duration = new Duration(duration);
			}

			string boardName = board.GetValue(FrameworkElement.NameProperty) as string;

			if (delayedExecution.ContainsKey(boardName))
			{
				delayedExecution.Remove(boardName);
			}
			if (action != null)
			{
				delayedExecution.Add(boardName, action);
				board.Completed += CompletedHandler;
			}


            board.Begin(target);

		}

		private static void CompletedHandler(object sender, EventArgs e)
		{

            Storyboard board = (sender as ClockGroup).Timeline as Storyboard;

			string boardName = board.GetValue(FrameworkElement.NameProperty) as string;

			////TODO:  Make sure no hard links remain (memory leaks!)
			if (delayedExecution.ContainsKey(boardName))
			{
				delayedExecution[boardName].Execute();

				// board.Completed -= CompletedHandler;
				delayedExecution.Remove(boardName);
			}
		}

		private static Storyboard GetAndCreateStoryboardIfNotPresent(FrameworkElement target)
		{
			Storyboard result = target.Resources["Animation"] as Storyboard;

			if (result == null)
			{
				////Target has render transform:
				if (!(target.RenderTransform is ScaleTransform))
				{
					target.RenderTransform = new ScaleTransform();
					target.RenderTransformOrigin = new Point(0.5, 0.5);
				}

				DoubleAnimation scaleAnimationX = new DoubleAnimation() { BeginTime = TimeSpan.FromMilliseconds(0) };
				DoubleAnimation scaleAnimationY = new DoubleAnimation() { BeginTime = TimeSpan.FromMilliseconds(0) };
				DoubleAnimation opacityAnimation = new DoubleAnimation() { BeginTime = TimeSpan.FromMilliseconds(0) };



                ////Target has name:
                string targetName = target.GetValue(FrameworkElement.NameProperty) as string;
                if (targetName == null)
                {
                    targetName = string.Format(CultureInfo.InvariantCulture, TargetTempName, tempNameCounter);
                    tempNameCounter++;
                    target.SetValue(FrameworkElement.NameProperty, targetName);
                }
                
                Storyboard.SetTargetName(scaleAnimationX, targetName);
                Storyboard.SetTargetName(scaleAnimationY, targetName);
                Storyboard.SetTargetName(opacityAnimation, targetName);


				Storyboard.SetTargetProperty(scaleAnimationX, new PropertyPath("(UIElement.RenderTransform).(ScaleTransform.ScaleX)"));
				Storyboard.SetTargetProperty(scaleAnimationY, new PropertyPath("(UIElement.RenderTransform).(ScaleTransform.ScaleY)"));
				Storyboard.SetTargetProperty(opacityAnimation, new PropertyPath("(UIElement.Opacity)"));

				result = new Storyboard();
                result.SetValue(FrameworkElement.NameProperty, string.Format(CultureInfo.InvariantCulture, StoryboardName, storyboardCounter));
				storyboardCounter++;

				result.Children.Add(scaleAnimationX);
				result.Children.Add(scaleAnimationY);
				result.Children.Add(opacityAnimation);

				if (target.Resources.Contains("Animation"))
				{
					target.Resources.Remove("Animation");
				}
				target.Resources.Add("Animation", result);
			}

			return result;
		}

		/// <summary>
		/// Request for a simple action.
		/// </summary>
		internal class ActionRequest : RequestBase
		{
			private Action delayedAction;

			/// <summary>
			/// Initializes a new instance of the <see cref="ActionRequest"/> class.
			/// </summary>
			/// <param name="action">The action.</param>
			public ActionRequest(Action action)
			{
				this.delayedAction = action;
			}

			/// <summary>
			/// Executes this instance.
			/// </summary>
			public override void Execute()
			{
				this.delayedAction();
				this.delayedAction = null;
			}
		}

		/// <summary>
		/// Request for an action that takes one parameter.
		/// </summary>
		/// <typeparam name="T">The first parameter.</typeparam>
		internal class ActionRequest<T> : RequestBase
		{
			private Action<T> delayedAction;
			private T param1;

			/// <summary>
			/// Initializes a new instance of the ActionRequest class.
			/// </summary>
			/// <param name="action">The action.</param>
			/// <param name="parameter1">The first parameter.</param>
			public ActionRequest(Action<T> action, T parameter1)
			{
				this.delayedAction = action;
				this.param1 = parameter1;
			}

			/// <summary>
			/// Executes this instance.
			/// </summary>
			public override void Execute()
			{
				this.delayedAction(this.param1);
				this.delayedAction = null;
				this.param1 = default(T);
			}
		}

		/// <summary>
		/// Request for an action that takes two parameters.
		/// </summary>
		/// <typeparam name="T1">The first parameter.</typeparam>
		/// <typeparam name="T2">The second parameter.</typeparam>
		internal class ActionRequest<T1, T2> : RequestBase
		{
			private Action<T1, T2> delayedAction;
			private T1 param1;
			private T2 param2;

			/// <summary>
			/// Initializes a new instance of the ActionRequest class.
			/// </summary>
			/// <param name="action">The action.</param>
			/// <param name="parameter1">The first parameter.</param>
			/// <param name="parameter2">The second parameter.</param>
			public ActionRequest(Action<T1, T2> action, T1 parameter1, T2 parameter2)
			{
				this.delayedAction = action;
				this.param1 = parameter1;
				this.param2 = parameter2;
			}

			/// <summary>
			/// Executes this instance.
			/// </summary>
			public override void Execute()
			{
				this.delayedAction(this.param1, this.param2);
				this.delayedAction = null;
				this.param1 = default(T1);
				this.param2 = default(T2);
			}
		}
	}
}
