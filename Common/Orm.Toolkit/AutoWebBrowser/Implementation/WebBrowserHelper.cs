using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Controls;
using System.Globalization;
using System.Windows;
using System.Windows.Threading;

namespace Orm.Toolkit
{
    public partial class WebBrowserHelper
    {
        private WebBrowser _webBrowser;
        private object _cookie;

        public event CancelEventHandler NewWindow;

        public WebBrowserHelper(WebBrowser webBrowser)
        {
            if (webBrowser == null)
                throw new ArgumentNullException("webBrowser");
            _webBrowser = webBrowser;
            _webBrowser.Dispatcher.BeginInvoke(new Action(Attach), DispatcherPriority.Loaded);
        }

        public void Disconnect()
        {
            if (_cookie != null)
            {
                _cookie.ReflectInvokeMethod("Disconnect", new Type[] { }, null);
                _cookie = null;
            }
        }

        private void Attach()
        {
            var axIWebBrowser2 = _webBrowser.ReflectGetProperty("AxIWebBrowser2");
            var webBrowserEvent = new WebBrowserEvent(this);
            var cookieType = typeof(WebBrowser).Assembly.GetType("MS.Internal.Controls.ConnectionPointCookie");
            _cookie = Activator.CreateInstance(
                cookieType,
                ReflectionService.BindingFlags,
                null,
                new[] { axIWebBrowser2, webBrowserEvent, typeof(DWebBrowserEvents2) },
                CultureInfo.CurrentUICulture);
        }

        private void OnNewWindow(ref bool cancel)
        {
            var eventArgs = new CancelEventArgs(cancel);
            if (NewWindow != null)
            {
                NewWindow(_webBrowser, eventArgs);
                cancel = eventArgs.Cancel;
            }
        }
    }

    public partial class WebBrowserHelper
    {
        //private bool _isSuppressScriptErrors;
        /// <summary>
        /// 抑制JavaScript错误
        /// </summary>
        //public bool IsSuppressScriptErrors { get { return _isSuppressScriptErrors; } set { if (_isSuppressScriptErrors != value) {
        //    if (this._webBrowser != null) {
        //        SuppressScriptErrors(_webBrowser,value);
        //    }
        //    _isSuppressScriptErrors=value;
        //} } }


        /// <summary>
        /// 抑制JavaScript错误
        /// </summary>
        /// <param name="wb"></param>
        /// <param name="Hide"></param>
        public void SuppressScriptErrors(WebBrowser wb, bool Hide)
        {
            System.Reflection.FieldInfo fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser2", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;

            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;

            objComWebBrowser.GetType().InvokeMember("Silent", System.Reflection.BindingFlags.SetProperty, null, objComWebBrowser, new object[] { Hide });
        }
    }
}
