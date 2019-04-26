

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应医保码 - 实体类
	/// </summary> 
	public partial class BsItemYb  
	{
        private string _tallyGroupName;
        private int  _yBType ;

        /// <summary>
        /// 医保种类.
        /// </summary>
        public string TallyGroupName
        {
            get
            {
                return this._tallyGroupName;
            }
            set
            {
                this._tallyGroupName = value;
            }
        }

        /// <summary>
        /// F1医保类别.
        /// </summary>
        public int YBType
        {
            get
            {
                return this._yBType;
            }
            set
            {
                this._yBType = value;
            }
        }
    }
}           


