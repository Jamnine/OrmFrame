
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:uspInHosInfoQry
    /// <summary>
    /// This object represents the properties and methods of a uspInHosInfoByCardNo.
    /// </summary>
    public class uspInHosInfoQry : BaseModel
    {
         
        private string _hospNo = String.Empty;
        private string _inPatNo = String.Empty;
        private string _cardNo = String.Empty;
        private string _name = String.Empty;
        private string _sex = String.Empty;
        private DateTime _birthDate;
        private int _lsMarriage;
        private string _bloodGroup = String.Empty;
        private DateTime _inTime;
        private int _nTime;
        private string _xNo = String.Empty;
        private string _countryId;
        private string _residence = String.Empty;
        private string _city = String.Empty;
        private string _province = String.Empty;
        private bool _isOversea;
        private DateTime _passTime;
        private string _idCardNo = String.Empty;
        private string _company = String.Empty;
        private string _occupation = String.Empty;
        private string _worktypeId;
        private string _patTypeId;
        private string _certificateId;
        private int _lsInType;
        private int _lsInWay;
        private int _lsInIllness;
        private int _docMz;
        private string _doctorId;
        private int _locIn;
        private string _locationId;
        private string _bedId;
        private bool _isYbMt;
        private bool _isObserved;
        private string _ybRegNo = String.Empty;
        private double _arrearAmount;
        private bool _isBaby;
        private int _ageDay;
        private double _height;
        private double _weight;
        private string _phoneHome = String.Empty;
        private string _addressHome = String.Empty;
        private string _postCodeHome = String.Empty;
        private string _areaCodeHome = String.Empty;
        private string _phoneWork = String.Empty;
        private string _addressWork = String.Empty;
        private string _postCodeWork = String.Empty;
        private string _areaCodeWork = String.Empty;
        private string _linkmanName = String.Empty;
        private string _relationId;
        private string _linkmanPhone = String.Empty;
        private string _linkmanAddress = String.Empty;
        private string _linkmanPost = String.Empty;
        private string _linkmanArea = String.Empty;
        private int _lsInStatus;
        private string _status = String.Empty;
        private DateTime _operTime;
        private string _operID;
        private string _medicareNo = String.Empty;
        private string _accountNo = String.Empty;
        private string _regionId;
        private string _areaId;
        private string _native = String.Empty;
        private string _mobile = String.Empty;
        private string _email = String.Empty;
        private string _phone = String.Empty;
        private int _circumference;
        private int _waistline;
        private int _sternline;
        private string _patID;
        private DateTime _outTime;
        private bool _isEndChg;
        private bool _isIllegal; 
        private string _endChgOperID;
        private DateTime _endchgoperTime;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _memo = String.Empty;
        private string _f4 = String.Empty;
        private string _nationId;
        private string _provinceId;
        private string _sensitive = String.Empty;
        private string _familyId;
        private bool _isHouseMaster;
        private string _relaMasterId;
        private int _lsCensus;
        private string _committeeId;
        private string _policeStationId;
        private string _levelId;
        private int _lsSport;
        private int _lsSportTime;
        private int _lsSportType;
        private int _lsBitHabit;
        private int _sleepHour;
        private int _lsSleepTrouble;
        private string _smokeHistory = String.Empty;
        private string _drinkHistory = String.Empty;
        private string _otherHabit = String.Empty;
        private bool _isActive;
        private string _inActiveReason = String.Empty;
        private DateTime _inActiveTime;
        private string _inActiveOperID;
        private int _iconIndex;
        private string _fromHospitalId;
        private string _mzRegId;
        private string _tipsNurse = String.Empty;  
        private string _tipsBalance = String.Empty;  
        private string _tipsOther = String.Empty;  
        private string _otherRoles = String.Empty;
        private string _lsInStatus2 = String.Empty;
        private bool _iSYBAUTH = false;

        private string _cARDNO2 = String.Empty;
        private int _iSPRICESTATE;
        private int _nUMBER1;
        private int _nUMBER2;
        private int _nUMBER3;
        private int _nUMBER4;
        private string _f5 = String.Empty;
        private string _f6 = String.Empty;
        private string _f7 = String.Empty;
        private string _f8 = String.Empty;
        private DateTime _newBabyInDate;
        public uspInHosInfoQry()
        {
        }



   
        #region Public Properties   

  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string HospNo  
        {  
            get { return _hospNo; }  
            set { _hospNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string InPatNo  
        {  
            get { return _inPatNo; }  
            set { _inPatNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string CardNo  
        {  
            get { return _cardNo; }  
            set { _cardNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Name  
        {  
            get { return _name; }  
            set { _name = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Sex  
        {  
            get { return _sex; }  
            set { _sex = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime BirthDate  
        {  
            get { return _birthDate; }  
            set { _birthDate = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsMarriage  
        {  
            get { return _lsMarriage; }  
            set { _lsMarriage = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string BloodGroup  
        {  
            get { return _bloodGroup; }  
            set { _bloodGroup = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime InTime  
        {  
            get { return _inTime; }  
            set { _inTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int NTime  
        {  
            get { return _nTime; }  
            set { _nTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string XNo  
        {  
            get { return _xNo; }  
            set { _xNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string CountryId  
        {  
            get { return _countryId; }  
            set { _countryId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Residence  
        {  
            get { return _residence; }  
            set { _residence = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string City  
        {  
            get { return _city; }  
            set { _city = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Province  
        {  
            get { return _province; }  
            set { _province = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsOversea  
        {  
            get { return _isOversea; }  
            set { _isOversea = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime PassTime  
        {  
            get { return _passTime; }  
            set { _passTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string IdCardNo  
        {  
            get { return _idCardNo; }  
            set { _idCardNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Company  
        {  
            get { return _company; }  
            set { _company = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Occupation  
        {  
            get { return _occupation; }  
            set { _occupation = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string WorktypeId  
        {  
            get { return _worktypeId; }  
            set { _worktypeId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PatTypeId  
        {  
            get { return _patTypeId; }  
            set { _patTypeId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string CertificateId  
        {  
            get { return _certificateId; }  
            set { _certificateId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsInType  
        {  
            get { return _lsInType; }  
            set { _lsInType = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsInWay  
        {  
            get { return _lsInWay; }  
            set { _lsInWay = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsInIllness  
        {  
            get { return _lsInIllness; }  
            set { _lsInIllness = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int DocMz  
        {  
            get { return _docMz; }  
            set { _docMz = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string DoctorId  
        {  
            get { return _doctorId; }  
            set { _doctorId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LocIn  
        {  
            get { return _locIn; }  
            set { _locIn = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LocationId  
        {  
            get { return _locationId; }  
            set { _locationId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string BedId  
        {  
            get { return _bedId; }  
            set { _bedId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsYbMt  
        {  
            get { return _isYbMt; }  
            set { _isYbMt = value; }  
        }
        public bool IsObserved  
        {
            get { return _isObserved; }
            set { _isObserved = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string YbRegNo  
        {  
            get { return _ybRegNo; }  
            set { _ybRegNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public double ArrearAmount  
        {  
            get { return _arrearAmount; }  
            set { _arrearAmount = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsBaby  
        {  
            get { return _isBaby; }  
            set { _isBaby = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int AgeDay  
        {  
            get { return _ageDay; }  
            set { _ageDay = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public double Height  
        {  
            get { return _height; }  
            set { _height = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public double Weight  
        {  
            get { return _weight; }  
            set { _weight = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PhoneHome  
        {  
            get { return _phoneHome; }  
            set { _phoneHome = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AddressHome  
        {  
            get { return _addressHome; }  
            set { _addressHome = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PostCodeHome  
        {  
            get { return _postCodeHome; }  
            set { _postCodeHome = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AreaCodeHome  
        {  
            get { return _areaCodeHome; }  
            set { _areaCodeHome = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PhoneWork  
        {  
            get { return _phoneWork; }  
            set { _phoneWork = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AddressWork  
        {  
            get { return _addressWork; }  
            set { _addressWork = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PostCodeWork  
        {  
            get { return _postCodeWork; }  
            set { _postCodeWork = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AreaCodeWork  
        {  
            get { return _areaCodeWork; }  
            set { _areaCodeWork = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LinkmanName  
        {  
            get { return _linkmanName; }  
            set { _linkmanName = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string RelationId  
        {  
            get { return _relationId; }  
            set { _relationId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LinkmanPhone  
        {  
            get { return _linkmanPhone; }  
            set { _linkmanPhone = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LinkmanAddress  
        {  
            get { return _linkmanAddress; }  
            set { _linkmanAddress = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LinkmanPost  
        {  
            get { return _linkmanPost; }  
            set { _linkmanPost = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LinkmanArea  
        {  
            get { return _linkmanArea; }  
            set { _linkmanArea = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsInStatus  
        {  
            get { return _lsInStatus; }  
            set { _lsInStatus = value; }  
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string LsInStatus2
        {
            get { return _lsInStatus2; }
            set { _lsInStatus2 = value; }
        } 
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Status  
        {  
            get { return _status; }  
            set { _status = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime OperTime  
        {  
            get { return _operTime; }  
            set { _operTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string OperID  
        {  
            get { return _operID; }  
            set { _operID = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string MedicareNo  
        {  
            get { return _medicareNo; }  
            set { _medicareNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AccountNo  
        {  
            get { return _accountNo; }  
            set { _accountNo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string RegionId  
        {  
            get { return _regionId; }  
            set { _regionId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string AreaId  
        {  
            get { return _areaId; }  
            set { _areaId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Native  
        {  
            get { return _native; }  
            set { _native = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Mobile  
        {  
            get { return _mobile; }  
            set { _mobile = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Email  
        {  
            get { return _email; }  
            set { _email = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Phone  
        {  
            get { return _phone; }  
            set { _phone = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int Circumference  
        {  
            get { return _circumference; }  
            set { _circumference = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int Waistline  
        {  
            get { return _waistline; }  
            set { _waistline = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int Sternline  
        {  
            get { return _sternline; }  
            set { _sternline = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PatID  
        {  
            get { return _patID; }  
            set { _patID = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime OutTime  
        {  
            get { return _outTime; }  
            set { _outTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsEndChg  
        {  
            get { return _isEndChg; }  
            set { _isEndChg = value; }  
        }  
        /// <summary>
        ///  
        /// </summary>
        public bool IsIllegal
        {
            get { return _isIllegal; }
            set { _isIllegal = value; }
        }
        public string EndChgOperID  
        {  
            get { return _endChgOperID; }  
            set { _endChgOperID = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime EndchgoperTime  
        {  
            get { return _endchgoperTime; }  
            set { _endchgoperTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string F1  
        {  
            get { return _f1; }  
            set { _f1 = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string F2  
        {  
            get { return _f2; }  
            set { _f2 = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string F3  
        {  
            get { return _f3; }  
            set { _f3 = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Memo  
        {  
            get { return _memo; }  
            set { _memo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string F4  
        {  
            get { return _f4; }  
            set { _f4 = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string NationId  
        {  
            get { return _nationId; }  
            set { _nationId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string ProvinceId  
        {  
            get { return _provinceId; }  
            set { _provinceId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Sensitive  
        {  
            get { return _sensitive; }  
            set { _sensitive = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string FamilyId  
        {  
            get { return _familyId; }  
            set { _familyId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsHouseMaster  
        {  
            get { return _isHouseMaster; }  
            set { _isHouseMaster = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string RelaMasterId  
        {  
            get { return _relaMasterId; }  
            set { _relaMasterId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsCensus  
        {  
            get { return _lsCensus; }  
            set { _lsCensus = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string CommitteeId  
        {  
            get { return _committeeId; }  
            set { _committeeId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string PoliceStationId  
        {  
            get { return _policeStationId; }  
            set { _policeStationId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string LevelId  
        {  
            get { return _levelId; }  
            set { _levelId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsSport  
        {  
            get { return _lsSport; }  
            set { _lsSport = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsSportTime  
        {  
            get { return _lsSportTime; }  
            set { _lsSportTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsSportType  
        {  
            get { return _lsSportType; }  
            set { _lsSportType = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsBitHabit  
        {  
            get { return _lsBitHabit; }  
            set { _lsBitHabit = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int SleepHour  
        {  
            get { return _sleepHour; }  
            set { _sleepHour = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsSleepTrouble  
        {  
            get { return _lsSleepTrouble; }  
            set { _lsSleepTrouble = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string SmokeHistory  
        {  
            get { return _smokeHistory; }  
            set { _smokeHistory = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string DrinkHistory  
        {  
            get { return _drinkHistory; }  
            set { _drinkHistory = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string OtherHabit  
        {  
            get { return _otherHabit; }  
            set { _otherHabit = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsActive  
        {  
            get { return _isActive; }  
            set { _isActive = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string InActiveReason  
        {  
            get { return _inActiveReason; }  
            set { _inActiveReason = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime InActiveTime  
        {  
            get { return _inActiveTime; }  
            set { _inActiveTime = value; }  
        }
        public DateTime NewBabyInDate  
        {
            get { return _newBabyInDate; }
            set { _newBabyInDate = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string InActiveOperID  
        {  
            get { return _inActiveOperID; }  
            set { _inActiveOperID = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int IconIndex  
        {  
            get { return _iconIndex; }  
            set { _iconIndex = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string FromHospitalId  
        {  
            get { return _fromHospitalId; }  
            set { _fromHospitalId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string MzRegId  
        {  
            get { return _mzRegId; }  
            set { _mzRegId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string TipsNurse  
        {  
            get { return _tipsNurse; }  
            set { _tipsNurse = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string TipsBalance  
        {  
            get { return _tipsBalance; }  
            set { _tipsBalance = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string TipsOther  
        {  
            get { return _tipsOther; }  
            set { _tipsOther = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string OtherRoles  
        {  
            get { return _otherRoles; }  
            set { _otherRoles = value; }  
        }

        /// <summary>  
        /// 确认为可报销病人  
        /// </summary>  
        public bool ISYBAUTH
        {
            get { return _iSYBAUTH; }
            set { _iSYBAUTH = value; }
        }
        /// <summary>  
        ///   
        /// </summary>  
        public string CARDNO2
        {
            get { return _cARDNO2; }
            set { _cARDNO2 = value; }
        }

        /// <summary>  
        /// 0正常价，1特殊价  
        /// </summary>  
        public int ISPRICESTATE
        {
            get { return _iSPRICESTATE; }
            set { _iSPRICESTATE = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int NUMBER1
        {
            get { return _nUMBER1; }
            set { _nUMBER1 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int NUMBER2
        {
            get { return _nUMBER2; }
            set { _nUMBER2 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int NUMBER3
        {
            get { return _nUMBER3; }
            set { _nUMBER3 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int NUMBER4
        {
            get { return _nUMBER4; }
            set { _nUMBER4 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F5
        {
            get { return _f5; }
            set { _f5 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F6
        {
            get { return _f6; }
            set { _f6 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F7
        {
            get { return _f7; }
            set { _f7 = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string F8
        {
            get { return _f8; }
            set { _f8 = value; }
        }  
  


        #endregion   
    }   
    #endregion   
}   
   
   
   



