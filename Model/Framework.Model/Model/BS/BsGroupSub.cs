

using System;
namespace XYHis.Model
{
    /// <summary>
    /// 项目二级分组 - 实体类
    /// </summary>
    [Serializable]
    public partial class BsGroupSub : BaseModel
    {

        

        private int _mainId;  //对应的大类ID

        private string _code;  //项目子类

        private string _name;  //项目子类名称

        private string _wbCode;  //五笔码

        private string _pyCode;  //拼音码

        private int _orderBy;  //显示顺序

        private bool _isActive;  //有效标志

        private int _iconIndex;  //图标类型

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
        /// 对应的大类ID
        /// </summary>
        public int MainId
        {
            get { return _mainId; }
            set { _mainId = value; }
        }

        /// <summary>
        /// 项目子类
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 项目子类名称
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


