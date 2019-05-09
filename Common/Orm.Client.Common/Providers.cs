using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Client.Common
{
    public class Provider : absConfigModel
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
        protected string _className;
        /// <summary>
        /// ClassName
        /// </summary>
        public string ClassName
        {
            set { _className = value; }
            get { return _className; }
        }


    }
}
