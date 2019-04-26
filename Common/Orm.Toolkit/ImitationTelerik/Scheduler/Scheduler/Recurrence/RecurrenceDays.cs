using System;

namespace Orm.Toolkit.Telerik.Windows.Controls.Scheduler
{
    /// <summary>
    /// 	<para>Specifies the days of the week. Members might be combined using bitwise
    ///     operations to specify multiple days.</para>
    /// </summary>
    /// <remarks>
    ///     The constants in the <see cref="RecurrenceDays"/> enumeration might be combined
    ///     with bitwise operations to represent any combination of days. It is designed to be
    ///     used in conjunction with the <see cref="RecurrencePattern"/> class to filter
    ///     the days of the week for which the recurrence pattern applies.
    /// </remarks>
    /// <example>
    /// 	<para>Consider the following example that demonstrates the basic usage pattern of
    ///     RecurrenceDays. The most common operators used for manipulating bit fields
    ///     are:</para>
    /// 	<list type="bullet">
    /// 		<item>Bitwise OR: Turns a flag on.</item>
    /// 		<item>Bitwise XOR: Toggles a flag.</item>
    /// 		<item>Bitwise AND: Checks if a flag is turned on.</item>
    /// 		<item>Bitwise NOT: Turns a flag off.</item>
    /// 	</list>
    /// 	<code lang="CS">
    /// using System;
    /// using Telerik.Windows.Controls.Scheduler;
    ///  
    /// namespace RecurrenceExamples
    /// {
    ///     class RecurrenceDayExample
    ///     {
    ///         static void Main()
    ///         {
    ///             // Selects Friday, Saturday and Sunday.
    ///             RecurrenceDays dayMask = RecurrenceDays.Friday | RecurrenceDays.WeekendDays;
    ///             PrintSelectedDays(dayMask);
    ///  
    ///             // Selects all days, except Thursday.
    ///             dayMask = RecurrenceDays.EveryDay ^ RecurrenceDays.Thursday;
    ///             PrintSelectedDays(dayMask);
    ///         }
    ///  
    ///         static void PrintSelectedDays(RecurrenceDays dayMask)
    ///         {
    ///             Console.WriteLine("Value: {0,3} - {1}", (int) dayMask, dayMask);
    ///         }
    ///     }
    /// }
    ///  
    /// /*
    /// This example produces the following results:
    ///  
    /// Value: 112 - Friday, WeekendDays
    /// Value: 119 - Monday, Tuesday, Wednesday, Friday, WeekendDays
    /// */
    ///     </code>
    /// 	<code lang="VB">
    /// Imports System
    /// Imports Telerik.Windows.Controls.Scheduler
    ///  
    /// Namespace RecurrenceExamples
    ///     Class RecurrenceDayExample
    ///         Shared Sub Main()
    ///             ' Selects Friday, Saturday and Sunday.
    ///             Dim dayMask As RecurrenceDays = RecurrenceDays.Friday Or RecurrenceDays.WeekendDays
    ///             PrintSelectedDays(dayMask)
    ///  
    ///             ' Selects all days, except Thursday.
    ///             dayMask = RecurrenceDays.EveryDay Xor RecurrenceDays.Thursday
    ///             PrintSelectedDays(dayMask)
    ///         End Sub
    ///  
    ///         Shared Sub PrintSelectedDays(ByVal dayMask As RecurrenceDays)
    ///             Console.WriteLine("Value: {0,3} - {1}", DirectCast(dayMask, Integer), dayMask)
    ///         End Sub
    ///     End Class
    /// End Namespace
    ///  
    /// '
    /// 'This example produces the following results:
    /// '
    /// 'Value: 112 - Friday, WeekendDays
    /// 'Value: 119 - Monday, Tuesday, Wednesday, Friday, WeekendDays
    /// '
    ///     </code>
    /// </example>
    [Flags]
    public enum RecurrenceDays
    {
        /// <summary>Indicates no selected day.</summary>
        None = 0,

        /// <summary>Indicates Sunday.</summary>
        Sunday = 1,

        /// <summary>Indicates Monday.</summary>
        Monday = 1 << 1,

        /// <summary>Indicates Tuesday.</summary>
        Tuesday = 1 << 2,

        /// <summary>Indicates Wednesday.</summary>
        Wednesday = 1 << 3,

        /// <summary>Indicates Thursday.</summary>
        Thursday = 1 << 4,

        /// <summary>Indicates Friday.</summary>
        Friday = 1 << 5,

        /// <summary>Indicates Saturday.</summary>
        Saturday = 1 << 6,

        /// <summary><para>Indicates the range from Sunday to Saturday inclusive.</para></summary>
        EveryDay = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday,

        /// <summary>Indicates the range from Monday to Friday inclusive.</summary>
        WeekDays = Monday | Tuesday | Wednesday | Thursday | Friday,

        /// <summary>Indicates the range from Saturday to Sunday inclusive.</summary>
        WeekendDays = Saturday | Sunday
    }
}