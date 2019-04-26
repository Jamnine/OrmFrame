using System;
using System.Globalization;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    internal static class SchedulerExtensions
    {
        internal static DateTime FirstDayOfFirstWeekOfMonthForVisibleDate(this IScheduler scheduler, DateTime startDate)
        {
            DateTime visibleDate = startDate;
            var firstDateOfMonth = new DateTime(visibleDate.Year, visibleDate.Month, 1);
            return CalendarHelper.GetFirstDayOfWeek(firstDateOfMonth, scheduler.GetFirstDayOfWeekInUse());
        }

        internal static DateTime FirstDayOfWeekForVisibleDate(this IScheduler scheduler, DateTime startDate)
        {
            return
                CalendarHelper.GetFirstDayOfWeek(startDate.Date, scheduler.GetFirstDayOfWeekInUse());
        }

        internal static int GetDaysInMonthView(this IScheduler scheduler, DateTime startDate)
        {
            // Change visible days according to last week end's date
            DateTime firstDateOfMonth = scheduler.FirstDayOfFirstWeekOfMonthForVisibleDate(startDate);
            DateTime lastDateOfMonth = CalendarHelper.GetEndOfMonth(startDate);
            DateTime lastDateOfLastWeek = CalendarHelper.GetLastDayOfWeek(
                lastDateOfMonth,
                scheduler.GetFirstDayOfWeekInUse());

            return (lastDateOfLastWeek - firstDateOfMonth).Days;
        }

        internal static int GetWeekOfYearForMonth(this IScheduler scheduler, DateTime dateTime)
        {
            if (scheduler != null)
            {
                CultureInfo use = scheduler.GetCultureInUse();
                if (use != null && use.Calendar != null)
                {
                    int year = use.Calendar.GetWeekOfYear(
                        dateTime,
                        CalendarWeekRule.FirstFullWeek,
                        scheduler.GetFirstDayOfWeekInUse());
                    return year;
                }
            }
            return 0;
        }
    }
}