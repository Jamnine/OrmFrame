using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Orm.Toolkit.QcCanvas
{


    /// <summary>
    /// 数据源
    /// </summary>
    public class ItemSource
    {
        private List<Tuple<Point, string>> _itemsSource = new List<Tuple<Point, string>>();

        public List<Tuple<Point, string>> ItemsSource
        {
            get { return _itemsSource; }
            set
            {
                _itemsSource = value;
            }
        }
    }

}
