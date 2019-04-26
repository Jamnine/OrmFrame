using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model
{
    [Serializable]
    public class BsBpItem : BaseModel
    {
        private string _name;

        private string _pyCode;

        private string _wbCode;

        private int _lsRpType;

        private string _ybCode;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        public int LsRpType
        {
            get { return _lsRpType; }
            set { _lsRpType = value; }
        }

        public string YbCode
        {
            get { return _ybCode; }
            set { _ybCode = value; }
        }
    }
}
