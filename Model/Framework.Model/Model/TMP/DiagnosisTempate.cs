using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Orm.Model
{
    [Serializable]
    public class DiagnosisTempate : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public DiagnosisTempate() { }

        private int _index = 0;
        /// <summary>
        /// 序号
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Index"));
            }
        }

        private string _id;
        /// <summary>
        /// 诊断意见ID
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _code = "";
        /// <summary>
        /// 疾病编码
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _name = "";
        /// <summary>
        /// 疾病名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private string _opinion = "";
        /// <summary>
        /// 治疗意见
        /// </summary>
        public string Opinion
        {
            get { return _opinion; }
            set { _opinion = value; }
        }
    }
}
