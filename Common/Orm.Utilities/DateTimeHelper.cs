using System;

namespace Orm.Utilities
{
    public class DateTimeHelper
    {
        /// <summary>
        /// 根据身份证获取出生日期
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        public static DateTime GetBirthdayByIdCard(string idCard)
        {
            string dt = string.Empty;
            var result = DateTime.MinValue;
            if (idCard.Length == 18)
            {
                dt = idCard.Substring(6, 4) + "-" + idCard.Substring(10, 2) + "-" + idCard.Substring(12, 2);
                if (DateTime.TryParse(dt, out result))
                {
                    return Convert.ToDateTime(dt);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            else if (idCard.Length == 15 || idCard.Length == 16)
            {
                dt = "19" + idCard.Substring(6, 2) + "-" + idCard.Substring(8, 2) + "-" + idCard.Substring(10, 2);

                if (DateTime.TryParse(dt, out result))
                {
                    return Convert.ToDateTime(dt);
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        //保留
        public static string CalAge(CalBirthday objCalBirthday)
        {
            string ageString;
            if (objCalBirthday.Birthday == DateTime.MinValue)
            {
                ageString = string.Empty;
            }
            else if (objCalBirthday.Age == 0 && objCalBirthday.Months == 0)
            {
                ageString = string.Format("{0}天", objCalBirthday.Days);
            }
            else if (objCalBirthday.Age <= 0)
            {
                ageString = string.Format("{0}个月{1}天", objCalBirthday.Months, objCalBirthday.Days);
            }
            else if (objCalBirthday.Age > 0 && objCalBirthday.Age < 10)
            {
                ageString = string.Format("{0}岁{1}个月", objCalBirthday.Age, objCalBirthday.Months);
            }
            else
            {
                ageString = string.Format("{0}岁", objCalBirthday.Age);
            }
            return ageString;
        }


    }
    /// <summary>
    /// 计算年龄类
    /// </summary>
    public class CalBirthday
    {
        private DateTime birthday;
        public CalBirthday()
        {
        }
        public CalBirthday(DateTime birthdayTime, DateTime nowDateTime)
        {
            NowDate = nowDateTime;
            Birthday = birthdayTime;

        }

        public CalBirthday(DateTime nowDateTime)
        {
            nowDate = nowDateTime;
        }

        public void SetBirthdayAndNowDate(DateTime birthdayTime, DateTime nowDateTime)
        {
            NowDate = nowDateTime;
            Birthday = birthdayTime;

        }
        /// <summary>
        /// 计算生日
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DateTime CalculateBirthday(string year, string month, string day, DateTime datetimeNow)
        {
            int years = 0, months = 0, days = 0;
            DateTime nowDate = datetimeNow;
            if (Common.IsNumeric(year) && int.Parse(year) > 200) return nowDate;
            string input = year;
            int dotIndex = input.IndexOf(".");
            if (dotIndex < 0) dotIndex = input.IndexOf("。");
            if (dotIndex >= 0)
            {
                year = input.Substring(0, dotIndex);
                if (dotIndex < input.Length - 1)
                {
                    month = input.Substring(dotIndex + 1, 1);
                }
                if (dotIndex < input.Length - 2)
                {
                    day = input.Substring(dotIndex + 2, 1);
                }
            }
            if (Common.IsNumeric(year))
            {
                years = Convert.ToInt32((year));
            }
            if (Common.IsNumeric(month))
            {
                months = Convert.ToInt32(month);
            }
            if (Common.IsNumeric(day))
            {
                days = Convert.ToInt32(day);
            }
            var result = DateTime.MinValue;
            if (years == 0 && months == 0 && days == 0)
            {
                result = DateTime.MinValue;
            }
            else
            {
                result = nowDate.AddDays(-days).AddMonths(-months).AddYears(-years);
            }
            return result;
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                _ages = CalculateAge();
                _months = CalculateMonths();
                _days = CalculateDays();
            }
        }

        private DateTime nowDate = DateTime.Now;
        /// <summary>
        /// 现在日期(可以计算相对时间的相对年龄）
        /// </summary>
        private DateTime NowDate
        {
            get
            {
                if (nowDate == DateTime.MinValue)
                {
                    throw new InformationException(string.Format("计算年龄类中的NowDate属性必须设置值"));
                }
                return nowDate;
            }
            set { nowDate = DateTime.Now; }
        }

        private int _ages;
        /// <summary>
        /// 获取岁数，（当出生日期为空时返回-1）
        /// </summary>
        public int Age
        {
            get { return _ages; }
        }
        private int _months;
        /// <summary>
        /// 获取月数
        /// </summary>
        public int Months
        {
            get { return _months; }
        }
        public int _days;
        /// <summary>
        /// 获取天数）（当出生日期为空时返回-1）
        /// </summary>
        public int Days
        {
            get { return CalculateDays(); }
        }
        public bool IsYounger
        {
            get
            {
                if (_ages > -1 && _ages < 16)
                    return true;
                return false;
            }
        }

        /// <summary>
        /// 获取岁数，（当出生日期为空时返回-1）
        /// </summary>
        public string AgeString
        {
            get
            {
                if (Age > 0)
                {
                    return Age + "岁" + Months + "月";
                }
                else
                {
                    return Months + "月" + Days + "天";
                }
            }
        }

        public bool IsElder(string sex)
        {
            if (sex.Trim() == "M" && _ages > 60) return true;
            if (sex.Trim() == "F" && _ages > 55) return true;
            return false;
        }
        private int CalculateAge()
        {
            if (Birthday == null || Birthday == DateTime.MinValue) return 0;
            if (NowDate.Month > Birthday.Month)
            {
                return NowDate.Year - Birthday.Year;
            }
            else if (nowDate.Month == birthday.Month && nowDate.Day >= birthday.Day)
            {
                return NowDate.Year - Birthday.Year;
            }
            else
            {
                return NowDate.Year - 1 - Birthday.Year;
            }
        }

        private int CalculateMonths()
        {
            if (Birthday == DateTime.MinValue) return 0;
            if (NowDate.Month > Birthday.Month && NowDate.Day >= Birthday.Day)
            {
                return NowDate.Month - Birthday.Month;
            }
            else if (NowDate.Month > Birthday.Month && NowDate.Day < Birthday.Day)
            {
                return NowDate.Month - Birthday.Month - 1;
            }
            else if (NowDate.Month == Birthday.Month && NowDate.Day >= Birthday.Day)
            {
                return NowDate.Month - Birthday.Month;
            }
            else if (NowDate.Month == Birthday.Month && NowDate.Day < Birthday.Day)
            {
                return 12 - Birthday.Month + NowDate.Month - 1;
            }
            else if (NowDate.Month < Birthday.Month && NowDate.Day >= Birthday.Day)
            {
                return 12 - Birthday.Month + NowDate.Month;
            }
            else
            {
                return 12 - Birthday.Month + NowDate.Month - 1;
            }
        }
        private bool IsLeapYear()
        {
            if (Birthday == DateTime.MinValue) return false;
            if (Birthday.Year % 100 == 0)
            {
                if (Birthday.Year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Birthday.Year % 4 == 0)
                {
                    return true;
                }
                else return false;
            }
        }

        private int CalculateDays()
        {
            if (Birthday == DateTime.MinValue) return 0;
            if (Birthday.Day > NowDate.Day)
            {
                return DaysOfForwardMonth() - Birthday.Day + NowDate.Day;
            }
            else if (NowDate.Day == Birthday.Day)
            {
                return 0;
            }
            else
            {
                return NowDate.Day - Birthday.Day;
            }

        }

        private int DaysOfForwardMonth()
        {

            switch (NowDate.Month - 1)
            {
                case 1:
                    return 31;
                case 3:
                    return 31;
                case 5:
                    return 31;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 10:
                    return 31;
                case 0:
                    return 31;
                case 2:
                    if (IsLeapYear()) return 29;
                    return 28;
                default: return 30;
            }
        }
    }

}
