

using System;
namespace Orm.Model
{
	/// <summary>
	/// 健康档案分组 - 实体类
	/// </summary>
	[Serializable]
	public partial class GblElGroup : BaseModel
    {   
		 
		private int _lsType;  //档案类别：1-基础档案；2-儿童保健；3-妇女保健；4-疾病控制；5-疾病管理
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _orderBy;  //显示顺序
		
		private int _isActive;  //有效标志
		
		private int _HospitalID;  //

        private int _hisType;

        DateTime _insertTime;
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InsertTime
        {
            get { return _insertTime; }
            set { _insertTime = value; }
        }

        /// <summary>
        /// his类别
        /// </summary>
        public int HisType
        {
            get { return _hisType; }
            set { _hisType = value; }
        }



        /// <summary>
        /// 档案类别：1-基础档案；2-儿童保健；3-妇女保健；4-疾病控制；5-疾病管理
        /// </summary>
        public int LsType
		{
			get { return _lsType;}
			set { _lsType = value;}
		}                                    
		
		/// <summary>
		/// 编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 显示顺序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 有效标志
		/// </summary>
		public int IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
		}                                    
		
	                                  
		        
	}  
}           


