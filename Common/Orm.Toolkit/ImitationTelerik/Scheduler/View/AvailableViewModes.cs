using System;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Provides flags for enumerating the ViewModes supported by <see cref="RadScheduler"/>.
    /// </summary>
    [Flags]
    public enum AvailableViewModes
    {
        Null=0,
        /// <summary>
        /// Enables Day view.
        /// </summary>
        Day = 1,

        /// <summary>
        /// Enables Week view.
        /// </summary>
        Week = 1 << 1,

        /// <summary>
        /// Enables Month view.
        /// </summary>
        Month = 1 << 2,

        /// <summary>
        /// Enables Timeline view.
        /// </summary>
        Timeline = 1 << 3,

        /// <summary>
        /// Enables All views.
        /// </summary>
        All = Month | Week | Day | Timeline
    }

    ////TODO: Remove the extensions when move to .NET Framework Version 4 since we will have the HasFlag() method out of the box then

    /// <summary>
    /// Contains extensions for Enum types.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Determines whether the specified enumObj has flag.
        /// </summary>
        /// <param name="enumObj">The enum object.</param>
        /// <param name="flagObj">The flag object.</param>
        /// <returns>
        /// 	<c>true</c> if the specified enumObj has flag; otherwise, <c>false</c>.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "flag"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag")]
        public static bool HasFlag(this Enum enumObj, Enum flagObj)
        {
            if (enumObj.GetType() != flagObj.GetType())
            {
                throw new ArgumentException("Enum Type Does Not Match in HasFlag() extension method");
            }
            ulong num = Convert.ToUInt64(flagObj);
            return (Convert.ToUInt64(enumObj) & num) == num;
        }
    }
}
