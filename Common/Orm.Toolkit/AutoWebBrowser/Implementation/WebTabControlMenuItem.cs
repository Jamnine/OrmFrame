using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.AutoWebBrowser.Implementation
{
    class WebTabControlMenuItem : MenuItem
    {
        #region 全局变量

        private readonly static Type selfType = typeof(WebTabControlMenuItem);

        #endregion

        #region 构造函数

        static WebTabControlMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(selfType,new PropertyMetadata(selfType));
        }

        #endregion

        #region 重载

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            // This is needed to avoid the:
            // System.Windows.Data Error: 26 : ItemTemplate and ItemTemplateSelector are ignored for items already of the ItemsControl's container type;
            // This error occurs because the items we try to add to the ItemsControl are already UIElements, therefore, they do not
            // need a DataTemplate to be visualized. In such cases, the ItemsControl ignores the DataTemplate defined in ItemTemplate.
            // In our case, we feed this ItemsControl with TabViews. We do not want these to be removed from the visual tree and added in the popup
            // (which is what would happen without this override)! We want our ItemTemplate to be respected.
            return false;
            //return base.IsItemItsOwnContainerOverride(item);
        }

        #endregion

        #region 公共依赖属性

        /// <summary>
        /// 头区域字体颜色
        /// </summary>
        public Brush HeaderForeground
        {
            get { return (Brush)GetValue(HeaderForegroundProperty); }
            set { SetValue(HeaderForegroundProperty, value); }
        }

        /// <summary>
        /// Identifies the <see cref="HeaderForeground"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.Register("HeaderForeground",
            typeof(Brush),selfType,
            new FrameworkPropertyMetadata(Brushes.White));    

        #endregion

    }
}
