//by lwl
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Orm.Client.Common
{
    public class CurrInvoInfo : absConfigModel
    {
        private string _key;
        public override string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private string _currInvoNo = string.Empty;
        public string CurrInvoNo
        {
            get { return _currInvoNo; }
            set { _currInvoNo = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
