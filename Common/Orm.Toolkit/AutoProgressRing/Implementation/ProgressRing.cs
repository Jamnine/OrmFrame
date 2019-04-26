using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit
{
    /// <summary>
    /// 环状物体
    /// </summary>
    [TemplateVisualState(Name = "Small", GroupName = "SizeStates"), TemplateVisualState(Name = "Active", GroupName = "ActiveStates"), TemplateVisualState(Name = "Large", GroupName = "SizeStates"), TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
    public class ProgressRing : Control
    {
        private List<Action> _deferredActions = new List<Action>();
        public static readonly DependencyProperty BindableWidthProperty = DependencyProperty.Register("BindableWidth", typeof(double), typeof(ProgressRing), new PropertyMetadata(0.0, new PropertyChangedCallback(ProgressRing.BindableWidthCallback)));
        public static readonly DependencyProperty EllipseDiameterProperty = DependencyProperty.Register("EllipseDiameter", typeof(double), typeof(ProgressRing), new PropertyMetadata(0.0));
        public static readonly DependencyProperty EllipseOffsetProperty = DependencyProperty.Register("EllipseOffset", typeof(Thickness), typeof(ProgressRing), new PropertyMetadata(new Thickness()));
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register("IsActive", typeof(bool), typeof(ProgressRing), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(ProgressRing.IsActiveChanged)));
        public static readonly DependencyProperty IsLargeProperty = DependencyProperty.Register("IsLarge", typeof(bool), typeof(ProgressRing), new PropertyMetadata(true, new PropertyChangedCallback(ProgressRing.IsLargeChangedCallback)));
        public static readonly DependencyProperty MaxSideLengthProperty = DependencyProperty.Register("MaxSideLength", typeof(double), typeof(ProgressRing), new PropertyMetadata(0.0));

        static ProgressRing()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ProgressRing), new FrameworkPropertyMetadata(typeof(ProgressRing)));
        }

        public ProgressRing()
        {
            base.SizeChanged += new SizeChangedEventHandler(this.OnSizeChanged);
        }

        private static void BindableWidthCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ProgressRing ring = dependencyObject as ProgressRing;
            if (ring != null)
            {
                Action item = delegate
                {
                    ring.SetEllipseDiameter((double)dependencyPropertyChangedEventArgs.NewValue);
                    ring.SetEllipseOffset((double)dependencyPropertyChangedEventArgs.NewValue);
                    ring.SetMaxSideLength((double)dependencyPropertyChangedEventArgs.NewValue);
                };
                if (ring._deferredActions != null)
                {
                    ring._deferredActions.Add(item);
                }
                else
                {
                    item();
                }
            }
        }

        private static void IsActiveChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ProgressRing ring = dependencyObject as ProgressRing;
            if (ring != null)
            {
                ring.UpdateActiveState();
            }
        }

        private static void IsLargeChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            ProgressRing ring = dependencyObject as ProgressRing;
            if (ring != null)
            {
                ring.UpdateLargeState();
            }
        }

        public override void OnApplyTemplate()
        {
            this.UpdateLargeState();
            this.UpdateActiveState();
            base.OnApplyTemplate();
            if (this._deferredActions != null)
            {
                foreach (Action action in this._deferredActions)
                {
                    action();
                }
            }
            this._deferredActions = null;
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs sizeChangedEventArgs)
        {
            this.BindableWidth = base.ActualWidth;
        }

        private void SetEllipseDiameter(double width)
        {
            this.EllipseDiameter = width / 8.0;
        }

        private void SetEllipseOffset(double width)
        {
            this.EllipseOffset = new Thickness(0.0, width / 2.0, 0.0, 0.0);
        }

        private void SetMaxSideLength(double width)
        {
            this.MaxSideLength = (width <= 20.0) ? 20.0 : width;
        }

        private void UpdateActiveState()
        {
            Action action;
            if (this.IsActive)
            {
                action = () => VisualStateManager.GoToState(this, "Active", true);
            }
            else
            {
                action = () => VisualStateManager.GoToState(this, "Inactive", true);
            }
            if (this._deferredActions != null)
            {
                this._deferredActions.Add(action);
            }
            else
            {
                action();
            }
        }

        private void UpdateLargeState()
        {
            Action action;
            if (this.IsLarge)
            {
                action = () => VisualStateManager.GoToState(this, "Large", true);
            }
            else
            {
                action = () => VisualStateManager.GoToState(this, "Small", true);
            }
            if (this._deferredActions != null)
            {
                this._deferredActions.Add(action);
            }
            else
            {
                action();
            }
        }

        public double BindableWidth
        {
            get
            {
                return (double)base.GetValue(BindableWidthProperty);
            }
            private set
            {
                base.SetValue(BindableWidthProperty, value);
            }
        }

        public double EllipseDiameter
        {
            get
            {
                return (double)base.GetValue(EllipseDiameterProperty);
            }
            private set
            {
                base.SetValue(EllipseDiameterProperty, value);
            }
        }

        public Thickness EllipseOffset
        {
            get
            {
                return (Thickness)base.GetValue(EllipseOffsetProperty);
            }
            private set
            {
                base.SetValue(EllipseOffsetProperty, value);
            }
        }

        public bool IsActive
        {
            get
            {
                return (bool)base.GetValue(IsActiveProperty);
            }
            set
            {
                base.SetValue(IsActiveProperty, value);
            }
        }

        public bool IsLarge
        {
            get
            {
                return (bool)base.GetValue(IsLargeProperty);
            }
            set
            {
                base.SetValue(IsLargeProperty, value);
            }
        }

        public double MaxSideLength
        {
            get
            {
                return (double)base.GetValue(MaxSideLengthProperty);
            }
            private set
            {
                base.SetValue(MaxSideLengthProperty, value);
            }
        }

    }
}
