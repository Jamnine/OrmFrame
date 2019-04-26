using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Model
{
    [Serializable]
    public partial class BsAddRatio : BaseModel
    {
        private string _code;
        private string _name;
        private double _addRatio;
        private string _wbCode;
        private string _pyCode;
        private Int16 _orderBy;
        private bool _isActive;

        public BsAddRatio()
        {

        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double AddRatio
        {
            get { return _addRatio; }
            set { _addRatio = value; }
        }

        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        public Int16 OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
