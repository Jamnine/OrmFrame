using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace Orm.Toolkit
{
    class TabViewCollection : ObservableCollection<TabView>
    {
        public void RaiseResetCollection()
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}
