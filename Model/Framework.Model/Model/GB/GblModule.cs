

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 窗口权限设置 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblModule : BaseModel
    {   
		
		
		
		private int _functionID;  //菜单权限GblSystemFunction.id
		
		private int _menuId;  //菜单ID
		
		private int _orderBy;  //排序
		
		private string _memo;  //备注
		
		private int _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _hospitalId;  //

        private string _powerName; //行心云:子权限名称

        /// <summary>
        /// 唯一标识
        /// </summary>
        public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 菜单权限GblSystemFunction.id
		/// </summary>
		public int FunctionID
		{
			get { return _functionID;}
			set { _functionID = value;}
		}                                    
		
		/// <summary>
		/// 菜单ID
		/// </summary>
		public int MenuId
		{
			get { return _menuId;}
			set { _menuId = value;}
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
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public int ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}

        /// <summary>
        /// 行心云:子权限名称
        /// </summary>
        public string PowerName
        {
            get { return _powerName; }
            set { _powerName = value; }
        }


    }  
}           


