using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit
{
    [TemplatePart(Name=TabView.ElementBrowser,Type=typeof(WebBrowser))]
    class TabView : Control
    {
        #region 常数

        public const String ElementBrowser = "PART_Browser";

        private const String JS_FAVICON = "(function(){ " +
           "links = document.getElementsByTagName('link'); " +
           "wHref = window.location.protocol + '//' + window.location.hostname + '/favicon.ico'; " +
           "for(i=0; i<links.length; i++){s=links[i].rel; if(s.indexOf('icon') != -1){ wHref = links[i].href }; }; " +
           "return wHref; })();";

        #endregion

        #region 全局变量

        private TabbedWebBrowser parentFrameworkElement;

        #endregion

        #region 构造函数

        static TabView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TabView),new PropertyMetadata(typeof(TabView)));
        }

        public TabView()
        {
            this.IsSelected = true;
        }

        internal TabView(TabbedWebBrowser parent,Uri url,bool isSourceView)
        {
            this.parentFrameworkElement = parent;
            this.IsSourceView = IsSourceView;
            this.Source = url;
        }

        internal TabView(TabbedWebBrowser parent,IntPtr nativeView)
        {
            this.parentFrameworkElement = parent;
            this.NativeView = nativeView;
        }

        #endregion

        #region 重写

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            this.SetValue(TabView.BrowserPropertyKey,GetTemplateChild(ElementBrowser));
            if (this.Browser == null)
                return;

            //监控一些重要的事件
            this.Browser.Loaded += OnBeginBrowser_Loaded;
            this.Browser.LoadCompleted += OnReadyBrowser_LoadCompleted;  

        }

        void OnReadyBrowser_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
           
        }

        void OnBeginBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        #endregion

        #region 全局变量

        #endregion


        #region 公共依赖属性

        #region IsSelected

        // This property is bound to the IsSelected property of the
        // WebTabItem that hosts us. It allows us to inform the parent
        // window of the currently selected tab, at any given time.
        // As the binding is a TwoWay binding, this also allows us
        // to update the selected tab from code.
        public bool IsSelected
        {
            get { return (bool)this.GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected",
            typeof(bool), typeof(TabView),
            new FrameworkPropertyMetadata(false, IsSelectedChanged));

        private static void IsSelectedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TabView owner = (TabView)d;
            bool value = (bool)e.NewValue;

            // We only update the parent window too, if we are in tab.
            //if (value && owner.IsRegularTab && (owner.ParentWindow != null))
            //    owner.ParentWindow.SelectedView = owner;
        }


        #endregion

        #region IsRegularTab
        // Indicates if this TabView is part of tab or of a popup window.
        // When in a popup window, we do not display the toolbox and address-box.
        public bool IsRegularTab
        {
            get { return (bool)this.GetValue(IsRegularTabProperty); }
            set { SetValue(IsRegularTabProperty, value); }
        }

        public static readonly DependencyProperty IsRegularTabProperty =
            DependencyProperty.Register("IsRegularTab",
            typeof(bool), typeof(TabView),
            new UIPropertyMetadata(true));

        #endregion

        #endregion


        #region Browser
        /// <summary>
        /// 这个网页控件在TabView中是一个模板
        /// </summary>
        public WebBrowser Browser
        {
            get { return (WebBrowser)this.GetValue( TabView.BrowserProperty);}
        }

        private static readonly DependencyPropertyKey BrowserPropertyKey =
      DependencyProperty.RegisterReadOnly("Browser",
      typeof(WebBrowser), typeof(TabView),
      new FrameworkPropertyMetadata(null));

      public static readonly DependencyProperty BrowserProperty =
            BrowserPropertyKey.DependencyProperty;

        #endregion

      #region 图标



      #endregion

      #region Source

      /// <summary>
      /// 网页控件的Source限制在这里
      /// </summary>
      public Uri Source
      {
          get { return this.GetValue(SourceProperty) as Uri; }
          set { SetValue(SourceProperty, value); }
      }

      public static readonly DependencyProperty SourceProperty =
          DependencyProperty.Register("Source",
          typeof(Uri), typeof(TabView),
          new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


        #endregion

        #region IsSourceView
        
      /// <summary>
      /// 是否表明这个标签是源视图
      /// </summary>
      public bool IsSourceView
      {
          get { return (bool)GetValue(IsSourceViewProperty); }
          internal set { SetValue(IsSourceViewPropertyKey, value); }
      }

      private static readonly DependencyPropertyKey IsSourceViewPropertyKey =
          DependencyProperty.RegisterReadOnly("IsSourceView",
          typeof(bool), typeof(TabView),
          new FrameworkPropertyMetadata(false));

      public static readonly DependencyProperty IsSourceViewProperty =
          IsSourceViewPropertyKey.DependencyProperty;

        #endregion

      #region NativeView
      // The WebControl's NativeView property is bound to this.
      // Used when the TabView hosts a created child view.
        /// <summary>
        /// 网页控件的NativeView属性被限制在这里
        /// 当用TabView创建一个子视图时使用。
        /// </summary>
      public IntPtr NativeView
      {
          get { return (IntPtr)this.GetValue(NativeViewProperty); }
          set { SetValue(NativeViewProperty, value); }
      }

      public static readonly DependencyProperty NativeViewProperty =
          DependencyProperty.Register("NativeView",
          typeof(IntPtr), typeof(TabView),
          new UIPropertyMetadata(IntPtr.Zero));
      #endregion
    }
}
