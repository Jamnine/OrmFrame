using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orm.Toolkit.Telerik.Windows.Controls;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 网格数据对象
    /// </summary>
    [Serializable]
    public class DataGridSummary
    {
        private int _rows=0;
        private double _retailTotal;
        private double _stockTotal;
        private double _totalCount;

        public int Rows
        {
            get { return _rows; }
            set { this._rows = value; }
        }
        public double RetailTotal
        {
            get { return _retailTotal; }
            set { this._retailTotal = value; }
        }
        public double StockTotal
        {
            get { return _stockTotal; }
            set { this._stockTotal = value; }
        }
        public double TotalCount
        {
            get { return _totalCount; }
            set { this._totalCount = value; }
        }
    }
}
