using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Linq;
using System.Windows.Input;

namespace Orm.Toolkit
{
    public class WorkCalendarEx  : Control
    {
        public ObservableCollection<Day> Days { get; set; }
        public ObservableCollection<string> DayNames { get; set; }

        public static readonly DependencyProperty CurrentDateProperty = DependencyProperty.Register("CurrentDate", typeof(DateTime), typeof(WorkCalendarEx), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendarEx.OnCurrentDateChanged)));

        public DateTime CurrentDate
        {
            get { return (DateTime)GetValue(CurrentDateProperty); }
            set { SetValue(CurrentDateProperty, value); }
        }

        public event EventHandler<DayExChangedEventArgs> DayChanged;

        public static readonly RoutedEvent AddClickEvent = EventManager.RegisterRoutedEvent("AddClick", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<object>), typeof(WorkCalendarEx));
        /// <summary>
        /// 新增
        /// </summary>
        public event RoutedPropertyChangedEventHandler<object> AddClick
        {
            add { AddHandler(AddClickEvent, value); }
            remove { RemoveHandler(AddClickEvent, value); }
        }

        public static readonly RoutedEvent CopyAllClickEvent = EventManager.RegisterRoutedEvent("CopyAllClick", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<object>), typeof(WorkCalendarEx));
        /// <summary>
        /// 复制
        /// </summary>
        public event RoutedPropertyChangedEventHandler<object> CopyAllClick
        {
            add { AddHandler(CopyAllClickEvent, value); }
            remove { RemoveHandler(CopyAllClickEvent, value); }
        }

        public static readonly RoutedEvent PasteClickEvent = EventManager.RegisterRoutedEvent("PasteClick", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<object>), typeof(WorkCalendarEx));
        /// <summary>
        /// 粘贴
        /// </summary>
        public event RoutedPropertyChangedEventHandler<object> PasteClick
        {
            add { AddHandler(PasteClickEvent, value); }
            remove { RemoveHandler(PasteClickEvent, value); }
        }

        public static readonly RoutedEvent DeleteAllClickEvent = EventManager.RegisterRoutedEvent("DeleteAllClick", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<object>), typeof(WorkCalendarEx));
        /// <summary>
        /// 删除
        /// </summary>
        public event RoutedPropertyChangedEventHandler<object> DeleteAllClick
        {
            add { AddHandler(DeleteAllClickEvent, value); }
            remove { RemoveHandler(DeleteAllClickEvent, value); }
        }

        static WorkCalendarEx ()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WorkCalendarEx), new FrameworkPropertyMetadata(typeof(WorkCalendarEx)));
        }
        public static RoutedCommand NewCommand = new RoutedCommand("NewCommand", typeof(WorkCalendarEx));

        public static RoutedCommand CopyAllCommand = new RoutedCommand("CopyAllCommand", typeof(WorkCalendarEx));

        public static RoutedCommand PasteCommand = new RoutedCommand("PasteCommand", typeof(WorkCalendarEx));

        public static RoutedCommand DeleteAllCommand = new RoutedCommand("DeleteAllCommand", typeof(WorkCalendarEx));


        public WorkCalendarEx ()
        {
            //DataContext = this;
            //CurrentDate = DateTime.Today;

            //this won't work in Australia where they start the week with Monday. So remember to test in other 
            //places if you plan on using it. 
            DayNames = new ObservableCollection<string> { "星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

            Days = new ObservableCollection<Day>();
            //BuildCalendar(DateTime.Today);

            #region 添加命令
            CommandBinding cbAdd = new CommandBinding();
            cbAdd.Command = NewCommand;
            cbAdd.CanExecute += new CanExecuteRoutedEventHandler(cbAdd_CanExecute);
            cbAdd.Executed += new ExecutedRoutedEventHandler(cbAdd_Executed);
            this.CommandBindings.Add(cbAdd);

            CommandBinding cbCopyAll = new CommandBinding();
            cbCopyAll.Command = CopyAllCommand;
            cbCopyAll.CanExecute += new CanExecuteRoutedEventHandler(cbCopyAll_CanExecute);
            cbCopyAll.Executed += new ExecutedRoutedEventHandler(cbCopyAll_Executed);
            this.CommandBindings.Add(cbCopyAll);

            CommandBinding cbPaste = new CommandBinding();
            cbPaste.Command = PasteCommand;
            cbPaste.CanExecute += new CanExecuteRoutedEventHandler(cbPaste_CanExecute);
            cbPaste.Executed += new ExecutedRoutedEventHandler(cbPaste_Executed);
            this.CommandBindings.Add(cbPaste);

            CommandBinding cbDeleteAll = new CommandBinding();
            cbDeleteAll.Command = DeleteAllCommand;
            cbDeleteAll.CanExecute += new CanExecuteRoutedEventHandler(cbDeleteAll_CanExecute);
            cbDeleteAll.Executed += new ExecutedRoutedEventHandler(cbDeleteAll_Executed);
            this.CommandBindings.Add(cbDeleteAll);


            #endregion

        }

        private void cbDeleteAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RoutedPropertyChangedEventArgs<object> args =
                new RoutedPropertyChangedEventArgs<object>(
                    DateTime.MinValue, Convert.ToDateTime((e.Parameter as Day).Date.ToString()), DeleteAllClickEvent);
            this.RaiseEvent(args);
        }

        private void cbDeleteAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Parameter != null && e.Parameter is Day && (e.Parameter as Day).Visual != null)
            {
                e.CanExecute = true;
            }
            else
                e.CanExecute = false;

        }

        private void cbPaste_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RoutedPropertyChangedEventArgs<object> args =
                new RoutedPropertyChangedEventArgs<object>(
                    DateTime.MinValue, Convert.ToDateTime((e.Parameter as Day).Date.ToString()), PasteClickEvent);
            this.RaiseEvent(args);
        }

        private void cbPaste_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = CanPaste;
        }

        private void cbCopyAll_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RoutedPropertyChangedEventArgs<object> args =
                new RoutedPropertyChangedEventArgs<object>(
                    DateTime.MinValue, Convert.ToDateTime((e.Parameter as Day).Date.ToString()), CopyAllClickEvent);
            this.RaiseEvent(args);
        }

        private void cbCopyAll_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Parameter != null && e.Parameter is Day && (e.Parameter as Day).Visual != null)
            {
                e.CanExecute = true;
            }
            else
                e.CanExecute = false;

        }

        private void cbAdd_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RoutedPropertyChangedEventArgs<object> args =
                new RoutedPropertyChangedEventArgs<object>(
                    DateTime.MinValue, Convert.ToDateTime((e.Parameter as Day).Date.ToString()), AddClickEvent);
            this.RaiseEvent(args);
        }

        private void cbAdd_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }



        #region 当前日期


        private static void OnCurrentDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendarEx control = (WorkCalendarEx)d;
            DateTime oldValue = (DateTime)e.OldValue;
            DateTime newValue = (DateTime)e.NewValue;
            //((IContainItemStorage)control).Clear();
            control.OnCurrentDateChanged(oldValue, newValue);
        }

        protected virtual void OnCurrentDateChanged(DateTime oldValue, DateTime newValue)
        {
            if (oldValue != newValue)
            {
                BuildCalendar(newValue);
            }
        }

        #endregion




        public void BuildCalendar(DateTime targetDate)
        {
            if (targetDate==DateTime.MinValue)
            {
                return;
            }
            //目标日期
            if (this.targetDate != targetDate)
                this.targetDate = targetDate;

            Days.Clear();


            //Calculate when the first day of the month is and work out an 
            //offset so we can fill in any boxes before that.
            DateTime d = new DateTime(targetDate.Year, targetDate.Month, 1);
            int offset = DayOfWeekNumber(d.DayOfWeek);
            if (offset != 1) d = d.AddDays(-offset);
            else if (offset == 1 && targetDate.Year != 0) d = d.AddDays(-offset);

            //Show 6 weeks each with 7 days = 42
            for (int box = 1; box <= 42; box++)
            {
                Day day = new Day { Date = d, Enabled = true, IsTargetMonth = targetDate.Month == d.Month, Visual = dictDateTimeVisual.FirstOrDefault(v => v.Key.Date == d.Date).Value };
                day.PropertyChanged += Day_Changed;
                day.IsToday = d == DateTime.Today;
                Days.Add(day);
                d = d.AddDays(1);
            }
        }

        private void Day_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Notes") return;
            if (DayChanged == null) return;

            DayChanged(this, new DayExChangedEventArgs(sender as Day));
        }

        private static int DayOfWeekNumber(DayOfWeek dow)
        {
            return Convert.ToInt32(dow.ToString("D"));
        }

        #region 显示控件

        private Dictionary<DateTime, System.Windows.FrameworkElement> dictDateTimeVisual = new Dictionary<DateTime, System.Windows.FrameworkElement>();
        /// <summary>
        /// Item模板根元素
        /// </summary>
        //private FrameworkElement itemTemplateControl = null;

        private DataTemplate itemTemplate = null;

        /// <summary>
        /// 目标日期
        /// </summary>
        private DateTime targetDate;

        #endregion

        #region 添加ItemTemplate模板



        #endregion

        #region 添加ItemsSource数据源

        //private ItemCollection _items;

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Bindable(true), CustomCategory("Content")]
        //public ItemCollection Items
        //{
        //    get
        //    {
        //        if (this._items == null)
        //        {
        //            this.CreateItemCollectionAndGenerator();
        //        }
        //        return this._items;
        //    }
        //}

        private void CreateItemCollectionAndGenerator()
        {
            //this._items = new ItemCollection(this);
            //this._items.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnItemCollectionChanged1);
            //this._itemContainerGenerator = new System.Windows.Controls.ItemContainerGenerator(this);
            //this._itemContainerGenerator.ChangeAlternationCount();
            //this._items.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnItemCollectionChanged2);
            //if (this.IsInitPending)
            //{
            //    this._items.BeginInit();
            //}
            //else if (base.IsInitialized)
            //{
            //    this._items.BeginInit();
            //    this._items.EndInit();
            //}
            //this._groupStyle.CollectionChanged += new NotifyCollectionChangedEventHandler(this.OnGroupStyleChanged);
        }

        [Bindable(true), CustomCategory("Content"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<DateTime, IEnumerable> ItemsSource
        {
            get
            {
                return (Dictionary<DateTime, IEnumerable>)base.GetValue(ItemsSourceProperty);
            }
            set
            {
                if (value == null)
                {
                    base.ClearValue(ItemsSourceProperty);
                }
                else
                {
                    base.SetValue(ItemsSourceProperty, value);
                }
            }
        }

        [CommonDependencyProperty]
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(Dictionary<DateTime, IEnumerable>), typeof(WorkCalendarEx ), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendarEx .OnItemsSourceChanged)));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendarEx  control = (WorkCalendarEx )d;
            Dictionary<DateTime, IEnumerable> oldValue = (Dictionary<DateTime, IEnumerable>)e.OldValue;
            Dictionary<DateTime, IEnumerable> newValue = (Dictionary<DateTime, IEnumerable>)e.NewValue;
            //((IContainItemStorage)control).Clear();
            control.OnItemsSourceChanged(oldValue, newValue);
        }

        protected virtual void OnItemsSourceChanged(Dictionary<DateTime, IEnumerable> oldValue, Dictionary<DateTime, IEnumerable> newValue)
        {
            if (oldValue != newValue)
            {
                this.CheckTemplateSource();
            }
        }

        #endregion

        #region 模板刷新



        #endregion

        #region 更新ItemTemplate

        [CommonDependencyProperty]
        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(WorkCalendarEx ), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(WorkCalendarEx .OnItemTemplateChanged)));

        [Bindable(true), CustomCategory("Content")]
        public DataTemplate ItemTemplate
        {
            get
            {
                return (DataTemplate)base.GetValue(ItemTemplateProperty);
            }
            set
            {
                base.SetValue(ItemTemplateProperty, value);
            }
        }

        protected virtual void OnItemTemplateChanged(DataTemplate oldItemTemplate, DataTemplate newItemTemplate)
        {
            if (oldItemTemplate != newItemTemplate && newItemTemplate != null)
            {
                this.itemTemplate = newItemTemplate;
                this.CheckTemplateSource();
            }
        }

        private void CheckTemplateSource()
        {
            var tempSource = this.ItemsSource;
            if (tempSource != null)
            {

                var tempDictDateTimeVisual = new Dictionary<DateTime, System.Windows.FrameworkElement>();
                //string xaml = System.Windows.Markup.XamlWriter.Save(this.itemsControl);
                // System.Windows.Markup.XamlReader.Parse(xaml) as System.Windows.Controls.ItemsControl;
                //通过DateTime.Date去掉重复的DateTime
                var lstDate = tempSource.Keys.Select(c => c.Date).Distinct().ToList();
                if (this.CalendarControl == null)
                {
                    this.CalendarControl = new ItemsControl();
                }
                foreach (var date in lstDate)
                {
                    System.Windows.Controls.ItemsControl tempFE = Activator.CreateInstance(this.CalendarControl.GetType()) as System.Windows.Controls.ItemsControl;
                    //{
                    //    //ItemTemplate = this.itemTemplate,
                    //    //ItemsPanel = this.CalendarItemsPanelTemplate,
                    //    Template =  
                    //};
                    //tempFE.Style = this.CalendarControl.Style;
                    //tempFE.MaxHeight = this.CalendarControl.MaxHeight;
                    //tempFE.GroupStyle = this.CalendarControl.GroupStyle;
                    tempFE.GroupStyle.Add(this.CalendarControl.GroupStyle.FirstOrDefault());
                    if (this.itemTemplate != null)
                    {
                        tempFE.ItemTemplate = this.itemTemplate;
                    }

                    var tempDict = tempSource.Where(s => s.Key.Date == date).ToDictionary(s => s.Key, v => v.Value);
                    //var ss = tempDict.Keys;
                    //var sss = tempDict.Values;
                    //获取数据
                    tempFE.ItemsSource = tempDict.Values.FirstOrDefault();
                    tempFE.Background = null;
                    if (GroupName != "")
                    {
                        CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(tempFE.ItemsSource);
                        PropertyGroupDescription groupDescription = new PropertyGroupDescription(GroupName);
                        view.GroupDescriptions.Add(groupDescription);
                    }
                    tempDictDateTimeVisual.Add(date, tempFE);
                }

                //foreach (var _dic in tempSource)
                //{
                //    System.Windows.Controls.ItemsControl tempFE = new ItemsControl
                //    {
                //        ItemTemplate = this.itemTemplate
                //    };

                //    tempFE.ItemsSource = _dic.Value;
                //    tempDictDateTimeVisual.Add(_dic.Key, tempFE);
                //}
                this.dictDateTimeVisual = tempDictDateTimeVisual;
            }
            //更新
            this.BuildCalendar(this.targetDate);
        }

        //private void CheckTemplateSource()
        //{
        //    var tempSource = this.ItemsSource;
        //    if (tempSource != null)
        //    {
        //        var tempDictDateTimeVisual = new Dictionary<DateTime, System.Windows.FrameworkElement>();
        //        //string xaml = System.Windows.Markup.XamlWriter.Save(this.itemsControl);
        //        // System.Windows.Markup.XamlReader.Parse(xaml) as System.Windows.Controls.ItemsControl;
        //        //通过DateTime.Date去掉重复的DateTime
        //        var lstDate = tempSource.Keys.Select(c => c.Date).Distinct().ToList();
        //        foreach (var date in lstDate)
        //        {
        //            System.Windows.Controls.ItemsControl tempFE = new ItemsControl
        //            {
        //                ItemTemplate = this.itemTemplate
        //            };
        //            var tempDict = tempSource.Where(s => s.Key.Date == date).ToDictionary(s => s.Key.Date, v => v.Value);
        //            //var ss = tempDict.Keys;
        //            //var sss = tempDict.Values;
        //            //获取数据
        //            tempFE.ItemsSource = tempDict.Values.FirstOrDefault();
        //            tempDictDateTimeVisual.Add(date, tempFE);
        //        }

        //        //foreach (var _dic in tempSource)
        //        //{
        //        //    System.Windows.Controls.ItemsControl tempFE = new ItemsControl
        //        //    {
        //        //        ItemTemplate = this.itemTemplate
        //        //    };

        //        //    tempFE.ItemsSource = _dic.Value;
        //        //    tempDictDateTimeVisual.Add(_dic.Key, tempFE);
        //        //}
        //        this.dictDateTimeVisual = tempDictDateTimeVisual;
        //    }
        //    //更新
        //    this.BuildCalendar(this.targetDate);
        //}

        private static void OnItemTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((WorkCalendarEx )d).OnItemTemplateChanged((DataTemplate)e.OldValue, (DataTemplate)e.NewValue);
        }



        public ItemsPanelTemplate CalendarItemsPanelTemplate
        {
            get { return (ItemsPanelTemplate)GetValue(CalendarItemsPanelTemplateProperty); }
            set { SetValue(CalendarItemsPanelTemplateProperty, value); }
        }
        // Using a DependencyProperty as the backing store for CalendarItemsPanelTemplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalendarItemsPanelTemplateProperty =
            DependencyProperty.Register("CalendarItemsPanelTemplate", typeof(ItemsPanelTemplate), typeof(WorkCalendarEx), new PropertyMetadata(null));
        
        public ItemsControl CalendarControl
        {
            get { return (ItemsControl)GetValue(CalendarControlProperty); }
            set { SetValue(CalendarControlProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CalendarItemsPanelTemplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalendarControlProperty =
            DependencyProperty.Register("CalendarControl", typeof(ItemsControl), typeof(WorkCalendarEx), new PropertyMetadata(null));



        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GroupName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register("GroupName", typeof(string), typeof(WorkCalendarEx), new PropertyMetadata(""));

        
        



        #endregion

        #region 控制承载Day Number的Grid是否显示 MenuItem

        public static readonly DependencyProperty CanPasteProperty = DependencyProperty.Register("CanPaste", typeof(bool), typeof(WorkCalendarEx), new FrameworkPropertyMetadata(false));

        public bool CanPaste
        {
            get{return (bool)base.GetValue(CanPasteProperty);}
            set{base.SetValue(CanPasteProperty, value);}
        }

        #endregion

    }

    public class DayExChangedEventArgs : EventArgs
    {
        public Day Day { get; private set; }

        public DayExChangedEventArgs(Day day)
        {
            this.Day = day;
        }
    }


}













