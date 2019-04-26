using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Orm.Toolkit.Metro;

namespace Orm.Toolkit
{
    [TemplatePart(Name = "PART_Header", Type = typeof(ContentPresenter)), TemplatePart(Name = "PART_BackButton", Type = typeof(Button))]
    public class Flyout : ContentControl
    {
        public static readonly DependencyProperty CloseCommandProperty = DependencyProperty.RegisterAttached("CloseCommand", typeof(ICommand), typeof(Flyout), new UIPropertyMetadata(null));
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register("Header", typeof(string), typeof(Flyout), new PropertyMetadata(null));
        public static readonly DependencyProperty HeaderTemplateProperty = DependencyProperty.Register("HeaderTemplate", typeof(DataTemplate), typeof(Flyout));
        public static readonly DependencyProperty IsModalProperty = DependencyProperty.Register("IsModal", typeof(bool), typeof(Flyout));
        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register("IsOpen", typeof(bool), typeof(Flyout), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(Flyout.IsOpenedChanged)));
        public static readonly DependencyProperty IsPinnableProperty = DependencyProperty.Register("IsPinnable", typeof(bool), typeof(Flyout), new PropertyMetadata(false));
        public static readonly DependencyProperty PositionProperty = DependencyProperty.Register("Position", typeof(Orm.Toolkit.Metro.Controls.Position), typeof(Flyout), new PropertyMetadata(Orm.Toolkit.Metro.Controls.Position.Left, new PropertyChangedCallback(Flyout.PositionChanged)));
        public static readonly DependencyProperty ThemeProperty = DependencyProperty.Register("Theme", typeof(Orm.Toolkit.Metro.Controls.FlyoutTheme), typeof(Flyout), new FrameworkPropertyMetadata(Orm.Toolkit.Metro.Controls.FlyoutTheme.Dark, new PropertyChangedCallback(Flyout.ThemeChanged)));

        public event EventHandler IsOpenChanged;

        static Flyout()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(Flyout), new FrameworkPropertyMetadata(typeof(Flyout)));
        }

        public Flyout():this(null)
        {
            RoutedEventHandler handler = null;
            if (handler == null)
            {
                handler = (sender, args) => this.UpdateFlyoutTheme();
            }
            base.Loaded += handler;
        }

        public Flyout(ICommand command)
        {
            this.CloseCommand = new RoutedCommand();
            base.CommandBindings.Add(new CommandBinding(this.CloseCommand,OnCloseCommandExecuted,OnCanExecuteCloseCommand));
        }

        #region Close Command

        void OnCanExecuteCloseCommand(object sender,CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        void OnCloseCommandExecuted(object sender,ExecutedRoutedEventArgs e)
        {
            this.IsOpen = false;
        }

        #endregion


        internal void ApplyAnimation(Orm.Toolkit.Metro.Controls.Position position)
        {
            Grid templateChild = (Grid)base.GetTemplateChild("root");
            if (templateChild != null)
            {
                EasingDoubleKeyFrame frame = (EasingDoubleKeyFrame)base.GetTemplateChild("hideFrame");
                EasingDoubleKeyFrame frame2 = (EasingDoubleKeyFrame)base.GetTemplateChild("hideFrameY");
                EasingDoubleKeyFrame frame3 = (EasingDoubleKeyFrame)base.GetTemplateChild("showFrame");
                EasingDoubleKeyFrame frame4 = (EasingDoubleKeyFrame)base.GetTemplateChild("showFrameY");
                if (((frame != null) && (frame3 != null)) && ((frame2 != null) && (frame4 != null)))
                {
                    if ((this.Position == Orm.Toolkit.Metro.Controls.Position.Left) || (this.Position == Orm.Toolkit.Metro.Controls.Position.Right))
                    {
                        frame3.Value = 0.0;
                    }
                    if ((this.Position == Orm.Toolkit.Metro.Controls.Position.Top) || (this.Position == Orm.Toolkit.Metro.Controls.Position.Bottom))
                    {
                        frame4.Value = 0.0;
                    }
                    templateChild.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                    switch (position)
                    {
                        case Orm.Toolkit.Metro.Controls.Position.Right:
                            base.HorizontalAlignment = HorizontalAlignment.Right;
                            base.VerticalAlignment = VerticalAlignment.Stretch;
                            frame.Value = templateChild.ActualWidth;
                            templateChild.RenderTransform = new TranslateTransform(templateChild.ActualWidth, 0.0);
                            return;

                        case Orm.Toolkit.Metro.Controls.Position.Top:
                            base.HorizontalAlignment = HorizontalAlignment.Stretch;
                            base.VerticalAlignment = VerticalAlignment.Top;
                            frame2.Value = -templateChild.ActualHeight - 1.0;
                            templateChild.RenderTransform = new TranslateTransform(0.0, -templateChild.ActualHeight - 1.0);
                            return;

                        case Orm.Toolkit.Metro.Controls.Position.Bottom:
                            base.HorizontalAlignment = HorizontalAlignment.Stretch;
                            base.VerticalAlignment = VerticalAlignment.Bottom;
                            frame2.Value = templateChild.ActualHeight;
                            templateChild.RenderTransform = new TranslateTransform(0.0, templateChild.ActualHeight);
                            return;
                    }
                    base.HorizontalAlignment = HorizontalAlignment.Left;
                    base.VerticalAlignment = VerticalAlignment.Stretch;
                    frame.Value = -templateChild.ActualWidth;
                    templateChild.RenderTransform = new TranslateTransform(-templateChild.ActualWidth, 0.0);
                }
            }
        }

        internal void ChangeFlyoutTheme(Accent windowAccent, Theme windowTheme)
        {
            switch (this.Theme)
            {
                case Orm.Toolkit.Metro.Controls.FlyoutTheme.Adapt:
                    ThemeManager.ChangeTheme(base.Resources, windowAccent, windowTheme);
                    switch (windowTheme)
                    {
                        case Orm.Toolkit.Metro.Theme.Light:
                            base.SetResourceReference(Control.ForegroundProperty, "BlackColorBrush");
                            base.SetResourceReference(Control.BackgroundProperty, "FlyoutLightBrush");
                            goto Label_00B8;

                        case Orm.Toolkit.Metro.Theme.Dark:
                            base.SetResourceReference(Control.ForegroundProperty, "BlackColorBrush");
                            base.SetResourceReference(Control.BackgroundProperty, "FlyoutDarkBrush");
                            goto Label_00B8;
                    }
                    break;

                case Orm.Toolkit.Metro.Controls.FlyoutTheme.Inverse:
                    switch (windowTheme)
                    {
                        case Orm.Toolkit.Metro.Theme.Light:
                            ThemeManager.ChangeTheme(base.Resources, windowAccent, Orm.Toolkit.Metro.Theme.Dark);
                            base.Background = (Brush)ThemeManager.LightResource["FlyoutDarkBrush"];
                            base.Foreground = (Brush)ThemeManager.LightResource["WhiteColorBrush"];
                            this.ActualTheme = Orm.Toolkit.Metro.Theme.Dark;
                            return;

                        case Orm.Toolkit.Metro.Theme.Dark:
                            ThemeManager.ChangeTheme(base.Resources, windowAccent, Orm.Toolkit.Metro.Theme.Light);
                            base.Background = (Brush)ThemeManager.DarkResource["FlyoutLightBrush"];
                            base.Foreground = (Brush)ThemeManager.DarkResource["WhiteColorBrush"];
                            this.ActualTheme = Orm.Toolkit.Metro.Theme.Light;
                            return;
                    }
                    return;

                case Orm.Toolkit.Metro.Controls.FlyoutTheme.Dark:
                    ThemeManager.ChangeTheme(base.Resources, windowAccent, Orm.Toolkit.Metro.Theme.Dark);
                    base.SetResourceReference(Control.BackgroundProperty, "FlyoutDarkBrush");
                    base.SetResourceReference(Control.ForegroundProperty, "BlackColorBrush");
                    this.ActualTheme = Orm.Toolkit.Metro.Theme.Dark;
                    return;

                case Orm.Toolkit.Metro.Controls.FlyoutTheme.Light:
                    ThemeManager.ChangeTheme(base.Resources, windowAccent, Orm.Toolkit.Metro.Theme.Light);
                    base.SetResourceReference(Control.BackgroundProperty, "FlyoutLightBrush");
                    base.SetResourceReference(Control.ForegroundProperty, "BlackColorBrush");
                    this.ActualTheme = Orm.Toolkit.Metro.Theme.Light;
                    return;

                case Orm.Toolkit.Metro.Controls.FlyoutTheme.Accent:
                    ThemeManager.ChangeTheme(base.Resources, windowAccent, windowTheme);
                    base.SetResourceReference(Control.BackgroundProperty, "HighlightBrush");
                    base.SetResourceReference(Control.ForegroundProperty, "IdealForegroundColorBrush");
                    this.ActualTheme = windowTheme;
                    return;

                default:
                    return;
            }
        Label_00B8:
            this.ActualTheme = windowTheme;
        }

        private static Tuple<Orm.Toolkit.Metro.Theme, Accent> DetectTheme(Flyout flyout)
        {
            if (flyout != null)
            {
                //MetroControl window = flyout.TryFindParent<MetroControl>();
                //Tuple<Orm.Toolkit.AutoMetroControl.Theme, Accent> tuple = (window != null) ? ThemeManager.DetectTheme(window) : null;
                //if ((tuple != null) && (tuple.Item2 != null))
                //{
                //    return tuple;
                //}
                //if (Application.Current != null)
                //{
                //    MetroControl mainWindow = Application.Current.MainWindow as MetroControl;
                //    tuple = (mainWindow != null) ? ThemeManager.DetectTheme(mainWindow) : null;
                //    if ((tuple != null) && (tuple.Item2 != null))
                //    {
                //        return tuple;
                //    }
                //    tuple = ThemeManager.DetectTheme(Application.Current);
                //    if ((tuple != null) && (tuple.Item2 != null))
                //    {
                //        return tuple;
                //    }
                //}
            }
            return null;
        }

        private static void IsOpenedChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            Flyout control = (Flyout)dependencyObject;
            VisualStateManager.GoToState(control, !((bool)e.NewValue) ? "Hide" : "Show", true);
            if (control.IsOpenChanged != null)
            {
                control.IsOpenChanged(control, EventArgs.Empty);
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.ApplyAnimation(this.Position);
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            if (sizeInfo.WidthChanged || sizeInfo.HeightChanged)
            {
                if (!this.IsOpen)
                {
                    this.ApplyAnimation(this.Position);
                }
                else
                {
                    Grid templateChild = (Grid)base.GetTemplateChild("root");
                    if (templateChild != null)
                    {
                        EasingDoubleKeyFrame frame = (EasingDoubleKeyFrame)base.GetTemplateChild("hideFrame");
                        EasingDoubleKeyFrame frame2 = (EasingDoubleKeyFrame)base.GetTemplateChild("hideFrameY");
                        EasingDoubleKeyFrame frame3 = (EasingDoubleKeyFrame)base.GetTemplateChild("showFrame");
                        EasingDoubleKeyFrame frame4 = (EasingDoubleKeyFrame)base.GetTemplateChild("showFrameY");
                        if (((frame != null) && (frame3 != null)) && ((frame2 != null) && (frame4 != null)))
                        {
                            if ((this.Position == Orm.Toolkit.Metro.Controls.Position.Left) || (this.Position == Orm.Toolkit.Metro.Controls.Position.Right))
                            {
                                frame3.Value = 0.0;
                            }
                            if ((this.Position == Orm.Toolkit.Metro.Controls.Position.Top) || (this.Position == Orm.Toolkit.Metro.Controls.Position.Bottom))
                            {
                                frame4.Value = 0.0;
                            }
                            switch (this.Position)
                            {
                                case Orm.Toolkit.Metro.Controls.Position.Right:
                                    frame.Value = templateChild.ActualWidth;
                                    return;

                                case Orm.Toolkit.Metro.Controls.Position.Top:
                                    frame2.Value = -templateChild.ActualHeight - 1.0;
                                    return;

                                case Orm.Toolkit.Metro.Controls.Position.Bottom:
                                    frame2.Value = templateChild.ActualHeight;
                                    return;
                            }
                            frame.Value = -templateChild.ActualWidth;
                        }
                    }
                }
            }
        }

        private static void PositionChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ((Flyout)dependencyObject).ApplyAnimation((Orm.Toolkit.Metro.Controls.Position)e.NewValue);
        }

        private static void ThemeChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ((Flyout)dependencyObject).UpdateFlyoutTheme();
        }

        private void UpdateFlyoutTheme()
        {
            if (this.TryFindParent<MetroControl>() != null)
            {
                Tuple<Orm.Toolkit.Metro.Theme, Accent> tuple = DetectTheme(this);
                if ((tuple != null) && (tuple.Item2 != null))
                {
                    Accent windowAccent = tuple.Item2;
                    this.ChangeFlyoutTheme(windowAccent, tuple.Item1);
                }
            }
        }

        internal Orm.Toolkit.Metro.Theme ActualTheme { get; private set; }

        public ICommand CloseCommand
        {
            get
            {
                return (ICommand)base.GetValue(CloseCommandProperty);
            }
            set
            {
                base.SetValue(CloseCommandProperty, value);
            }
        }

        public string Header
        {
            get
            {
                return (string)base.GetValue(HeaderProperty);
            }
            set
            {
                base.SetValue(HeaderProperty, value);
            }
        }

        public DataTemplate HeaderTemplate
        {
            get
            {
                return (DataTemplate)base.GetValue(HeaderTemplateProperty);
            }
            set
            {
                base.SetValue(HeaderTemplateProperty, value);
            }
        }

        public bool IsModal
        {
            get
            {
                return (bool)base.GetValue(IsModalProperty);
            }
            set
            {
                base.SetValue(IsModalProperty, value);
            }
        }

        public bool IsOpen
        {
            get
            {
                return (bool)base.GetValue(IsOpenProperty);
            }
            set
            {
                base.SetValue(IsOpenProperty, value);
            }
        }

        public bool IsPinnable
        {
            get
            {
                return (bool)base.GetValue(IsPinnableProperty);
            }
            set
            {
                base.SetValue(IsPinnableProperty, value);
            }
        }

        public Orm.Toolkit.Metro.Controls.Position Position
        {
            get
            {
                return (Orm.Toolkit.Metro.Controls.Position)base.GetValue(PositionProperty);
            }
            set
            {
                base.SetValue(PositionProperty, value);
            }
        }

        public Orm.Toolkit.Metro.Controls.FlyoutTheme Theme
        {
            get
            {
                return (Orm.Toolkit.Metro.Controls.FlyoutTheme)base.GetValue(ThemeProperty);
            }
            set
            {
                base.SetValue(ThemeProperty, value);
            }
        }
    }
}
