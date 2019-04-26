using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Holds extension methods for <see cref="ListBox"/>.
    /// </summary>
    internal static class ListBoxExtensions
    {
        /// <summary>
        /// Adds given items to the <see cref="ListBox.SelectedItems"/> of the list box. If the items are already selected 
        /// they are not added. All other items from the current selection of the list are removed.
        /// </summary>
        /// <param name="listBox">The list box, which selected items will be changed.</param>
        /// <param name="items">The items to be selected.</param>
        internal static void SelectItems(this ListBox listBox, IEnumerable items)
        {
            if (items == null) throw new ArgumentNullException("items");

            var itemsToSelect = new List<object>(items.Cast<object>());

            // Remove unselected item from list box selection
            listBox.SelectedItems.RemoveAll(item => !itemsToSelect.Contains(item));

            // Remove already selected from selection
            Predicate<object> pred = new Predicate<object>(item => listBox.SelectedItems.Contains(item));

            itemsToSelect.RemoveAll(pred);


            foreach (object item in itemsToSelect)
            {
                if (!listBox.SelectedItems.Contains(item))
                {
                    listBox.SelectedItems.Add(item);
                }
            }
        }
    }
}