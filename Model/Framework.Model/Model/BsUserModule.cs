

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户权限 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserModule:BaseModel
	{   
		 
		private string _operId;  //操作员ID,BsUser.Id
		
		private string _moduleId;  //窗口权限,对应GblModule.Id

        private DateTime _modiTime;//行心云:最后修改时间

        private string _modiOperId;//行心云:最后修改人

        private int _HospitalID;//医院ID

        private int _iconIndex;  //图标类型
		  
		/// <summary>
		/// 操作员ID,BsUser.Id
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 窗口权限,对应GblModule.Id
		/// </summary>
		public string ModuleId
		{
			get { return _moduleId;}
			set { _moduleId = value;}
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
        /// 最后修改时间.
        /// </summary>
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }

        /// <summary>
        /// 最后修改人.
        /// </summary>
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }
     
    }  
}           


