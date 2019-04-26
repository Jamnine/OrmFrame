using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 转诊外院记录表
    /// </summary>
    public class BSRefHospital : BaseModel
    {
        private string _name = string.Empty;
        private string _hospitalMc = string.Empty;
        private string _departmentMc = string.Empty;
        private int _isActive = 0;
        private DateTime _insertTime;

        /// <summary>
        /// 界面显示使用，非数据库字段
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 医院名称
        /// </summary>
        public string HospitalMc
        {
            get { return _hospitalMc; }
            set { _hospitalMc = value; }
        }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string DepartmentMc
        {
            get { return _departmentMc; }
            set { _departmentMc = value; }
        }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }
    }
}
