

using System;
namespace XYHis.Model
{
    /// <summary>
    /// 频率时间表 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsFrequencyTime : BaseModel
    {

        

        private int _frequencyId;  //频率

        private string _execTime;  //执行时间

        private int _iconIndex;  //图标类型

        private bool _isHour;  //是否按小时收费

        private string _useTime;  //早上，上午，中午，下午,晚上等

        private string _upCode;  //行心云:上报码

        private string _yBCode;  //行心云:医保码

        private double _modiOperId;  //行心云:最后修改人

        private DateTime _modiTime;  //行心云:最后修改时间

        private int _hospitalId;  //



        /// <summary>
        /// 唯一标识
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 频率
        /// </summary>
        public int FrequencyId
        {
            get { return _frequencyId; }
            set { _frequencyId = value; }
        }

        /// <summary>
        /// 执行时间
        /// </summary>
        public string ExecTime
        {
            get { return _execTime; }
            set { _execTime = value; }
        }

        /// <summary>
        /// 图标类型
        /// </summary>
        public int IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
        }

        /// <summary>
        /// 是否按小时收费
        /// </summary>
        public bool IsHour
        {
            get { return _isHour; }
            set { _isHour = value; }
        }

        /// <summary>
        /// 早上，上午，中午，下午,晚上等
        /// </summary>
        public string UseTime
        {
            get { return _useTime; }
            set { _useTime = value; }
        }

        /// <summary>
        /// 行心云:上报码
        /// </summary>
        public string UpCode
        {
            get { return _upCode; }
            set { _upCode = value; }
        }

        /// <summary>
        /// 行心云:医保码
        /// </summary>
        public string YBCode
        {
            get { return _yBCode; }
            set { _yBCode = value; }
        }

        /// <summary>
        /// 行心云:最后修改人
        /// </summary>
        public double ModiOperId
        {
            get { return _modiOperId; }
            set { _modiOperId = value; }
        }

        /// <summary>
        /// 行心云:最后修改时间
        /// </summary>
        public DateTime ModiTime
        {
            get { return _modiTime; }
            set { _modiTime = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

    }
}


