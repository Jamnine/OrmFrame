// ===================================================================   
// Model  
// ===================================================================   
// File: SysSequenceConfig.cs  
//   
// Copyright   
// History:  
// 2015/7/21 16:19:08: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  流水号配置表
    /// </summary>  
    [Serializable]
   
    public partial class SysSequenceConfig : BaseModel
    {
        private string _sequenceName = String.Empty;
        private string _sequenceDesc = String.Empty;
        private int _sequenceLen;
        private int _resetType;
        private string _separator = String.Empty;
        private string _prefix = String.Empty;
        private string _dateFormat = String.Empty;
        private int _currentValue;
        private int _initialValue;
        private int _step;
        private DateTime _createdDate;
        private DateTime _lastUpdatedDate;
        private string _isActive = String.Empty;
        private string _updateControlID = String.Empty;

        public SysSequenceConfig()
        {
        }


        /// <summary>  
        /// 流水号名称 流水号名称必须唯一  
        /// </summary>  
        public string SequenceName
        {
            get { return this._sequenceName; }
            set { this._sequenceName = value; }
        }

        /// <summary>  
        /// 流水号描述 对流水号的说明  
        /// </summary>  
        public string SequenceDesc
        {
            get { return this._sequenceDesc; }
            set { this._sequenceDesc = value; }
        }

        /// <summary>  
        /// 流水号长度 如4表示0001这种,6表示000001这种  
        /// </summary>  
        public int SequenceLen
        {
            get { return this._sequenceLen; }
            set { this._sequenceLen = value; }
        }

        /// <summary>  
        /// 重置类型 0不重置,1按年,2按月,3按日  
        /// </summary>  
        public int ResetType
        {
            get { return this._resetType; }
            set { this._resetType = value; }
        }

        /// <summary>  
        /// 分隔符 分隔流水号各部分的连接符,如-,则生成的流水号为 前缀-日期-流水号形式,如果为空,则各部分没有连接符号  
        /// </summary>  
        public string Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        /// <summary>  
        /// 前缀  
        /// </summary>  
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        /// <summary>  
        /// 日期格式 日期格式格式可以是yyyy yy mm dd hh ii ss的组合,如yyyymm,yy-mm,yyyymmdd,yyyymmdd-hh等,如果按年重置,则日期格式中必须有年,如果按月重置,则日期格式中必须有月.如果不重置,则日期格式不限定,甚至可以为空  
        /// </summary>  
        public string DateFormat
        {
            get { return this._dateFormat; }
            set { this._dateFormat = value; }
        }

        /// <summary>  
        /// 当前流水号 流水号当前值,如234表示当前的流水号生成到了234,下一个为234+STEP(步长)  
        /// </summary>  
        public int CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
        }

        /// <summary>  
        /// 初始值 初始流水号是多少,默认是0  
        /// </summary>  
        public int InitialValue
        {
            get { return this._initialValue; }
            set { this._initialValue = value; }
        }

        /// <summary>  
        ///   当前流水号 流水号当前值,如234表示当前的流水号生成到了234,下一个为234+STEP(步长)
        /// </summary>  
        public int Step
        {
            get { return this._step; }
            set { this._step = value; }
        }

        /// <summary>  
        /// 创建时间  
        /// </summary>  
        public DateTime CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        /// <summary>  
        /// 最后更新时间  
        /// </summary>  
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        /// <summary>  
        ///   是否可用
        /// </summary>  
        public string IsActive
        {
            get { return this._isActive; }
            set { this._isActive = value; }
        }

        /// <summary>  
        /// 并发控制字段  
        /// </summary>  
        public string UpdateControlID
        {
            get { return this._updateControlID; }
            set { this._updateControlID = value; }
        }

 

    }
}

