

using System;
namespace Orm.Model
{
    /// <summary>
    /// 发血申请单 - 实体类
    /// </summary>
    [Serializable]
    public partial class CkBldApply : BaseModel
    {

        private string _recNo;  //申请单号

        private string _hospId;  //住院病人对应InHosinfo.Id

        private string _patBloodGroup;  //血型：1-A;2-B;3-O;4-AB

        private string _patRHD;  //RHD+

        private string _illness;  //临床诊断

        private string _purpose;  //输血目的

        private string _hstyBlood;  //输血史

        private string _hstyReact;  //输血反应史

        private string _hstyTest;  //配型史

        private string _hstyPregnancy;  //妊娠史

        private string _hstyBirth;  //分娩史

        private string _testResult;  //病人最近检查结果

        private string _bloodTypeId;  //血液品种

        private double _vollume;  //申请数量

        private string _unit;  //单位

        private int _preOps;  //术前先配

        private string _specHandle;  //特殊处理

        private string _bloodGroup;  //血型：1-A;2-B;3-O;4-AB

        private string _replace;  //替代品种

        private string _labNum;  //标本号

        private bool _isAgree;  //病人/病人家属是否签署输血治疗同意书

        private string _bloodBreeds;  //输血品种

        private string _mzRegId;  //MzRegId(关联OuHosInfo的ID)

        private string _operId;  //操作员Id,BsUser.Id

        private DateTime _operTime;  //申请时间

        private string _locationId;  //科室ID,Bslocation.id

        private int _patPhdBlood;  //病人血型

        private int _phdBlood;  //申请血型

        private bool _isMed;  //医务科是否审核

        private string _bloodBreedsSec;  //输血品种2

        private bool _isSelection;  //是否输血科主任审核

        private int _vollumeUse;  //申请数量使用

        private int _vollumeUseTwo;  //申请数量使用2

        private string _unitTwo;  //申请品种单位2

        private int _vollumeTwo;  //申请数量2

        private string _plt;  //PLT

        private string _hBsAg;  //HBsAg

        private string _antiHCV;  //AntiHCV

        private string _antiAIV;  //Anti_AIV1_2

        private string _syphilis;  //梅毒

        private bool _isAuthed;  //已经封存，不可改删

        private int _hospitalId;  //

        private string _hb;

        private string _hct;

        private string _alt;

        public CkBldApply() { }

        /// <summary>
        /// 申请单号
        /// </summary>
        public string RecNo
        {
            get { return _recNo; }
            set { _recNo = value; }
        }

        /// <summary>
        /// 住院病人对应InHosinfo.Id
        /// </summary>
        public string HospId
        {
            get { return _hospId; }
            set { _hospId = value; }
        }

        /// <summary>
        /// 血型：1-A;2-B;3-O;4-AB
        /// </summary>
        public string PatBloodGroup
        {
            get { return _patBloodGroup; }
            set { _patBloodGroup = value; }
        }

        /// <summary>
        /// RHD+
        /// </summary>
        public string PatRHD
        {
            get { return _patRHD; }
            set { _patRHD = value; }
        }

        /// <summary>
        /// 临床诊断
        /// </summary>
        public string Illness
        {
            get { return _illness; }
            set { _illness = value; }
        }

        /// <summary>
        /// 输血目的
        /// </summary>
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }

        /// <summary>
        /// 输血史
        /// </summary>
        public string HstyBlood
        {
            get { return _hstyBlood; }
            set { _hstyBlood = value; }
        }

        /// <summary>
        /// 输血反应史
        /// </summary>
        public string HstyReact
        {
            get { return _hstyReact; }
            set { _hstyReact = value; }
        }

        /// <summary>
        /// 配型史
        /// </summary>
        public string HstyTest
        {
            get { return _hstyTest; }
            set { _hstyTest = value; }
        }

        /// <summary>
        /// 妊娠史
        /// </summary>
        public string HstyPregnancy
        {
            get { return _hstyPregnancy; }
            set { _hstyPregnancy = value; }
        }

        /// <summary>
        /// 分娩史
        /// </summary>
        public string HstyBirth
        {
            get { return _hstyBirth; }
            set { _hstyBirth = value; }
        }

        /// <summary>
        /// 病人最近检查结果
        /// </summary>
        public string TestResult
        {
            get { return _testResult; }
            set { _testResult = value; }
        }

        /// <summary>
        /// 血液品种
        /// </summary>
        public string BloodTypeId
        {
            get { return _bloodTypeId; }
            set { _bloodTypeId = value; }
        }

        /// <summary>
        /// 申请数量
        /// </summary>
        public double Vollume
        {
            get { return _vollume; }
            set { _vollume = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        /// <summary>
        /// 术前先配
        /// </summary>
        public int PreOps
        {
            get { return _preOps; }
            set { _preOps = value; }
        }

        /// <summary>
        /// 特殊处理
        /// </summary>
        public string SpecHandle
        {
            get { return _specHandle; }
            set { _specHandle = value; }
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
        /// 替代品种
        /// </summary>
        public string Replace
        {
            get { return _replace; }
            set { _replace = value; }
        }

        /// <summary>
        /// 标本号
        /// </summary>
        public string LabNum
        {
            get { return _labNum; }
            set { _labNum = value; }
        }

        /// <summary>
        /// 病人/病人家属是否签署输血治疗同意书
        /// </summary>
        public bool IsAgree
        {
            get { return _isAgree; }
            set { _isAgree = value; }
        }

        /// <summary>
        /// 输血品种
        /// </summary>
        public string BloodBreeds
        {
            get { return _bloodBreeds; }
            set { _bloodBreeds = value; }
        }

        /// <summary>
        /// MzRegId(关联OuHosInfo的ID)
        /// </summary>
        public string MzRegId
        {
            get { return _mzRegId; }
            set { _mzRegId = value; }
        }

        /// <summary>
        /// 操作员Id,BsUser.Id
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

        /// <summary>
        /// 科室ID,Bslocation.id
        /// </summary>
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        /// <summary>
        /// 病人血型
        /// </summary>
        public int PatPhdBlood
        {
            get { return _patPhdBlood; }
            set { _patPhdBlood = value; }
        }

        /// <summary>
        /// 申请血型
        /// </summary>
        public int PhdBlood
        {
            get { return _phdBlood; }
            set { _phdBlood = value; }
        }

        /// <summary>
        /// 医务科是否审核
        /// </summary>
        public bool IsMed
        {
            get { return _isMed; }
            set { _isMed = value; }
        }

        /// <summary>
        /// 输血品种2
        /// </summary>
        public string BloodBreedsSec
        {
            get { return _bloodBreedsSec; }
            set { _bloodBreedsSec = value; }
        }

        /// <summary>
        /// 是否输血科主任审核
        /// </summary>
        public bool IsSelection
        {
            get { return _isSelection; }
            set { _isSelection = value; }
        }

        /// <summary>
        /// 申请数量使用
        /// </summary>
        public int VollumeUse
        {
            get { return _vollumeUse; }
            set { _vollumeUse = value; }
        }

        /// <summary>
        /// 申请数量使用2
        /// </summary>
        public int VollumeUseTwo
        {
            get { return _vollumeUseTwo; }
            set { _vollumeUseTwo = value; }
        }

        /// <summary>
        /// 申请品种单位2
        /// </summary>
        public string UnitTwo
        {
            get { return _unitTwo; }
            set { _unitTwo = value; }
        }

        /// <summary>
        /// 申请数量2
        /// </summary>
        public int VollumeTwo
        {
            get { return _vollumeTwo; }
            set { _vollumeTwo = value; }
        }

        /// <summary>
        /// PLT
        /// </summary>
        public string Plt
        {
            get { return _plt; }
            set { _plt = value; }
        }

        /// <summary>
        /// HBsAg
        /// </summary>
        public string HBsAg
        {
            get { return _hBsAg; }
            set { _hBsAg = value; }
        }

        /// <summary>
        /// AntiHCV
        /// </summary>
        public string AntiHCV
        {
            get { return _antiHCV; }
            set { _antiHCV = value; }
        }

        /// <summary>
        /// Anti_AIV1_2
        /// </summary>
        public string AntiAIV
        {
            get { return _antiAIV; }
            set { _antiAIV = value; }
        }

        /// <summary>
        /// 梅毒
        /// </summary>
        public string Syphilis
        {
            get { return _syphilis; }
            set { _syphilis = value; }
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

        public string Hb
        {
            get { return _hb; }
            set { _hb = value; }
        }

        public string Hct
        {
            get { return _hct; }
            set { _hct = value; }
        }

        public string Alt
        {
            get { return _alt; }
            set { _alt = value; }
        }
    }
}


