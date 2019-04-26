

using System;
namespace Orm.Model
{
	/// <summary>
	/// 整散比 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsUnitRatio:BaseModel
	{   
		 
		private string _itemId;  //项目ID
		
		private string _unitId1;  //拆散后单位（目标单位）
		
		private string _unitId2;  //拆散前单位（原单位）
		
		private double _drugRatio;  //拆散比例
        private DateTime _modiTime;
        private string _modiOperId;
        private int _iconIndex;  //图标类型

        #region
        private string _ratioUnitNmae1;
        private string _ratioUnitNmae2;
        private double _drugRatioName;
        public string RatioUnitNmae1
        {
            get { return this._ratioUnitNmae1; }
            set { this._ratioUnitNmae1 = value; }
        }
        public string RatioUnitNmae2
        {
            get { return this._ratioUnitNmae2; }
            set { this._ratioUnitNmae2 = value; }
        }
        public double DrugRatioName
        {
            get { return this._drugRatio; }
            set { this._drugRatio = value; }
        }
        #endregion
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

        /// <summary>
        /// 项目ID
        /// </summary>
        public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 拆散后单位（目标单位）
		/// </summary>
		public string UnitId1
		{
			get { return _unitId1;}
			set { _unitId1 = value;}
		}                                    
		
		/// <summary>
		/// 拆散前单位（原单位）
		/// </summary>
		public string UnitId2
		{
			get { return _unitId2;}
			set { _unitId2 = value;}
		}                                    
		
		/// <summary>
		/// 拆散比例
		/// </summary>
		public double DrugRatio
		{
			get { return _drugRatio;}
			set { _drugRatio = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}                                    
		        
	}  
}           


