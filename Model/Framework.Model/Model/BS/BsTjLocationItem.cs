// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjLocationItem.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:04:44: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  体检科室对应项目
    /// </summary> 
    [Serializable]
    public partial class BsTjLocationItem : BaseModel
    {
        private string _tjLocationID;
        private string _tjItemCode = String.Empty;
        private int _orderBy;

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public BsTjLocationItem()
        {
        }


        /// <summary>  
        /// 体检科室ID  
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
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
        ///   排序字段
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

    }
}

