// ===================================================================   
// Model  
// ===================================================================   
// File: TjSummary.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:12:20: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    /// 体检小结  数据库不存在此表
    /// </summary>  
    [Serializable]  
   
    public partial class TjSummary : BaseModel  
    {  
        private string _mzRegId;  
        private string _doctorId;  
        private string _tjLocationID;  
        private string _summary = String.Empty;  
        private string _suggestion = String.Empty;  
        private bool _isOver;  
        private string _operId;  
        private DateTime _operTime;
        private string _itemID;
        private string _testIllustration = String.Empty;
        private string _resultDetermine = String.Empty;
        private string _rAnalysis = String.Empty;
        private string _commonProblem = String.Empty;
  
        public TjSummary()  
        {  
        }  
  
        /// <summary>  
        /// 就诊id
        /// </summary>  
        public string MzRegId  
        {  
            get { return this._mzRegId; }  
            set { this._mzRegId = value; }  
        }  
  
        /// <summary>  
        ///  小结医生ID 
        /// </summary>  
        public string DoctorId  
        {  
            get { return this._doctorId; }  
            set { this._doctorId = value; }  
        }  
  
        /// <summary>  
        ///  体检科室ID 
        /// </summary>  
        public string TjLocationID  
        {  
            get { return this._tjLocationID; }  
            set { this._tjLocationID = value; }  
        }  
  
        /// <summary>  
        ///  小结 
        /// </summary>  
        public string Summary  
        {  
            get { return this._summary; }  
            set { this._summary = value; }  
        }  
  
        /// <summary>  
        ///  建议 
        /// </summary>  
        public string Suggestion  
        {  
            get { return this._suggestion; }  
            set { this._suggestion = value; }  
        }  
  
        /// <summary>  
        ///  是否结束小结 
        /// </summary>  
        public bool IsOver  
        {  
            get { return this._isOver; }  
            set { this._isOver = value; }  
        }  
  
        /// <summary>  
        /// 操作人id
        /// </summary>  
        public string OperId  
        {  
            get { return this._operId; }  
            set { this._operId = value; }  
        }  
  
        /// <summary>  
        ///   操作时间
        /// </summary>  
        public DateTime OperTime  
        {  
            get { return this._operTime; }  
            set { this._operTime = value; }  
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }

        /// <summary>
        /// 科室
        /// </summary>
        public string TjLocationName { get; set; }

        /// <summary>
        /// 医生
        /// </summary>
        public string DoctorName { get; set; }

        /// <summary>
        /// 综合分析
        /// </summary>
        public string CAnalysis { get; set; }

        /// <summary>
        /// 健康结论
        /// </summary>
        public string Conclusion { get; set; }

        /// <summary>
        /// 干预方案
        /// </summary>
        public string Programme { get; set; }

       /// <summary>
        /// 项目id
        /// </summary>
        public string ItemID
        {
            get { return this._itemID; }
            set { this._itemID = value; }  
        }

        /// <summary>  
        ///  检测说明 
        /// </summary>  
        public string TestIllustration
        {
            get { return this._testIllustration; }
            set { this._testIllustration = value; }
        }

        /// <summary>  
        ///  结果判定 
        /// </summary>  
        public string ResultDetermine
        {
            get { return this._resultDetermine; }
            set { this._resultDetermine = value; }
        }

        /// <summary>  
        ///  结果分析 
        /// </summary>  
        public string RAnalysis
        {
            get { return this._rAnalysis; }
            set { this._rAnalysis = value; }
        }

        /// <summary>  
        ///  常见问题 
        /// </summary>  
        public string CommonProblem
        {
            get { return this._commonProblem; }
            set { this._commonProblem = value; }
        }

        /// <summary>
        /// 病人名称
        /// </summary>
        public string PatName { get; set; }

        private bool _isSelected = false;
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { this._isSelected = value; }
        }

        private DateTime _saveTime;
        /// <summary>
        /// 保存时间
        /// </summary>
        public DateTime SaveTime
        {
            get { return _saveTime; }
            set { this._saveTime = value; }
        }
  
    }
}  

