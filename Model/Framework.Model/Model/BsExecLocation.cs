

using System;
namespace Orm.Model
{
	/// <summary>
	/// 执行科室指引 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsExecLocation   : BaseModel
    {   
		
		
		private string _locationId;  //科室
		
		private string _itemId;  //项目
		
		private string _timeBegin;  //开始时间
		
		private string _timeEnd;  //截止时间
		
		private string _execPoint;  //诊疗地点
		
		private string _memo;  //备注
		
		private int _iconIndex;  //图标类型
		
		private string _invInItemName;  //收费类别

        private int _HospitalID;  //


        /// <summary>
        /// 科室
        /// </summary>
        public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public string TimeBegin
		{
			get { return _timeBegin;}
			set { _timeBegin = value;}
		}                                    
		
		/// <summary>
		/// 截止时间
		/// </summary>
		public string TimeEnd
		{
			get { return _timeEnd;}
			set { _timeEnd = value;}
		}                                    
		
		/// <summary>
		/// 诊疗地点
		/// </summary>
		public string ExecPoint
		{
			get { return _execPoint;}
			set { _execPoint = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
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
		/// 收费类别
		/// </summary>
		public string InvInItemName
		{
			get { return _invInItemName;}
			set { _invInItemName = value;}
		}

        /// <summary>
        /// 
        /// </summary>
        public int HospitalID
        {
            get { return _HospitalID; }
            set { _HospitalID = value; }
        }
    }  
}           


