using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class BsItemBpId : BaseModel
    {
        private DateTime _operTime;

        private string _userId;

        private string _bPItemId;

        private string _hISItemId;

        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string BPItemId
        {
            get { return _bPItemId; }
            set { _bPItemId = value; }
        }

        public string HISItemId
        {
            get { return _hISItemId; }
            set { _hISItemId = value; }
        }
    }
}
