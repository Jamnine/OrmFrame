using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Windows.Controls
{


    [TemplateVisualState()]
    public class HubTile : Control
    {
        /// <summary>
        /// 图片状态
        /// </summary>
        private const string ImageStates = "ImageState";
        /// <summary>
        /// 展开状态
        /// </summary>
        private const string Expanded = "Expanded";
        /// <summary>
        /// 半展开状态
        /// </summary>
        private const string Semiexpanded = "Semiexpanded";
        /// <summary>
        /// 真正隐藏状态
        /// </summary>
        private const string Collapsed = "Collapsed";
        /// <summary>
        /// 翻卷状态
        /// </summary>
        private const string Flipped = "Flipped";
        /// <summary>
        /// 通知块 - 模板部件名称
        /// </summary>
        private const string NotificationBlock = "NotificationBlock";
        /// <summary>
        /// 消息块 - 模板部件名称
        /// </summary>
        private const string MessageBlock = "MessageBlock";
        /// <summary>
        /// 回到标题块 - 模板部件名称
        /// </summary>
        private const string BackTitleBlock = "BackTitleBlock";
        /// <summary>
        /// 标题栏 - 模板部件名称
        /// </summary>
        private const string TitlePanel = "TitlePanel";

        /// <summary>
        /// 通知块 - 模板部件
        /// </summary>
        //private TextBlock _notificationBlock;
        /// <summary>
        /// 消息块 - 模板部件
        /// </summary>
        //private TextBlock _messageBlock;
        /// <summary>
        /// 标题栏 - 模板部件
        /// </summary>
        //private Panel _titlePanel;
        /// <summary>
        /// 回到标题块 - 模板部件
        /// </summary>
        //private TextBlock _backTitleBlock;

        /// <summary>
        /// 失速计时器
        /// 代表在停滞的图像这个界面的停滞步数
        /// </summary>
        //internal int _stallingCounter;
        /// <summary>
        /// 磁贴是否会下降动画
        /// </summary>
        //internal bool _canDrop;
        /// <summary>
        /// 磁贴是否会翻卷动画
        /// </summary>
        //internal bool _canFlip;

        #region 标题栏依赖属性

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty,value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title",typeof(string),typeof(HubTile),new PropertyMetadata(string.Empty,OnTitleChanged));

        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region 尺寸依赖属性

        public TileSize Size
        {
            get { return (TileSize)GetValue(SizeProperty); }
            set { SetValue(SizeProperty,value); }
        }

        public static readonly DependencyProperty SizeProperty = DependencyProperty.Register("Size",typeof(TileSize),typeof(HubTile),new PropertyMetadata(TileSize.Default,OnSizeChanged));

        private static void OnSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

      
        #endregion

        #region 图片资源依赖属性
        /// <summary>
        /// 获取或设置图片资源
        /// </summary>
        public ImageSource Source { 
            get{ return (ImageSource)GetValue(SourceProperty);}
            set{SetValue(SourceProperty,value);}
        }
        /// <summary>
        /// 标识依赖属性的来源
        /// </summary>
        public static readonly DependencyProperty SourceProperty=DependencyProperty.Register("Source",typeof(ImageSource),typeof(HubTile),new PropertyMetadata(null));

        #endregion

        #region 状态依赖属性

        internal ImageState State
        {
            get { return (ImageState)GetValue(StateProperty); }
            set { SetValue(StateProperty,value); }
        }

        private static readonly DependencyProperty StateProperty = DependencyProperty.Register("State", typeof(ImageState), typeof(HubTile), new PropertyMetadata(ImageState.Expanded,OnImageStateChanged));


        private static void OnImageStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // throw new System.NotImplementedException();
        }
 
        #endregion

        #region 通知依赖属性

        public string Notification
        {
            get { return (string)GetValue(NotificationProperty); }
            set { SetValue(NotificationProperty,value); }
        }

        public static readonly DependencyProperty NotificationProperty = DependencyProperty.Register("Notification",typeof(string),typeof(HubTile),new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnBackContentChanged)));
        /// <summary>
        /// 如果没有通知警报信息也不能被设置，防止磁贴过度到一个翻转状态
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnBackContentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region 消息依赖属性

        public string Message
        { 
            get{ return (string)GetValue(MessageProperty);}
            set{ SetValue(MessageProperty,value);}
        }

        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message",typeof(string),typeof(HubTile),new PropertyMetadata(string.Empty,new PropertyChangedCallback(OnBackContentChanged)));

        #endregion

        #region 显示通知依赖属性
        /// <summary>
        /// 获取或设置新的通知标识
        /// </summary>
        public bool DisplayNotification
        {
            get { return (bool)GetValue(DisplayNotificationProperty); }
            set { SetValue(DisplayNotificationProperty,value); }
        }

        public static readonly DependencyProperty DisplayNotificationProperty = DependencyProperty.Register("DisplayNotification",typeof(bool),typeof(HubTile),new PropertyMetadata(false,new PropertyChangedCallback(OnBackContentChanged)));

        #endregion

        #region 是否冻结依赖属性
        /// <summary>
        /// 获取或设置一个标识，图片不能触发动画
        /// </summary>
        public bool IsFrozen { get { return (bool)GetValue(IsFrozenProperty); } set { SetValue(IsFrozenProperty,value); } }

        public static readonly DependencyProperty IsFrozenProperty = DependencyProperty.Register("IsFrozen",typeof(bool),typeof(HubTile),new PropertyMetadata(false,new PropertyChangedCallback(OnIsFrozenChanged)));

        private static void OnIsFrozenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region 组标签依赖属性

        public string GroupTag
        {
            get { return (string)GetValue(GroupTagProperty); }
            set { SetValue(GroupTagProperty,value); }
        }

        public static readonly DependencyProperty GroupTagProperty = DependencyProperty.Register("GroupTag",typeof(string),typeof(HubTile),new PropertyMetadata(string.Empty));
        
        #endregion

        /// <summary>
        /// 更新视觉状态
        /// </summary>
        private void UpdateVisualState()
        {
            //如果我们是小尺寸，我们仅仅只需要显示图片，否则触发动画


        }

        /// <summary>
        /// 获取和设置绑定模板部件
        /// </summary>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public HubTile()
        {
            this.Loaded += HubTile_Loaded;
            this.Unloaded += HubTile_Unloaded;
        }
        /// <summary>
        /// 磁贴界面加载完成后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void HubTile_Loaded(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 当磁贴从元素树中移除时发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void HubTile_Unloaded(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

   


    }
    /// <summary>
    /// 表示图片视觉状态
    /// </summary>
    internal enum ImageState
    { 
        /// <summary>
        /// 展开状态
        /// </summary>
        Expanded=0,
        /// <summary>
        /// 半展开状态
        /// </summary>
        Semiexpanded=1,
        /// <summary>
        /// 真正隐藏状态
        /// </summary>
        Collapsed=2,
        /// <summary>
        /// 翻卷状态
        /// </summary>
        Flipped=3,
    };

    public enum TileSize
    { 
        /// <summary>
        /// 默认尺寸173 px x 173 px
        /// </summary>
        Default,
        /// <summary>
        /// 小尺寸 99 px x 99 px
        /// </summary>
        Small,
        /// <summary>
        /// 中等尺寸 210 px x 210 px
        /// </summary>
        Medium,
        /// <summary>
        /// 大尺寸 432 px x 210 px
        /// </summary>
        Large,
    };

}
