

using System;
namespace Orm.Model
{
	/// <summary>
	/// 药房对应窗口 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsRoomWindow:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _roomId;  //药房ID,BsRoom.Id
		
		private string _wbCode;  //五笔码
		
		private string _pyCode;  //拼音码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private string _memo;  //窗口号描述
		
		private int _windowType;  //窗口类别
		
		private int _HospitalID;  //
		  
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 药房ID,BsRoom.Id
		/// </summary>
		public string RoomId
		{
			get { return _roomId;}
			set { _roomId = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 窗口号描述
		/// </summary>
		public string memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 窗口类别
		/// </summary>
		public int WindowType
		{
			get { return _windowType;}
			set { _windowType = value;}
		}                                    
		
	

        private int hisType;

        /// <summary>
        /// 系统类型
        /// </summary>
        public int HisType
        {
            get
            {
                return this.hisType;
            }

            set
            {
                this.hisType = value;
            }
        }

        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return insertTime;
            }

            set
            {
                insertTime = value;
            }
        }

        private DateTime insertTime;
    }  
}           


