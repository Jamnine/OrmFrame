using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class DeleteItem
    {
        private string _name;
        private string _itemid;
        private bool _isEnd;
        /// <summary>
        /// 
        /// </summary>
        public bool IsEnd
        {
            get { return _isEnd; }
            set { _isEnd = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
    }
}
