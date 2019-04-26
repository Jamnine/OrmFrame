#region model

// ===================================================================   
// Model  
// ===================================================================   
// File: GBLBACKUPRESTOREInfo.cs  
//   
// Copyright   
// History:  
// 2015-08-24 17:34:27: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// 备份恢复表
    /// <para>GblBackupRestore Object</para>  
    /// <para>Summary description for GblBackupRestore.</para>  
    /// <para><see cref="member"/></para>  
    /// <remarks></remarks>  
    /// </summary>  
    [Serializable]
    public class GblBackupRestore : BaseModel
    {
        #region Fields
        protected DateTime _operTime;
        protected string _operId;
        protected int _dataSize;
        protected string _operName;
        protected int _lsType;
        #endregion

        #region Contructors
        public GblBackupRestore()
        {
        }

        #endregion

        #region Public Properties


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
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public int DataSize
        {
            get { return _dataSize; }
            set { _dataSize = value; }
        }

        /// <summary>  
        ///   
        /// </summary>  
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }

        /// <summary>  
        ///  备份还原标识：1为备份；2为还原
        /// </summary>  
        public int LsType
        {
            get { return _lsType; }
            set { _lsType = value; }
        }

        #endregion
    }
}
#endregion

