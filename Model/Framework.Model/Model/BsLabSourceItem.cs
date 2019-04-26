

using System;
namespace Orm.Model
{
	/// <summary>
	/// 检验附加项目 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLabSourceItem:BaseModel
	{   
		 
		private string _sourceId;  //标本来源
		
		private string _tubeTypeId;  //容器
		
		private string _itemId;  //附加项目
		
		private double _totality;  //一个主项目需要多少个附加项目？
		
		private int _lsUseArea;  //特定用途：1-门诊；2-住院；3-所有
		
		private bool _isOnlyUseOne;  //只收一次

        private bool _isActive;  //是否有效标识 

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 标本来源
		/// </summary>
		public string SourceId
		{
			get { return _sourceId;}
			set { _sourceId = value;}
		}                                    
		
		/// <summary>
		/// 容器
		/// </summary>
		public string TubeTypeId
		{
			get { return _tubeTypeId;}
			set { _tubeTypeId = value;}
		}                                    
		
		/// <summary>
		/// 附加项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 一个主项目需要多少个附加项目？
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 特定用途：1-门诊；2-住院；3-所有
		/// </summary>
		public int LsUseArea
		{
			get { return _lsUseArea;}
			set { _lsUseArea = value;}
		}                                    
		
		/// <summary>
		/// 只收一次
		/// </summary>
		public bool IsOnlyUseOne
		{
			get { return _isOnlyUseOne;}
			set { _isOnlyUseOne = value;}
		}
        /// <summary>
        /// 是否有效标识
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        } 
  

        private string _itemName;
        /// <summary>
        /// 用法附加项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

    }  
}           


