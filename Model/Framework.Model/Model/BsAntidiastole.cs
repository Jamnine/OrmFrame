using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>
    /// 鉴别诊断
    /// </summary>
    public class BsAntidiastole : BaseModel
    {
        private string _title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _symptom;
        /// <summary>
        /// 从症状鉴别
        /// </summary>
        public string Symptom
        {
            get { return _symptom; }
            set { _symptom = value; }
        }
        private string _check;
        /// <summary>
        /// 从检查鉴别
        /// </summary>
        public string FromCheck
        {
            get { return _check; }
            set { _check = value; }
        }
        private int _xmlId;
        /// <summary>
        /// 对应的疾病id
        /// </summary>
        public int XmlId
        {
            get { return _xmlId; }
            set { _xmlId = value; }
        }

    }
}
