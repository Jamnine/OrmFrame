

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class TrScheduler:BaseModel
	{    
		private string _userId;  //用户名
		
		private string _lineId;  //用户名
		
		private DateTime _scheTime;  //排班日期
		
		private DateTime _operTime;  //登记时间
		
		private string _operId;  //登记人
		
		private int _iconIndex;  //图标类型
		
		private int _HospitalID;  // 

        private int _remind;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserId
		{
			get { return _userId;}
			set { _userId = value;}
		}                                    
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string LineId
		{
			get { return _lineId;}
			set { _lineId = value;}
		}                                    
		
		/// <summary>
		/// 排班日期
		/// </summary>
		public DateTime ScheTime
		{
			get { return _scheTime;}
			set { _scheTime = value;}
		}                                    
		
		/// <summary>
		/// 登记时间
		/// </summary>
		public DateTime OperTime
		{
			get { return _operTime;}
			set { _operTime = value;}
		}                                    
		
		/// <summary>
		/// 登记人
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		

        /// <summary>
        /// 提醒次数
        /// </summary>	


        public int Remind
        {
            get { return _remind; }
            set { _remind = value; }
        }
    }  
}           


