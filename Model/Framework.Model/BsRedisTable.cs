using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public partial class BsRedisTable : BaseModel
    {

        public BsRedisTable() { }

        private string _tableName;  //表名称


        /// <summary>
		/// 表名称
		/// </summary>
		public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }


    }
}
