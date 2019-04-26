using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    /// <summary>  
    /// 体检记录结果
    /// </summary>  
    [Serializable]
    public partial class CkLabResult : BaseModel
    {
        private string _labid;
        private string _testid;
        private string _lastResult = String.Empty;

        private string _result;
        private string _unit;
        private int _lsrefflag;
        private bool _ispanic;
        private bool _isdalta;
        private int _dalabsolute;
        private int _dalpercent;
        private double _lowvalue;
        private double _highvalue;
        private double _paniclow;
        private double _panichigh;
        private bool _ispass;

        private bool _isreport;
        private string _memo;
        private DateTime _operTime;
        private string _operId;
        private bool _isprint;
        private DateTime _printtime;
        private string _printoperid;
        private string _textrange;
        private string _deviate;
        private string _authdocname;
        private DateTime _authdoctime;
        private string _checkno;
        private string _itemname;
        private bool _isauthed;
        private int _hospitalId;

        private string _commentary;  //行心云：评论

        private string _commonProblem;  //行心云：常见问题

        private string _abnormalTips;  //行心云：异常提示

        private string _testIllustration;  //行心云：检测说明

        private bool _isGroup;  //行心云：是否组合

        private string _properties;  //行心云：样本性状

        private string _groupItemCode;  //行心云：组合项目编码

        private int _itemTerface;  //行心云：项目接口
        /// <summary>
        /// 体检记录结果
        /// </summary>
        public CkLabResult() { }

        /// <summary>  
        /// 体检指引单号
        /// </summary>  
        public string Labid
        {
            get { return _labid; }
            set { _labid = value; }
        }

        private string _doctorid;
        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorId
        {
            get { return _doctorid; }
            set { _doctorid = value; }
        }



        /// <summary>  
        ///  检验项目ID,对应CkItem.Id
        /// </summary>  
        public string Testid
        {
            get { return this._testid; }
            set { this._testid = value; }
        }

        /// <summary>  
        /// 上次检查结果 失控结果
        /// </summary>  
        public string LastResult
        {
            get { return this._lastResult; }
            set { this._lastResult = value; }
        }

        
        /// <summary>  
        /// 检查结果
        /// </summary>  
        public string Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        /// <summary>  
        /// 单位
        /// </summary>  
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        /// <summary>  
        /// 超标标志：1-高；2-低
        /// </summary>  
        public int LsrefFlag
        {
            get { return this._lsrefflag; }
            set { this._lsrefflag = value; }
        }

        /// <summary>  
        /// 危险标志
        /// </summary>  
        public bool IsPanic
        {
            get { return this._ispanic; }
            set { this._ispanic = value; }
        }

        /// <summary>  
        /// 上次对比超标标志
        /// </summary>  
        public bool IsDalta
        {
            get { return this._isdalta; }
            set { this._isdalta = value; }
        }

        /// <summary>  
        /// 上次对比正常范围（绝对值）
        /// </summary>  
        public int DalabSolute
        {
            get { return this._dalabsolute; }
            set { this._dalabsolute = value; }
        }

        /// <summary>  
        /// 上次对比正常范围（百分比）
        /// </summary>  
        public int DalPercent
        {
            get { return this._dalpercent; }
            set { this._dalpercent = value; }
        }

        /// <summary>  
        /// 正常低值
        /// </summary>  
        public double LowValue
        {
            get { return this._lowvalue; }
            set { this._lowvalue = value; }
        }


        /// <summary>  
        /// 正常高值
        /// </summary>  
        public double HighValue
        {
            get { return this._highvalue; }
            set { this._highvalue = value; }
        }

        /// <summary>  
        /// 危险低值
        /// </summary>  
        public double Paniclow
        {
            get { return this._paniclow; }
            set { this._paniclow = value; }
        }

        /// <summary>  
        /// 危险高值
        /// </summary>  
        public double PanicHigh
        {
            get { return this._panichigh; }
            set { this._panichigh = value; }
        }


        /// <summary>  
        /// 是否合格
        /// </summary>  
        public bool IsPass
        {
            get { return this._ispass; }
            set { this._ispass = value; }
        }

        /// <summary>  
        /// 是否需要打印报告
        /// </summary>  
        public bool IsReport
        {
            get { return this._isreport; }
            set { this._isreport = value; }
        }

        /// <summary>  
        /// 报告备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>  
        /// 检查时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        /// 检查人
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 是否已打印
        /// </summary>  
        public bool Isprint
        {
            get { return this._isprint; }
            set { this._isprint = value; }
        }

        /// <summary>  
        /// 打印时间
        /// </summary>  
        public DateTime PrintTime
        {
            get { return this._printtime; }
            set { this._printtime = value; }
        }

        /// <summary>  
        /// 打印人，BsUser.Id
        /// </summary>  
        public string PrintOperid
        {
            get { return this._printoperid; }
            set { this._printoperid = value; }
        }

        /// <summary>  
        /// 文本型的范围
        /// </summary>  
        public string TextRange
        {
            get { return this._textrange; }
            set { this._textrange = value; }
        }

        /// <summary>  
        /// 偏高偏低
        /// </summary>  
        public string Deviate
        {
            get { return this._deviate; }
            set { this._deviate = value; }
        }

        /// <summary>  
        /// 审核医生
        /// </summary>  
        public string AuthDocname
        {
            get { return this._authdocname; }
            set { this._authdocname = value; }
        }

        /// <summary>  
        /// 审核时间
        /// </summary>  
        public DateTime AuthDocTime
        {
            get { return this._authdoctime; }
            set { this._authdoctime = value; }
        }

        /// <summary>  
        /// 单号
        /// </summary>  
        public string CheckNo
        {
            get { return this._checkno; }
            set { this._checkno = value; }
        }

        /// <summary>  
        /// 项目名称
        /// </summary>  
        public string Itemname
        {
            get { return this._itemname; }
            set { this._itemname = value; }
        }


        /// <summary>  
        /// 已经封存，不可改删
        /// </summary>  
        public bool IsAuthed
        {
            get { return this._isauthed; }
            set { this._isauthed = value; }
        }

        /// <summary>
        /// 行心云：评论
        /// </summary>
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }

        /// <summary>
        /// 行心云：常见问题
        /// </summary>
        public string CommonProblem
        {
            get { return _commonProblem; }
            set { _commonProblem = value; }
        }

        /// <summary>
        /// 行心云：异常提示
        /// </summary>
        public string AbnormalTips
        {
            get { return _abnormalTips; }
            set { _abnormalTips = value; }
        }

        /// <summary>
        /// 行心云：检测说明
        /// </summary>
        public string TestIllustration
        {
            get { return _testIllustration; }
            set { _testIllustration = value; }
        }

        /// <summary>
        /// 行心云：是否组合
        /// </summary>
        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }

        /// <summary>
        /// 行心云：样本性状
        /// </summary>
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        /// <summary>
        /// 行心云：组合项目编码
        /// </summary>
        public string GroupItemCode
        {
            get { return _groupItemCode; }
            set { _groupItemCode = value; }
        }

        /// <summary>
        /// 行心云：项目接口
        /// </summary>
        public int ItemTerface
        {
            get { return _itemTerface; }
            set { _itemTerface = value; }
        }

        public string MzRegId { get; set; }

        /// <summary>
        /// 病人姓名
        /// </summary>
        public string PatName { get; set; }

        public string ReferRange;
    }
}

