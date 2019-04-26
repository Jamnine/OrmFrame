using System;

using System.Windows;


namespace Orm.Toolkit.Telerik.Windows.Controls
{
	internal delegate void RadRoutedPropertyChangedEventHandler<T>(object sender, RadRoutedPropertyChangedEventArgs<T> e);

	internal class RadRoutedPropertyChangedEventArgs<T> : RadRoutedEventArgs
	{
		// Fields
		private T newValue;
		private T oldValue;

		// Methods
		public RadRoutedPropertyChangedEventArgs(T oldValue, T newValue)
		{
			this.oldValue = oldValue;
			this.newValue = newValue;
		}

		public RadRoutedPropertyChangedEventArgs(T oldValue, T newValue, RoutedEvent routedEvent)
			: this(oldValue, newValue)
		{
			this.RoutedEvent = routedEvent;
		}

		// Properties
		public T NewValue
		{
			get
			{
				return this.newValue;
			}
		}

		public T OldValue
		{
			get
			{
				return this.oldValue;
			}
		}

		protected override void InvokeEventHandler(Delegate genericHandler, object genericTarget)
		{
			RadRoutedPropertyChangedEventHandler<T> handler = (RadRoutedPropertyChangedEventHandler<T>)genericHandler;
			handler(genericTarget, (RadRoutedPropertyChangedEventArgs<T>)this);
		}
	}
}