

using System;
namespace Orm.Model
{
	/// <summary>
	/// 用户对应科室 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUserLocation:BaseModel
	{    
		private string _operId;  //用户名
		
		private string _locationId;  //所属科室
		
		private int _iconIndex;  //图标类型

        private bool _isNoinrecipe;//  行心云:F3禁止住院处方权
        private DateTime _modiTime;//行心云:最后修改时间
        private string  _modiOperId;//行心云:最后修改人
        private int _HospitalID;//医院ID

        private bool _isNoOutRecipe ; //行心云:F2禁止门诊处方权

        private int _hisType;//产品类型

        /// <summary>
        /// 行心云:F2禁止门诊处方权
        /// </summary>
        public bool IsNoOutRecipe
        {
            get { return _isNoOutRecipe ; }
            set { _isNoOutRecipe  = value; }
        }


        public bool IsNoInRecipe
        {
            get { return _isNoinrecipe ; }
            set { _isNoinrecipe  = value; }
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
        public string  ModiOperId
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
    
                                        
		
		/// <summary>
		/// 用户名
		/// </summary>
		public string OperId
		{
			get { return _operId;}
			set { _operId = value;}
		}                                    
		
		/// <summary>
		/// 所属科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
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
        /// 0为共享，1为HIS ，2为行心云
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }
    }  
}           


