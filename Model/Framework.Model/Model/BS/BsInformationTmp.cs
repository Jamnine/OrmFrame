

using System;
namespace XYHis.Model
{
    /// <summary>
    /// 行心云:信息模板表(短信，微信) - 实体类***********
    /// </summary>
    [Serializable]
    public partial class BsInformationTmp : BaseModel
    {

        private int _iD;  //

        private string _name;  //模板名称

        private string _content;  //模板内容

        private int _type;  //通知类型：0 其他 1 回访 2 预约 

        private int _parentId;  //父级ID

        private int _operId;  //操作员ID

        private DateTime _operTime;  //操作时间

        private bool _isDefault;  //是否默认

        private bool _isActive;  //

        private int _hospitalId;  //



        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 模板内容
        /// </summary>
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        /// <summary>
        /// 通知类型：0 其他 1 回访 2 预约 
        /// </summary>
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 父级ID
        /// </summary>
        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public int OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 是否默认
        /// </summary>
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
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


