using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    public partial class  CkItemQc : BaseModel
    {
        private string _ckmId;
        /// <summary>
        /// 仪器id
        /// </summary>
        public string CkmId
        {
            get { return _ckmId; }
            set { _ckmId = value; }
        }

        private string _qCReagentBatchesID;
        /// <summary>  
        /// 试剂批号id
        /// </summary>  
        public string QCReagentBatchesID
        {
            get { return _qCReagentBatchesID; }
            set { _qCReagentBatchesID = value; }
        }
        private string _qCItemName;
        /// <summary>
        /// 项目名称
        /// </summary>
        public string QCItemName
        {
            get { return _qCItemName; }
            set { _qCItemName = value; }
        }
    }
}
