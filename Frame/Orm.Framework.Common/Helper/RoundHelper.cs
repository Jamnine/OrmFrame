using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Framework.Common
{
    public class RoundHelper
    {
        #region 生成个位随机数
        /// <summary>
        /// 生成个位随机数
        /// </summary>
        /// <returns>个位随机数</returns>
        public static int GetRandomNum()
        {
            return GetRandomNum(0, 10);
        }
        #endregion

        #region 生成随机数，指定最大值和最小值
        /// <summary>
        /// 生成随机数，指定最大值和最小值
        /// </summary>
        /// <param name="MinValue">最小值</param>
        /// <param name="MaxValue">最大值</param>
        /// <returns></returns>
        public static int GetRandomNum(int MinValue, int MaxValue)
        {
            Random ran = new Random();
            return ran.Next(MinValue, MaxValue);
        }
        #endregion

        #region 生成多位随机数字符串
        /// <summary>
        /// 生成多位随机数字符串
        /// </summary>
        /// <param name="length">随机数位数</param>
        /// <returns>多位随机数字符串</returns>
        public static int GetRandomNum(int length)
        {
            if (length <= 1)
            {
                return GetRandomNum();
            }
            else
            {
                return GetRandomNum((int)Math.Pow(10, length - 1), (int)Math.Pow(10, length));
            }
        }
        #endregion

        #region 四舍五入

        /// <summary>
        /// Double型四舍五入
        /// </summary>
        /// <param name="dDou">待操作的数值</param>
        /// <param name="i">小数点后的位数</param>
        /// <returns>Double型四舍五入结果</returns>
        public static double Round(double dDou, int i)
        {
            return System.Math.Round(dDou, i);
        }

        /// <summary>
        /// Decimal型的四舍五入
        /// </summary>
        /// <param name="Deci"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static decimal Round(decimal Deci, int i)
        {
            return System.Math.Round(Deci, i);
        }
        #endregion

        #region 将数字转换为百分数
        /// <summary>
        /// Decimal型转换为百分数
        /// </summary>
        /// <param name="Deci"></param>
        /// <returns></returns>
        public static string Percentage(decimal Deci)
        {
            return Deci.ToString("P");
        }

        /// <summary>
        /// Double型转换为百分数
        /// </summary>
        /// <param name="Deci"></param>
        /// <returns></returns>
        public static string Percentage(double Deci)
        {
            return Deci.ToString("P");
        }
        #endregion

        #region 生成指定小数位数
        /// <summary>
        /// 生成指定小数位数
        /// </summary>
        /// <param name="Deci"></param>
        /// <param name="Num"></param>
        /// <returns></returns>
        public static string DecimalNum(double Deci, int Num)
        {
            string strDeci = Deci.ToString();
            if ((strDeci.Split('.')).Length < 2)
            {
                strDeci += ".";
                for (int i = 0; i < Num; i++)
                {
                    strDeci += "0";
                }
            }
            else
            {
                if ((strDeci.Split('.'))[1].Length >= Num)
                {
                    strDeci = Convert.ToString(Round(double.Parse(strDeci), Num));
                }
                else
                {
                    for (int i = 0; i < Num - (strDeci.Split('.'))[1].Length; i++)
                    {
                        strDeci += "0";
                    }
                }
            }
            return strDeci;
        }
        #endregion

        #region 随机生成编号
        /// <summary>
        /// 生成编号（订单编号，退换货编号，提现编号 等）
        /// </summary>
        /// <param name="vipId">会员id</param>
        /// <returns></returns>
        //public static string GetRoundNo(long vipId)
        //{
        //    string str = RandHelper.Number(4, true);

        //    string tempid = vipId.ToString();

        //    string id = string.Empty;

        //    if (tempid.Length >= 4)
        //    {
        //        id = tempid.Substring(tempid.Length - 4, 4);
        //    }
        //    else
        //    {
        //        id = tempid.PadLeft(4, '0');
        //    }
        //    return (DateTime.Now.ToString("yyyyMMddHHmmss") + str + id);
        //}
        #endregion

    }
}
