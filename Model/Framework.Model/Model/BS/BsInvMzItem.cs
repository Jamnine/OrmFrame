

using System;
namespace XYHis.Model
{
    /// <summary>
    /// 门诊发票分类 - 实体类***********
    /// </summary>
    [Serializable]
    public partial class BsInvMzItem : BaseModel
    {

        

        private string _code;  //发票项目ID

        private string _name;  //发票项目

        private string _wbCode;  //五笔码

        private string _pyCode;  //拼音码

        private int _orderBy;  //显示顺序

        private bool _isActive;  //有效标志

        private int _iconIndex;  //图标类型

        private string _groupName;  //分组

        private int _groupOrderBy;  //组显示顺序

        private bool _isAlone;  //是否单独分组

        private string _amountorName;  //行心云:F1

        private string _upCode;  //行心云:上报码

        private string _yBCode;  //行心云:医保码

        private double _modiOperId;  //行心云:最后修改人

        private DateTime _modiTime;  //行心云:最后修改时间

        private string _otherName;  //行心云:F4别名

        private bool _iSPrintALONE;  //行心云:F3另打一行

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
        /// 发票项目ID
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 发票项目
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
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
        /// 分组
        /// </summary>
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        /// <summary>
        /// 组显示顺序
        /// </summary>
        public int GroupOrderBy
        {
            get { return _groupOrderBy; }
            set { _groupOrderBy = value; }
        }

        /// <summary>
        /// 是否单独分组
        /// </summary>
        public bool IsAlone
        {
            get { return _isAlone; }
            set { _isAlone = value; }
        }

        /// <summary>
        /// 行心云:F1
        /// </summary>
        public string AmountorName
        {
            get { return _amountorName; }
            set { _amountorName = value; }
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
        /// 行心云:F4别名
        /// </summary>
        public string OtherName
        {
            get { return _otherName; }
            set { _otherName = value; }
        }

        /// <summary>
        /// 行心云:F3另打一行
        /// </summary>
        public bool ISPrintALONE
        {
            get { return _iSPrintALONE; }
            set { _iSPrintALONE = value; }
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


