// ===================================================================   
// Model  
// ===================================================================   
// File: AFClinicalWasteRecord.cs  
//   
// Copyright   
// History:  
// 2015/7/1 14:39:22: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// Stru  医疗废物记录表
    /// </summary>  
    [Serializable]
    public partial class AFClinicalWasteRecord : BaseModel
    {
        private int _recordMonth;
        private int _recordDay;
        private double _infectWeight;
        private double _pathologicWeight;
        private double _traumaticWeight;
        private double _drugsWeight;
        private double _chemicalWeight;
        private DateTime _handDate;
        private DateTime _operTime;
        private string _operId;
        private string _memo = String.Empty;
        private string _handLocManID;
        private string _speciallyManID;
        private string _institutionManID;
        private string _goManID;

        public AFClinicalWasteRecord()
        {
        }


        /// <summary>  
        /// 登记月份201507  
        /// </summary>  
        public int RecordMonth
        {
            get { return this._recordMonth; }
            set { this._recordMonth = value; }
        }

        /// <summary>  
        /// 某月的某天  
        /// </summary>  
        public int RecordDay
        {
            get { return this._recordDay; }
            set { this._recordDay = value; }
        }

        /// <summary>  
        /// 感染性重量  
        /// </summary>  
        public double InfectWeight
        {
            get { return this._infectWeight; }
            set { this._infectWeight = value; }
        }

        /// <summary>  
        /// 病理性重量  
        /// </summary>  
        public double PathologicWeight
        {
            get { return this._pathologicWeight; }
            set { this._pathologicWeight = value; }
        }

        /// <summary>  
        /// 损伤性重量  
        /// </summary>  
        public double TraumaticWeight
        {
            get { return this._traumaticWeight; }
            set { this._traumaticWeight = value; }
        }

        /// <summary>  
        /// 药物性重量  
        /// </summary>  
        public double DrugsWeight
        {
            get { return this._drugsWeight; }
            set { this._drugsWeight = value; }
        }

        /// <summary>  
        /// 化学性重量  
        /// </summary>  
        public double ChemicalWeight
        {
            get { return this._chemicalWeight; }
            set { this._chemicalWeight = value; }
        }

        /// <summary>  
        /// 交接时间  
        /// </summary>  
        public DateTime HandDate
        {
            get { return this._handDate; }
            set { this._handDate = value; }
        }

        /// <summary>  
        /// 录入日期  
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 录入人  
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 备注  
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>  
        /// 诊所交接签名  
        /// </summary>  
        public string HandLocManID
        {
            get { return this._handLocManID; }
            set { this._handLocManID = value; }
        }

        /// <summary>  
        /// 专管人签名  
        /// </summary>  
        public string SpeciallyManID
        {
            get { return this._speciallyManID; }
            set { this._speciallyManID = value; }
        }

        /// <summary>  
        /// 机构主管人签名  
        /// </summary>  
        public string InstitutionManID
        {
            get { return this._institutionManID; }
            set { this._institutionManID = value; }
        }

        /// <summary>  
        /// 最终去向签名  
        /// </summary>  
        public string GoManID
        {
            get { return this._goManID; }
            set { this._goManID = value; }
        }

    }
}
