using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orm.Model;

namespace Orm.Model.Custom
{
   public class UspRmOutCache:BaseModel
    {
        /// <summary>
        /// 单据流水号
        /// </summary>
        public string BillNo
        {
            get;
            set;
        }

        /// <summary>
        /// 药房ID,BsRoom.Id
        /// </summary>
        public string RoomId
        {
            get;
            set;
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get;
            set;
        }

        /// <summary>
        /// 操作员ID,BsUser.Id
        /// </summary>
        public string OperId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否审核
        /// </summary>
        public bool IsSign
        {
            get;
            set;
        }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime SignTime
        {
            get;
            set;
        }

        /// <summary>
        /// 审核人
        /// </summary>
        public string SignOperId
        {
            get;
            set;
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get;
            set;
        }
        
        /// <summary>
        /// 门诊流水号
        /// </summary>
        public string MzRegId { set; get; }
    }
}
