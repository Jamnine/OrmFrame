

using System;
namespace Orm.Model
{
	/// <summary>
	/// 住院每天固定收费项目(针对科室或全院) - 实体类
	/// </summary>
	[Serializable]
	public partial class InDayCharge : BaseModel
	{   
		 
		private string _itemId;  //项目
		
		private string _patTypeId;  //特定的病人类别
		
		private string _locationId;  //特定的科室
		
		private DateTime _beginTime;  //开始时间
		
		private double _totality;  //发生数量
		
		private string _unitId;  //发生单位
		
		private bool _isAuthed;  //已经封存，不可改删
		
		private int _HospitalID;  //

        public InDayCharge() { }
                                    
		
		/// <summary>
		/// 项目
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 特定的病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 特定的科室
		/// </summary>
		public string LocationId
		{
			get { return _locationId;}
			set { _locationId = value;}
		}                                    
		
		/// <summary>
		/// 开始时间
		/// </summary>
		public DateTime BeginTime
		{
			get { return _beginTime;}
			set { _beginTime = value;}
		}                                    
		
		/// <summary>
		/// 发生数量
		/// </summary>
		public double Totality
		{
			get { return _totality;}
			set { _totality = value;}
		}                                    
		
		/// <summary>
		/// 发生单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 已经封存，不可改删
		/// </summary>
		public bool IsAuthed
		{
			get { return _isAuthed;}
			set { _isAuthed = value;}
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


