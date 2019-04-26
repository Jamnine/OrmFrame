using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// The <see cref="DeferrableObservableCollection{T}"/> represents an <see cref="ObservableCollection{T}"/> supported deferring events during the massive collection changes.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    public class DeferrableObservableCollection<T> : ObservableCollection<T>
    {
        private int deferLevel;
        private bool shouldRiseChangeNotification;

        /// <summary>
        /// Gets a value that indicates whether there is an outstanding <see cref="DeferRefresh"/> in use. 
        /// </summary>
        /// <value>
        /// 	<c>True</c> if there is an outstanding <see cref="DeferRefresh"/> in use; otherwise, <c>false</c>.
        /// </value>
        protected internal bool IsRefreshDeferred
        {
            get
            {
                return this.deferLevel > 0;
            }
        }

        /// <summary>
        /// Enters a defer cycle that you can use to merge changes to the view and delay
        /// automatic refresh.
        /// </summary>
        /// <returns>
        /// An <see cref="IDisposable"/> object that you can use to dispose of the calling
        /// object and finish the defered refreshed.
        /// </returns>
        internal IDisposable DeferRefresh()
        {
            this.deferLevel++;
            return new DeferToken(this);
        }

        /// <summary>
        /// Ends the deferred refresh.
        /// </summary>
        internal void EndDefer()
        {
            this.deferLevel--;
            if (this.deferLevel == 0)
            {
                if (this.shouldRiseChangeNotification)
                {
                    this.OnEndDefer();
                }
                else
                {
                    this.shouldRiseChangeNotification = false;
                }
            }
        }

        /// <summary>
        /// Called by the base class to notify the derived class that all nested deferred refreshes are finished.
        /// </summary>
        protected virtual void OnEndDefer()
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs("Count"));
            this.OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        /// <summary>
        /// Raises the <see cref="System.Collections.ObjectModel.ObservableCollection{T}.CollectionChanged"/> event with the provided arguments.
        /// </summary>
        /// <param name="e">Arguments of the event being raised.</param>
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (!this.IsRefreshDeferred)
            {
                base.OnCollectionChanged(e);
            }
            else
            {
                this.shouldRiseChangeNotification = true;
            }
        }

        /// <summary>
        /// Raises the <see cref="System.Collections.ObjectModel.ObservableCollection{T}.PropertyChanged"/> event with the provided arguments.
        /// </summary>
        /// <param name="e">Arguments of the event being raised.</param>
        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (!this.IsRefreshDeferred)
            {
                base.OnPropertyChanged(e);
            }
            else
            {
                this.shouldRiseChangeNotification = true;
            }
        }

        private class DeferToken : IDisposable
        {
            private DeferrableObservableCollection<T> collection;

            internal DeferToken(DeferrableObservableCollection<T> collection)
            {
                this.collection = collection;
            }

            void IDisposable.Dispose()
            {
                if (this.collection != null)
                {
                    this.collection.EndDefer();
                    this.collection = null;
                }
            }
        }
    }
}