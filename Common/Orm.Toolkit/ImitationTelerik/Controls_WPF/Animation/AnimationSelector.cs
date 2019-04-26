using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Animation Selector, used for easier definition of animations in xaml.
	/// </summary>
	[ContentProperty("Animations")]
	public class AnimationSelector : AnimationSelectorBase
	{
		private Dictionary<string, RadAnimation> availableAnimations = new Dictionary<string, RadAnimation>();
		private ObservableCollection<RadAnimation> animations = new ObservableCollection<RadAnimation>();

		/// <summary>
		/// Initializes a new instance of the AnimationSelector class.
		/// </summary>
		public AnimationSelector()
		{
			this.animations.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnAnimationsCollectionChanged);
		}

		/// <summary>
		/// Gets the list of animations in that this selector will choose from.
		/// </summary>
		public IList Animations
		{
			get
			{
				return this.animations;
			}
		}

		/// <summary>
		/// Selects an animation based on its AnimationName.
		/// </summary>
		/// <remarks>
		///		<para>
		///			The AnimationSelector will return the animation with matching name from
		///			its <strong>Animations</strong> list.
		///		</para>
		/// </remarks>
		/// <param name="control">The control the animation is needed for.</param>
		/// <param name="name">The name of the animation. Often it is a change of state, result of a user action.</param>
		/// <returns>The RadAnimation object.</returns>
		/// <seealso cref="AnimationSelector.Animations"/>
		public override RadAnimation SelectAnimation(FrameworkElement control, string name)
		{
			if (this.availableAnimations.ContainsKey(name))
			{
				return this.availableAnimations[name];
			}

			foreach (var animation in this.animations)
			{
				if (animation.AnimationName == name)
				{
					this.availableAnimations.Add(name, animation);
					return animation;
				}
			}

			return null;
		}

		private void OnAnimationsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				this.OnAnimationAdded(e.NewItems[0] as RadAnimation);
			}
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				this.OnAnimationRemoved(e.OldItems[0] as RadAnimation);
			}
		}

		private void OnAnimationRemoved(RadAnimation radAnimation)
		{
			if (this.availableAnimations.ContainsKey(radAnimation.AnimationName))
			{
				this.availableAnimations.Remove(radAnimation.AnimationName);
			}
		}

		private void OnAnimationAdded(RadAnimation radAnimation)
		{
			if (radAnimation.AnimationName != null)
			{
				this.availableAnimations.Add(radAnimation.AnimationName, radAnimation);
			}
		}
	}
}
