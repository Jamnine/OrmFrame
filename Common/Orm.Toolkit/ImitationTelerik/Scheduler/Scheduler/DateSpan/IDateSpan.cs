using System;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// Defines <see cref="Start"/> and <see cref="End"/> properties.
    /// </summary>
    public interface IDateSpan
    {
        /// <summary>
        /// Gets the end <see cref="DateTime"/> of the <see cref="IDateSpan"/>.
        /// </summary>
        /// <value>The end <see cref="DateTime"/>.</value>
        DateTime End { get; }

        /// <summary>
        /// Gets the start <see cref="DateTime"/> of the <see cref="IDateSpan"/>.
        /// </summary>
        /// <value>The start <see cref="DateTime"/>.</value>
        DateTime Start { get; }
    }
}