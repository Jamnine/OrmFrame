using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Orm.Client.Common
{
    /// <summary>
    /// 控件操作类
    /// Add By Ben  2014-12-16
    /// </summary>
    public class ControlHelper
    {
        /// <summary>
        /// 筛选需要的Visual子控件
        /// </summary>
        /// <param name="element"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<Visual> GetDescendantByType(Visual element, Type type)
        {
            if (element == null) return null;
            List<Visual> lstElement = new List<Visual>();
            if (element is FrameworkElement)
                (element as FrameworkElement).ApplyTemplate();
            int cnt = VisualTreeHelper.GetChildrenCount(element);
            for (int i = 0; i < cnt; i++)
            {
                Visual visual = VisualTreeHelper.GetChild(element, i) as Visual;
                if (visual.GetType() == type || visual.GetType().BaseType == type)
                {
                    lstElement.Add(visual);
                }
            }
            return lstElement;
        }

        public static List<Visual> GetChildObjects(Visual element, Type type)
        {
            if (element == null) return null;
            List<Visual> lstElement = new List<Visual>();
            if (element is FrameworkElement)
                (element as FrameworkElement).ApplyTemplate();
            int cnt = VisualTreeHelper.GetChildrenCount(element);
            for (int i = 0; i < cnt; i++)
            {
                Visual visual = VisualTreeHelper.GetChild(element, i) as Visual;
                if (visual.GetType() == type || visual.GetType().BaseType == type)
                {
                    lstElement.Add(visual);
                }
                else
                {
                    lstElement.AddRange(GetChildObjects(visual, type));
                }
            }
            return lstElement;
        }


        public static List<T> GetChildObjects<T>(DependencyObject obj, Type typename) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();
            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);

                if (child is T && (((T)child).GetType() == typename))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, typename));
            }
            return childList;
        }
    }
}
