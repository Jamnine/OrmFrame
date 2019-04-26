

using System;
namespace Orm.Model
{
	/// <summary>
	/// 限额 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsLimitGroup:BaseModel
	{    
		private string _code;  //公费限额类别ID
		
		private string _name;  //限额组
		
		private string _patTypeId;  //对应病人类别
		
		private string _typeGFXEId;  //公费限额类别
		
		private double _limitFeeMz;  //限额
		
		private double _limitFeeZy;  //住院限额
		
		private string _lsLimitType;  //限额类别：1-每天限额；2-每次限额
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _docLevelId;  //职称对应BsDocLevel.Id

        private int _HospitalID;//医院ID
         
		/// <summary>
		/// 公费限额类别ID
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 限额组
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 对应病人类别
		/// </summary>
		public string PatTypeId
		{
			get { return _patTypeId;}
			set { _patTypeId = value;}
		}                                    
		
		/// <summary>
		/// 公费限额类别
		/// </summary>
		public string TypeGFXEId
		{
			get { return _typeGFXEId;}
			set { _typeGFXEId = value;}
		}                                    
		
		/// <summary>
		/// 限额
		/// </summary>
		public double LimitFeeMz
		{
			get { return _limitFeeMz;}
			set { _limitFeeMz = value;}
		}                                    
		
		/// <summary>
		/// 住院限额
		/// </summary>
		public double LimitFeeZy
		{
			get { return _limitFeeZy;}
			set { _limitFeeZy = value;}
		}                                    
		
		/// <summary>
		/// 限额类别：1-每天限额；2-每次限额
		/// </summary>
		public string LsLimitType
		{
			get { return _lsLimitType;}
			set { _lsLimitType = value;}
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
		/// 职称对应BsDocLevel.Id
		/// </summary>
		public string DocLevelId
		{
			get { return _docLevelId;}
			set { _docLevelId = value;}
		}

    }  
}           


