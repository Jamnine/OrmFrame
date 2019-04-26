using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Holds extension methods for <see cref="DependencyObject"/> class.
    /// </summary>
    public static class DependencyObjectExtensions
    {
        /// <summary>
        /// Searches up in the visual tree for parent element of the specified type.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the parent that will be searched up in the visual object hierarchy. 
        /// The type should be <see cref="DependencyObject"/>.
        /// </typeparam>
        /// <param name="dependencyObject">The target <see cref="DependencyObject"/> which visual parents will be traversed.</param>
        /// <returns>Visual parent of the specified type if there is any, otherwise null.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public static T GetVisualParent<T>(this DependencyObject dependencyObject) where T : DependencyObject
        {
            return dependencyObject.GetVisualParent<T>(false);
        }

        /// <summary>
        /// Finds child element of the specified type. Uses breadth-first search.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the child that will be searched in the object hierarchy. The type should be <see cref="DependencyObject"/>.
        /// </typeparam>
        /// <param name="source">The target <see cref="DependencyObject"/> which children will be traversed.</param>
        /// <returns>The first child element that is of the specified type.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
        public static T FindChildByType<T>(this DependencyObject source) where T : DependencyObject
        {
            return FindChildrenByType<T>(source).FirstOrDefault();
        }

        internal static IEnumerable<T> FindChildrenByType<T>(this DependencyObject source) where T : DependencyObject
        {
            var itemsToProcess = new Queue<DependencyObject>();
            itemsToProcess.Enqueue(source);
            while (itemsToProcess.Count > 0)
            {
                DependencyObject item = itemsToProcess.Dequeue();
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(item); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(item, i);

                    var typedChild = child as T;
                    if (typedChild != null)
                    {
                        yield return typedChild;
                    }

                    itemsToProcess.Enqueue(child);
                }
            }
            yield break;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        internal static bool Focus(this DependencyObject dependencyObject)
        {

            FrameworkElement element = dependencyObject as FrameworkElement;
            if (element != null)
                return element.Focus();

            FrameworkContentElement contentElement = dependencyObject as FrameworkContentElement;
            if (contentElement != null)
                return contentElement.Focus();

            if (dependencyObject is Control)
            {
                return ((Control)dependencyObject).Focus();
            }

            return false;
        }


        internal static void SetReadOnlyValue(this DependencyObject element, DependencyPropertyKey key, object value)
        {
            element.SetValue(key, value);
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        internal static TParent GetVisualParent<TParent>(this DependencyObject dependencyObject, bool includeSelf) where TParent : DependencyObject
        {
            if (includeSelf && dependencyObject is TParent)
            {
                return dependencyObject as TParent;
            }

            return dependencyObject.GetVisualParent<TParent, TParent>();
        }

        internal static TParent GetVisualParent<TParent, TRestriction>(this DependencyObject dependencyObject) where TParent : DependencyObject
        {
            DependencyObject parent = null;

            if (dependencyObject != null)
                parent = VisualTreeHelper.GetParent(dependencyObject);

            while ((parent != null) && !(parent is TParent && parent is TRestriction))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            return (TParent)parent;
        }
    }
}