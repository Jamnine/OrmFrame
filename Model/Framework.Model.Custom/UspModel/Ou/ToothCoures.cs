// ===================================================================   
// Model  
// ===================================================================   
// File: ToothCoures.cs  
//   
// Copyright   
// History:  
// 2015/7/1 9:54:50: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  电子病历治疗过程表
    /// </summary>  
    [Serializable]  
    
    public partial class ToothCoures : BaseModel  
    {    
        public ToothCoures()  
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
        /// 治疗过程  
        /// </summary>  
        public string Coures
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
        ///   
        /// </summary>  
        public int OrderBy
        {
            get;
            set;
        }  
  
    }  
}  

