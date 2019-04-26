

using System;
namespace Orm.Model
{
	/// <summary>
	/// 门诊收费发票明细 - 实体类
	/// </summary> 
	public partial class OuInvoiceDtl
	{

        private double _howMany;  //发票ID
        private string _tjLocationID;
        private DateTime _inputTime;
        private double _oldPriceDiag;

        /// <summary>
        /// 
        /// </summary>
        public double HowMany
        {
			get { return _howMany; }
			set { _howMany = value;}
		}


        /// <summary>  
        ///  体检科室
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }

        /// <summary>
        /// F1录入时间.
        /// </summary>
        public DateTime InputTime
        {
            get
            {
                return this._inputTime;
            }
            set
            {
                this._inputTime = value;
            }
        }

        /// <summary>
        /// 门诊价格
        /// </summary>
        public double OldPriceDiag
        {
            get
            {
                return this._oldPriceDiag;
            }
            set
            {
                this._oldPriceDiag = value;
            }
        }
    }  
}           


