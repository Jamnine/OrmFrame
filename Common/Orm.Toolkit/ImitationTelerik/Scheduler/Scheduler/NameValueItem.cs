using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Name and value object useful for data binding operations.
    /// </summary>
    /// <typeparam name="T">Type of value.</typeparam>
    public class NameValueItem<T> : INotifyPropertyChanged
    {
        private readonly string name;
        private readonly T value;
        private bool isSelected;

        /// <summary>
        /// Initializes a new instance of the <see cref="NameValueItem{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        public NameValueItem(T value, string name) : this(value, name, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameValueItem{T}"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <param name="isSelected">Whether the item is selected.</param>
        public NameValueItem(T value, string name, bool isSelected)
        {
            this.value = value;
            this.name = name;
            this.isSelected = isSelected;
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance is selected; otherwise, <c>false</c>.
        /// </value>
        public bool IsSelected
        {
            get
            {
                return this.isSelected;
            }
            set
            {
                if (this.isSelected != value)
                {
                    this.isSelected = value;
                    this.OnPropertyChanged("IsSelected");
                }
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value
        {
            get
            {
                return this.value;
            }
        }

        /// <summary>
        /// Raises the property changed.
        /// </summary>
        /// <param name="propertyName">The name.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}