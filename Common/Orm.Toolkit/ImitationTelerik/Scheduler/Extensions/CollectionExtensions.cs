using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Holds extension methods for <see cref="ICollection{T}"/>.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds the elements from the specified collection - <paramref name="items"/> to the end of the target <paramref name="collection"/>.
        /// </summary>
        /// <param name="collection">The collection that will be extended.</param>
        /// <param name="items">The items that will be added.</param>
        /// <exception cref="ArgumentNullException"><paramref name="items"/> is null</exception>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            if (items == null) throw new ArgumentNullException("items");

            items.ForEach(item => collection.Add(item));
        }

        /// <summary>
        /// Adds the elements from the specified collection - <paramref name="items"/> to the end of the target <paramref name="list"/>.
        /// </summary>
        /// <param name="list">The list that will be extended.</param>
        /// <param name="items">The items that will be added.</param>
        /// <exception cref="ArgumentNullException"><paramref name="items"/> is null</exception>
        public static void AddRange(this IList list, IEnumerable items)
        {
            if (items == null) throw new ArgumentNullException("items");

            foreach (object item in items)
            {
                list.Add(item);
            }
        }

        /// <summary>
        /// Adds the elements from the specified collection - <paramref name="items"/> to the end of the target <paramref name="list"/>.
        /// </summary>
        /// <param name="list">The list that will be extended.</param>
        /// <param name="items">The items that will be added.</param>
        /// <exception cref="ArgumentNullException"><paramref name="items"/> is null</exception>
        public static void AddRange(this ItemCollection list, IEnumerable items)
        {
            if (items == null) throw new ArgumentNullException("items");

            foreach (object item in items)
            {
                list.Add(item);
            }
        }

        /// <summary>
        /// Removes all elements from a collection that match the condition defined by the specified predicate.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <param name="collection">The collection, which elements will be removed.</param>
        /// <param name="match">The predicate delegate that defines the condition for the removed elements.</param>
        /// <returns>Number of removed elements.</returns>
        public static int RemoveAll<T>(this ICollection<T> collection, Predicate<T> match)
        {
            List<T> removed =
                (from item in collection
                 where match(item)
                 select item).ToList();

            foreach (T item in removed)
            {
                collection.Remove(item);
            }

            return removed.Count;
        }

        /// <summary>
        /// Removes all elements from the given collection.
        /// </summary>
        /// <typeparam name="T">Elements type.</typeparam>
        /// <param name="collection">The collection, which will be emptied.</param>
        public static void RemoveAll<T>(this IList<T> collection)
        {
            while (collection.Count != 0)
            {
                collection.RemoveAt(0);
            }
        }

        /// <summary>
        /// Removes all elements from a list that match the condition defined by the specified predicate.
        /// </summary>
        /// <param name="list">The list, which elements will be removed.</param>
        /// <param name="match">The predicate delegate that defines the condition for the removed elements.</param>
        /// <returns>Number of removed elements.</returns>
        public static int RemoveAll(this IList list, Predicate<object> match)
        {
            var removed = new List<object>();
            foreach (object item in list)
            {
                if (match(item))
                {
                    removed.Add(item);
                }
            }

            foreach (object item in removed)
            {
                list.Remove(item);
            }

            return removed.Count;
        }

        /// <summary>
        /// Performs the specified action on each element of the collection.
        /// </summary>
        /// <typeparam name="T">Type of the elements in the collection.</typeparam>
        /// <param name="source">The collection on which elements the action will be executed.</param>
        /// <param name="action">The <see cref="Action{T}"/> delegate to perform on each element of the collection.</param>
        internal static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T item in source)
            {
                action(item);
            }
        }
    }
}