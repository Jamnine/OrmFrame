using System;
using System.Collections.Generic;

namespace Orm.MvvmFrame.Auxiliary
{
    /// <summary>
    /// 数据列表异步加载器
    /// </summary>
    /// <typeparam name="T">要加载的model类型</typeparam>
    public class AsyncListLoader<T> where T : Model.BaseModel, new()
    {
        public AsyncListLoader()
        {
            allListLoader = new Func<List<T>>(LoadAllList);
            listLoader = new Func<string, object[], List<T>>(LoadList);
        }

        Func<List<T>> allListLoader;
        Func<string, object[], List<T>> listLoader;
        Action loader;
        ////Func<string,object[],List<T>> listLoader;
        //List<T> _allList;
        List<T> _list;


        /// <summary>
        /// 异步获取所有数据
        /// </summary>
        /// <param name="callback">回调函数</param>
        public void GetAllList(Action<List<T>> callback)
        {
            if (callback != null && allListLoader != null)
            {
                CallBack = callback;
                allListLoader.BeginInvoke(AllListCallBack, allListLoader);
            }
        }

        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="where">条件</param>
        /// <param name="callback">回调函数</param>
        public void GetList(Action<List<T>> callback, string where, params object[] args)
        {
            if (callback != null && listLoader != null)
            {
                CallBack = callback;
                listLoader.BeginInvoke(where, args, ListCallBack, listLoader);
            }
        }

        /// <summary>
        /// 根据自定义方法 获得List
        /// </summary>
        /// <param name="callback">获得数据后返回</param>
        /// <param name="doWork">传入的获得数据的方法</param>
        public void GetListByCustom(Action<List<T>> callback, Action doWork)
        {

            if (doWork != null && callback != null)
            {
                loader = new Action(doWork);
                CallBack = callback;
                loader.BeginInvoke(null, loader);
            }
        }


        private List<T> LoadAllList()
        {
            return Orm.Config.Service.DBClientService.GetAllList<T>();
        }

        private List<T> LoadList(string where, object[] args)
        {
            return Orm.Config.Service.DBClientService.GetList<T>(where, args);
        }
        private void AllListCallBack(IAsyncResult ar)
        {
            Func<List<T>> loaderBack = ar.AsyncState as Func<List<T>>;
            if (ar.IsCompleted)
            {
                try
                {
                    _list = loaderBack.EndInvoke(ar);
                    CallBack(_list);
                }
                catch (Exception ex)
                {
                    System.Windows.Application.Current.Dispatcher.Invoke((Action)delegate
                    {
                        throw ex;
                    });
                }
            }
        }

        private void ListCallBack(IAsyncResult ar)
        {
            Func<string, object[], List<T>> loaderBack = ar.AsyncState as Func<string, object[], List<T>>;
            if (ar.IsCompleted)
            {
                try
                {
                    _list = loaderBack.EndInvoke(ar);
                    CallBack(_list);
                }
                catch (Exception ex)
                {
                    System.Windows.Application.Current.Dispatcher.Invoke((Action)delegate
                    {
                        throw ex;
                    });
                }
            }
        }

        //private void CustomCallBack(IAsyncResult ar)
        //{
        //    Func<List<T>> loaderBack = ar.AsyncState as Func<List<T>>;
        //    if (ar.IsCompleted)
        //    {
        //        _list = loaderBack.EndInvoke(ar);
        //        CallBack(_list);
        //    }
        //}


        private Action<List<T>> _callBack;
        /// <summary>
        /// 接收一个集合参数的回调函数
        /// </summary>
        public Action<List<T>> CallBack
        {
            get { return _callBack; }
            set { _callBack = value; }
        }
    }
}
