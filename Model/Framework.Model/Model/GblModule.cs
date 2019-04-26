

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
	/// <summary>
	/// 窗口权限设置 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblModule : BaseModel
    {    
		private string _functionID;  //菜单权限GblSystemFunction.id
		
		private string _menuId;  //菜单ID
		
		private int _orderBy;  //排序
		
		private string _memo;  //备注
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //

        private string _powerName; //行心云:子权限名称
         
		/// <summary>
		/// 菜单权限GblSystemFunction.id
		/// </summary>
		public string FunctionID
		{
			get { return _functionID;}
			set { _functionID = value;}
		}                                    
		
		/// <summary>
		/// 菜单ID
		/// </summary>
		public string MenuId
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
		public string ModiOperId
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
        /// 行心云:子权限名称
        /// </summary>
        public string PowerName
        {
            get { return _powerName; }
            set { _powerName = value; }
        }


        private int _hisType;
        /// <summary>
        /// 系统产品类型 0 公共，1 his， 2 行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }
        private bool _isOrmType = false;
        public bool u_IsOrmType
        {
            get
            {
                if (HisType == (int)EnumSystemProductType.OrmType)
                {
                    _isOrmType = true;
                }
                else
                {
                    _isOrmType = false;
                }
                return _isOrmType;
            }
            set { _isOrmType = value; }
        }
    }  
}           


