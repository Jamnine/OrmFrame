using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace Orm.Toolkit
{
    class WebTabControl : TabControl
    {

        #region 全局变量


        private readonly static Type selfType = typeof(WebTabControl);

        #endregion

        #region 领域
        /// <summary>
        /// 判断TabItem集合是否改变的状态
        /// </summary>
        private bool collectionChanging;

        #endregion

        #region 构造函数

        static WebTabControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(selfType, new PropertyMetadata(selfType));
        }

        #endregion

        #region 重载

        protected override System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
        {
            // This is overridden so that we can have a better profiling image of the
            // sample's performance. TabControlAutomationPeer keeps weak references
            // to all tabs and their content (WebControl in our case).
            // If you require the AutomationPeer to build a proper automation tree
            // for accessibility or testing purposes, remove this override.
            return null;
            //return base.OnCreateAutomationPeer();
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            collectionChanging = true;
            base.OnItemsChanged(e);
            collectionChanging = false;

            if ((e.NewItems != null) && (e.NewItems.Count > 0))
            {
                TabView view = (TabView)e.NewItems[0];
                this.SelectedItem = view;

                if (!view.IsLoaded)
                {
                    RoutedEventHandler loaded = null;
                    loaded = (sender, ea) =>
                    {
                        view.Loaded -= loaded;
                        this.InvalidateMeasure();
                    };

                    view.Loaded += loaded;
                }
            }

            this.InvalidateMeasure();

            //base.OnItemsChanged(e);
        }

        /// <summary>
        /// 重新测量控件
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size constraint)
        {
            Size size = base.MeasureOverride(constraint);

            if (constraint.Width <= 0)
                return size;

            double totalWidth = this.Items.Count * 180;
            double rightPadding = this.TabPanelRightPadding;
            double finalWidth = 180;

            if (totalWidth > (constraint.Width - rightPadding))
                finalWidth = (constraint.Width - rightPadding) / this.Items.Count;

            foreach (TabView item in this.Items)
            {
                TabItem container = this.ItemContainerGenerator.ContainerFromItem(item) as TabItem;

                if ((container != null) && (container.ActualWidth > 0))
                    container.Width = finalWidth;
            }

            return size;

            //return base.MeasureOverride(constraint);
        }
        /// <summary>
        /// 标识或创建指定显示的控件
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new WebTabItem();
            //return base.GetContainerForItemOverride();
        }

        /// <summary>
        /// 确定指定的Item是否可以作为自己的ItemContainer
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is WebTabItem;
            //return base.IsItemItsOwnContainerOverride(item);
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);

            // Prevent the TabControl from staying with no selected item.
            // This can occur is we try to un-select the selected tab from code,
            // or by clicking it in the tabs menu.
            if (!collectionChanging && (this.Items.Count > 0) && (e.AddedItems.Count == 0) && (this.SelectedIndex < 0))
                ((TabView)this.Items[0]).IsSelected = true;
        }

        #endregion

        #region 依赖属性


        public double TabPanelRightPadding
        {
            get { return (double)GetValue(TabPanelRightPaddingProperty); }
            set { SetValue(TabPanelRightPaddingProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="TabPanelRightPadding"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TabPanelRightPaddingProperty =
            DependencyProperty.Register("TabPanelRightPadding",
            typeof(double), selfType,
            new FrameworkPropertyMetadata(180.0, TabPanelRightPaddingChanged));

        private static void TabPanelRightPaddingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WebTabControl owner = (WebTabControl)d;
            double value = (double)e.NewValue;

            // Add handling.
            owner.InvalidateMeasure();
        }

        #endregion



    }
}
