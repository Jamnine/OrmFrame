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
    public class BsAgent: BaseModel
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AgentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AgentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AgentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CardType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CardNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MobileNum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSelf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UserBingId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UserCode { get; set; }
    }
}
