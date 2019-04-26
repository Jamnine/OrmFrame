using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Collection with categories.
    /// </summary>
    public class CategoryCollection : ObservableCollection<Category>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryCollection"/> class.
        /// </summary>
        public CategoryCollection()
            : base()
        {
        }

        /// <summary>
        /// Gets first category with the given name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public Category GetCategoryByName(string name)
        {
            foreach (Category cat in this)
            {
                if (cat.CategoryName == name)
                {
                    return cat;
                }
            }
            return null;
        }
    }
}
