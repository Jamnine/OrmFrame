using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Orm.Utilities
{
    public static class Common
    {  
        /// <summary>
        /// 图片转二进制
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static byte[] ImageDatabytes(Bitmap bitmap)
        {
            Bitmap myBitmap = bitmap;
            using (MemoryStream curImageStream = new MemoryStream())
            {
                myBitmap.Save(curImageStream, System.Drawing.Imaging.ImageFormat.Png);
                curImageStream.Flush();
                byte[] bmpBytes = curImageStream.ToArray();
                return bmpBytes;
            }
        }
        /// <summary>
        /// 遍历某类的所有属性的值是否相等
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="last"></param>
        /// <param name="old"></param>
        /// <returns></returns>
        public static bool InfoIsChange<T>(T last, T old)
        {
            if (old != null && last != null)
            {
                foreach (PropertyInfo p in old.GetType().GetProperties())
                {
                    foreach (PropertyInfo q in last.GetType().GetProperties())
                    {
                        if (p.Name == q.Name)
                        {
                            var proInP = p.GetValue(last, null);
                            var proInQ = q.GetValue(old, null);
                            if (!object.Equals(proInP, proInQ))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        ///  弹窗显示提示信息
        /// </summary>
        public static MessageBoxResult ShowErrBox(string strErr)
        {
            return MessageBox.Show(strErr, "错误", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
        /// <summary>
        ///  弹窗显示提示信息
        /// </summary>
        public static MessageBoxResult ShowMsgBox(string strMsg, MessageBoxButton buttons, MessageBoxImage icon)
        {
            return MessageBox.Show(strMsg, "提示", buttons, icon);
        }

        public static List<T> DataTableToList<T>(DataTable dt, bool isStoreDB = true)
        {
            List<T> list = new List<T>();
            Type type = typeof(T);
            List<string> listColums = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                PropertyInfo[] pArray = type.GetProperties(); //集合属性数组  
                T entity = Activator.CreateInstance<T>(); //新建对象实例  
                foreach (PropertyInfo p in pArray)
                {
                    if (!dt.Columns.Contains(p.Name) || row[p.Name] == null || row[p.Name] == DBNull.Value)
                    {
                        continue;  //DataTable列中不存在集合属性或者字段内容为空则，跳出循环，进行下个循环  
                    }
                    if (isStoreDB && p.PropertyType == typeof(DateTime) && Convert.ToDateTime(row[p.Name]) < Convert.ToDateTime("1753-01-01"))
                    {
                        continue;
                    }
                    try
                    {
                        var obj = Convert.ChangeType(row[p.Name], p.PropertyType);//类型强转，将table字段类型转为集合字段类型  
                        p.SetValue(entity, obj, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                list.Add(entity);
            }
            return list;
        }

        /// <summary>
        ///  弹窗显示提示信息
        /// </summary>
        public static MessageBoxResult ShowMsgBox(string strMsg)
        {
            return MessageBox.Show(strMsg, "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static string GetTodayString(DateTime dateTime)
        {
            string month, day;
            if (dateTime.Month.ToString().Length == 1)
            {
                month = "0" + dateTime.Month.ToString();
            }
            else
            {
                month = dateTime.Month.ToString();
            }
            if (dateTime.Day.ToString().Length == 1)
            {
                day = "0" + dateTime.Day.ToString();
            }
            else
            {
                day = dateTime.Day.ToString();
            }

            return dateTime.Year.ToString() + month + day;
        }

        /// <summary>
        /// 获取门诊病人病史症状[诊断表]
        /// </summary>
        /// <param name="IllDesc">诊断（ICD名称）</param>
        /// <param name="Chindiag">中医诊断</param>
        /// <param name="LsDiagType">诊断类别：1-初诊；2-疑诊；3-复诊</param>
        /// <returns></returns>
        public static string GetDesc(string IllDesc, string Chindiag, int LsDiagType)
        {
            string desc = string.Empty;
            if (!string.IsNullOrEmpty(IllDesc))
            {
                desc = desc + "西医诊断" + ":";
            }
            if (!string.IsNullOrEmpty(Chindiag))
            {
                desc = desc + "中医诊断" + ":";
            }
            if (LsDiagType == 1)
            {
                desc = desc + "初诊";
            }
            if (LsDiagType == 2)
            {
                desc = desc + "疑诊";
            }
            else if (LsDiagType == 3)
            {
                desc = desc + "疑诊";
            }
            return desc;

        }

        #region NumberFormatToString[将数值转换为指定最小长度的字符形式]
        public static string NumberFormatToString(int intOrderNo, int intMinLenth)
        {
            if (intOrderNo.ToString().Length < intMinLenth)
            {
                StringBuilder strOrderNo = new StringBuilder("000000000", 1, intMinLenth - intOrderNo.ToString().Length, 10);
                return strOrderNo + intOrderNo.ToString();
            }
            return intOrderNo.ToString();
        }
        #endregion

        /// <summary>
        /// 根据类的实例设置类的属性。
        /// </summary>
        /// <param name="classInstance">将要设置的类的实例。</param>
        /// <param name="propertyName">将要设置属性名。</param>
        /// <param name="propertSetValue">将要设置属性值。</param>
        public static void SetPropertyValue(object classInstance, string propertyName, object propertSetValue)
        {
            classInstance.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, classInstance, new object[] { Convert.ChangeType(propertSetValue, propertSetValue.GetType()) });
        }

        public static T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            int count = VisualTreeHelper.GetChildrenCount(obj);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                    return (T)child;
                else
                {
                    var childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        /// <summary>
        /// 根据类的实例获取类的属性。
        /// </summary>
        /// <param name="classInstance">将要获取的类的实例</param>
        /// <param name="propertyName">将要设置的属性名。</param>
        /// <returns>返回获取的类的属性。</returns>
        public static object GetPropertyValue(object classInstance, string propertyName)
        {
            if (!string.IsNullOrWhiteSpace(propertyName))
            {
                var asdffrtyd = classInstance.GetType();
                var asdffd = classInstance.GetType().InvokeMember(propertyName, BindingFlags.GetProperty, null, classInstance, new object[] { });
                return asdffd;
            }
            else
            { 
                return null;
            } 
        }

        /// <summary>
        /// 判断指定对象实例是否存在该属性
        /// </summary>
        public static bool HasProperty(object target, string propertyName)
        {
            if (target == null || propertyName == null)
            {
                return false;
            }

            PropertyInfo[] names = target.GetType().GetProperties().ToArray();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Name == propertyName.Trim())
                {
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// 过滤掉数组中重复的项目
        /// </summary>
        /// <param name="item">被过滤的数组</param>
        /// <remarks>例如：原字符串：1,3,2,2,3,1,6,3.   得到的结果为: 1,3,2,6</remarks>
        /// <returns></returns>
        public static string FilterArrayToString(string[] item)
        {
            if (item == null || item.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder str = new StringBuilder();
            string[] result = item;
            string resultData = string.Empty;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Trim() != string.Empty)
                {
                    str.Append(result[i].Trim());
                    str.Append(",");

                    for (int j = i + 1; j < result.Length; j++)
                    {
                        if (result[i].Trim() == result[j].Trim())
                        {
                            result[j] = string.Empty;
                        }
                    }
                }
            }

            if (str.Length > 0)
            {
                str.Remove(str.Length - 1, 1);
                resultData = str.ToString();
            }

            return resultData;
        }
        /// <summary>
        /// 过滤掉数组中重复的项目
        /// </summary>
        /// <param name="item">被过滤的数组</param>
        /// <remarks>例如：原字符串：1,3,2,2,3,1,6,3.   得到的结果为: 1,3,2,6</remarks>
        /// <returns></returns>
        public static string FilterArrayToString(int[] item)
        {
            if (item == null || item.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder str = new StringBuilder();
            int[] result = item;
            string resultData = string.Empty;

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].ToString().Trim() != string.Empty)
                {
                    str.Append(result[i].ToString().Trim());
                    str.Append(",");

                    for (int j = i + 1; j < result.Length; j++)
                    {
                        if (result[i].ToString().Trim() == result[j].ToString().Trim())
                        {
                            result[j] = 0;
                        }
                    }
                }
            }

            if (str.Length > 0)
            {
                str.Remove(str.Length - 1, 1);
                resultData = str.ToString();
            }

            return resultData;
        }
        public static bool ValidateNullInput(int obj)
        {
            if (obj == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateNullInput(double obj)
        {
            if (obj == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateNullInput(string obj)
        {
            if (obj.Trim() == string.Empty || obj.Trim() == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateNullInput(object obj)
        {
            if (obj == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 大写金额
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ConvertToCn(decimal num)
        {
            string str1 = "零壹贰叁肆伍陆柒捌玖";            //0-9所对应的汉字 
            string str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字 
            string str3 = string.Empty;    //从原num值中取出的值 
            string str4 = string.Empty;    //数字的字符串形式 
            string str5 = string.Empty;  //人民币大写金额形式 
            int i;    //循环变量 
            int j;    //num的值乘以100的字符串长度 
            string ch1 = string.Empty;    //数字的汉语读法 
            string ch2 = string.Empty;    //数字位的汉字读法 
            int nzero = 0;  //用来计算连续的零值是几个 
            int temp;            //从原num值中取出的值 

            num = Math.Round(Math.Abs(num), 2);    //将num取绝对值并四舍五入取2位小数 
            str4 = ((long)(num * 100)).ToString();        //将num乘100并转换成字符串形式 
            j = str4.Length;      //找出最高位 
            if (j > 15) { return "溢出"; }
            str2 = str2.Substring(15 - j);   //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分 

            //循环取出每一位需要转换的值 
            for (i = 0; i < j; i++)
            {
                str3 = str4.Substring(i, 1);          //取出需转换的某一位的值 
                temp = Convert.ToInt32(str3);      //转换为数字 
                if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                {
                    //当所取位数不为元、万、亿、万亿上的数字时 
                    if (str3.Trim() == "0")
                    {
                        ch1 = string.Empty;
                        ch2 = string.Empty;
                        nzero = nzero + 1;
                    }
                    else
                    {
                        if (str3.Trim() != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                    }
                }
                else
                {
                    //该位是万亿，亿，万，元位等关键位 
                    if (str3.Trim() != "0" && nzero != 0)
                    {
                        ch1 = "零" + str1.Substring(temp * 1, 1);
                        ch2 = str2.Substring(i, 1);
                        nzero = 0;
                    }
                    else
                    {
                        if (str3.Trim() != "0" && nzero == 0)
                        {
                            ch1 = str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3.Trim() == "0" && nzero >= 3)
                            {
                                ch1 = string.Empty;
                                ch2 = string.Empty;
                                nzero = nzero + 1;
                            }
                            else
                            {
                                if (j >= 11)
                                {
                                    ch1 = string.Empty;
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    ch1 = string.Empty;
                                    ch2 = str2.Substring(i, 1);
                                    nzero = nzero + 1;
                                }
                            }
                        }
                    }
                }
                if (i == (j - 11) || i == (j - 3))
                {
                    //如果该位是亿位或元位，则必须写上 
                    ch2 = str2.Substring(i, 1);
                }
                str5 = str5 + ch1 + ch2;

                if (i == j - 1 && str3.Trim() == "0")
                {
                    //最后一位（分）为0时，加上“整” 
                    str5 = str5 + '整';
                }
            }
            if (num == 0)
            {
                str5 = "零元整";
            }
            return str5;
        }

        /// <summary>
        /// 字符串加1
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string IncreaseNumberString(string value)
        {
            if (value.Trim() == string.Empty)
                return "1";
            switch (value[value.Length - 1])
            {
                case 'z':
                    return IncreaseNumberString(value.Substring(1, value.Length - 1)) + "a";

                case 'Z':
                    return IncreaseNumberString(value.Substring(1, value.Length - 1)) + "A";

                case '9':
                    return IncreaseNumberString(value.Substring(1, value.Length - 1)) + "0";

                default:
                    return value.Substring(0, value.Length - 1) + (char)((int)value[value.Length - 1] + 1);
            }
        }

        /// <summary>
        /// 在表中查找是否有存在指定值的行
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="key"></param>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public static bool FindInDataTable(DataTable dt, string key, string keyValue)
        {
            if (dt == null || key == null || keyValue == null || key == string.Empty) return false;
            if (dt.Columns.IndexOf(key) < 0) return false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][key].ToString() == keyValue) return true;
            }
            return false;
        }


        /// <summary>
        /// 是不是数字
        /// </summary>
        /// <param name="val">字符</param>
        /// <returns>布尔值</returns>
        public static bool IsNumeric(string val)
        {
            try
            {
                if (val.Trim() == string.Empty) return false;
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i].ToString().Trim() == "/" || val[i].ToString().Trim() == "*" || val[i].ToString().Trim() == "+" || (val[i].ToString().Trim() == "-" && val.Length == 1))
                        return false;
                    int intCode = Convert.ToInt32(val[i]);
                    if (i == 0)
                    {
                        if (intCode < 45 || intCode > 57)
                            return false;
                    }
                    else
                    { 
                        if (intCode < 46 || intCode > 57)
                            return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 是不是数字
        /// </summary>
        /// <param name="val">字符</param>
        /// <returns>布尔值</returns>
        public static bool IsNumeric(object val)
        {
            if (val == null)
                return false;
            return IsNumeric(val.ToString());

        }

        /// <summary>
        /// 日期检测
        /// </summary>
        /// <returns>true 表示日期，false 表示不是日期</returns>
        public static bool IsDate(string val)
        {
            if (val == null) return false;

            DateTime date;
            if (DateTime.TryParse(val, out date))
                return true;
            else
                return false;
        }

        public static bool IsChar(string ch)
        {
            if (ch == null || ch == string.Empty) return false;
            ch = ch.ToLower();
            for (int i = 0; i < ch.Length; i++)
            {
                int intCode = Convert.ToInt32(ch[i]);
                if (intCode < 97 || intCode > 122)
                    return false;
            }
            return true;
        }

        public static bool IsInteger(object val)
        {
            if (!IsNumeric(val)) return false;
            decimal dVal = Convert.ToDecimal(System.Math.Round(Convert.ToDouble(val), 6));
            if (Math.Abs(dVal - Math.Ceiling(dVal)) < Convert.ToDecimal(0.009999) || Math.Abs(dVal - Math.Floor(dVal)) < Convert.ToDecimal(0.009999))
            { 
                return true;
            }
            else
            { 
                return false;
            }
        }
        /// <summary>
        /// 验证身份证是否合法
        /// </summary>
        /// <param name="idCard"></param>
        /// <param name="birthday"></param>
        /// <returns></returns>
        public static bool ValidateIdCard(string idCard, DateTime birthday)
        {
            if (idCard.Length != 18 && idCard.Length != 15 && idCard.Length != 16)
            {
                return false;
            }
            else if (idCard.Length == 18)
            {
                if (Convert.ToInt32(idCard.Substring(6, 4)) != birthday.Year || Convert.ToInt32(idCard.Substring(10, 2)) != birthday.Month || Convert.ToInt32(idCard.Substring(12, 2)) != birthday.Day)
                { 
                    return false;
                }
                else
                { 
                    return true;
                }
            }
            else
            {
                if (Convert.ToInt32("19" + idCard.Substring(6, 2)) != birthday.Year || Convert.ToInt32(idCard.Substring(8, 2)) != birthday.Month || Convert.ToInt32(idCard.Substring(10, 2)) != birthday.Day)
                { 
                    return false;
                }
                else
                { 
                    return true;
                }
            }
        }

        //保留
        public static string GetNotEmptyString(string str1, string str2, string str3, string str4)
        {
            if (str1 != string.Empty)
                return str1;
            if (str2 != string.Empty)
                return str2;
            if (str3 != string.Empty)
                return str3;
            if (str4 != string.Empty)
                return str4;
            return string.Empty;
        }

        public static string GetAgeString(int age, int months, int days)
        {
            string result = string.Empty;
            if (age == -1)
            {
                result = string.Empty;
            }
            else if (age == 0)
            {
                if (months > 0)
                { 
                    result = months + "个月" + days + "天";
                }
                else
                {  
                    result = days + "天";
                }
            }
            else
            {
                if (months > 0)
                { 
                    result = age + "岁" + months + "个月";
                }
                else
                { 
                    result = age + "岁";
                }
            }

            return result;
        }

        /// <summary>
        /// 获取主板序列号
        /// </summary>
        /// <returns></returns>

        public static string GetBIOSSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_BIOS");
                string sBIOSSerialNumber = string.Empty;
                foreach (ManagementObject mo in searcher.Get())
                {
                    sBIOSSerialNumber = mo["SerialNumber"].ToString().Trim();
                }
                return sBIOSSerialNumber;
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取CPU序列号
        /// </summary>
        /// <returns></returns>

        public static string GetCPUSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_Processor");
                string sCPUSerialNumber = string.Empty;
                foreach (ManagementObject mo in searcher.Get())
                {
                    sCPUSerialNumber = mo["ProcessorId"].ToString().Trim();
                }
                return sCPUSerialNumber;
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        /// <returns></returns>

        public static string GetHardDiskSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                string sHardDiskSerialNumber = string.Empty;
                foreach (ManagementObject mo in searcher.Get())
                {
                    sHardDiskSerialNumber = mo["SerialNumber"].ToString().Trim();
                    break;
                }
                return sHardDiskSerialNumber;
            }
            catch
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取网卡地址
        /// </summary>
        /// <returns></returns>

        public static string GetNetCardMACAddress()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE ((MACAddress Is Not NULL) AND (Manufacturer <> 'Microsoft'))");
                string NetCardMACAddress = string.Empty;
                foreach (ManagementObject mo in searcher.Get())
                {
                    NetCardMACAddress = mo["MACAddress"].ToString().Trim();
                }
                return NetCardMACAddress;
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 根据GUID获取16位的唯一字符串  
        /// </summary>
        /// <returns></returns>
        public static string GuidTo16String()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            { 
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        /// <summary>  
        /// 根据GUID获取19位的唯一数字序列  
        /// </summary>  
        /// <returns></returns>  
        public static long GuidToLongID()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt64(buffer, 0);
        }

        /// <summary>
        /// Ping命令检测网络是否畅通
        /// </summary>
        /// <param name="urls">URL数据</param>
        /// <returns></returns>
        public static bool PingInternet(string[] urls)
        {
            bool isconn = true;
            System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
            int errorCount = 0;
            try
            {
                System.Net.NetworkInformation.PingReply pr;
                for (int i = 0; i < urls.Length; i++)
                {
                    pr = ping.Send(urls[i]);
                    if (pr.Status != System.Net.NetworkInformation.IPStatus.Success)
                    {
                        isconn = false;
                        errorCount++;
                    } 
                }
            }
            catch
            {
                isconn = false;
                errorCount = urls.Length;
            } 
            return isconn;
        }

        public static string GetSex(string sexcode)
        {
            string sex = "未填";
            if (sexcode == "M")
            {
                sex = "男";
            }
            else if (sexcode == "F")
            {
                sex = "女";
            }
            return sex;
        }
    }
}
