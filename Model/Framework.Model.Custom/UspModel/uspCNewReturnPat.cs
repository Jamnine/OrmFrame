using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    [Serializable]
    public class uspCNewReturnPat ///初诊复诊收入统计
    {
        private DateTime _OperTime;
        private int _Positive;
        private int _Return;
        private double _Amount;
        private bool _isReturn;
        private string _locationId;
        private string _locationName = String.Empty;
        public uspCNewReturnPat() { }

        public string LocationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }
        /// <summary>
        /// 科室
        /// </summary>
        public string LocationName
        {
            get
            {
                return this._locationName;
            }
            set
            {
                this._locationName = value;
            }
        }
        public bool IsReturn
        {
            get
            {
                return this._isReturn;
            }
            set
            {
                this._isReturn = value;
            }
        }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return this._OperTime;
            }
            set
            {
                this._OperTime = value;
            }
        }
        /// <summary>
        /// 初诊
        /// </summary>
        public int Positive
        {
            get
            {
                return this._Positive;
            }
            set
            {
                this._Positive = value;
            }
        }
        /// <summary>
        /// 复诊
        /// </summary>
        public int Return
        {
            get
            {
                return this._Return;
            }
            set
            {
                this._Return = value;
            }
        }
        /// <summary>
        /// 金额
        /// </summary>
        public double Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this._Amount = value;
            }

        }
        private bool _isHideIllness;
        /// <summary>
        /// 是否特殊患者
        /// </summary>
        public bool IsHideIllness
        {
            get { return _isHideIllness; }
            set { _isHideIllness = value; }
        }

    }
}
