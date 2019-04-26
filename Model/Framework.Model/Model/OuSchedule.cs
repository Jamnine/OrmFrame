

using System;
namespace Orm.Model
{
	/// <summary>
	/// 行心云:病人日常事务表 - 实体类
	/// </summary>
	[Serializable]
	public partial class OuSchedule : BaseModel
	{   
		
		
		private string _patID;  //病人ID
		
		private string _mzRegID;  //门诊ID
		
		private string _itemID;  //项目ID
		
		private string _recipeDtlID;  //处方明细ID
		
		private DateTime _startTime;  //开始时间
		
		private DateTime _endTime;  //结束时间
		
		private string _affairs;  //事务
		
		private bool _isAttach;  //是否完成
		
		private string _operID;  //操作人
		
		private int _HospitalID;  //

        private DateTime _operTime;//操作时间

        /// <summary>
        /// 操作时间
        /// </summary>
		public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }

		/// <summary>
		/// 病人ID
		/// </summary>
		public string PatID
		{
			get { return _patID;}
			set { _patID = value;}
		}                                    
		
		/// <summary>
		/// 门诊ID
		/// </summary>
		public string MzRegID
		{
			get { return _mzRegID;}
			set { _mzRegID = value;}
		}                                    
		
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemID
		{
			get { return _itemID;}
			set { _itemID = value;}
		}                                    
		
		/// <summary>
		/// 处方明细ID
		/// </summary>
		public string RecipeDtlID
		{
			get { return _recipeDtlID;}
			set { _recipeDtlID = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime StartTime
		{
			get { return _startTime;}
			set { _startTime = value;}
		}                                    
		
		/// <summary>
		/// 结束时间
		/// </summary>
		public DateTime EndTime
		{
			get { return _endTime;}
			set { _endTime = value;}
		}                                    
		
		/// <summary>
		/// 事务
		/// </summary>
		public string Affairs
		{
			get { return _affairs;}
			set { _affairs = value;}
		}                                    
		
		/// <summary>
		/// 是否完成
		/// </summary>
		public bool IsAttach
		{
			get { return _isAttach;}
			set { _isAttach = value;}
		}                                    
		
		/// <summary>
		/// 操作人
		/// </summary>
		public string OperID
		{
			get { return _operID;}
			set { _operID = value;}
		}                                    
		    
	}  
}           


