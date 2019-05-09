using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    [Serializable]
    public class LocalRegit
    {
        public KeyConfig keyLocal;
    }

    [Serializable]
    public class KeyConfig : absConfigModel
    {
        protected string _key;
        /// <summary>
        /// Key
        /// </summary>
        public override string Key
        {
            set { _key = value; }
            get { return _key; }
        }
        protected string _keyValue;
        /// <summary>
        /// KeyValue
        /// </summary>
        public string KeyValue
        {
            set { _keyValue = value; }
            get { return _keyValue; }
        }

        protected string _memo;
        /// <summary>
        /// Memo
        /// </summary>
        public string Memo
        {
            set { _memo = value; }
            get { return _memo; }
        }
    }
}


