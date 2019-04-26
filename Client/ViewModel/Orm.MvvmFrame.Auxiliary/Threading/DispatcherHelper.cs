using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace Orm.MvvmFrame.Auxiliary
{
   public static class DispatcherHelper
    {
       public static Dispatcher UIDispatcher
       {
           get;
           private set;
       }

       /// <summary>
       /// 检验，并在主线程中执行。
       /// </summary>
       /// <param name="action">执行方法</param>
       public static void CheckBeginInvokeOnUI(Action action)
       {
           if (action == null)
           {
               return;
           }
           CheckDispatcher();
           if (UIDispatcher.CheckAccess())
           {
               action();
           }
           else
           {
               UIDispatcher.BeginInvoke(action);
           }
       }

       /// <summary>
       /// 检验，并在主线程中执行。
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="action">执行的方法</param>
       /// <param name="argument">导入执行方法中的参数</param>
       public static void CheckBeginInvokeOnUI<T>(Action<T> action, T argument)
       {
           if (action == null)
           {
               return;
           }

            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(2, true);
            string methodFilePath = st.GetFrame(0).GetFileName();

            System.Diagnostics.StackTrace st2 = new System.Diagnostics.StackTrace(3, true);
            string methodFilePath2 = st2.GetFrame(0).GetFileName();



            CheckDispatcher();
           if (UIDispatcher.CheckAccess())
           {
               action(argument);
           }
           else
           {
               UIDispatcher.BeginInvoke(action, argument);
           }
       }

       /// <summary>
       /// 检验，并在主线程中执行。
       /// </summary>
       /// <param name="action">执行的方法</param>
       /// <param name="args"></param>
       public static void CheckBeginInvokeOnUI<T1, T2>(Action<T1, T2> action, T1 argument1, T2 argument2)
       {
           if (action == null)
           {
               return;
           }
           CheckDispatcher();
           if (UIDispatcher.CheckAccess())
           {
               action(argument1, argument2);
           }
           else
           {
               UIDispatcher.BeginInvoke(action, argument1, argument2);
           }
       }

       /// <summary>
       /// 检验，并在主线程中执行。
       /// </summary>
       /// <param name="action">执行的方法</param>
       /// <param name="args"></param>
       public static void CheckBeginInvokeOnUI<T1, T2,T3>(Action<T1, T2, T3> action, T1 argument1, T2 argument2, T3 argument3)
       {
           if (action == null)
           {
               return;
           }
           CheckDispatcher();
           if (UIDispatcher.CheckAccess())
           {
               action(argument1, argument2, argument3);
           }
           else
           {
               UIDispatcher.BeginInvoke(action, argument1, argument2, argument3);
           }
       }


       private static void CheckDispatcher()
       {
           if (UIDispatcher == null)
           {
               var error = new StringBuilder("DispatcherHelper 未初始化。");
               error.AppendLine();
               throw new InvalidOperationException(error.ToString());
           }
       }

       public static DispatcherOperation RunAsync(Action action)
       {
           CheckDispatcher();

           return UIDispatcher.BeginInvoke(action);
       }

       public static void Initialize()
       {
           if (UIDispatcher != null && UIDispatcher.Thread.IsAlive)
           {
               return;
           }
           UIDispatcher = Dispatcher.CurrentDispatcher;
       }

       public static void Reset()
       {
           UIDispatcher = null;
       }

    }
}
