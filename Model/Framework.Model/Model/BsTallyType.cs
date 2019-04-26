

using System;
namespace Orm.Model
{
	/// <summary>
	/// 病人类别二级分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsTallyType:BaseModel
	{   
		 
		private string _code;  //记帐方式ID
		
		private string _name;  //记帐方式
		
		private string _tallyGroupId;  //公医类别ID
		
		private string _pyCode;  //拼单码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
         
        private DateTime _modiTime;
        private string _modiOperId;
        private int _HospitalID;//医院ID

         
        /// <summary>
        /// 记帐方式ID.
        /// </summary>
        [Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// 记帐方式.
        /// </summary>
        [Collumn(HeaderName = "名称", RelatedTableType = null, Length = 50)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// 公医类别ID.
        /// </summary>
        [Collumn(HeaderName = "公医类别", RelatedTableType = typeof(BsTallyGroup))]
        public string TallyGroupId
        {
            get
            {
                return this._tallyGroupId;
            }
            set
            {
                this._tallyGroupId = value;
            }
        }

        /// <summary>
        /// 拼单码.
        /// </summary>
        [Collumn(HeaderName = "拼单码", RelatedTableType = null)]
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// 五笔码.
        /// </summary>
        [Collumn(HeaderName = "五笔码", RelatedTableType = null)]
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// 显示顺序.
        /// </summary>
        [Collumn(HeaderName = "显示顺序", RelatedTableType = null)]
        public int OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy = value;
            }
        }

        /// <summary>
        /// 有效标志.
        /// </summary>
        [Collumn(HeaderName = "有效标志", RelatedTableType = null)]
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// 图标索引
        /// </summary>
        [Collumn(HeaderName = "图标", IsShow = false, RelatedTableType = null)]
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex = value;
            }
        }

        /// <summary>
        /// 最后修改时间.
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
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
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
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


