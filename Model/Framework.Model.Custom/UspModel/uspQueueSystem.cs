using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{

    /// <summary>
    /// 叫号系统
    /// </summary>
    [Serializable]
    public class uspQueueSystem
    {
        public uspQueueSystem()
        {

        }

        /// <summary>
        /// 叫号内容(请xx病人到xxx科室就诊)
        /// </summary>
        public string ContentRoomInfo { get; set; }

        /// <summary>
        /// 诊室
        /// </summary>
        public BsDiagRoom DiagRoomInfo { get; set; }

      
        private List<Custom.uspOuHosInfoEx> _lstOuHosInfo = new List<Custom.uspOuHosInfoEx>();
        /// <summary>
        /// 挂号查询信息组合条件
        /// </summary>
        public List<Custom.uspOuHosInfoEx> OuHosInfoList
        {
            get { return _lstOuHosInfo; }
            set
            {
                _lstOuHosInfo = value;
            }
        }
    }

}
