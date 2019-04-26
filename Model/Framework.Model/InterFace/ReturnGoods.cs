using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class ReturnGoods
    {
        private string _order_id;

        private string _token;

        private string _timestamp;

        public string order_id
        {
            get { return _order_id; }
            set { _order_id = value; }
        }

        public string token
        {
            get { return _token; }
            set { _token = value; }
        }

        public string timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }
    }
}
