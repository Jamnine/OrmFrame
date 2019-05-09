using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Client.Common
{
    public class CashierHelper
    {
        /// <summary>
        /// 套打报表1生成数据
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static Model.Custom.uspOuCashierTaoDa1 ProduceTaodaData1(List<Model.Custom.uspOuInvoiceInvItemGoupSumQry> rawData)
        {
            Model.Custom.uspOuCashierTaoDa1 result = new Model.Custom.uspOuCashierTaoDa1();
            if (rawData == null || rawData.Count == 0) return result;
            for (int i = 0; i < rawData.Count; i++)
            {
                switch (rawData[i].Name)
                {
                    case "西药费":
                        result.XiYao = rawData[i].AmountPay;
                        break;
                    case "中成药费":
                        result.ZChengYao = rawData[i].AmountPay;
                        break;
                    case "中草药费":
                        result.ZCaoYao = rawData[i].AmountPay;
                        break;
                    case "诊察费":
                        result.ZhenCha = rawData[i].AmountPay;
                        break;
                    case "治疗费":
                        result.ZhiLiao = rawData[i].AmountPay;
                        break;
                    case "检查费":
                        result.JianCha = rawData[i].AmountPay;
                        break;
                    case "CT":
                        result.CT = rawData[i].AmountPay;
                        break;
                    case "MRI":
                        result.MRI = rawData[i].AmountPay;
                        break;
                    case "手术费":
                        result.ShouShu = rawData[i].AmountPay;
                        break;
                    case "化验费":
                        result.HuaYan = rawData[i].AmountPay;
                        break;
                    case "其他":
                        result.QiTa = rawData[i].AmountPay;
                        break;
                    case "特需服务":
                        result.TeXu = rawData[i].AmountPay;
                        break;
                    case "自费药品":
                        result.ZiFei = rawData[i].AmountPay;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        /// <summary>
        /// 套打报表2、3生成数据
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        public static Model.Custom.uspOuCashierTaoDa2 ProduceTaodaData2(List<Model.Custom.uspOuInvoiceInvItemGoupSumQry> rawData)
        {
            Model.Custom.uspOuCashierTaoDa2 result = new Model.Custom.uspOuCashierTaoDa2();
            if (rawData == null || rawData.Count == 0) return result;
            for (int i = 0; i < rawData.Count; i++)
            {
                switch (rawData[i].Name)
                {
                    case "西药费":
                        result.XiYao = rawData[i].AmountPay;
                        break;
                    case "中成药费":
                        result.ZChengYao = rawData[i].AmountPay;
                        break;
                    case "中草药费":
                        result.ZCaoYao = rawData[i].AmountPay;
                        break;
                    case "材料费":
                        result.CaiLiao = rawData[i].AmountPay;
                        break;
                    case "注射费":
                        result.ZhuShe = rawData[i].AmountPay;
                        break;
                    case "理疗费":
                        result.LiLiao = rawData[i].AmountPay;
                        break;
                    case "拔牙费":
                        result.BaYa = rawData[i].AmountPay;
                        break;
                    case "镶牙费":
                        result.XiangYa = rawData[i].AmountPay;
                        break;
                    case "诊查费":
                        result.ZhenCha = rawData[i].AmountPay;
                        break;
                    case "急诊留观床位费":
                        result.JiZhen = rawData[i].AmountPay;
                        break;
                    case "检查费":
                        result.JianCha = rawData[i].AmountPay;
                        break;
                    case "CT":
                        result.CT = rawData[i].AmountPay;
                        break;
                    case "MRI":
                        result.MRI = rawData[i].AmountPay;
                        break;
                    case "B超、心电图":
                        result.BChaoXinDian = rawData[i].AmountPay;
                        break;
                    case "X光":
                        result.XGuang = rawData[i].AmountPay;
                        break;
                    case "检验费":
                        result.JianYan = rawData[i].AmountPay;
                        break;
                    case "治疗费":
                        result.ZhiLiao = rawData[i].AmountPay;
                        break;
                    case "麻醉费":
                        result.MaZui = rawData[i].AmountPay;
                        break;
                    case "输氧费":
                        result.ShuYang = rawData[i].AmountPay;
                        break;
                    case "输血费":
                        result.ShuXue = rawData[i].AmountPay;
                        break;
                    case "手术费":
                        result.ShouShu = rawData[i].AmountPay;
                        break;
                    case "其他":
                        result.QiTa = rawData[i].AmountPay;
                        break;
                    case "特需服务费":
                        result.TeXu = rawData[i].AmountPay;
                        break;
                    case "洗牙":
                        result.XiYa = rawData[i].AmountPay;
                        break;
                    case "种植":
                        result.ZhongZhi = rawData[i].AmountPay;
                        break;
                    case "补牙":
                        result.BuYa = rawData[i].AmountPay;
                        break;
                    case "正畸":
                        result.ZhengJi = rawData[i].AmountPay;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        public static Model.Custom.uspOuCashierTaoDa4 ProduceTaodaData4(List<Model.Custom.uspOuInvoiceInvItemGoupSumQry> rawData)
        {
            Model.Custom.uspOuCashierTaoDa4 result = new Model.Custom.uspOuCashierTaoDa4();
            if (rawData == null || rawData.Count == 0) return result;
            for (int i = 0; i < rawData.Count; i++)
            {
                switch (rawData[i].Name)
                {
                    case "挂号费":
                        result.GuaHao = rawData[i].AmountPay;
                        break;
                    case "一次性器械费":
                        result.YiCiQiXie = rawData[i].AmountPay;
                        break;
                    case "麻药费":
                        result.MaYao = rawData[i].AmountPay;
                        break;
                    case "洁牙费":
                        result.JieYa = rawData[i].AmountPay;
                        break;
                    case "治疗费":
                        result.ZhiLiao = rawData[i].AmountPay;
                        break;
                    case "拔牙费":
                        result.BaYa = rawData[i].AmountPay;
                        break;
                    case "手术费":
                        result.ShouShu = rawData[i].AmountPay;
                        break;
                    case "固定修复":
                        result.GuDingXiuFu = rawData[i].AmountPay;
                        break;
                    case "活动修复":
                        result.HuoDongXiuFu = rawData[i].AmountPay;
                        break;
                    case "正畸费":
                        result.ZhengJi = rawData[i].AmountPay;
                        break;
                    case "种植牙":
                        result.Zhongzhiya = rawData[i].AmountPay;
                        break;
                    case "放射费":
                        result.FangShe = rawData[i].AmountPay;
                        break;
                    case "补牙费":
                        result.BuYa = rawData[i].AmountPay;
                        break;
                    case "牙周治疗费":
                        result.YaZhouZhiLiao = rawData[i].AmountPay;
                        break;
                    case "拔牙定金":
                        result.BaYaDingJin = rawData[i].AmountPay;
                        break;
                    case "预付金额":
                        result.YuFuJinE = rawData[i].AmountPay;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
        /// <summary>
        /// 套打报表1生成大写金额
        /// </summary>
        /// <param name="taoDa1"></param>
        /// <param name="AmountPay"></param>
        /// <returns></returns>
        public static Model.Custom.uspOuCashierTaoDa1 ProduceCapitalAmount1(Model.Custom.uspOuCashierTaoDa1 taoDa1, double AmountPay)
        {
            if (AmountPay == 0) return taoDa1;
            string capitalAmout = Orm.Utilities.Common.ConvertToCn(Convert.ToDecimal(AmountPay));
            int index = 0;
            index = capitalAmout.IndexOf("仟") - 1;
            if (index > -2)
            {
                taoDa1.Qian = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("佰") - 1;
            if (index > -2)
            {
                taoDa1.Bai = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("拾") - 1;
            if (index > -2)
            {
                taoDa1.Shi = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("元") - 1;
            if (index > -2)
            {
                taoDa1.Yuan = capitalAmout.Substring(index, 1);
                if (taoDa1.Yuan == "仟" || taoDa1.Yuan == "佰" || taoDa1.Yuan == "拾")
                {
                    taoDa1.Yuan = "";
                }
            }
            index = capitalAmout.IndexOf("角") - 1;
            if (index > -2)
            {
                taoDa1.Jiao = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("分") - 1;
            if (index > -2)
            {
                taoDa1.Fen = capitalAmout.Substring(index, 1);
            }
            return taoDa1;
        }
        /// <summary>
        /// 套打报表2、3生成大写金额
        /// </summary>
        /// <param name="taoDa2"></param>
        /// <param name="AmountPay"></param>
        /// <returns></returns>
        public static Model.Custom.uspOuCashierTaoDa2 ProduceCapitalAmount2(Model.Custom.uspOuCashierTaoDa2 taoDa2, double AmountPay)
        {
            if (AmountPay == 0) return taoDa2;
            string capitalAmout = Orm.Utilities.Common.ConvertToCn(Convert.ToDecimal(AmountPay));
            int index = 0;
            index = capitalAmout.IndexOf("万") - 1;
            if (index > -2)
            {
                taoDa2.Wan = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("仟") - 1;
            if (index > -2)
            {
                taoDa2.Qian = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("佰") - 1;
            if (index > -2)
            {
                taoDa2.Bai = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("拾") - 1;
            if (index > -2)
            {
                taoDa2.Shi = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("元") - 1;
            if (index > -2)
            {
                taoDa2.Yuan = capitalAmout.Substring(index, 1);
                if (taoDa2.Wan == "万" || taoDa2.Yuan == "仟" || taoDa2.Yuan == "佰" || taoDa2.Yuan == "拾")
                {
                    taoDa2.Yuan = "";
                }
            }
            index = capitalAmout.IndexOf("角") - 1;
            if (index > -2)
            {
                taoDa2.Jiao = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("分") - 1;
            if (index > -2)
            {
                taoDa2.Fen = capitalAmout.Substring(index, 1);
            }
            return taoDa2;
        }
        public static Model.Custom.uspOuCashierTaoDa4 ProduceCapitalAmount4(Model.Custom.uspOuCashierTaoDa4 taoDa4, double AmountPay)
        {
            if (AmountPay == 0) return taoDa4;
            string capitalAmout = Orm.Utilities.Common.ConvertToCn(Convert.ToDecimal(AmountPay));
            int index = 0;
            index = capitalAmout.IndexOf("万") - 1;
            if (index > -2)
            {
                taoDa4.Wan = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("仟") - 1;
            if (index > -2)
            {
                taoDa4.Qian = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("佰") - 1;
            if (index > -2)
            {
                taoDa4.Bai = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("拾") - 1;
            if (index > -2)
            {
                taoDa4.Shi = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("元") - 1;
            if (index > -2)
            {
                taoDa4.Yuan = capitalAmout.Substring(index, 1);
                if (taoDa4.Wan == "万" || taoDa4.Yuan == "仟" || taoDa4.Yuan == "佰" || taoDa4.Yuan == "拾")
                {
                    taoDa4.Yuan = "";
                }
            }
            index = capitalAmout.IndexOf("角") - 1;
            if (index > -2)
            {
                taoDa4.Jiao = capitalAmout.Substring(index, 1);
            }
            index = capitalAmout.IndexOf("分") - 1;
            if (index > -2)
            {
                taoDa4.Fen = capitalAmout.Substring(index, 1);
            }
            return taoDa4;
        }
        /// <summary>
        /// 生成大写金额序列
        /// </summary>
        /// <param name="AmountPay"></param>
        /// <returns></returns>
        public static string[] ProduceCapitalAmount(double AmountPay)
        {
            string capitalAmout = Orm.Utilities.Common.ConvertToCn(Convert.ToDecimal(AmountPay));
            int index = 0;
            string[] str = new string[7];
            index = capitalAmout.IndexOf("万") - 1;
            str[0] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            index = capitalAmout.IndexOf("仟") - 1;
            str[1] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            index = capitalAmout.IndexOf("佰") - 1;
            str[2] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            index = capitalAmout.IndexOf("拾") - 1;
            str[3] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            index = capitalAmout.IndexOf("元") - 1;
            str[4] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            if (str[4] == "万" || str[4] == "仟" || str[4] == "佰" || str[4] == "拾")
            {
                str[4] = null;
            }
            index = capitalAmout.IndexOf("角") - 1;
            str[5] = index > -2 ? capitalAmout.Substring(index, 1) : "零";
            index = capitalAmout.IndexOf("分") - 1;
            str[6] = index > -2 ? capitalAmout.Substring(index, 1) : "零";

            return str;
        }

        public static string GetCurrentPayWay(string InvoceNo)
        {
            if (InvoceNo.Trim() == "")
            {
                return "";
            }
            string payWay = String.Empty;
            List<Model.BsPayWay> paywaylst = new List<Model.BsPayWay>();
            paywaylst = null; //Orm.Config.Service.AccountingService.GetPayWayByInvoId(InvoceNo);
            if (paywaylst == null || paywaylst.Count == 0)
            {
                return payWay;
            }
            foreach (var item in paywaylst)
            {
                payWay = payWay + " " + item.Name;
            }
            return payWay;
        }

    }
}
