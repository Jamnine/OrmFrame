

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验项目范围 - 实体类
	/// </summary>
	[Serializable]
    public partial class CkItemRange : BaseModel
	{   
		 
		private string _testId = string.Empty;  //检验项目ID,对应CkItem.Id
		
		private string _sex = string.Empty;  //性别
		
		private int _ageFrom;  //年龄下限
		
		private int _ageTo;  //年龄上限
		
		private double _lowValue;  //正常低值
		
		private double _highValue;  //正常高值
		
		private double _panicLow;  //危险低值
		
		private double _panicHigh;  //危险高值
		
		private string _printResult = " ";  //当结果处于这个范围时打印什么
		
		private string _textRange = string.Empty;  //文本型范围
		
		private int _lsAgeUnit;  //年龄单位：1-年；2-月
		
		private string _machineId = string.Empty;  //指定仪器
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //
		
		private string _tjItemCode = string.Empty;  //
		 
         
		/// <summary>
		/// 检验项目ID,对应CkItem.Id
		/// </summary>
		public string TestId
		{
			get { return _testId;}
			set { _testId = value;}
		}                                    
		
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			get { return _sex;}
			set { _sex = value;}
		}                                    
		
		/// <summary>
		/// 年龄下限
		/// </summary>
		public int AgeFrom
		{
			get { return _ageFrom;}
			set { _ageFrom = value;}
		}                                    
		
		/// <summary>
		/// 年龄上限
		/// </summary>
		public int AgeTo
		{
			get { return _ageTo;}
			set { _ageTo = value;}
		}                                    
		
		/// <summary>
		/// 正常低值
		/// </summary>
		public double LowValue
		{
			get { return _lowValue;}
			set { _lowValue = value;}
		}                                    
		
		/// <summary>
		/// 正常高值
		/// </summary>
		public double HighValue
		{
			get { return _highValue;}
			set { _highValue = value;}
		}                                    
		
		/// <summary>
		/// 危险低值
		/// </summary>
		public double PanicLow
		{
			get { return _panicLow;}
			set { _panicLow = value;}
		}                                    
		
		/// <summary>
		/// 危险高值
		/// </summary>
		public double PanicHigh
		{
			get { return _panicHigh;}
			set { _panicHigh = value;}
		}                                    
		
		/// <summary>
		/// 当结果处于这个范围时打印什么
		/// </summary>
		public string PrintResult
		{
			get { return _printResult;}
			set { _printResult = value;}
		}                                    
		
		/// <summary>
		/// 文本型范围
		/// </summary>
		public string TextRange
		{
			get { return _textRange;}
			set { _textRange = value;}
		}                                    
		
		/// <summary>
		/// 年龄单位：1-年；2-月
		/// </summary>
		public int LsAgeUnit
		{
			get { return _lsAgeUnit;}
			set { _lsAgeUnit = value;}
		}                                    
		
		/// <summary>
		/// 指定仪器
		/// </summary>
		public string MachineId
		{
			get { return _machineId;}
			set { _machineId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
		}                                    
		
          
		public string TjItemCode
        {
			get { return _tjItemCode; }
			set { _tjItemCode = value;}
		}
        
        private int _decimalDigits;
        /// <summary>
        /// 保留小数位数
        /// </summary>
        public int DecimalDigits
        {
            get { return _decimalDigits; }
            set { _decimalDigits = value; }
        }

        private string _referenceString; 
        /// <summary>
        /// 
        /// </summary>
        public string ReferenceString
        {
            get { return _referenceString; }
            set { _referenceString = value; }
        }

        private string _referenExplain;
        /// <summary>
        /// 
        /// </summary>
        public string ReferenExplain
        {
            get { return _referenExplain; }
            set { _referenExplain = value; }
        }

        private double _veryLowLimit; 
        public double VeryLowLimit
        {
            get { return _veryLowLimit; }
            set { _veryLowLimit = value; }
        }

        private double _veryTopLimit;
        public double VeryTopLimit
        {
            get { return _veryTopLimit; }
            set { _veryTopLimit = value; }
        }

    }  
}           


