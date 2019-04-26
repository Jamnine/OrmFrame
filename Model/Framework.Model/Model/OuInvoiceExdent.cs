

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票 - 实体类
	/// </summary> 
	public partial class OuInvoice  
	{   
		 
        private double _accountAmount;
        private bool _isTally;


        /// <summary>
        /// 记账金额
        /// </summary>
        public double AccountAmount
        {
            get
            {
                return this._accountAmount;
            }
            set
            {
                this._accountAmount = value;
            }
        }

        /// <summary>
        /// 是否记账
        /// </summary>
        public bool IsTally
        {
            get
            {
                return this._isTally;
            }
            set
            {
                this._isTally = value;
            }
        }

    }
}           


