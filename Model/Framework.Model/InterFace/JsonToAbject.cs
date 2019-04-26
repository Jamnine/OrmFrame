using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.InterFace
{
    public class JsonToAbject
    {
        private string _status;

        private string _data;


        private string _errorinfo;

        /// <summary>
        /// 状态
        /// </summary>
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 返回数据
        /// </summary>
        public string data
        {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errorinfo
        {
            get { return _errorinfo; }
            set { _errorinfo = value; }
        }
    }
}
