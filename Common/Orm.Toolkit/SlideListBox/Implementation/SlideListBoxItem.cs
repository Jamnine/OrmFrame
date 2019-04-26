using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Orm.Toolkit
{

    public class SlideListBoxItem : ListBoxItem
    {
        #region 构造函数

        static SlideListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SlideListBoxItem), new FrameworkPropertyMetadata(typeof(SlideListBoxItem)));
        }

        #endregion

        #region 属性

        /// <summary>
        /// 判断是否已经按下鼠标
        /// </summary>
        private bool IsMouseDown { get; set; }

        #endregion

        #region 重写事件

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            IsMouseDown = true;
            e.Handled = true;
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            if (IsMouseDown)
            {
                this.IsSelected = !this.IsSelected;
            }
            IsMouseDown = false;
            base.OnMouseUp(e);
        }

        #endregion
    }
}
