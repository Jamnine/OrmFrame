using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Orm.Client.Common
{
    /// <summary>
    /// 修改当前电脑的时间
    /// </summary>
    public class SetSystemDateTime
    {
         
        [DllImportAttribute("Kernel32.dll")]

        public static extern void GetLocalTime(SystemTime st);

        [DllImportAttribute("Kernel32.dll")]

        public static extern void SetLocalTime(SystemTime st);

        public static void SetSystemTime(DateTime dateTime)
        {
            SystemTime systemTime = new SystemTime();
            systemTime.vYear = (ushort)dateTime.Year;
            systemTime.vMonth = (ushort)dateTime.Month; 
            systemTime.vDay = (ushort)dateTime.Day; 
            systemTime.vHour = (ushort)dateTime.Hour; 
            systemTime.vMinute = (ushort)dateTime.Minute; 
            //systemTime.vSecond = (ushort)dateTime.Second;
            SetLocalTime(systemTime);
        }

    }
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public class SystemTime
    {

        public ushort vYear;

        public ushort vMonth;

        public ushort vDayOfWeek;

        public ushort vDay;

        public ushort vHour;

        public ushort vMinute;

        public ushort vSecond;

    }
}
