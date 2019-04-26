using System;
using System.Collections;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    public partial class AppointmentCollectionView
    {
        /// <summary>
        /// Adds an item to the <see cref="IList"/>.
        /// </summary>
        /// <param name="value">The <see cref="object"/> to add to the <see cref="IList"/>.</param>
        /// <returns>
        /// The position into which the new element was inserted.
        /// </returns>
        /// <exception cref="NotSupportedException">
        /// The <see cref="IList"/> is read-only.
        /// -or-
        /// The <see cref="IList"/> has a fixed size.
        /// </exception>
        int IList.Add(object value)
        {
            this.EnsureSourceCollection();
            return this.sourceCollection.Add(value);
        }

        /// <summary>
        /// Determines whether the <see cref="IList"/> contains a specific value.
        /// </summary>
        /// <param name="value">The <see cref="Object"/> to locate in the <see cref="IList"/>.</param>
        /// <returns>
        /// True if the <see cref="Object"/> is found in the <see cref="IList"/>; otherwise, false.
        /// </returns>
        bool IList.Contains(object value)
        {
            if (this.sourceCollection != null)
            {
                return this.sourceCollection.Contains(value);
            }
            return false;
        }

        /// <summary>
        /// Copies the elements of the <see cref="ICollection"/> to an <see cref="Array"/>, starting at a particular <see cref="Array"/> index.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from <see cref="ICollection"/>. The <see cref="Array"/> must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in <paramref name="array"/> at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        /// 	<paramref name="array"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// 	<paramref name="index"/> is less than zero.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// 	<paramref name="array"/> is multidimensional.
        /// -or-
        /// <paramref name="index"/> is equal to or greater than the length of <paramref name="array"/>.
        /// -or-
        /// The number of elements in the source <see cref="ICollection"/> is greater than the available space from <paramref name="index"/> to the end of the destination <paramref name="array"/>.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The type of the source <see cref="ICollection"/> cannot be cast automatically to the type of the destination <paramref name="array"/>.
        /// </exception>
        void ICollection.CopyTo(Array array, int index)
        {
            if (this.sourceCollection != null)
            {
                this.sourceCollection.CopyTo(array, index);
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerator"/> object that can be used to
        /// iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            this.EnsureSourceCollection();
            return this.sourceCollection.GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the <see cref="IList"/>.
        /// </summary>
        /// <param name="value">The <see cref="Object"/> to remove from the <see cref="IList"/>.</param>
        /// <exception cref="NotSupportedException">
        /// The <see cref="IList"/> is read-only.
        /// -or-
        /// The <see cref="IList"/> has a fixed size.
        /// </exception>
        void IList.Remove(object value)
        {
            if (this.sourceCollection != null)
            {
                this.sourceCollection.Remove(value);
            }
        }
    }
}