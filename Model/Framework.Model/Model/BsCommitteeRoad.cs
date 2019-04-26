using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 街道表 - 实体类
    /// </summary>
    public partial class BsCommitteeRoad : BaseModel
    {
        private string _code;

        private string _committeeId;// 居委编码

        private Int16 _iconIndex;

        private bool _isActive;// 有效标志

        private string _name;

        private Int16 _orderBy;// 显示顺序

        private string _pyCode;// 拼音码

        private string _wbCode;// 五笔码

        public BsCommitteeRoad()
        {

        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// 居委编码
        /// </summary>	
        public string CommitteeId
        {
            get { return _committeeId; }
            set { _committeeId = value; }
        }

        /// <summary>
        /// 
        /// </summary>	
        public Int16 IconIndex
        {
            get { return _iconIndex; }
            set { _iconIndex = value; }
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
        /// 
        /// </summary>	
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>	
        public Int16 OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
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
    }
}
