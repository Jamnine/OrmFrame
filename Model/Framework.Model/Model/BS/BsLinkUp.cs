// ===================================================================   
// Model  
// ===================================================================   
// File: BsLinkUp.cs  
//   
// Copyright   
// History:  
// 2015/3/30 9:04:44: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  
    /// </summary>
    [Serializable]  
      
    public partial class BsLinkUp : BaseModel  
    {  
        private string _title = String.Empty;  
        private string _parentID;  
        private string _fileAddress = String.Empty;  
        private int _lsType;  
        private int _lsOperType;  
        private string _memo = String.Empty;  
        private string _operId;  
        private DateTime _operTime;  
        private bool _isActive;
        private bool _isCommon;
  
        public BsLinkUp()  
        {  
        }  
  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Title  
        {  
            get { return this._title; }  
            set { this._title = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string ParentID  
        {  
            get { return this._parentID; }  
            set { this._parentID = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string FileAddress  
        {  
            get { return this._fileAddress; }  
            set { this._fileAddress = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsType  
        {  
            get { return this._lsType; }  
            set { this._lsType = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int LsOperType  
        {  
            get { return this._lsOperType; }  
            set { this._lsOperType = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string Memo  
        {  
            get { return this._memo; }  
            set { this._memo = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public string OperId  
        {  
            get { return this._operId; }  
            set { this._operId = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public DateTime OperTime  
        {  
            get { return this._operTime; }  
            set { this._operTime = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public bool IsActive  
        {  
            get { return this._isActive; }  
            set { this._isActive = value; }  
        }
        public bool IsCommon
        {
            get { return this._isCommon; }
            set{
                this._isCommon = value;
            }
        }
  
    }  
}  

