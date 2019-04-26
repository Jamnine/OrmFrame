namespace Orm.Utilities
{
    /// <summary>
    /// 诊断
    /// </summary>
    public class Diagnosis
    {

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
    }
}
