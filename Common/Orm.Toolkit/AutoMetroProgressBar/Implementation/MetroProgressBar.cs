using System;
using System.Collections;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Orm.Toolkit
{
    public class MetroProgressBar : ProgressBar
    {
        public static readonly DependencyProperty EllipseDiameterProperty = DependencyProperty.Register("EllipseDiameter", typeof(double), typeof(MetroProgressBar), new PropertyMetadata(0.0));
        public static readonly DependencyProperty EllipseOffsetProperty = DependencyProperty.Register("EllipseOffset", typeof(double), typeof(MetroProgressBar), new PropertyMetadata(0.0));

        static MetroProgressBar()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(MetroProgressBar), new FrameworkPropertyMetadata(typeof(MetroProgressBar)));
            ProgressBar.IsIndeterminateProperty.OverrideMetadata(typeof(MetroProgressBar), new FrameworkPropertyMetadata(new PropertyChangedCallback(MetroProgressBar.OnIsIndeterminateChanged)));
        }

        public MetroProgressBar()
        {
            base.SizeChanged += new SizeChangedEventHandler(this.SizeChangedHandler);
        }

        private double CalcContainerAnimEnd(double width)
        {
            double num = 0.4352 * width;
            if (width <= 180.0)
            {
                return (num - 25.731);
            }
            if (width <= 280.0)
            {
                return (num + 27.84);
            }
            return (num + 58.862);
        }

        private double CalcContainerAnimStart(double width)
        {
            if (width <= 180.0)
            {
                return -34.0;
            }
            if (width <= 280.0)
            {
                return -50.5;
            }
            return -63.0;
        }

        private double CalcEllipseAnimEnd(double width)
        {
            return ((width * 2.0) / 3.0);
        }

        private double CalcEllipseAnimWell(double width)
        {
            return ((width * 1.0) / 3.0);
        }

        private VisualState GetIndeterminate()
        {
            FrameworkElement templateChild = base.GetTemplateChild("ContainingGrid") as FrameworkElement;
            if (templateChild == null)
            {
                return null;
            }
            IList visualStateGroups = VisualStateManager.GetVisualStateGroups(templateChild);
            if (visualStateGroups == null)
            {
                return null;
            }
            //var x = visualStateGroups.Cast<VisualStateGroup>().Select(g => g.States.Cast<VisualState>()).FirstOrDefault(state => (state is VisualState) && ((VisualState)state).Name == "Indeterminate");
            return visualStateGroups.Cast<VisualStateGroup>().Select(g => g.States.Cast<VisualState>()).FirstOrDefault(state => (state is VisualState) && ((VisualState)state).Name == "Indeterminate") as VisualState;
            //return (from g in visualStateGroups.Cast<VisualStateGroup>() select g.States.Cast<VisualState>()).FirstOrDefault<VisualState>(state => (state.Name == "Indeterminate")) as VisualState;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.SizeChangedHandler(null, null);
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            if (this.EllipseDiameter.Equals((double)0.0))
            {
                this.SetEllipseDiameter(base.ActualWidth);
            }
            if (this.EllipseOffset.Equals((double)0.0))
            {
                this.SetEllipseOffset(base.ActualWidth);
            }
        }

        private static void OnIsIndeterminateChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            MetroProgressBar bar = dependencyObject as MetroProgressBar;
            if ((bar != null) && (e.NewValue != e.OldValue))
            {
                VisualState indeterminate = bar.GetIndeterminate();
                FrameworkElement templateChild = bar.GetTemplateChild("ContainingGrid") as FrameworkElement;
                if ((indeterminate != null) && (templateChild != null))
                {
                    if ((bool)e.NewValue)
                    {
                        indeterminate.Storyboard.Begin(templateChild, true);
                    }
                    else
                    {
                        indeterminate.Storyboard.Stop(templateChild);
                    }
                }
            }
        }

        private void ResetStoryboard(double width)
        {
            lock (this)
            {
                double num = this.CalcContainerAnimStart(width);
                double num2 = this.CalcContainerAnimEnd(width);
                double num3 = this.CalcEllipseAnimWell(width);
                double num4 = this.CalcEllipseAnimEnd(width);
                try
                {
                    VisualState indeterminate = this.GetIndeterminate();
                    if (indeterminate != null)
                    {
                        Storyboard storyboard = indeterminate.Storyboard.Clone();
                        Timeline timeline = storyboard.Children.First<Timeline>(t => t.Name == "MainDoubleAnim");
                        timeline.SetValue(DoubleAnimation.FromProperty, num);
                        timeline.SetValue(DoubleAnimation.ToProperty, num2);
                        string[] strArray3 = new string[] { "E1", "E2", "E3", "E4", "E5" };
                        for (int i = 0; i < strArray3.Length; i++)
                        {
                            DoubleKeyFrame frame;
                            DoubleKeyFrame frame2;
                            DoubleKeyFrame frame3;
                            Func<Timeline, bool> predicate = null;
                            string elemName = strArray3[i];
                            if (predicate == null)
                            {
                                predicate = t => t.Name == (elemName + "Anim");
                            }
                            DoubleAnimationUsingKeyFrames frames = (DoubleAnimationUsingKeyFrames)storyboard.Children.First<Timeline>(predicate);
                            if (elemName == "E1")
                            {
                                frame = frames.KeyFrames[1];
                                frame2 = frames.KeyFrames[2];
                                frame3 = frames.KeyFrames[3];
                            }
                            else
                            {
                                frame = frames.KeyFrames[2];
                                frame2 = frames.KeyFrames[3];
                                frame3 = frames.KeyFrames[4];
                            }
                            frame.Value = num3;
                            frame2.Value = num3;
                            frame3.Value = num4;
                            frame.InvalidateProperty(DoubleKeyFrame.ValueProperty);
                            frame2.InvalidateProperty(DoubleKeyFrame.ValueProperty);
                            frame3.InvalidateProperty(DoubleKeyFrame.ValueProperty);
                            frames.InvalidateProperty(Storyboard.TargetPropertyProperty);
                            frames.InvalidateProperty(Storyboard.TargetNameProperty);
                        }
                        indeterminate.Storyboard.Remove();
                        indeterminate.Storyboard = storyboard;
                        if (base.IsIndeterminate)
                        {
                            indeterminate.Storyboard.Begin((FrameworkElement)base.GetTemplateChild("ContainingGrid"), true);
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void SetEllipseDiameter(double width)
        {
            if (width <= 180.0)
            {
                this.EllipseDiameter = 4.0;
            }
            else if (width <= 280.0)
            {
                this.EllipseDiameter = 5.0;
            }
            else
            {
                this.EllipseDiameter = 6.0;
            }
        }

        private void SetEllipseOffset(double width)
        {
            if (width <= 180.0)
            {
                this.EllipseOffset = 4.0;
            }
            else if (width <= 280.0)
            {
                this.EllipseOffset = 7.0;
            }
            else
            {
                this.EllipseOffset = 9.0;
            }
        }

        private void SizeChangedHandler(object sender, SizeChangedEventArgs e)
        {
            double actualWidth = base.ActualWidth;
            this.ResetStoryboard(actualWidth);
        }

        public double EllipseDiameter
        {
            get
            {
                return (double)base.GetValue(EllipseDiameterProperty);
            }
            set
            {
                base.SetValue(EllipseDiameterProperty, value);
            }
        }

        public double EllipseOffset
        {
            get
            {
                return (double)base.GetValue(EllipseOffsetProperty);
            }
            set
            {
                base.SetValue(EllipseOffsetProperty, value);
            }
        }
    }
}
