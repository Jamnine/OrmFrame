    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Interop;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;

namespace Orm.Toolkit
{
     [TemplatePart(Name = "PART_OverlayBox", Type = typeof(Grid)),TemplatePart(Name = "PART_FlyoutModal", Type = typeof(Rectangle))]
    public class MetroControl : ContentControl
    {
           private static readonly Type _selfType=typeof(MetroControl);
      
            private Rectangle flyoutModal;
            public static readonly DependencyProperty FlyoutsProperty = DependencyProperty.Register("Flyouts", typeof(FlyoutsControl), _selfType, new PropertyMetadata(null));
            public static readonly RoutedEvent FlyoutsStatusChangedEvent = EventManager.RegisterRoutedEvent("FlyoutsStatusChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), _selfType);
            public static readonly DependencyProperty GlowBrushProperty = DependencyProperty.Register("GlowBrush", typeof(SolidColorBrush),_selfType, new PropertyMetadata(null));
            //public static readonly DependencyProperty IgnoreTaskbarOnMaximizeProperty = DependencyProperty.Register("IgnoreTaskbarOnMaximize", typeof(bool), _selfType, new PropertyMetadata(false));
            //private bool isDragging;
            //internal Grid metroDialogContainer;
            internal Grid overlayBox;
            private Storyboard overlayStoryboard;
            //internal static readonly DependencyProperty OverrideDefaultWindowCommandsBrushProperty = DependencyProperty.Register("OverrideDefaultWindowCommandsBrush", typeof(SolidColorBrush), _selfType);
            private const string PART_FlyoutModal = "PART_FlyoutModal";
            //private const string PART_MetroDialogContainer = "PART_MetroDialogContainer";

            private const string PART_OverlayBox = "PART_OverlayBox";

            //private const string PART_TitleBar = "PART_TitleBar";

            //private const string PART_WindowButtonCommands = "PART_WindowButtonCommands";

            //private const string PART_WindowCommands = "PART_WindowCommands";

            //public static readonly DependencyProperty SaveWindowPositionProperty = DependencyProperty.Register("SaveWindowPosition", typeof(bool), _selfType, new PropertyMetadata(false));

            //public static readonly DependencyProperty ShowCloseButtonProperty = DependencyProperty.Register("ShowCloseButton", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty ShowIconOnTitleBarProperty = DependencyProperty.Register("ShowIconOnTitleBar", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty ShowMaxRestoreButtonProperty = DependencyProperty.Register("ShowMaxRestoreButton", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty ShowMinButtonProperty = DependencyProperty.Register("ShowMinButton", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty ShowTitleBarProperty = DependencyProperty.Register("ShowTitleBar", typeof(bool), _selfType, new PropertyMetadata(true, null, new CoerceValueCallback(MetroWindow.OnShowTitleBarCoerceValueCallback)));
         
        //public static readonly DependencyProperty ShowWindowCommandsOnTopProperty = DependencyProperty.Register("ShowWindowCommandsOnTop", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty TextBlockStyleProperty = DependencyProperty.Register("TextBlockStyle", typeof(Style), _selfType, new PropertyMetadata(null));

            //private UIElement titleBar;
            //public static readonly DependencyProperty TitlebarHeightProperty = DependencyProperty.Register("TitlebarHeight", typeof(int), _selfType, new PropertyMetadata(30));

            //public static readonly DependencyProperty TitleCapsProperty = DependencyProperty.Register("TitleCaps", typeof(bool), _selfType, new PropertyMetadata(true));

            //public static readonly DependencyProperty TitleForegroundProperty = DependencyProperty.Register("TitleForeground", typeof(Brush), _selfType);

            //public static readonly DependencyProperty UseNoneWindowStyleProperty = DependencyProperty.Register("UseNoneWindowStyle", typeof(bool), _selfType, new PropertyMetadata(false, new PropertyChangedCallback(MetroWindow.OnUseNoneWindowStylePropertyChangedCallback)));
            //internal MahApps.Metro.Controls.WindowButtonCommands WindowButtonCommands;
            //internal ContentPresenter WindowCommandsPresenter;
            //public static readonly DependencyProperty WindowPlacementSettingsProperty = DependencyProperty.Register("WindowPlacementSettings", typeof(IWindowPlacementSettings), _selfType, new PropertyMetadata(null));
          
          public static readonly DependencyProperty WindowTransitionsEnabledProperty = DependencyProperty.Register("WindowTransitionsEnabled", typeof(bool), _selfType, new PropertyMetadata(true));

            public event RoutedEventHandler FlyoutsStatusChanged
            {
                add
                {
                    base.AddHandler(FlyoutsStatusChangedEvent, value);
                }
                remove
                {
                    base.RemoveHandler(FlyoutsStatusChangedEvent, value);
                }
            }

            static MetroControl()
            {
                FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(_selfType, new FrameworkPropertyMetadata(_selfType));
            }

            public MetroControl()
            {
                base.Loaded += new RoutedEventHandler(this.MetroCotrol_Loaded);
                //if (this.MetroDialogOptions == null)
                //{
                //    this.MetroDialogOptions = new MetroDialogSettings();
                //}
            }

            internal T GetPart<T>(string name) where T : DependencyObject
            {
                return (T)base.GetTemplateChild(name);
            }

            internal void HandleFlyoutStatusChange(Flyout flyout, IEnumerable<Flyout> visibleFlyouts)
            {
                if ((flyout.Position == Orm.Toolkit.Metro.Controls.Position.Right) || (flyout.Position == Orm.Toolkit.Metro.Controls.Position.Top))
                {
                    int num = flyout.IsOpen ? (Panel.GetZIndex(flyout) + 3) : (visibleFlyouts.Count<Flyout>() + 2);
                    //this.WindowCommandsPresenter.SetValue(Panel.ZIndexProperty, this.ShowWindowCommandsOnTop ? num : ((num > 0) ? (num - 1) : 0));
                    //this.WindowButtonCommands.SetValue(Panel.ZIndexProperty, num);
                    //this.HandleWindowCommandsForFlyouts(visibleFlyouts, null);
                }
                this.flyoutModal.Visibility = visibleFlyouts.Any<Flyout>(x => x.IsModal) ? Visibility.Visible : Visibility.Hidden;
                FlyoutStatusChangedRoutedEventArgs e = new FlyoutStatusChangedRoutedEventArgs(FlyoutsStatusChangedEvent, this)
                {
                    ChangedFlyout = flyout
                };
                base.RaiseEvent(e);
            }

            public Task HideOverlayAsync()
            {
                if ((this.overlayBox.Visibility == Visibility.Visible) && (this.overlayBox.Opacity == 0.0))
                {
                    return new Task(delegate
                    {
                    });
                }
                base.Dispatcher.VerifyAccess();
                TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
                Storyboard sb = (Storyboard)base.Template.Resources["OverlayFastSemiFadeOut"];
                sb = sb.Clone();
                EventHandler completionHandler = null;
                completionHandler = delegate(object sender, EventArgs args)
                {
                    sb.Completed -= completionHandler;
                    if (this.overlayStoryboard == sb)
                    {
                        this.overlayBox.Visibility = Visibility.Hidden;
                        this.overlayStoryboard = null;
                    }
                    tcs.TrySetResult(null);
                };
                sb.Completed += completionHandler;
                this.overlayBox.BeginStoryboard(sb);
                this.overlayStoryboard = sb;
                return tcs.Task;
            }

            public bool IsOverlayVisible()
            {
                return ((this.overlayBox.Visibility == Visibility.Visible) && (this.overlayBox.Opacity >= 0.7));
            }

            private void MetroCotrol_Loaded(object sender, RoutedEventArgs e)
            {
                if (this.WindowTransitionsEnabled)
                {
                    VisualStateManager.GoToState(this, "AfterLoaded", true);
                }

                //if (!this.ShowTitleBar)
                //{
                //    IntPtr handle = new WindowInteropHelper(this).Handle;
                //    UnsafeNativeMethods.SetWindowLong(handle, -16, UnsafeNativeMethods.GetWindowLong(handle, -16) & -524289);
                //}

                //if (this.UseNoneWindowStyle)
                //{
                //    this.WindowCommandsPresenter.Visibility = Visibility.Collapsed;
                //    this.ShowMinButton = false;
                //    this.ShowMaxRestoreButton = false;
                //    this.ShowCloseButton = false;
                //}
                if (this.Flyouts == null)
                {
                    this.Flyouts = new FlyoutsControl();
                }
                //this.ResetAllWindowCommandsBrush();
                Orm.Toolkit.Metro.ThemeManager.IsThemeChanged += new EventHandler<Orm.Toolkit.Metro.OnThemeChangedEventArgs>(this.ThemeManagerOnIsThemeChanged);
                base.Unloaded += delegate(object o, RoutedEventArgs args)
                {
                    Orm.Toolkit.Metro.ThemeManager.IsThemeChanged -= new EventHandler<Orm.Toolkit.Metro.OnThemeChangedEventArgs>(this.ThemeManagerOnIsThemeChanged);
                };
            }

            public override void OnApplyTemplate()
            {
                base.OnApplyTemplate();

                this.overlayBox = base.GetTemplateChild(PART_OverlayBox) as Grid;
                this.flyoutModal = base.GetTemplateChild(PART_FlyoutModal) as Rectangle;

                //if ((this.TextBlockStyle != null) && !base.Resources.Contains(typeof(TextBlock)))
                //{
                //    base.Resources.Add(typeof(TextBlock), this.TextBlockStyle);
                //}
                //if (this.WindowCommands == null)
                //{
                //    this.WindowCommands = new MahApps.Metro.Controls.WindowCommands();
                //}
                //this.WindowCommandsPresenter = base.GetTemplateChild("PART_WindowCommands") as ContentPresenter;
                //this.WindowButtonCommands = base.GetTemplateChild("PART_WindowButtonCommands") as MahApps.Metro.Controls.WindowButtonCommands;
          
                //this.metroDialogContainer = base.GetTemplateChild("PART_MetroDialogContainer") as Grid;
          

                //this.titleBar = base.GetTemplateChild("PART_TitleBar") as UIElement;
                //if ((this.titleBar != null) && (this.titleBar.Visibility == Visibility.Visible))
                //{
                //    this.titleBar.MouseDown += new MouseButtonEventHandler(this.TitleBarMouseDown);
                //    this.titleBar.MouseUp += new MouseButtonEventHandler(this.TitleBarMouseUp);
                //    this.titleBar.MouseMove += new MouseEventHandler(this.TitleBarMouseMove);
                //}
                //else
                //{
                //    base.MouseDown += new MouseButtonEventHandler(this.TitleBarMouseDown);
                //    base.MouseUp += new MouseButtonEventHandler(this.TitleBarMouseUp);
                //    base.MouseMove += new MouseEventHandler(this.TitleBarMouseMove);
                //}
            }

            //private static object OnShowTitleBarCoerceValueCallback(DependencyObject d, object value)
            //{
            //    if (((MetroWindow)d).UseNoneWindowStyle)
            //    {
            //        return false;
            //    }
            //    return value;
            //}

            //protected override void OnStateChanged(EventArgs e)
            //{
            //    if (this.WindowButtonCommands != null)
            //    {
            //        this.WindowButtonCommands.RefreshMaximiseIconState();
            //    }
            //    base.OnStateChanged(e);
            //}

            //private static void OnUseNoneWindowStylePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
            //{
            //    if ((e.NewValue != e.OldValue) && ((bool)e.NewValue))
            //    {
            //        ((MetroWindow)d).ShowTitleBar = false;
            //    }
            //}

            public Task ShowOverlayAsync()
            {
                if (this.IsOverlayVisible() && (this.overlayStoryboard == null))
                {
                    return new Task(delegate
                    {
                    });
                }
                base.Dispatcher.VerifyAccess();
                this.overlayBox.Visibility = Visibility.Visible;
                TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
                Storyboard sb = (Storyboard)base.Template.Resources["OverlayFastSemiFadeIn"];
                sb = sb.Clone();
                EventHandler completionHandler = null;
                completionHandler = delegate(object sender, EventArgs args)
                {
                    sb.Completed -= completionHandler;
                    if (this.overlayStoryboard == sb)
                    {
                        this.overlayStoryboard = null;
                    }
                    tcs.TrySetResult(null);
                };
                sb.Completed += completionHandler;
                this.overlayBox.BeginStoryboard(sb);
                this.overlayStoryboard = sb;
                return tcs.Task;
            }

            //private static void ShowSystemMenuPhysicalCoordinates(Window window, Point physicalScreenLocation)
            //{
            //    if (window != null)
            //    {
            //        IntPtr handle = new WindowInteropHelper(window).Handle;
            //        if ((handle != IntPtr.Zero) && UnsafeNativeMethods.IsWindow(handle))
            //        {
            //            uint num = UnsafeNativeMethods.TrackPopupMenuEx(UnsafeNativeMethods.GetSystemMenu(handle, false), 0x100, (int)physicalScreenLocation.X, (int)physicalScreenLocation.Y, handle, IntPtr.Zero);
            //            if (num != 0)
            //            {
            //                UnsafeNativeMethods.PostMessage(handle, 0x112, new IntPtr((long)num), IntPtr.Zero);
            //            }
            //        }
            //    }
            //}

            private void ThemeManagerOnIsThemeChanged(object sender, Orm.Toolkit.Metro.OnThemeChangedEventArgs e)
            {
                if (e.Accent != null)
                {
                    List<Flyout> source = this.Flyouts.GetFlyouts().ToList<Flyout>();
                    if (source.Any<Flyout>())
                    {
                        foreach (Flyout flyout in source)
                        {
                            flyout.ChangeFlyoutTheme(e.Accent, e.Theme);
                        }
                        //this.HandleWindowCommandsForFlyouts(source, null);
                    }
                }
            }

            //protected void TitleBarMouseDown(object sender, MouseButtonEventArgs e)
            //{
            //    Point position = e.GetPosition(this);
            //    bool flag = (this.ShowIconOnTitleBar && (position.X <= this.TitlebarHeight)) && (position.Y <= this.TitlebarHeight);
            //    if (e.ChangedButton == MouseButton.Left)
            //    {
            //        if (flag)
            //        {
            //            if (e.ClickCount == 2)
            //            {
            //                base.Close();
            //            }
            //            else
            //            {
            //                ShowSystemMenuPhysicalCoordinates(this, base.PointToScreen(new Point(0.0, (double)this.TitlebarHeight)));
            //            }
            //        }
            //        else if (!this.UseNoneWindowStyle)
            //        {
            //            IntPtr handle = new WindowInteropHelper(this).Handle;
            //            UnsafeNativeMethods.ReleaseCapture();
            //            Point point = Mouse.GetPosition(this);
            //            Point point3 = base.PointToScreen(point);
            //            short num = Convert.ToInt16(point3.X);
            //            short num2 = Convert.ToInt16(point3.Y);
            //            int lParam = num | (num2 << 0x10);
            //            UnsafeNativeMethods.SendMessage(handle, 0xa1, 2, lParam);
            //            if (((e.ClickCount == 2) && ((base.ResizeMode == ResizeMode.CanResizeWithGrip) || (base.ResizeMode == ResizeMode.CanResize))) && (point.Y <= this.TitlebarHeight))
            //            {
            //                base.WindowState = (base.WindowState == WindowState.Maximized) ? WindowState.Normal : WindowState.Maximized;
            //            }
            //        }
            //    }
            //    else if (e.ChangedButton == MouseButton.Right)
            //    {
            //        ShowSystemMenuPhysicalCoordinates(this, base.PointToScreen(position));
            //    }
            //}

            //private void TitleBarMouseMove(object sender, MouseEventArgs e)
            //{
            //    if (e.LeftButton != MouseButtonState.Pressed)
            //    {
            //        this.isDragging = false;
            //    }
            //    if ((this.isDragging && (base.WindowState == WindowState.Maximized)) && (base.ResizeMode != ResizeMode.NoResize))
            //    {
            //        Point point = base.PointToScreen(Mouse.GetPosition(this));
            //        double width = base.RestoreBounds.Width;
            //        double num2 = point.X - (width / 2.0);
            //        if ((this.titleBar.Visibility == Visibility.Visible) || (point.Y <= this.TitlebarHeight))
            //        {
            //            double virtualScreenWidth = SystemParameters.VirtualScreenWidth;
            //            num2 = ((num2 + width) > virtualScreenWidth) ? (virtualScreenWidth - width) : num2;
            //            Point position = e.MouseDevice.GetPosition(this);
            //            base.Top = (position.Y < 5.0) ? -5.0 : (point.Y - position.Y);
            //            base.Left = num2;
            //            base.WindowState = WindowState.Normal;
            //        }
            //    }
            //}

            //protected void TitleBarMouseUp(object sender, MouseButtonEventArgs e)
            //{
            //    this.isDragging = false;
            //}

            public FlyoutsControl Flyouts
            {
                get
                {
                    return (FlyoutsControl)base.GetValue(FlyoutsProperty);
                }
                set
                {
                    base.SetValue(FlyoutsProperty, value);
                }
            }

            public SolidColorBrush GlowBrush
            {
                get
                {
                    return (SolidColorBrush)base.GetValue(GlowBrushProperty);
                }
                set
                {
                    base.SetValue(GlowBrushProperty, value);
                }
            }

            //public bool IgnoreTaskbarOnMaximize
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(IgnoreTaskbarOnMaximizeProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(IgnoreTaskbarOnMaximizeProperty, value);
            //    }
            //}

            //public MetroDialogSettings MetroDialogOptions { get; private set; }

            //internal SolidColorBrush OverrideDefaultWindowCommandsBrush
            //{
            //    get
            //    {
            //        return (SolidColorBrush)base.GetValue(OverrideDefaultWindowCommandsBrushProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(OverrideDefaultWindowCommandsBrushProperty, value);
            //    }
            //}

            //public bool SaveWindowPosition
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(SaveWindowPositionProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(SaveWindowPositionProperty, value);
            //    }
            //}

            //public bool ShowCloseButton
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowCloseButtonProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowCloseButtonProperty, value);
            //    }
            //}

            //public bool ShowIconOnTitleBar
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowIconOnTitleBarProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowIconOnTitleBarProperty, value);
            //    }
            //}

            //public bool ShowMaxRestoreButton
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowMaxRestoreButtonProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowMaxRestoreButtonProperty, value);
            //    }
            //}

            //public bool ShowMinButton
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowMinButtonProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowMinButtonProperty, value);
            //    }
            //}

            //public bool ShowTitleBar
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowTitleBarProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowTitleBarProperty, value);
            //    }
            //}

            //public bool ShowWindowCommandsOnTop
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(ShowWindowCommandsOnTopProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(ShowWindowCommandsOnTopProperty, value);
            //    }
            //}

            //public Style TextBlockStyle
            //{
            //    get
            //    {
            //        return (Style)base.GetValue(TextBlockStyleProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(TextBlockStyleProperty, value);
            //    }
            //}

            //public int TitlebarHeight
            //{
            //    get
            //    {
            //        return (int)base.GetValue(TitlebarHeightProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(TitlebarHeightProperty, value);
            //    }
            //}

            //public bool TitleCaps
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(TitleCapsProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(TitleCapsProperty, value);
            //    }
            //}

            //public Brush TitleForeground
            //{
            //    get
            //    {
            //        return (Brush)base.GetValue(TitleForegroundProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(TitleForegroundProperty, value);
            //    }
            //}

            //public bool UseNoneWindowStyle
            //{
            //    get
            //    {
            //        return (bool)base.GetValue(UseNoneWindowStyleProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(UseNoneWindowStyleProperty, value);
            //    }
            //}

            //public MahApps.Metro.Controls.WindowCommands WindowCommands { get; set; }

            //public IWindowPlacementSettings WindowPlacementSettings
            //{
            //    get
            //    {
            //        return (IWindowPlacementSettings)base.GetValue(WindowPlacementSettingsProperty);
            //    }
            //    set
            //    {
            //        base.SetValue(WindowPlacementSettingsProperty, value);
            //    }
            //}

            //public string WindowTitle
            //{
            //    get
            //    {
            //        if (!this.TitleCaps)
            //        {
            //            return base.Title;
            //        }
            //        return base.Title.ToUpper();
            //    }
            //}

            public bool WindowTransitionsEnabled
            {
                get
                {
                    return (bool)base.GetValue(WindowTransitionsEnabledProperty);
                }
                set
                {
                    base.SetValue(WindowTransitionsEnabledProperty, value);
                }
            }

            public class FlyoutStatusChangedRoutedEventArgs : RoutedEventArgs
            {
                internal FlyoutStatusChangedRoutedEventArgs(RoutedEvent rEvent, object source)
                    : base(rEvent, source)
                {
                }

                public Flyout ChangedFlyout { get; internal set; }
            }
        }

}
