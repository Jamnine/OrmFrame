// ===================================================================   
// Model  
// ===================================================================   
// File: AdEmr.cs  
//   
// Copyright   
// History:  
// 2016/3/26 12:23:07: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{  
    [Serializable]
    /// <summary>  
    ///   数据库不存在此表
    /// </summary>  
    public partial class AdEmrVisits : BaseModel  
    {  
       

        private string _dietitianVisits;
        private string _sportsVisits;
        private string _psychologicalVisits;
        private string _tCMvisits;
        private string _otherVisits;
        private string _inquiryFunction;
        private string _hosId;


        public AdEmrVisits()  
        {  
        }  
  
        /// <summary>  
        ///   就诊id
        /// </summary>  
        public string HosId  
        {
            get { return this._hosId; }
            set { this._hosId = value; }  
        }  

         /// <summary>
         /// 主诊医生问诊
         /// </summary>
        public string InquiryFunction
        {
            get { return this._inquiryFunction; }
            set { this._inquiryFunction = value; }
        }

       
        /// <summary>
        /// 营养师问诊
        /// </summary>
        public string DietitianVisits
        {
            get { return this._dietitianVisits; }
            set { this._dietitianVisits = value; }
        }

        /// <summary>
        /// 运动师问诊
        /// </summary>
        public string SportsVisits
        {
            get { return this._sportsVisits; }
            set { this._sportsVisits = value; }
        }

        /// <summary>
        /// 心里医师问诊
        /// </summary>
        public string PsychologicalVisits
        {
            get { return this._psychologicalVisits; }
            set { this._psychologicalVisits = value; }
        }

        /// <summary>
        /// 中医师问诊
        /// </summary>
        public string TCMvisits
        {
            get { return this._tCMvisits; }
            set { this._tCMvisits = value; }
        }

        /// <summary>
        /// 其他医生问诊
        /// </summary>
        public string OtherVisits
        {
            get { return this._otherVisits; }
            set { this._otherVisits = value; }
        }
    }  
}  

