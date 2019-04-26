using System;

namespace Orm.Model
{
    /// <summary>
    /// º≤≤°÷Œ¡∆ΩÈ…‹
    /// </summary>
    [Serializable]
    public partial class BsDisTreatmentSuggest : BaseModel
    {
        string _name;
        /// <summary>
        /// º≤≤°√˚≥∆
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _describe;
        /// <summary>
        /// º≤≤°÷Œ¡∆√Ë ˆ
        /// </summary>
        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }
    }
}



