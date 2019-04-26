using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    public class PSApplyItem : BaseModel
    {
        #region 构造函数
        /// <summary>
        ///  构造函数
        /// </summary>
        public PSApplyItem()
        {
        }
        #endregion

        #region 字段  CancelOperId, CancelTime, CheckBody-部位, IsCancel, ItemId-检查项目, OperTime-申请时间, PsApplyId-检查报告申请表GUID

        //[DataMember(Order = 9)]
        public string GUID { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        //[DataMember(Order = 10)]
        public string CancelOperId { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        //[DataMember(Order = 11)]
        public DateTime? CancelTime { get; set; }

        /// <summary>
        /// 部位
        /// </summary>	
        //[DataMember(Order = 12)]
        public string CheckBody { get; set; }

        /// <summary>
        /// 
        /// </summary>	
        //[DataMember(Order = 13)]
        public Boolean? IsCancel { get; set; }

        /// <summary>
        /// 检查项目
        /// </summary>	
        //[DataMember(Order = 14)]
        public string ItemId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>	
        //[DataMember(Order = 15)]
        public DateTime? OperTime { get; set; }

        /// <summary>
        /// 检查报告申请表GUID
        /// </summary>	
        //[DataMember(Order = 16)]
        public string PsApplyId { get; set; }

        #endregion

    }
}
