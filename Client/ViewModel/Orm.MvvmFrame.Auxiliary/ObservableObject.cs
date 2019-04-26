using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Orm.MvvmFrame.Auxiliary
{
    /// <summary>
    /// 对象的属性是可观察的基类
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {
        #region 属性更改机制

        public event PropertyChangedEventHandler PropertyChanged;

        #region 支持.NET4.5/.NET4.0
        /// </summary>
        /// 
        /// </summary>
        /// <typeparam name="T">属性类型</typeparam>
        /// <param name="storage">被设置的属性</param>
        /// <param name="isCheckEquals">是否检查属性相等</param>
        /// <param name="value">将要设置的属性值</param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T storage, T value, bool isCheckEquals = true, [CallerMemberName] string propertyName = null)
        {
            if (isCheckEquals)
                if (object.Equals(storage, value)) { return false; }
            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// </summary>
        /// 
        /// </summary>
        /// <typeparam name="T">属性类型</typeparam>
        /// <param name="storage">被设置的属性</param>
        /// <param name="isCheckEquals">是否检查属性相等</param>
        /// <param name="value">将要设置的属性值</param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null, params string[] propertyNames)
        {
            storage = value;
            this.OnPropertyChanged(propertyName);
            foreach (string propertyname in propertyNames)
            {
                this.OnPropertyChanged(propertyname);
            }
            return true;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region 支持.NET4.0

        //private static string GetProperyName(string methodName)
        //{
        //    if (methodName.StartsWith("get_") || methodName.StartsWith("set_") ||
        //        methodName.StartsWith("put_"))
        //    {
        //        return methodName.Substring("get_".Length);
        //    }
        //    throw new Exception(methodName + " not a method of Property");
        //}

        //protected bool SetProperty<T>(ref T storage, T value)
        //{
        //    if (object.Equals(storage, value)) { return false; }
        //    storage = value;
        //    string propertyName = GetProperyName(new System.Diagnostics.StackTrace(true).GetFrame(1).GetMethod().Name);
        //    this.OnPropertyChanged(propertyName);
        //    return true;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <typeparam name="T">属性类型</typeparam>
        ///// <param name="storage">被设置的属性</param>
        ///// <param name="value">将要设置的属性值</param>
        ///// <param name="isCheckEquals">是否检查属性相等</param>
        ///// <returns></returns>
        //protected bool SetProperty<T>(ref T storage, T value, bool isCheckEquals)
        //{
        //    if (isCheckEquals)
        //        if (object.Equals(storage, value)) { return false; }
        //    storage = value;
        //    string propertyName = GetProperyName(new System.Diagnostics.StackTrace(true).GetFrame(1).GetMethod().Name);
        //    this.OnPropertyChanged(propertyName);
        //    return true;
        //}

        //private void OnPropertyChanged(string propertyName)
        //{
        //    var eventHandler = this.PropertyChanged;
        //    if (eventHandler != null)
        //    {
        //        eventHandler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        #endregion

        #endregion
    }
}
