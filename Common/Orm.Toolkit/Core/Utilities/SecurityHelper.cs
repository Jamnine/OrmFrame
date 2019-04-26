using MS.Internal.AppModel;
using MS.Internal.Permissions;
using MS.Internal.PresentationCore;
using MS.Win32;
using System;
using System.ComponentModel;
using System.IO.Packaging;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows.Markup;
using System.Windows.Navigation;

namespace Orm.Toolkit.Core.Utilities
{
    /// <summary>
    /// 安全助手
    /// </summary>
   internal static class SecurityHelper
    {
       private static UIPermission _allWindowsUIPermission = null;

       [SecurityCritical]
       internal static void DemandUIWindowPermission()
       {
           if (_allWindowsUIPermission == null)
           {
               _allWindowsUIPermission = new UIPermission(UIPermissionWindow.AllWindows);
           }
           _allWindowsUIPermission.Demand();
       }
    }
}