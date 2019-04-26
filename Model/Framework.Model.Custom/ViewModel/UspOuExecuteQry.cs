using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom
{
    /// <summary>
    /// 护士执行单组合处理类
    /// </summary>
    [Serializable]
    public class UspOuExecuteQry
    {
        
        /// <summary>
        /// OuExecute.GUID（执行单ID）
        /// </summary>
        public string GUID { get; set; }

        /// <summary>
        /// OuHosInfo.GUID（门诊挂号ID）
        /// </summary>
        public string MzRegId { get; set; }

        /// <summary>
        /// OuRecipeDtl.GUID（处方明细ID）
        /// </summary>
        public string RecipeDtlId { get; set; }

        /// <summary>
        /// BsItem.GUID（项目ID）
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 组号
        /// </summary>
        public int GroupNum { get; set; }

        private bool _isSkinTest = false;
        /// <summary>
        /// 是否皮试
        /// </summary>
        public bool IsSkinTest
        {
            get { return this._isSkinTest; }
            set { this._isSkinTest = value; }
        }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 第几天
        /// </summary>
        public int NDay { get; set; }

        /// <summary>
        /// 第几次
        /// </summary>
        public int NTime { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec { get; set; }

        /// <summary>
        /// 次用量
        /// </summary>
        public double Dosage { get; set; }

        /// <summary>
        /// 用量单位
        /// </summary>
        public string UnitTake { get; set; }

        /// <summary>
        /// 用法
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// 频率
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// 滴速
        /// </summary>
        public string DripRates { get; set; }

        private string _result = string.Empty;
        /// <summary>
        /// 结果
        /// </summary>
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }
        private string _oldResult = string.Empty;
        /// <summary>
        /// 护士执行结果
        /// </summary>
        public string OldResult
        {
            get { return _oldResult; }
            set { _oldResult = value; }
        }
        private string _memo = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        private int _status = 0;
        /// <summary>
        /// 状态 0 未发药 1 已发药 2 退药 3 已执行
        /// </summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// 是否执行
        /// </summary>
        private bool _isExecuted;
        public bool IsExecuted
        {
            get { return this._isExecuted; }
            set { this._isExecuted = value; }
        }
        private DateTime _operTime = DateTime.MinValue;
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        private string _drugFormName = String.Empty;
        /// <summary>
        /// 剂型
        /// </summary>
        public string DrugFormName
        {
            get { return this._drugFormName; }
            set { this._drugFormName = value; }
        }
        private bool _isPrint = false;
        /// <summary>
        /// 是否打印瓶签
        /// </summary>
        public bool IsPrint
        {
            get { return this._isPrint; }
            set { this._isPrint = value; }
        }
    }
}
