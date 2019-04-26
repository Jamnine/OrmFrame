using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Represents composite animation, used for declaratively creating composite animations.
	/// </summary>
	[ContentProperty("Children")]
	public class AnimationGroup : RadAnimation
	{
		private readonly ObservableCollection<RadAnimation> children = new ObservableCollection<RadAnimation>();

		/// <summary>
		/// Gets a list of the children animation objects of this composite animation.
		/// </summary>
		public IList Children
		{
			get
			{
				return this.children;
			}
		}

        /// <summary>
        /// Calls <see cref="CreateAnimation"/> for each of control 
        /// in <see cref="Children"/> collection.
        /// </summary>
        /// <param name="control">The control for which the animation is needed.</param>
        /// <returns>The newly created animation.</returns>
		public override Storyboard CreateAnimation(FrameworkElement control)
		{
			var result = new Storyboard();

			foreach (var animation in this.children)
			{
				var child = animation.CreateAnimation(control);
				if (this.SpeedRatio != 0 && animation.SpeedRatio == 0.0)
				{
					animation.SpeedRatio = this.SpeedRatio;
				}
				if (child == null)
				{
					throw new InvalidOperationException("Calls to CreateAnimation should always return a non-null storyboard");
				}
				else
				{					
					result.Children.Add(child);
				}
			}

			return result;
		}

        /// <summary>
        /// Updates each child animation of <paramref name="storyboard"/> using according 
        /// animation for each child control in <see cref="Children"/>.
        /// </summary>
		public override void UpdateAnimation(FrameworkElement control, Storyboard storyboard, params object[] args)
		{
			int currentIndex = 0;
			foreach (var animation in this.children)
			{
				if (this.SpeedRatio != 0 && animation.SpeedRatio == 0.0)
				{
					animation.SpeedRatio = this.SpeedRatio;
				}
				var childBoard = storyboard.Children[currentIndex] as Storyboard;
				if (childBoard.Children.Count > 0)
				{
					animation.UpdateAnimation(control, childBoard, args);
				}
				currentIndex++;
			}

			// TODO: No need to call the base here since it will once more update the speed of the animations, which is wrong.
			// base.UpdateAnimation(control, storyboard);
		}
	}
}
