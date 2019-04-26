using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 转诊信息
    /// </summary>
    [Serializable]
    public class uspReferralRdlc :BaseModel ///患者收费情况报表
    {
        private string _patid;
        private string _patname = String.Empty;
        private string _memo;
        private string _lastdoctor;
        private string _doctor;
        private double _consumption;
        private DateTime _regTime;
        private DateTime _referralTime;
        private DateTime _operationTime;
        private double _oldconsumption;

        private string _cardNo;
        private string _department = string.Empty;
        private string _lastDepartment = string.Empty;
        private string _hosId;
        private string _oldhosId;

        public uspReferralRdlc() { }

        public DateTime OperationTime { get; set; }
        /// <summary>
        /// 转诊前处方id
        /// </summary>
        public string RecipeId { get; set; }
        /// <summary>
        /// 转诊后处方id
        /// </summary>
        public string OldRecipeId { get; set; }

        public string FeferalStatus { get; set; }

        /// <summary>
        /// 时段
        /// </summary>
        public string TimeSpan { get; set; }

        /// <summary>
        /// 客人ID
        /// </summary>
        public string PatId { get { return this._patid; } set { this._patid = value; } }

        /// <summary>
        /// 客人姓名
        /// </summary>
        public string PatName { get { return _patname; } set { _patname = value; } }

        /// <summary>
        /// 转诊备注
        /// </summary>
        public string Memo { get { return this._memo; } set { this._memo = value; } }

        public string LastDoctorId { get; set; }
        /// <summary>
        /// 转诊前医生
        /// </summary>
        public string LastDoctor { get { return this._lastdoctor; } set { this._lastdoctor = value; } }

        /// <summary>
        /// 转诊医生
        /// </summary>
        public string Doctor { get { return this._doctor; } set { this._doctor = value; } }

        /// <summary>
        /// 转诊前消费
        /// </summary>
        public double ConsumPtion { get { return this._consumption; } set { this._consumption = value; } }

        /// <summary>
        /// 转诊后消费
        /// </summary>
        public double OldConsumPtion { get { return this._oldconsumption; } set { this._oldconsumption = value; } }

        /// <summary>
        /// 就诊时间
        /// </summary>
        public DateTime RegTime { get { return this._regTime; } set { this._regTime = value; } }

        /// <summary>
        /// 转诊时间
        /// </summary>
        public DateTime ReferralTime { get { return this._referralTime; } set { this._referralTime = value; } }

        /// <summary>
        /// 病历号
        /// </summary>
        public string CardNo { get { return _cardNo; } set { _cardNo = value; } }

        /// <summary>
        /// 转诊后科室
        /// </summary>
        public string Department { get { return this._department; } set { this._department = value; } }

        /// <summary>
        /// 转诊前科室
        /// </summary>
        public string LastDepartment { get { return this._lastDepartment; } set { this._lastDepartment = value; } }


        /// <summary>
        /// 就诊Id
        /// </summary>
        public string HosId { get { return this._hosId; } set { this._hosId = value; } }

        /// <summary>
        /// 就诊Id
        /// </summary>
        public string OldHosId { get { return this._oldhosId; } set { this._oldhosId = value; } }

    }
}
