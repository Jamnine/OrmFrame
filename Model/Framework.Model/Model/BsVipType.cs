

using System;
namespace Orm.Model
{
	/// <summary>
	///  - 实体类
	/// </summary>
	[Serializable]
	public partial class BsVipType : BaseModel
    {   
		 
		private string _name;  //名称:1会员消费卡（次卡只有赠送项目没有余额）2会员储值卡
		
		private int _orderBy;  //顺序
		
		private bool _isActive;  //是否有效标识

        public BsVipType() { }
         
		/// <summary>
		/// 名称:1会员消费卡（次卡只有赠送项目没有余额）2会员储值卡
		/// </summary>
		public string Name
		{
			get { return _name;}
			set { _name = value;}
		}                                    
		
		/// <summary>
		/// 顺序
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
		        
	}  
}           


