using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Orm.Toolkit
{
    public class PathListBoxItem : System.Windows.Controls.ListBoxItem
    {
        public PathListBoxItem()
        { 
           // System.Windows.Controls.Button
        }

        static PathListBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PathListBoxItem), new FrameworkPropertyMetadata(typeof(PathListBoxItem)));
        }

        #region 依赖属性

        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(PathListBoxItem));
        public static readonly DependencyProperty ClickModeProperty = DependencyProperty.Register("ClickMode", typeof(System.Windows.Controls.ClickMode), typeof(PathListBoxItem), new FrameworkPropertyMetadata(System.Windows.Controls.ClickMode.Release), new ValidateValueCallback(PathListBoxItem.IsValidClickMode));

        [CommonDependencyProperty]
        public static readonly DependencyProperty IsPressedProperty = IsPressedPropertyKey.DependencyProperty;
        internal static readonly DependencyPropertyKey IsPressedPropertyKey = DependencyProperty.RegisterReadOnly("IsPressed", typeof(bool), typeof(PathListBoxItem), new FrameworkPropertyMetadata(BooleanBoxes.FalseBox, new PropertyChangedCallback(PathListBoxItem.OnIsPressedChanged)));
        
        #endregion

        #region 辅助方法

        private static bool IsValidClickMode(object o)
        {
            System.Windows.Controls.ClickMode mode = (System.Windows.Controls.ClickMode)o;
            if ((mode != System.Windows.Controls.ClickMode.Press) && (mode != System.Windows.Controls.ClickMode.Release))
            {
                return (mode == System.Windows.Controls.ClickMode.Hover);
            }
            return true;
        }


        private static void OnIsPressedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((PathListBoxItem)d).OnIsPressedChanged(e);
        }

        protected virtual void OnIsPressedChanged(DependencyPropertyChangedEventArgs e)
        {
            //System.Windows.Controls.Control.OnVisualStatePropertyChanged(this, e);
        }

        #endregion



        public Style PathStyle { get { return (Style)GetValue(PathStyleProperty); } set { SetValue(PathStyleProperty, value); } }

        public static readonly DependencyProperty PathStyleProperty = DependencyProperty.Register("PathStyle", typeof(Style), typeof(PathListBoxItem), null);

        public string Text { get { return (string)GetValue(TextProperty); } set { SetValue(TextProperty, value); } }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(PathListBoxItem), null);

        public int MessageCount { get { return (int)GetValue(MessageCountProperty); } set { SetValue(MessageCountProperty, value); } }

        public static readonly DependencyProperty MessageCountProperty = DependencyProperty.Register("MessageCount", typeof(int), typeof(PathListBoxItem), null);

    }

    internal static class BooleanBoxes
    {
        internal static object FalseBox = false;
        internal static object TrueBox = true;

        internal static object Box(bool value)
        {
            if (value)
            {
                return TrueBox;
            }
            return FalseBox;
        }
    }
}
