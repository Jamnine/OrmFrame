

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary> 
	public partial class VipReckoningCharge 
	{
        private string _itemName;
        private double _price;  
        private int _currentAddCount;
        private int _LeftCount;
        
        /// <summary>  
        ///  项目Name
        /// </summary>  
        public string ItemName
        {
            get { return this._itemName; }
            set { this._itemName = value; }
        }

        /// <summary>  
        ///  项目Price
        /// </summary>  
        public double Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        /// <summary>
        /// 当前添加数
        /// </summary> 
        public int CurrentAddCount
        {
            get { return this._currentAddCount; }
            set { this._currentAddCount = value; }
        }
        /// <summary>
        /// 剩余次数
        /// </summary> 

        public int LeftCount
        {
            get { return this._LeftCount; }
            set { this._LeftCount = value; }
        }


    }
}           


