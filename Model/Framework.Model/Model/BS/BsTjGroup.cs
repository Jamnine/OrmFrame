// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjGroup.cs  
//   
// Copyright   
// History:  
// 2015/12/18 16:54:12: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  体检组合项目
    /// </summary> 
    [Serializable]
    public partial class BsTjGroup : BaseModel
    {
        private string _groupItemCode = String.Empty;
        private string _tjItemCode = String.Empty;
        private int _orderBy;

        public BsTjGroup()
        {
        }


        /// <summary>  
        /// 组合项目编码  
        /// </summary>  
        public string GroupItemCode
        {
            get { return this._groupItemCode; }
            set { this._groupItemCode = value; }
        }

        /// <summary>  
        /// 明细项目编码  
        /// </summary>  
        public string TjItemCode
        {
            get { return this._tjItemCode; }
            set { this._tjItemCode = value; }
        }

        /// <summary>  
        /// 排序
        /// </summary>  
        public int OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }

        private string _itemName;
        /// <summary>  
        ///   项目名称
        /// </summary>  
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

    }
}

