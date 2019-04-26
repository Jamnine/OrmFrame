using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 质控运行方式
    /// </summary>
    [Serializable]
    public class uspQCRunaway
    {
        private int _qCThenumber = 0;
        private string _qCSpecimenCode=String.Empty;
        private DateTime _qCDateTime ;
        private int  _qCtotal ;
        private string _qCtjItemName = String.Empty;
        private string _tjResult= String.Empty;
        private string _qCRunaway = String.Empty;
        private string _qCdoctName;
        private string _qCcombination = String.Empty;
        
         /// <summary>  
        /// 序号
        /// </summary>  
        public int QCThenumber
        {
            get { return _qCThenumber; }
            set { _qCThenumber = value; }
        }

        /// <summary>  
        /// 失控规则
        /// </summary>  
        public string QCcombination
        {
            get { return _qCcombination; }
            set { _qCcombination = value; }
        }

        /// <summary>  
        /// 质控批号
        /// </summary>  
        public string QCSpecimenCode
        {
            get { return _qCSpecimenCode; }
            set { _qCSpecimenCode = value; }
        }  
        /// <summary>  
        /// 质控日期
        /// </summary>  
        public DateTime QCDateTime
        {
            get { return _qCDateTime; }
            set { _qCDateTime = value; }
        } 
        /// <summary>  
        /// 次数
        /// </summary>  
        public int QCtotal
        {
            get { return _qCtotal; }
            set { _qCtotal = value; }
        }
        /// <summary>  
        /// 项目名称
        /// </summary>  
        public string QCtjItemName
        {
            get { return _qCtjItemName; }
            set { _qCtjItemName = value; }
        }

        /// <summary>  
        /// 质控组合
        /// </summary>  
        public string QCRunaway
        {
            get { return _qCRunaway; }
            set { _qCRunaway = value; }
        } 
       

        /// <summary>  
        /// 处理人
        /// </summary>  
        public string QCdoctName
        {
            get { return _qCdoctName; }
            set { _qCdoctName = value; }
        }

         /// <summary>  
        /// 结果
        /// </summary>  
        public string TjResult
        {
            get { return _tjResult; }
            set { _tjResult = value; }
        }
        
    }
      
}
