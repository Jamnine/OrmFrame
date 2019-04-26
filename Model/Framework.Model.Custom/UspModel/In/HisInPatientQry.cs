using System;
using System.Data;
using System.Data.Common;

namespace Orm.Model.Custom
{

    #region class of Model:HisInPatientQry
    /// <summary>
    /// This object represents the properties and methods of a HisInPatient.
    /// </summary>
    [Serializable]
    public class HisInPatientQry : BaseModel
    {
       
        protected string _patTypeId;
        protected string _doctorId;
        protected string _motherHospId;
        protected string _patID;
        protected string _locationId;
        protected string _bedID;
        protected string _patientName = String.Empty;
        protected string _doctorName = String.Empty;
        protected string _patTypeName = String.Empty;
        protected string _bedName = String.Empty;
        protected string _locationName = String.Empty;
        protected string _hospNo = String.Empty;
        protected int _nTime;
        protected DateTime _inTime;
        protected DateTime _outTime;
        protected bool _firtDay;
        protected string _sex = String.Empty;
        protected int _lsInStatus;
        protected string _lsInStatus2 = String.Empty;
        protected string _cardNo = String.Empty;
        protected string _inPatNo = String.Empty;
        protected bool _bedIsAdd;
        protected int _bedOrderBy;
        protected string _tallyTypeId;
        protected string _tallyTypeName = String.Empty;
        protected string _tallyGroupId;
        protected string _tallyGroupName = String.Empty;
        protected DateTime _birthDate=DateTime.MinValue;
        protected string _getTallyType = String.Empty;
        protected bool _isGf;
        protected bool _isYb;
        protected string _getTallyTypeName = String.Empty;
        protected int _age;
        protected string _native = String.Empty;
        protected string _residence = String.Empty;
        protected string _company = String.Empty;
        protected string _occupation = String.Empty;
        protected string _mobile = String.Empty;
        protected string _phone = String.Empty;
        protected string _sensitive = String.Empty;
        protected string _idCardNo = String.Empty;
        protected string _medicareNo = String.Empty;
        protected string _linkmanName = String.Empty;
        protected double _arrearAmount;
        protected string _ageString = String.Empty;
        protected string _workTypeName = String.Empty;
        protected string _marriageName = String.Empty;
        protected string _doctorCode = String.Empty;
        protected string _locationCode = String.Empty;
        protected string _lsInStatusName = String.Empty;
        protected bool _iSYBAUTH;
        protected bool _isTodayOut;
        protected double _weight;
        public HisInPatientQry()
        {
        }

 
        #region Public Properties

        public string PatTypeId
        {
            get { return _patTypeId; }
            set { _patTypeId = value; }
        }

        public string DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }

        public string MotherHospId
        {
            get { return _motherHospId; }
            set { _motherHospId = value; }
        }

        public string PatID
        {
            get { return _patID; }
            set { _patID = value; }
        }

        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public string BedID
        {
            get { return _bedID; }
            set { _bedID = value; }
        }

        public string PatientName
        {
            get { return _patientName; }
            set { _patientName = value; }
        }

        public string DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; }
        }

        public string PatTypeName
        {
            get { return _patTypeName; }
            set { _patTypeName = value; }
        }

        public string BedName
        {
            get { return _bedName; }
            set { _bedName = value; }
        }

        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        public string HospNo
        {
            get { return _hospNo; }
            set { _hospNo = value; }
        }

        public int NTime
        {
            get { return _nTime; }
            set { _nTime = value; }
        }

        public DateTime InTime
        {
            get { return _inTime; }
            set { _inTime = value; }
        }

        public DateTime OutTime
        {
            get { return _outTime; }
            set { _outTime = value; }
        }

        public bool FirtDay
        {
            get { return _firtDay; }
            set { _firtDay = value; }
        }

        public string DoctorCode
        {
            get { return _doctorCode; }
            set { _doctorCode = value; }
        }
        public string LocationCode
        {
            get { return _locationCode; }
            set { _locationCode = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public int LsInStatus
        {
            get { return _lsInStatus; }
            set { _lsInStatus = value; }
        }

        public string LsInStatus2
        {
            get { return _lsInStatus2; }
            set { _lsInStatus2 = value; }
        }

        public string CardNo
        {
            get { return _cardNo; }
            set { _cardNo = value; }
        }

        public string InPatNo
        {
            get { return _inPatNo; }
            set { _inPatNo = value; }
        }

        public bool BedIsAdd
        {
            get { return _bedIsAdd; }
            set { _bedIsAdd = value; }
        }

        public int BedOrderBy
        {
            get { return _bedOrderBy; }
            set { _bedOrderBy = value; }
        }

        public string TallyTypeId
        {
            get { return _tallyTypeId; }
            set { _tallyTypeId = value; }
        }

        public string TallyTypeName
        {
            get { return _tallyTypeName; }
            set { _tallyTypeName = value; }
        }

        public string TallyGroupId
        {
            get { return _tallyGroupId; }
            set { _tallyGroupId = value; }
        }

        public string TallyGroupName
        {
            get { return _tallyGroupName; }
            set { _tallyGroupName = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string GetTallyType
        {
            get { return _getTallyType; }
            set { _getTallyType = value; }
        }

        public bool IsGf
        {
            get { return _isGf; }
            set { _isGf = value; }
        }

        public bool IsYb
        {
            get { return _isYb; }
            set { _isYb = value; }
        }

        public string GetTallyTypeName
        {
            get { return _getTallyTypeName; }
            set { _getTallyTypeName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Native
        {
            get { return _native; }
            set { _native = value; }
        }

        public string Residence
        {
            get { return _residence; }
            set { _residence = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string Occupation
        {
            get { return _occupation; }
            set { _occupation = value; }
        }

        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Sensitive
        {
            get { return _sensitive; }
            set { _sensitive = value; }
        }

        public string IdCardNo
        {
            get { return _idCardNo; }
            set { _idCardNo = value; }
        }

        public string MedicareNo
        {
            get { return _medicareNo; }
            set { _medicareNo = value; }
        }

        public string LinkmanName
        {
            get { return _linkmanName; }
            set { _linkmanName = value; }
        }

        public double ArrearAmount
        {
            get { return _arrearAmount; }
            set { _arrearAmount = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        
        public string AgeString
        {
            get { return _ageString; }
            set { _ageString = value; }
        }

        public string WorkTypeName
        {
            get { return _workTypeName; }
            set { _workTypeName = value; }
        }

        public string MarriageName
        {
            get { return _marriageName; }
            set { _marriageName = value; }
        }

        public string LsInStatusName
        {
            get { return _lsInStatusName; }
            set { _lsInStatusName = value; }
        }

        /// <summary>  
        /// 确认为可报销病人  
        /// </summary>  
        public bool ISYBAUTH
        {
            get { return _iSYBAUTH; }
            set { _iSYBAUTH = value; }
        }
        public bool IsTodayOut
        {
            get { return _isTodayOut; }
            set { _isTodayOut = value; }
        }  
        
        #endregion
    }
    #endregion
}


