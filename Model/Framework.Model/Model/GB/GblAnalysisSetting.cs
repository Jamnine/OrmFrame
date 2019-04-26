using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 数据分析设置 - 实体类
    /// </summary>
    [Serializable]
    public class GblAnalysisSetting:BaseModel
    {
        private string _name;
        private string _fileName;
        private bool _isActive;
        private int _hospitalId;
        private string _procName;
        private string _parentID;
        private DateTime _insertTime;
        private int _orderBy;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get { return _name;} set { _name = value;} }
        /// <summary>
        /// 报表文件名称
        /// </summary>
        public string FileName { get { return _fileName;} set { _fileName = value;} }
        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsActive { get { return _isActive;} set { _isActive = value;} }
        /// <summary>
        /// 医院
        /// </summary>
        public int HospitalId { get { return _hospitalId; } set { _hospitalId = value;} }
        /// <summary>
        /// 存储过程
        /// </summary>
        public string ProcName { get {return _procName;} set { _procName = value;} }
        /// <summary>
        /// 父级
        /// </summary>
        public string ParentID { get { return _parentID; }set {_parentID = value; }}

        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime { get { return _insertTime; } set { _insertTime = value; } }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy { get { return _orderBy; } set { _orderBy = value; } }
    }
}
