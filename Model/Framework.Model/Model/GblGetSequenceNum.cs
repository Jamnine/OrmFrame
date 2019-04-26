

using System;
namespace Orm.Model
{
	/// <summary>
	/// 记录系统每个模块下一次单据号 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblGetSequenceNum : BaseModel
    {    
		private double _nextSequenceNum;  //下次序列号
		
		private bool _isDayBegin;  //是否每天从YYYYMMDD0001开始
		
		private string _getdateStr;  //字符串日期
		
		private string _nextSequenceStr;  //字符下次序列号
		

        private int _resetType;

        private int _sequenceLen;

        private string _prefix = String.Empty;

        private int _currentValue;

        private string _dateFormat = String.Empty;

        private string _sequenceName = String.Empty;

        /// <summary>
        /// 下次序列号
        /// </summary>
        public double NextSequenceNum
		{
			get { return _nextSequenceNum;}
			set { _nextSequenceNum = value;}
		}                                    
		
		/// <summary>
		/// 是否每天从YYYYMMDD0001开始
		/// </summary>
		public bool IsDayBegin
		{
			get { return _isDayBegin;}
			set { _isDayBegin = value;}
		}                                    
		
		/// <summary>
		/// 字符串日期
		/// </summary>
		public string GetdateStr
		{
			get { return _getdateStr;}
			set { _getdateStr = value;}
		}                                    
		
		/// <summary>
		/// 字符下次序列号
		/// </summary>
		public string NextSequenceStr
		{
			get { return _nextSequenceStr;}
			set { _nextSequenceStr = value;}
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
        /// 流水号长度 如4表示0001这种,6表示000001这种  
        /// </summary>  
        public int SequenceLen
        {
            get { return this._sequenceLen; }
            set { this._sequenceLen = value; }
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
        /// 当前流水号 流水号当前值,如234表示当前的流水号生成到了234,下一个为234+STEP(步长)  
        /// </summary>  
        public int CurrentValue
        {
            get { return this._currentValue; }
            set { this._currentValue = value; }
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
        /// 流水号名称 流水号名称必须唯一  
        /// </summary>  
        public string SequenceName
        {
            get { return this._sequenceName; }
            set { this._sequenceName = value; }
        }
    }  
}           


