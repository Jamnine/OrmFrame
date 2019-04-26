

using System;
namespace Orm.Model
{
	/// <summary>
	/// 设备管理 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsItemEquipment : BaseModel
	{   
		 
		private string _itemId;  //项目ID
		
		private int _lsEqType;  //设备类别：1-医疗设备;2-专用设备;3-通用设备;4-电子产品及通讯设备;5-电器设备;6-器仪表计量标准
		
		private string _eqTypeId;  //
		
		private string _eqType;  //型号
		
		private string _seriesNo;  //主机系列号
		
		private string _brand;  //品牌
		
		private string _countryId;  //国别
		
		private int _lsEqClass;  //设备等级：1-A级;2-B级;3-C级
		
		private int _underLine;  //最小工作量
		
		private string _unitId;  //工作量单位
		
		private int _costPercent;  //成本消耗比
		
		private int _alarmLine;  //警戒收入
		
		private bool _isCalProfit;  //是否效益分析
		
		private bool _isMutiTotality;  //是否允许同一批多台合并数量
		
		private string _useArea;  //用途
		
		private string _manuId;  //生产商
		
		private string _useMemo;  //详细用途
		
		private string _memo;  //备注
		
		private int _HospitalID;  //

        public BsItemEquipment() { }
         
		/// <summary>
		/// 项目ID
		/// </summary>
		public string ItemId
		{
			get { return _itemId;}
			set { _itemId = value;}
		}                                    
		
		/// <summary>
		/// 设备类别：1-医疗设备;2-专用设备;3-通用设备;4-电子产品及通讯设备;5-电器设备;6-器仪表计量标准
		/// </summary>
		public int LsEqType
		{
			get { return _lsEqType;}
			set { _lsEqType = value;}
		}                                    
		
		/// <summary>
		/// 
		/// </summary>
		public string EqTypeId
		{
			get { return _eqTypeId;}
			set { _eqTypeId = value;}
		}                                    
		
		/// <summary>
		/// 型号
		/// </summary>
		public string EqType
		{
			get { return _eqType;}
			set { _eqType = value;}
		}                                    
		
		/// <summary>
		/// 主机系列号
		/// </summary>
		public string SeriesNo
		{
			get { return _seriesNo;}
			set { _seriesNo = value;}
		}                                    
		
		/// <summary>
		/// 品牌
		/// </summary>
		public string Brand
		{
			get { return _brand;}
			set { _brand = value;}
		}                                    
		
		/// <summary>
		/// 国别
		/// </summary>
		public string CountryId
		{
			get { return _countryId;}
			set { _countryId = value;}
		}                                    
		
		/// <summary>
		/// 设备等级：1-A级;2-B级;3-C级
		/// </summary>
		public int LsEqClass
		{
			get { return _lsEqClass;}
			set { _lsEqClass = value;}
		}                                    
		
		/// <summary>
		/// 最小工作量
		/// </summary>
		public int UnderLine
		{
			get { return _underLine;}
			set { _underLine = value;}
		}                                    
		
		/// <summary>
		/// 工作量单位
		/// </summary>
		public string UnitId
		{
			get { return _unitId;}
			set { _unitId = value;}
		}                                    
		
		/// <summary>
		/// 成本消耗比
		/// </summary>
		public int CostPercent
		{
			get { return _costPercent;}
			set { _costPercent = value;}
		}                                    
		
		/// <summary>
		/// 警戒收入
		/// </summary>
		public int AlarmLine
		{
			get { return _alarmLine;}
			set { _alarmLine = value;}
		}                                    
		
		/// <summary>
		/// 是否效益分析
		/// </summary>
		public bool IsCalProfit
		{
			get { return _isCalProfit;}
			set { _isCalProfit = value;}
		}                                    
		
		/// <summary>
		/// 是否允许同一批多台合并数量
		/// </summary>
		public bool IsMutiTotality
		{
			get { return _isMutiTotality;}
			set { _isMutiTotality = value;}
		}                                    
		
		/// <summary>
		/// 用途
		/// </summary>
		public string UseArea
		{
			get { return _useArea;}
			set { _useArea = value;}
		}                                    
		
		/// <summary>
		/// 生产商
		/// </summary>
		public string ManuId
		{
			get { return _manuId;}
			set { _manuId = value;}
		}                                    
		
		/// <summary>
		/// 详细用途
		/// </summary>
		public string UseMemo
		{
			get { return _useMemo;}
			set { _useMemo = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			get { return _memo;}
			set { _memo = value;}
		}                                    
		
		                                 
		        
	}  
}           


