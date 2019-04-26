// ===================================================================   
// Model  
// ===================================================================   
// File: OuDayScheduleDtl.cs  
//   
// Copyright   
// History:  
// 2015/5/26 17:21:12: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  日排班明细  数据库不存在此表
    /// </summary>  
    [Serializable]  
 
    public partial class OuDayScheduleDtl : BaseModel  
    {  
        private string _scheduleID;  
        private string _timeSpanSubID;  
        private int _totalNum;  
        private int _booklimitNum;  
  
        public OuDayScheduleDtl()  
        {
              
        }  
  
        /// <summary>  
        /// 日排班主表ID  
        /// </summary>  
        public string ScheduleID  
        {  
            get { return this._scheduleID; }  
            set { this._scheduleID = value; }  
        }  
  
        /// <summary>  
        /// 时段ID  
        /// </summary>  
        public string TimeSpanSubID  
        {  
            get { return this._timeSpanSubID; }  
            set { this._timeSpanSubID = value; }  
        }  
  
        /// <summary>  
        /// 挂号号源
        /// </summary>  
        public int TotalNum  
        {  
            get { return this._totalNum; }  
            set { this._totalNum = value; }  
        }  
  
        /// <summary>  
        /// 预约限号数  
        /// </summary>  
        public int BooklimitNum  
        {  
            get { return this._booklimitNum; }  
            set { this._booklimitNum = value; }  
        }  
    }  
}  

