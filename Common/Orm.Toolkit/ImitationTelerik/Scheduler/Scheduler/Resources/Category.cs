using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// A Category class.
    /// </summary>
    public class Category : INotifyPropertyChanged
    {
        private bool isChecked;
        private string displayName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="brush">The brush.</param>
        public Category(string name, Brush brush)
        {
            this.CategoryName = name;
            this.CategoryBrush = brush;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>The name of the category.</value>
        public string CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the category brush.
        /// </summary>
        /// <value>The category brush.</value>
        public Brush CategoryBrush
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>The name of the category.</value>
        public string DisplayName
        {
            get
            {
                if (String.IsNullOrEmpty(this.displayName))
                {
                    return this.CategoryName;
                }
                return this.displayName;
            }

            set
            {
                if (this.displayName != value)
                {
                    this.displayName = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is checked.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is checked; otherwise, <c>false</c>.
        /// </value>
        public bool IsChecked
        {
            get
            {
                return this.isChecked;
            }
            set
            {
                if (value != this.isChecked)
                {
                    this.isChecked = value;
                    this.OnPropertyChanged("IsChecked");
                }
            }
        }

		/// <summary>
		/// Returns a hash code for the Category instance.
		/// </summary>
		public override int GetHashCode()
		{
			return this.CategoryBrush.GetHashCode() ^ this.CategoryName.GetHashCode() ^ this.DisplayName.GetHashCode();
		}

		/// <summary>
		/// Determines whether the specified object equals this Category. 
		/// </summary>
		/// <param name="obj"></param>
		public override bool Equals(object obj)
		{
			if (obj is Category)
			{
				Category category = (Category)obj;
				return this.CategoryBrush.Equals(category.CategoryBrush) && (this.CategoryName == category.CategoryName) && (this.DisplayName == category.DisplayName);
			}
			return false;
		}

        /// <summary>
        /// Called when some property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
