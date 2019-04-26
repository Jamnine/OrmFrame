using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace Orm.Toolkit.Metro
{
    public static class TreeHelper
    {
        public static T TryFindParent<T>(this DependencyObject child) where T : DependencyObject
        {
            DependencyObject parentObject = child.GetParentObject();
            if (parentObject == null)
            {
                return default(T);
            }
            T local = parentObject as T;
            if (local != null)
            {
                return local;
            }
            return parentObject.TryFindParent<T>();
        }

        public static DependencyObject GetParentObject(this DependencyObject child)
        {
            if (child == null)
            {
                return null;
            }
            ContentElement reference = child as ContentElement;
            if (reference != null)
            {
                DependencyObject parent = ContentOperations.GetParent(reference);
                if (parent != null)
                {
                    return parent;
                }
                FrameworkContentElement element2 = reference as FrameworkContentElement;
                if (element2 == null)
                {
                    return null;
                }
                return element2.Parent;
            }
            FrameworkElement element3 = child as FrameworkElement;
            if (element3 != null)
            {
                DependencyObject obj3 = element3.Parent;
                if (obj3 != null)
                {
                    return obj3;
                }
            }
            return VisualTreeHelper.GetParent(child);
        }
    }
}
