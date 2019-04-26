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
    public class ElBaseTableDtl : BaseModel
    {
        int _baseTableId;
        /// <summary>
        /// 字典表Id
        /// </summary>
        public int BaseTableId
        {
            get { return _baseTableId; }
            set { _baseTableId = value; }
        }

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

        string _memo;
        /// <summary>
        /// 其他备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
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
