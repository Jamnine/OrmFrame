using System;

namespace Orm.Model
{
    /// <summary>
    /// ÆÀ¹À±í
    /// </summary>
    [Serializable]
    public partial class Assessment : BaseModel
    {

        string _assessmentName;


        /// <summary>
        /// ÆÀ¹ÀÃû×Ö
        /// </summary>
        public string Name
        {
            get { return _assessmentName; }
            set { _assessmentName = value; }
        }

        int _orderby;
        /// <summary>
        /// ÅÅĞò
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

        string _pyCode = string.Empty;
        /// <summary>
        /// Æ´ÒôÂë
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        string _wbCode = string.Empty;
        /// <summary>
        /// Îå±ÊÂë
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }
    }
}



