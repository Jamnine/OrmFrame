

using System;
namespace Orm.Model
{
	/// <summary>
	/// 手术类型 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsOPS:BaseModel
	{   
		 
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //排序
		
		private bool _isActive;  //是否有效标识
		
		private int _iconIndex;  //图标类型
		
		private int _lsClass;  //切口分级：1-清洁；2-清洁-污染；3-污染
		
		private int _lsASA;  //ASA评分：1-I级;2-II级;3-III级;4-IV级;5-V级
		
		private bool _isEmergency;  //是否急诊手术
		
		private string _anaesId;  //麻醉类型
		
		private int _minutes;  //手术时间
		
		private bool _isImplant;  //是否植入物
		
		private bool _isImglass;  //是否内镜手术
		
		private bool _isOPSDrug;  //是否围术期用药
		
		private double _dangerPoint;  //危险等级

        private int _HospitalID;//医院ID

         
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
		/// 拼音码
		/// </summary>
		public string PyCode
		{
			get { return _pyCode;}
			set { _pyCode = value;}
		}                                    
		
		/// <summary>
		/// 五笔码
		/// </summary>
		public string WbCode
		{
			get { return _wbCode;}
			set { _wbCode = value;}
		}                                    
		
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderBy
		{
			get { return _orderBy;}
			set { _orderBy = value;}
		}                                    
		
		/// <summary>
		/// 是否有效标识
		/// </summary>
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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
		/// 切口分级：1-清洁；2-清洁-污染；3-污染
		/// </summary>
		public int LsClass
		{
			get { return _lsClass;}
			set { _lsClass = value;}
		}                                    
		
		/// <summary>
		/// ASA评分：1-I级;2-II级;3-III级;4-IV级;5-V级
		/// </summary>
		public int LsASA
		{
			get { return _lsASA;}
			set { _lsASA = value;}
		}                                    
		
		/// <summary>
		/// 是否急诊手术
		/// </summary>
		public bool IsEmergency
		{
			get { return _isEmergency;}
			set { _isEmergency = value;}
		}                                    
		
		/// <summary>
		/// 麻醉类型
		/// </summary>
		public string AnaesId
		{
			get { return _anaesId;}
			set { _anaesId = value;}
		}                                    
		
		/// <summary>
		/// 手术时间
		/// </summary>
		public int Minutes
		{
			get { return _minutes;}
			set { _minutes = value;}
		}                                    
		
		/// <summary>
		/// 是否植入物
		/// </summary>
		public bool IsImplant
		{
			get { return _isImplant;}
			set { _isImplant = value;}
		}                                    
		
		/// <summary>
		/// 是否内镜手术
		/// </summary>
		public bool IsImglass
		{
			get { return _isImglass;}
			set { _isImglass = value;}
		}                                    
		
		/// <summary>
		/// 是否围术期用药
		/// </summary>
		public bool IsOPSDrug
		{
			get { return _isOPSDrug;}
			set { _isOPSDrug = value;}
		}                                    
		
		/// <summary>
		/// 危险等级
		/// </summary>
		public double DangerPoint
		{
			get { return _dangerPoint;}
			set { _dangerPoint = value;}
		}
 
    }  
}           


