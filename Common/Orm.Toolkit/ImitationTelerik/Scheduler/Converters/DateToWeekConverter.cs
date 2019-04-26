using System;
using System.Globalization;
using System.Windows.Data;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts <see cref="DateTime"/> to a int that 
    /// represent the number of week in year.
    /// </summary>
    [ValueConversion(typeof(DateTime), typeof(int))]
    internal class DateToWeekConverter : ISchedulerConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateToWeekConverter"/> class.
        /// </summary>
        public DateToWeekConverter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateToWeekConverter"/> class.
        /// </summary>
        /// <param name="scheduler">The scheduler.</param>
        public DateToWeekConverter(IScheduler scheduler)
        {
            this.Scheduler = scheduler;
        }

        public IScheduler Scheduler { get; set; }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return this.Scheduler.GetWeekOfYearForMonth((DateTime)value);
        }

        /// <summary>
        /// Converts a value.
        /// </summary>
        /// <param name="value">The value that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}