

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 健教处方 - 实体类
	/// </summary>
	[Serializable]
	public partial class BsHealthEduRec : BaseModel
    {   
		
		
		
		private string _code;  //健教处方编码
		
		private int _healthEduRec;  //健教处方号
		
		private string _name;  //健教处方名称
		
		private string _rmark;  //备注
		
		private string _pyCode;  //拼音码
		
		private string _wbCode;  //五笔码
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
		private bool _idleFlag;  //删除标志
		
		private int _iconIndex;  //图标类型
		
		private int _hospitalId;  //
		 

		
		/// <summary>
		/// 唯一标识
		/// </summary>
		public int Id
		{
			get { return _id;}
			set { _id = value;}
		}                                    
		
		/// <summary>
		/// 健教处方编码
		/// </summary>
		public string Code
		{
			get { return _code;}
			set { _code = value;}
		}                                    
		
		/// <summary>
		/// 健教处方号
		/// </summary>
		public int HealthEduRec
		{
			get { return _healthEduRec;}
			set { _healthEduRec = value;}
		}                                    
		
		/// <summary>
		/// 健教处方名称
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 备注
		/// </summary>
		public string Rmark
		{
			get { return _rmark;}
			set { _rmark = value;}
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
		/// 删除标志
		/// </summary>
		public bool IdleFlag
		{
			get { return _idleFlag;}
			set { _idleFlag = value;}
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
		/// 
		/// </summary>
		public int HospitalId
		{
			get { return _hospitalId;}
			set { _hospitalId = value;}
		}                                    
		        
	}  
}           


