using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Orm.Toolkit.Telerik.Windows.Controls.Animation
{
    /// <summary>
    /// Static manager class used for dynamic animations of controls.
    /// </summary>
    public static class AnimationManager
    {
        /// <summary>
        /// Represents the AnimationSelector attached property.
        /// </summary>
        public static readonly DependencyProperty AnimationSelectorProperty =

			DependencyProperty.RegisterAttached("AnimationSelector", typeof(AnimationSelectorBase), typeof(AnimationManager), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits, OnAnimationSelectorChanged, null));


        /// <summary>
        /// Identifies the IsAnimationEnabled attached property.
        /// </summary>
        public static readonly DependencyProperty IsAnimationEnabledProperty =

			DependencyProperty.RegisterAttached("IsAnimationEnabled", typeof(bool), typeof(AnimationManager), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.Inherits));


        internal static readonly DependencyProperty CallbacksProperty =
            DependencyProperty.RegisterAttached("Callbacks", typeof(ICollection<Action>), typeof(AnimationManager), null);

        /// <summary>
        /// Identifies the Animation attached property.
        /// </summary>
        /// <remarks>
        ///		<para>
        ///			This property is used to bind the corresponding RadAnimation to a storyboard.
        ///		</para>
        /// </remarks>
        internal static readonly DependencyProperty AnimationProperty =
            DependencyProperty.RegisterAttached("Animation", typeof(WeakReference), typeof(AnimationManager), null);

        private static bool isAnimationEnabled = true;
        private static double globalSpeedRatio = 1;

        /// <summary>
        /// Gets or sets a value idicating whether the Animation for the whole application will be enabled. 
        /// This value overrides all other properties.
        /// </summary>
        public static bool IsGlobalAnimationEnabled
        {
            get
            {
                return isAnimationEnabled;
            }
            set
            {
                isAnimationEnabled = value;
            }
        }

        /// <summary>
        /// Gets or sets the global animation speed ration that will be used if no local speed ratio is set.
        /// </summary>
        public static double AnimationSpeedRatio
        {
            get
            {
                return globalSpeedRatio;
            }
            set
            {
                globalSpeedRatio = value;
            }
        }

        /// <summary>
        /// Gets the AnimationSelector for the given DependencyObject, normally a control.
        /// </summary>
        /// <param name="obj">The target animated object, normally a control.</param>
        /// <returns>The animation selector for the object.</returns>
        public static AnimationSelectorBase GetAnimationSelector(DependencyObject obj)
        {
            return (AnimationSelectorBase)obj.GetValue(AnimationSelectorProperty);
        }

        /// <summary>
        /// Sets the Animation selector for the given DependencyObject, normally a Control.
        /// </summary>
        /// <param name="obj">The target animated object, normally a cotnrol.</param>
        /// <param name="value">The AnimationSelector to assign.</param>
        public static void SetAnimationSelector(DependencyObject obj, AnimationSelectorBase value)
        {
            obj.SetValue(AnimationSelectorProperty, value);
        }

        /// <summary>
        /// Gets a value idicating whether animation is enabled for the given Control.
        /// </summary>
        /// <param name="obj">The dependency object for which to check the value, normally a control.</param>
        /// <returns>True if animation is enabled, false otherwise.</returns>
        public static bool GetIsAnimationEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsAnimationEnabledProperty);
        }

        /// <summary>
        /// Sets a value idicating whether animation is enabled for the given Control.
        /// </summary>
        /// <param name="obj">The dependency object for which to check the value, normally a control.</param>
        /// <param name="value">True if animation should be enabled, false otherwise.</param>
        public static void SetIsAnimationEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsAnimationEnabledProperty, value);
        }

        /// <summary>
        /// Stops an animation if it is currently active or filling.
        /// </summary>
        /// <param name="target">The control to stop the animation for.</param>
        /// <param name="animationName">The name of the animation to stop.</param>
        public static void Stop(FrameworkElement target, string animationName)
        {
            ////FrameworkElement firstChild = VisualTreeHelper.GetChild(target, 0) as FrameworkElement;
            ////Storyboard storyboard = firstChild.Resources[animationName] as Storyboard;
            Storyboard storyboard = target.Resources[animationName] as Storyboard;
            if (storyboard != null && storyboard.GetCurrentState() != ClockState.Stopped)
            {
                storyboard.Stop();
                InvkokeCallbacks(storyboard);
            }
        }

        /// <summary>
        /// Stops an animation if it is currently active or filling.
        /// </summary>
        /// <param name="target">The control to stop the animation for.</param>
        /// <param name="animationName">The name of the animation to stop.</param>
        public static void StopIfRunning(FrameworkElement target, string animationName)
        {
            ////FrameworkElement firstChild = VisualTreeHelper.GetChild(target, 0) as FrameworkElement;
            ////Storyboard storyboard = firstChild.Resources[animationName] as Storyboard;
            Storyboard storyboard = target.Resources[animationName] as Storyboard;
            if (storyboard != null && storyboard.GetCurrentState() == ClockState.Active)
            {
                storyboard.Stop();
                InvkokeCallbacks(storyboard);
            }
        }

        /// <summary>
        /// Plays an animation for the given control and invokes the callback on completion.
        /// </summary>
        /// <param name="target">The control for which to play the animation.</param>
        /// <param name="animationName">The name of the animation.</param>
        /// <returns>True if an aimation actually played, false otherwise.</returns>
        public static bool Play(FrameworkElement target, string animationName)
        {
            return Play(target, animationName, null);
        }

        /// <summary>
        /// Plays an animation for the given control and invokes the callback on completion.
        /// </summary>
        /// <param name="target">The control for which to play the animation.</param>
        /// <param name="animationName">The name of the animation.</param>
        /// <param name="completeCallback">The callback to be called. The callback is always called.</param>
        /// <param name="args">Optional oarameters for the animation, can be provided by the control.</param>
        /// <returns>True if an aimation actually played, false otherwise.</returns>
        public static bool Play(FrameworkElement target, string animationName, Action completeCallback, params object[] args)
        {
            bool animationsEnabled = AnimationManager.GetIsAnimationEnabled(target) && AnimationManager.IsGlobalAnimationEnabled;
            if (!animationsEnabled || VisualTreeHelper.GetChildrenCount(target) <= 0)
            {
                BeginInvokeCallback(completeCallback, target);
                return false;
            }

            AnimationSelectorBase selector = null;
            RadAnimation animation = null;
            ////FrameworkElement firstChild = VisualTreeHelper.GetChild(target, 0) as FrameworkElement;
            ////Storyboard storyboard = firstChild.Resources[animationName] as Storyboard;
            Storyboard storyboard = target.Resources[animationName] as Storyboard;

            if (storyboard == null)
            {
                selector = AnimationManager.GetAnimationSelector(target);
                if (selector == null)
                {
                    BeginInvokeCallback(completeCallback, target);
                    return false;
                }

                animation = selector.SelectAnimation(target, animationName);
                if (animation == null)
                {
                    BeginInvokeCallback(completeCallback, target);
                    return false;
                }

                storyboard = animation.CreateAnimation(target);

                if (storyboard == null)
                {
                    BeginInvokeCallback(completeCallback, target);
                    return false;
                }
                else
                {
                    storyboard.Completed += new EventHandler(OnStoryboardCompleted);
                    AnimationManager.SetAnimation(storyboard, animation);
                    target.Resources.Add(animationName, storyboard);
                    ////firstChild.Resources.Add(animationName, storyboard);
                }
            }

            RadAnimation sourceAnimation = AnimationManager.GetAnimation(storyboard);

            AddCallback(storyboard, new Action(() => storyboard.Stop()));

            if (completeCallback != null)
            {
                AddCallback(storyboard, completeCallback);
            }            

            if (storyboard.Children.Count > 0)
            {
                sourceAnimation.UpdateAnimation(target, storyboard, args);
            }

            storyboard.Begin();
            return true;
        }

        internal static RadAnimation GetAnimation(DependencyObject obj)
        {
            var result = obj.GetValue(AnimationProperty) as WeakReference;
            if (result == null)
            {
                return null;
            }
            return result.Target as RadAnimation;
        }

        internal static void SetAnimation(DependencyObject obj, RadAnimation value)
        {
            if (value == null)
            {
                obj.SetValue(AnimationProperty, null);
            }
            else
            {
                obj.SetValue(AnimationProperty, new WeakReference(value));
            }
        }

        internal static void AddCallback(Storyboard storyboard, Action callback)
        {
            var callbacks = GetCallbacks(storyboard);
            if (callbacks == null)
            {
                SetCallbacks(storyboard, new List<Action>() { callback });
            }
            else
            {
                callbacks.Add(callback);
            }
        }

        internal static void InvkokeCallbacks(Storyboard storyboard)
        {
            if (storyboard == null)
            {
                return;
            }
            var callbacks = GetCallbacks(storyboard);

            foreach (var child in storyboard.Children)
            {
                var childStoryboard = child as Storyboard;
                if (childStoryboard != null)
                {
                    InvkokeCallbacks(childStoryboard);
                }
            }

            if (callbacks != null)
            {
                foreach (var callback in callbacks)
                {
                    callback();
                }
                callbacks.Clear();
            }
        }

        private static void BeginInvokeCallback(Action callback, DependencyObject target)
        {
            if (callback != null)
            {
                target.Dispatcher.BeginInvoke(callback);
            }
        }

        private static void OnStoryboardCompleted(object sender, EventArgs e)
        {
			var clockGroup = sender as ClockGroup;
			if(clockGroup != null)
			{
				InvkokeCallbacks(clockGroup.Timeline as Storyboard);
			}

        }

        private static ICollection<Action> GetCallbacks(DependencyObject obj)
        {
            return obj.GetValue(AnimationManager.CallbacksProperty) as ICollection<Action>;
        }

        private static void SetCallbacks(DependencyObject obj, ICollection<Action> value)
        {
            obj.SetValue(AnimationManager.CallbacksProperty, value);
        }

        private static void OnAnimationSelectorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Make sure property is set to the children as well:
            var itemsControl = sender as ItemsControl;
            if (itemsControl != null)
            {
                foreach (var item in itemsControl.Items)
                {
                    var container = itemsControl.ItemContainerGenerator.ContainerFromItem(item) as FrameworkElement;
                    if (container != null)
                    {
                        AnimationManager.SetAnimationSelector(container, e.NewValue as AnimationSelectorBase);
                    }
                }
            }
        }
    }
}