using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Linq;

namespace Orm.Toolkit
{
 
    public partial class CheckTreeViewItem : TreeViewItem
    {
        /// <summary>
        /// Instantiate a CustomControls.CustomTreeViewItem class.
        /// </summary>
        public CheckTreeViewItem()
        {
            base.Header = this.chkHeader;
            //this.SetValue(CheckTreeViewItem.CheckHeaderProperty, this.chkHeader.Content);
            chkHeader.Click += new RoutedEventHandler(OnClickHandle);
            chkHeader.Checked += new RoutedEventHandler(OnCheckedHandle);
            chkHeader.Unchecked += new RoutedEventHandler(OnUncheckedHandle);

            chkHeader.Checked += checkbox_Checked;
            chkHeader.Unchecked += checkbox_Unchecked;
            InitializeComponent();
           //this.Loaded += CheckTreeViewItem_Loaded;
        }


        //void CheckTreeViewItem_Loaded(object sender, RoutedEventArgs e)
        //{

        //   // this.IsExpanded = true;
        //    //this.IsExpanded = false;
        //}

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

        }

        //static CheckTreeViewItem()
        //{
        //    DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckTreeViewItem), new FrameworkPropertyMetadata(typeof(CheckTreeViewItem)));
        //}

        #region 全局变量



        /// <summary>
        /// 支持三种状态的CheckBox
        /// </summary>
        private CheckBox chkHeader = new CheckBox
        {
            IsThreeState = false
        };

        private readonly static Type _type = typeof(CheckTreeViewItem);

        #endregion

        #region 自定义依赖属性

        public object CheckHeader
        {
            get
            {
                return this.GetValue(CheckHeaderProperty);  
            }
            set
            {
                this.SetValue(CheckHeaderProperty, value);
            }
        }

        protected virtual void OnCheckHeaderChanged(object oldCheckHeader, object newCheckHeader)
        {
            if (!(base.Header is CheckBox))
            {
                base.Header = this.chkHeader;
            }
            this.chkHeader.Content = newCheckHeader;

            //base.RemoveLogicalChild(oldContent);
            //if (!this.ContentIsNotLogical)
            //{
            //    DependencyObject current = newContent as DependencyObject;
            //    if (current != null)
            //    {
            //        DependencyObject parent = LogicalTreeHelper.GetParent(current);
            //        if (parent != null)
            //        {
            //            if ((base.TemplatedParent != null) && FrameworkObject.IsEffectiveAncestor(parent, this))
            //            {
            //                return;
            //            }
            //            LogicalTreeHelper.RemoveLogicalChild(parent, newContent);
            //        }
            //    }
            //    base.AddLogicalChild(newContent);
            //}
        }


        public readonly static DependencyProperty CheckHeaderProperty = DependencyProperty.Register("CheckHeader", typeof(object), typeof(CheckTreeViewItem), new PropertyMetadata(null, new PropertyChangedCallback(CheckTreeViewItem.OnCheckHeaderChanged)));

        private static void OnCheckHeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as CheckTreeViewItem;
            if (e.OldValue != e.NewValue)
            {

            }
            control.OnCheckHeaderChanged(e.OldValue,e.NewValue);
        }


        #endregion

       
        public new object Header
        {
            get {
                return chkHeader.Content;
            }
            set {
                var bawse=chkHeader.Content;
                chkHeader.Content = value;
            }
        }

      
        public bool? IsChecked
        {
            get { return (bool?)this.GetValue(IsCheckedProperty); }
            set { this.SetValue(IsCheckedProperty,value); }
        }

        private readonly static DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked",typeof(bool?),_type,new PropertyMetadata(false,new PropertyChangedCallback(CheckTreeViewItem.OnIsCheckedChanged)));

        private static void OnIsCheckedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CheckTreeViewItem collapsed = d as CheckTreeViewItem;
            if (collapsed != null) { 
              collapsed.OnIsCheckCheckedChanged(e.OldValue,e.NewValue);
            }
        }

        internal void OnIsCheckCheckedChanged(object OldValue,object NewValue)
        {
            //if (NewValue != OldValue)
            //{
                this.chkHeader.IsChecked = NewValue as bool?;
                //collapsed.IsChecked = e.NewValue as bool?;

            //}

        }

        #region 事件公共方法

        protected void RaiseAddRoutedEvent(RoutedEvent routedEvent)
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(routedEvent);
            this.RaiseEvent(newEventArgs);
        }

        #endregion

        #region 添加Click事件

        public readonly static RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CheckTreeViewItem));

        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        private void OnClickHandle(object sender, System.Windows.RoutedEventArgs e)
        {
            RaiseAddRoutedEvent(CheckTreeViewItem.ClickEvent);
        }

        #endregion

        #region 添加Checked事件

        public readonly static RoutedEvent CheckedEvent = EventManager.RegisterRoutedEvent("Checked",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(CheckTreeViewItem));

        public event RoutedEventHandler Checked
        {
            add { this.AddHandler(CheckedEvent,value); }
            remove { this.RemoveHandler(CheckedEvent,value); }
        }

        private void OnCheckedHandle(object sender,System.Windows.RoutedEventArgs e)
        {
            RaiseAddRoutedEvent(CheckTreeViewItem.CheckedEvent);
        }

        #endregion

        #region 添加Unchecked事件

        public readonly static RoutedEvent UncheckedEvent = EventManager.RegisterRoutedEvent("Unchecked",RoutingStrategy.Bubble,typeof(RoutedEventHandler),typeof(CheckTreeViewItem));

        public event RoutedEventHandler Unchecked
        {
            add { this.AddHandler(UncheckedEvent,value); }
            remove { this.RemoveHandler(UncheckedEvent,value); }
        }

        private void OnUncheckedHandle(object sender, System.Windows.RoutedEventArgs e)
        {
            RaiseAddRoutedEvent(CheckTreeViewItem.UncheckedEvent);
        }

        #endregion

        #region CheckBox选择状态

        /// <summary>
        /// 选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.IsChecked = true;
            var parent = GetFirstVisualParent<CheckTreeViewItem>(this);

            if (parent != null)
            {
                //判断别的子控件是否是非选中状态
                bool areOtherChildrenUnchecked = false;
                //获取父级控件下一级子控件o
                //var parentChildren = GetFirstVisualChildren<CheckTreeViewItem>(parent);
                ////删除自身控件
                //parentChildren.Remove(this);

                //if (parentChildren.FirstOrDefault(f => f.IsChecked == false) != null)
                //{
                //    areOtherChildrenUnchecked = true;
                //}
                if (!areOtherChildrenUnchecked)
                    SetCheckBoxState(parent, CheckBoxState.IsChecked);
                else if (parent.chkHeader.IsThreeState)
                    SetCheckBoxState(parent, CheckBoxState.Indeterminate);
            }

            if (!this.IsExpanded)
            {
                this.SetValue(CheckTreeViewItem.IsExpandedProperty, true);
                this.UpdateLayout();//更新布局

                this.SetValue(CheckTreeViewItem.IsExpandedProperty, false);
                this.UpdateLayout();//更新布局
            }
           
            //更新子节点
            if (GetSelfOrParentIsMouseOver(this) && this.HasItems)
            {
                //var lstVisualChildren = GetFirstVisualChildren<CheckTreeViewItem>(this);
                //var count = lstVisualChildren.Count;
                //for (int i = 0; i < count; i++)
                //{
                //    if (lstVisualChildren[i].IsEnabled)
                //    {
                //        lstVisualChildren[i].IsChecked = true;
                //    }
                //}
                UpdateAllChildrenStatus(this);
            }
        }

        /// <summary>
        /// 非选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.IsChecked = false;
            //获取父级控件
            var parent = GetFirstVisualParent<CheckTreeViewItem>(this);
            if (parent != null)
            {
                //判断别的子控件是否是非选中状态
                bool areOtherChildrenUnchecked = true;
                //获取父级控件下一级子控件o
                var parentChildren = GetFirstVisualChildren<CheckTreeViewItem>(parent);
                //移除自身控件
                parentChildren.Remove(this);
                if (parentChildren.FirstOrDefault(f => f.IsChecked == true) != null)
                {
                    areOtherChildrenUnchecked = false;
                }
                if (areOtherChildrenUnchecked)
                    SetCheckBoxState(parent, CheckBoxState.Unchecked);
                else if (parent.chkHeader.IsThreeState)
                    SetCheckBoxState(parent, CheckBoxState.Indeterminate);
            }

            //更新子节点
            if (this.HasItems)
            {
                //var lstVisualChildren = GetFirstVisualChildren<CheckTreeViewItem>(this);
                //var count = lstVisualChildren.Count;
                //for (int i = 0; i < count; i++)
                //{
                //    if (lstVisualChildren[i].IsEnabled)
                //    {
                //        lstVisualChildren[i].IsChecked = false;
                //    }
                //}

                UpdateAllChildrenStatus(this);
            }

        }

        /// <summary>
        ///   //自身或者父级控件鼠标指针存在于控件上
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        private static bool GetSelfOrParentIsMouseOver<T>(T element) where T : CheckTreeViewItem
        { 
            
            bool flag=false;
            if (element == null)
            {
                return flag;
            }
            if (element.chkHeader.IsMouseOver)
            {
                flag = true;
            }
            else {
               flag = GetSelfOrParentIsMouseOver(GetFirstVisualParent<T>(element));
            }
            return flag;
        }

        private void UpdateAllChildrenStatus(CheckTreeViewItem node)
        {
            var lstVisualChildren = GetFirstVisualChildren<CheckTreeViewItem>(node);
            if(lstVisualChildren!=null&&lstVisualChildren.Count>0)
            {
                foreach (var item in lstVisualChildren)
                {
                    if (item.IsEnabled)
                    {
                        item.IsChecked = node.IsChecked;
                        UpdateAllChildrenStatus(item);
                    }
                }
            }
            
        }

        /// <summary>
        /// 获取类型T的父级控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        private static T GetFirstVisualParent<T>(DependencyObject element) where T :FrameworkElement
        {
            if (element == null) return null;
            if (element is FrameworkElement)
                (element as FrameworkElement).ApplyTemplate();
            var parent = VisualTreeHelper.GetParent(element);
            if (parent != null && !(parent is T))
            {
                parent = GetFirstVisualParent<T>(parent);
            }
            return parent as T;
        }

        /// <summary>
        /// 获取第一级T类型的控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        private static List<T> GetFirstVisualChildren<T>(DependencyObject element) where T : FrameworkElement
        {
            if (element == null) return null;
            List<T> childList = new List<T>();
            if (element is FrameworkElement)
                (element as FrameworkElement).ApplyTemplate();
            var cnt = VisualTreeHelper.GetChildrenCount(element);
            //bool flag = false;//标识说明在第一级获取到所需要的控件
            for (int i = 0; i < cnt ; i++)
            {
                var child = VisualTreeHelper.GetChild(element, i);
                if (child is T)
                {
                    childList.Add(child as T);
                    continue;//跳过搜寻下一级控件
                }
                var tempLst = GetFirstVisualChildren<T>(child);
                if (tempLst != null && tempLst.Count > 0)
                {
                    childList.AddRange(tempLst);
                }
            }
            return childList;
        }


        #endregion

    


        public event PropertyChangedEventHandler PropertyChanged;

        internal void NotifyPropertyChanged(object sender, string args)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(args));

            if (sender is CheckTreeViewItem)
            {
                CheckTreeViewItem child = sender as CheckTreeViewItem;
                if (args.CompareTo(_indeterminateState) == 0 && child.Parent is CheckTreeViewItem)
                {
                    CheckTreeViewItem parent = child.Parent as CheckTreeViewItem;
                    SetCheckBoxState(parent, CheckBoxState.Indeterminate);  //recursive call to update all its parents to indeterminate
                }
            }
        }


        private const string _isCheckedState = "CheckBox_IsChecked";
        private const string _indeterminateState = "CheckBox_Indeterminate";
        private const string _uncheckedState = "CheckBox_Unchecked";

        void SetCheckBoxState(CheckTreeViewItem item, CheckBoxState state)
        {
            switch (state)
            {
                case CheckBoxState.IsChecked:
                    item.IsChecked = true;
                   // item.NotifyPropertyChanged(item, _isCheckedState);
                    break;
                case CheckBoxState.Indeterminate:
                    item.IsChecked = null;
                    //item.NotifyPropertyChanged(item, _indeterminateState);
                    break;
                case CheckBoxState.Unchecked:
                    item.IsChecked = false;
                    //item.NotifyPropertyChanged(item, _uncheckedState);
                    break;
            }
        }



        #region 模仿微软的代码

        internal ItemsControl ParentItemsControl
        {
            get
            {
                return ItemsControl.ItemsControlFromItemContainer(this);
            }
        }


        internal TreeView ParentTreeView
        {
            get
            {
                for (ItemsControl control = this.ParentItemsControl; control != null; control = ItemsControl.ItemsControlFromItemContainer(control))
                {
                    TreeView view = control as TreeView;
                    if (view != null)
                    {
                        return view;
                    }
                }
                return null;
            }
        }

        internal TreeViewItem ParentTreeViewItem
        {
            get
            {
                return (this.ParentItemsControl as TreeViewItem);
            }
        }

        #endregion


        ///// <summary>
        ///// Gets or set the IsChecked property of the System.Windows.Controls.CheckBox class.
        ///// </summary>
        //public bool? IsChecked
        //{
        //    get { return checkbox.IsChecked; }
        //    set { checkbox.IsChecked = value; }
        //}
        ///// <summary>
        ///// Gets or sets the IsExpanded property of the System.Windows.Controls.TreeViewItem class.
        ///// </summary>
        //public bool IsExpanded
        //{
        //    get { return treeItem.IsExpanded; }
        //    set { treeItem.IsExpanded = value; }
        //}
        ///// <summary>
        ///// Gets or sets the IsSelected propert of the System.Windows.Controls.TreeViewItem class;
        ///// </summary>
        //public bool IsSelected
        //{
        //    get { return treeItem.IsSelected; }
        //    set { treeItem.IsSelected = value; }
        //}
        ///// <summary>
        ///// Gets the HasItems property of the System.Windows.Controls.TreeViewItem class.
        ///// </summary>
        //public bool HasItems
        //{
        //    get { return treeItem.HasItems; }
        //}

        ///// <summary>
        ///// Gets or sets the parent container of this CustomTreeViewItem.
        ///// </summary>
        //public new object Parent { get; set; }
        ///// <summary>
        ///// Gets or sets the Header for the TreeViewItem. Header is limited to only strings.
        ///// </summary>
        //public string Header
        //{
        //    get { return treeItem.Header as string; }
        //    set { treeItem.Header = value + "  "; }     //leaving some space for visual purposes during highlight
        //}
        ///// <summary>
        ///// Gets an IEnumerable of all the Children of this CustomTreeViewItem.
        ///// </summary>
        //public IEnumerable<object> Items
        //{
        //    get 
        //    {
        //        foreach (object item in treeItem.Items)
        //            yield return item;
        //    }
        //}

        ///// <summary>
        ///// Adds an item to the current CustomTreeViewItem.
        ///// </summary>
        ///// <param name="item">The object to be added.</param>
        //public void AddItem(object item)
        //{
        //    treeItem.Items.Add(item);
        //    ItemsAdded(this, new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
        //}

        //#region TreeViewItem events
        ///// <summary>
        ///// Handler for when an item has been added through the CustomTreeViewItem.AddItem(object item) method.
        ///// </summary>
        //public event CollectionChangeEventHandler ItemsAdded;
        //void CustomTreeViewItem_ItemsAdded(object sender, CollectionChangeEventArgs e)
        //{
        //    //Sets the newly added child element's Parent property to this class.
        //    if (e.Element is CheckTreeViewItem)
        //    {
        //        CheckTreeViewItem temp = e.Element as CheckTreeViewItem;
        //        temp.Parent = this;
        //    }
        //}

        //#endregion

        //#region CheckBox events
        ////Events for highlighting the CustomTreeViewItem
        //void checkbox_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    this.Background = this.FindResource("AeroTheme") as Brush;
        //    CheckTreeViewItem current = this;
        //    if (!(current.Parent is CheckTreeView))
        //    {
        //        CheckTreeViewItem item = current.Parent as CheckTreeViewItem;
        //        item.Background = Brushes.Transparent;
        //    }
        //}
        //void checkbox_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    this.Background = Brushes.Transparent;
        //}

        ////Events for checking/unchecking CheckBox
        //void checkbox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    //hooks CustomTreeViewItem Checked EventHandler if this object does not have any children
        //    if (!this.HasItems && Checked != null)
        //        Unchecked(this, e);

        //    //update parent checkbox
        //    if (Parent is CheckTreeViewItem)
        //    {
        //        CheckTreeViewItem parent = Parent as CheckTreeViewItem;
        //        bool areOtherChildrenUnchecked = true;
        //        foreach (CheckTreeViewItem item in parent.Items)
        //        {
        //            if (item.IsChecked == true)
        //            {
        //                areOtherChildrenUnchecked = false;
        //                break;
        //            }
        //        }

        //        if (areOtherChildrenUnchecked)
        //            SetCheckBoxState(parent, CheckBoxState.Unchecked);
        //        else
        //            SetCheckBoxState(parent, CheckBoxState.Indeterminate);
        //    }
        //    //update children checkboxes
        //    if (HasItems)
        //    {
        //        foreach (CheckTreeViewItem item in treeItem.Items)
        //        {
        //            if(item.IsEnabled)
        //                SetCheckBoxState(item, CheckBoxState.Unchecked);
        //        }
        //    }
        //}
        //void checkbox_Checked(object sender, RoutedEventArgs e)
        //{
        //    //hooks CustomTreeViewItem Checked EventHandler if this object does not have any children
        //    if (!this.HasItems && Checked != null)
        //        Checked(this, e);

        //    //update parent
        //    if (Parent is CheckTreeViewItem)
        //    {
        //        CheckTreeViewItem parent = Parent as CheckTreeViewItem;
        //        bool areOtherChildrenChecked = true;
        //        foreach (CheckTreeViewItem item in parent.Items)
        //        {
        //            if (item.IsChecked == false)
        //            {
        //                areOtherChildrenChecked = false;
        //                break;
        //            }
        //        }

        //        if (areOtherChildrenChecked)
        //            SetCheckBoxState(parent, CheckBoxState.IsChecked);
        //        else
        //            SetCheckBoxState(parent, CheckBoxState.Indeterminate);
        //    }

        //    //update children
        //    if (HasItems)
        //    {
        //        foreach (CheckTreeViewItem item in treeItem.Items)
        //        {
        //            if(item.IsEnabled)
        //                SetCheckBoxState(item, CheckBoxState.IsChecked);
        //        }
        //        this.IsExpanded = true;
        //    }
        //}

        ////The EventHandlers below are for CustomTreeViewItem users
        //public event RoutedEventHandler Checked;
        //public event RoutedEventHandler Unchecked;
        //#endregion

        //#region INotifyPropertyChanged events
  
        ///// <summary>
        ///// Selective property changed notification
        ///// </summary>
        ///// <param name="sender">The sender of the property changed notification.</param>
        ///// <param name="args">A description of the change.</param>
    
        //#endregion

        //#region Helper methods
     
        //#endregion
    }

    internal enum CheckBoxState
    {
        IsChecked,
        Indeterminate,
        Unchecked,
    }
}
