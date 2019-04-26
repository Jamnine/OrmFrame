using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Orm.Framework.Services
{
    /// <summary>
    /// 工作者基类,定时执行相应的业务逻辑
    /// </summary>
    public abstract class Worker : IDisposable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Worker()
        {
            IsMutex = true;
            Interval = 10;
        }

        #region 属性
        private readonly object mutexLock = new object(); //锁 
        private bool isWorking = false; //标志
        private System.Timers.Timer Timer; //计时器

        /// <summary>
        /// Worker是否互斥执行
        /// </summary>
        protected bool IsMutex { get; set; }

        /// <summary>
        /// Worker工作间隔,默认10秒（单位：秒）
        /// </summary>
        protected double Interval { get; set; }

        #endregion

        #region 计时器 & 控制方法
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (IsMutex && isWorking) return;

            try
            {
                setWorking(true);

                //前处理
                BeforeWorking();

                //
                Working();

                //

                //后处理
                AfterWorking();
            }
            finally
            {
                setWorking(false);
            }
        }

        public virtual void Start()
        {
            //启动定时器
            Timer = new System.Timers.Timer();
            Timer.Interval = Interval * 1000; //两次 Elapsed 事件之间的时间（以毫秒为单位）
            Timer.Elapsed += new ElapsedEventHandler(this.Timer_Elapsed);
            Timer.Start();
        }

        public virtual void Stop()
        {
            //终止定时器
            if (Timer != null)
            {
                Timer.Elapsed -= new ElapsedEventHandler(this.Timer_Elapsed);
                Timer.Stop();
                Timer.Dispose();
                Timer = null;
            }
        }

        public virtual void Pause()
        {
        }
        public virtual void Continue()
        {
        }

        /// <summary>
        /// 释放Worker所占资源
        /// </summary>
        public virtual void Dispose()
        {
            Stop();
        }

        #endregion

        #region 方法

        /// <summary>
        /// 前处理
        /// </summary>
        protected virtual void BeforeWorking()
        {
        }

        /// <summary>
        /// 后处理
        /// </summary>
        protected virtual void AfterWorking()
        {
        }

        /// <summary>
        /// 工作线程主方法(子类须覆写该方法完成具体业务逻辑)
        /// </summary>
        protected abstract void Working();

        private void setWorking(bool working)
        {
            if (IsMutex)
            {
                lock (mutexLock)
                {
                    isWorking = working;
                }
            }
        }

        #endregion
    }
}
