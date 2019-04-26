using System;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Toolkit
{
    class WebTabItem : TabItem
    {
        #region 全局变量

        private readonly static Type selfType = typeof(WebTabItem);


        #endregion

        #region 构造函数

        static WebTabItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(selfType, new PropertyMetadata(selfType));
        }

        #endregion
    }
}
