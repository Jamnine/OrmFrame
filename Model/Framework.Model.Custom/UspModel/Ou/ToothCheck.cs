// ===================================================================   
// Model  
// ===================================================================   
// File: ToothCheck.cs  
//   
// Copyright   
// History:  
// 2015/7/1 9:54:00: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  电子病历检查表
    /// </summary>  
    [Serializable]  
   
    public partial class ToothCheck : BaseModel  
    {  

        public ToothCheck()  
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
        /// 检查  
        /// </summary>  
        public string CheckCT
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
        ///   显示序号
        /// </summary>  
        public int OrderBy
        {
            get;
            set;
        }  
  
    }  
}  

