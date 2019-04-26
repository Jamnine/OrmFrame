// ===================================================================   
// Model  
// ===================================================================   
// File: TjSuggestion.cs  
//   
// Copyright   
// History:  
// 2015/12/21 15:04:06: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    /// 体检诊断建议  数据库不存在此表
    /// </summary> 
    [Serializable]  
    
    public partial class TjSuggestion : BaseModel  
    {  
        private string _name = String.Empty;  
        private string _diseaseCode = String.Empty;  
        private string _testTypeId;  
        private string _suggestion = String.Empty;  
        private string _flag = "0";  
        private bool _isCommonDisease;  
        private bool _isImportantDisease;  
        private bool _isNotify;  
        private string _pyCode = String.Empty;  
        private string _wbCode = String.Empty;  
        private DateTime _modiTime = DateTime.MinValue;  
        private string _modiOperId;  
        private int _orderBy;  
        private bool _isActive=true;
        private string _complaint = String.Empty;
        private string _presentHistory = String.Empty;
  
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public TjSuggestion()  
        {  
        }  
  
  
        /// <summary>  
        ///   诊断建议名称
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }  
  
        /// <summary>  
        /// 疾病编码  
        /// </summary>  
        public string DiseaseCode  
        {  
            get { return this._diseaseCode; }  
            set { this._diseaseCode = value; }  
        }  
  
        /// <summary>  
        ///  类别ID 
        /// </summary>  
        public string TestTypeId  
        {  
            get { return this._testTypeId; }  
            set { this._testTypeId = value; }  
        }  
  
        /// <summary>  
        /// 建议内容  
        /// </summary>  
        public string Suggestion  
        {  
            get { return this._suggestion; }  
            set { this._suggestion = value; }  
        }  
  
        /// <summary>  
        /// 是否疾病：1 疾病 2异常 3提示 9其他  
        /// </summary>  
        public string Flag  
        {  
            get { return this._flag; }  
            set { this._flag = value; }  
        }  
  
        /// <summary>  
        /// 是否常见疾病  
        /// </summary>  
        public bool IsCommonDisease  
        {  
            get { return this._isCommonDisease; }  
            set { this._isCommonDisease = value; }  
        }  
  
        /// <summary>  
        /// 是否重大疾病  
        /// </summary>  
        public bool IsImportantDisease  
        {  
            get { return this._isImportantDisease; }  
            set { this._isImportantDisease = value; }  
        }  
  
        /// <summary>  
        /// 是否通知  
        /// </summary>  
        public bool IsNotify  
        {  
            get { return this._isNotify; }  
            set { this._isNotify = value; }  
        }  
  
        /// <summary>  
        ///   拼音
        /// </summary>  
        public string PyCode  
        {  
            get { return this._pyCode; }  
            set { this._pyCode = value; }  
        }  
  
        /// <summary>  
        ///   五笔码
        /// </summary>  
        public string WbCode  
        {  
            get { return this._wbCode; }  
            set { this._wbCode = value; }  
        }  
  
        /// <summary>  
        ///   最后修改时间
        /// </summary>  
        public DateTime ModiTime  
        {  
            get { return this._modiTime; }  
            set { this._modiTime = value; }  
        }  
  
        /// <summary>  
        ///   最后修改人ID
        /// </summary>  
        public string ModiOperId  
        {  
            get { return this._modiOperId; }  
            set { this._modiOperId = value; }  
        }  
  
        /// <summary>  
        ///   显示顺序
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }  
  
        /// <summary>  
        ///   是否可用
        /// </summary>  
        public bool IsActive  
        {  
            get { return this._isActive; }  
            set { this._isActive = value; }  
        }
        
        /// <summary>  
        /// 主诉  
        /// </summary>  
        public string Complaint
        {
            get { return this._complaint; }
            set { this._complaint = value; }
        }

        /// <summary>  
        /// 现病史  
        /// </summary>  
        public string PresentHistory
        {
            get { return this._presentHistory; }
            set { this._presentHistory = value; }
        }

        /// <summary>
        /// 疾病ID
        /// </summary>
        public string ClassId { get; set; }
    }  
}  

