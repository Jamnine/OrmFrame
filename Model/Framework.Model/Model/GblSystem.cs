

using System;
using Orm.Model.EnumDefine;

namespace Orm.Model
{
	/// <summary>
	/// 系统一级菜单 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblSystem : BaseModel
    {   
		 
		private string _name;  //名称
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private string _modiOperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private int _HospitalID;  //
		                                   
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
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


