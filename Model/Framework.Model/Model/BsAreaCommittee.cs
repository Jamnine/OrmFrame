

using System;
namespace Orm.Model
{
	/// <summary>
	/// 村、居委会 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsAreaCommittee : BaseModel
    {   
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private string _areaId;  //地区编码
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private int _iconIndex;  //图标类型
		
		private string _policeStationId;  //镇
		
		private string _upCode;  //行心云:上报码
		
		private string _ybCode;  //行心云:医保码
		
		private string _moDioperId;  //行心云:最后修改人
		
		private DateTime _modiTime;  //行心云:最后修改时间
		

        public BsAreaCommittee() { }

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
		/// 地区编码
		/// </summary>
		public string AreaId
		{
			get { return _areaId;}
			set { _areaId = value;}
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
		/// 镇
		/// </summary>
		public string PoliceStationId
		{
			get { return _policeStationId;}
			set { _policeStationId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:上报码
		/// </summary>
		public string UpCode
		{
			get { return _upCode;}
			set { _upCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:医保码
		/// </summary>
		public string YbCode
		{
			get { return _ybCode;}
			set { _ybCode = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改人
		/// </summary>
		public string MoDioperId
		{
			get { return _moDioperId;}
			set { _moDioperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                                               
		        
	}  
}           


