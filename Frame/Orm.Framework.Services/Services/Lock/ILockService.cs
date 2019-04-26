using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Framework.Services
{
    public interface ILockService
    {
        /// <summary>
        ///  获取锁  
        /// 如果锁可用立即返回true,否则返回false 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool TryLock(String key);

        /// <summary>
        /// 锁在给定的等待时间(单位:秒)内空闲，则获取锁成功 返回true， 否则返回false
        /// </summary>
        /// <param name="key"></param>
        /// <param name="timeout">等待时间，单位秒</param>
        /// <returns></returns>
        bool TryLock(String key, long timeout);

        /// <summary>
        /// 如果锁空闲立即返回, 获取失败一直等待
        /// </summary>
        /// <param name="key"></param>
        void Lock(String key);

        /// <summary>
        /// 释放锁
        /// </summary>
        /// <param name="key"></param>
        void UnLock(String key);
    }
}
