// ===================================================================   
// Model  
// ===================================================================   
// File: ToothXRay.cs  
//   
// Copyright   
// History:  
// 2015/7/1 9:57:39: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  电子病历X线表
    /// </summary>  
    [Serializable]  
  
    public partial class ToothXRay : BaseModel  
    {    
        public ToothXRay()  
        {  
        }  
  
  
        /// <summary>  
        /// 病历主表序号  
        /// </summary>  
        public string RecordId
        {
            get;
            set;
        }  
  
        /// <summary>  
        /// X线  
        /// </summary>  
        public string CheckCTXRay
        {
            get;
            set;
        }  
  
        /// <summary>  
        ///   左上
        /// </summary>  
        public string P1
        {
            get;
            set;
        }  
  
        /// <summary>  
        ///   右上
        /// </summary>  
        public string P2
        {
            get;
            set;
        }  
  
        /// <summary>  
        ///   右下
        /// </summary>  
        public string P3
        {
            get;
            set;
        }  
  
        /// <summary>  
        ///   左下
        /// </summary>  
        public string P4
        {
            get;
            set;
        }  
  
        /// <summary>  
        ///   排序
        /// </summary>  
        public int OrderBy
        {
            get;
            set;
        }  
  
    }  
}  

