

using System;
namespace Orm.Model
{
	/// <summary>
	/// 减号套餐明细表 - 实体类
	/// </summary>
	[Serializable]
    public partial class BsXdRpDtl : BaseModel
    {   
		 
		private string _xdRpId;  //协定处方ID
		
		private int _groupNum;  //组号
		
		private string _itemId;  //项目ID,BsItem.Id
		
		private double _dosage;  //用量
		
		private string _unitTakeId;  //服用单位
		
		private string _frequencyId;  //频率，对应BsFrequency.Id
		
		private string _usageId;  //用法
		
		private int _days;  //天数
		
		private string _execLocId;  //执行科室
		
		private string _memo;  //备注
		
		private double _feeTotality;  //总量
		
		private string _unitId;  //计价单位
		
		private double _discountAoumt;  //折扣金额
		
		private string _modioperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		
		private double _listNum;  //行心云:F3处方号
		
		private double _limittoTalzy;  //行心云:F2门诊整包装
		
		private string _grouptIp;  //行心云:F1组“|”标示
		
		private int _HospitalID;  //
		private int _cookType;  //

        public BsXdRpDtl() { }
         
		/// <summary>
		/// 协定处方ID
		/// </summary>
		public string XdRpId
		{
			get { return _xdRpId;}
			set { _xdRpId = value;}
		}                                    
		
		/// <summary>
		/// 组号
		/// </summary>
		public int  GroupNum
		{
			get { return _groupNum;}
			set { _groupNum = value;}
		}                                    
		
		/// <summary>
		/// 项目ID,BsItem.Id
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 用量
		/// </summary>
		public double Dosage
		{
			get { return _dosage;}
			set { _dosage = value;}
		}                                    
		
		/// <summary>
		/// 服用单位
		/// </summary>
		public string UnitTakeId
		{
			get { return _unitTakeId;}
			set { _unitTakeId = value;}
		}                                    
		
		/// <summary>
		/// 频率，对应BsFrequency.Id
		/// </summary>
		public string FrequencyId
		{
			get { return _frequencyId;}
			set { _frequencyId = value;}
		}                                    
		
		/// <summary>
		/// 用法
		/// </summary>
		public string UsageId
		{
			get { return _usageId;}
			set { _usageId = value;}
		}                                    
		
		/// <summary>
		/// 天数
		/// </summary>
		public int Days
		{
			get { return _days;}
			set { _days = value;}
		}                                    
		
		/// <summary>
		/// 执行科室
		/// </summary>
		public string ExecLocId
		{
			get { return _execLocId;}
			set { _execLocId = value;}
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
		/// 总量
		/// </summary>
		public double FeeTotality
		{
			get { return _feeTotality;}
			set { _feeTotality = value;}
		}                                    
		
		/// <summary>
		/// 计价单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double DiscountAoumt
		{
			get { return _discountAoumt;}
			set { _discountAoumt = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string ModioperId
		{
			get { return _modioperId;}
			set { _modioperId = value;}
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
		/// 行心云:F3处方号
		/// </summary>
		public double ListNum
		{
			get { return _listNum;}
			set { _listNum = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F2门诊整包装
		/// </summary>
		public double LimittoTalzy
		{
			get { return _limittoTalzy;}
			set { _limittoTalzy = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1组“|”标示
		/// </summary>
		public string GrouptIp
		{
			get { return _grouptIp;}
			set { _grouptIp = value;}
		}                                    
		

		public int CookType
        {
			get { return _cookType; }
			set { _cookType = value;}
		}

        public string TmpRecipeEmrID
        {
            get
            {
                return _TmpRecipeEmrID;
            }

            set
            {
                _TmpRecipeEmrID = value;
            }
        }


        ///// <summary>
        ///// 项目名称
        ///// </summary>
        //public string Name { get; set; }

        ///// <summary>
        ///// 总金额
        ///// </summary>
        //public double Amount { get; set; }

        ///// <summary>
        ///// 所在机构ID
        ///// </summary>
        //public int HospitalID { get; set; }

        private string _TmpRecipeEmrID;
    }  
}           


