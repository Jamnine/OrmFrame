using System;

namespace Orm.Model
{
    /// <summary>
    /// BP疾病基础库
    /// </summary>
    [Serializable]
    public partial class BsDis : BaseModel
    {
        string _name;
        /// <summary>
        /// 疾病名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _orderby;
        /// <summary>
        /// 排序
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

        /// <summary>
        /// 拼音码
        /// </summary>
        string _pyCode = string.Empty;
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        string _wbCode = string.Empty;
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        private string _icdName;
        /// <summary>
        /// ICD疾病名称
        /// </summary>
        public string ICDName
        {
            get { return _icdName; }
            set { _icdName = value; }
        }

        private string _bpIllId;
        /// <summary>
        /// BP对应XmlID
        /// </summary>
        public string BpIllId
        {
            get { return _bpIllId; }
            set { _bpIllId = value; }
        }

        private string _icd;
        /// <summary>
        /// ICD编码
        /// </summary>
        public string ICD
        {
            get { return _icd; }
            set { _icd = value; }
        }

        private bool _existBP;
        /// <summary>
        /// 是否存在bp数据
        /// </summary>
        public bool ExistBP
        {
            get { return _existBP; }
            set { _existBP = value; }
        }

        private bool _existChinaMed;
        /// <summary>
        /// 是否存在中药数据
        /// </summary>
        public bool ExistChinaMed
        {
            get { return _existChinaMed; }
            set { _existChinaMed = value; }
        }

        private bool _existPatentMed;
        /// <summary>
        /// 是否存在中成药数据
        /// </summary>
        public bool ExistPatentMed
        {
            get { return _existPatentMed; }
            set { _existPatentMed = value; }
        }
    }
}



