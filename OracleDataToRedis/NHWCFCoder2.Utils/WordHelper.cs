using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Text;
using System.Globalization;
using OracleDataToRedis.Utils;

namespace OracleDataToRedis.Utils
{
    public class WordHelper
    {
        /// <summary>
        /// 排除Hql关键字
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ExclusionHqlKeyWords(string word)
        {
            string[] keys = { "order" };
            foreach (string s in keys)
            {
                word = "_" + word;
            }
            return word;
        }

        /// <summary>
        /// 去除字符串中的" ","-", "_","."
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CleanName(string name)
        {
            Regex cleanRegEx = new Regex(@"\s+|_|-|\.", RegexOptions.Compiled);
            return cleanRegEx.Replace(name, "");
        }

        public static string PascalCase(string name)
        {
            string output = CleanName(name);
            return char.ToUpper(output[0]) + output.Substring(1);
        }

        /// <summary>
        /// 单词变成单数形式
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string MakeSingle(string name)
        {
            Regex plural1 = new Regex("(?<keep>[^aeiou])ies$");
            Regex plural2 = new Regex("(?<keep>[aeiou]y)s$");
            Regex plural3 = new Regex("(?<keep>[sxzh])es$");
            Regex plural4 = new Regex("(?<keep>[^sxzhyu])s$");

            if (plural1.IsMatch(name))
                return plural1.Replace(name, "${keep}y");
            else if (plural2.IsMatch(name))
                return plural2.Replace(name, "${keep}");
            else if (plural3.IsMatch(name))
                return plural3.Replace(name, "${keep}");
            else if (plural4.IsMatch(name))
                return plural4.Replace(name, "${keep}");

            return name;
        }

        /// <summary>
        /// 单词变成复数形式
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string MakePlural(string name)
        {
            Regex plural1 = new Regex("(?<keep>[^aeiou])y$");
            Regex plural2 = new Regex("(?<keep>[aeiou]y)$");
            Regex plural3 = new Regex("(?<keep>[sxzh])$");
            Regex plural4 = new Regex("(?<keep>[^sxzhy])$");

            if (plural1.IsMatch(name))
                return plural1.Replace(name, "${keep}ies");
            else if (plural2.IsMatch(name))
                return plural2.Replace(name, "${keep}s");
            else if (plural3.IsMatch(name))
                return plural3.Replace(name, "${keep}es");
            else if (plural4.IsMatch(name))
                return plural4.Replace(name, "${keep}s");

            return name;
        }

        public static string MakeTitleCaseName(string tableName, string tablePrefixSpilt, string tablePrefix, bool isMakePlural)
        {
            // 获取当前线程
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            // 获取TextInfo
            TextInfo textInfo = cultureInfo.TextInfo;
            string tmpName = tableName.ToLower();
            if (BaseParams.TablePrefixSpilt != null)
                tmpName = tableName.Substring(tableName.IndexOf(BaseParams.TablePrefixSpilt) + 1).ToLower();
            else if (BaseParams.TablePrefix != null)
            {
                if (tmpName.IndexOf(BaseParams.TablePrefix) == 0)
                {
                    tmpName = tableName.Substring(BaseParams.TablePrefix.Length).ToLower();
                }
                else
                {
                    tmpName = tableName.ToLower();
                }
            }
            string titlecasetablename = textInfo.ToTitleCase(tmpName);
            titlecasetablename = titlecasetablename.Replace("_", "");
            if (isMakePlural == true)
                titlecasetablename = WordHelper.MakePlural(titlecasetablename);
            return titlecasetablename;
        }

        public static string MakeTitleCaseName(string fieldName)
        {
            // 获取当前线程
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            // 获取TextInfo
            TextInfo textInfo = cultureInfo.TextInfo;
            string titlecasename = textInfo.ToTitleCase(fieldName.ToLower());
            titlecasename = titlecasename.Replace("_", "");
            return titlecasename;
        }

    }

}
