// ===================================================================   
// Model  
// ===================================================================   
// File: TjPackageDtl.cs  
//   
// Copyright   
// History:  
// 2015/12/25 18:56:41: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{  
    [Serializable]
    /// <summary>  
    ///   数据库不存在此表
    /// </summary>  
    public partial class TjPackageDtl : BaseModel  
    {  
        private string _tjPackageID;  
        private string _tjItemCode = String.Empty;  
        private int _orderBy;  
  
        public TjPackageDtl()  
        {  
        }  
  
  
        /// <summary>  
        /// 套餐ID  
        /// </summary>  
        public string TjPackageID  
        {  
            get { return this._tjPackageID; }  
            set { this._tjPackageID = value; }  
        }  
  
        /// <summary>  
        /// 体检项目编码  
        /// </summary>  
        public string TjItemCode  
        {  
            get { return this._tjItemCode; }  
            set { this._tjItemCode = value; }  
        }  
  
        /// <summary>  
        ///   
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }  
  
    }  
}  

