using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 表名称集合表
    /// </summary>
    [Serializable]
    public class ElBaseTable : BaseModel
    {
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

        int _isActive;
        /// <summary>
        /// 有效标志
        /// </summary>
        public int IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
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
