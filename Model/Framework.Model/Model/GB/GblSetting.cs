

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 系统参数 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblSetting : BaseModel
    {   
		
		
		
		private string _keyNum;  //键名称
		
		private string _setValue;  //键值
		
		private string _explain;  //解释
		
		private int _piority;  //重要级别
		
		private string _basetable;  //对应基本表
		
		private bool _isMutiselect;  //是否允许多选
		
		private int _systemId;  //所属系统
		
		private DateTime _modiTime;  //最后修改时间
		
		private int _modiOperId;  //最后修改人
		
		private string _describtion;  //行心云:F1描述2
		
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
		/// 键名称
		/// </summary>
		public string KeyNum
		{
			get { return _keyNum;}
			set { _keyNum = value;}
		}                                    
		
		/// <summary>
		/// 键值
		/// </summary>
		public string SetValue
		{
			get { return _setValue;}
			set { _setValue = value;}
		}                                    
		
		/// <summary>
		/// 解释
		/// </summary>
		public string Explain
		{
			get { return _explain;}
			set { _explain = value;}
		}                                    
		
		/// <summary>
		/// 重要级别
		/// </summary>
		public int Piority
		{
			get { return _piority;}
			set { _piority = value;}
		}                                    
		
		/// <summary>
		/// 对应基本表
		/// </summary>
		public string Basetable
		{
			get { return _basetable;}
			set { _basetable = value;}
		}                                    
		
		/// <summary>
		/// 是否允许多选
		/// </summary>
		public bool IsMutiselect
		{
			get { return _isMutiselect;}
			set { _isMutiselect = value;}
		}                                    
		
		/// <summary>
		/// 所属系统
		/// </summary>
		public int SystemId
		{
			get { return _systemId;}
			set { _systemId = value;}
		}                                    
		
		/// <summary>
		/// 最后修改时间
		/// </summary>
		public DateTime ModiTime
		{
			get { return _modiTime;}
			set { _modiTime = value;}
		}                                    
		
		/// <summary>
		/// 最后修改人
		/// </summary>
		public int ModiOperId
		{
			get { return _modiOperId;}
			set { _modiOperId = value;}
		}                                    
		
		/// <summary>
		/// 行心云:F1描述2
		/// </summary>
		public string Describtion
		{
			get { return _describtion;}
			set { _describtion = value;}
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


