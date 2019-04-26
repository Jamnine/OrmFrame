using System;
namespace XYHis.Model
{
    /// <summary>
    /// 频率表 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsFrequency : BaseModel
    {

        

        private string _code;  //编号

        private string _name;  //频率名称

        private string _printName;  //打印名称

        private int _days;  //天数

        private double _times;  //次数

        private string _pyCode;  //拼音码

        private string _wbCode;  //五笔码

        private int _orderBy;  //显示顺序

        private bool _isActive;  //有效标志

        private int _iconIndex;  //图标类型

        private bool _isHour;  //是否按小时收费

        private bool _isMax;  //是否按最大频率收费

        private int _userDefined;  //自定义频次

        private string _upCode;  //行心云:上报码

        private string _ybCode;  //行心云:医保码

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
        /// 编号
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 频率名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 打印名称
        /// </summary>
        public string PrintName
        {
            get { return _printName; }
            set { _printName = value; }
        }

        /// <summary>
        /// 天数
        /// </summary>
        public int Days
        {
            get { return _days; }
            set { _days = value; }
        }

        /// <summary>
        /// 次数
        /// </summary>
        public double Times
        {
            get { return _times; }
            set { _times = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        /// <summary>
        /// 有效标志
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
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
        /// 是否按最大频率收费
        /// </summary>
        public bool IsMax
        {
            get { return _isMax; }
            set { _isMax = value; }
        }

        /// <summary>
        /// 自定义频次
        /// </summary>
        public int UserDefined
        {
            get { return _userDefined; }
            set { _userDefined = value; }
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
        public string YbCode
        {
            get { return _ybCode; }
            set { _ybCode = value; }
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


