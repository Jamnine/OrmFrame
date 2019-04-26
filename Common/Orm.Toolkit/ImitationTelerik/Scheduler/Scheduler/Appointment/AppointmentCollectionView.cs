using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
//using Orm.Toolkit.Telerik.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// This class is a view over the appointment to which the <see cref="RadScheduler"/> is bound.
    /// </summary>
    public sealed partial class AppointmentCollectionView : ICollection<IAppointment>,
                                                            IAppointmentFactory,
                                                            INotifyCollectionChanged,
															IList,

 IWeakEventListener
    {
        private readonly ObservableCollection<IAppointment> allDayAppointments;
        private readonly ReadOnlyAppointmentCollection allDayAppointmentsReadOnly;
        private readonly ObservableCollection<IAppointment> notAllDayAppointments;
        private readonly ReadOnlyAppointmentCollection notAllDayAppointmentsReadOnly;

        private ConstructorInfo itemConstructorInfo;
        private IEnumerable originalCollection;
        private IList sourceCollection;


		
		/// <summary>
        /// Initializes a new instance of the <see cref="AppointmentCollectionView"/> class.
        /// </summary>
        public AppointmentCollectionView()
        {
            this.allDayAppointments = new ObservableCollection<IAppointment>();
            this.allDayAppointmentsReadOnly = new ReadOnlyAppointmentCollection(this.allDayAppointments);

            this.notAllDayAppointments = new ObservableCollection<IAppointment>();
            this.notAllDayAppointmentsReadOnly = new ReadOnlyAppointmentCollection(this.notAllDayAppointments);
        }

        /// <summary>
        /// Occurs when the collection changes.
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Get read only collection of all day appointments.
        /// </summary>
        public ReadOnlyAppointmentCollection AllDayAppointmentsView
        {
            get
            {
                return this.allDayAppointmentsReadOnly;
            }
        }

        /// <summary>
        /// Gets the appointments source.
        /// </summary>
        /// <value>The appointments source.</value>
        public IList AppointmentsSource
        {
            get
            {
                this.EnsureSourceCollection();
                return this.sourceCollection;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance can create new appointment.
        /// </summary>
        /// <value>
        /// 	<c>True</c> if this instance can create new appointment; otherwise, <c>false</c>.
        /// </value>
        public bool CanCreateNewAppointment
        {
            get
            {
                this.EnsureSourceCollection();
                return this.OriginalCollectionAsAppointmentFactory != null || this.itemConstructorInfo != null;
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the <see cref="ICollection{T}"/>.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// The number of elements contained in the <see cref="ICollection{T}"/>.
        /// </returns>
        public int Count
        {
            get
            {
                if (this.sourceCollection != null)
                {
                    return this.sourceCollection.Count;
                }
                return 0;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="IList"/> has a fixed size.
        /// </summary>
        /// <value></value>
        /// <returns>true if the <see cref="IList"/> has a fixed size; otherwise, false.
        /// </returns>
        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the <see cref="ICollection{T}"/> is read-only.
        /// </summary>
        /// <value></value>
        /// <returns>true if the <see cref="ICollection{T}"/> is read-only; otherwise, false.
        /// </returns>
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="ICollection"/> is synchronized (thread safe).
        /// </summary>
        /// <value></value>
        /// <returns>true if access to the <see cref="ICollection"/> is synchronized (thread safe); otherwise, false.
        /// </returns>
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Get read only collection of not all day appointments.
        /// </summary>
        public ReadOnlyAppointmentCollection NotAllDayAppointmentsView
        {
            get
            {
                return this.notAllDayAppointmentsReadOnly;
            }
        }

        /// <summary>
        /// Gets an object that can be used to synchronize access to the <see cref="ICollection"/>.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// An object that can be used to synchronize access to the <see cref="ICollection"/>.
        /// </returns>
        public object SyncRoot
        {
            get
            {
                this.EnsureSourceCollection();
                return this.sourceCollection.SyncRoot;
            }
        }

        private IAppointmentFactory OriginalCollectionAsAppointmentFactory
        {
            get
            {
                return this.originalCollection as IAppointmentFactory;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="Object"/> at the specified index.
        /// </summary>
        /// <value></value>
        public object this[int index]
        {
            get
            {
                this.EnsureSourceCollection();
                return this.sourceCollection[index];
            }
            set
            {
                this.EnsureSourceCollection();
                this.sourceCollection[index] = value;
            }
        }

        /// <summary>
        /// Adds an item to the <see cref="ICollection{T}"/>.
        /// </summary>
        /// <param name="item">The object to add to the <see cref="ICollection{T}"/>.</param>
        /// <exception cref="NotSupportedException">
        /// The <see cref="ICollection{T}"/> is read-only.
        /// </exception>
        public void Add(IAppointment item)
        {
            this.EnsureSourceCollection();
            this.sourceCollection.Add(item);
        }

        /// <summary>
        /// Removes all items from the <see cref="ICollection{T}"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// The <see cref="ICollection{T}"/> is read-only.
        /// </exception>
        public void Clear()
        {
            if (this.sourceCollection != null)
            {
                this.sourceCollection.Clear();
            }
        }

        /// <summary>
        /// Determines whether the <see cref="ICollection{T}"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="ICollection{T}"/>.</param>
        /// <returns>
        /// True if <paramref name="item"/> is found in the <see cref="ICollection{T}"/>; otherwise, false.
        /// </returns>
        public bool Contains(IAppointment item)
        {
            return ((IList)this).Contains(item);
        }

        /// <summary>
        /// Copies the elements of the <see cref="ICollection{T}"/> to an <see cref="Array"/>, starting at a particular <see cref="Array"/> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from <see cref="ICollection{T}"/>. The <see cref="Array"/> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        /// 	<paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 	<paramref name="arrayIndex"/> is less than 0.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// 	<paramref name="array"/> is multidimensional.
        /// -or-
        /// <paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.
        /// -or-
        /// The number of elements in the source <see cref="ICollection{T}"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.
        /// </exception>
        public void CopyTo(IAppointment[] array, int arrayIndex)
        {
            this.EnsureSourceCollection();
            this.sourceCollection.CopyTo(array, arrayIndex);
        }
		bool IWeakEventListener.ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
		{
			if (managerType == typeof(PropertyChangedEventManager))
			{
				PropertyChangedEventArgs args = (PropertyChangedEventArgs)e;
				this.AppointmentPropertyChangedHandler(sender, args);
				return true;
			}
			if (managerType == typeof(CollectionChangedEventManager))
			{
				NotifyCollectionChangedEventArgs args = (NotifyCollectionChangedEventArgs)e;
				this.SourceCollectionChanged(sender, args);
				return true;
			}
			return false;
		}


		/// <summary>
        /// Creates a new appointment. 
        /// </summary>
        /// <remarks>
        /// This method uses the source collection if it is <see cref="IAppointmentFactory"/>;
        /// if it is not it tries to find a parameterless constructor of a
        /// </remarks>
        /// <returns>A new appointment.</returns>
        public IAppointment CreateNewAppointment()
        {
            this.EnsureSourceCollection();

            if (this.OriginalCollectionAsAppointmentFactory != null)
            {
                return this.OriginalCollectionAsAppointmentFactory.CreateNewAppointment();
            }

            if (this.itemConstructorInfo != null)
            {
                return this.itemConstructorInfo.Invoke(null) as IAppointment;
            }

            return null;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="IEnumerator{T}"/> that can be used to
        /// iterate through the collection.
        /// </returns>
        public IEnumerator<IAppointment> GetEnumerator()
        {
            this.EnsureSourceCollection();

            foreach (object o in this.sourceCollection)
            {
                yield return o as IAppointment;
            }
        }

        /// <summary>
        /// Determines the index of a specific item in the <see cref="IList"/>.
        /// </summary>
        /// <param name="value">The <see cref="Object"/> to locate in the <see cref="IList"/>.</param>
        /// <returns>
        /// The index of <paramref name="value"/> if found in the list; otherwise, -1.
        /// </returns>
        public int IndexOf(object value)
        {
            if (this.sourceCollection != null)
            {
                return this.sourceCollection.IndexOf(value);
            }
            return -1;
        }

        /// <summary>
        /// Inserts an item to the <see cref="IList"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="value"/> should be inserted.</param>
        /// <param name="value">The <see cref="Object"/> to insert into the <see cref="IList"/>.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is not a valid index in the <see cref="IList"/>.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <see cref="IList"/> is read-only.
        /// -or-
        /// The <see cref="IList"/> has a fixed size.
        /// </exception>
        /// <exception cref="NullReferenceException">
        /// 	<paramref name="value"/> is null reference in the <see cref="IList"/>.
        /// </exception>
        public void Insert(int index, object value)
        {
            this.EnsureSourceCollection();
            this.sourceCollection.Insert(index, value);
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="ICollection{T}"/>.
        /// </summary>
        /// <param name="item">The object to remove from the <see cref="ICollection{T}"/>.</param>
        /// <returns>
        /// True if <paramref name="item"/> was successfully removed from the <see cref="ICollection{T}"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="ICollection{T}"/>.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The <see cref="ICollection{T}"/> is read-only.
        /// </exception>
        public bool Remove(IAppointment item)
        {
            if (this.sourceCollection != null && this.Contains(item))
            {
                ((IList)this).Remove(item);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Removes the <see cref="IList"/> item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is not a valid index in the <see cref="IList"/>.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <see cref="IList"/> is read-only.
        /// -or-
        /// The <see cref="IList"/> has a fixed size.
        /// </exception>
        public void RemoveAt(int index)
        {
            if (this.sourceCollection != null)
            {
                this.sourceCollection.RemoveAt(index);
            }
        }

        internal void SetSourceCollection(IEnumerable collection)
        {
            if (this.sourceCollection != null)
            {
                this.UnAdoptSourceAndOriginalCollections();
            }

            if (collection != null)
            {
                this.originalCollection = collection;

                this.AdoptSourceAndOriginalCollections();
            }
        }

        private static Type SearchForGenericCollectionItemType(object collection)
        {
            Type collectionType = collection.GetType();

            if (collectionType.IsGenericType)
            {
                Type[] genericArguments = collectionType.GetGenericArguments();
                if (genericArguments.Length == 1)
                {
                    return genericArguments[0];
                }
            }

            return null;
        }

        private void AddToViews(IAppointment app)
        {
            if (app.IsAllDay())
            {
                this.allDayAppointments.Add(app);
            }
            else
            {
                this.notAllDayAppointments.Add(app);
            }

			PropertyChangedEventManager.AddListener(app, this, String.Empty);
		}

        /// <summary>
        /// We use the original collection as source if:
        /// 1) it supports <see cref="IList"/>
        /// 2) it supports <see cref="INotifyCollectionChanged"/>
        /// 3) it is not fixed size or read only
        /// We copy the original collection in all other cases, because for this version RadScheduler does not support
        /// read only mode and we make all edits/deletes/adds through this collection. This should change in future versions.
        /// </summary>
        private void AdoptOriginalCollection()
        {
            var originalCollectionAsIList = this.originalCollection as IList;
			var editableCollection = this.originalCollection as IEditableCollectionView;
            bool originalCollectionCanRaiseChanged = this.originalCollection is INotifyCollectionChanged;

            this.SetUpAppointmentCreation();

			if (originalCollectionAsIList != null && originalCollectionCanRaiseChanged)
			{
				if (!originalCollectionAsIList.IsFixedSize && !originalCollectionAsIList.IsReadOnly)
				{
					this.sourceCollection = originalCollectionAsIList;
				}
			}
			else if (editableCollection != null && originalCollectionCanRaiseChanged)
			{
				if (editableCollection.CanRemove && editableCollection.CanAddNew)
				{
					(this.originalCollection as INotifyCollectionChanged).CollectionChanged += this.OriginalCollectionChanged;
				}
			}

            if (this.sourceCollection == null)
            {
                var collection = new ObservableCollection<IAppointment>();
                collection.AddRange(this.originalCollection.OfType<IAppointment>().ToList());
                this.sourceCollection = collection;
            }
        }

		private void OriginalCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (this.sourceCollection != null)
			{
				this.sourceCollection.Clear();
				this.sourceCollection.AddRange(this.originalCollection.OfType<IAppointment>().ToList());
			}
		}

        private void AdoptSourceAndOriginalCollections()
        {
            this.AdoptOriginalCollection();
            this.AdoptSourceCollection();
            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        private void AdoptSourceCollection()
        {
            var notifyChangedCollection = this.sourceCollection as INotifyCollectionChanged;

            if (notifyChangedCollection != null)
            {
				CollectionChangedEventManager.AddListener(notifyChangedCollection, this);
            }
        }

        private void AppointmentPropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            this.ChangeAppointmentView((IAppointment)sender);
        }

        private void ChangeAppointmentView(IAppointment appointment)
        {
            bool isAllDay = appointment.IsAllDay();
            bool isContainsInAllDayAppointments = this.allDayAppointments.Contains(appointment);
            bool isContainsInNotAllDayAppointments = this.notAllDayAppointments.Contains(appointment);

            if (isContainsInAllDayAppointments && !isAllDay)
            {
                this.allDayAppointments.Remove(appointment);
            }
            else if (!isContainsInAllDayAppointments && isAllDay)
            {
                this.allDayAppointments.Add(appointment);
            }

            if (isContainsInNotAllDayAppointments && isAllDay)
            {
                this.notAllDayAppointments.Remove(appointment);
            }
            else if (!isContainsInNotAllDayAppointments && !isAllDay)
            {
                this.notAllDayAppointments.Add(appointment);
            }
        }

        private void EnsureSourceCollection()
        {
            if (this.sourceCollection == null)
            {
                this.SetSourceCollection(new DefaultAppointmentCollection());
            }
        }

        private Type GetAppointmentType()
        {
            Type collectionItemType = SearchForGenericCollectionItemType(this.originalCollection);

            if (collectionItemType != null)
            {
                return collectionItemType;
            }

            var sourceCollectionView = this.sourceCollection as ICollectionView;

            if (sourceCollectionView != null)
            {
                Type sourceCollectionItemType = SearchForGenericCollectionItemType(sourceCollectionView.SourceCollection);

                if (sourceCollectionItemType != null)
                {
                    return sourceCollectionItemType;
                }
            }

            return null;
        }

        private void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, e);
            }

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IAppointment app in e.NewItems)
                    {
                        this.AddToViews(app);
                    }
                    break;

                case NotifyCollectionChangedAction.Move:
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (IAppointment app in e.OldItems)
                    {
                        this.RemoveFromViews(app);
                    }
                    break;

                case NotifyCollectionChangedAction.Replace:
                    foreach (IAppointment app in e.OldItems)
                    {
                        this.RemoveFromViews(app);
                    }

                    foreach (IAppointment app in e.NewItems)
                    {
                        this.AddToViews(app);
                    }
                    break;

                case NotifyCollectionChangedAction.Reset:
                    this.ResetAllDayAndNotAllDayViews();
                    break;

                default:
                    break;
            }
        }

        private void RemoveFromViews(IAppointment app)
        {
            if (this.allDayAppointments.Contains(app))
            {
                this.allDayAppointments.Remove(app);
            }
            if (this.notAllDayAppointments.Contains(app))
            {
                this.notAllDayAppointments.Remove(app);
            }

			PropertyChangedEventManager.RemoveListener(app, this, String.Empty);

        }

        private void ResetAllDayAndNotAllDayViews()
        {
            foreach (IAppointment allDayAppointment in this.allDayAppointments)
            {

				PropertyChangedEventManager.RemoveListener(allDayAppointment, this, String.Empty);

            }

            foreach (IAppointment notAllDayAppointment in this.notAllDayAppointments)
            {

				PropertyChangedEventManager.RemoveListener(notAllDayAppointment, this, String.Empty);

            }

            this.allDayAppointments.Clear();
            this.notAllDayAppointments.Clear();

            if (this.sourceCollection != null)
            {
                foreach (object o in this.sourceCollection)
                {
                    var appointment = o as IAppointment;
                    if (appointment != null)
                    {
                        this.AddToViews(appointment);
                    }
                }
            }
        }

        private void SetUpAppointmentCreation()
        {
            if (this.OriginalCollectionAsAppointmentFactory == null)
            {
                Type appointmentType = this.GetAppointmentType();

                if (appointmentType != null)
                {
                    this.itemConstructorInfo = appointmentType.GetConstructor(Type.EmptyTypes);
                }
            }
        }

        private void SourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged(e);
        }

        private void UnAdoptOriginalCollection()
        {
            this.itemConstructorInfo = null;
			var notifyChangedCollection = this.originalCollection as INotifyCollectionChanged;

			if (notifyChangedCollection != null)
			{
				notifyChangedCollection.CollectionChanged -= this.OriginalCollectionChanged;
			}
            this.originalCollection = null;
        }

        private void UnAdoptSourceAndOriginalCollections()
        {
            this.UnAdoptSourceCollection();
            this.UnAdoptOriginalCollection();
            this.ResetAllDayAndNotAllDayViews();
        }

        private void UnAdoptSourceCollection()
        {
            var notifyChangedCollection = this.sourceCollection as INotifyCollectionChanged;

            if (notifyChangedCollection != null)
            {
				CollectionChangedEventManager.RemoveListener(notifyChangedCollection, this);
            }

            this.sourceCollection = null;
        }
	}
}