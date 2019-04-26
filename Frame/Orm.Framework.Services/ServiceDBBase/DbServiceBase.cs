
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Orm.Framework.Services;
using Orm.Model;
using Orm.Framework.Services.ServiceDBBase;
using Orm.Redis;
using System.Text.RegularExpressions;
using System.Reflection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Threading;
using Orm.Log4Library;

namespace Orm.Framework.Services
{
    public class DBServiceBase : DBClientBase, IDBServiceBase
    {
        static bool isMQListening = false;
        public DBServiceBase(string dbKey) : base(dbKey)
        {
        }
        public DBServiceBase() : base(AppSettings.ConfigDB_Key)
        {
            if (!isMQListening)
            {
                foreach (string k in System.Configuration.ConfigurationManager.AppSettings.AllKeys)
                {
                    if (k == "IsImportDataToRedis")
                    {//说明当前进程在IIS上运行
                        //Thread thread = new Thread(RabbitMQServerListening);
                        //thread.Start();
                        isMQListening = true;
                        break;
                    }
                }
                isMQListening = true;
            }
        }

        //public void RabbitMQServerListening()
        //{
        //    string hostName = System.Configuration.ConfigurationManager.AppSettings["Orm.RabbitMQ.HostName"].ToString().Trim();
        //    string userName = System.Configuration.ConfigurationManager.AppSettings["Orm.RabbitMQ.UserName"].ToString().Trim();
        //    string password = System.Configuration.ConfigurationManager.AppSettings["Orm.RabbitMQ.Password"].ToString().Trim();
        //    string routingkey = System.Configuration.ConfigurationManager.AppSettings["Orm.RabbitMQ.Routingkey"].ToString().Trim();
        //    try
        //    {
        //        ConnectionFactory factory = new ConnectionFactory();
        //        factory.HostName = hostName;
        //        factory.UserName = userName;
        //        factory.Password = password;
        //        using (IConnection conn = factory.CreateConnection())
        //        {
        //            using (RabbitMQ.Client.IModel channel = conn.CreateModel())
        //            {
        //                //在MQ上定义一个持久化队列，如果名称相同不会重复创建
        //                channel.QueueDeclare(routingkey, true, false, false, null);

        //                //输入1，那如果接收一个消息，但是没有应答，则客户端不会收到下一个消息
        //                channel.BasicQos(0, 1, false);

        //                LogHelper.ErrorLog("Listening...");

        //                //在队列上定义一个消费者
        //                QueueingBasicConsumer consumer = new QueueingBasicConsumer(channel);
        //                //消费队列，并设置应答模式为程序主动应答
        //                channel.BasicConsume(routingkey, false, consumer);

        //                while (true)
        //                {
        //                    //阻塞函数，获取队列中的消息
        //                    BasicDeliverEventArgs ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
        //                    byte[] bytes = ea.Body;
        //                    string str = Encoding.UTF8.GetString(bytes);
        //                    RabbitMQMessage rabbitMQMessage = JsonConvert.DeserializeObject<RabbitMQMessage>(str);
        //                    LogHelper.ErrorLog(string.Format("key:{0},guid:{1},body:{1}", rabbitMQMessage.MessageKey, rabbitMQMessage.EntityGuid, rabbitMQMessage.MessageBody));
        //                    switch (rabbitMQMessage.OperType)
        //                    {
        //                        case (int)OperTypeEnum.SetEntryInHash:
        //                            RedisWriteExHelper.SetAdd(rabbitMQMessage.MessageKey, rabbitMQMessage.EntityGuid, rabbitMQMessage.MessageBody);
        //                            break;
        //                        case (int)OperTypeEnum.RemoveEntryFromHash:
        //                            RedisWriteExHelper.SetRemove(rabbitMQMessage.MessageKey, rabbitMQMessage.EntityGuid);
        //                            break;
        //                        case (int)OperTypeEnum.UpdateEntryInHash:
        //                            RedisWriteExHelper.SetUpdate(rabbitMQMessage.MessageKey, rabbitMQMessage.EntityGuid, rabbitMQMessage.MessageBody);
        //                            break;
        //                    }
        //                    //回复确认
        //                    channel.BasicAck(ea.DeliveryTag, false);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e1)
        //    {
        //        LogHelper.ErrorLog(e1.ToString());
        //    }
        //}

        public new IDataPersist DataRepository
        {
            get { return DataRepository(); }
        }

        #region 查询单个

        /// <summary>
        /// 返回实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public T Get<T>(Func<T, bool> exp) where T : BaseModel, new()
        {

            //string modelTypeStr = typeof(T).Name;
            //var IsExist = IsExist<BsRedisTable>("TableName=@0", modelTypeStr);
            //if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")|| IsExist)
            //{//如果是基础数据，从本地redis中获取数据
            //    //构建pattern
            //    string pattern = "";
            //    pattern = GetExpPattern<T>(exp.ToString(), modelTypeStr);
            //    if (pattern != "")
            //    {//pattern如果为空，将从数据库中查询
            //        List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
            //        if (list != null)
            //            return list[0];
            //        else
            //            return null;
            //    }
            //}
            IQueryable<T> _dal = DataRepository().GetQueryable<T>();
            return _dal.Where(exp).FirstOrDefault();
        }


        #endregion

        #region 查询多个
        /// <summary>
        /// 返回LIST
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public List<T> GetList<T>(Expression<Func<T, bool>> exp) where T : class, new()
        {
            string modelTypeStr = typeof(T).Name;
            var IsExist = IsExist<BsRedisTable>("TableName=@0", modelTypeStr);
            if (modelTypeStr.ToUpper().StartsWith("BS") || modelTypeStr.ToUpper().StartsWith("GBL")|| IsExist)
            {//如果是基础数据，从本地redis中获取数据
                //构建pattern
                string pattern = "";
                pattern = GetExpPattern<T>(exp.ToString(), modelTypeStr);
                if (pattern != "")
                {//pattern如果为空，将从数据库中查询
                    List<T> list = RedisReadExHelper.SetSearch<T>(modelTypeStr, 0, pattern, 10000);
                    return list;
                }
            }
            IQueryable<T> _dal = DataRepository().GetQueryable<T>();
            return _dal.Where(exp).ToList();
        }

        /// <summary>
        /// 返回LIST
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <param name="orderBy"></param>
        /// <param name="IsDesc"></param>
        /// <returns></returns>
        public List<T> GetList<T, TKey>(Expression<Func<T, bool>> exp, Expression<Func<T, TKey>> orderBy, bool IsDesc = false) where T : BaseModel, new()
        {
            string name = typeof(T).Name;
            IQueryable<T> _dal = DataRepository().GetQueryable<T>();

            if (IsDesc)
            {
                return _dal.Where(exp).OrderBy(orderBy).ToList();
            }
            else
            {
                return _dal.Where(exp).OrderByDescending(orderBy).ToList();
            }
        }

        #endregion

        /// <summary>
        /// 带事务的删除操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <param name="IsTrn">是否创建事务，true函数体内加事务，false或不传外部加事务</param>
        /// <returns></returns>
        public int Delete<T>(Expression<Func<T, bool>> exp, bool IsTrn = false) where T : BaseModel, new()
        {
            int count = 0;
            if (IsTrn)
            {
                Action action = delegate ()
                {
                    DeleteRedis<T>(exp);
                    count = DataRepository().Delete<T>(exp);
                    //TransformExpressDeleteToSQL(exp);
                };
                Commit(action);
               
                return count;
            }
            else
            {
                //TransformExpressDeleteToSQL(exp);
                DeleteRedis<T>(exp);
                int k = DataRepository().Delete<T>(exp);
                  
                return k;
            }
        }

        internal void TransformExpressDeleteToSQL<T>(Expression<Func<T, bool>> lamb) where T : class, new()
        {
            string deleteSQL = DeleteByExpress(lamb);
            AppLogger.Log("TransformExpressDeleteToSQL:" + deleteSQL);
        }

        /// <summary>
        /// Update<Model.BsUser>(new { name = "测试" }, m => m.Name == "scott");
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Update<T>(object update, Expression<Func<T, bool>> where) where T : BaseModel, new()
        {
            //TransformUpdateEntityByExpressToSql(update, where);
            int k = DataRepository().Update<T>(update, where);
            if (k > 0)
                UpdateRedis<T>(where);
            return k;
        }

        private void TransformUpdateEntityByExpressToSql<T>(object update, Expression<Func<T, bool>> where) where T : class, new()
        {
            string updateSQL = UpdateByExpress(update, where);
            AppLogger.Log("UpdateEntityByExpress：" + updateSQL);
        }

        /// <summary>
        /// 判断表是否存在数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exp"></param>
        /// <returns></returns>
        public bool IsExist<T>(Expression<Func<T, bool>> exp) where T : BaseModel, new()
        {
            IQueryable<T> _dal = DataRepository().GetQueryable<T>();
            int count = _dal.Count(exp);
            return count > 0 ? true : false;
        }

        /// <summary>
        /// 修改数据库之后修改redis中相关记录
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lamb"></param>
        public void UpdateRedis<T>(Expression<Func<T, bool>> lamb) where T : BaseModel, new()
        {
            try
            {
                List<T> list = GetList<T>(lamb);
                foreach (T t in list)
                {
                   bool succ= RedisWriteExHelper.SetUpdate(typeof(T).Name, t.GUID, JsonConvert.SerializeObject(t));
                    //RabbitMQMessage rabbitMQMessage = new RabbitMQMessage()
                    //{
                    //    MessageKey = typeof(T).Name,
                    //    EntityGuid = t.GUID,
                    //    MessageBody = JsonConvert.SerializeObject(t),
                    //    OperTime = DateTime.Now,
                    //    OperType = (int)OperTypeEnum.UpdateEntryInHash
                    //};
                    //RabbitMQTasks.MQTask(rabbitMQMessage);
                }
            }
            catch (Exception ex)
            {
                Log4Library.LogHelper.ErrorLog(ex.ToString());
                throw (ex);
            }
        }
    }
}
