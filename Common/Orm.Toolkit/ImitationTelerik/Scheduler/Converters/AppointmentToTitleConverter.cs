using System;
using System.Globalization;
using System.Windows.Data;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents converter that converts <see cref="IAppointment"/> to a string that 
    /// can be used as a title of a window.
    /// </summary>
    [ValueConversion(typeof(IAppointment), typeof(string))]
    public class AppointmentToTitleConverter : IValueConverter
    {
        /// <summary>
        /// Converts <see cref="IAppointment"/> to a string.
        /// </summary>
        /// <param name="value">The <see cref="IAppointment"/> that will be used for conversion.</param>
        /// <param name="targetType">This parameter is not used.</param>
        /// <param name="parameter">This parameter is not used.</param>
        /// <param name="culture">This parameter is not used.</param>
        /// <returns>
        /// A string representation for the given <see cref="IAppointment"/>.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var appointment = value as IAppointment;
            if (appointment != null)
            {
                string subject;
                if (string.IsNullOrEmpty(appointment.Subject))
                {
                    subject = LocalizationManager.GetString("Untitled");
                }
                else
                {
                    subject = appointment.Subject;
                }

                string type;
                if (appointment.IsAllDayEvent)
                {
                    type = LocalizationManager.GetString("Event");
                }
                else
                {
                    type = LocalizationManager.GetString("Appointment");
                }

                return type + " - " + subject;
            }

            return string.Empty;
        }

        /// <summary>
        /// This method is not implemented.
        /// </summary>
        /// <remarks>Throws <see cref="NotImplementedException"/>.</remarks>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}