

using System;
namespace Orm.Model
{
	/// <summary>
	/// 科室病人互助献血 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkBldDonate : BaseModel
    {

        private string _hospId;  //住院病人对应InHosinfo.Id

        private string _locationId;  //科室

        private string _bloodGroup;  //血型：1-A;2-B;3-O;4-AB

        private string _bloodTypeId;  //血液种类

        private double _vollume;  //血量

        private string _memo;  //备注

        private DateTime _operTime;  //操作时间

        private string _operId;  //操作员ID,BsUser.Id

        private string _bloodDonor;  //献血者

        private string _mzRegId;  //门诊病人对应ouhosinfo.id

        private string _receptor;  //受血者血型

        private bool _isAuthed;  //已经封存，不可改删

        private int _hospitalId;  //

        private string _phd;

        public CkBldDonate() { }

        /// <summary>
        /// 住院病人对应InHosinfo.Id
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 血型：1-A;2-B;3-O;4-AB
        /// </summary>
        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }

        /// <summary>
        /// 血液种类
        /// </summary>
        public string BloodTypeId
        {
            get { return _bloodTypeId; }
            set { _bloodTypeId = value; }
        }

        /// <summary>
        /// 血量
        /// </summary>
        public double Vollume
        {
            get { return _vollume; }
            set { _vollume = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 操作员ID,BsUser.Id
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 献血者
        /// </summary>
        public string BloodDonor
        {
            get { return _bloodDonor; }
            set { _bloodDonor = value; }
        }

        /// <summary>
        /// 门诊病人对应ouhosinfo.id
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 受血者血型
        /// </summary>
        public string Receptor
        {
            get { return _receptor; }
            set { _receptor = value; }
        }

        /// <summary>
        /// 已经封存，不可改删
        /// </summary>
        public bool IsAuthed
        {
            get { return _isAuthed; }
            set { _isAuthed = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int HospitalId
        {
            get { return _hospitalId; }
            set { _hospitalId = value; }
        }

        public string RHD
        {
            get { return _phd; }
            set { _phd = value; }
        }
    }
}           


