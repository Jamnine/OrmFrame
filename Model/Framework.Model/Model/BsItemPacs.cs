

using System;
namespace Orm.Model
{
	/// <summary>
	/// 影像项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemPacs : BaseModel
    {    
		private string _itemId;  //项目
		
		private int _xType;  //申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		
		private string _equipment;  //检查设备
		
		private string _checkBody;  //部位
		
		private int _iconIndex;  //图标类型

        public BsItemPacs() { }
         
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 申请类别：1-CT；2-DR；3-MR；4-CR；5-RF；6-US；7-脑电图；8-心电图；9-镜检查；10-MG；11-DSA；12-普放；13-病理；14-其它
		/// </summary>
		public int XType
		{
			get { return _xType;}
			set { _xType = value;}
		}                                    
		
		/// <summary>
		/// 检查设备
		/// </summary>
		public string Equipment
		{
			get { return _equipment;}
			set { _equipment = value;}
		}                                    
		
		/// <summary>
		/// 部位
		/// </summary>
		public string CheckBody
		{
			get { return _checkBody;}
			set { _checkBody = value;}
		}                                    
		
		/// <summary>
		/// 图标类型
		/// </summary>
		public int IconIndex
		{
			get { return _iconIndex;}
			set { _iconIndex = value;}
		}

        private int _hisType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public int HisType
        {
            get
            {
                return _hisType;
            }

            set
            {
                _hisType = value;
            }
        }
        private DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get
            {
                return _insertTime;
            }

            set
            {
                _insertTime = value;
            }
        }

    }  
}           


