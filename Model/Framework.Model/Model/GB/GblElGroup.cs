

using System;
namespace XYHis.Model
{
	/// <summary>
	/// 健康档案分组 - 实体类***********
	/// </summary>
	[Serializable]
	public partial class GblElGroup : BaseModel
    {   
		
		
		
		private int _lsType;  //档案类别：1-基础档案；2-儿童保健；3-妇女保健；4-疾病控制；5-疾病管理
		
		private string _code;  //编码
		
		private string _name;  //名称
		
		private int _orderBy;  //显示顺序
		
		private bool _isActive;  //有效标志
		
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
		public bool IsActive
		{
			get { return _isActive;}
			set { _isActive = value;}
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


