using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Orm.Client.Common
{
    public class TreeListViewItem : TreeViewItem
    {
        /// <summary>
        /// hierarchy 
        /// </summary>
        public int Level
        {
            get
            {
                if (_level == -1)
                {
                    TreeListViewItem parent =
                        ItemsControl.ItemsControlFromItemContainer(this) as TreeListViewItem;//返回拥有指定的容器元素中 ItemsControl 。 
                    _level = (parent != null) ? parent.Level + 1 : 0;
                }
                return _level;
            }
        }


        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeListViewItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            //return item is TreeListViewItem;
            bool _isITV = item is TreeListViewItem;
            return _isITV;
        }

        private int _level = -1;
    }
}
