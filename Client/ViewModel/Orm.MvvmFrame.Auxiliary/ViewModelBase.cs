using Orm.Model.Custom;
using Orm.Model.EnumDefine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Orm.MvvmFrame.Auxiliary
{
    public class ViewModelBase : ObservableObject, ICleanup
    {
        protected ToolbarStatus _formStatus;
        private bool _isInModify = false;
        private bool _isPrintModify = true;
        private bool _isReadOnly;
        protected string _menuId;
        protected string _helpAddress = string.Empty;
        protected ButtonEnabledModel _buttonEnabled = new ButtonEnabledModel();
        protected List<uspWindowOperFunctionQry> _lstUspWindowOperFunction = new List<uspWindowOperFunctionQry>();

        /// <summary>
        /// 按钮可用状态
        /// </summary>
        public ButtonEnabledModel ButtonEnabled
        {
            get { return _buttonEnabled; }
            protected set { this.SetProperty(ref _buttonEnabled, value); }
        }

        /// <summary>
        /// 是否在可编辑状态，即新增或修改状态
        /// </summary>
        public bool IsInModify { get { return _isInModify; } set { this.SetProperty(ref _isInModify, value); } }

        /// <summary>
        /// 是否在打印状态，即新增或修改状态
        /// </summary>
        public bool IsPrintModify { get { return _isPrintModify; } set { this.SetProperty(ref _isPrintModify, value); } }
        /// <summary>
        /// 是否只读
        /// </summary>
        public bool IsReadOnly { get { return _isReadOnly; } set { this.SetProperty(ref _isReadOnly, value); } }
        /// <summary>
        /// 记录目前操作状态
        /// </summary>
        protected ToolbarStatus FormStatus
        {
            set { _formStatus = value; }
            get { return _formStatus; }
        }
        /// <summary>
        /// Key
        /// </summary>
        public string MenuId
        {
            set
            {
                _menuId = value;
                //_lstUspWindowOperFunction = Orm.Config.Service.UserService.GetUspWindowOperFunction(_menuId, UserProfiles.UserID.ToString());
                HasThisModule();
            }
            get { return _menuId; }
        }

        /// <summary>
        /// 帮助网页地址
        /// </summary>
        public string HelpAddress
        {
            set
            {
                _helpAddress = value;
            }
            get { return _helpAddress; }
        }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public string InvoNo { get; set; }

        #region 命令声明
        public ICommand ShortcutKeysCommand { get; protected set; }
        /// <summary>
        /// 加载上一张事件
        /// </summary>
        public ICommand LoadPreviousCommand { get; protected set; }
        /// <summary>
        /// 加载下一张事件
        /// </summary>
        public ICommand LoadNextCommand { get; protected set; }
        /// <summary>
        /// 查找命令（刷新）
        /// </summary>
        public ICommand SearchCommand { get; protected set; }
        /// <summary>
        /// 增加命令
        /// </summary>
        public ICommand AddCommand { get; protected set; }
        /// <summary>
        /// 修改命令
        /// </summary>
        public ICommand ModifyCommand { get; protected set; }
        /// <summary>
        /// 删除命令
        /// </summary>
        public ICommand DeleteCommand { get; protected set; }
        /// <summary>
        /// 取消命令
        /// </summary>
        public ICommand CancelCommand { get; protected set; }
        /// <summary>
        /// 保存命令
        /// </summary>
        public ICommand SaveCommand { get; protected set; }
        /// <summary>
        /// 审核命令
        /// </summary>
        public ICommand AuditCommand { get; protected set; }
        /// <summary>
        /// 刷新命令
        /// </summary>
        public ICommand RefreshCommand { get; protected set; }
        /// <summary>
        /// 打印命令
        /// </summary>
        public ICommand PrintCommand { get; protected set; }
        /// <summary>
        /// 导出Excel命令
        /// </summary>
        public ICommand ExportCommand { get; protected set; }

        /// <summary>
        ///返回退出命令
        /// </summary>
        public ICommand ReturnCommand { get; protected set; }
        /// <summary>
        /// 取消审核命令
        /// </summary>
        public ICommand CancelAuditCommand { get; protected set; }

        /// <summary>
        /// 帮助Click事件命令
        /// </summary>
        public ICommand HelpClickCommand { get; private set; }

        /// <summary>
        /// 导入命令
        /// </summary>
        public ICommand TmportCommand { get; protected set; }
        /// <summary>
        /// 分页
        /// </summary>
        public ICommand DataPagerChangedCommand { get; protected set; }

        #endregion

        #region 初始化信息
        /// <summary>
        /// 整体初始化
        /// </summary>
        void Init()
        {
            InitCommand();
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        protected virtual void LoadData() { }
        /// <summary>
        /// 初始化控件
        /// </summary>
        protected virtual void InitControl() { }
        /// <summary>
        /// 命令初始化
        /// </summary>
        protected virtual void InitCommand()
        {
            this.HelpClickCommand = new ViewModelCommand((object parameter) => { this.HelpClickExecute(); });

            this.ShortcutKeysCommand = new RelayCommand<EventInformation<RoutedEventArgs>>((eventInfo) => { this.ShortcutKeys(eventInfo); });

            this.LoadPreviousCommand = new ViewModelCommand((object parameter) => { this.Previous(); });

            this.LoadNextCommand = new ViewModelCommand((object parameter) => { this.Next(); });

            this.SearchCommand = new ViewModelCommand((object parameter) => { this.Search(); });

            this.AddCommand = new ViewModelCommand((object parameter) => { this.AddNew(); SetControlStatus(ToolbarStatus.Add); });

            this.ModifyCommand = new ViewModelCommand((object parameter) => { if (!CanModify()) return; this.Modify(); SetControlStatus(ToolbarStatus.Edit); });

            this.DeleteCommand = new ViewModelCommand((object parameter) => { if (!CanDelete()) return; this.Delete(); });

            this.CancelCommand = new ViewModelCommand((object parameter) => { this.Cancel(); SetControlStatus(ToolbarStatus.View); });

            this.SaveCommand = new ViewModelCommand((object parameter) =>
            {
                if (!CheckValidate()) return;
                if (this.Save())
                {
                    SetControlStatus(ToolbarStatus.View);
                }
            });

            this.AuditCommand = new ViewModelCommand((object parameter) => { this.Audit(); SetControlStatus(ToolbarStatus.View); });

            this.CancelAuditCommand = new ViewModelCommand((object parameter) => { this.CancelAudit(); SetControlStatus(ToolbarStatus.View); });

            this.PrintCommand = new ViewModelCommand((object parameter) => { this.Print(); });

            this.ExportCommand = new ViewModelCommand((object parameter) => { this.Export(parameter); });

            this.ReturnCommand = new ViewModelCommand((object parameter) => { this.End(); });

            this.TmportCommand = new ViewModelCommand((object parameter) => { this.Tmport(); });
            DataPagerChangedCommand = new ViewModelCommand((object parameter) => { this.DataPagerChangedExecute(); });
        }

        #endregion

        #region 其他方法
        /// <summary>
        /// 系统提示
        /// </summary>
        /// <param name="firstModul">一级菜单</param>
        /// <param name="twoModul">二级菜单，界面名称</param>
        /// <param name="audit">操作类型</param>
        /// <returns>true,没有权限，请于管理员联系，否则相反</returns>
        public virtual bool GetIsCanAccessThisModuleReturn(EnumCanAccessFirstModul firstModul, EnumCanAccesTwoModul twoModul, EnumAudit audit)
        {
            //自动化测试中跳过权限限制
            if (Orm.Config.UserProfiles.blnPassTest == true)
            {
                return true;
            }
            bool returnValue = false;
            if (!IsCanAccessThisModule(firstModul.GetType().ToString(), twoModul.GetType().ToString(), audit.GetType().ToString()))
            {
                returnValue = true;
            }
            return returnValue;
        }


        /// <summary>
        /// 判断数据有效性
        /// </summary>
        /// <returns></returns>
        protected virtual bool CheckValidate()
        {
            return true;
        }

        /// <summary>
        /// 判断是否能进入修改状态
        /// </summary>
        /// <returns></returns>
        protected virtual bool CanModify() { return true; }

        /// <summary>
        /// 判断是否能进行删除操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool CanDelete() { return true; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual bool IsModify()
        {
            return true;
        }
        /// <summary>
        /// 判断系统权限
        /// </summary>
        /// <param name="fuction"></param>
        /// <param name="show">是否弹出提示</param>
        /// <returns></returns>
        public bool IsCanAccessThisModule(FuctionAccess fuction, bool show)
        {
            if (_lstUspWindowOperFunction.Where(t => t.FunctionId == ((int)fuction).ToString()).ToArray().Length > 0)
                return true;
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断是否有某一操作的权限
        /// </summary>
        /// <param name="menuName">一级菜单名称</param>
        /// <param name="pageName">二级菜单名称</param>
        /// <param name="functionName">功能名称</param>
        /// <returns></returns>
        public static bool IsCanAccessThisModule(string menuName, string pageName, string functionName)
        {
            //自动化测试中跳过权限限制
            if (Orm.Config.UserProfiles.blnPassTest == true)
            {
                return true;
            }
            var a = Orm.Config.UserProfiles.CurrentAuthority;
            if (a == null || a.Count == 0)
            {
                return false;
            }
            foreach (var menu in a)
            {
                if (menu.Key.Title == menuName)
                {
                    foreach (var page in menu.Value)
                    {
                        if (page.Key.Title == pageName)
                        {
                            foreach (var function in page.Value)
                            {
                                if (function.Key.Title == functionName)
                                {
                                    return true;
                                }
                            }
                            Toolkit.MessageBox.Show($"你没有{pageName}的相关权限,请与系统管理员联系！", "系统提示");
                            return false;
                        }
                    }
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// 判断是否有某一操作的权限
        /// </summary>
        /// <param name="menuName">一级菜单名称</param>
        /// <param name="pageName">二级菜单名称</param>
        /// <param name="functionName">功能名称</param>
        /// <returns></returns>
        public static bool IsCanAccessThisModule(string menuName, string pageName, string functionName, bool isTrue = true)
        {
            //自动化测试中跳过权限限制
            if (Orm.Config.UserProfiles.blnPassTest == true)
            {
                return true;
            }
            var a = Orm.Config.UserProfiles.CurrentAuthority;
            if (a == null || a.Count == 0)
            {
                return false;
            }
            foreach (var menu in a)
            {
                if (menu.Key.Title == menuName)
                {
                    foreach (var page in menu.Value)
                    {
                        if (page.Key.Title == pageName)
                        {
                            foreach (var function in page.Value)
                            {
                                if (function.Key.Title == functionName)
                                {
                                    return true;
                                }
                            }
                            if (isTrue)
                            {
                                Toolkit.MessageBox.Show($"你没有{pageName}的相关权限,请与系统管理员联系！", "系统提示");
                            }
                            return false;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// 给子类重写，在获取到当前模块权限列表后执行，一般用于判断是否有某个权限
        /// </summary>
        protected virtual void HasThisModule() { }
        /// <summary>
        /// 判断单据是否审核
        /// </summary>
        /// <returns></returns>
        protected virtual bool BillIsAudit()
        {
            return false;
        }
        public virtual void SetTabIndex()
        {

        }
        /// <summary>
        /// 按钮快捷键
        /// </summary>
        /// <param name="eventInfo"></param>
        protected void ShortcutKeys(EventInformation<RoutedEventArgs> eventInfo)
        {
            System.Windows.Input.KeyEventArgs e = eventInfo.EventArgs as System.Windows.Input.KeyEventArgs;
            switch (e.Key)
            {
                case Key.F1:
                    if (ButtonEnabled.Previous == false) break;
                    this.Previous();
                    break;
                case Key.F2:
                    if (ButtonEnabled.Next == false) break;
                    this.Next();
                    break;
                case Key.F3:
                    if (ButtonEnabled.Search == false) break;
                    this.Search();
                    break;
                case Key.F4:
                    if (ButtonEnabled.Add == false) break;
                    SetControlStatus(ToolbarStatus.Add);
                    this.AddNew();
                    break;
                case Key.F5:
                    if (ButtonEnabled.Modify == false) break;
                    if (!CanModify()) break;
                    SetControlStatus(ToolbarStatus.Edit);
                    this.Modify();
                    break;
                case Key.F6:
                    if (ButtonEnabled.Delete == false) break;
                    if (!CanDelete()) break;
                    this.Delete();
                    break;
                case Key.F7:
                    if (ButtonEnabled.Cancel == false) break;
                    this.Cancel();
                    SetControlStatus(ToolbarStatus.View);
                    break;
                case Key.F8:
                    if (ButtonEnabled.Save == false) break;
                    if (!CheckValidate()) break;
                    if (this.Save())
                    {
                        SetControlStatus(ToolbarStatus.View);
                    }
                    break;
                case Key.F9:
                    if (ButtonEnabled.Audit == false) break;
                    this.Audit();
                    SetControlStatus(ToolbarStatus.View);
                    break;
                case Key.F10:
                    if (ButtonEnabled.Refresh == false) break;
                    this.BtnRefreshExecute();
                    break;
                case Key.F11:
                    if (ButtonEnabled.Print == false) break;
                    this.Print();
                    break;
                case Key.F12:
                    if (ButtonEnabled.Export == false) break;
                    this.Export(eventInfo.CommandArgument);
                    break;
                case Key.Escape:
                    this.End();
                    break;
            }
        }
        #endregion

        #region 按钮命令执行
        /// <summary>
        /// 上一张
        /// </summary>
        protected virtual void Previous() { }
        /// <summary>
        /// 下一张
        /// </summary>
        protected virtual void Next() { }
        /// <summary>
        /// 查询
        /// </summary>
        protected virtual void Search() { }
        /// <summary>
        /// 新增
        /// </summary>
        protected virtual void AddNew() { }
        /// <summary>
        /// 修改
        /// </summary>
        protected virtual void Modify() { }
        /// <summary>
        /// 删除
        /// </summary>
        protected virtual void Delete() { }//MessageBox.Show("确定删除当前项?", "系统提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        /// <summary>
        /// 取消
        /// </summary>
        protected virtual void Cancel() { }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        protected virtual bool Save() { return false; }
        /// <summary>
        /// 新增 保存
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveNew()
        {
            return false;
        }
        /// <summary>
        /// 修改 保存
        /// </summary>
        /// <returns></returns>
        public virtual bool SaveModify()
        {
            return false;
        }
        /// <summary>
        /// 打印
        /// </summary>
        protected virtual void Print() { }
        /// <summary>
        /// 导出
        /// </summary>
        protected virtual void Export(object parameter) { }
        /// <summary>
        /// 取消审核
        /// </summary>
        protected virtual bool CancelAudit() { return true; }
        /// <summary>
        /// 审核、结转记账
        /// </summary>
        /// <returns></returns>
        protected virtual bool Audit()
        {
            return true;
        }
        /// <summary>
        /// 刷新
        /// </summary>
        protected virtual void BtnRefreshExecute() { }
        /// <summary>
        /// 返回、退出
        /// </summary>
        protected virtual void End() { }

        /// <summary>
        /// 导入
        /// </summary>
        protected virtual void Tmport() { }

        protected virtual void DataPagerChangedExecute() { }
        private void HelpClickExecute()
        {
            Encoding gb2312 = Encoding.GetEncoding("GB2312");
            string uri = HelpAddress;
            //MessageBox.Show(this.MenuId.ToString() + "  " + uri);

            string assemblyName = "Orm.Client.Base";
            string typeName = "Orm.Client.Base.BaseForm.HelpWebWindow";
            bool flag = true;
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType().FullName == typeName)
                {
                    window.GetType().GetProperty("UriFromString").SetValue(window, uri, null);
                    window.Activate();
                    window.Topmost = true;
                    window.Topmost = false;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                var tempObj = AppDomain.CurrentDomain.CreateInstance(assemblyName, typeName).Unwrap();
                if (tempObj != null && tempObj is Window)
                {
                    tempObj.GetType().GetProperty("UriFromString").SetValue(tempObj, uri, null);
                    (tempObj as Window).Show();
                }
            }


        }
        #endregion

        #region 状态及按钮的可用控制
        /// <summary>
        /// 设置控件状态
        /// </summary>
        /// <param name="toolBarStatus"></param>
        protected virtual void SetControlStatus(ToolbarStatus toolBarStatus)
        {
            this.FormStatus = toolBarStatus;
            if (toolBarStatus == ToolbarStatus.View)
            {
                IsInModify = false;
                IsReadOnly = true;
                ViewButtonStatus();
            }
            else
            {
                IsInModify = true;
                IsReadOnly = false;
                AddOrEditButtonStatus();
            }
        }
        /// <summary>
        /// 添加和编辑按钮的初始状态
        /// </summary>
        protected void AddOrEditButtonStatus()
        {
            this.ButtonEnabled.Previous = false;
            this.ButtonEnabled.Next = false;
            this.ButtonEnabled.Search = true;
            this.ButtonEnabled.Add = false;
            this.ButtonEnabled.Modify = false;
            this.ButtonEnabled.Delete = false;
            this.ButtonEnabled.Save = true;
            this.ButtonEnabled.Cancel = true;
            this.ButtonEnabled.Audit = false;
            this.ButtonEnabled.CancelAudit = false;
            this.ButtonEnabled.Refresh = false;
            this.ButtonEnabled.Print = false;
            this.ButtonEnabled.Export = false;
        }

        protected void SetButtonBaseStatus(bool enabled)
        {
            this.ButtonEnabled.Modify = enabled;
            this.ButtonEnabled.Delete = enabled;
            this.ButtonEnabled.Audit = enabled;
        }
        protected void ViewButtonStatus()
        {
            //单据或其他记录已经审核或记账,将不可删改。如没有审核操作，不重写BillIsAudit()即可
            if (this.BillIsAudit())
            {
                this.ButtonEnabled.Previous = true;
                this.ButtonEnabled.Next = true;
                this.ButtonEnabled.Search = true;
                this.ButtonEnabled.Add = true;
                this.SetButtonBaseStatus(false);
                this.ButtonEnabled.Save = false;
                this.ButtonEnabled.Cancel = false;
                this.ButtonEnabled.Refresh = true;
                this.ButtonEnabled.Print = true;
                this.ButtonEnabled.Export = true;
                this.ButtonEnabled.CancelAudit = true;
            }
            else
            {
                this.ButtonEnabled.Previous = true;
                this.ButtonEnabled.Next = true;
                this.ButtonEnabled.Search = true;
                this.ButtonEnabled.Add = true;
                this.SetButtonBaseStatus(true);
                this.ButtonEnabled.Save = false;
                this.ButtonEnabled.Cancel = false;
                this.ButtonEnabled.Refresh = true;
                this.ButtonEnabled.Print = true;
                this.ButtonEnabled.Export = true;
                this.ButtonEnabled.CancelAudit = false;
            }
        }
        #endregion


        #region 构造函数

        public ViewModelBase()
            : this(null)
        {

        }

        public ViewModelBase(IEventAggregator eventAggregator)
        {
            this.EventAggregatorInstance = eventAggregator;
            Init();
        }

        #endregion

        #region 是否在设计模式下

        private static bool? _isInDesignMode;

        #endregion

        #region 消息事件机制

        private IEventAggregator _eventAggregatorInstance;

        #endregion

        #region 清理操作

        /// <summary>
        /// 清理订阅的消息
        /// </summary>
        public virtual void Cleanup()
        {
            this.EventAggregatorInstance.Unsubscribe(this);
        }

        #endregion

        #region 属性

        protected IEventAggregator EventAggregatorInstance
        {
            get
            {
                return (this._eventAggregatorInstance ?? EventAggregator.Default);
            }

            set
            {
                this._eventAggregatorInstance = value;
            }
        }

        public bool IsInDesignMode
        {
            get
            {
                return IsInDesignModeStatic;
            }
        }

        #endregion

        #region 判断是否在设计状态下

        public static bool IsInDesignModeStatic
        {
            get
            {
                if (!_isInDesignMode.HasValue)
                {
                    var prop = DesignerProperties.IsInDesignModeProperty;
                    _isInDesignMode = (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
                }
                return _isInDesignMode.Value;
            }
        }

        #endregion

        private int _pageIndex = 1;
        public int PageIndex
        {
            get { return _pageIndex; }
            set { this.SetProperty(ref _pageIndex, value); }
        }

        private int _pageSize = 0;
        public int PageSize
        {
            get { return _pageSize; }
            set { this.SetProperty(ref _pageSize, value); }
        }

        private int _totalCount = 0;
        public int TotalCount
        {
            get { return _totalCount; }
            set { this.SetProperty(ref _totalCount, value); }
        }

    }

}
