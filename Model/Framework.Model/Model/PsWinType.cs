using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class PsWinType : BaseModel
    {
        #region 构造函数
        /// <summary>
        ///  构造函数
        /// </summary>
        public PsWinType()
        {
        }
        #endregion

        #region 字段  GUID, Level, Width, WinType
        /// <summary>
        ///  标识列 DbGenerated
        /// </summary>	
      
        public string GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>	
       
        public int? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>	
      
        public string Width { get; set; }

        /// <summary>
        /// 
        /// </summary>	
      
        public string WinType { get; set; }

        #endregion
    }
}
