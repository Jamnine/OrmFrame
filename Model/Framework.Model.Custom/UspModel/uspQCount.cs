using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{

    /// <summary>
    /// 质控计算
    /// </summary>
    [Serializable]
    public class uspQCount
    {
        private double _setX = 0;
        private double _setSD = 0;
        private double __setCV = 0;
        private double _actualSD = 0;
        private double _actualCV = 0;
        private double _actualX = 0;
        private double _totalCount;
        private double _constantdeviation = 0;
        private string _qCItemName;
        /// <summary>
        /// 测试项目
        /// </summary>
        public string QCItemName
        {
            get { return _qCItemName; }
            set { _qCItemName = value; }
        }
        /// <summary>
        /// 定值偏差
        /// </summary>
        public double Constantdeviation
        {
            get { return _constantdeviation; }
            set { _constantdeviation = value; }
        }

          /// <summary>
        /// 总次数
        /// </summary>
        public double TotalCount
        {
            get { return _totalCount; }
            set { _totalCount = value; }
        }

         /// <summary>
        /// 实际X
        /// </summary>
        public double ActualX
        {
            get { return _actualX; }
            set { _actualX = value; }
        }

        /// <summary>
        /// 实际sd
        /// </summary>
        public double ActualSD
        {
            get { return _actualSD; }
            set { _actualSD = value; }
        }

        private double _aggregateSD;
        /// <summary>
        /// 累计sd
        /// </summary>
        public double AggregateSD
        {
            get { return _aggregateSD; }
            set { _aggregateSD = value; }
        }

        private double _aggregateCV;
        /// <summary>
        /// 累计CV
        /// </summary>
        public double AggregateCV
        {
            get { return _aggregateCV; }
            set { _aggregateCV = value; }
        }


        private double _aggregateX;
        /// <summary>
        /// 累计X
        /// </summary>
        public double AggregateX
        {
            get { return _aggregateX; }
            set { _aggregateX = value; }
        }
        /// <summary>
        /// 实际cv%
        /// </summary>
        public double ActualCV
        {
            get { return _actualCV; }
            set { _actualCV = value; }
        }

          /// <summary>
        /// 设定X
        /// </summary>
        public double SetX
        {
            get { return _setX; }
            set { _setX = value; }
        }

        /// <summary>
        /// 设定sd
        /// </summary>
        public double SetSD
        {
            get { return _setSD; }
            set { _setSD = value; }
        }

        /// <summary>
        /// 设定cv%
        /// </summary>
        public double SetCV
        {
            get { return __setCV; }
            set { __setCV = value; }
        }

       


    }
      
}
