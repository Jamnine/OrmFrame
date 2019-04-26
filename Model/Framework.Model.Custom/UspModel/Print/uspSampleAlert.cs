using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 简单弹窗接受类
    /// </summary>
    [Serializable]
    public class uspSampleAlert
    {
       public uspSampleAlert()
       {
           

       }
       /// <summary>
       /// 温馨提示
       /// </summary>
       public string Title{get;set;}
       /// <summary>
       /// 号数
       /// </summary>
       public int Number { get; set; }
       /// <summary>
       /// 黄色格子前面部分文字
       /// </summary>
       public string YTxt { get; set; }
      /// <summary>
      /// 需要加粗的文字
      /// </summary>
       public string BoldTxt { get; set; }
       /// <summary>
       /// 第一行后面部分文字
       /// </summary>
       public string FirstTxt { get; set; }
       /// <summary>
       /// 剩下的文字
       /// </summary>
       public string LastTxt { get; set; }

       /// <summary>
       /// 红色格子前面部分文字
       /// </summary>
       public string RTxt { get; set; }
    }
}
