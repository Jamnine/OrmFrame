using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Orm.Client.Common
{
    public class TreeListView : TreeView
    {
        //这两个默认的是TreeViewItem
        protected override DependencyObject GetContainerForItemOverride()//创建或标识用于显示指定项的元素。 
        {
            return new TreeListViewItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)//确定指定项是否是（或可作为）其自己的 ItemContainer
        {
            //return item is TreeListViewItem;
            bool _isTreeLVI = item is TreeListViewItem;
            return _isTreeLVI;
        }
    }
}
