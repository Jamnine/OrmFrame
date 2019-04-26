using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 采检检查
    /// </summary>
    [Serializable]
    public class uspQCDetection
    {
        private string _qCstandId ;
        private double  _qCstandardadd1 = 0;
        private double  _qCstandardadd2 = 0;
        private double  _qCstandardadd3 = 0;
        private double  _qCstandardremove1 = 0;
        private double  _qCstandardremove2 = 0;
        private double  _qCstandardremove3 = 0;
        private string _tjItemId;
        private double  _theaverage = 0;

         /// <summary>  
        /// 标准偏差+1
        /// </summary>  
        public double  QCstandardadd1
        {
            get { return _qCstandardadd1; }
            set { _qCstandardadd1 = value; }
        }
        /// <summary>  
        /// 标准偏差+2
        /// </summary>  
        public double  QCstandardadd2
        {
            get { return _qCstandardadd2; }
            set { _qCstandardadd2 = value; }
        }  
        /// <summary>  
        /// 标准偏差+3
        /// </summary>  
        public double  QCstandardadd3
        {
            get { return _qCstandardadd3; }
            set { _qCstandardadd3 = value; }
        } 
        /// <summary>  
        /// 标准偏差-1
        /// </summary>  
        public double  QCstandardremove1
        {
            get { return _qCstandardremove1; }
            set { _qCstandardremove1 = value; }
        }
        /// <summary>  
        /// 标准偏差-2
        /// </summary>  
        public double  QCstandardremove2
        {
            get { return _qCstandardremove2; }
            set { _qCstandardremove2 = value; }
        } 
        /// <summary>  
        /// 标准偏差-3
        /// </summary>  
        public double  QCstandardremove3
        {
            get { return _qCstandardremove3; }
            set { _qCstandardremove3 = value; }
        }
        /// <summary>  
        /// 标准样品id 
        /// </summary>  
        public string QCstandId
        {
            get { return _qCstandId; }
            set { _qCstandId = value; }
        }

         /// <summary>  
        /// 平均值
        /// </summary>  
        public double  Theaverage
        {
            get { return _theaverage; }
            set { _theaverage = value; }
        }

        /// <summary>  
        /// 检验项目id
        /// </summary>  
        public string TjItemId
        {
            get { return _tjItemId; }
            set { _tjItemId = value; }
        }

         /// <summary>  
        /// 检验项目结果
        /// </summary>  
        public string TjResult
        {
            get ;
            set;
        }


           /// <summary>  
        /// 保存失控结果
        /// </summary>  
        public string TjResultCopy
        {
            get ;
            set;
        }
        

        /// <summary>  
        /// 检验项目时间
        /// </summary>  
        public DateTime OpenTime
        {
            get;
            set;
        }


        /// <summary>  
        /// 检验项目结果
        /// </summary>  
        public string TjResult2
        {
            get;
            set;
        }

        /// <summary>  
        /// 检验项目结果
        /// </summary>  
        public string TjResult3
        {
            get;
            set;
        }

        /// <summary>  
        /// 检验项目结果
        /// </summary>  
        public string TjResult4
        {
            get;
            set;
        }

        /// <summary>  
        /// 检验项目结果
        /// </summary>  
        public string TjResult5
        {
            get;
            set;
        }


        /// <summary>  
        /// 检验高低值参数
        /// </summary>  
        public string TjResultName1
        {
            get;
            set;
        }

        /// <summary>  
        /// 检验高低值参数
        /// </summary>  
        public string TjResultName2
        {
            get;
            set;
        }

        /// <summary>  
        /// 检验高低值参数
        /// </summary>  
        public string TjResultName3
        {
            get;
            set;
        }


        /// <summary>  
        /// 组合项目编码  
        /// </summary>  
        public string GroupItemName
        {
            get;
            set;
        }
        /// <summary>
        /// 检验结果id
        /// </summary>
        public string TjItemRecordId { get; set; }

        private double _sd;
        /// <summary>  
        /// 设定sd
        /// </summary>  
        public double SD
        {
            get { return _sd; }
            set { _sd = value; }
        }

        private double _cv;
        /// <summary>  
        /// 设定CV
        /// </summary>  
        public double CV
        {
            get { return _cv; }
            set { _cv = value; }
        }

        public string TjItemName { get; set; }
    }
      
}
