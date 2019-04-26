using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class ElBaseFiled : BaseModel
    {
        //string _guid;
        /// <summary>
        /// 唯一标识
        /// </summary>
        //public string Guid
        //{
        //    get { return _guid; }
        //    set { _guid = value; }
        //}

        string _code;
        /// <summary>
        /// 编号
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        string _name;
        /// <summary>
        /// 命名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _lsdatatype;
        /// <summary>
        /// 数据类型：1-数字；2-字符；3-日期；4-逻辑是否；5-二进制文件；6-大文本
        /// </summary>
        public int LsdataType
        {
            get { return _lsdatatype; }
            set { _lsdatatype = value; }
        }

        int _lengh;
        /// <summary>
        /// 长度
        /// </summary>
        public int Lengh
        {
            get { return _lengh; }
            set { _lengh = value; }
        }

        string _editMask;
        /// <summary>
        /// 正则表达式
        /// </summary>
        public string EditMask
        {
            get { return _editMask; }
            set { _editMask = value; }
        }

        string _memo;
        /// <summary>
        /// 其他备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        string _toolTips;
        /// <summary>
        /// 用户提示
        /// </summary>
        public string ToolTips
        {
            get { return _toolTips; }
            set { _toolTips = value; }
        }

        string _errorTips;
        /// <summary>
        /// 错误提示
        /// </summary>
        public string ErrorTips
        {
            get { return _errorTips; }
            set { _errorTips = value; }
        }

        int _isHasChild;
        /// <summary>
        /// 是否父节点
        /// </summary>
        public int IsHasChild
        {
            get { return _isHasChild; }
            set { _isHasChild = value; }
        }

        int _orderBy;
        /// <summary>
        /// 显示顺序
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        int _isActive;
        /// <summary>
        /// 有效标志
        /// </summary>
        public int IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        int _isEncrypt;
        /// <summary>
        /// 是否数据加密
        /// </summary>
        public int IsEncrypt
        {
            get { return _isEncrypt; }
            set { _isEncrypt = value; }
        }

        int _isLog;
        /// <summary>
        /// 是否数据修改跟踪
        /// </summary>
        public int IsLog
        {
            get { return _isLog; }
            set { _isLog = value; }
        }

        string _isMustWrite;
        /// <summary>
        /// 是否必填
        /// </summary>
        public string IsMustWrite
        {
            get { return _isMustWrite; }
            set { _isMustWrite = value; }
        }

        int _tagOrder;
        /// <summary>
        /// 排序（用于生成页面代码）
        /// </summary>
        public int TagOrder
        {
            get { return _tagOrder; }
            set { _tagOrder = value; }
        }

        int _tagType;
        /// <summary>
        /// 控件类别：1-弹窗(多选),2--弹窗(单选)
        /// </summary>
        public int TagType
        {
            get { return _tagType; }
            set { _tagType = value; }
        }

        int _baseTableId;
        /// <summary>
        /// 字典表Id
        /// </summary>
        public int BaseTableId
        {
            get { return _baseTableId; }
            set { _baseTableId = value; }
        }

        string _nameType;
        /// <summary>
        /// 字段类型：Code,Name
        /// </summary>
        public string NameType
        {
            get { return _nameType; }
            set { _nameType = value; }
        }

        int _hospitalID;
        /// <summary>
        /// 医院ID
        /// </summary>
        public int HospitalID
        {
            get { return _hospitalID; }
            set { _hospitalID = value; }
        }

        int _hisType;
        /// <summary>
        /// his类别
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }

        DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

    }
}
