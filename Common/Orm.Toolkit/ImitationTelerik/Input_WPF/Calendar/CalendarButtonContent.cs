using System;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Calendar
{
	/// <summary>
	/// The content that each calendar button is assigned.
	/// </summary>
	public class CalendarButtonContent : INotifyPropertyChanged
	{
		private string text;
		private CalendarButtonType buttonType;
		private bool fromCurrentView;
		private bool selected;
		private bool anotherView;
		private DateTime date;
		private bool enabled = true;
		private WeakReference ownerReference;

		/// <summary>
		/// Occurs when a property value changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		//// Properties:

		/// <summary>
		/// Gets the type of the button.
		/// </summary>
		public CalendarButtonType ButtonType
		{
			get
			{
				return this.buttonType;
			}
			internal set
			{
				if (this.buttonType != value)
				{
					this.buttonType = value;
					this.OnPropertyChanged("ButtonType");
					if (this.HasOwner)
					{
						this.Owner.ButtonType = value;
					}
				}
			}
		}

		/// <summary>
		/// Gets or sets the text that gets displayed on the calendar.
		/// </summary>
		public string Text
		{
			get
			{
				return this.text;
			}
			set
			{
				if (this.text != value)
				{
					this.text = value;
					this.OnPropertyChanged("Text");
					if (this.HasOwner)
					{
						this.Owner.Text = value;
					}
				}
			}
		}

		/// <summary>
		/// Defines whther the element belongs to the current view (currently displayed month, year, decade or century).
		/// </summary>
		public bool IsFromCurrentView
		{
			get
			{
				return this.fromCurrentView;
			}
			set
			{
				if (this.fromCurrentView != value)
				{
					this.fromCurrentView = value;
					this.OnPropertyChanged("IsFromCurrentView");
					if (this.HasOwner)
					{
						this.Owner.IsFromCurrentView = value;
					}
				}
			}
		}

		/// <summary>
		/// Gets whether the button is initially selected.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				return this.selected;
			}
			set
			{
				if (this.selected != value)
				{
					this.selected = value;
					this.OnPropertyChanged("IsSelected");
					if (this.HasOwner)
					{
						this.Owner.IsSelected = value;
					}
				}
			}
		}

		/// <summary>
		/// Gets whether the button is initially visible.
		/// </summary>
		public bool IsInAnotherView
		{
			get
			{
				return this.anotherView;
			}
			set
			{
				if (this.anotherView != value)
				{
					this.anotherView = value;
					this.OnPropertyChanged("IsInAnotherView");
					if (this.HasOwner)
					{
						this.Owner.IsInAnotherView = value;
					}
				}
			}
		}

		/// <summary>
		///     Gets or sets date that the button displays.
		/// </summary>
		public DateTime Date
		{
			get
			{
				return this.date;
			}
			internal set
			{
				if (this.date != value)
				{
					this.date = value;
					this.OnPropertyChanged("Date");
				}
			}
		}

		/// <summary>
		///     Gets or sets whether the date can be selected.
		/// </summary>
		public bool IsEnabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled != value)
				{
					this.enabled = value;
					this.OnPropertyChanged("IsEnabled");
					if (this.HasOwner)
					{
						this.Owner.IsEnabled = value;
					}
				}
			}
		}

		internal CalendarButton Owner
		{
			get
			{
				if (this.ownerReference == null)
				{
					return null;
				}
				return (CalendarButton)this.ownerReference.Target;
			}
			set
			{
				this.ownerReference = new WeakReference(value);
			}
		}

		internal bool HasOwner
		{
			get
			{
				return this.Owner != null;
			}
		}

        /// <summary>
        /// Overrides ToString to support proper display if set as Content on ContentPresenter with ContentTemplate = null.
        /// </summary>
        /// <returns>Returns the value of the Text property.</returns>
        public override string ToString()
        {
            return this.Text;
        }

		private void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}