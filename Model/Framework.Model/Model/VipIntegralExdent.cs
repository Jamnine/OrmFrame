

using System;
namespace Orm.Model
{
	/// <summary>
	/// 会员积分表 - 实体类
	/// </summary> 
	public partial class VipIntegral :BaseModel
	{

        private string _operStatusName;
        private string _operName;


        /// <summary>
        /// 操作状态名称
        /// </summary>

        public string OperStatusName
        {
            get { return this._operStatusName; }
            set { this._operStatusName = value; }
        }

        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OperName
        {
            get { return this._operName; }
            set { this._operName = value; }
        }
    }  
}           


