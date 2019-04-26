using System;

namespace Orm.Model
{
    /// <summary>
    /// 医院可以转诊医院的关系表
    /// </summary>
    [Serializable]

    public partial class BsHospitalRelation : BaseModel
    {

        private int _outhospitalid;
        private int _inhospitalid;
        private bool _isexchange;
        private string _relationdesc;

        /// <summary>
        /// 医院可以转诊医院的关系表
        /// </summary>
        public BsHospitalRelation() { }

        /// <summary>
        /// 转出医院
        /// </summary>
        public int OutHospitalId
        {
            get { return this._outhospitalid; }
            set { this._outhospitalid = value; }
        }

        /// <summary>
        /// 转入医院
        /// </summary>
        public int InHospitalId
        {
            get { return this._inhospitalid; }
            set { this._inhospitalid = value; }
        }

        /// <summary>
        /// 是否可以双向转院
        /// </summary>
        public bool IsExChange
        {
            get { return this._isexchange; }
            set { this._isexchange = value; }
        }

        /// <summary>
        /// 医院关系Str
        /// </summary>
        public string RelationDesc
        {
            get { return this._relationdesc; }
            set { this._relationdesc = value; }
        }

        /// <summary>
        /// 转出医院名称
        /// </summary>
        public string OutHospitalName { get; set; }


        /// <summary>
        /// 转入医院名称
        /// </summary>
        public string InHospitalName { get; set; }
         
        /// <summary>
        /// 转入医院省份ID
        /// </summary>
        public string ProvinceId { get; set; }

        /// <summary>
        /// 转入医院省份名称
        /// </summary>
        public string ProvinceName { get; set; }

        /// <summary>
        /// 转入医院城市ID
        /// </summary>
        public string RegIonId { get; set; } 

        /// <summary>
        /// 转入医院城市名称
        /// </summary>
        public string RegIonName { get; set; }
    }
}