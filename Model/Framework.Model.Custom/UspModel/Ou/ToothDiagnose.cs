// ===================================================================   
// Model  
// ===================================================================   
// File: ToothDiagnose.cs  
//   
// Copyright   
// History:  
// 2015/7/1 9:55:26: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  电子病历诊断表
    /// </summary> 
    [Serializable]  
    
    public partial class ToothDiagnose : BaseModel  
    {    
        public ToothDiagnose()  
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
        /// 诊断  
        /// </summary>  
        public string Diagnose
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
        ///   排序编号
        /// </summary>  
        public int OrderBy
        {
            get;
            set;
        }  
  
    }  
}  

