using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Diagnostics;
using System.Windows.Input;
using System.ComponentModel;
using Orm.Toolkit.Core.ViewModels;
using Orm.Toolkit.Core.Utilities;

namespace Orm.Toolkit
{
    public class DownloadItem : Orm.Toolkit.Core.ViewModels.ViewModel
    {
          #region Fields
        private const string SHELL = "explorer.exe";
        private string file;
        WebClient client;

        DelegateCommand openCommand;
        DelegateCommand openFolderCommand;
        DelegateCommand cancelCommand;
        DelegateCommand startCommand;
        DelegateCommand pauseCommand;
        DelegateCommand removeCommand;

        private Stopwatch stopwatch = new Stopwatch();

        private Action<string, string, Func<bool>, Func<bool>, Action<int, long, long>, Action<bool, string>> downAction;

        private Action removeAction;

        #endregion

        #region Ctors

        public DownloadItem(string url, string file, Action<string, string, Func<bool>, Func<bool>, Action<int, long, long>, Action<bool, string>> downAction,Action removeAction)
            : this(url, file)
        {
            this.downAction = downAction;
            this.removeAction = removeAction;
        }

        public DownloadItem(string url, string file)
        {
            if ( String.IsNullOrEmpty( url ) )
                throw new ArgumentNullException( "url" );

            if ( String.IsNullOrEmpty( file ) )
                throw new ArgumentNullException( "file" );

            this.URL = url;
            this.FileName = new FileInfo( file ).Name;
            this.file = file;

            openCommand = new DelegateCommand( OnOpenDownloadedFile, CanOpenDownloadedFile );
            this.Commands.Add( openCommand );
            openFolderCommand = new DelegateCommand(OnOpenDownloadedFileFolder, CanOpenDownloadedFileFolder);
            this.Commands.Add( openFolderCommand );
            cancelCommand = new DelegateCommand(OnCancelDownloaded,CanCancelDownloaded);
            this.Commands.Add(cancelCommand);
            startCommand = new DelegateCommand(OnStartDownloaded,CanStartDownloaded);
            this.Commands.Add(startCommand);
            pauseCommand = new DelegateCommand(OnPauseDownloaded,CanPauseDownloaded);
            this.Commands.Add(pauseCommand);
            removeCommand = new DelegateCommand(OnRemoveDownloaded,CanRemoveDownloaded);
            this.Commands.Add(removeCommand);

        }
        #endregion


        #region Overrides
        public override int GetHashCode()
        {
            return String.Format( "{0}_{1}", _URL, file ).GetHashCode();
        }

        public override bool Equals( object obj )
        {
            if (obj is DownloadItem)
                return this == (DownloadItem)obj;

            return false;
        }

        protected override void OnDispose()
        {
            base.OnDispose();

            file = null;
            client = null;
            openCommand = null;
            openFolderCommand = null;
        }
        #endregion

        #region Methods
        public void Start()
        {
            if (!IsDownloading && this.downAction!=null)
            {
                this.stopwatch.Restart();
                try
                {
                    this.downAction(this.URL, this.file, CancelDownload, PauseDownload, DownloadProgressChanged, DownloadCompleted);
                }
                catch (Exception ex)
                {
                    CommandManager.InvalidateRequerySuggested();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                this.TotalBytes = -1; //long.Parse("N/A");
                this.IsCanceled = false;
                this.IsComplete = false;
                this.IsDownloading = true;
                CommandManager.InvalidateRequerySuggested();
                return;
            }

            if (!IsDownloading)
            {
                this.stopwatch.Restart();
                this.DownloadFile();
            }
        }

        public void Cancel()
        {
            if (this.downAction != null)
            {
                this.IsCanceled = true;
                return;
            }

            if (client!=null && client.IsBusy)
                client.CancelAsync();
        }

        private void DownloadFile()
        {
            if ( client == null )
                client = new WebClient();

            DownloadProgressChangedEventHandler progressHandler = ( sender, e ) =>
            {
                 if(Convert.ToInt32(this.stopwatch.ElapsedMilliseconds)>=this.Interval)
                 {
                     this.stopwatch.Stop();
                     this.Progress = e.ProgressPercentage;
                     this.TotalBytes = e.TotalBytesToReceive;
                     this.CurrentSpeed = ComputingSpeed(Convert.ToInt32(this.stopwatch.ElapsedMilliseconds), (e.BytesReceived - this.DownloadBytes));
                     this.DownloadBytes = e.BytesReceived;
                     this.stopwatch.Restart();
                     CommandManager.InvalidateRequerySuggested();
                 }
            };

            AsyncCompletedEventHandler completeHandler = null;
            completeHandler = ( sender, e ) =>
            {
                this.stopwatch.Stop();
                using ( client )
                {
                    client.DownloadProgressChanged -= progressHandler;
                    client.DownloadFileCompleted -= completeHandler;
                   
                    this.IsCanceled = e.Cancelled;
                    this.IsDownloading = false;
                   
                    if ( !e.Cancelled && File.Exists( file ) )
                    {
                        //this.TotalBytes = new FileInfo(file).GetFileSize();
                        //this.IsComplete = true;

                        this.IsComplete = true;
                        this.CurrentSpeed = 0;
                        this.TotalBytes = new FileInfo(file).Length;
                    }

                    CommandManager.InvalidateRequerySuggested();
                }

                client = null;
            };

            client.DownloadProgressChanged += progressHandler;
            client.DownloadFileCompleted += completeHandler;
          
            try
            {
                client.DownloadFileAsync( new Uri( this.URL ), file);
            }
            catch ( Exception ex )
            {
                CommandManager.InvalidateRequerySuggested();
                MessageBox.Show( ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error );
                return;
            }

            this.TotalBytes =-1; //long.Parse("N/A");
            this.IsCanceled = false;
            this.IsComplete = false;
            this.IsDownloading = true;

            CommandManager.InvalidateRequerySuggested();
        }

        #endregion

        #region Properties
        private string _URL;
        public string URL
        {
            get
            {
                return _URL;
            }
            protected set
            {
                if ( String.Compare( _URL, value, true ) == 0 )
                    return;

                _URL = value;
                RaisePropertyChanged( "URL" );
            }
        }


        private int _Progress;
        public int Progress
        {
            get
            {
                return _Progress;
            }
            protected set
            {
                if ( _Progress == value )
                    return;

                _Progress = value;
                RaisePropertyChanged( "Progress" );
            }
        }


        private bool _IsDownloading;
        public bool IsDownloading
        {
            get
            {
                return _IsDownloading;
            }
            protected set
            {
                if ( _IsDownloading == value )
                    return;

                _IsDownloading = value;
                RaisePropertyChanged( "IsDownloading" );
            }
        }


        private bool _IsCanceled;
        public bool IsCanceled
        {
            get
            {
                return _IsCanceled;
            }
            protected set
            {
                if ( _IsCanceled == value )
                    return;

                _IsCanceled = value;
                RaisePropertyChanged("IsCanceled");
            }
        }


        private string _FileName;
        public string FileName
        {
            get
            {
                return _FileName;
            }
            protected set
            {
                if ( String.Compare( _FileName, value, true ) == 0 )
                    return;

                _FileName = value;
                RaisePropertyChanged( "FileName" );
            }
        }

        private long _TotalBytes;
        public long TotalBytes
        {
            get
            {
                return _TotalBytes;
            }
            protected set
            {
                //if ( String.Compare( _TotalBytes, value, true ) == 0 )
                //    return;
                if (value == 0 || _TotalBytes==value)
                {
                    return;
                }
                _TotalBytes = value;
                RaisePropertyChanged("TotalBytes");
            }
        }

        private long _DownloadBytes;
        /// <summary>
        /// 已下载的字节数
        /// </summary>
        public long DownloadBytes
        {
            get { return _DownloadBytes; }
            set {
                if (_DownloadBytes == value)
                    return;
                _DownloadBytes = value;
                RaisePropertyChanged("DownloadBytes");
            }
        }

        private int _Interval=500;
        /// <summary>
        /// 间隔时间 毫秒计
        /// </summary>
        public int Interval
        {
            get { return _Interval; }
            set {
                if (_Interval == value)
                    return;
                _Interval = value;
                RaisePropertyChanged("Interval");
            }
        }

        private bool _IsComplete;
        public bool IsComplete
        {
            get
            {
                return _IsComplete;
            }
            protected set
            {
                if ( _IsComplete == value )
                    return;

                _IsComplete = value;
                RaisePropertyChanged("IsComplete");
            }
        }

        private long _CurrentSpeed;

        public long CurrentSpeed { 
            get { return _CurrentSpeed; } 
            set {
                if (_CurrentSpeed == value)
                    return;
                _CurrentSpeed = value;
                RaisePropertyChanged("CurrentSpeed");
             } }

        public ICommand OpenDownloadedFileCommand
        {
            get
            {
                return openCommand;
            }
        }

        public ICommand OpenDownloadedFileFolderCommand
        {
            get
            {
                return openFolderCommand;
            }
        }

        public ICommand CancelCommand
        {
            get {
                return cancelCommand;
            }
        }

        public ICommand StartCommand
        {
            get {
                return startCommand;
            }
        }

        public ICommand PauseCommand
        {
            get
            {
                return pauseCommand;
            }
        }

        public ICommand RemoveCommand
        {
            get {
                return removeCommand;
            }
        }
       
        #endregion

        #region Operators
        public static bool operator ==(DownloadItem d1, DownloadItem d2)
        {
            if ( Object.ReferenceEquals( d1, null ) )
                return Object.ReferenceEquals( d2, null );

            if ( Object.ReferenceEquals( d2, null ) )
                return Object.ReferenceEquals( d1, null );

            return String.Compare( d1.URL, d2.URL, true ) == 0 &&
                String.Compare( d1.file, d2.file, true ) == 0;
        }

        public static bool operator !=(DownloadItem d1, DownloadItem d2)
        {
            return !( d1 == d2 );
        }
        #endregion

        #region Event Handlers
        private void OnOpenDownloadedFile()
        {
            if ( IsComplete && File.Exists( file ) )
            {
                try
                {
                    Process.Start( file );
                }
                catch { }
            }
        }

        private void OnOpenDownloadedFileFolder()
        {
            if ( IsComplete && File.Exists( file ) )
            {
                try
                {
                    Process.Start( SHELL, String.Format( @"/select, ""{0}""", file ) );
                }
                catch { }
            }
        }

        private bool CanOpenDownloadedFileFolder()
        {
            return !IsCanceled;
        }

        private bool CanOpenDownloadedFile()
        {
            return !IsCanceled;
        }


        private void OnCancelDownloaded()
        {
            Cancel();
            //if (this.client != null)
            //{
            //    this.client.CancelAsync();
            //    this.IsDownloading = false;
            //    this.IsCanceled = true;
            //}
        }

        private bool CanCancelDownloaded()
        {
            return !IsCanceled;
        }

        private void OnStartDownloaded()
        {
            if (this.client != null)
            {

            }

            this.IsDownloading = true;
        }

        private bool CanStartDownloaded()
        {
            return true;
        }

        private void OnPauseDownloaded()
        {
            if (this.client != null)
            { 
               
            }

            this.IsDownloading = false;
        }

        private bool CanPauseDownloaded()
        {
            return true;
        }

        private void OnRemoveDownloaded()
        {
            if (this.removeAction != null)
            {
                this.removeAction();
                this.Dispose();
            }
        }

        private bool CanRemoveDownloaded()
        {
            return true;
        }

        #endregion

        /// <summary>
        /// 计算下载速度
        /// </summary>
        /// <param name="milliseconds"></param>
        private long ComputingSpeed(int milliseconds, long haveDownloaded)
        {
            if (milliseconds <= 0)
            {
                return 0;
            }
            return (haveDownloaded * 1000) / milliseconds;
        }

        private void DownloadProgressChanged(int ProgressPercentage, long TotalBytesToReceive, long BytesReceived)
        {
            if ((Convert.ToInt32(this.stopwatch.ElapsedMilliseconds) >= this.Interval) || (BytesReceived == TotalBytesToReceive))
            {
                this.stopwatch.Stop();
                this.Progress = ProgressPercentage;
                this.TotalBytes = TotalBytesToReceive;
                this.CurrentSpeed = ComputingSpeed(Convert.ToInt32(this.stopwatch.ElapsedMilliseconds), (BytesReceived - this.DownloadBytes));
                this.DownloadBytes = BytesReceived;
                this.stopwatch.Restart();
                CommandManager.InvalidateRequerySuggested();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Cancelled">操作是否已被取消</param>
        /// <param name="path"></param>
        private void DownloadCompleted(bool Cancelled,string path)
        {
            this.stopwatch.Stop();

            this.IsCanceled = Cancelled;
            this.IsDownloading = false;

            if (!Cancelled && File.Exists(path))
            {
                //this.TotalBytes = new FileInfo(file).GetFileSize();
                //this.IsComplete = true;

                this.IsComplete = true;
                this.CurrentSpeed = 0;
                this.TotalBytes = new FileInfo(path).Length;
            }
            CommandManager.InvalidateRequerySuggested();
        }

        private bool CancelDownload()
        {
            return this.IsCanceled;
        }

        private bool PauseDownload()
        {
            return !this.IsDownloading && !this.IsComplete;
        }

        public void GoOnStart()
        {
            this.IsDownloading = true;
        }
    }
}
