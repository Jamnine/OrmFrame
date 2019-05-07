using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Client.Common
{
    public class CommonMethod
    {
        public static int GetAgeMonth(DateTime dt)
        {
            var currentDate = DateTime.Now;
            if (!IsBaby(dt))
                return 0;
            return currentDate.Month - dt.Month;

        }

        public static int GetAgeDay(DateTime dt)
        {
            var ageMonth = GetAgeMonth(dt);
            if (ageMonth == 0)
                return 0;
            if (ageMonth % 2 == 0)
            {
                if (ageMonth == 28)
                {
                    return 28 - dt.Day;
                }
                else
                {
                    return 30 - dt.Day;
                }
            }
            return 31 - dt.Day; ;
        }

        public static bool IsBaby(DateTime dt)
        {
            var currentDate = DateTime.Now;
            if (currentDate.Year - dt.Year == 0
                || (currentDate.Year - dt.Year == 1 && dt.Month - 12 < 0))
                return true;
            return false;
        }
    }
}
