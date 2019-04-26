

using System;
namespace Orm.Model
{
    /// <summary>
    /// 减号套餐主表 - 实体类
    /// </summary>

    public partial class BsXdRp
    {
        private bool _iSShowTimeS;
        private string _upCode;
        private string _userID;
        private string _yBCode;

        /// <summary>
        /// F4是否套餐次数显示.
        /// </summary>
        public bool ISShowTimeS
        {
            get
            {
                return this._iSShowTimeS;
            }
            set
            {
                this._iSShowTimeS = value;
            }
        }

        /// <summary>
        /// 上报码.
        /// </summary>
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode = value;
            }
        }

        /// <summary>
        /// 所属医生ID
        /// </summary>
        public string UserID
        {
            get { return this._userID; }
            set { this._userID = value; }
        }

        public double VIPAmount { get; set; }

        /// <summary>
        /// 医保码.
        /// </summary>
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode = value;
            }
        }

    }
}           


