using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Common
{
    /// <summary>
    /// 医嘱查对表 - 实体类
    /// </summary>
    [Serializable]
    public partial class CommonComboBox : BaseModel
    {
        private string _name;

        /// <summary>  
        ///名称
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
    }
}
