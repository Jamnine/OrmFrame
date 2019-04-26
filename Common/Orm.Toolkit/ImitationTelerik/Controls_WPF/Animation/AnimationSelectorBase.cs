using System;
using System.Windows.Controls;
using System.Windows;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
	/// <summary>
	/// Base class for selecting DynamicAnimations.
	/// </summary>
	public abstract class AnimationSelectorBase
	{
		/// <summary>
		///		<para>
		///			When overriden in derived classes, it selects an animation for the specific
		///			control and reason.
		///		</para>
		/// </summary>
		/// <param name="control">The control the animation is needed for.</param>
		/// <param name="name">The reason for the animation. Often it is a change of state, result of a user action.</param>
		/// <returns>The RadAnimation object.</returns>
		public abstract RadAnimation SelectAnimation(FrameworkElement control, string name);
	}
}
