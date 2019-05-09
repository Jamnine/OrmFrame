using System.Collections.Generic;
using System.Linq;
using Orm.Model;
using Orm.Model.Custom;

namespace Orm.Client.Common
{
    public class ToothsHelper
    {
        /// <summary>
        /// 根据牙位字符串解析成四个方位的字典集合信息（ToothPositionLT，ToothPositionLB，ToothPositionRT，ToothPositionRB）
        /// </summary>
        /// <param name="toothPositions"></param>
        /// <returns></returns>
        public static Dictionary<string,string> ParseCrossTooth(string toothPositions)
        {
            if (string.IsNullOrWhiteSpace(toothPositions))
            { 
                return null;
            }
            Dictionary<string,string> dic = new Dictionary<string,string>();
            List<string> lstTooths = toothPositions.Trim().Split(',').ToList();
            dic = ParseCrossTooth(lstTooths);

            return dic;
        }

        /// <summary>
        /// 根据牙位字符集合解析成四个方位的字典集合信息（ToothPositionLT，ToothPositionLB，ToothPositionRT，ToothPositionRB）
        /// </summary>
        /// <param name="lstTooths"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseCrossTooth(List<string> lstTooths)
        {
            if (lstTooths == null)
            { 
                return null;
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            List<string> lstToothLT = new List<string>();
            List<string> lstToothRT = new List<string>();
            List<string> lstToothRB = new List<string>();
            List<string> lstToothLB = new List<string>();
            if (lstTooths != null)
            {
                foreach (var toothNo in lstTooths)
                {
                    if (lstTooths.Contains(toothNo))
                    {
                        string s = toothNo;
                        if (s == "11" || s == "12" || s == "13" || s == "14" || s == "15" || s == "16" || s == "17" || s == "18")
                        { 
                            lstToothLT.Add(toothNo.Substring(1));
                        }
                        else if (s == "21" || s == "22" || s == "23" || s == "24" || s == "25" || s == "26" || s == "27" || s == "28")
                        { 
                            lstToothRT.Add(toothNo.Substring(1));
                        }
                        else if (s == "31" || s == "32" || s == "33" || s == "34" || s == "35" || s == "36" || s == "37" || s == "38")
                        { 
                            lstToothRB.Add(toothNo.Substring(1));
                        }
                        else if (s == "41" || s == "42" || s == "43" || s == "44" || s == "45" || s == "46" || s == "47" || s == "48")
                        { 
                            lstToothLB.Add(toothNo.Substring(1));
                        }
                    }

                }
            }

            dic.Add("ToothPositionLT", string.Join(",", lstToothLT.OrderBy(t => t)));
            dic.Add("ToothPositionLB", string.Join(",", lstToothLB.OrderBy(t => t)));
            dic.Add("ToothPositionRT", string.Join(",", lstToothRT.OrderBy(t => t)));
            dic.Add("ToothPositionRB", string.Join(",", lstToothRB.OrderBy(t => t)));

            return dic;
        }

        /// <summary>
        /// 构建电子病历报表十字牙位子报表集合
        /// </summary>
        /// <param name="LstToothCaseHistory"></param>
        /// <returns></returns>
        public static List<RptToothPosition> MakeRptToothSubData(List<ToothCaseHistory> LstToothCaseHistory)
        {
            if (LstToothCaseHistory == null)
                return null;
            List<Model.Custom.RptToothPosition> lst = new List<Model.Custom.RptToothPosition>();
            if (LstToothCaseHistory != null && LstToothCaseHistory.Count > 0)
            {
                foreach (var item in LstToothCaseHistory)
                {

                    #region 牙位选择情况

                    var dicToothPosition = ToothsHelper.ParseCrossTooth(item.ToothPosition);
                    string ToothPositionLT = string.Empty;
                    string ToothPositionRT = string.Empty;
                    string ToothPositionLB = string.Empty;
                    string ToothPositionRB = string.Empty;
                    if (dicToothPosition != null)
                    {
                        if (dicToothPosition.ContainsKey("ToothPositionLT"))
                            ToothPositionLT = dicToothPosition["ToothPositionLT"];
                        if (dicToothPosition.ContainsKey("ToothPositionRT"))
                            ToothPositionRT = dicToothPosition["ToothPositionRT"];
                        if (dicToothPosition.ContainsKey("ToothPositionLB"))
                            ToothPositionLB = dicToothPosition["ToothPositionLB"];
                        if (dicToothPosition.ContainsKey("ToothPositionRB"))
                            ToothPositionRB = dicToothPosition["ToothPositionRB"];
                    }

                    #endregion

                    lst.Add(new Model.Custom.RptToothPosition() { Source = "检查", IsClearTooths = item.IsClearTooths, Content = item.CheckCT, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                    lst.Add(new Model.Custom.RptToothPosition() { Source = "X光检查", IsClearTooths = item.IsClearTooths, Content = item.CheckCTXRay, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                    lst.Add(new Model.Custom.RptToothPosition() { Source = "诊断", IsClearTooths = item.IsClearTooths, Content = item.Diagnosis, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                    lst.Add(new Model.Custom.RptToothPosition() { Source = "治疗方案", IsClearTooths = item.IsClearTooths, Content = item.TreatmentPlan, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                    lst.Add(new Model.Custom.RptToothPosition() { Source = "治疗过程", IsClearTooths = item.IsClearTooths, Content = item.TreatmentProcess, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                    lst.Add(new Model.Custom.RptToothPosition() { Source = "医嘱", IsClearTooths = item.IsClearTooths, Content = item.AdviceNotice, ToothPositionLB = ToothPositionLB, ToothPositionLT = ToothPositionLT, ToothPositionRB = ToothPositionRB, ToothPositionRT = ToothPositionRT });
                }
                lst = lst.FindAll(t => !string.IsNullOrWhiteSpace(t.Content));
            }

            return lst;

        }
        /// <summary>
        /// 构建电子病历报表非十字牙位子报表集合
        /// </summary>
        /// <param name="LstToothCaseHistory"></param>
        /// <returns></returns>
        public static List<Model.Custom.RptNoCrossToothPosition> MakeRptNoCrossToothSubData(List<Model.ToothCaseHistory> LstToothCaseHistory)
        {
            if (LstToothCaseHistory == null)
            { 
                return null;
            }
            List<Model.Custom.RptNoCrossToothPosition> lst = new List<Model.Custom.RptNoCrossToothPosition>();
            if (LstToothCaseHistory.Count > 0)
            {
                foreach (var item in LstToothCaseHistory)
                {
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "检查", IsClearTooths = item.IsClearTooths, Content = item.CheckCT, ToothPosition = item.ToothPosition });
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "X光检查", IsClearTooths = item.IsClearTooths, Content = item.CheckCTXRay, ToothPosition = item.ToothPosition });
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "诊断", IsClearTooths = item.IsClearTooths, Content = item.Diagnosis, ToothPosition = item.ToothPosition });
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "治疗方案", IsClearTooths = item.IsClearTooths, Content = item.TreatmentPlan, ToothPosition = item.ToothPosition });
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "治疗过程", IsClearTooths = item.IsClearTooths, Content = item.TreatmentProcess, ToothPosition = item.ToothPosition });
                    lst.Add(new Model.Custom.RptNoCrossToothPosition() { Source = "医嘱", IsClearTooths = item.IsClearTooths, Content = item.AdviceNotice, ToothPosition = item.ToothPosition });
                }
                lst = lst.FindAll(t => !string.IsNullOrWhiteSpace(t.Content));
            }
            return lst;
        }
    }
}
