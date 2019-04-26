using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspChargeFeezyAmount///日期收费分类报表
    {
        private string _FeeID;
        private string _FeeName = String.Empty;
        private string _locationId;
        private string _locationName = String.Empty;
        private DateTime _operTime;
        private double _Amount;
        private string _doctorId;
        private string _doctorName = string.Empty;
        private string _departmentId;
        private string _departmentName = string.Empty;
        private string _nurse = string.Empty;
        private string _nurseId;
        private string _ouHosInfoId;

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }


        public uspChargeFeezyAmount() { }

        public string LocationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }

        /// <summary>
        /// 护士名称
        /// </summary>
        public string NurseName
        {
            get
            {
                return this._nurse;
            }
            set
            {
                this._nurse = value;
            }
        }
        /// <summary>
        /// 护士ID
        /// </summary>
        public string NurseId
        {
            get
            {
                return this._nurseId;
            }
            set
            {
                this._nurseId = value;
            }
        }


        public string DepartmentId
        {
            get
            {
                return this._departmentId;
            }
            set
            {
                this._departmentId = value;
            }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string DepartmentName
        {
            get
            {
                return this._departmentName;
            }
            set
            {
                this._departmentName = value;
            }
        }

        private string DoctorId
        {
            get
            {
                return this._doctorId;
            }
            set
            {
                this._doctorId = value;
            }
        }
        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;
            }
        }

        /// <summary>
        /// 科室
        /// </summary>
        public string LocationName
        {
            get
            {
                return this._locationName;
            }
            set
            {
                this._locationName = value;
            }
        }
        /// <summary>
        /// 收费类别ID
        /// </summary>
        public string FeeID
        {
            get { return _FeeID; }
            set { _FeeID = value; }
        }
        /// <summary>
        /// 收费类别
        /// </summary>
        public string FeeName
        {
            get
            {
                return this._FeeName;
            }
            set
            {
                this._FeeName = value;
            }
        }
        /// <summary>
        /// 日期.
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                _Amount = value;
            }
        }
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊患者
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

        /// <summary>
        /// 门诊挂号表ID
        /// </summary>
        public string OuhosInfoId
        {
            get { return _ouHosInfoId; }
            set { _ouHosInfoId = value; }
        }
    }
}
