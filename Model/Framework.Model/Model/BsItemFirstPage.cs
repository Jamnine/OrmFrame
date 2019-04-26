

using System;
namespace Orm.Model
{
	/// <summary>
	/// 项目对应病案首页的费用类别表 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemFirstPage : BaseModel
    {   
		
		private string _itemId;  //项目ID
		
		private string _psFeeId;  //病案首页的费用类别

        public BsItemFirstPage() { }
         
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 病案首页的费用类别
		/// </summary>
		public string PsFeeId
		{
			get { return _psFeeId;}
			set { _psFeeId = value;}
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


