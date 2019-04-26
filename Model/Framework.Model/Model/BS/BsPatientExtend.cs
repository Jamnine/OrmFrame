using System;

namespace XYHis.Model
{
    /// <summary>
    ///病人表
    /// </summary>
    
    public partial class BsPatient 
    { 
        /// <summary>
        /// 病人类型
        /// </summary>
        public string PatType { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        public string HosPitalName { get; set; }

        private int _locationid;
        /// <summary>
        /// 门诊机构id  
        /// BsPatient表中的LocationId 字段删除掉  已在数据组王细想口中得到证实
        /// 如果需要关联医院 请关联ouhosinfo  或者 inhosinfo
        /// </summary>
        public int LocationId
        {
            get
            {
                return this._locationid;
            }
            set
            {
                this._locationid = value;
            }
        }

        /// <summary>
        /// 相片
        /// </summary>
        public byte[] Photo { get; set; }

        private string _pyCode;
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        private string _wbCode;
        /// <summary>
        /// 五笔码
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

    }
}



