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

namespace Orm.Toolkit
{
    public class WorkCalendar  : Control
    {
        public ObservableCollection<Day> Days { get; set; }
        public ObservableCollection<string> DayNames { get; set; }
        public static readonly DependencyProperty CurrentDateProperty = DependencyProperty.Register("CurrentDate", typeof(DateTime), typeof(WorkCalendar), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendar.OnCurrentDateChanged)));

        public event EventHandler<DayChangedEventArgs> DayChanged;

        public DateTime CurrentDate
        {
            get { return (DateTime)GetValue(CurrentDateProperty); }
            set { SetValue(CurrentDateProperty, value); }
        }

        static WorkCalendar ()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WorkCalendar), new FrameworkPropertyMetadata(typeof(WorkCalendar)));
        }

        public WorkCalendar ()
        {
            //DataContext = this;
            //CurrentDate = DateTime.Today;

            //this won't work in Australia where they start the week with Monday. So remember to test in other 
            //places if you plan on using it. 
            DayNames = new ObservableCollection<string> { "星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

            Days = new ObservableCollection<Day>();
            //BuildCalendar(DateTime.Today);
            
        }



        #region 当前日期


        private static void OnCurrentDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendar control = (WorkCalendar)d;
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
            //目标日期
            if (this.targetDate != targetDate)
                this.targetDate = targetDate;

            Days.Clear();


            //Calculate when the first day of the month is and work out an 
            //offset so we can fill in any boxes before that.
            DateTime d = new DateTime(targetDate.Year, targetDate.Month, 1);
            int offset = DayOfWeekNumber(d.DayOfWeek);
            if (offset != 1) d = d.AddDays(-offset);
            else if (offset == 1 && targetDate.Year!=0 && targetDate.Month!=1) d = d.AddDays(-offset);

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

            DayChanged(this, new DayChangedEventArgs(sender as Day));
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
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(Dictionary<DateTime, IEnumerable>), typeof(WorkCalendar ), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendar .OnItemsSourceChanged)));

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendar  control = (WorkCalendar )d;
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
        public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(WorkCalendar ), new FrameworkPropertyMetadata(null, new PropertyChangedCallback(WorkCalendar .OnItemTemplateChanged)));

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
                var lstDate = tempSource.Keys.Select(c =>c.Date).Distinct().ToList();
                foreach (var date in lstDate)
                {
                    System.Windows.Controls.ItemsControl tempFE = new ItemsControl
                    {
                        ItemTemplate = this.itemTemplate
                    };
                    var tempDict=tempSource.Where(s => s.Key.Date == date).ToDictionary(s=>s.Key.Date,v=>v.Value);
                    //var ss = tempDict.Keys;
                    //var sss = tempDict.Values;
                    //获取数据
                    tempFE.ItemsSource = tempDict.Values.FirstOrDefault();
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


        private static void OnItemTemplateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((WorkCalendar )d).OnItemTemplateChanged((DataTemplate)e.OldValue, (DataTemplate)e.NewValue);
        }

        #endregion

        #region 选中的日期

        public Day SelectedDay
        {
            get { return (Day)GetValue(SelectedDayProperty); }
            set { SetValue(SelectedDayProperty, value); }
        }

        public static readonly DependencyProperty SelectedDayProperty = DependencyProperty.Register("SelectedDay", typeof(Day), typeof(WorkCalendar), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendar.OnSelectedDayChanged)));

        private static void OnSelectedDayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendar control = (WorkCalendar)d;
            Day oldValue = (Day)e.OldValue;
            Day newValue = (Day)e.NewValue;
            //((IContainItemStorage)control).Clear();
            control.OnSelectedDayChanged(oldValue, newValue);
        }

        protected virtual void OnSelectedDayChanged(Day oldValue, Day newValue)
        {
            if (oldValue != newValue)
            {
                if (newValue != null)
                {
                    this.SelectedDate = newValue.Date;
                }
            }
        }


        public DateTime SelectedDate
        {
            get { return (DateTime)GetValue(SelectedDateProperty); }
            set { SetValue(SelectedDateProperty, value); }
        }

        public static readonly DependencyProperty SelectedDateProperty = DependencyProperty.Register("SelectedDate", typeof(DateTime), typeof(WorkCalendar), new FrameworkPropertyMetadata(new PropertyChangedCallback(WorkCalendar.OnSelectedDateChanged)));

        private static void OnSelectedDateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCalendar control = (WorkCalendar)d;
            DateTime oldValue = (DateTime)e.OldValue;
            DateTime newValue = (DateTime)e.NewValue;
            //((IContainItemStorage)control).Clear();
            control.OnSelectedDateChanged(oldValue, newValue);
        }

        protected virtual void OnSelectedDateChanged(DateTime oldValue, DateTime newValue)
        {
            if (oldValue != newValue)
            {
              
            }
        }

        #endregion

    }

    public class DayChangedEventArgs : EventArgs
    {
        public Day Day { get; private set; }

        public DayChangedEventArgs(Day day)
        {
            this.Day = day;
        }
    }


}













