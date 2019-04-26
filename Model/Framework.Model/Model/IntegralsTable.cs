

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:积分使用记录表 - 实体类
	/// </summary>
	[Serializable]
	public partial class IntegralsTable : BaseModel
	{   
		
		private string _patId;  //病人ID

        private double _integral;  

        private double _totalinTegral;  //总积分
		
		private double _outinTegral;  //消耗积分
		
		private bool _lsState;  //状态  1、正常2、已用
		
		private string _operId;  //操作员ID
		
		private DateTime _operTime;  //操作时间
		
		private string _memo;  //备注
		
		private int _HospitalID;  //
		 

		
		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatId
		{
			get { return  _patId;}
			set {  _patId = value;}
		}
        
        /// <summary>
        /// 总积分
        /// </summary>
        public double Integral
        {
            get { return _integral; }
            set { _integral = value; }
        }

        /// <summary>
        /// 总积分
        /// </summary>
        public double TotalIntegral
        {
			get { return _totalinTegral;}
			set { _totalinTegral = value;}
		}                                    
		
		/// <summary>
		/// 消耗积分
		/// </summary>
		public double OutIntegral
        {
			get { return _outinTegral;}
			set { _outinTegral = value;}
		}

        /// <summary>
        /// 状态  1、正常2、已用  true 正常   fales已用
        /// </summary>
        public bool LsState
		{
			get { return _lsState;}
			set { _lsState = value;}
		}                                    
		
		/// <summary>
		/// 操作员ID
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 操作时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		                                  
		        
	}  
}           


